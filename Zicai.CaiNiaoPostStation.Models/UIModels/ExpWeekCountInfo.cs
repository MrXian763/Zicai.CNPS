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
        public int ExpCount { get; set; }
        public int HasCount { get; set; }
        public string ExpState { get; set; }
        public int UnCount { get; set; }
    }
}
