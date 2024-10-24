using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Zicai.CaiNiaoPostStation.Utility;

namespace Zicai.CaiNiaoPostStation
{
    public partial class FrmNavigation : Form
    {
        public FrmNavigation()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 站点管理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStation_Click(object sender, EventArgs e)
        {
            this.ShowNavForm<BM.FrmStationList>();
        }

        /// <summary>
        /// 货架管理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSelves_Click(object sender, EventArgs e)
        {
            this.ShowNavForm<BM.FrmShelvesList>();
        }

        /// <summary>
        /// 员工信息管理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEmployee_Click(object sender, EventArgs e)
        {
            this.ShowNavForm<Employee.FrmEmployeeList>();
        }

        /// <summary>
        /// 快递信息管理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExpress_Click(object sender, EventArgs e)
        {
            this.ShowNavForm<Exp.FrmExpressList>();
        }

        /// <summary>
        /// 快递派送
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExpDistribution_Click(object sender, EventArgs e)
        {
            this.ShowNavForm<Exp.FrmExpressDistribution>();
        }

        /// <summary>
        /// 快递自提
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExpSelfPick_Click(object sender, EventArgs e)
        {
            this.ShowNavForm<Exp.FrmExpSelfPickList>();
        }

        /// <summary>
        /// 快递统计
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExpStatistics_Click(object sender, EventArgs e)
        {
            this.ShowNavForm<Stat.FrmExpCompletionStatistics>();
        }
    }
}
