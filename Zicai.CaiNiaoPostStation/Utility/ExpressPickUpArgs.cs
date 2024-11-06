using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zicai.CaiNiaoPostStation.Utility
{
    /// <summary>
    /// 快递签收事件参数类
    /// </summary>
    public class ExpressPickUpArgs : EventArgs
    {
        /// <summary>
        /// 要签收的快递ID集合
        /// </summary>
        public List<int> ExpIds { get; set; }

        /// <summary>
        /// 快递签收时间
        /// </summary>
        public DateTime PickingTime { get; set; }
        public ExpressPickUpArgs(List<int> expIds, DateTime pickingTime)
        {
            ExpIds = expIds;
            PickingTime = pickingTime;
        }
    }
}
