using Common.CustAttributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zicai.CaiNiaoPostStation.Models
{
    /// <summary>
    /// 站点信息类
    /// </summary>
    [Table("StationInfos")]
    [PrimaryKey("StationId", autoIncrement = true)]
    public class StationInfo
    {
        /// <summary>
        /// 站点编号
        /// </summary>
        public int StationId { get; set; }
        /// <summary>
        /// 站点编码
        /// </summary>
        public string StationNo { get; set; }
        /// <summary>
        /// 站点名称
        /// </summary>
        public string StationName { get; set; }
        /// <summary>
        /// 站点拼音码
        /// </summary>
        public string StationPYNo { get; set; }
        /// <summary>
        /// 地址
        /// </summary>
        public string Address { get; set; }
        /// <summary>
        /// 管理者
        /// </summary>
        public string Manager { get; set; }
        /// <summary>
        /// 联系电话
        /// </summary>
        public string Phone { get; set; }
        /// <summary>
        /// 描述
        /// </summary>
        public string Remark { get; set; }
        /// <summary>
        /// 是否运营中
        /// </summary>
        public bool IsRunning { get; set; }
    }
}
