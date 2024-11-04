using Common.CustAttributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZiCai.CainiaoPostStation.Models;

namespace ZiCai.CaiNiaoPostStation.Models.VModels
{
    /// <summary>
    /// View_EmployeeInfos视图的实体类
    /// </summary>
    [Table("View_EmployeeInfos")]
    [PrimaryKey("EmpId")]
    public class ViewEmployeeInfo:EmployeeInfo
    {
        public string StationName { get; set; }
        public string EmpTypeName { get; set; }

        public ViewEmployeeInfo() { }
        public ViewEmployeeInfo(EmployeeInfo empInfo,string stationName,string empTypeName)
        {
            EmpId = empInfo.EmpId;
            StationName = stationName;
            EmpTypeName= empTypeName;
            EmpNo= empInfo.EmpNo;
            EmpName= empInfo.EmpName;
            Sex= empInfo.Sex;
            Age= empInfo.Age;
            Phone= empInfo.Phone;
            EmpPYNo= empInfo.EmpPYNo;
            EmpTypeId= empInfo.EmpTypeId;
            StationId= empInfo.StationId;
            Remark= empInfo.Remark;
            IsOn= empInfo.IsOn;
        }
    }
}
