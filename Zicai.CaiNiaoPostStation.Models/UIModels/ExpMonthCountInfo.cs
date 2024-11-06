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
        public int ExpCount { get; set; }
        public int HasCount { get; set; }
        public string ExpState { get; set; }
        public int UnCount { get; set; }
    }
}
