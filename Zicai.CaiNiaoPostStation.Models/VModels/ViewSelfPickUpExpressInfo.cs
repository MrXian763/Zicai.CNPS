using Common.CustAttributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zicai.CaiNiaoPostStation.Models.VModels
{
    [Table("View_SelfPickUpExpressInfos")]
    [PrimaryKey("ExpId")]
    public class ViewSelfPickUpExpressInfo
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
        /// 站点编号
        /// </summary>
        public int StationId { get; set; }

        /// <summary>
        /// 货架编号
        /// </summary>
        public int ShelfId { get; set; }

        /// <summary>
        /// 收件人
        /// </summary>
        public string Receiver { get; set; }

        /// <summary>
        /// 收件地址
        /// </summary>
        public string ReceiveAddress { get; set; }

        /// <summary>
        /// 收件人电话
        /// </summary>
        public string ReceiverPhone { get; set; }

        /// <summary>
        /// 快递描述
        /// </summary>
        public string ExpRemark { get; set; }

        /// <summary>
        /// 快递状态
        /// </summary>
        public string ExpState { get; set; }

        /// <summary>
        /// 站点名称
        /// </summary>
        public string StationName { get; set; }

        /// <summary>
        /// 货架名称
        /// </summary>
        public string ShelfName { get; set; }

        /// <summary>
        /// 取件码
        /// </summary>
        public string PickingCode { get; set; }

        /// <summary>
        /// 是否已取件
        /// </summary>
        public bool IsPickUp { get; set; }

        /// <summary>
        /// 取件时间
        /// </summary>
        public DateTime? PickingTime { get; set; }

        //取件列的文本
        public string PickText { get; set; }
    }
}
