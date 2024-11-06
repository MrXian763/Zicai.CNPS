using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zicai.CaiNiaoPostStation.Models.UIModels
{
    public class ExpressCountInfo
    {
        /// <summary>
        /// 快递状态
        /// </summary>
        public string ExpState { get; set; }

        /// <summary>
        /// 该快递状态下的快递数量
        /// </summary>
        public int ExpCount { get; set; }
    }
}
