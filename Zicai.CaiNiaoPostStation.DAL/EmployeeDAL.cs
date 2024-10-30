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

        /// <summary>
        /// 获取员工列表（绑定下拉框）
        /// </summary>
        /// <param name="stationId">站点ID</param>
        /// <returns></returns>
        public List<EmployeeInfo> GetCboEmployeeList(int stationId)
        {
            string strWhere = "IsDeleted=0  ";
            if (stationId > 0)
                strWhere += " and StationId=" + stationId;
            return GetModelList(strWhere, "EmpId,EmpName", "");
        }

        /// <summary>
        /// 判断员工名称是否存在
        /// </summary>
        /// <param name="empName">员工名称</param>
        /// <param name="phone">员工电话</param>
        /// <returns></returns>
        public bool ExistEmpInfo(string empName, string phone)
        {
            string strWhere = "IsDeleted=0 and EmpName=@empName and Phone=@phone";
            SqlParameter[] paras =
            {
                new SqlParameter("@empName",empName),
                new SqlParameter("@phone",phone)
            };
            return Exists(strWhere, paras);
        }

        /// <summary>
        /// 检查员工号是否存在
        /// </summary>
        /// <param name="empNo">员工号</param>
        /// <returns></returns>
        public bool ExistEmpNo(string empNo)
        {
            return ExistsByName("EmpNo", empNo);
        }

        /// <summary>
        /// 添加员工信息
        /// </summary>
        /// <param name="empInfo">员工信息</param>
        /// <returns>1-添加成功</returns>
        public int AddEmployee(EmployeeInfo empInfo)
        {
            string cols = CreateSql.GetColNames<EmployeeInfo>("EmpId");
            return Add(empInfo, cols, 1);
        }

        /// <summary>
        /// 员工离职
        /// </summary>
        /// <param name="empId">员工ID</param>
        /// <returns></returns>
        public bool EmpLeaveOut(int empId)
        {
            string sql = "update EmployeeInfos set IsOn=0 where EmpId=" + empId;
            return SqlHelper.ExecuteNonQuery(sql, 1) > 0;
        }

        /// <summary>
        /// 员工信息删除、恢复、移除
        /// </summary>
        /// <param name="empIds">要删除的员工ID列表</param>
        /// <param name="delType">0-逻辑删除</param>
        /// <param name="isDeleted"></param>
        /// <returns></returns>
        public bool UpdateEmployeesDelState(List<int> empIds, int delType, int isDeleted)
        {
            string strIds = string.Join(",", empIds);
            string strWhere = $"EmpId in ({strIds})";
            List<string> sqlList = new List<string>();
            if (delType == 0)
            {
                sqlList.Add(CreateSql.CreateLogicDeleteSql<EmployeeInfo>(strWhere, isDeleted));
                sqlList.Add(CreateSql.CreateLogicDeleteSql<ExpDistributeInfo>(strWhere, isDeleted));
            }
            else
            {
                sqlList.Add(CreateSql.CreateDeleteSql<EmployeeInfo>(strWhere));
                sqlList.Add(CreateSql.CreateDeleteSql<ExpDistributeInfo>(strWhere));
            }
            return SqlHelper.ExecuteTrans(sqlList);
        }
    }
}
