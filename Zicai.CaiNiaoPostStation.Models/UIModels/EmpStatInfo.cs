using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zicai.CaiNiaoPostStation.Models.UIModels
{
    /// <summary>
    /// 员工快递统计
    /// </summary>
    public class EmpStatInfo
    {
        /// <summary>
        /// 员工编号
        /// </summary>
        public int EmpId { get; set; }

        /// <summary>
        /// 员工姓名
        /// </summary>
        public string EmpName { get; set; }

        /// <summary>
        /// 派送总量
        /// </summary>
        public int TotalCount { get; set; }

        /// <summary>
        /// 已完成量
        /// </summary>
        public int SignedCount { get; set; }

        /// <summary>
        /// 未完成量
        /// </summary>
        public int UnSignCount { get; set; }
    }
}
