using Helper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZiCai.CainiaoPostStation.DAL.Base;
using ZiCai.CainiaoPostStation.Models;

namespace Zicai.CaiNiaoPostStation.DAL
{
    public class EmpTypeDAL : BaseDAL<EmpTypeInfo>
    {
        /// <summary>
        /// 获取所有员工类别
        /// </summary>
        /// <param name="isDeleted">1-已删除数据；0-未删除数据</param>
        /// <returns></returns>
        public DataTable GetEmpTypeList(int isDeleted)
        {
            string sql = CreateSql.CreateSelectSql<EmpTypeInfo>("", "IsDeleted=" + isDeleted, "");
            return GetDt(sql, 1);
        }

        /// <summary>
        /// 获取员工类别列表（绑定下拉框）
        /// </summary>
        /// <returns></returns>
        public List<EmpTypeInfo> GetCboEmpTypes()
        {
            return GetAllModelList("EmpTypeId,EmpTypeName", "", 0);
        }

        /// <summary>
        /// 保存员工类别信息
        /// </summary>
        /// <param name="dt">员工类别信息</param>
        /// <returns></returns>
        public bool SaveEmpTypeInfos(DataTable dt)
        {
            string sql = CreateSql.CreateSelectSql<EmpTypeInfo>("", "", "");
            return SqlHelper.ExecuteDataTable(dt, sql) > 0;
        }
    }
}
