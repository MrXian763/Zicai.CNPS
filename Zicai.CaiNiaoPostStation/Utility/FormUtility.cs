using Common;
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
        /// 打开对应类型的Form页面
        /// </summary>
        /// <typeparam name="T">要创建的Form类型</typeparam>
        /// <param name="tab"></param>
        public static void ShowTabFormPage<T>(this TabControl tab) where T : Form
        {
            Form frm = Activator.CreateInstance<T>(); // 反射创建Form实例
            tab.AddTabFormPage(frm); // 添加到TabControl中
        }

        /// <summary>
        /// 从导航页打开对应页面
        /// </summary>
        /// <typeparam name="T">当前导航页</typeparam>
        /// <param name="tab"></param>
        public static void ShowNavForm<T>(this Form currentForm) where T : Form
        {
            TabControl tab = currentForm.Parent.Parent as TabControl;
            tab.ShowTabFormPage<T>();
        }

        /// <summary>
        /// 显示异常信息
        /// </summary>
        /// <param name="lblErr">要显示的标签</param>
        /// <param name="msg">异常信息</param>
        public static void SetErrorMsg(this Label lblErr, string msg)
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

        /// <summary>
        /// 关闭指定的Form
        /// </summary>
        /// <param name="formName">Form名称</param>
        public static void CloseOpenForm(string formName)
        {
            foreach (Form frm in Application.OpenForms)
            {
                if (frm.Name == formName)
                {
                    frm.Close();
                    break;
                }
            }
        }

        /// <summary>
        /// 更新DataGridView数据
        /// </summary>
        /// <typeparam name="T">要更新的数据模型</typeparam>
        /// <param name="dgv">要更新的表格</param>
        /// <param name="actType">更新类型：1-添加；2-修改</param>
        /// <param name="info">新数据</param>
        /// <param name="id">当前行数据主键</param>
        public static void UpdateDgv<T>(this DataGridView dgv, int actType, T info, int id)
        {
            List<T> list = dgv.DataSource as List<T>;
            if (list == null)
                list = new List<T>();
            dgv.DataSource = null;
            if (actType == 1) // 添加
                list.Add(info);
            else if (actType == 2) // 修改
            {
                int index = -1; // 要更新的行索引
                Type type = typeof(T);
                string keyName = type.GetPrimaryName(); // 主键名
                foreach (T t in list)
                {
                    int uid = (int) type.GetProperty(keyName).GetValue(t);
                    if (uid == id)
                    {
                        index = list.IndexOf(t); // 找到要更新的行索引位置
                        break;
                    }
                }
                list[index] = info;
                
            }
            dgv.DataSource = list;
        }

        /// <summary>
        /// 更新DataGridView 删除、恢复、移除
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="dgv"></param>
        /// <param name="delList"></param>
        public static void UpdateDgv<T>(this DataGridView dgv, List<T> delList)
        {
            List<T> list = dgv.DataSource as List<T>;
            dgv.DataSource = null;
            delList.ForEach(t => list.Remove(t));
            dgv.DataSource = list;
        }

        /// <summary>
        /// 生成删除、恢复、移除操作的询问框的标题和提示消息
        /// </summary>
        /// <param name="infoName">操作的对象</param>
        /// <param name="isDeleted">操作类型</param>
        /// <returns>提示信息数组：[0]操作名称；[1]提示消息</returns>
        public static string[] GetActTitleAndMsg(string infoName, int isDeleted)
        {
            string typeName = GetDelTypeName(isDeleted);
            string title = $"{typeName}{infoName}";
            string msg = $"你确定要对该{infoName}信息进行{typeName}吗？";
            return new string[] { title, msg };
        }

        /// <summary>
        /// 获取操作的名称
        /// </summary>
        /// <param name="isDeleted"></param>
        /// <returns></returns>
        public static string GetDelTypeName(int isDeleted)
        {
            string typeName = "";
            switch (isDeleted)
            {
                case 1: typeName = "删除"; break;
                case 0: typeName = "恢复"; break;
                case 2: typeName = "移除"; break;
                default: break;
            }
            return typeName;
        }
    }
}
