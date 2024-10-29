using Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZiCai.CainiaoPostStation.DAL.Base;
using ZiCai.CainiaoPostStation.Models;

namespace Zicai.CaiNiaoPostStation.DAL
{
    public class ExpressTypeDAL : BaseDAL<ExpressTypeInfo>
    {
        /// <summary>
        /// 获取所有类别列表（绑定下拉框、TreeView）
        /// </summary>
        /// <returns>快递类别集合</returns>
        public List<ExpressTypeInfo> GetCboExpTypes(int isDefault = 0)
        {
            string strWhere = "IsDeleted=0";
            if (isDefault == 0)
                strWhere += " and ParentId>0";
            return GetModelList(strWhere, "ExpTypeId,ExpTypeName,ParentId", "ParentId,OrderNum");
        }

        /// <summary>
        /// 检查指定类别下类别名称是否存在
        /// </summary>
        /// <param name="name">类别名称</param>
        /// <param name="parentId">父类别ID</param>
        /// <returns>是否存在</returns>
        public bool ExistExpType(string name, int parentId)
        {
            return ExistsByName("ExpTypeName", name, "ParentId", parentId);
        }

        /// <summary>
        /// 获取指定类别的子类别数
        /// </summary>
        /// <param name="typeId">类别ID</param>
        /// <returns>子类别数</returns>
        public int GetChildCount(int typeId)
        {
            string sql = $"select count(1) from ExpressTypeInfos where ParentId={typeId} and IsDeleted=0";
            object oCount = SqlHelper.ExecuteScalar(sql, 1);
            int count = 0;
            if (oCount != null && oCount.ToString() != "")
                count = (int)oCount;
            return count;
        }

        /// <summary>
        /// 添加快递类别
        /// </summary>
        /// <param name="expType">快递类别</param>
        /// <returns>1-添加成功</returns>
        public int AddExpType(ExpressTypeInfo expType)
        {
            string cols = CreateSql.GetColNames<ExpressTypeInfo>("ExpTypeId");
            return Add(expType, cols, 1);
        }

        /// <summary>
        /// 删除、恢复、移除快递类别信息
        /// </summary>
        /// <param name="typeIds">要删除的快递类别ID</param>
        /// <param name="delType">0-逻辑删除</param>
        /// <param name="isDeleted"></param>
        /// <returns>操作结果</returns>
        public bool UpdateExpTypeDelState(List<int> typeIds, int delType, int isDeleted)
        {
            string strIds = string.Join(",", typeIds);
            string strWhere = $"ExpTypeId in ({strIds})";
            List<string> sqlList = new List<string>();
            if (delType == 0)
            {
                sqlList.Add(CreateSql.CreateLogicDeleteSql<ExpressTypeInfo>(strWhere, isDeleted));
            }
            else
            {
                sqlList.Add(CreateSql.CreateDeleteSql<ExpressTypeInfo>(strWhere));
            }
            return SqlHelper.ExecuteTrans(sqlList);
        }
    }
}
