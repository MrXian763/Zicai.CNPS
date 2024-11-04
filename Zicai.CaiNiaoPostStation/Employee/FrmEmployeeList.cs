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
using ZiCai.CainiaoPostStation.Models;
using ZiCai.CainiaoPostStation.Models.UIModels;
using ZiCai.CaiNiaoPostStation.Models.VModels;
using ZiCai.CaiNiaoPostStation.Utility;
using ZXIMEW.Common;

namespace Zicai.CaiNiaoPostStation.Employee
{
    public partial class FrmEmployeeList : Form
    {
        public FrmEmployeeList()
        {
            InitializeComponent();
        }

        StationBLL stationBLL = new StationBLL();
        EmpTypeBLL empTypeBLL = new EmpTypeBLL();
        EmployeeBLL employeeBLL = new EmployeeBLL();
        int actType = 1; // 提交状态
        int editEmpId = 0; // 当前修改的员工编号
        bool isFirst = true; // 第一次加载
        int totalCount = 0; // 总员工数
        string oldNo = "";
        string oldName = "";
        string oldPhone = "";
        Random random = new Random(); // 随机数

        /// <summary>
        /// 页面加载触发
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmEmployeeList_Load(object sender, EventArgs e)
        {
            // 加载下拉框
            LoadCboEmpTypes();
            LoadCboStations();

            dgvEmployeeList.CurrentCellDirtyStateChanged += FormUtility.DgvList_CurrentCellDirtyStateChanged;

            // 加载员工列表
            FindEmployeeList();
            // 初始化信息栏
            InitEmployeeInfo();
        }

        /// <summary>
        /// 加载员工类别下拉框数据
        /// </summary>
        private void LoadCboEmpTypes()
        {
            List<EmpTypeInfo> typeList01 = empTypeBLL.GetCboEmpTypes();
            typeList01.Insert(0, new EmpTypeInfo()
            {
                EmpTypeId = 0,
                EmpTypeName = "员工类别"
            });
            List<EmpTypeInfo> typeList02 = new List<EmpTypeInfo>();
            typeList01.ForEach(t => typeList02.Add(t));

            cboEmpTypes.DisplayMember = "EmpTypeName";
            cboEmpTypes.ValueMember = "EmpTypeId";
            cboEmpTypes.DataSource = typeList01;

            cboEmpTypeSearch.DisplayMember = "EmpTypeName";
            cboEmpTypeSearch.ValueMember = "EmpTypeId";
            cboEmpTypeSearch.DataSource = typeList02;
            cboEmpTypeSearch.SelectedIndex = 0;

        }

        /// <summary>
        /// 加载站点下拉框数据
        /// </summary>
        private void LoadCboStations()
        {
            FormUtility.LoadCboStations(cboStations, stationBLL);
            FormUtility.LoadCboStations(cboStationSearch, stationBLL);
            cboStationSearch.SelectedIndex = 0;
        }

        /// <summary>
        /// 查询员工列表
        /// </summary>
        private void FindEmployeeList()
        {
            string keywords = txtKeyWordSearch.Text.Trim();
            int empTypeId = cboEmpTypeSearch.SelectedValue.GetInt();
            int stationId = cboStationSearch.SelectedValue.GetInt();
            bool showDel = chkShowDel.Checked;
            int startIndex = uPager1.StartIndex; // 当页的开始索引
            int pageSize = uPager1.PageSize; // 每页记录数
            dgvEmployeeList.AutoGenerateColumns = false;
            PageModel<ViewEmployeeInfo> pageModel = employeeBLL.FindEmployeeList(keywords, empTypeId, stationId, showDel, startIndex, pageSize);
            if (pageModel.TotalCount > 0)
            {
                dgvEmployeeList.DataSource = pageModel.PageList;
                uPager1.Record = pageModel.TotalCount;
                if (isFirst)
                {
                    totalCount = pageModel.TotalCount;
                    isFirst = false;
                }
                uPager1.Enabled = true;
            }
            else
            {
                dgvEmployeeList.DataSource = null;
                uPager1.Enabled = false;
            }
            SetActBtnsAndColVisible(showDel);
        }

        /// <summary>
        /// 设置按钮可见
        /// </summary>
        /// <param name="showDel">是否显示已删除数据</param>
        private void SetActBtnsAndColVisible(bool showDel)
        {
            btnDelete.Visible = !showDel;
            btnRecover.Visible = showDel;
            btnRemove.Visible = showDel;
            dgvEmployeeList.Columns["colEdit"].Visible = !showDel;
            dgvEmployeeList.Columns["colLeave"].Visible = !showDel;
        }

        /// <summary>
        /// 信息栏初始化
        /// </summary>
        private void InitEmployeeInfo()
        {
            foreach (Control c in gbEmpInfo.Controls)
            {
                if (c is TextBox)
                {
                    c.Text = "";
                }
                else if (c is ComboBox)
                {
                    ComboBox cmb = (ComboBox)c;
                    cmb.SelectedIndex = 0;
                }
                tbtnMale.Checked = true;
                chkIsOn.Checked = false;
            }
            // 默认生成初始员工号
            string createNo = "E";
            totalCount++;
            createNo += random.Next(0, 100000000).ToString("D8"); // 0到99999999之间的随机数，不足8位前补0
            txtEmpNo.Text = createNo;

            actType = 1;
            btnOk.Text = "添加";
            lblErrMsg.Visible = false;
        }

        /// <summary>
        /// 重置
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReset_Click(object sender, EventArgs e)
        {
            InitEmployeeInfo();
        }

        /// <summary>
        /// 查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFind_Click(object sender, EventArgs e)
        {
            FindEmployeeList();
        }

        /// <summary>
        /// 已删除切换
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chkShowDel_CheckedChanged(object sender, EventArgs e)
        {
            FindEmployeeList();
        }

        /// <summary>
        /// 翻页
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uPager1_PageChanged(object sender, EventArgs e)
        {
            FindEmployeeList();
        }

        /// <summary>
        /// 搜索员工类型条件改变触发
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cboEmpTypeSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            FindEmployeeList();
        }

        /// <summary>
        /// 搜索站点条件改变触发
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cboStationSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            FindEmployeeList();
        }

        Action reloadTypeList = null;
        /// <summary>
        /// 点击类别链接触发
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void linkTypes_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            reloadTypeList = LoadCboEmpTypes;
            this.ShowNavForm<FrmEmpTypeList>(reloadTypeList);
        }

        List<ViewEmployeeInfo> selectItems = new List<ViewEmployeeInfo>(); // 选择行的数据列表
        /// <summary>
        /// 选择表格行数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvEmployeeList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // 当前单元格
            DataGridViewCell cell = dgvEmployeeList.Rows[e.RowIndex].Cells[e.ColumnIndex];
            ViewEmployeeInfo info = dgvEmployeeList.Rows[e.RowIndex].DataBoundItem as ViewEmployeeInfo;
            // 选择行
            if (cell is DataGridViewCheckBoxCell)
            {
                if (cell.FormattedValue.ToString() == "True")
                    selectItems.Add(info);
                else
                    selectItems.Remove(info);
            }
            else if (cell is DataGridViewLinkCell)
            {
                string cellValue = cell.FormattedValue.ToString();
                switch (cellValue)
                {
                    case "修改":
                        InitEditSEmpInfo(info);
                        break;
                    case "离职":
                        EmpLeaveOut(info);
                        break;
                }
            }
        }

        /// <summary>
        /// 修改行数据
        /// </summary>
        /// <param name="info">员工信息</param>
        private void InitEditSEmpInfo(ViewEmployeeInfo info)
        {
            // 将改行数据更新到信息栏
            if (info != null)
            {
                txtEmpNo.Text = info.EmpNo;
                txtEmpName.Text = info.EmpName;
                if (info.Sex == "男")
                    tbtnMale.Checked = true;
                else
                    rbtnFemale.Checked = true;
                txtAge.Text = info.Age.ToString();
                txtPYNo.Text = info.EmpPYNo;
                txtPhone.Text = info.Phone;
                cboEmpTypes.SelectedValue = info.EmpTypeId;
                cboStations.SelectedValue = info.StationId;
                txtRemark.Text = info.Remark;
                chkIsOn.Checked = info.IsOn;
                editEmpId = info.EmpId;
                oldName = info.EmpName;
                oldNo = info.EmpNo;
                oldPhone = info.Phone;
                actType = 2;
                btnOk.Text = "修改";
            }
        }

        /// <summary>
        /// 离职
        /// </summary>
        /// <param name="info">员工信息</param>
        private void EmpLeaveOut(ViewEmployeeInfo info)
        {
            string[] titleMsg = FormUtility.GetActTitleAndMsg("员工", 3);
            string msgTitle = titleMsg[0];
            string msg = titleMsg[1];
            if (MessageHelper.Confirm(msgTitle, msg) == DialogResult.OK)
            {
                int reVal = employeeBLL.EmpLeaveOut(info);
                if (reVal == 1)
                {
                    MessageHelper.Info(msgTitle, $"员工：{info.EmpNo}-{info.EmpName} 离职办理成功！");
                    info.IsOn = false;
                }
                else if (reVal == 2)
                {
                    MessageHelper.Error(msgTitle, $"员工：{info.EmpNo}-{info.EmpName} 还未完成任务，请先处理！");
                    return;
                }
                else
                {
                    MessageHelper.Error(msgTitle, $"员工：{info.EmpNo}-{info.EmpName} 离职办理失败！");
                    return;
                }
            }
        }

        /// <summary>
        /// 员工信息提交
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOk_Click(object sender, EventArgs e)
        {
            // 接收信息
            string empNo = txtEmpNo.Text.Trim();
            string empName = txtEmpName.Text.Trim();
            string sex = tbtnMale.Checked ? "男" : "女";
            int? age = null;
            int age1 = txtAge.Text.GetInt();
            if (age1 > 0)
                age = age1;
            string phone = txtPhone.Text.Trim();
            string pyno = txtPYNo.Text.Trim();
            int empTypeId = cboEmpTypes.SelectedValue.GetInt();
            int stationId = cboStations.SelectedValue.GetInt();
            bool isOn = chkIsOn.Checked;
            string remark = txtRemark.Text.Trim();
            // 信息检查
            if (string.IsNullOrEmpty(empNo))
            {
                lblErrMsg.SetErrorMsg("请输入员工号！");
                txtEmpNo.Focus();
                return;
            }
            else if ((actType == 1 || (actType == 2 && oldNo != empNo)) && employeeBLL.ExistEmpNo(empNo))
            {
                lblErrMsg.SetErrorMsg("该员工号已存在！");
                txtEmpNo.Focus();
                return;
            }
            if (string.IsNullOrEmpty(empName))
            {
                lblErrMsg.SetErrorMsg("请输入员工姓名！");
                txtEmpName.Focus();
                return;
            }
            if (string.IsNullOrEmpty(phone))
            {
                lblErrMsg.SetErrorMsg("请输入员工电话！");
                txtPhone.Focus();
                return;
            }
            else if ((actType == 1 || (actType == 2 && (oldName != empName || oldPhone != phone))) && employeeBLL.ExistEmpInfo(empName, phone))
            {
                lblErrMsg.SetErrorMsg("该员工信息已存在！");
                txtEmpName.Focus();
                return;
            }
            if (empTypeId == 0)
            {
                lblErrMsg.SetErrorMsg("请选择员工类别！");
                return;
            }
            if (stationId == 0)
            {
                lblErrMsg.SetErrorMsg("请选择所在站点！");
                return;
            }

            // 封装信息
            EmployeeInfo empInfo = new EmployeeInfo()
            {
                EmpId = editEmpId,
                EmpNo = empNo,
                EmpName = empName,
                Sex = sex,
                Age = age,
                EmpPYNo = pyno,
                Phone = phone,
                EmpTypeId = empTypeId,
                StationId = stationId,
                Remark = remark,
                IsOn = isOn
            };
            ViewEmployeeInfo vempInfo = new ViewEmployeeInfo(empInfo, cboStations.Text, cboEmpTypes.Text);
            // 提交处理
            if (actType == 1)
            {
                int reId = employeeBLL.AddEmployee(empInfo);
                if (reId > 0)
                {
                    MessageHelper.Info("添加员工", $"员工：{empName} 添加成功！");
                    empInfo.EmpId = reId;
                    // 添加员工信息到员工列表中
                    dgvEmployeeList.UpdateDgv(1, vempInfo, 0);
                    editEmpId = reId;
                    btnOk.Text = "修改";
                    actType = 2;
                    oldName = empName;
                    oldNo = empNo;
                    oldPhone = phone;
                    FindEmployeeList(); // 刷新表格数据
                }
                else
                {
                    lblErrMsg.SetErrorMsg("员工信息添加失败！");
                    return;
                }
            }
            else
            {
                bool blEdit = employeeBLL.UpdateEmployee(empInfo);
                if (blEdit)
                {
                    MessageHelper.Info("修改员工", $"员工：{empName} 修改成功！");
                    oldName = empName;
                    oldNo = empNo;
                    oldPhone = phone;
                    // 更新员工信息到站员工列表中
                    dgvEmployeeList.UpdateDgv(2, vempInfo, editEmpId);
                }
                else
                {
                    lblErrMsg.SetErrorMsg("员工信息修改失败！");
                    return;
                }
            }
        }

        /// <summary>
        /// 员工名称输入框改变更新拼音码
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtEmpName_TextChanged(object sender, EventArgs e)
        {
            string empName = txtEmpName.Text.Trim();
            txtPYNo.Text = PingYinHelper.GetFirstSpell(empName);
        }

        /// <summary>
        /// 鼠标点击输入框隐藏错误提示
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TextBox_MouseDown(object sender, MouseEventArgs e)
        {
            lblErrMsg.Visible = false;
            lblErrMsg.Text = "";
        }

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteEmployees(1);
        }

        /// <summary>
        /// 恢复
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRecover_Click(object sender, EventArgs e)
        {
            DeleteEmployees(0);
        }

        /// <summary>
        /// 移除
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRemove_Click(object sender, EventArgs e)
        {
            DeleteEmployees(2);
        }

        /// <summary>
        /// 员工信息的删除、恢复、移除功能
        /// </summary>
        /// <param name="isDeleted">1-逻辑删除；0-恢复；2-删除</param>
        private void DeleteEmployees(int isDeleted)
        {
            string actName = FormUtility.GetDelTypeName(isDeleted);
            string msgTitle = $"{actName}员工";
            if (selectItems.Count > 0)
            {
                if (MessageHelper.Confirm(msgTitle, $"你确定要{actName}选择的员工信息吗？") == DialogResult.OK)
                {
                    bool bl = false; // 执行结果（恢复、移除）
                    List<int> delIds = selectItems.Select(s => s.EmpId).ToList(); // 选择的员工编号集合
                    switch (isDeleted)
                    {
                        case 1:
                            string reStr = employeeBLL.DeleteEmployees(selectItems); // 执行删除方法
                            string[] reArr = reStr.Split(';');
                            if (reArr[0] == "1")
                            {
                                if (reArr.Length == 1)
                                {
                                    // 删除成功，没有不能删除的员工
                                    MessageHelper.Info(msgTitle, "选择的员工信息删除成功！");
                                    dgvEmployeeList.UpdateDgv(selectItems);
                                }
                                else
                                {
                                    MessageHelper.Info(msgTitle, $"选择的员工中，{reArr[1]}都还在职，不能删除！其余的员工信息删除成功！");
                                    // 刷新  筛选出能删除员工
                                    var delList = selectItems.Where(emp => emp.IsOn == false).ToList();
                                    dgvEmployeeList.UpdateDgv(delList);
                                }
                                selectItems.Clear();// 清空选择列表
                            }
                            else if (reArr[0] == "0")
                            {
                                MessageHelper.Error(msgTitle, "选择的员工信息删除失败！");
                                return;
                            }
                            else
                            {
                                MessageHelper.Error(msgTitle, "选择的员工都还在职，不能删除！");
                                return;
                            }
                            break;
                        case 0:
                            bl = employeeBLL.RecoverEmployees(delIds); // 恢复
                            break;
                        case 2:
                            bl = employeeBLL.RemoveEmployees(delIds); // 永久删除
                            break;
                    }
                    if (isDeleted != 1)
                    {
                        if (bl)
                        {
                            MessageHelper.Info(msgTitle, $"选择的员工{actName}成功！");
                            dgvEmployeeList.UpdateDgv(selectItems);
                            selectItems.Clear();
                        }
                        else
                        {
                            MessageHelper.Error(msgTitle, $"选择的员工信息{actName}失败！");
                            return;
                        }
                    }
                }
            }
            else
            {
                MessageHelper.Error(msgTitle, $"请选择要{actName}的员工信息");
                return;
            }
        }
    }
}
