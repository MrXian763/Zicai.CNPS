using Common.CustAttributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zicai.CaiNiaoPostStation.Models
{
    /// <summary>
    /// 货架信息类
    /// </summary>
    [Table("ShelfInfos")]
    [PrimaryKey("ShelfId", autoIncrement = true)]
    internal class ShelfInfo
    {
        /// <summary>
        /// 货架自编号
        /// </summary>
        public int ShelfId { get; set; }
        /// <summary>
        /// 货架号
        /// </summary>
        public string ShelfNo { get; set; }
        /// <summary>
        /// 货架名称
        /// </summary>
        public string ShelfName { get; set; }
        /// <summary>
        /// 所属站点编号
        /// </summary>
        public int StationId { get; set; }
        /// <summary>
        /// 货架位置
        /// </summary>
        public string Address { get; set; }
        /// <summary>
        /// 描述
        /// </summary>
        public string Remark { get; set; }
    }
}
