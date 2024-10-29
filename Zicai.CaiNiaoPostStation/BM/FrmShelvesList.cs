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
using Zhaoxi.CainiaoPostStation.Models.UIModels;
using Zicai.CaiNiaoPostStation.BLL;
using Zicai.CaiNiaoPostStation.Models;
using Zicai.CaiNiaoPostStation.Utility;
using ZiCai.CaiNiaoPostStation.Utility;

namespace Zicai.CaiNiaoPostStation.BM
{
    public partial class FrmShelvesList : Form
    {
        public FrmShelvesList()
        {
            InitializeComponent();
        }

        ShelfBLL shelfBLL = new ShelfBLL();
        StationBLL stationBLL = new StationBLL();
        int actType = 1; // 信息提交状态  1-新增 2-修改
        int editShelfId = 0; // 当前正在修改的货架编号
        bool isFirst = true; // 第一次加载
        int totalCount = 0; // 总货架数
        string oldNo = "", oldName = ""; // 修改前名称和编码
        Random random = new Random(); // 随机数

        private void FrmShelvesList_Load(object sender, EventArgs e)
        {
            // 加载站点下拉框、站点下拉框列
            LoadCboStations();
            dgvShelvesList.CurrentCellDirtyStateChanged += FormUtility.DgvList_CurrentCellDirtyStateChanged;
            // 加载货架列表
            FindShelvesList();
            // 清空信息栏
            InitShelfInfo();
        }

        /// <summary>
        /// 加载站点下拉框、站点下拉框列
        /// </summary>
        private void LoadCboStations()
        {
            List<StationInfo> stations = stationBLL.GetCboStationList();
            // 添加默认项
            stations.Insert(0, new StationInfo()
            {
                StationId = 0,
                StationName = "请选择站点"
            });
            cboStations.DisplayMember = "StationName";
            cboStations.ValueMember = "StationId";
            cboStations.DataSource = stations;
            cboStations.SelectedIndex = 0; // 默认提示选择
            
            // 表格内站点列数据
            DataGridViewComboBoxColumn cboStationCol = dgvShelvesList.Columns["colStation"] as DataGridViewComboBoxColumn;
            cboStationCol.DisplayMember = "StationName";
            cboStationCol.ValueMember = "StationId";
            cboStationCol.DataSource = stations;
        }

        /// <summary>
        /// 查询货架列表
        /// </summary>
        private void FindShelvesList()
        {
            string keywords = txtKeyWords.Text.Trim(); // 查询关键词
            bool showDel = chkShowDel.Checked; // 是否显示已删除数据
            int startIndex = uPager1.StartIndex; // 当页的开始索引
            int pageSize = uPager1.PageSize; // 每页记录数
            dgvShelvesList.AutoGenerateColumns = false;
            PageModel<ShelfInfo> pageModel = shelfBLL.FindShelveList(keywords, showDel, startIndex, pageSize);
            if (pageModel.TotalCount > 0)
            {
                dgvShelvesList.DataSource = pageModel.PageList;
                uPager1.Record = pageModel.TotalCount;
                if (isFirst)
                {
                    totalCount = pageModel.TotalCount;
                    isFirst = false;
                }
                uPager1.Enabled = true;
            }
            else
            {
                dgvShelvesList.DataSource = null;
                uPager1.Enabled = false;
            }
            SetActBtnsAndColVisible(showDel);
        }

        /// <summary>
        /// 设置操作按钮和行内操作列的显示
        /// </summary>
        /// <param name="showDel">是否显示已删除数据</param>
        private void SetActBtnsAndColVisible(bool showDel)
        {
            btnDelete.Visible = !showDel;
            btnRecover.Visible = showDel;
            btnRemove.Visible = showDel;
            dgvShelvesList.Columns["colEdit"].Visible = !showDel;
            dgvShelvesList.Columns["colDel"].Visible = !showDel;
            dgvShelvesList.Columns["colRecover"].Visible = showDel;
            dgvShelvesList.Columns["colRemove"].Visible = showDel;
        }

        /// <summary>
        /// 信息栏初始化
        /// </summary>
        private void InitShelfInfo()
        {
            foreach (Control c in gbShelfInfo.Controls)
            {
                if (c is TextBox)
                {
                    c.Text = "";
                }
            }
            cboStations.SelectedIndex = 0; // 显示默认提示
            lblErrMsg.Visible = false; // 隐藏异常标签
            //默认生成初始编码
            string createNo = "H";
            totalCount++; // 总数加一
            createNo += random.Next(0, 100000000).ToString("D8"); // 0到99999999之间的随机数，不足8位前补0
            txtShelfNo.Text = createNo;
            actType = 1;//新增
            btnOk.Text = "添加";
        }

        /// <summary>
        /// 已删除切换
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chkShowDel_CheckedChanged(object sender, EventArgs e)
        {
            FindShelvesList();
        }

        /// <summary>
        /// 翻页
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uPager1_PageChanged(object sender, EventArgs e)
        {
            FindShelvesList();
        }

        /// <summary>
        /// 查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFind_Click(object sender, EventArgs e)
        {
            FindShelvesList();
        }

        List<ShelfInfo> selectItems = new List<ShelfInfo>(); // 选择行的数据列表
        /// <summary>
        ///  多行选择、行内按钮单击操作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvShelvesList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //当前单元格
            DataGridViewCell cell = dgvShelvesList.Rows[e.RowIndex].Cells[e.ColumnIndex];
            ShelfInfo info = dgvShelvesList.Rows[e.RowIndex].DataBoundItem as ShelfInfo;
            //选择行
            if (cell is DataGridViewCheckBoxCell)
            {
                if (cell.FormattedValue.ToString() == "True")
                    selectItems.Add(info);
                else
                    selectItems.Remove(info);
            }
            else if (cell is DataGridViewLinkCell)
            {
                string cellValue = cell.FormattedValue.ToString();
                switch (cellValue)
                {
                    case "修改":
                        InitEditShelfInfo(info);
                        break;
                    case "删除":
                        DeleteShelf(info, 1);
                        break;
                    case "恢复":
                        DeleteShelf(info, 0);
                        break;
                    case "移除":
                        DeleteShelf(info, 2);
                        break;
                }
            }
        }

        /// <summary>
        /// 加载货架信息
        /// </summary>
        /// <param name="shelfInfo">货架信息</param>
        private void InitEditShelfInfo(ShelfInfo shelfInfo)
        {
            if (shelfInfo != null)
            {
                txtShelfNo.Text = shelfInfo.ShelfNo;
                txtShelfName.Text = shelfInfo.ShelfName;
                txtAddress.Text = shelfInfo.Address;
                cboStations.SelectedValue = shelfInfo.StationId;
                txtRemark.Text = shelfInfo.Remark;
                editShelfId = shelfInfo.ShelfId;
                oldName = shelfInfo.ShelfName;
                oldNo = shelfInfo.ShelfNo;
                actType = 2;
                btnOk.Text = "修改";
            }
        }

        /// <summary>
        /// 单个货架信息的删除、恢复、移除
        /// </summary>
        /// <param name="shelfInfo">货架信息</param>
        /// <param name="isDeleted">1-删除；0-恢复；2-移除</param>
        private void DeleteShelf(ShelfInfo shelfInfo, int isDeleted)
        {
            string[] titleMsg = FormUtility.GetActTitleAndMsg("货架", isDeleted);
            string msgTitle = titleMsg[0];
            string msg = titleMsg[1];
            if (MessageHelper.Confirm(msgTitle, msg) == DialogResult.OK)
            {
                // 确认执行操作
                List<int> ids = new List<int> { shelfInfo.ShelfId };
                List<ShelfInfo> delList = new List<ShelfInfo> { shelfInfo };
                string msgInfoName = $"货架：{shelfInfo.ShelfName} ";
                switch (isDeleted)
                {
                    case 1:
                        string restr = shelfBLL.DeleteShelves(delList, out List<int> hasIds); // 删除
                        string[] reArr = restr.Split(';'); // 结果字符串分隔

                        if (reArr[0] == "1")
                        {
                            MessageHelper.Info(msgTitle, $"{msgInfoName} 删除成功！");
                            dgvShelvesList.UpdateDgv(delList); // 更新dgv
                        }
                        else if (reArr[0] == "0")
                        {
                            MessageHelper.Info(msgTitle, $"{msgInfoName} 删除失败！");
                            return;
                        }
                        else
                        {
                            MessageHelper.Info(msgTitle, $"{msgInfoName} 在运营中，不能删除！");
                            return;
                        }
                        break;
                    case 0:
                        bool blRecover = shelfBLL.RecoverShelves(ids);
                        if (blRecover)
                        {
                            MessageHelper.Info(msgTitle, $"{msgInfoName} 恢复成功！");
                            dgvShelvesList.UpdateDgv(delList); // 更新dgv
                        }
                        else
                        {
                            MessageHelper.Info(msgTitle, $"{msgInfoName}恢复失败！");
                            return;
                        }
                        break;
                    case 2:
                        bool blRemove = shelfBLL.RemoveShelves(ids);
                        if (blRemove)
                        {
                            MessageHelper.Info(msgTitle, $"{msgInfoName} 移除成功！");
                            dgvShelvesList.UpdateDgv(delList); // 更新dgv
                        }
                        else
                        {
                            MessageHelper.Info(msgTitle, $"{msgInfoName}移除失败！");
                            return;
                        }
                        break;
                }
            }
        }

        /// <summary>
        /// 货架信息提交功能
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOk_Click(object sender, EventArgs e)
        {
            //接收信息
            string shelfNo = txtShelfNo.Text.Trim();
            string shelfName = txtShelfName.Text.Trim();
            string address = txtAddress.Text.Trim();
            string remark = txtRemark.Text.Trim();
            int stationId = cboStations.SelectedValue.GetInt();
            //检查信息
            if (string.IsNullOrEmpty(shelfNo))
            {
                lblErrMsg.SetErrorMsg("请输入货架编码！");
                txtShelfNo.Focus();
                return;
            }
            else if ((actType == 1 || (actType == 2 && oldNo != shelfNo)) && shelfBLL.ExistShelfNo(shelfNo))
            {
                lblErrMsg.SetErrorMsg("该货架编码已存在！");
                txtShelfNo.Focus();
                return;
            }
            if (stationId == 0)
            {
                lblErrMsg.SetErrorMsg("请选择所在站点！");
                return;
            }
            if (string.IsNullOrEmpty(shelfName))
            {
                lblErrMsg.SetErrorMsg("请输入货架名称！");
                txtShelfName.Focus();
                return;
            }
            else if ((actType == 1 || (actType == 2 && oldName != shelfName)) && shelfBLL.ExistShelfName(shelfName, stationId))
            {
                lblErrMsg.SetErrorMsg("该货架名称已存在！");
                txtShelfName.Focus();
                return;
            }
            if (string.IsNullOrEmpty(address))
            {
                lblErrMsg.SetErrorMsg("请输入货架存放位置！");
                txtAddress.Focus();
                return;
            }

            // 封装信息
            ShelfInfo shelf = new ShelfInfo()
            {
                ShelfId = editShelfId,
                ShelfNo = shelfNo,
                ShelfName = shelfName,
                StationId = stationId,
                Address = address,
                Remark = remark
            };

            // 提交处理
            if (actType == 1) // 新增
            {
                int reId = shelfBLL.AddShelf(shelf); // 添加货架信息，返回货架ID
                if (reId > 0)
                {
                    MessageHelper.Info("添加货架", $"货架：{shelfName} 添加成功！");
                    shelf.ShelfId = reId;
                    //添加货架信息到货架列表中
                    dgvShelvesList.UpdateDgv(1, shelf, 0);
                    editShelfId = reId;
                    btnOk.Text = "修改";
                    actType = 2;
                    oldName = shelfName;
                    oldNo = shelfNo;
                }
                else
                {
                    lblErrMsg.SetErrorMsg("货架信息添加失败！");
                    return;
                }
            }
            else // 修改
            {
                bool blEdit = shelfBLL.UpdateShelf(shelf);
                if (blEdit)
                {
                    MessageHelper.Info("修改货架", $"货架：{shelfName} 修改成功！");
                    oldName = shelfName;
                    oldNo = shelfNo;
                    //更新货架信息到货架列表中
                    dgvShelvesList.UpdateDgv(2, shelf, editShelfId);
                }
                else
                {
                    lblErrMsg.SetErrorMsg("货架信息修改失败！");
                    return;
                }
            }
        }

        /// <summary>
        /// 鼠标按下输入框隐藏错误提示
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TextBox_MouseDown(object sender, MouseEventArgs e)
        {
            lblErrMsg.Visible = false;
            lblErrMsg.Text = "";
        }

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteShelves(1);
        }

        /// <summary>
        /// 恢复
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRecover_Click(object sender, EventArgs e)
        {
            DeleteShelves(0);
        }

        /// <summary>
        /// 移除
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRemove_Click(object sender, EventArgs e)
        {
            DeleteShelves(2);
        }

        /// <summary>
        /// 批量删除、恢复、移除货架信息处理
        /// </summary>
        /// <param name="isDeleted"></param>
        private void DeleteShelves(int isDeleted)
        {
            string actName = FormUtility.GetDelTypeName(isDeleted);
            string msgTitle = $"{actName}货架";
            if (selectItems.Count > 0)
            {
                if (MessageHelper.Confirm(msgTitle, $"你确定要{actName}选择的货架信息吗？") == DialogResult.OK)
                {
                    bool bl = false; // 执行结果
                    List<int> delIds = selectItems.Select(s => s.ShelfId).ToList(); // 货架编号集合
                    switch (isDeleted)
                    {
                        case 1:
                            string reStr = shelfBLL.DeleteShelves(selectItems, out List<int> hasIds); // 删除方法
                            string[] reArr = reStr.Split(';');
                            if (reArr[0] == "1")
                            {
                                if (reArr.Length == 1)
                                {
                                    // 删除成功，没有不能删除的货架
                                    MessageHelper.Info(msgTitle, "选择的货架删除成功！");
                                    dgvShelvesList.UpdateDgv(selectItems);
                                }
                                else
                                {
                                    MessageHelper.Info(msgTitle, $"选择的货架中，{reArr[1]}正在使用中，不能删除！其余的货架删除成功！");
                                    // 刷新  筛选出能删除货架
                                    var delList = selectItems.Where(s => !hasIds.Contains(s.ShelfId)).ToList();
                                    dgvShelvesList.UpdateDgv(delList);
                                }
                                selectItems.Clear();//清空
                            }
                            else if (reArr[0] == "0")
                            {
                                MessageHelper.Error(msgTitle, "选择的货架删除失败！");
                                return;
                            }
                            else
                            {
                                MessageHelper.Error(msgTitle, "选择的货架都在使用中，不能删除！");
                                return;
                            }
                            break;
                        case 0:
                            bl = shelfBLL.RecoverShelves(delIds);
                            break;
                        case 2:
                            bl = shelfBLL.RemoveShelves(delIds);
                            break;
                    }
                    if (isDeleted != 1)
                    {
                        if (bl)
                        {
                            MessageHelper.Info(msgTitle, $"选择的货架{actName}成功！");
                            dgvShelvesList.UpdateDgv(selectItems);
                            selectItems.Clear();
                        }
                        else
                        {
                            MessageHelper.Error(msgTitle, $"选择的货架{actName}失败！");
                            return;
                        }
                    }
                }
            }
            else
            {
                MessageHelper.Error(msgTitle, $"请选择要{actName}的货架信息");
                return;
            }
        }


        /// <summary>
        /// 重置
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReset_Click(object sender, EventArgs e)
        {
            InitShelfInfo();
        }

    }
}
