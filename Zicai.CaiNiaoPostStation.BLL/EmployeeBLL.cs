using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zicai.CaiNiaoPostStation.DAL;
using ZiCai.CainiaoPostStation.Models;
using ZiCai.CainiaoPostStation.Models.UIModels;
using ZiCai.CaiNiaoPostStation.DAL;
using ZiCai.CaiNiaoPostStation.Models.VModels;

namespace Zicai.CaiNiaoPostStation.BLL
{
    public class EmployeeBLL
    {

        ViewEmployeeDAL viewEmployeeDAL = new ViewEmployeeDAL();
        EmployeeDAL employeeDAL = new EmployeeDAL();
        ExpDistributeDAL expDistributeDAL = new ExpDistributeDAL();

        /// <summary>
        /// 分页查询员工信息列表
        /// </summary>
        /// <param name="keywords">查询关键词</param>
        /// <param name="empTypeId">员工类型ID</param>
        /// <param name="stationId">站点ID</param>
        /// <param name="blShowDel">是否显示已删除</param>
        /// <param name="startIndex">起始索引</param>
        /// <param name="pageSize">每页数据大小</param>
        /// <returns>员工信息视图</returns>
        public PageModel<ViewEmployeeInfo> FindEmployeeList(string keywords, int empTypeId, int stationId, bool blShowDel, int startIndex, int pageSize)
        {
            int isDeleted = blShowDel ? 1 : 0;
            return viewEmployeeDAL.FindEmployeeList(keywords, empTypeId, stationId, isDeleted, startIndex, pageSize);
        }

        /// <summary>
        ///  获取员工列表（绑定下拉框）
        /// </summary>
        /// <param name="stationId">站点ID</param>
        /// <returns></returns>
        public List<EmployeeInfo> GetCboEmployeeList(int stationId)
        {
            return employeeDAL.GetCboEmployeeList(stationId);
        }

        /// <summary>
        /// 判断员工名称是否存在
        /// </summary>
        /// <param name="empName">员工名称</param>
        /// <param name="phone">员工电话</param>
        /// <returns></returns>
        public bool ExistEmpInfo(string empName, string phone)
        {
            return employeeDAL.ExistEmpInfo(empName, phone);
        }

        /// <summary>
        /// 检查员工号是否存在
        /// </summary>
        /// <param name="empNo">员工号</param>
        /// <returns></returns>
        public bool ExistEmpNo(string empNo)
        {
            return employeeDAL.ExistEmpNo(empNo);
        }

        /// <summary>
        /// 获取指定的员工信息
        /// </summary>
        /// <param name="empId">员工ID</param>
        /// <returns></returns>
        public EmployeeInfo GetEmployee(int empId)
        {
            return employeeDAL.GetById(empId, "");
        }

        /// <summary>
        /// 新增员工
        /// </summary>
        /// <param name="empInfo">员工信息</param>
        /// <returns></returns>
        public int AddEmployee(EmployeeInfo empInfo)
        {
            return employeeDAL.AddEmployee(empInfo);
        }

        /// <summary>
        /// 修改员工
        /// </summary>
        /// <param name="empInfo">员工信息</param>
        /// <returns></returns>
        public bool UpdateEmployee(EmployeeInfo empInfo)
        {
            return employeeDAL.Update(empInfo, "");
        }

        /// <summary>
        /// 员工离职处理
        /// </summary>
        /// <param name="empInfo">员工信息</param>
        /// <returns></returns>
        public int EmpLeaveOut(ViewEmployeeInfo empInfo)
        {
            int expCount = expDistributeDAL.GetEmpDisExpCount(empInfo.EmpId);
            if (expCount > 0)
            {
                return 2; // 未处理离职，还有未完成的派送
            }
            else
            {
                bool bl = employeeDAL.EmpLeaveOut(empInfo.EmpId); // 离职
                if (bl)
                    return 1; // 离职处理成功
                else
                    return 0; // 离职处理失败
            }
        }

        /// <summary>
        /// 员工删除
        /// </summary>
        /// <param name="employees">要删除的员工数据</param>
        /// <returns>删除结果提示词</returns>
        public string DeleteEmployees(List<ViewEmployeeInfo> employees)
        {
            string reStr = "";
            string hasNames = ""; // 存储在职（不可删除）的员工名称字符串
            List<int> delIds = new List<int>(); // 存储符合删除的员工编号
            foreach (ViewEmployeeInfo emp in employees)
            {
                if (emp.IsOn)
                {
                    // 员工在职
                    if (hasNames != "")
                        hasNames += ",";
                    hasNames += emp.EmpName;
                }
                else
                    delIds.Add(emp.EmpId);
            }
            bool blDel = false;
            if (delIds.Count > 0)
            {
                blDel = employeeDAL.UpdateEmployeesDelState(delIds, 0, 1); // 删除员工列表
            }
            if (blDel)
            {
                if (hasNames == "")
                    reStr = "1"; // 删除成功
                else
                    reStr = "1;" + hasNames; // 删除成功，但存在不能删除的员工
            }
            else
            {
                if (delIds.Count > 0)
                    reStr = "0"; // 删除失败
                else
                {
                    reStr = "-1;"; // 所有选择的员工都不能删除
                }
            }
            return reStr;
        }

        /// <summary>
        /// 恢复员工
        /// </summary>
        /// <param name="empIds">要恢复的员工ID</param>
        /// <returns></returns>
        public bool RecoverEmployees(List<int> empIds)
        {
            return employeeDAL.UpdateEmployeesDelState(empIds, 0, 0);
        }

        /// <summary>
        /// 移除员工（真删除）
        /// </summary>
        /// <param name="empIds">要删除的员工ID集合</param>
        /// <returns></returns>
        public bool RemoveEmployees(List<int> empIds)
        {
            return employeeDAL.UpdateEmployeesDelState(empIds, 1, 2);
        }
    }
}
