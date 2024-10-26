using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Zhaoxi.CainiaoPostStation.Models.UIModels;
using Zicai.CaiNiaoPostStation.BLL;
using Zicai.CaiNiaoPostStation.Models;

namespace Zicai.CaiNiaoPostStation.BM
{
    public partial class FrmStationList : Form
    {
        public FrmStationList()
        {
            InitializeComponent();
        }

        StationBLL stationBLL = new StationBLL();

        int actType = 1; // 信息提交状态
        int editStationId = 0; // 当前正在修改的站点ID
        bool isFirst = true; // 是否第一次加载
        int totalCount = 0; // 总站点数
        string oldNo = "", oldName = ""; // 修改前的站点编号、名称

        /// <summary>
        /// 页面加载触发
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmStationList_Load(object sender, EventArgs e)
        {
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
            defaultNo += totalCount.ToString("0000");
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
    }
}
