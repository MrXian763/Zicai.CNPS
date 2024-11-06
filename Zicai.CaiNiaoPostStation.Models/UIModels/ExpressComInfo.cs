using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zicai.CaiNiaoPostStation.Models.UIModels
{
    public class ExpressComInfo
    {
        /// <summary>
        /// 快递编号
        /// </summary>
        public int ExpId { get; set; }

        /// <summary>
        /// 快递单号
        /// </summary>
        public string ExpNumber { get; set; }

        /// <summary>
        /// 站点名称
        /// </summary>
        public string StationName { get; set; }

        /// <summary>
        /// 快递描述
        /// </summary>
        public string ExpRemark { get; set; }

        /// <summary>
        /// 快递状态
        /// </summary>
        public string ExpState { get; set; }

        /// <summary>
        /// 取件方式
        /// </summary>
        public string PickWay { get; set; }
    }
}
