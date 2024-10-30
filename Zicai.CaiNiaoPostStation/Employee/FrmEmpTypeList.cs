using Common;
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
using Zicai.CaiNiaoPostStation.Utility;
using ZiCai.CaiNiaoPostStation.Utility;

namespace Zicai.CaiNiaoPostStation.Employee
{
    public partial class FrmEmpTypeList : Form
    {
        public FrmEmpTypeList()
        {
            InitializeComponent();
        }

        EmpTypeBLL empTypeBLL = new EmpTypeBLL();
        Action refreshCboList = null; // 跨页面刷新下拉框
        
        /// <summary>
        /// 列表加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmEmpTypeList_Load(object sender, EventArgs e)
        {
            dgvEmpTypeList.AutoGenerateColumns = false; // 不自动创建列
            // 加载员工类别列表
            LoadEmpTypeList();
            if (this.Tag != null)
            {
                refreshCboList = this.Tag as Action;
            }
        }

        /// <summary>
        /// 加载员工类别列表
        /// </summary>
        private void LoadEmpTypeList()
        {
            bool showDel = chkShowDel.Checked;
            DataTable dtList = empTypeBLL.GetEmpTypeList(showDel);
            dgvEmpTypeList.DataSource = dtList;
            // 设置操作列显示
            SetDgvColsVisible(showDel);
        }

        /// <summary>
        /// 设置操作列显示
        /// </summary>
        /// <param name="blShow">是否展示已删除数据</param>
        private void SetDgvColsVisible(bool blShow)
        {
            dgvEmpTypeList.Columns["colDel"].Visible = !blShow;
            dgvEmpTypeList.Columns["colRecover"].Visible = blShow;
            dgvEmpTypeList.Columns["colRemove"].Visible = blShow;
        }

        /// <summary>
        /// 已删除复选框改变
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chkShowDel_CheckedChanged(object sender, EventArgs e)
        {
            LoadEmpTypeList();
        }

        /// <summary>
        /// 单元格结束编辑时发生-----提示名称为空
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvEmpTypeList_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewCell curCell = dgvEmpTypeList.Rows[e.RowIndex].Cells[e.ColumnIndex];
            if (curCell.Value != null && curCell.Value.ToString() == "")
            {
                if (curCell.OwningColumn == dgvEmpTypeList.Columns["colEmpTypeName"])
                {
                    lblErrorMsg.SetErrorMsg("请输入员工类别！");
                    return;
                }
            }
        }

        /// <summary>
        /// 操作列的响应
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvEmpTypeList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            lblErrorMsg.Visible = false;
            DataGridViewCell curCell = dgvEmpTypeList.Rows[e.RowIndex].Cells[e.ColumnIndex];
            string cellVallue = curCell.FormattedValue.ToString();
            //行对象
            DataRow dr = (dgvEmpTypeList.Rows[e.RowIndex].DataBoundItem as DataRowView).Row;
            switch (cellVallue)
            {
                case "删除":
                    DeleteEmpType(dr, 1);
                    break;
                case "恢复":
                    DeleteEmpType(dr, 0);
                    break;
                case "移除":
                    DeleteEmpType(dr, 2);
                    break;
            }
        }

        /// <summary>
        /// 删除、恢复、移除员工类别数据
        /// </summary>
        /// <param name="dr">选择的行数据</param>
        /// <param name="isDeleted">1-删除；0-恢复；2-移除</param>
        private void DeleteEmpType(DataRow dr, int isDeleted)
        {
            string[] titleMsg = FormUtility.GetActTitleAndMsg("员工类别", isDeleted);
            string msgTitle = titleMsg[0];
            string msg = titleMsg[1];
            if (MessageHelper.Confirm(msgTitle, msg) == DialogResult.OK)
            {
                // 执行删除
                switch (isDeleted)
                {
                    case 1:
                        int typeId = dr["EmpTypeId"].ToString().GetInt();
                        if (!empTypeBLL.IsHasEmployee(typeId)) // false 可以删除
                        {
                            dr["IsDeleted"] = 1;
                        }
                        else
                        {
                            lblErrorMsg.SetErrorMsg("该类别下已包含员工，不能删除！");
                            return;
                        }
                        break;
                    case 0:
                        dr["IsDeleted"] = 0;
                        break;
                    case 2:
                        dr.Delete();
                        break;
                }
            }
        }

        /// <summary>
        /// 新增类别信息提交
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            DataTable dtList = dgvEmpTypeList.DataSource as DataTable;
            if (dtList.Rows.Count > 0)
            {
                int count = 0;
                // 监控行状态：Added  Modified  Deleted
                foreach (DataRow dr in dtList.Rows)
                {
                    if (dr.RowState == DataRowState.Added || dr.RowState == DataRowState.Modified || dr.RowState == DataRowState.Deleted)
                        count += 1;
                }
                if (count > 0)
                {
                    bool blSave = empTypeBLL.SaveEmpTypeInfos(dtList);
                    if (blSave)
                    {
                        MessageHelper.Info("保存员工类别", "员工类别信息保存成功！");
                        LoadEmpTypeList();
                    }
                    else
                    {
                        lblErrorMsg.SetErrorMsg("员工类别信息保存失败！");
                        return;
                    }
                }
                else
                {
                    lblErrorMsg.SetErrorMsg("没有可提交的类别信息！");
                    return;
                }
            }
        }

        /// <summary>
        /// 刷新下拉框
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmEmpTypeList_FormClosing(object sender, FormClosingEventArgs e)
        {
            refreshCboList?.Invoke(); // 调用委托实现下拉框刷新
        }
    }
}
