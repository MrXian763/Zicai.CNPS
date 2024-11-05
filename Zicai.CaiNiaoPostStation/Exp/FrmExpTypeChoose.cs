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
using ZiCai.CainiaoPostStation.Models;
using Zicai.CaiNiaoPostStation.Utility;

namespace Zicai.CaiNiaoPostStation.Exp
{
    public partial class FrmExpTypeChoose : Form
    {
        public FrmExpTypeChoose()
        {
            InitializeComponent();
        }

        ExpressTypeBLL expressTypeBLL = new ExpressTypeBLL();
        public event EventHandler<ChooseExpTypeArgs> ExpTypeChoosed; // 快递类别选择事件

        string expType = ""; // 快递类别信息
        List<string> checkedItems = new List<string>();

        /// <summary>
        /// 页面加载触发
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmExpTypeChoose_Load(object sender, EventArgs e)
        {
            if (this.Tag != null)
            {
                expType = this.Tag.ToString();
            }
            LoadChkTypeList();
        }

        /// <summary>
        /// 加载类别可选列表
        /// </summary>
        private void LoadChkTypeList()
        {
            List<ExpressTypeInfo> typeList = expressTypeBLL.GetCboExpTypes(); // 获取快递类别数据
            chkExpTypes.DataSource = typeList;
            chkExpTypes.DisplayMember = "ExpTypeName"; // 展示类别名称
            // 如果有已设置的类别信息，进行加载
            if (!string.IsNullOrEmpty(expType))
            {
                string[] types = expType.Split(' ').Where(s => s != "").ToArray(); // 分隔成子项
                for (int i = 0; i < chkExpTypes.Items.Count; i++)
                {
                    string name = (chkExpTypes.Items[i] as ExpressTypeInfo).ExpTypeName; // 获取当前项的名称
                    if (types.Contains(name))
                    {
                        checkedItems.Add(name); // 选中
                        chkExpTypes.SetItemChecked(i, true);
                    }
                }
            }
        }

        /// <summary>
        /// 切换项的勾选状态的响应
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chkExpTypes_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            string name = (chkExpTypes.Items[e.Index] as ExpressTypeInfo).ExpTypeName;
            if (e.NewValue == CheckState.Checked)
            {
                if (!checkedItems.Contains(name))
                    checkedItems.Add(name);
            }
            else
            {
                if (checkedItems.Contains(name))
                    checkedItems.Remove(name);
            }
            txtExpType.Text = String.Join(" ", checkedItems);
        }

        /// <summary>
        /// 确定并返回
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOK_Click(object sender, EventArgs e)
        {
            string choosedType = txtExpType.Text.Trim();
            if (string.IsNullOrEmpty(choosedType))
            {
                lblErrMsg.SetErrorMsg("请选择快递类别！");
                return;
            }
            ExpTypeChoosed?.Invoke(this, new ChooseExpTypeArgs(choosedType)); // 更新快递信息页面快递类别显示
            this.Close(); // 关闭当前页面
        }
    }
}
