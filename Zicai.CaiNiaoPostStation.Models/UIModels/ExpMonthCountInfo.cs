using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zicai.CaiNiaoPostStation.Models.UIModels
{
    public class ExpMonthCountInfo
    {
        /// <summary>
        ///月份
        /// </summary>
        public int MonthNumber { get; set; }

        /// <summary>
        /// 当月总快递数量
        /// </summary>
        public int ExpCount { get; set; }

        /// <summary>
        /// 当月已完成的快递数量
        /// </summary>
        public int HasCount { get; set; }

        /// <summary>
        /// 当月未完成的快递数量
        /// </summary>
        public int UnCount { get; set; }

        /// <summary>
        /// 快递状态
        /// </summary>
        public string ExpState { get; set; }
    }
}
