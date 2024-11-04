using System;
using System.Collections.Generic;
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
    }
}
