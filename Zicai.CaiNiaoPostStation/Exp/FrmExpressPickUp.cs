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
using Zicai.CaiNiaoPostStation.Models.VModels;

namespace Zicai.CaiNiaoPostStation.Exp
{
    public partial class FrmExpressPickUp : Form
    {
        public FrmExpressPickUp()
        {
            InitializeComponent();
        }

        ExpressBLL expressBLL = new ExpressBLL();
        public bool isSelfPickUp = false; // 是否是自提签收
        public event EventHandler<ExpressPickUpArgs> ExpressPickedUp; // 签收后触发---刷新列表页
        List<ExpressInfo> expList = new List<ExpressInfo>(); // 派送签收快递列表
        bool isSame = true; // 同一收件人
        ViewSelfPickUpExpressInfo selfExp = null; // 自提快递信息

        /// <summary>
        /// 页面加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmExpressPickUp_Load(object sender, EventArgs e)
        {
            if (this.Tag != null)
            {
                if (isSelfPickUp) // 自提签收的加载
                {
                    selfExp = this.Tag as ViewSelfPickUpExpressInfo;
                    panelCode.Visible = true;
                    txtReceiver.Text = selfExp.Receiver;
                    txtReceiverPhone.Text = selfExp.ReceiverPhone;
                }
                else  // 派送签收
                {
                    expList = this.Tag as List<ExpressInfo>; // 要签收的快递列表
                    List<string> receiverPhones = expList.Select(exp => exp.ReceiverPhone).Distinct().ToList(); // 获取快递签收者的电话
                    if (receiverPhones.Count > 1)
                    {
                        isSame = false; // 不是同一收件人
                        if (MessageHelper.Confirm("快递签收", "这些快递不是同一收件人，是否继续？") == DialogResult.Cancel)
                            this.Close();
                    }
                    else
                    {
                        // 同一收件人
                        txtReceiver.Text = expList[0].Receiver;
                        txtReceiverPhone.Text = expList[0].ReceiverPhone;
                    }
                    panelCode.Visible = false; // 不显示取件码
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// 签收
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOk_Click(object sender, EventArgs e)
        {
            string pickingCode = "";
            if (isSelfPickUp)
                pickingCode = txtPickingCode.Text.Trim(); // 自提签收
            string receiver = txtReceiver.Text.Trim(); // 签收人名称
            string recPhone = txtReceiverPhone.Text.Trim(); // 签收人电话
            if (isSelfPickUp)
            {
                // 自提签收，判断输入的取件码与设置的取件码是否一致
                if (pickingCode != selfExp.PickingCode)
                {
                    lblErrMsg.SetErrorMsg("取件码不正确！");
                    txtPickingCode.Focus();
                    return;
                }
            }

            // 签收
            bool blSign = false;
            DateTime pickingTime = DateTime.Now; // 签收时间
            List<int> expIds = new List<int>(); // 签收的快递ID列表
            if (isSelfPickUp)
            {
                expIds.Add(selfExp.ExpId);
                // 调用自提签收方法
                blSign = expressBLL.SignExpress(selfExp.ExpId, pickingCode, pickingTime);
            }
            else
            {
                expIds = expList.Select(exp => exp.ExpId).ToList();
                // 调用派送签收方法
                blSign = expressBLL.SignExpress(expIds, pickingTime);
            }

            if (blSign)
            {
                MessageHelper.Info("快递签收", "快递签收成功！");
                ExpressPickedUp?.Invoke(this, new ExpressPickUpArgs(expIds, pickingTime)); // 刷新列表页
                this.Close();
            }
            else
            {
                MessageHelper.Error("快递签收", "快递签收失败！");
                return;
            }
        }

        /// <summary>
        /// 鼠标放入快递取件码输入框
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtPickingCode_MouseDown(object sender, MouseEventArgs e)
        {
            lblErrMsg.Visible = false; // 隐藏错误提示消息
        }
    }
}
