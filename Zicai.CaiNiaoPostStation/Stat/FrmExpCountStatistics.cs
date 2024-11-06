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
using Zicai.CaiNiaoPostStation.Models.UIModels;

namespace Zicai.CaiNiaoPostStation.Stat
{
    public partial class FrmExpCountStatistics : Form
    {
        public FrmExpCountStatistics()
        {
            InitializeComponent();
        }

        ExpStatisticsBLL statisticsBLL = new ExpStatisticsBLL();

        /// <summary>
        /// 页面加载触发
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmExpCountStatistics_Load(object sender, EventArgs e)
        {
            // 初始化条件
            rbtnDay.Checked = true; // 默认按日统计
            cboYears.Text = DateTime.Now.Year.ToString(); // 默认当前年份
            cboMonths.Text = DateTime.Now.Month.ToString(); // 默认当前月份
            // 默认统计当前月份中的按日统计数据
            LoadExpCountStatistics();
        }

        /// <summary>
        /// 统计方法
        /// </summary>
        private void LoadExpCountStatistics()
        {
            int year = int.Parse(cboYears.Text);
            int[] years = new int[6];
            for (int i = 0; i < 6; i++)
                years[i] = year - i;
            cboYears.DataSource = years; // 年份下拉框数据为近五年
            int month = 0;
            if (cboMonths.Enabled)
            {
                month = int.Parse(cboMonths.Text);
            }
            if (rbtnDay.Checked)
            {
                // 按日统计
                List<ExpDayCountInfo> list = statisticsBLL.StatExpressCountByDay(year, month);
                chartExpStat.DataSource = list;
            }
            else if (rbtnWeek.Checked)
            {
                // 按周统计
                List<ExpWeekCountInfo> list = statisticsBLL.StatExpressCountByWeek(year);
                chartExpStat.DataSource = list;
            }
            else
            {
                // 按月统计
                List<ExpMonthCountInfo> list = statisticsBLL.StatExpressCountByMonth(year);
                chartExpStat.DataSource = list;
            }
            chartExpStat.Series[0].YValueMembers = "ExpCount"; // 总快递数目
            chartExpStat.Series[1].YValueMembers = "HasCount"; // 已完成快递数
            chartExpStat.Series[2].YValueMembers = "UnCount"; // 未完成快递数
            chartExpStat.Series[0].Label = "#VAL"; // 显示点的Y值
        }

        /// <summary>
        /// 统计
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStatistics_Click(object sender, EventArgs e)
        {
            LoadExpCountStatistics();
        }

        /// <summary>
        /// 统计类别多选框改变
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbtn_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rbtn = sender as RadioButton;
            string tagValue = rbtn.Tag.ToString();
            if (rbtn.Checked)
            {
                switch (tagValue)
                {
                    case "Day":
                        cboMonths.Enabled = true;
                        cboMonths.SelectedIndex = DateTime.Now.Month - 1;
                        chartExpStat.ChartAreas[0].AxisX.Title = "日期";
                        chartExpStat.Series[0].XValueMember = "InsertDate";
                        chartExpStat.Series[1].XValueMember = "InsertDate";
                        chartExpStat.Series[2].XValueMember = "InsertDate";
                        break;
                    case "Week":
                        cboMonths.Enabled = false;
                        chartExpStat.ChartAreas[0].AxisX.Title = "周数";
                        chartExpStat.Series[0].XValueMember = "WeekNumber";
                        chartExpStat.Series[1].XValueMember = "WeekNumber";
                        chartExpStat.Series[2].XValueMember = "WeekNumber";
                        break;
                    case "Month":
                        cboMonths.Enabled = false;
                        chartExpStat.ChartAreas[0].AxisX.Title = "月份";
                        chartExpStat.Series[0].XValueMember = "MonthNumber";
                        chartExpStat.Series[1].XValueMember = "MonthNumber";
                        chartExpStat.Series[2].XValueMember = "MonthNumber";
                        break;
                }
                LoadExpCountStatistics();
            }
        }
    }
}
