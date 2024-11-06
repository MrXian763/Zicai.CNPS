using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zicai.CaiNiaoPostStation.Models.UIModels
{
    /// <summary>
    /// 按日统计实体类
    /// </summary>
    public class ExpDayCountInfo
    {
        /// <summary>
        /// 日期，日
        /// </summary>
        public string InsertDate { get; set; }

        /// <summary>
        /// 当天的快递总数
        /// </summary>
        public int ExpCount { get; set; }

        /// <summary>
        /// 当天已完成快递总数
        /// </summary>
        public int HasCount { get; set; }

        /// <summary>
        /// 当天未完成快递总数
        /// </summary>
        public int UnCount { get; set; }

        /// <summary>
        /// 快递状态
        /// </summary>
        public string ExpState { get; set; }
    }
}
