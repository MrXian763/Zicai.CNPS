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
using System.Windows.Forms.DataVisualization.Charting;
using Zicai.CaiNiaoPostStation.BLL;
using Zicai.CaiNiaoPostStation.Models.UIModels;
using Zicai.CaiNiaoPostStation.Utility;

namespace Zicai.CaiNiaoPostStation.Stat
{
    public partial class FrmExpCompletionStatistics : Form
    {
        public FrmExpCompletionStatistics()
        {
            InitializeComponent();
        }

        StationBLL stationBLL = new StationBLL();
        ExpStatisticsBLL statisticsBLL = new ExpStatisticsBLL();

        /// <summary>
        /// 页面加载触发
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmExpCompletionStatistics_Load(object sender, EventArgs e)
        {
            // 站点下拉框加载
            FormUtility.LoadCboStations(cboStations, stationBLL);
            cboStations.SelectedIndex = 0;
            // 统计当前的完成度
            dgvExpList.AutoGenerateColumns = false;
            StatisticsCompletionCount();
        }

        /// <summary>
        /// 统计快递完成度数据，默认加载已完成的列表
        /// </summary>
        private void StatisticsCompletionCount()
        {
            int stationId = cboStations.SelectedValue.GetInt(); // 站点ID
            List<ExpressCountInfo> countData = statisticsBLL.StatExpressCountData(stationId);
            if (countData != null)
            {
                chartExpStat.DataSource = countData;    // 设置图表数据源
                Series seriesComplete = chartExpStat.Series[0];
                seriesComplete.Label = "#PERCENT{P}"; // 显示百分比
                seriesComplete.XValueType = ChartValueType.String; // x轴的值的类型
                seriesComplete.YValueType = ChartValueType.Int32; // y轴的值的类型
                seriesComplete["PieLableStyle"] = "OutSide"; // 设置标签文本显示在图标外边
                seriesComplete.BorderWidth = 2; // 设置边框宽度
                seriesComplete.XValueMember = "ExpState"; // 快递状态
                seriesComplete.YValueMembers = "ExpCount"; // 快递数量
                seriesComplete.LegendText = "#VALX";//图例文本

                lblHasCompleteCount.Text = countData[0].ExpCount.ToString(); // 已完成快递数量
                lblUnCompleteCount.Text = countData[1].ExpCount.ToString(); // 未完成快递数量
            }
            LoadExpressListByCount(true, stationId);
        }

        /// <summary>
        /// 加载指定的快递列表
        /// </summary>
        /// <param name="isCompleted">是否已完成</param>
        /// <param name="stationId">站点ID</param>
        private void LoadExpressListByCount(bool isCompleted, int stationId)
        {
            List<ExpressComInfo> expList = statisticsBLL.GetExpressListByCount(isCompleted, stationId);
            if (expList.Count > 0)
                dgvExpList.DataSource = expList;
            else
                dgvExpList.DataSource = null;
        }

        /// <summary>
        /// 点击已完成数触发
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lblHasCompleCount_Click(object sender, EventArgs e)
        {
            int stationId = cboStations.SelectedValue.GetInt(); // 获取站点ID
            LoadExpressListByCount(true, stationId);
        }

        /// <summary>
        /// 点击未完成数触发
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lblUnCompleteCount_Click(object sender, EventArgs e)
        {
            int stationId = cboStations.SelectedValue.GetInt(); // 获取站点ID
            LoadExpressListByCount(false, stationId);
        }

        /// <summary>
        /// 点击统计按钮触发
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStatistics_Click(object sender, EventArgs e)
        {
            StatisticsCompletionCount();
        }
    }
}
