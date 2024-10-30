using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZiCai.CainiaoPostStation.DAL.Base;
using ZiCai.CainiaoPostStation.Models;

namespace Zicai.CaiNiaoPostStation.DAL
{
    public class EmployeeDAL : BaseDAL<EmployeeInfo>
    {
        /// <summary>
        /// 获取指定员工类别下的员工数
        /// </summary>
        /// <param name="empTypeId">员工类别ID</param>
        /// <returns>员工数量</returns>
        public int GetEmployeeCount(int empTypeId)
        {
            string sql = "select count(1) from EmployeeInfos where IsDeleted=0  and EmpTypeId=" + empTypeId;
            return SelectAndReIntValue(sql);
        }
    }
}
