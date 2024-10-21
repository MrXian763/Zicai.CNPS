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
            // 加载菜单项到菜单栏
            CreateMenuItems(allMenuList, null, 0);
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
        
        /// <summary>
        /// 动态添加菜单项
        /// </summary>
        /// <param name="allMenuList">所有菜单集合</param>
        /// <param name="parentMenu">父级菜单</param>
        /// <param name="parentMenuId">父级菜单编号</param>
        private void CreateMenuItems(List<MenuInfo> allMenuList, ToolStripMenuItem parentMenu, int parentMenuId)
        {
            // 子菜单列表
            var subItems = allMenuList.Where(m => m.ParentId == parentMenuId);
            foreach (MenuInfo menuInfo in subItems)
            {
                // 创建菜单项
                ToolStripMenuItem mItem = new ToolStripMenuItem();
                mItem.Name = menuInfo.MenuId.ToString();
                mItem.Text = menuInfo.MenuName;
                if (parentMenuId == 0)
                {
                    // 一级菜单
                    mItem.Font = new Font("微软雅黑", 12F, FontStyle.Bold, GraphicsUnit.Point);
                    mItem.ForeColor = Color.Navy;
                }
                else
                {
                    // 二级菜单
                    mItem.Font = new Font("微软雅黑", 9F, FontStyle.Bold, GraphicsUnit.Point);
                    mItem.ForeColor = Color.Blue;
                }
                // 快捷键
                if (!string.IsNullOrEmpty(menuInfo.MKey))
                {
                    string[] keyArr = menuInfo.MKey.Split('+');
                    // 长度 2、3 Ctrl+A Ctrl+Alt+A 的快捷键
                    if (keyArr.Length == 2)
                    {
                        Keys key = (Keys)Enum.Parse(typeof(Keys), keyArr[1]);
                        switch (keyArr[0])
                        {
                            case "Alt":
                                mItem.Text += $"(&{keyArr[1]})";
                                mItem.ShortcutKeys = (Keys.Alt | key);
                                break;
                            case "Ctrl":
                                mItem.Text += $"(&{keyArr[1]})";
                                mItem.ShortcutKeys = (Keys.Control | key);
                                break;
                            case "Shift":
                                mItem.Text += $"(&{keyArr[1]})";
                                mItem.ShortcutKeys = (Keys.Shift | key);
                                break;
                        }
                    }
                    else if (keyArr.Length == 3)
                    {
                        Keys key = (Keys)Enum.Parse(typeof(Keys), keyArr[2]);
                        string twoKeys = keyArr[0] + "+" + keyArr[1];
                        switch (twoKeys)
                        {
                            case "Ctrl+Shift":
                                mItem.ShortcutKeys = (Keys.Control | Keys.Shift | key);
                                break;
                            case "Ctrl+Alt":
                                mItem.ShortcutKeys = (Keys.Control | Keys.Alt | key);
                                break;
                            case "Shift+Alt":
                                mItem.ShortcutKeys = (Keys.Shift | Keys.Alt | key);
                                break;
                        }
                    }
                }
                // 页面地址
                if (!string.IsNullOrEmpty(menuInfo.FrmURL))
                {
                    mItem.Tag = menuInfo.FrmURL; // 传递页面地址
                }
                // 单击事件订阅（无子菜单的项）
                if (allMenuList.Where(m => m.ParentId == menuInfo.MenuId).Count() == 0)
                {
                    mItem.Click += MItem_Click;
                }
                // 菜单项添加在哪一级
                if (parentMenu != null)
                    parentMenu.DropDownItems.Add(mItem);
                else
                    cainiaoMenus.Items.Add(mItem);
                // 递归调用
                CreateMenuItems(allMenuList, mItem, menuInfo.MenuId); // 创建当前菜单项的子菜单
            }
        }

        /// <summary>
        /// 菜单响应事件处理程序
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <exception cref="NotImplementedException"></exception>
        private void MItem_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
