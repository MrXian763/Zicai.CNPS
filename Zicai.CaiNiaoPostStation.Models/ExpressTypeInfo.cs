using Common.CustAttributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZiCai.CainiaoPostStation.Models
{
    /// <summary>
    /// 快递分类信息类
    /// </summary>
    [Table("ExpressTypeInfos")]
    [PrimaryKey("ExpTypeId", autoIncrement = true)]
    public class ExpressTypeInfo
    {
        /// <summary>
        /// 类别编号
        /// </summary>
        public int ExpTypeId { get; set; }
        /// <summary>
        /// 类别名称
        /// </summary>
        public string ExpTypeName { get; set; }
        /// <summary>
        /// 父类别编号
        /// </summary>
        public int ParentId { get; set; }
        /// <summary>
        /// 拼音码
        /// </summary>
        public string ExpPYNo { get; set; }
        /// <summary>
        /// 同级排序号
        /// </summary>
        public int OrderNum { get; set; }
        /// <summary>
        /// 描述
        /// </summary>
        public string Remark { get; set; }
    }
}
