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
using ZiCai.CainiaoPostStation.Models;
using Zicai.CaiNiaoPostStation.Utility;
using ZiCai.CaiNiaoPostStation.Utility;
using ZXIMEW.Common;

namespace Zicai.CaiNiaoPostStation.BM
{
    public partial class FrmExpTypeList : Form
    {
        public FrmExpTypeList()
        {
            InitializeComponent();
        }

        ExpressTypeBLL expTypeBLL = new ExpressTypeBLL();
        int actType = 1;
        int editTypeId = 0;
        int oldParentId = 0; // 修改前的父类别编号
        string oldName = ""; // 修改前的类别名称

        /// <summary>
        /// 页面加载触发
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmExpTypeList_Load(object sender, EventArgs e)
        {
            // 加载父类别列表
            LoadCboParents();
            // 禁用自动生成列，使用自定义列
            dgvExpTypeList.AutoGenerateColumns = false;
            // 处理当前单元格状态改变事件
            dgvExpTypeList.CurrentCellDirtyStateChanged += FormUtility.DgvList_CurrentCellDirtyStateChanged;
            // 加载类别列表
            FindExpressTypeList();
            // 初始化信息栏
            InitExpTypeInfo(0);
        }

        /// <summary>
        /// 加载父类别列表
        /// </summary>
        private void LoadCboParents()
        {
            List<ExpressTypeInfo> typeList = expTypeBLL.GetCboExpTypes(1);
            typeList.Insert(0, new ExpressTypeInfo()
            {
                ExpTypeId = 0,
                ExpTypeName = "请选择父类别"
            });
            cboParents.DisplayMember = "ExpTypeName";
            cboParents.ValueMember = "ExpTypeId";
            cboParents.DataSource = typeList;

        }

        /// <summary>
        /// 查询类别列表
        /// </summary>
        private void FindExpressTypeList()
        {
            string keywords = txtKeyWords.Text.Trim(); // 查询关键词
            bool showDel = chkShowDel.Checked; // 是否查询已删除数据
            List<ViewExpressTypeInfo> expTypeList = expTypeBLL.GetExpressTypeList(keywords, showDel);
            if (expTypeList.Count > 0)
                dgvExpTypeList.DataSource = expTypeList;
            else
                dgvExpTypeList.DataSource = null;
            // 设置操作按钮和操作列的显示
            SetActBtnsAndColVisible(showDel);
        }

        /// <summary>
        /// 设置操作按钮和行内操作列的显示
        /// </summary>
        /// <param name="showDel"></param>
        private void SetActBtnsAndColVisible(bool showDel)
        {
            btnEdit.Visible = !showDel;
            btnDelete.Visible = !showDel;
            btnRecover.Visible = showDel;
            btnRemove.Visible = showDel;
            dgvExpTypeList.Columns["colAddChild"].Visible = !showDel;
        }

        /// <summary>
        /// 初始化信息栏
        /// </summary>
        /// <param name="parentId">信息栏父分类ID</param>
        private void InitExpTypeInfo(int parentId)
        {
            txtExpTypeName.Clear(); // 清空信息栏
            if (parentId > 0)
            {
                if (cboParents.SelectedValue == null)
                    cboParents.SelectedValue = 0; // 默认选项
                cboParents.SelectedValue = parentId;
                cboParents.Enabled = false;
            }
            else
            {
                cboParents.SelectedValue = 0;
                cboParents.Enabled = true;
            }

            txtOrderNum.Value = 1; // 排序号默认1
            txtPYNo.Clear();
            txtRemark.Clear();
            lblErrMsg.Visible = false; // 隐藏错误提示消息
            actType = 1; // 模式为添加
            btnOk.Text = "添加";
        }



        /// <summary>
        /// 查询按钮触发
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFind_Click(object sender, EventArgs e)
        {
            FindExpressTypeList();
        }

        /// <summary>
        /// 已删除复选框改变触发
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chkShowDel_CheckedChanged(object sender, EventArgs e)
        {
            FindExpressTypeList();
        }

        /// <summary>
        /// 重置按钮触发
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReset_Click(object sender, EventArgs e)
        {
            InitExpTypeInfo(0);
        }

        List<ViewExpressTypeInfo> selectItems = new List<ViewExpressTypeInfo>(); // 选择行的数据列表
        /// <summary>
        /// 行选择、行内按钮单击操作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvExpTypeList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // 当前单元格
            DataGridViewCell cell = dgvExpTypeList.Rows[e.RowIndex].Cells[e.ColumnIndex];
            ViewExpressTypeInfo info = dgvExpTypeList.Rows[e.RowIndex].DataBoundItem as ViewExpressTypeInfo;
            if (cell is DataGridViewCheckBoxCell)
            {
                // 选择行
                if (cell.FormattedValue.ToString() == "True")
                    selectItems.Add(info); // 选中
                else
                    selectItems.Remove(info); // 移除
            }
            else if (cell is DataGridViewLinkCell)
            {
                // 添加子分类
                string cellValue = cell.FormattedValue.ToString();
                if (cellValue.Contains("添加子分类"))
                    InitExpTypeInfo(info.ExpTypeId); // 设置信息栏父分类ID
            }
        }

        /// <summary>
        /// 修改加载当前类别信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvExpTypeList.SelectedRows.Count > 0)
            {
                ViewExpressTypeInfo info = dgvExpTypeList.SelectedRows[0].DataBoundItem as ViewExpressTypeInfo; // 选择行的数据
                if (info != null)
                {
                    // 加载当前行类别信息到信息栏
                    editTypeId = info.ExpTypeId;
                    txtExpTypeName.Text = info.ExpTypeName;
                    cboParents.SelectedValue = info.ParentId;
                    txtOrderNum.Value = info.OrderNum;
                    txtPYNo.Text = info.ExpTypePYNo;
                    txtRemark.Text = info.Remark;
                    oldName = info.ExpTypeName;
                    oldParentId = info.ParentId;
                    actType = 2;
                    btnOk.Text = "修改";
                }
            }
        }

        /// <summary>
        /// 添加（添加子类）或修改类别信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOk_Click(object sender, EventArgs e)
        {
            // 接收信息
            string typeName = txtExpTypeName.Text.Trim();
            int parentId = cboParents.SelectedValue.GetInt();
            string parentName = cboParents.Text.Trim();
            int orderNum = Convert.ToInt32(txtOrderNum.Value);
            string pyNo = txtPYNo.Text.Trim();
            string remark = txtRemark.Text.Trim();
            // 信息检查
            if (string.IsNullOrEmpty(typeName))
            {
                lblErrMsg.SetErrorMsg("请输入类别名称！");
                txtExpTypeName.Focus();
                return;
            }
            else if ((actType == 1) || (actType == 2 && (oldName != typeName || oldParentId != parentId)))
            {
                if (expTypeBLL.ExistExpType(typeName, parentId))
                {
                    lblErrMsg.SetErrorMsg("该类别名称已存在！");
                    txtExpTypeName.Focus();
                    return;
                }
            }
            if (parentId == 0)
            {
                parentName = "";
            }
            // 信息封装
            ExpressTypeInfo expTypeInfo = new ExpressTypeInfo()
            {
                ExpTypeId = editTypeId,
                ExpTypeName = typeName,
                ParentId = parentId,
                ExpTypePYNo = pyNo,
                OrderNum = orderNum,
                Remark = remark
            };
            ViewExpressTypeInfo viewTypeInfo = new ViewExpressTypeInfo(expTypeInfo, parentName);
            // 提交处理
            if (actType == 1)
            {
                // 新增
                int reId = expTypeBLL.AddExpType(expTypeInfo);
                if (reId > 0)
                {
                    MessageHelper.Info("添加快递类别", $"类别：{typeName} 添加成功！");
                    expTypeInfo.ExpTypeId = reId;
                    //viewTypeInfo.ExpTypeId = reId;
                    // 添加类别信息到类别列表中
                    dgvExpTypeList.UpdateDgv(1, viewTypeInfo, 0);
                    editTypeId = reId; // 当前编辑数据ID更新为刚创建的数据
                    btnOk.Text = "修改";
                    actType = 2; // 信息栏模式更新为修改
                    oldName = typeName;
                    oldParentId = parentId;
                }
                else
                {
                    lblErrMsg.SetErrorMsg("快递类别信息添加失败！");
                    return;
                }
            }
            else
            {
                // 修改
                bool blEdit = expTypeBLL.UpdateExpType(expTypeInfo);
                if (blEdit)
                {
                    MessageHelper.Info("修改快递类别", $"类别：{typeName} 修改成功！");
                    oldName = typeName;
                    oldParentId = parentId;
                    //更新类别信息到类别列表中
                    dgvExpTypeList.UpdateDgv(2, viewTypeInfo, editTypeId);
                }
                else
                {
                    lblErrMsg.SetErrorMsg("快递类别信息修改失败！");
                    return;
                }
            }
        }

        /// <summary>
        /// 生成拼音码
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtExpTypeName_TextChanged(object sender, EventArgs e)
        {
            string typeName = txtExpTypeName.Text.Trim();
            txtPYNo.Text = PingYinHelper.GetFirstSpell(typeName);
        }

        /// <summary>
        /// 点击输入框隐藏错误提示信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtExpTypeName_MouseDown(object sender, MouseEventArgs e)
        {
            lblErrMsg.Visible = false;
            lblErrMsg.Text = "";
        }

        /// <summary>
        /// 删除快递类别
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteExpTypes(1);
        }

        /// <summary>
        /// 恢复快递类别
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRecover_Click(object sender, EventArgs e)
        {
            DeleteExpTypes(0);
        }

        /// <summary>
        ///移除快递类别
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRemove_Click(object sender, EventArgs e)
        {
            DeleteExpTypes(2);
        }

        /// <summary>
        /// 批量删除、恢复、移除快递类别信息处理
        /// </summary>
        /// <param name="isDeleted">1-逻辑删除；0-恢复；2-永久删除</param>
        private void DeleteExpTypes(int isDeleted)
        {
            string actName = FormUtility.GetDelTypeName(isDeleted);
            string msgTitle = $"{actName}快递类别";
            if (selectItems.Count > 0)
            {
                if (MessageHelper.Confirm(msgTitle, $"你确定要{actName}选择的类别信息吗？") == DialogResult.OK)
                {
                    // 执行删除
                    bool bl = false; // 执行结果
                    List<int> delIds = selectItems.Select(t => t.ExpTypeId).ToList(); // 要删除的类别编号集合
                    switch (isDeleted)
                    {
                        case 1:
                            string reStr = expTypeBLL.DeleteExpressTypes(selectItems, out List<int> hasIds); // 删除方法
                            string[] reArr = reStr.Split(';');
                            if (reArr[0] == "1")
                            {
                                if (reArr.Length == 1)
                                {
                                    // 删除成功，没有不能删除的类别
                                    MessageHelper.Info(msgTitle, "选择的快递类别删除成功！");
                                    dgvExpTypeList.UpdateDgv(selectItems);
                                }
                                else
                                {
                                    MessageHelper.Info(msgTitle, $"选择的类别中，{reArr[1]}有子类别，不能删除！其余的类别删除成功！");
                                    // 刷新  筛选出能删除类别
                                    var delList = selectItems.Where(t => !hasIds.Contains(t.ExpTypeId)).ToList();
                                    dgvExpTypeList.UpdateDgv(delList);
                                }
                                selectItems.Clear(); // 清空
                            }
                            else if (reArr[0] == "0")
                            {
                                MessageHelper.Error(msgTitle, "选择的类别删除失败！");
                                return;
                            }
                            else
                            {
                                MessageHelper.Error(msgTitle, "选择的类别都有子类别，不能删除！");
                                return;
                            }
                            break;
                        case 0:
                            bl = expTypeBLL.RecoverExpressTypes(delIds);
                            break;
                        case 2:
                            bl = expTypeBLL.RemoveExpressTypes(delIds);
                            break;
                    }
                    if (isDeleted != 1)
                    {
                        if (bl)
                        {
                            MessageHelper.Info(msgTitle, $"选择的类别{actName}成功！");
                            dgvExpTypeList.UpdateDgv(selectItems);
                            selectItems.Clear();
                        }
                        else
                        {
                            MessageHelper.Error(msgTitle, $"选择的类别{actName}失败！");
                            return;
                        }
                    }
                }
            }
            else
            {
                MessageHelper.Error(msgTitle, $"请选择要{actName}的快递类别信息");
                return;
            }
        }
    }
}
