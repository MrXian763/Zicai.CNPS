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
    public partial class FrmEmpExpStatistics : Form
    {
        public FrmEmpExpStatistics()
        {
            InitializeComponent();
        }

        ExpStatisticsBLL statisticsBLL = new ExpStatisticsBLL();

        /// <summary>
        /// 额面加载处理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmEmpExpStatistics_Load(object sender, EventArgs e)
        {
            LoadEmpExpressStatistics();
        }

        List<EmpStatInfo> empStatInfos = null;
        /// <summary>
        /// 统计快递员数据并呈现
        /// </summary>
        private void LoadEmpExpressStatistics()
        {
            EmpExpressStatInfo statInfo = statisticsBLL.StatEmpExpressData(DateTime.Now.Year);
            if (statInfo != null)
            {
                lblTotalCount.Text = statInfo.TotalDisCount.ToString(); // 总派送量
                lblHasCompleteCount.Text = statInfo.HasDisCount.ToString(); // 已完成量
                lblUnCompleteCount.Text = statInfo.UnDisCount.ToString(); // 未完成量
                lblSuperName.Text = statInfo.SuperEmpName; // 派送冠军
                lblMaxDisCount.Text = statInfo.SuperDisCount.ToString(); // 派送冠军派送数量

                chartEmpExpStat.ChartAreas[0].AxisX.Title = "员工姓名";
                chartEmpExpStat.Series[0].XValueType = ChartValueType.String;
                chartEmpExpStat.Series[0].YValueType = ChartValueType.Int32;

                chartEmpExpStat.DataSource = statInfo.EmpStatInfos;
                empStatInfos = statInfo.EmpStatInfos; // 导出用

                foreach (var series in chartEmpExpStat.Series)
                {
                    series.XValueMember = "EmpName"; // x轴 员工姓名
                }
                chartEmpExpStat.Series[0].YValueMembers = "TotalCount";
                chartEmpExpStat.Series[1].YValueMembers = "SignedCount";
                chartEmpExpStat.Series[2].YValueMembers = "UnSignCount";
            }
        }

        /// <summary>
        /// 统计
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStatistics_Click(object sender, EventArgs e)
        {
            LoadEmpExpressStatistics();
        }

        /// <summary>
        /// 导出数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExport_Click(object sender, EventArgs e)
        {
            // List列表  -- 属性名与中文名的键值对
            Dictionary<string, string> dicNames = new Dictionary<string, string>();
            dicNames.Add("EmpId", "员工编号");
            dicNames.Add("EmpName", "姓名");
            dicNames.Add("TotalCount", "派送总数");
            dicNames.Add("SignedCount", "已完成数");
            dicNames.Add("UnSignCount", "未完成数");
            FormUtility.DataToExcel(empStatInfos, dicNames, "员工快递统计.xls", "快递员数据", "导出快递员数据");
        }
    }
}
