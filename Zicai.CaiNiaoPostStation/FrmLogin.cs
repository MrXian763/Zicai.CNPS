using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Zicai.CaiNiaoPostStation.BLL;
using Zicai.CaiNiaoPostStation.Models;
using Zicai.CaiNiaoPostStation.Utility;

namespace Zicai.CaiNiaoPostStation
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        UserBLL userBLL = new UserBLL();

        /// <summary>
        /// 登录页面加载初始化处理
        /// </summary>
        private void FrmLogin_Load(object sender, EventArgs e)
        {
            txtUserName.Clear();
            txtPassword.Clear();
            lblErrMsg.Visible = false;
        }

        /// <summary>
        /// 点击登录按钮
        /// </summary>
        private void btnLogin_Click(object sender, EventArgs e)
        {
            // 接收信息
            string userName = txtUserName.Text.Trim();
            string password = txtPassword.Text.Trim();
            // 非空检查
            if (string.IsNullOrEmpty(userName))
            {
                lblErrMsg.SetErrorMsg("请输入账号！");
                txtUserName.Focus(); // 指针聚焦到输入框
                return;
            }
            if (string.IsNullOrEmpty(password))
            {
                lblErrMsg.SetErrorMsg("请输入密码！");
                txtPassword.Focus(); // 指针聚焦到输入框
                return;
            }
            // 登录操作响应处理
            UserInfo userInfo = new UserInfo()
            {
                UserName = userName,
                UserPwd = password
            };
            string loginRes = "";
            loginRes = userBLL.Login(userInfo);
            if (loginRes == "1")
            {
                // 登录成功
                FrmMain frmMain = new FrmMain();
                frmMain.Tag = userName;
                frmMain.Show(); // 展示主页
                this.Hide(); // 隐藏当前页面
            }
            else
            {
                // 登录失败
                lblErrMsg.SetErrorMsg(loginRes);
                return;
            }
        }

        /// <summary>
        /// 用户按下用户名输入框
        /// </summary>
        private void txtUserName_MouseDown(object sender, MouseEventArgs e)
        {
            lblErrMsg.Visible = false; // 关闭异常信息显示
        }

        /// <summary>
        /// 用户按下密码输入框
        /// </summary>
        private void txtPassword_MouseDown(object sender, MouseEventArgs e)
        {
            lblErrMsg.Visible = false; // 关闭异常信息显示
        }
    }
}
