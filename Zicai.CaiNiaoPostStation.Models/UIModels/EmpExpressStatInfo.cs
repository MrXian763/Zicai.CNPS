using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zicai.CaiNiaoPostStation.Models.UIModels
{
    /// <summary>
    /// 员工快递统计总数据
    /// </summary>
    public class EmpExpressStatInfo
    {
        /// <summary>
        /// 总派送量
        /// </summary>
        public int TotalDisCount { get; set; }

        /// <summary>
        /// 已完成量
        /// </summary>
        public int HasDisCount { get; set; }

        /// <summary>
        /// 未完成量
        /// </summary>
        public int UnDisCount { get; set; }

        /// <summary>
        /// 派送冠军
        /// </summary>
        public string SuperEmpName { get; set; }

        /// <summary>
        /// 员工最大完成量
        /// </summary>
        public int SuperDisCount { get; set; }

        /// <summary>
        /// 员工派送列表
        /// </summary>
        public List<EmpDisExpInfo> EmpDisExpInfos { get; set; }

        /// <summary>
        /// 员工派送统计数据列表
        /// </summary>
        public List<EmpStatInfo> EmpStatInfos { get; set; }
    }
}
