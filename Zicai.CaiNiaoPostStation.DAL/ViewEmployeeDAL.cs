using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZiCai.CainiaoPostStation.DAL.Base;
using ZiCai.CainiaoPostStation.Models.UIModels;
using ZiCai.CaiNiaoPostStation.Models;
using ZiCai.CaiNiaoPostStation.Models.VModels;

namespace ZiCai.CaiNiaoPostStation.DAL
{
    public class ViewEmployeeDAL : BQuery<ViewEmployeeInfo>
    {
        /// <summary>
        /// 分页查询员工信息列表
        /// </summary>
        /// <param name="keywords"></param>
        /// <param name="empTypeId"></param>
        /// <param name="stationId"></param>
        /// <param name="isDeleted"></param>
        /// <param name="startIndex"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        public PageModel<ViewEmployeeInfo> FindEmployeeList(string keywords, int empTypeId, int stationId, int isDeleted, int startIndex, int pageSize)
        {
            string strWhere = $"IsDeleted={isDeleted}";
            List<SqlParameter> listParas = new List<SqlParameter>();
            if (!string.IsNullOrEmpty(keywords))
            {
                strWhere += " and (EmpNo like @keywords or EmpName  like @keywords  or EmpPYNo like  @keywords  or Phone like @keywords or Remark  like @keywords )";
                listParas.Add(new SqlParameter("@keywords", $"%{keywords}%"));
            }
            if(empTypeId>0)
            {
                strWhere += " and EmpTypeId=@empTypeId";
                listParas.Add(new SqlParameter("@empTypeId", empTypeId));
            }
            if(stationId>0)
            {
                strWhere += " and StationId=@stationId";
                listParas.Add(new SqlParameter("@stationId", stationId));
            }

            string cols = CreateSql.GetColNames<ViewEmployeeInfo>("IsDeleted");
            return GetRowsModelList<ViewEmployeeInfo>(strWhere, cols,"Id", "EmpId",startIndex, pageSize ,listParas.ToArray());
        }
    }
}
