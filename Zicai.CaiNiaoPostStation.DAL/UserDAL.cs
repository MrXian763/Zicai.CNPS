using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zicai.CaiNiaoPostStation.Models;
using ZiCai.CainiaoPostStation.DAL.Base;

namespace Zicai.CaiNiaoPostStation.DAL
{
    public class UserDAL : BaseDAL<UserInfo>
    {
        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="userInfo">用户名密码</param>
        /// <returns>用户账户状态</returns>
        public UserInfo Login(UserInfo userInfo)
        {
            string strWhere = "UserName = @userName and UserPwd = @userPwd and IsDeleted = 0";
            SqlParameter[] paras =
            {
                new SqlParameter("@userName", userInfo.UserName),
                new SqlParameter("@userPwd", userInfo.UserPwd)
            };
            UserInfo user = GetModel(strWhere, "UserState", paras);
            return user;
        }
    }
}
