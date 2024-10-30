using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zicai.CaiNiaoPostStation.DAL;
using ZiCai.CainiaoPostStation.Models;

namespace Zicai.CaiNiaoPostStation.BLL
{
    public class EmpTypeBLL
    {

        EmpTypeDAL empTypeDAL = new EmpTypeDAL();
        EmployeeDAL employeeDAL = new EmployeeDAL();

        /// <summary>
        ///  获取所有员工类别
        /// </summary>
        /// <param name="showDel">是否显示已删除数据</param>
        /// <returns></returns>
        public DataTable GetEmpTypeList(bool showDel)
        {
            int isDeleted = showDel ? 1 : 0;
            return empTypeDAL.GetEmpTypeList(isDeleted);
        }

        /// <summary>
        /// 获取员工类别列表（绑定下拉框）
        /// </summary>
        /// <returns></returns>
        public List<EmpTypeInfo> GetCboEmpTypes()
        {
            return empTypeDAL.GetCboEmpTypes();
        }

        /// <summary>
        /// 保存员工类别信息
        /// </summary>
        /// <param name="dt">员工类别数据</param>
        /// <returns></returns>
        public bool SaveEmpTypeInfos(DataTable dt)
        {
            return empTypeDAL.SaveEmpTypeInfos(dt);
        }

        /// <summary>
        /// 查询指定员工类别是否包含有员工
        /// </summary>
        /// <param name="empTypeId">员工类别ID</param>
        /// <returns></returns>
        public bool IsHasEmployee(int empTypeId)
        {
            int count = employeeDAL.GetEmployeeCount(empTypeId);
            return count > 0;
        }
    }
}
