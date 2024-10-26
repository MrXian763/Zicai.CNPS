using Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zicai.CaiNiaoPostStation.UControls
{
    public partial class UPager : UserControl
    {
        public UPager()
        {
            InitializeComponent();
        }

        // 定义委托
        public delegate void PageHandler(object sender, EventArgs e);
        // 声明翻页事件
        public event PageHandler PageChanged;

        private int record = 0;
        /// <summary>
        /// 总记录数
        /// </summary>
        public int Record
        {
            get { return record; }
            set 
            { 
                record = value;
                InitPageInfo();
            }
    }

        private int startIndex = 1;
        /// <summary>
        /// 当前页开始索引
        /// </summary>
        public int StartIndex
        {
            get { return (CurrentPage - 1) * PageSize + 1; }
            set { startIndex = value; }
        }

        private int pageSize = 10;
        /// <summary>
        /// 每页显示记录数
        /// </summary>
        public int PageSize
        {
            get { return pageSize; }
            set { pageSize = value; }
        }

        private int currentPage = 1;
        /// <summary>
        /// 当前页索引
        /// </summary>
        public int CurrentPage
        {
            get { return currentPage; }
            set { currentPage = value; }
        }

        private int pageNum;

        /// <summary>
        /// 总页数
        /// </summary>
        public int PageNum
        {
            get 
            {
                if (record == 0)
                    pageNum = 0;
                else
                {
                    if (Record % PageSize > 0)
                        pageNum = Record / PageSize + 1;
                    else
                        pageNum = Record / PageSize;
                }
                return pageNum;
            }
        }

        private void UPager_Load(object sender, EventArgs e)
        {
            //OnPageChanged();
        }

        /// <summary>
        /// 页码改变
        /// </summary>
        private void OnPageChanged()
        {
            if (PageChanged != null)
            {
                PageChanged(this, new EventArgs());
                InitPageInfo();
            }
        }

        /// <summary>
        /// 刷新分页控件
        /// </summary>
        private void InitPageInfo()
        {
            if (record > 0)
            {
                if (CurrentPage > PageNum) // 输入的页码大于总页码数
                    CurrentPage = PageNum;
                if (CurrentPage < 1) // 输入的页码小于1
                    CurrentPage = 1;
            }

            if (CurrentPage == 1)
            {
                // 当前页码为第一页则取消向前按钮
                btnFirst.Enabled = false;
                btnPrev.Enabled = false;
                if (CurrentPage == PageNum)
                {
                    // 只有一页数据
                    btnNext.Enabled = false;
                    btnLast.Enabled = false;
                    btnGoPage.Enabled = false;
                }
                else
                {
                    btnNext.Enabled = true;
                    btnLast.Enabled = true;
                    btnGoPage.Enabled = true;
                }
            }
            else if (CurrentPage > 1)
            {
                // 当前页码不是第一页
                btnFirst.Enabled = true;
                btnPrev.Enabled = true;
                btnGoPage.Enabled = true;
                if (CurrentPage < PageNum)
                {
                    // 当前页码不是最后一页
                    btnNext.Enabled = true;
                    btnLast.Enabled = true;
                }
                else
                {
                    // 当前页码是最后一页
                    btnNext.Enabled = false;
                    btnLast.Enabled = false;
                }
            }

            // 被禁用的按钮设置为深灰色
            foreach (Control c in this.Controls)
            {
                if (c is Button && c.Enabled == false)
                {
                    c.BackColor = Color.DarkGray;
                }
            }

            // 处理分页信息展示
            lblPageInfo.Text = $"共 {Record} 条记录，共 {PageSize} 页，当前第 {CurrentPage} 页";
            // 跳转页文本框默认显示当前页码
            txtPage.Text = CurrentPage.ToString();
        }

        /// <summary>
        /// 首页
        /// </summary>
        private void btnFirst_Click(object sender, EventArgs e)
        {
            if (CurrentPage > 1)
            {
                CurrentPage = 1;
                OnPageChanged();
            }
        }

        /// <summary>
        /// 前一页
        /// </summary>
        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (CurrentPage > 1)
            {
                CurrentPage -= 1;
                OnPageChanged();
            }
        }

        /// <summary>
        /// 后一页
        /// </summary>
        private void btnNext_Click(object sender, EventArgs e)
        {
            if (CurrentPage < PageNum)
            {
                CurrentPage += 1;
                OnPageChanged();
            }
        }

        /// <summary>
        /// 最后一页
        /// </summary>
        private void btnLast_Click(object sender, EventArgs e)
        {
            if (CurrentPage < PageNum)
            {
                CurrentPage = PageNum;
                OnPageChanged();
            }
        }

        /// <summary>
        /// 转到指定页
        /// </summary>
        private void btnGoPage_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtPage.Text) && !Regex.IsMatch(txtPage.Text, @"^[\d]*$"))
            {
                MessageBox.Show("请输入正确的页面！");
                return;
            }
            int page = txtPage.Text.GetInt();
            if (page < 1)
            {
                page = 1;
            }
            if (page > pageNum)
            {
                page = pageNum;
            }
            CurrentPage = page;
            OnPageChanged();
        }
    }
}
