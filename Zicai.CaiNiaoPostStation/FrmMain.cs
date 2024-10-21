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
using ZiCai.CaiNiaoPostStation.Utility;

namespace Zicai.CaiNiaoPostStation
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        MenuBLL menuBLL = new MenuBLL();
        string loginUserName = ""; // 登录用户名
        System.Timers.Timer timerDT; // 定时器

        /// <summary>
        /// 页面加载初始化处理
        /// </summary>
        private void FrmMain_Load(object sender, EventArgs e)
        {
            // 初始化处理
            InitMainPageInfo();
        }

        /// <summary>
        /// 初始化处理
        /// </summary>
        private void InitMainPageInfo()
        {
            // 加载登录信息
            if (this.Tag != null)
                loginUserName = this.Tag.ToString();
            if (!string.IsNullOrEmpty(loginUserName))
                lblLoginInfo.Text = loginUserName + "，欢迎使用系统！";
            else
            {
                MessageHelper.Error("系统加载", "未登录系统！");
                return;
            }
            lblCopyright.Text = "紫菜网络所有";
            // 动态显示时间
            timerDT = new System.Timers.Timer();
            timerDT.Interval = 1000; // 执行间隔，单位为毫秒
            timerDT.AutoReset = true; // 持续执行
            timerDT.Elapsed += TimerDT_Elapsed; // 重复执行事件
            lblLoginTime.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"); // 设置状态栏时间显示
            timerDT.Start(); // 启动定时器
            // 加载菜单栏
            cainiaoMenus.Items.Clear(); // 清空菜单项
            List<MenuInfo> allMenuList = menuBLL.GetMenuList(); // 获取所有菜单数据
            // TODO 加载菜单项到菜单栏

            // 默认显示系统导航子页
            tabPages.AddTabFormPage(new FrmNavigation());
            lblAction.Text = "系统导航页";
        }

        /// <summary>
        /// 定时器重复执行事件，动态获取当前时间
        /// </summary>
        private void TimerDT_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            if (this.IsHandleCreated) // 检查窗体的句柄是否已经创建
            {
                this.Invoke(new Action(() => // UI更新操作在UI线程上执行
                {
                    lblLoginTime.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                }));
            }
        }
    }
}
