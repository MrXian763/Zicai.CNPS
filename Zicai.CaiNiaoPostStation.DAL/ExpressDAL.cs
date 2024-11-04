using Common;
using Helper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZiCai.CainiaoPostStation.DAL.Base;
using ZiCai.CainiaoPostStation.Models;

namespace Zicai.CaiNiaoPostStation.DAL
{
    public class ExpressDAL : BaseDAL<ExpressInfo>
    {
        /// <summary>
        /// 获取指定货架上的快递数量
        /// </summary>
        /// <param name="shelfId">货架ID</param>
        /// <returns>快递数量</returns>
        public int GetExpressCount(int shelfId)
        {
            string sql = $"select count(1) from ExpressInfos where ShelfId = {shelfId} and IsDeleted=0  and ExpState in ('已入库','未取件')";
            return SelectAndReIntValue(sql);
        }

        /// <summary>
        /// 检查快递单号是否存在
        /// </summary>
        /// <param name="expNumber">快递单号</param>
        /// <returns></returns>
        public bool ExistExpressNumber(string expNumber)
        {
            return ExistsByName("ExpNumber", expNumber);
        }

        /// <summary>
        /// 添加快递信息
        /// </summary>
        /// <param name="expInfo">快递信息</param>
        /// <param name="selfPick">自提方式</param>
        /// <returns>添加成功的快递信息ID</returns>
        public int AddExpressInfo(ExpressInfo expInfo, ExpSelfPickInfo selfPick = null)
        {
            string cols = CreateSql.GetColNames<ExpressInfo>("ExpId"); // 获取实体所有列名，除了 ExpId
            if (selfPick == null)
            {
                return Add(expInfo, cols, 1); // 不包含自提信息，直接新增
            }
            else // 自提快递
            {
                // 操作有先后顺序 执行事务保证原子性
                return SqlHelper.ExecuteTrans<int>(cmd =>
                {
                    try
                    {
                        // 添加快递信息
                        SqlModel insertExpModel = CreateSql.CreateInsertSql(expInfo, cols, 1);
                        cmd.CommandText = insertExpModel.Sql;
                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.AddRange(insertExpModel.Paras);
                        object oExpId = cmd.ExecuteScalar(); // 执行添加快递信息命令，返回新添的快递主键
                        cmd.Parameters.Clear();
                        int expId = 0;
                        expId = oExpId.GetInt();
                        if (expId > 0)
                        {
                            // 快递信息添加成功，添加自提记录
                            selfPick.ExpId = expId;
                            string cols_self = "ExpId,PickingCode";
                            SqlModel insertSelfModel = CreateSql.CreateInsertSql(selfPick, cols_self, 0);
                            cmd.CommandText = insertSelfModel.Sql;
                            cmd.CommandType = CommandType.Text;
                            cmd.Parameters.AddRange(insertSelfModel.Paras);
                            cmd.ExecuteNonQuery(); // 执行添加自提记录命令
                            cmd.Parameters.Clear();

                            // 设置快递状态 ：未提取
                            cmd.CommandText = "update ExpressInfos set ExpState='未取件' where ExpId=" + expId;
                            cmd.CommandType = CommandType.Text;
                            cmd.ExecuteNonQuery();
                        }
                        cmd.Transaction.Commit(); // 提交事务
                        return expId;
                    }
                    catch (Exception ex)
                    {
                        cmd.Transaction.Rollback(); // 回滚事务
                        throw new Exception("执行添加快递事件异常！", ex);
                    }
                });
            }
        }

        /// <summary>
        /// 修改快递信息，改为自提或还是派送
        /// </summary>
        /// <param name="expInfo">快递信息</param>
        /// <param name="selfPick">自提、派送</param>
        /// <returns></returns>
        public bool UpdateExpressInfo(ExpressInfo expInfo, ExpSelfPickInfo selfPick = null)
        {
            string cols = CreateSql.GetColNames<ExpressInfo>("EnterTime"); // 获取实体所有列名，除了EnterTime
            if (selfPick == null)
            {
                return Update(expInfo, cols); // 派送
            }
            else
            {
                List<CommandInfo> comList = new List<CommandInfo>();
                SqlModel editExpModel = CreateSql.CreateUpdateSql(expInfo, cols, "");
                // 修改快递信息
                comList.Add(new CommandInfo()
                {
                    CommandText = editExpModel.Sql,
                    IsProc = false,
                    Paras = editExpModel.Paras
                });
                if (selfPick.PickUpId == 0) // 添加自提记录
                {
                    selfPick.ExpId = expInfo.ExpId;
                    string cols_self = "ExpId,PickingCode"; // 新增时排除列
                    SqlModel insertSelfModel = CreateSql.CreateInsertSql(selfPick, cols_self, 0);
                    // 添加自提记录
                    comList.Add(new CommandInfo()
                    {
                        CommandText = insertSelfModel.Sql,
                        IsProc = false,
                        Paras = insertSelfModel.Paras
                    });
                    // 更新快递状态
                    comList.Add(new CommandInfo()
                    {
                        CommandText = "update ExpressInfos set ExpState='未取件' where ExpId=" + expInfo.ExpId,
                        IsProc = false
                    });
                }
                else
                {
                    // 更新取件码
                    string updatesql = "update ExpSelfPickInfos set PickingCode=@code where ExpId=" + expInfo.ExpId;
                    SqlParameter[] paraCode = { new SqlParameter("@code", selfPick.PickingCode) };
                    comList.Add(new CommandInfo()
                    {
                        CommandText = updatesql,
                        IsProc = false,
                        Paras = paraCode
                    });
                }
                return SqlHelper.ExecuteTrans(comList);
            }
        }

        /// <summary>
        /// 修改快递信息，并删除之前的自提记录
        /// </summary>
        /// <param name="expInfo">快递信息</param>
        /// <param name="selfPickId">自提记录ID</param>
        /// <returns></returns>
        public bool UpdateExpressInfo(ExpressInfo expInfo, int selfPickId)
        {
            string cols = CreateSql.GetColNames<ExpressInfo>("EnterTime");
            List<CommandInfo> comList = new List<CommandInfo>(); // 要执行的SQL命令列表
            SqlModel editExpModel = CreateSql.CreateUpdateSql(expInfo, cols, "");
            // 修改快递信息
            comList.Add(new CommandInfo()
            {
                CommandText = editExpModel.Sql,
                IsProc = false,
                Paras = editExpModel.Paras
            });
            // 删除该快递的自提记录
            comList.Add(new CommandInfo()
            {
                CommandText = CreateSql.CreateDeleteSql<ExpSelfPickInfo>("PickUpId=" + selfPickId),
                IsProc = false
            });
            // 更新快递状态
            comList.Add(new CommandInfo()
            {
                CommandText = "update ExpressInfos set ExpState='已入库' where ExpId=" + expInfo.ExpId,
                IsProc = false
            });
            return SqlHelper.ExecuteTrans(comList); // 执行命令

        }

        /// <summary>
        /// 删除、恢复、移除快递信息
        /// </summary>
        /// <param name="expIds">快递信息ID集合</param>
        /// <param name="delType">0-逻辑删除</param>
        /// <param name="isDeleted">0-恢复；1-逻辑删除</param>
        /// <returns></returns>
        public bool UpdateExpressesDelState(List<int> expIds, int delType, int isDeleted)
        {
            string strIds = string.Join(",", expIds);
            string strWhere = $"ExpId in ({strIds})";
            List<string> sqlList = new List<string>(); // 要执行的命令列表
            if (delType == 0)
            {
                sqlList.Add(CreateSql.CreateLogicDeleteSql<ExpressInfo>(strWhere, isDeleted));
                sqlList.Add(CreateSql.CreateLogicDeleteSql<ExpDistributeInfo>(strWhere, isDeleted));
                sqlList.Add(CreateSql.CreateLogicDeleteSql<ExpSelfPickInfo>(strWhere, isDeleted));
            }
            else
            {
                sqlList.Add(CreateSql.CreateDeleteSql<ExpressInfo>(strWhere));
                sqlList.Add(CreateSql.CreateDeleteSql<ExpDistributeInfo>(strWhere));
                sqlList.Add(CreateSql.CreateDeleteSql<ExpSelfPickInfo>(strWhere));
            }
            return SqlHelper.ExecuteTrans(sqlList);
        }

        /// <summary>
        /// 快递签收
        /// </summary>
        /// <param name="expIds">快递ID集合</param>
        /// <param name="isSelf">是否自提</param>
        /// <param name="signTime">签收时间</param>
        /// <param name="pickCode">取件码</param>
        /// <returns></returns>
        public bool SignExpress(List<int> expIds, bool isSelf, string signTime, string pickCode = null)
        {
            List<string> sqlList = new List<string>(); // 要执行的SQL命令列表
            foreach (int expId in expIds)
            {
                if (isSelf) // 自提签收
                {
                    sqlList.Add("update ExpSelfPickInfos set IsPickUp=1,PickingTime='" + signTime + "' where ExpId=" + expId + " and PickingCode='" + pickCode + "'");
                }
                else // 派送签收
                {
                    sqlList.Add("update ExpDistributeInfos set IsSignFor=1,SignTime='" + signTime + "' where ExpId=" + expId);
                }
                sqlList.Add("update ExpressInfos set ExpState='已签收' where ExpId=" + expId);
            }
            return SqlHelper.ExecuteTrans(sqlList);
        }
    }
}
