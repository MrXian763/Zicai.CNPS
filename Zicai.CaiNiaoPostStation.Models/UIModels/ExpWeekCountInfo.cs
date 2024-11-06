using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zicai.CaiNiaoPostStation.Models.UIModels
{
    /// <summary>
    /// 按周统计实体类
    /// </summary>
    public class ExpWeekCountInfo
    {
        /// <summary>
        /// 周数
        /// </summary>
        public int WeekNumber { get; set; }

        /// <summary>
        /// 本周快递总数
        /// </summary>
        public int ExpCount { get; set; }

        /// <summary>
        /// 本周已完成快递总数
        /// </summary>
        public int HasCount { get; set; }

        /// <summary>
        /// 本周未完成快递总数
        /// </summary>
        public int UnCount { get; set; }

        /// <summary>
        /// 快递状态
        /// </summary>
        public string ExpState { get; set; }
    }
}
