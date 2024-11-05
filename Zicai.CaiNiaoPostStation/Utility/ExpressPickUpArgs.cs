using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zicai.CaiNiaoPostStation.Utility
{
    public class ExpressPickUpArgs : EventArgs
    {
        /// <summary>
        /// 快递签收事件参数类
        /// </summary>
        public List<int> ExpIds { get; set; }
        public DateTime PickingTime { get; set; }
        public ExpressPickUpArgs(List<int> expIds, DateTime pickingTime)
        {
            ExpIds = expIds;
            PickingTime = pickingTime;
        }
    }
}
