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
using Zicai.CaiNiaoPostStation.Models.VModels;
using Zicai.CaiNiaoPostStation.Models;
using ZiCai.CainiaoPostStation.Models;
using Zicai.CaiNiaoPostStation.Utility;
using ZiCai.CaiNiaoPostStation.Utility;

namespace Zicai.CaiNiaoPostStation.Exp
{
    public partial class FrmExpressInfo : Form
    {
        public FrmExpressInfo()
        {
            InitializeComponent();
        }

        ExpressBLL expressBLL = new ExpressBLL();
        StationBLL stationBLL = new StationBLL();
        ShelfBLL shelfBLL = new ShelfBLL();
        EmployeeBLL employeeBLL = new EmployeeBLL();

        public event EventHandler<ExpressArgs> ReloadExpressEvent; // 刷新快递列表事件
        public int actType = 1; // 提交标识   1--新增  2--修改
        int editExpId = 0; // 当前修改的快递编号
        string oldExpNumber = "";
        int selfCount = 0; // 今日自提数
        int selfPickId = 0; // 自提编号
        string oldPickingCode = "";
        int stationId = 0; // 当前选择的站点编号
        bool isSaved = false; // 是否提交

        /// <summary>
        /// 页面加载触发
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmExpressInfo_Load(object sender, EventArgs e)
        {
            // 下拉框加载：站点列表、货架列表、员工列表
            LoadCboStations();
            //stationId = cboStations.SelectedValue.GetInt();
            //LoadCboShelves(stationId);
            //LoadCboEmployees(stationId);
            // 获取今日总自提数
            selfCount = expressBLL.GetTodaySelfCount();
            // 快递信息页加载处理
            InitExpressInfo();
        }


        /// <summary>
        /// 加载站点列表
        /// </summary>
        private void LoadCboStations()
        {
            FormUtility.LoadCboStations(cboStations, stationBLL);
            cboStations.SelectedIndex = 0;
        }

        /// <summary>
        /// 加载站点下货架列表
        /// </summary>
        /// <param name="stationId">站点ID</param>
        private void LoadCboShelves(int stationId)
        {
            List<ShelfInfo> shelves = shelfBLL.GetCboShelveList(stationId);
            shelves.Insert(0, new ShelfInfo() { ShelfId = 0, ShelfName = "请选择" });
            cboShelves.DisplayMember = "ShelfName";
            cboShelves.ValueMember = "ShelfId";
            cboShelves.DataSource = shelves;
            cboShelves.SelectedIndex = 0;
        }

        /// <summary>
        /// 页面信息加载处理
        /// </summary>
        private void InitExpressInfo()
        {
            if (actType == 1) // 新增状态
            {
                foreach (Control c in gbExpInfo.Controls)
                {
                    if (c is TextBox)
                        c.Text = "";
                    else if (c is ComboBox)
                        ((ComboBox)c).SelectedIndex = 0;
                }
                lblErrMsg.Visible = false; // 隐藏错误提示
                btnOk.Text = "添加";
            }
            else // 修改状态
            {
                if (this.Tag != null)
                {
                    editExpId = this.Tag.ToString().GetInt(); // 要修改的快递编号
                    // 根据id获取快递详细信息并加载到界面上
                    ExpressInfo expInfo = expressBLL.GetExpressInfo(editExpId);
                    if (expInfo != null)
                    {
                        txtExpNo.Text = expInfo.ExpNumber;
                        oldExpNumber = expInfo.ExpNumber;
                        cboStations.SelectedValue = expInfo.StationId;
                        txtRemark.Text = expInfo.ExpRemark;
                        txtReceiver.Text = expInfo.Receiver;
                        txtReceiverPhone.Text = expInfo.ReceiverPhone;
                        txtReceiverAddress.Text = expInfo.ReceiveAddress;
                        txtSender.Text = expInfo.Sender;
                        txtSenderPhone.Text = expInfo.SenderPhone;
                        txtSenderAddress.Text = expInfo.SenderAddress;
                        txtExpType.Text = expInfo.ExpType;
                        cboExpStates.Text = expInfo.ExpState;
                        cboShelves.SelectedValue = expInfo.ShelfId;
                        cboPickWays.Text = expInfo.PickWay;
                        if (expInfo.PickWay == "自提")
                        {
                            ExpSelfPickInfo selfPick = expressBLL.GetSelfPickInfo(editExpId);
                            if (selfPick != null)
                            {
                                txtPickCode.Text = selfPick.PickingCode; // 取件码
                                selfPickId = selfPick.PickUpId; // 自提自编号
                                oldPickingCode = selfPick.PickingCode; // 更新取件码
                            }
                            txtPickCode.Enabled = true; // 取件码可用
                        }
                        else // 派送
                        {
                            txtPickCode.Enabled = false; // 禁用取件码
                        }
                        txtEnterTime.Text = expInfo.EnterTime.ToString("yyyy-MM-dd HH:mm:ss"); // 录入时间
                        cboEnterEmployee.Text = expInfo.EnterPerson; // 录入人
                        btnOk.Text = "修改";
                    }
                }
            }
        }

        /// <summary>
        /// 点击重置按钮触发 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReset_Click(object sender, EventArgs e)
        {
            actType = 1; // 提交标识为更新
            InitExpressInfo();
        }

        /// <summary>
        /// 点击关闭按钮触发
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close(); // 关闭当前页面
        }

        /// <summary>
        /// 关闭页面时触发
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmExpressInfo_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!isSaved)
            {
                if (MessageHelper.Confirm("关闭快递信息页", "还未保存，你确定要关闭该页面吗？") == DialogResult.Cancel)
                {
                    e.Cancel = true; // 取消关闭页面
                }
            }
        }

        /// <summary>
        /// 站点选择改变
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cboStations_SelectedIndexChanged(object sender, EventArgs e)
        {
            stationId = cboStations.SelectedValue.GetInt(); // 获取选中的站点ID
            LoadCboShelves(stationId); // 加载选中站点下的货架列表
            FormUtility.LoadCboEmployees(stationId, cboEnterEmployee, employeeBLL); // 加载选中站点下的员工
        }

        /// <summary>
        /// 取件方式改变
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cboPickWays_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboPickWays.Text == "自提")
            {
                txtPickCode.Enabled = true; // 自提码可用
                // 格式 15-02-0091
                txtPickCode.Text = DateTime.Today.Day.ToString("00") + "-" + cboShelves.SelectedValue.GetInt().ToString("00") + "-" + (selfCount + 1).ToString("0000");
            }
            else
            {
                txtPickCode.Enabled = false; // 禁用自提码
                txtPickCode.Text = "";
            }
        }

        /// <summary>
        /// 打开类别选择页
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void linkChoose_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmExpTypeChoose frmExpTypeChoose = new FrmExpTypeChoose();
            frmExpTypeChoose.Tag = txtExpType.Text;
            // 选择完成后，把设置的类别信息传递过来，显示在当前的类别文本框？？？？  事件，订阅
            frmExpTypeChoose.ExpTypeChoosed += FrmExpTypeChoose_ExpTypeChoosed;
            frmExpTypeChoose.Show(); // 打开选择页
        }

        private void FrmExpTypeChoose_ExpTypeChoosed(object sender, ChooseExpTypeArgs e)
        {
            if (!string.IsNullOrEmpty(e.ChoosedExpType))
            {
                txtExpType.Text = e.ChoosedExpType;
            }
        }

        /// <summary>
        /// 快递信息提交 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOk_Click(object sender, EventArgs e)
        {
            // 信息接收
            string expNumber = txtExpNo.Text.Trim();
            int stationId = cboStations.SelectedValue.GetInt();
            string remark = txtRemark.Text.Trim();
            string receiver = txtReceiver.Text.Trim();
            string recPhone = txtReceiverPhone.Text.Trim();
            string recAddress = txtReceiverAddress.Text.Trim();
            string senderName = txtSender.Text.Trim();
            string senderPhone = txtSenderPhone.Text.Trim();
            string senderAddress = txtSenderAddress.Text.Trim();
            string expType = txtExpType.Text.Trim();
            string expState = cboExpStates.Text.Trim();
            int shelfId = cboShelves.SelectedValue.GetInt();
            string pickWay = cboPickWays.Text.Trim();
            string pickingCode = txtPickCode.Text.Trim();
            if (pickWay == "派送")
                pickingCode = null;
            string enterPerson = cboEnterEmployee.Text;

            #region 信息检查
            if (string.IsNullOrEmpty(expNumber))
            {
                lblErrMsg.SetErrorMsg("请输入快递单号！");
                txtExpNo.Focus();
                return;
            }
            else if ((actType == 1 || (actType == 2 && oldExpNumber != expNumber)) && expressBLL.ExistExpressNumber(expNumber))
            {
                lblErrMsg.SetErrorMsg("该快递单号已存在！");
                txtExpNo.Focus();
                return;
            }
            if (stationId == 0)
            {
                lblErrMsg.SetErrorMsg("请选择所在站点！");
                cboStations.Focus();
                return;
            }
            if (string.IsNullOrEmpty(receiver))
            {
                lblErrMsg.SetErrorMsg("请输入收件人！");
                txtReceiver.Focus();
                return;
            }
            if (string.IsNullOrEmpty(recPhone))
            {
                lblErrMsg.SetErrorMsg("请输入收件人电话！");
                txtReceiverPhone.Focus();
                return;
            }
            if (string.IsNullOrEmpty(recAddress))
            {
                lblErrMsg.SetErrorMsg("请输入收件人地址！");
                txtReceiverAddress.Focus();
                return;
            }
            if (string.IsNullOrEmpty(senderName))
            {
                lblErrMsg.SetErrorMsg("请输入寄件人！");
                txtReceiver.Focus();
                return;
            }
            if (string.IsNullOrEmpty(senderPhone))
            {
                lblErrMsg.SetErrorMsg("请输入寄件人电话！");
                txtSenderPhone.Focus();
                return;
            }
            if (string.IsNullOrEmpty(senderAddress))
            {
                lblErrMsg.SetErrorMsg("请输入寄件人地址！");
                txtSenderAddress.Focus();
                return;
            }
            if (string.IsNullOrEmpty(expType))
            {
                lblErrMsg.SetErrorMsg("请设置快递类别！");
                return;
            }
            if (shelfId == 0 && pickWay == "自提")
            {
                lblErrMsg.SetErrorMsg("请选择快递存储的货架！");
                cboShelves.Focus();
                return;
            }
            if (pickWay == "自提" && string.IsNullOrEmpty(pickWay))
            {
                lblErrMsg.SetErrorMsg("请设置取件码！");
                txtPickCode.Focus();
                return;
            }
            if (string.IsNullOrEmpty(enterPerson))
            {
                lblErrMsg.SetErrorMsg("请设置录入人！");
                cboEnterEmployee.Focus();
                return;
            }
            #endregion

            #region 信息封装
            ExpressInfo expInfo = new ExpressInfo()
            {
                ExpId = editExpId,
                ExpNumber = expNumber,
                StationId = stationId,
                ExpRemark = remark,
                Receiver = receiver,
                ReceiverPhone = recPhone,
                ReceiveAddress = recAddress,
                Sender = senderName,
                SenderPhone = senderPhone,
                SenderAddress = senderAddress,
                ExpType = expType,
                ExpState = expState,
                ShelfId = shelfId,
                PickWay = pickWay,
                EnterTime = DateTime.Now,
                EnterPerson = enterPerson
            };
            ExpSelfPickInfo selfPickInfo = null;
            if (pickWay == "自提" && (selfPickId > 0 && pickingCode != oldPickingCode) || (selfPickId == 0 && !string.IsNullOrEmpty(pickingCode)))
            {
                selfPickInfo = new ExpSelfPickInfo()
                {
                    PickUpId = selfPickId,
                    ExpId = editExpId,
                    PickingCode = pickingCode,
                    IsPickUp = false,
                    PickingTime = null
                };
            }
            #endregion

            #region 信息提交
            if (actType == 1) // 新增
            {
                int reId = expressBLL.AddExpressInfo(expInfo, selfPickInfo);
                if (reId > 0)
                {
                    MessageHelper.Info("添加快递", $"快递单号：{expNumber} 的快递信息添加成功！");
                    isSaved = true; // 标识数据已提交
                    expInfo.ExpId = reId; // 设置当前编辑数据为新增的数据
                    ViewExpressInfo viewExpress = new ViewExpressInfo(expInfo, cboStations.Text, cboShelves.Text);
                    // 刷新到列表页
                    ReloadExpressEvent?.Invoke(this, new ExpressArgs(viewExpress, actType));
                    editExpId = reId;
                    btnOk.Text = "修改";
                    actType = 2;
                    oldExpNumber = expNumber;
                    if (selfPickInfo != null)
                    {
                        selfPickId = expressBLL.GetSelfPickInfo(reId).PickUpId;
                        oldPickingCode = pickingCode;
                    }
                }
                else
                {
                    lblErrMsg.SetErrorMsg("快递信息添加失败！");
                    return;
                }
            }
            else // 修改
            {
                bool blEdit = false;
                if (pickWay == "派送" && selfPickId > 0)
                    blEdit = expressBLL.UpdateExpressInfo(expInfo, selfPickId); // 改为派送，删除自提记录
                else if (pickWay == "自提")
                    blEdit = expressBLL.UpdateExpressInfo(expInfo, selfPickInfo);
                else
                    blEdit = expressBLL.UpdateExpressInfo(expInfo);
                if (blEdit)
                {
                    MessageHelper.Info("修改快递", $"快递单号：{expNumber} 的快递信息修改成功！");
                    isSaved = true; // 标识状态为已提交
                    oldExpNumber = expNumber;
                    ViewExpressInfo viewExpress = new ViewExpressInfo(expInfo, cboStations.Text, cboShelves.Text);
                    // 刷新到列表页
                    ReloadExpressEvent?.Invoke(this, new ExpressArgs(viewExpress, actType));
                    if (selfPickInfo != null)
                    {
                        selfPickId = expressBLL.GetSelfPickInfo(editExpId).PickUpId;
                        oldPickingCode = pickingCode;
                    }
                }
                else
                {
                    lblErrMsg.SetErrorMsg("快递信息修改失败！");
                    return;
                }
            }
            #endregion
        }
    }
}
