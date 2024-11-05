using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZiCai.CainiaoPostStation.Models;

namespace Zicai.CaiNiaoPostStation.Utility
{
    /// <summary>
    /// 派送安排事件参数类
    /// </summary>
    public class DistributeExpressArgs : EventArgs
    {
        public List<int> ExpIds { get; set; }
        public EmployeeInfo EmpInfo { get; set; }
        public DateTime DisTime { get; set; }
        public DistributeExpressArgs(List<int> expIds, EmployeeInfo empInfo, DateTime disTime)
        {
            ExpIds = expIds;
            EmpInfo = empInfo;
            DisTime = disTime;
        }
    }
}
