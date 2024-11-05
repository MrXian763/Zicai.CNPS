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
using ZiCai.CainiaoPostStation.Models.UIModels;
using Zicai.CaiNiaoPostStation.Models.VModels;
using ZiCai.CainiaoPostStation.Models;
using Zicai.CaiNiaoPostStation.Utility;
using ZiCai.CaiNiaoPostStation.Utility;
using Common;

namespace Zicai.CaiNiaoPostStation.Exp
{
    public partial class FrmExpressDistribution : Form
    {
        public FrmExpressDistribution()
        {
            InitializeComponent();
        }

        DistributeExpressBLL disExpressBLL = new DistributeExpressBLL();
        StationBLL stationBLL = new StationBLL();

        int stationId = 0; // 选择的站点

        /// <summary>
        /// 页面加载触发
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmExpressDistribution_Load(object sender, EventArgs e)
        {
            // 加载站点列表
            FormUtility.LoadCboStations(cboStations, stationBLL);
            // 初始化条件
            InitFindConditions();
            dgvDisExpressList.CurrentCellDirtyStateChanged += FormUtility.DgvList_CurrentCellDirtyStateChanged;
            // 加载快递派送列表
            FindDistributeExpressList();
        }

        /// <summary>
        /// 初始化条件
        /// </summary>
        private void InitFindConditions()
        {
            txtKeyWords.Clear();
            txtRecPhone.Clear();
            cboStations.SelectedIndex = 0;
            cboStates.SelectedIndex = 0;
        }

        /// <summary>
        /// 加载快递派送列表
        /// </summary>
        private void FindDistributeExpressList()
        {
            string keywords = txtKeyWords.Text.Trim();
            stationId = cboStations.SelectedValue.GetInt();
            string recPhone = txtRecPhone.Text.Trim();
            string expState = cboStates.Text.Trim();
            if (expState == "全部")
                expState = "";
            int startIndex = uPager1.StartIndex;
            int pageSize = uPager1.PageSize;
            dgvDisExpressList.AutoGenerateColumns = false;
            PageModel<ViewDistributeExpressInfo> pageModel = disExpressBLL.FindDistributeExpressList(keywords, stationId, recPhone, expState, startIndex, pageSize);
            bool isShow = false;
            if (pageModel.TotalCount > 0)
            {
                dgvDisExpressList.DataSource = pageModel.PageList;
                uPager1.Record = pageModel.TotalCount;
                isShow = true;
                uPager1.Enabled = true;
            }
            else
            {
                dgvDisExpressList.DataSource = null;
                uPager1.Enabled = false;

            }
            // 更新按钮（派送安排、签收）显示或隐藏
            btnAssign.Visible = isShow;
            btnPickup.Visible = isShow;
        }

        /// <summary>
        /// 查询按钮触发
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFind_Click(object sender, EventArgs e)
        {
            FindDistributeExpressList();
        }

        /// <summary>
        /// 页码改变触发
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uPager1_PageChanged(object sender, EventArgs e)
        {
            FindDistributeExpressList();
        }

        /// <summary>
        /// 站点下拉框选择改变触发
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cboStations_SelectedIndexChanged(object sender, EventArgs e)
        {
            FindDistributeExpressList();
        }

        /// <summary>
        /// 快递状态下拉框选择改变触发
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cboStates_SelectedIndexChanged(object sender, EventArgs e)
        {
            FindDistributeExpressList();
        }

        List<ViewDistributeExpressInfo> selectItems = new List<ViewDistributeExpressInfo>(); // 选择行的数据列表
        /// <summary>
        /// 表格行数据选择
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvDisExpressList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // 当前单元格
            DataGridViewCell cell = dgvDisExpressList.Rows[e.RowIndex].Cells[e.ColumnIndex];
            ViewDistributeExpressInfo info = dgvDisExpressList.Rows[e.RowIndex].DataBoundItem as ViewDistributeExpressInfo;
            // 选择行
            if (cell is DataGridViewCheckBoxCell)
            {
                if (cell.FormattedValue.ToString() == "True")
                    selectItems.Add(info);
                else
                    selectItems.Remove(info);
            }
        }

        /// <summary>
        /// 派送安排
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAssign_Click(object sender, EventArgs e)
        {
            // 如果没有勾选，就获取当前行的信息
            if (dgvDisExpressList.SelectedRows.Count > 0 && selectItems.Count == 0)
                selectItems.Add(dgvDisExpressList.SelectedRows[0].DataBoundItem as ViewDistributeExpressInfo);
            if (selectItems.Count > 0)
            {
                List<string> hasDisNumbers = new List<string>(); // 存储已安排了派送或已签收的快递的单号
                List<int> expIds = new List<int>(); // 未安排派送或签收的快递单号
                foreach (var expInfo in selectItems)
                {
                    if (expInfo.ExpState == "派送中" || expInfo.ExpState == "已签收")
                        hasDisNumbers.Add(expInfo.ExpNumber);
                    else
                        expIds.Add(expInfo.ExpId);
                }
                bool blContinue = false; // 是否继续进行派送安排
                if (hasDisNumbers.Count > 0)
                {
                    // 存在已安排了派送或已签收的快递
                    hasDisNumbers.ForEach(num =>
                    {
                        // 移除表单选项中已经安排了派送或已签收的快递数据
                        ViewDistributeExpressInfo vexp = selectItems.Find(ex => ex.ExpNumber == num);
                        selectItems.Remove(vexp);
                    });
                    string Numbers = string.Join(",", hasDisNumbers);
                    MessageHelper.Error("派送安排", $"快递单号：{Numbers} 已安排了派送或已签收！");
                    // 存在没安排派送的快递
                    if (selectItems.Count > 0)
                    {
                        if (MessageHelper.Confirm("派送安排", "剩余的快递是否继续进行派送安排？") == DialogResult.OK)
                            blContinue = true;
                    }
                }
                else
                    blContinue = true;
                if (blContinue)
                {
                    // 显示派送安排页面
                    FrmExpAssignSet frmExpAssign = new FrmExpAssignSet();
                    frmExpAssign.Tag = expIds;
                    frmExpAssign.stationId = stationId;
                    // 订阅派送安排后事件：刷新派送列表
                    frmExpAssign.ReLoadDisExpressList += FrmExpAssign_ReLoadDisExpressList;
                    frmExpAssign.ShowDialog();
                }
            }
            else
            {
                MessageHelper.Error("派送安排", "请选择要安排派送的快递信息！");
                return;
            }
        }

        /// <summary>
        /// 派送安排后刷新派送列表
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmExpAssign_ReLoadDisExpressList(object sender, DistributeExpressArgs e)
        {
            if (e.EmpInfo != null)
            {
                var list = dgvDisExpressList.DataSource as List<ViewDistributeExpressInfo>; // 表单快递派送信息数据集合
                dgvDisExpressList.DataSource = null;
                var disExpIds = e.ExpIds; // 要派送的ID集合
                disExpIds.ForEach(id =>
                {
                    var vexp = list.Find(info => info.ExpId == id); // 找到安排了派送的快递信息
                    vexp.EmpId = e.EmpInfo.EmpId; // 派送员ID
                    vexp.EmpName = e.EmpInfo.EmpName; // 派送员名称
                    vexp.DistributeTime = e.DisTime; // 派送时间
                    vexp.Phone = e.EmpInfo.Phone; // 派送员电话
                    vexp.ExpState = "派送中"; // 快递状态
                });
                dgvDisExpressList.DataSource = list;
                selectItems.Clear(); // 清空选中行数据
            }
        }

        /// <summary>
        /// 派送签收
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPickup_Click(object sender, EventArgs e)
        {
            // 如果没有勾选，就获取当前行的信息
            if (dgvDisExpressList.SelectedRows.Count > 0 && selectItems.Count == 0)
                selectItems.Add(dgvDisExpressList.SelectedRows[0].DataBoundItem as ViewDistributeExpressInfo);
            if (selectItems.Count > 0)
            {
                List<string> hasDisNumbers = new List<string>(); // 存储未安排派送或已签收的快递的单号
                foreach (var expInfo in selectItems)
                {
                    if (expInfo.ExpState == "已入库" || expInfo.ExpState == "已签收")
                        hasDisNumbers.Add(expInfo.ExpNumber);
                }
                bool blContinue = false; // 是否继续进行签收
                if (hasDisNumbers.Count > 0)
                {
                    // 移除未安排派送或已签收的快递
                    hasDisNumbers.ForEach(num =>
                    {
                        ViewDistributeExpressInfo vexp = selectItems.Find(ex => ex.ExpNumber == num);
                        selectItems.Remove(vexp);
                    });
                    string Numbers = string.Join(",", hasDisNumbers);
                    MessageHelper.Error("快递签收", $"快递单号：{Numbers} 未安排派送或已签收！");
                    if (selectItems.Count > 0)
                    {
                        if (MessageHelper.Confirm("快递签收", "剩余的快递是否继续进行签收？") == DialogResult.OK)
                            blContinue = true;
                    }
                }
                else
                    blContinue = true;
                if (blContinue)
                {
                    List<ExpressInfo> expInfos = selectItems.Select(exp => new ExpressInfo()
                    {
                        ExpId = exp.ExpId,
                        Receiver = exp.Receiver,
                        ReceiverPhone = exp.ReceiverPhone
                    }).ToList(); // 签收的快递集合
                    // 显示签收页面
                    FrmExpressPickUp frmExpressPick = new FrmExpressPickUp();
                    frmExpressPick.Tag = expInfos;
                    frmExpressPick.isSelfPickUp = false; // 派送签收
                    // 刷新派送列表
                    frmExpressPick.ExpressPickedUp += FrmExpressPick_ExpressPickedUp;
                    frmExpressPick.ShowDialog();

                }
            }
            else
            {
                MessageHelper.Error("快递签收", "请选择要签收的快递信息！");
                return;
            }
        }

        /// <summary>
        /// 签收后刷新处理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmExpressPick_ExpressPickedUp(object sender, ExpressPickUpArgs e)
        {
            if (e.ExpIds.Count > 0)
            {
                // 存在快递签收成功
                var list = dgvDisExpressList.DataSource as List<ViewDistributeExpressInfo>;
                dgvDisExpressList.DataSource = null;
                // 找出被签收的快递并更新表格数据
                e.ExpIds.ForEach(expId =>
                {
                    var expInfo = list.Find(info => info.ExpId == expId);
                    expInfo.SignTime = e.PickingTime; // 签收时间
                    expInfo.IsSignFor = true;
                    expInfo.ExpState = "已签收";
                });
                dgvDisExpressList.DataSource = list;
                selectItems.Clear(); // 清空已选择快递行数据
            }
        }
    }
}
