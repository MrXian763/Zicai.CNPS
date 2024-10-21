using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zicai.CaiNiaoPostStation.Utility
{
    public static class FormUtility
    {
        /// <summary>
        /// 显示异常信息
        /// </summary>
        /// <param name="lblErr">要显示的标签</param>
        /// <param name="msg">异常信息</param>
        public static void SerErrorMsg(this Label lblErr, string msg)
        {
            if (!lblErr.Visible)
                lblErr.Visible = true;
            lblErr.Text = msg;
        }

        /// <summary>
        /// 添加窗体到选项卡中
        /// </summary>
        /// <param name="tab"></param>
        /// <param name="form"></param>
        /// <param name="index"></param>
        public static void AddTabFormPage(this TabControl tab, Form form, int index = -1)
        {
            TabPage page = null;
            Form frm = GetOpenForm(form.Name); // 查找指定Form是否已经打开
            if (frm == null)
            {
                frm = form;
                frm.FormBorderStyle = FormBorderStyle.None;
                frm.TopLevel = false;
                frm.WindowState = FormWindowState.Maximized;
                page = new TabPage();
                frm.Parent = page;
                frm.Dock = DockStyle.Fill;
                page.Name = frm.Name;
                page.Text = frm.Text;
                if (index != -1)
                    tab.TabPages.Insert(index, page);
                else
                    tab.TabPages.Add(page);
                frm.Show();
            }
            else
            {
                page = tab.TabPages[frm.Name];
            }
            tab.SelectedTab = page;
        }

        /// <summary>
        /// 返回指定的Form
        /// </summary>
        /// <param name="formName">Form名称</param>
        /// <returns>Form页面</returns>
        public static Form GetOpenForm(string formName)
        {
            Form f = null;
            foreach (Form frm in Application.OpenForms)
            {
                if (frm.Name == formName)
                {
                    f = frm;
                    break;
                }
            }
            return f;
        }
    }
}
