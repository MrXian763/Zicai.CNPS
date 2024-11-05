using Helper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZiCai.CainiaoPostStation.DAL.Base;
using ZiCai.CainiaoPostStation.Models;

namespace Zicai.CaiNiaoPostStation.DAL
{
    public class ExpDistributeDAL : BaseDAL<ExpDistributeInfo>
    {
        /// <summary>
        /// 获取指定员工未完成派送的快件数
        /// </summary>
        /// <param name="empId">员工ID</param>
        /// <returns>快件数</returns>
        public int GetEmpDisExpCount(int empId)
        {
            string sql = "select count(1) from ExpDistributeInfos where EmpId=" + empId + " and IsDeleted=0 and IsSignFor=0";
            return SelectAndReIntValue(sql);
        }

        /// <summary>
        /// 保存派送安排，添加派送记录
        /// </summary>
        /// <param name="expIds">快递信息ID集合</param>
        /// <param name="empId">员工ID</param>
        /// <param name="disTime">派送时间</param>
        /// <returns></returns>
        public bool SaveDistributeAssignSet(List<int> expIds, int empId, DateTime disTime)
        {
            List<CommandInfo> comList = new List<CommandInfo>(); // 要执行的命令列表
            string sql = "insert into ExpDistributeInfos(ExpId,EmpId,DistributeTime) values (@expId,@empId,@disTime)";
            foreach (int expId in expIds)
            {
                SqlParameter[] paras =
                {
                    new SqlParameter("@expId",expId),
                    new SqlParameter("@empId",empId),
                    new SqlParameter("@disTime",disTime)
                };
                // 添加派送记录
                comList.Add(new CommandInfo()
                {
                    CommandText = sql,
                    IsProc = false,
                    Paras = paras
                });
                // 更新快递信息表的快递状态为派送中
                comList.Add(new CommandInfo()
                {
                    CommandText = "update ExpressInfos set ExpState='派送中' where ExpId=" + expId,
                    IsProc = false
                });
            }
            return SqlHelper.ExecuteTrans(comList); // 事务执行
        }
    }
}
