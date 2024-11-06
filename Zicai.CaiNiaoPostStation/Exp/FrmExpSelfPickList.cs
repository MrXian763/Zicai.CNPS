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
using Zicai.CaiNiaoPostStation.Utility;
using Common;

namespace Zicai.CaiNiaoPostStation.Exp
{
    public partial class FrmExpSelfPickList : Form
    {
        public FrmExpSelfPickList()
        {
            InitializeComponent();
        }

        ExpSelfPickUpBLL selfPickUpBLL = new ExpSelfPickUpBLL();
        StationBLL stationBLL = new StationBLL();

        /// <summary>
        /// 页面加载触发
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmExpSelfPickList_Load(object sender, EventArgs e)
        {
            // 加载站点下拉框
            FormUtility.LoadCboStations(cboStations, stationBLL);
            // 初始化条件
            InitFindConditions();
            // 加载所有自提列表
            FindSelfPickUpExpressList();
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
        /// 条件查询自提列表
        /// </summary>
        private void FindSelfPickUpExpressList()
        {
            string keywords = txtKeyWords.Text.Trim();
            int stationId = cboStations.SelectedValue.GetInt();
            string recPhone = txtRecPhone.Text.Trim();
            string expState = cboStates.Text.Trim();
            if (expState == "全部")
                expState = "";
            int startIndex = uPager1.StartIndex;
            int pageSize = uPager1.PageSize;
            dgvSelfExpressList.AutoGenerateColumns = false;
            PageModel<ViewSelfPickUpExpressInfo> pageModel = selfPickUpBLL.FindSelfPickUpExpressList(keywords, stationId, recPhone, expState, startIndex, pageSize);
            if (pageModel.TotalCount > 0)
            {
                dgvSelfExpressList.DataSource = pageModel.PageList;
                uPager1.Record = pageModel.TotalCount;
                uPager1.Enabled = true;
            }
            else
            {
                dgvSelfExpressList.DataSource = null;
                uPager1.Enabled = false;

            }
        }
        /// <summary>
        /// 查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFind_Click(object sender, EventArgs e)
        {
            FindSelfPickUpExpressList();
        }

        /// <summary>
        /// 翻页
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uPager1_PageChanged(object sender, EventArgs e)
        {
            FindSelfPickUpExpressList();
        }

        /// <summary>
        /// 站点下拉框选项改变
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cboStations_SelectedIndexChanged(object sender, EventArgs e)
        {
            FindSelfPickUpExpressList();
        }

        /// <summary>
        /// 快递状态下拉框选项改变
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cboStates_SelectedIndexChanged(object sender, EventArgs e)
        {
            FindSelfPickUpExpressList();
        }

        /// <summary>
        /// 点击表格内单元格
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvSelfExpressList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // 当前单元格
            DataGridViewCell cell = dgvSelfExpressList.Rows[e.RowIndex].Cells[e.ColumnIndex];
            ViewSelfPickUpExpressInfo info = dgvSelfExpressList.Rows[e.RowIndex].DataBoundItem as ViewSelfPickUpExpressInfo;
            if (cell.FormattedValue.ToString() == "取件")
            {
                // 点击取件按钮，显示签收页
                FrmExpressPickUp frmExpressPick = new FrmExpressPickUp();
                frmExpressPick.isSelfPickUp = true; // 自提
                frmExpressPick.Tag = info;
                frmExpressPick.ExpressPickedUp += FrmExpressPick_ExpressPickedUp;
                frmExpressPick.ShowDialog();
            }
        }

        /// <summary>
        /// 刷新自提签收信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmExpressPick_ExpressPickedUp(object sender, ExpressPickUpArgs e)
        {
            if (e.ExpIds.Count == 1)
            {
                // 只签收一条快递
                var list = dgvSelfExpressList.DataSource as List<ViewSelfPickUpExpressInfo>;
                dgvSelfExpressList.DataSource = null;
                int expId = e.ExpIds[0];
                var expInfo = list.Find(info => info.ExpId == expId); // 查找被签收的快递
                expInfo.PickingTime = e.PickingTime;
                expInfo.IsPickUp = true;
                expInfo.ExpState = "已签收";
                dgvSelfExpressList.DataSource = list;
            }
        }
    }
}
