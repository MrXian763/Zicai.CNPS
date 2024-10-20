using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zicai.CaiNiaoPostStation.DAL;
using Zicai.CaiNiaoPostStation.Models;

namespace Zicai.CaiNiaoPostStation.BLL
{
    public class UserBLL
    {
        UserDAL userDAL = new UserDAL();

        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="userInfo">用户名密码</param>
        /// <returns>登录结果</returns>
        public string Login(UserInfo userInfo)
        {
            string res = "";
            UserInfo user = userDAL.Login(userInfo);
            if (user == null )
                res = "用户名或密码错误！";
            else
            {
                if (user.UserState)
                    res = "1"; // 登录成功
                else
                    res = "账户被锁定！";
            }
            return res;
        }
    }
}
