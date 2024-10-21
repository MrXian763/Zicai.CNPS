using Common.CustAttributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZiCai.CainiaoPostStation.Models
{
    /// <summary>
    /// 快递自提信息类
    /// </summary>
    [Table("ExpSelfPickInfos")]
    [PrimaryKey("PickUpId", autoIncrement = true)]
    public class ExpSelfPickInfo
    {
        /// <summary>
        /// 自编号
        /// </summary>
        public int PickUpId { get; set; }
        /// <summary>
        /// 快递编号
        /// </summary>
        public int ExpId { get; set; }
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
        public DateTime?  PickingTime { get; set; }
        /// <summary>
        /// 入库时间
        /// </summary>
        public DateTime InsertTime { get; set; }
    }
}
