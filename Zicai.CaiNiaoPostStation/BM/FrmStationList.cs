using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZiCai.CainiaoPostStation.Models.UIModels;
using Zicai.CaiNiaoPostStation.BLL;
using Zicai.CaiNiaoPostStation.Models;
using Zicai.CaiNiaoPostStation.Utility;
using ZiCai.CaiNiaoPostStation.Utility;
using ZXIMEW.Common;

namespace Zicai.CaiNiaoPostStation.BM
{
    public partial class FrmStationList : Form
    {
        public FrmStationList()
        {
            InitializeComponent();
        }

        StationBLL stationBLL = new StationBLL();

        int actType = 1; // 信息提交状态 1-新增；2-修改
        int editStationId = 0; // 当前正在修改的站点ID
        bool isFirst = true; // 是否第一次加载
        int totalCount = 0; // 总站点数
        Random random = new Random(); // 随机数
        string oldNo = "", oldName = ""; // 修改前的站点编号、名称

        /// <summary>
        /// 页面加载触发
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmStationList_Load(object sender, EventArgs e)
        {
            this.dgvStationList.CurrentCellDirtyStateChanged += new System.EventHandler(FormUtility.DgvList_CurrentCellDirtyStateChanged);
            // 加载站点列表
            FindStationList();
            // 初始化站点信息栏
            InitStationInfo();
        }

        /// <summary>
        /// 加载站点列表
        /// </summary>
        private void FindStationList()
        {
            string keywords = txtKeyWords.Text.Trim(); // 查询关键词
            bool showDel = chkShowDel.Checked; // 是否显示删除的站点数据
            int startIndex = uPager1.StartIndex; // 当页起始索引
            int pageSize = uPager1.PageSize; // 每页记录数
            dgvStationList.AutoGenerateColumns = false;
            PageModel<StationInfo> pageModel = stationBLL.FindStationList(keywords, showDel, startIndex, pageSize);
            if (pageModel.TotalCount > 0) // 有站点数据
            {
                dgvStationList.DataSource = pageModel.PageList;
                uPager1.Record = pageModel.TotalCount;
                if (isFirst)
                {
                    totalCount = pageModel.TotalCount;
                    isFirst = false;
                }
            }
            else // 无站点数据
            {
                dgvStationList.DataSource = null; // 站点列表数据源为空
                uPager1.Enabled = false; // 分页控件禁用
            }
            SetActBinsAndColVisible(showDel); // 设置操作栏按钮、列的操作按钮显示或隐藏
        }

        /// <summary>
        /// 初始化站点信息栏
        /// </summary>
        private void InitStationInfo()
        {
            foreach (Control c in gbStationInfo.Controls)
            {
                if (c is TextBox)
                {
                    c.Text = ""; // 清空文本框
                }
                else if (c is CheckBox)
                {
                    ((CheckBox)c).Checked = false; // 取消勾选
                }
            }
            lblErrMsg.Visible = false; // 隐藏错误信息
            // 默认生成初始编码
            string defaultNo = "S";
            totalCount++;
            defaultNo += random.Next(0, 100000000).ToString("D8"); // 0到99999999之间的随机数，不足8位前补0
            txtStationNo.Text = defaultNo;
            actType = 1; // 新增
            btnOk.Text = "添加";
        }

        /// <summary>
        /// 设置操作栏按钮、列的操作按钮显示或隐藏
        /// </summary>
        /// <param name="showDel">是否显示删除的数据</param>
        private void SetActBinsAndColVisible(bool showDel)
        {
            btnDelete.Visible = !showDel;
            btnRecover.Visible = showDel;
            btnRemove.Visible = showDel;
            dgvStationList.Columns["colEdit"].Visible = !showDel;
            dgvStationList.Columns["colDel"].Visible = !showDel;
            dgvStationList.Columns["colRecover"].Visible = showDel;
            dgvStationList.Columns["colRemove"].Visible = showDel;
        }

        /// <summary>
        /// 查询按钮触发
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnQuery_Click(object sender, EventArgs e)
        {
            FindStationList(); // 加载站点列表
        }

        /// <summary>
        /// 显示删除的站点复选框改变触发
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chkShowDel_CheckedChanged(object sender, EventArgs e)
        {
            FindStationList(); // 加载站点列表
        }

        /// <summary>
        /// 分页控件页码改变触发
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uPager1_PageChange(object sender, EventArgs e)
        {
            FindStationList(); // 加载站点列表
        }

        /// <summary>
        /// 重置按钮触发
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReset_Click(object sender, EventArgs e)
        {
            InitStationInfo(); // 初始化站点信息栏
        }

        List<StationInfo> selectedStations = new List<StationInfo>(); // 选择行的数据列表

        /// <summary>
        /// 表格行内容单元格点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvStationList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewCell cell = dgvStationList.Rows[e.RowIndex].Cells[e.ColumnIndex]; // 获取当前单元格
            StationInfo stationInfo = dgvStationList.Rows[e.RowIndex].DataBoundItem as StationInfo;

            // 选择行
            if (cell is DataGridViewCheckBoxCell) // 多选框
            {
                if (cell.FormattedValue.ToString() == "True")
                    selectedStations.Add(stationInfo); // 添加到已选择列表
                else
                    selectedStations.Remove(stationInfo); // 从已选择列表移除
            }
            else if (cell is DataGridViewLinkCell) // 操作按钮
            {
                string cellValue = cell.FormattedValue.ToString();
                switch (cellValue)
                {
                    case "修改":
                        InitEditStationInfo(stationInfo);
                        break;
                    case "删除":
                        DeleteStation(stationInfo, 1);
                        if (txtStationNo.Text == stationInfo.StationNo)
                            InitStationInfo(); // 初始化站点信息栏
                        break;
                    case "恢复":
                        DeleteStation(stationInfo, 0);
                        break;
                    case "移除":
                        DeleteStation(stationInfo, 2);
                        break;
                }
            }
        }

        /// <summary>
        /// 编辑站点信息加载到信息栏
        /// </summary>
        /// <param name="stationInfo">要编辑的站点</param>
        private void InitEditStationInfo(StationInfo stationInfo)
        {
            if (stationInfo != null)
            {
                txtStationNo.Text = stationInfo.StationNo;
                txtStationName.Text = stationInfo.StationName;
                txtAddress.Text = stationInfo.Address;
                txtManager.Text = stationInfo.Manager;
                txtPhone.Text = stationInfo.Phone;
                txtPYNo.Text = stationInfo.StationPYNo;
                txtRemark.Text = stationInfo.Remark;
                chkIsRunning.Checked = stationInfo.IsRunning;
                editStationId = stationInfo.StationId;
                oldName = stationInfo.StationName;
                oldNo = stationInfo.StationNo;
                actType = 2; // 信息提交状态设置为修改
                btnOk.Text = "修改"; // 按钮文字设置为修改
            }
        }

        /// <summary>
        /// 删除、恢复、移除单个站点
        /// </summary>
        /// <param name="station">要操作的站点</param>
        /// <param name="isDeleted">1-删除；0-恢复；2-移除</param>
        private void DeleteStation(StationInfo station, int isDeleted)
        {
            // 询问用户是否确认删除
            string[] titleMsg = FormUtility.GetActTitleAndMsg("站点", isDeleted);
            string msgTitle = titleMsg[0];
            string msg = titleMsg[1];
            if (MessageHelper.Confirm(msgTitle, msg) == DialogResult.OK)
            {
                // 确认删除
                List<int> ids = new List<int> { station.StationId };
                List<StationInfo> delList = new List<StationInfo> { station };
                switch (isDeleted)
                {
                    case 1:
                        string restr = stationBLL.DeleteStations(delList); // 执行删除
                        string[] reArr = restr.Split(';'); // 结果字符串分割
                        if (reArr[0] == "1")
                        {
                            MessageHelper.Info(msgTitle, $"站点：{station.StationName}删除成功！");
                            dgvStationList.UpdateDgv(delList); // 更新dgv数据源
                        }
                        else if (reArr[0] == "0")
                        {
                            MessageHelper.Info(msgTitle, $"站点：{station.StationName}删除失败！");
                            return;
                        }
                        else
                        {
                            MessageHelper.Info(msgTitle, $"站点：{station.StationName}运营中，不能删除！");
                            return;
                        }
                        break;
                    case 0:
                        bool blRecover = stationBLL.RecoverStations(ids);
                        if (blRecover)
                        {
                            MessageHelper.Info(msgTitle, $"站点：{station.StationName} 恢复成功！");
                            dgvStationList.UpdateDgv(delList);//更新dgv
                        }
                        else
                        {
                            MessageHelper.Info(msgTitle, $"站点：{station.StationName} 恢复失败！");
                            return;
                        }
                        break;
                    case 2:
                        bool blRemove = stationBLL.RemoveStations(ids);
                        if (blRemove)
                        {
                            MessageHelper.Info(msgTitle, $"站点：{station.StationName} 移除成功！");
                            dgvStationList.UpdateDgv(delList);//更新dgv
                        }
                        else
                        {
                            MessageHelper.Info(msgTitle, $"站点：{station.StationName} 移除失败！");
                            return;
                        }
                        break;
                }
            }
        }

        /// <summary>
        /// 确认提交信息按钮触发
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOk_Click(object sender, EventArgs e)
        {
            //接收信息
            string stationNo = txtStationNo.Text.Trim();
            string stationName = txtStationName.Text.Trim();
            string address = txtAddress.Text.Trim();
            string manager = txtManager.Text.Trim();
            string phone = txtPhone.Text.Trim();
            string pyno = txtPYNo.Text.Trim();
            bool isRunning = chkIsRunning.Checked;
            string remark = txtRemark.Text.Trim();
            //信息检查
            if (string.IsNullOrEmpty(stationNo))
            {
                lblErrMsg.SetErrorMsg("请输入站点编码！");
                txtStationNo.Focus(); // 指针聚焦到输入框
                return;
            }
            else if ((actType == 1 || (actType == 2 && oldNo != stationNo)) && stationBLL.ExistStationNo(stationNo))
            {
                // （新增操作 || （操作类型为修改 && 新的站点编号与旧的不一样） && 已存在站点编号）
                lblErrMsg.SetErrorMsg("该站点编码已存在！");
                txtStationNo.Focus();
                return;
            }
            if (string.IsNullOrEmpty(stationName))
            {
                lblErrMsg.SetErrorMsg("请输入站点名称！");
                txtStationName.Focus();
                return;
            }
            else if ((actType == 1 || (actType == 2 && oldName != stationName)) && stationBLL.ExistStationName(stationName))
            {
                // （新增操作 || （操作类型为修改 && 新的站点名称与旧的不一样） && 已存在站点名称）
                lblErrMsg.SetErrorMsg("该站点名称已存在！");
                txtStationName.Focus();
                return;
            }
            if (string.IsNullOrEmpty(address))
            {
                lblErrMsg.SetErrorMsg("请输入站点地址！");
                txtAddress.Focus();
                return;
            }
            if (string.IsNullOrEmpty(manager))
            {
                lblErrMsg.SetErrorMsg("请输入站点管理者！");
                txtManager.Focus();
                return;
            }
            if (string.IsNullOrEmpty(phone))
            {
                lblErrMsg.SetErrorMsg("请输入站点联系电话！");
                txtPhone.Focus();
                return;
            }
            //封装信息
            StationInfo station = new StationInfo()
            {
                StationId = editStationId,
                StationNo = stationNo,
                StationName = stationName,
                Address = address,
                Manager = manager,
                Phone = phone,
                StationPYNo = pyno,
                IsRunning = isRunning,
                Remark = remark
            };
            //提交处理
            if (actType == 1) // 新增
            {
                int reId = stationBLL.AddStation(station);
                if (reId > 0) // 新增成功
                {
                    MessageHelper.Info("添加站点", $"站点：{stationName} 添加成功！");
                    station.StationId = reId;
                    // 添加站点信息到站点列表中
                    dgvStationList.UpdateDgv(1, station, 0);
                    editStationId = reId;// 设置当前编辑的站点ID为新增的ID
                    btnOk.Text = "修改"; //  按钮文字设置为修改
                    actType = 2; // 信息提交状态设置为修改
                    oldName = stationName; // 更新站点名称
                    oldNo = stationNo; // 更新站点编号
                }
                else // 新增失败
                {
                    lblErrMsg.SetErrorMsg("站点信息添加失败！");
                    return;
                }
            }
            else // 修改
            {
                bool blEdit = stationBLL.UpdateStation(station);
                if (blEdit) // 修改成功
                {
                    MessageHelper.Info("修改站点", $"站点：{stationName} 修改成功！");
                    oldName = stationName; // 更新站点名称
                    oldNo = stationNo; // 更新站点编号
                    //更新站点信息到站点列表中
                    dgvStationList.UpdateDgv(2, station, editStationId);
                }
                else
                {
                    lblErrMsg.SetErrorMsg("站点信息修改失败！");
                    return;
                }
            }
        }

        /// <summary>
        /// 站点名称文本框内容改变触发生成拼音码
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtStationName_TextChanged(object sender, EventArgs e)
        {
            string stationName = txtStationName.Text.Trim();
            txtPYNo.Text = PingYinHelper.GetFirstSpell(stationName);
        }

        /// <summary>
        /// 鼠标点击文本框触发
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TextBox_MouseDown(object sender, MouseEventArgs e)
        {
            lblErrMsg.Visible = false; // 隐藏错误消息
            lblErrMsg.Text = ""; // 清空消息
        }

        /// <summary>
        /// 批量恢复按钮处理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRecover_Click(object sender, EventArgs e)
        {
            BatchProcessingStations(0);
        }

        /// <summary>
        /// 批移除按钮处理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRemove_Click(object sender, EventArgs e)
        {
            BatchProcessingStations(2);
        }

        /// <summary>
        /// 批量删除按钮处理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            BatchProcessingStations(1);
        }

        /// <summary>
        /// 批量处理站点
        /// </summary>
        /// <param name="isDeleted">0-恢复；1-删除；2-移除</param>
        private void BatchProcessingStations(int isDeleted)
        {
            string actName = FormUtility.GetDelTypeName(isDeleted);
            string msgTitle = $"{actName}站点";
            if (selectedStations.Count > 0)
            {
                if (MessageHelper.Confirm(msgTitle, $"你确定要{actName}选择的站点信息吗？") == DialogResult.OK)
                {
                    // 删除当前正在编辑的站点
                    if (isDeleted == 1)
                    {
                        bool clearStationInfo = false;
                        foreach (StationInfo station in selectedStations)
                        {
                            if (station.StationId == editStationId) // 当前编辑的站点不能删除
                            {
                                clearStationInfo = true;
                                break;
                            }
                        }
                        if (clearStationInfo)
                        {
                            InitStationInfo(); // 初始化站点信息栏
                        }
                    }
                    bool bl = false;//执行结果
                    List<int> delIds = selectedStations.Select(s => s.StationId).ToList();//站点编号集合
                    switch (isDeleted)
                    {
                        case 1:
                            string reStr = stationBLL.DeleteStations(selectedStations);//删除方法
                            string[] reArr = reStr.Split(';');
                            if (reArr[0] == "1")
                            {
                                if (reArr.Length == 1)
                                {
                                    //删除成功，没有不能删除的站点
                                    MessageHelper.Info(msgTitle, "选择的站点删除成功！");
                                    dgvStationList.UpdateDgv(selectedStations);
                                }
                                else
                                {
                                    MessageHelper.Info(msgTitle, $"选择的站点中，{reArr[1]}正在运营中，不能删除！其余的站点删除成功！");
                                    //刷新  筛选出能删除站点
                                    var delList = selectedStations.Where(s => s.IsRunning == false).ToList();
                                    dgvStationList.UpdateDgv(delList);
                                }
                                selectedStations.Clear();//清空
                            }
                            else if (reArr[0] == "0")
                            {
                                MessageHelper.Error(msgTitle, "选择的站点删除失败！");
                                return;
                            }
                            else
                            {
                                MessageHelper.Error(msgTitle, "选择的站点都在运营中，不能删除！");
                                return;
                            }
                            break;
                        case 0:
                            bl = stationBLL.RecoverStations(delIds);
                            break;
                        case 2:
                            bl = stationBLL.RemoveStations(delIds);
                            break;
                    }
                    if (isDeleted != 1)
                    {
                        if (bl)
                        {
                            MessageHelper.Info(msgTitle, $"选择的站点{actName}成功！");
                            dgvStationList.UpdateDgv(selectedStations);
                            selectedStations.Clear();
                        }
                        else
                        {
                            MessageHelper.Error(msgTitle, $"选择的站点{actName}失败！");
                            return;
                        }
                    }
                }
            }
            else
            {
                MessageHelper.Error(msgTitle, $"请选择要{actName}的站点信息");
                return;
            }
        }
    }
}
