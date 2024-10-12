using Common.CustAttributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zhaoxi.CainiaoPostStation.Models
{
    /// <summary>
    /// 快递信息类
    /// </summary>
    [Table("ExpressInfos")]
    [PrimaryKey("ExpId", autoIncrement = true)]
    public class ExpressInfo
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
        /// 寄件人
        /// </summary>
        public string  Sender { get; set; }
        /// <summary>
        /// 寄件地址
        /// </summary>
        public string SendAddress { get; set; }
        /// <summary>
        /// 寄件人电话
        /// </summary>
        public string  SenderPhone { get; set; }
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
        public string  ExpRemark { get; set; }
        /// <summary>
        /// 快递状态
        /// </summary>
        public string ExpState { get; set; }
        /// <summary>
        /// 快递类别
        /// </summary>
        public string ExpType { get; set; }
        /// <summary>
        /// 录入人
        /// </summary>
        public string EnterPerson { get; set; }
        /// <summary>
        /// 录入时间
        /// </summary>
        public DateTime EnterTime { get; set; }
        /// <summary>
        /// 取件方式
        /// </summary>
        public string PickWay { get; set; }
    }
}
