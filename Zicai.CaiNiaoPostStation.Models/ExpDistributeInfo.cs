using Common.CustAttributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZiCai.CainiaoPostStation.Models
{
    /// <summary>
    /// 快递派送信息类
    /// </summary>
    [Table("ExpDistributeInfos")]
    [PrimaryKey("DistributeId", autoIncrement = true)]
    public class ExpDistributeInfo
    {
        /// <summary>
        /// 派送编号
        /// </summary>
        public int DistributeId { get; set; }
        /// <summary>
        /// 快递编号
        /// </summary>
        public int ExpId { get; set; }
        /// <summary>
        /// 派送员编号
        /// </summary>
        public int EmpId { get; set; }
        /// <summary>
        /// 是否已签收
        /// </summary>
        public bool IsSignFor { get; set; }
        /// <summary>
        /// 签收时间
        /// </summary>
        public DateTime?  SignTime { get; set; }
        /// <summary>
        /// 派送时间
        /// </summary>
        public DateTime? DistributeTime { get; set; }
        /// <summary>
        /// 入库时间
        /// </summary>
        public DateTime InsertTime { get; set; }
    }
}
