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
using ZiCai.CainiaoPostStation.Models.UIModels;
using Zicai.CaiNiaoPostStation.Models.VModels;
using ZiCai.CainiaoPostStation.Models;
using Zicai.CaiNiaoPostStation.Utility;
using ZiCai.CaiNiaoPostStation.Utility;

namespace Zicai.CaiNiaoPostStation.Exp
{
    public partial class FrmExpressList : Form
    {
        public FrmExpressList()
        {
            InitializeComponent();
        }

        StationBLL stationBLL = new StationBLL();
        ExpressTypeBLL expressTypeBLL = new ExpressTypeBLL();
        ExpressBLL expressBLL = new ExpressBLL();

        int isFirst = 0; // 是否初始化完成
        /// <summary>
        /// 初始化处理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmExpressList_Load(object sender, EventArgs e)
        {
            // 站点下拉框加载
            LoadCboStations();
            // 类别节点树加载
            LoadTvExpTypes();
            // 查询条件初始化
            InitFindConditions();
            dgvExpressList.CurrentCellDirtyStateChanged += FormUtility.DgvList_CurrentCellDirtyStateChanged;
            // 加载所有快递列表
            FindExpressList();
            isFirst = 1;
        }

        /// <summary>
        /// 加载所有快递列表
        /// </summary>
        private void FindExpressList()
        {
            // 构造搜索条件
            string keywords = txtKeyWords.Text.Trim();
            string expType = tvExpTypes.SelectedNode.Text; // 选择节点的文本
            if (expType == "快递类别")
                expType = "";
            int stationId = cboStations.SelectedValue.GetInt();
            string expState = cboStates.Text.Trim();
            if (expState == "全部")
                expState = "";
            string pickWay = cboPickWays.Text.Trim();
            if (pickWay == "全部")
                pickWay = "";
            string expNumber = txtExpNo.Text.Trim();
            string receiver = txtReveiverName.Text.Trim();
            string recPhone = txtReceiverPhone.Text.Trim();
            bool showDel = chkShowDel.Checked;
            int startIndex = uPager1.StartIndex; // 当页的开始索引
            int pageSize = uPager1.PageSize; // 每页记录数
            dgvExpressList.AutoGenerateColumns = false;
            // 执行查询
            PageModel<ViewExpressInfo> pageModel = expressBLL.FindExpressList(keywords, expType, stationId, expState, expNumber, receiver, recPhone, pickWay, showDel, startIndex, pageSize);
            if (pageModel.TotalCount > 0)
            {
                // 有数据
                dgvExpressList.DataSource = pageModel.PageList;
                uPager1.Record = pageModel.TotalCount;
                uPager1.Enabled = true;
            }
            else
            {
                // 无数据
                dgvExpressList.DataSource = null;
                uPager1.Enabled = false;
            }
            SetActBtnsVisible(showDel); // 更新按钮展示
        }

        /// <summary>
        /// 设置按钮显示
        /// </summary>
        /// <param name="showDel"></param>
        private void SetActBtnsVisible(bool showDel)
        {
            btnEdit.Visible = !showDel;
            btnDelete.Visible = !showDel;
            btnRecover.Visible = showDel;
            btnRemove.Visible = showDel;
        }

        /// <summary>
        /// 站点下拉框加载
        /// </summary>
        private void LoadCboStations()
        {
            FormUtility.LoadCboStations(cboStations, stationBLL);
        }

        /// <summary>
        /// 类别节点树加载
        /// </summary>
        private void LoadTvExpTypes()
        {
            List<ExpressTypeInfo> expTypeList = expressTypeBLL.GetCboExpTypes(1);
            TreeNode rootNode = new TreeNode() { Name = "0", Text = "快递类别" };
            tvExpTypes.Nodes.Add(rootNode);
            // 递归加载节点
            AddTvNode(expTypeList, rootNode, 0);
            tvExpTypes.ExpandAll(); // 展开所有树节点
        }

        /// <summary>
        /// 加载类别节点递归方法
        /// </summary>
        /// <param name="allTypes">父节点集合</param>
        /// <param name="pNode">当前节点</param>
        /// <param name="parentId">当前节点父节点ID</param>
        private void AddTvNode(List<ExpressTypeInfo> allTypes, TreeNode pNode, int parentId)
        {
            var subList = allTypes.Where(t => t.ParentId == parentId); // 获取当前节点的子节点集合
            foreach (ExpressTypeInfo expType in subList)
            {
                TreeNode node = new TreeNode() { Name = expType.ExpTypeId.ToString(), Text = expType.ExpTypeName };
                if (pNode != null)
                    pNode.Nodes.Add(node); // 添加当前节点的子节点
                AddTvNode(allTypes, node, expType.ExpTypeId); // 递归执行
            }
        }

        /// <summary>
        /// 查询条件初始化
        /// </summary>
        private void InitFindConditions()
        {
            tvExpTypes.SelectedNode = tvExpTypes.Nodes[0];
            chkShowDel.Checked = false;
            cboStations.SelectedIndex = 0;
            cboStates.SelectedIndex = 0;
            cboPickWays.SelectedIndex = 0;
            foreach (Control c in gbExpCondition.Controls)
            {
                if (c is TextBox)
                    c.Text = "";
            }
        }


        /// <summary>
        /// 选择快递类别后
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tvExpTypes_AfterSelect(object sender, TreeViewEventArgs e)
        {
            FindExpressList();
            //cboPickWays.Text = "全部";
            //cboStates.Text = "全部";
        }

        /// <summary>
        /// 点击查询按钮触发
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFind_Click(object sender, EventArgs e)
        {
            FindExpressList();
        }

        /// <summary>
        /// 改变显示已删除数据按钮触发
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chkShowDel_CheckedChanged(object sender, EventArgs e)
        {
            FindExpressList();
        }

        /// <summary>
        /// 页码改变刷新分页控件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uPager1_PageChanged(object sender, EventArgs e)
        {
            if (isFirst == 1)
                FindExpressList();
        }

        List<ViewExpressInfo> selectItems = new List<ViewExpressInfo>(); // 选择行的数据列表
        /// <summary>
        /// 选择表格数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvExpressList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // 当前单元格
            DataGridViewCell cell = dgvExpressList.Rows[e.RowIndex].Cells[e.ColumnIndex];
            ViewExpressInfo info = dgvExpressList.Rows[e.RowIndex].DataBoundItem as ViewExpressInfo;
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
        /// 点击修改，打开快递信息修改页
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvExpressList.SelectedRows.Count == 0)
            {
                MessageHelper.Error("修改快递", "请选择要修改的快递信息！");
                return;
            }
            else
            {
                ViewExpressInfo vexpInfo = dgvExpressList.SelectedRows[0].DataBoundItem as ViewExpressInfo;
                if (vexpInfo.ExpState != "已签收")
                {
                    ShowExpressInfoPage(2, vexpInfo.ExpId); // 快递签收
                }
                else
                {
                    MessageHelper.Error("修改快递", "快递已签收，不能再修改！");
                    return;
                }
            }
        }

        /// <summary>
        /// 点击快递录入，打开快递信息新增页
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            ShowExpressInfoPage(1, 0);
        }

        /// <summary>
        /// 打开快递信息页
        /// </summary>
        /// <param name="actType">操作类型：1-新增；2-修改</param>
        /// <param name="expId">修改时要传入修改的快递信息ID</param>
        private void ShowExpressInfoPage(int actType, int expId)
        {
            FrmExpressInfo frmExpressInfo = new FrmExpressInfo();
            frmExpressInfo.actType = actType;
            frmExpressInfo.Tag = expId;
            frmExpressInfo.ReloadExpressEvent += FrmExpressInfo_ReloadExpressEvent;
            frmExpressInfo.Show();
        }

        /// <summary>
        /// 快递列表刷新事件触发
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmExpressInfo_ReloadExpressEvent(object sender, ExpressArgs e)
        {
            if (e.VExpressInfo != null)
            {
                List<ViewExpressInfo> expList = dgvExpressList.DataSource as List<ViewExpressInfo>;
                dgvExpressList.DataSource = null;
                if (expList == null)
                    expList = new List<ViewExpressInfo>();
                if (e.ActType == 1)
                {
                    // 新增
                    expList.Add(e.VExpressInfo);
                }
                else
                {
                    // 修改
                    int index = expList.FindIndex(exp => exp.ExpId == e.VExpressInfo.ExpId); // 查找被修改数据索引
                    if (index != -1)
                    {
                        expList[index] = e.VExpressInfo; // 将旧数据替换为新修改的
                    }
                }
                dgvExpressList.DataSource = expList;
            }
        }

        /// <summary>
        /// 删除快递
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteExpresses(1);
        }

        /// <summary>
        /// 恢复快递
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRecover_Click(object sender, EventArgs e)
        {
            DeleteExpresses(0);
        }

        /// <summary>
        /// 移除快递
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRemove_Click(object sender, EventArgs e)
        {
            DeleteExpresses(2);
        }

        /// <summary>
        /// 删除、恢复、移除快递
        /// </summary>
        /// <param name="isDeleted">1-逻辑删除；0-恢复；2-永久删除</param>
        private void DeleteExpresses(int isDeleted)
        {
            string actName = FormUtility.GetDelTypeName(isDeleted);
            string msgTitle = $"{actName}快递";
            if (selectItems.Count > 0)
            {
                if (MessageHelper.Confirm(msgTitle, $"你确定要{actName}选择的快递信息吗？") == DialogResult.OK)
                {
                    bool bl = false; // 执行结果（恢复、移除）
                    List<int> delIds = selectItems.Select(s => s.ExpId).ToList(); // 选中的快递编号集合
                    switch (isDeleted)
                    {
                        case 1:
                            string reStr = expressBLL.DeleteExpresses(selectItems); // 删除方法
                            string[] reArr = reStr.Split(';');
                            if (reArr[0] == "1")
                            {
                                if (reArr.Length == 1)
                                {
                                    // 删除成功，没有不能删除的快递信息
                                    MessageHelper.Info(msgTitle, "选择的快递信息删除成功！");
                                    dgvExpressList.UpdateDgv(selectItems);
                                }
                                else
                                {
                                    MessageHelper.Info(msgTitle, $"选择的快递中，{reArr[1]}都还未签收，不能删除！其余的快递信息删除成功！");
                                    // 刷新  筛选出能删除快递信息
                                    var delList = selectItems.Where(exp => exp.ExpState == "已签收").ToList();
                                    dgvExpressList.UpdateDgv(delList); // 刷新
                                }
                                selectItems.Clear(); // 清空选中的数据
                            }
                            else if (reArr[0] == "0")
                            {
                                MessageHelper.Error(msgTitle, "选择的快递信息删除失败！");
                                return;
                            }
                            else
                            {
                                MessageHelper.Error(msgTitle, "选择的快递都还未签收，不能删除！");
                                return;
                            }
                            break;
                        case 0:
                            bl = expressBLL.RecoverExpresses(delIds); // 恢复
                            break;
                        case 2:
                            bl = expressBLL.RemoveExpresses(delIds); // 永久删除
                            break;
                    }
                    if (isDeleted != 1)
                    {
                        if (bl)
                        {
                            MessageHelper.Info(msgTitle, $"选择的快递{actName}成功！");
                            dgvExpressList.UpdateDgv(selectItems);
                            selectItems.Clear();
                        }
                        else
                        {
                            MessageHelper.Error(msgTitle, $"选择的快递信息{actName}失败！");
                            return;
                        }
                    }
                }
            }
            else
            {
                MessageHelper.Error(msgTitle, $"请选择要{actName}的快递信息");
                return;
            }
        }
    }
}
