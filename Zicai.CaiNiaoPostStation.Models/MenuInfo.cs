using Common.CustAttributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zicai.CaiNiaoPostStation.Models
{
    /// <summary>
    /// 菜单信息类
    /// </summary>
    [Table("MenuInfos")]
    [PrimaryKey("MenuId", autoIncrement = true)]
    internal class MenuInfo
    {
        /// <summary>
        /// 菜单编号
        /// </summary>
        public int MenuId { get; set; }
        /// <summary>
        /// 菜单名称
        /// </summary>
        public string MenuName { get; set; }
        /// <summary>
        /// 父菜单编号
        /// </summary>
        public int ParentId { get; set; }
        /// <summary>
        /// 快捷键
        /// </summary>
        public string MKey { get; set; }
        /// <summary>
        /// 页面名称
        /// </summary>
        public string FrmURL { get; set; }
        /// <summary>
        /// 排序号
        /// </summary>
        public string MOrder { get; set; }
    }
}
