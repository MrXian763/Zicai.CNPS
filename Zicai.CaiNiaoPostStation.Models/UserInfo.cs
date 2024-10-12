using Common.CustAttributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zicai.CaiNiaoPostStation.Models
{
    /// <summary>
    /// 用户信息类
    /// </summary>
    [Table("UserInfos")]
    [PrimaryKey("UserId", autoIncrement = true)]
    public class UserInfo
    {
        /// <summary>
        /// 用户编号
        /// </summary>
        public int UserId { get; set; }
        /// <summary>
        /// 用户名
        /// </summary>
        public string UserName { get; set; }
        /// <summary>
        /// 密码
        /// </summary>
        public string UserPwd { get; set; }
        /// <summary>
        /// 帐号状态
        /// </summary>
        public bool UserState { get; set; }
    }
}
