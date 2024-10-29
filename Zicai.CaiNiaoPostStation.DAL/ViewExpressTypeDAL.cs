using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zicai.CaiNiaoPostStation.Models.VModels;
using ZiCai.CainiaoPostStation.DAL.Base;

namespace Zicai.CaiNiaoPostStation.DAL
{
    public class ViewExpressTypeDAL : BQuery<ViewExpressTypeInfo>
    {
        /// <summary>
        /// 查询快递类别列表
        /// </summary>
        /// <param name="keywords">查询关键词</param>
        /// <param name="isDeleted">是否查询已删除数据 1-已删除</param>
        /// <returns></returns>
        public List<ViewExpressTypeInfo> GetExpressTypeList(string keywords, int isDeleted)
        {
            string strWhere = $"IsDeleted={isDeleted}";
            if (!string.IsNullOrEmpty(keywords))
            {
                strWhere += " and (ExpTypeName like @keywords or ExpPYNo  like @keywords  or Remark  like @keywords )";
            }
            SqlParameter para = new SqlParameter("@keywords", $"%{keywords}%");
            string cols = "";
            return GetModelList(strWhere, cols, "ParentId,OrderNum", para);
        }
    }
}
