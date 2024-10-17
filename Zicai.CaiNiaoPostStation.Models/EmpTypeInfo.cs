using Common.CustAttributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zhaoxi.CainiaoPostStation.Models
{
    /// <summary>
    /// 员工类别
    /// </summary>
    [Table("EmpTypeInfos")]
    [PrimaryKey("EmpTypeId", autoIncrement = true)]
    public class EmpTypeInfo
    {
        /// <summary>
        /// 类别编号
        /// </summary>
        public int EmpTypeId { get; set; }
        /// <summary>
        /// 类别名称
        /// </summary>
        public string EmpTypeName { get; set; }
        /// <summary>
        /// 描述
        /// </summary>
        public string Remark { get; set; }
        public int IsDeleted { get; set; }
    }
}
