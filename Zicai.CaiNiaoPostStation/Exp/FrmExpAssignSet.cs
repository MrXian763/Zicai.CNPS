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
using ZiCai.CainiaoPostStation.Models;
using Zicai.CaiNiaoPostStation.Utility;
using ZiCai.CaiNiaoPostStation.Utility;

namespace Zicai.CaiNiaoPostStation.Exp
{
    public partial class FrmExpAssignSet : Form
    {
        public FrmExpAssignSet()
        {
            InitializeComponent();
        }

        EmployeeBLL employeeBLL = new EmployeeBLL();
        DistributeExpressBLL distributeExpressBLL = new DistributeExpressBLL();
        public int stationId = 0;
        public event EventHandler<DistributeExpressArgs> ReLoadDisExpressList; // 刷新事件
        List<int> expIds = new List<int>();

        /// <summary>
        /// 页面加载触发
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmExpAssignSet_Load(object sender, EventArgs e)
        {
            if (this.Tag != null)
            {
                expIds = this.Tag as List<int>;
                // 加载员工列表
                FormUtility.LoadCboEmployees(stationId, cboEmpList, employeeBLL);
                // 初始化日期时间
                dtDate.Value = DateTime.Now;
                dtTime.Value = DateTime.Now;
            }
        }

        /// <summary>
        /// 选择派送员
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cboEmpList_SelectedIndexChanged(object sender, EventArgs e)
        {
            int empId = cboEmpList.SelectedValue.GetInt(); // 获取选中的派送员ID
            txtDisPhone.Text = employeeBLL.GetEmployee(empId).Phone; // 获取派送员电话
        }

        /// <summary>
        /// 保存派送安排信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOk_Click(object sender, EventArgs e)
        {
            int empId = cboEmpList.SelectedValue.GetInt(); // 快递员ID
            string date = dtDate.Text.Trim();
            string time = dtTime.Text.Trim();
            DateTime disTime = DateTime.Parse(date + " " + time); // 派送日期时间
            if (empId == 0)
            {
                lblErrMsg.SetErrorMsg("请选择派送员！");
                cboEmpList.Focus();
                return;
            }
            if (date == "" || time == "")
            {
                lblErrMsg.SetErrorMsg("请设置派送日期和时间！");
                dtDate.Focus();
                return;
            }
            // 保存派送安排
            bool blSave = distributeExpressBLL.SaveDistributeAssignSet(expIds, empId, disTime);
            if (blSave)
            {
                MessageHelper.Info("派送安排", "派送安排保存成功！");
                // 构造快递员信息
                EmployeeInfo empInfo = new EmployeeInfo()
                {
                    EmpId = empId,
                    EmpName = cboEmpList.Text.Trim(),
                    Phone = txtDisPhone.Text.Trim()
                };
                DistributeExpressArgs args = new DistributeExpressArgs(expIds, empInfo, disTime);
                ReLoadDisExpressList?.Invoke(this, args); // 刷新派送列表
                this.Close(); // 关闭当前窗口
            }
            else
            {
                lblErrMsg.SetErrorMsg("派送安排保存失败！");
                return;
            }
        }

        /// <summary>
        /// 点击关闭按钮触发
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
