using Common.CustAttributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zicai.CaiNiaoPostStation.Models.VModels
{
    [Table("View_DistributeExpressInfos")]
    [PrimaryKey("ExpId")]
    public class ViewDistributeExpressInfo
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
        /// 站点名称
        /// </summary>
        public string StationName { get; set; }

        /// <summary>
        /// 货架编号
        /// </summary>
        public int ShelfId { get; set; }

        /// <summary>
        /// 货架名称
        /// </summary>
        public string ShelfName { get; set; }

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
        /// 员工编号
        /// </summary>
        public int EmpId { get; set; }

        /// <summary>
        /// 姓名
        /// </summary>
        public string EmpName { get; set; }

        /// <summary>
        /// 电话
        /// </summary>
        public string Phone { get; set; }

        /// <summary>
        /// 是否已签收
        /// </summary>
        public bool IsSignFor { get; set; }

        /// <summary>
        /// 签收时间
        /// </summary>
        public DateTime? SignTime { get; set; }

        /// <summary>
        /// 派送时间
        /// </summary>
        public DateTime? DistributeTime { get; set; }
    }
}
