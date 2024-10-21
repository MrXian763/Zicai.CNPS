namespace Zicai.CaiNiaoPostStation
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblLoginInfo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cainiaoMenus = new System.Windows.Forms.MenuStrip();
            this.基础信息维护ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.站点信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tbtnStation = new System.Windows.Forms.ToolStripButton();
            this.tbtnShelves = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tbtnEmployee = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tbtnExpress = new System.Windows.Forms.ToolStripButton();
            this.tbtnDistribute = new System.Windows.Forms.ToolStripButton();
            this.tbtnSelfPick = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblLoginTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblAction = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel6 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel7 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblCopyright = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabPages = new System.Windows.Forms.TabControl();
            this.picClose = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.cainiaoMenus.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.lblLoginInfo);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1348, 72);
            this.panel1.TabIndex = 0;
            // 
            // lblLoginInfo
            // 
            this.lblLoginInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLoginInfo.AutoSize = true;
            this.lblLoginInfo.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblLoginInfo.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.lblLoginInfo.Location = new System.Drawing.Point(1192, 36);
            this.lblLoginInfo.Name = "lblLoginInfo";
            this.lblLoginInfo.Size = new System.Drawing.Size(131, 17);
            this.lblLoginInfo.TabIndex = 2;
            this.lblLoginInfo.Text = "admin，欢迎使用系统";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(81, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "菜鸟驿站管理系统";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Zicai.CaiNiaoPostStation.Properties.Resources.门店;
            this.pictureBox1.Location = new System.Drawing.Point(12, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(63, 63);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // cainiaoMenus
            // 
            this.cainiaoMenus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cainiaoMenus.AutoSize = false;
            this.cainiaoMenus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(189)))), ((int)(((byte)(240)))));
            this.cainiaoMenus.Dock = System.Windows.Forms.DockStyle.None;
            this.cainiaoMenus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.基础信息维护ToolStripMenuItem});
            this.cainiaoMenus.Location = new System.Drawing.Point(1, 75);
            this.cainiaoMenus.Name = "cainiaoMenus";
            this.cainiaoMenus.Size = new System.Drawing.Size(1348, 40);
            this.cainiaoMenus.TabIndex = 2;
            this.cainiaoMenus.Text = "menuStrip1";
            // 
            // 基础信息维护ToolStripMenuItem
            // 
            this.基础信息维护ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.站点信息ToolStripMenuItem});
            this.基础信息维护ToolStripMenuItem.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.基础信息维护ToolStripMenuItem.ForeColor = System.Drawing.Color.Navy;
            this.基础信息维护ToolStripMenuItem.Name = "基础信息维护ToolStripMenuItem";
            this.基础信息维护ToolStripMenuItem.Size = new System.Drawing.Size(141, 36);
            this.基础信息维护ToolStripMenuItem.Text = "基础信息维护(&B)";
            // 
            // 站点信息ToolStripMenuItem
            // 
            this.站点信息ToolStripMenuItem.BackColor = System.Drawing.Color.LightGray;
            this.站点信息ToolStripMenuItem.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.站点信息ToolStripMenuItem.ForeColor = System.Drawing.Color.Blue;
            this.站点信息ToolStripMenuItem.Name = "站点信息ToolStripMenuItem";
            this.站点信息ToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.站点信息ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.站点信息ToolStripMenuItem.Size = new System.Drawing.Size(187, 24);
            this.站点信息ToolStripMenuItem.Text = "站点信息";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(238)))), ((int)(((byte)(251)))));
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbtnStation,
            this.tbtnShelves,
            this.toolStripSeparator1,
            this.tbtnEmployee,
            this.toolStripSeparator2,
            this.tbtnExpress,
            this.tbtnDistribute,
            this.tbtnSelfPick});
            this.toolStrip1.Location = new System.Drawing.Point(1, 115);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1348, 34);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tbtnStation
            // 
            this.tbtnStation.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold);
            this.tbtnStation.ForeColor = System.Drawing.Color.Gray;
            this.tbtnStation.Image = global::Zicai.CaiNiaoPostStation.Properties.Resources.zhandianguanli;
            this.tbtnStation.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tbtnStation.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnStation.Margin = new System.Windows.Forms.Padding(5, 1, 0, 2);
            this.tbtnStation.Name = "tbtnStation";
            this.tbtnStation.Size = new System.Drawing.Size(85, 31);
            this.tbtnStation.Text = "站点信息";
            // 
            // tbtnShelves
            // 
            this.tbtnShelves.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold);
            this.tbtnShelves.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tbtnShelves.Image = global::Zicai.CaiNiaoPostStation.Properties.Resources.huojia;
            this.tbtnShelves.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tbtnShelves.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnShelves.Margin = new System.Windows.Forms.Padding(5, 1, 0, 2);
            this.tbtnShelves.Name = "tbtnShelves";
            this.tbtnShelves.Size = new System.Drawing.Size(85, 31);
            this.tbtnShelves.Text = "货架信息";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 34);
            // 
            // tbtnEmployee
            // 
            this.tbtnEmployee.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold);
            this.tbtnEmployee.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.tbtnEmployee.Image = global::Zicai.CaiNiaoPostStation.Properties.Resources.yuangongguanli_;
            this.tbtnEmployee.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tbtnEmployee.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnEmployee.Margin = new System.Windows.Forms.Padding(5, 1, 0, 2);
            this.tbtnEmployee.Name = "tbtnEmployee";
            this.tbtnEmployee.Size = new System.Drawing.Size(85, 31);
            this.tbtnEmployee.Text = "员工信息";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 34);
            // 
            // tbtnExpress
            // 
            this.tbtnExpress.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold);
            this.tbtnExpress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.tbtnExpress.Image = global::Zicai.CaiNiaoPostStation.Properties.Resources.kuaidi;
            this.tbtnExpress.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tbtnExpress.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnExpress.Margin = new System.Windows.Forms.Padding(5, 1, 0, 2);
            this.tbtnExpress.Name = "tbtnExpress";
            this.tbtnExpress.Size = new System.Drawing.Size(85, 31);
            this.tbtnExpress.Text = "快递信息";
            // 
            // tbtnDistribute
            // 
            this.tbtnDistribute.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold);
            this.tbtnDistribute.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.tbtnDistribute.Image = global::Zicai.CaiNiaoPostStation.Properties.Resources.baoguopaisong;
            this.tbtnDistribute.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tbtnDistribute.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnDistribute.Margin = new System.Windows.Forms.Padding(5, 1, 0, 2);
            this.tbtnDistribute.Name = "tbtnDistribute";
            this.tbtnDistribute.Size = new System.Drawing.Size(85, 31);
            this.tbtnDistribute.Text = "派送管理";
            // 
            // tbtnSelfPick
            // 
            this.tbtnSelfPick.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold);
            this.tbtnSelfPick.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.tbtnSelfPick.Image = global::Zicai.CaiNiaoPostStation.Properties.Resources.zitigui;
            this.tbtnSelfPick.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tbtnSelfPick.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnSelfPick.Margin = new System.Windows.Forms.Padding(5, 1, 0, 2);
            this.tbtnSelfPick.Name = "tbtnSelfPick";
            this.tbtnSelfPick.Size = new System.Drawing.Size(85, 31);
            this.tbtnSelfPick.Text = "快递自提";
            // 
            // statusStrip1
            // 
            this.statusStrip1.AutoSize = false;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.lblLoginTime,
            this.toolStripStatusLabel3,
            this.lblAction,
            this.toolStripStatusLabel5,
            this.toolStripStatusLabel6,
            this.toolStripStatusLabel7,
            this.lblCopyright});
            this.statusStrip1.Location = new System.Drawing.Point(0, 713);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1351, 41);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.toolStripStatusLabel1.ForeColor = System.Drawing.Color.DimGray;
            this.toolStripStatusLabel1.Margin = new System.Windows.Forms.Padding(12, 3, 0, 2);
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(68, 36);
            this.toolStripStatusLabel1.Text = "登录时间：";
            // 
            // lblLoginTime
            // 
            this.lblLoginTime.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblLoginTime.ForeColor = System.Drawing.Color.Blue;
            this.lblLoginTime.Name = "lblLoginTime";
            this.lblLoginTime.Size = new System.Drawing.Size(126, 36);
            this.lblLoginTime.Text = "2024-10-15 10:30:23";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.toolStripStatusLabel3.ForeColor = System.Drawing.Color.DimGray;
            this.toolStripStatusLabel3.Margin = new System.Windows.Forms.Padding(10, 3, 0, 2);
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(68, 36);
            this.toolStripStatusLabel3.Text = "当前操作：";
            // 
            // lblAction
            // 
            this.lblAction.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblAction.ForeColor = System.Drawing.Color.DarkMagenta;
            this.lblAction.Name = "lblAction";
            this.lblAction.Size = new System.Drawing.Size(32, 36);
            this.lblAction.Text = "首页";
            // 
            // toolStripStatusLabel5
            // 
            this.toolStripStatusLabel5.Name = "toolStripStatusLabel5";
            this.toolStripStatusLabel5.Size = new System.Drawing.Size(0, 36);
            // 
            // toolStripStatusLabel6
            // 
            this.toolStripStatusLabel6.AutoSize = false;
            this.toolStripStatusLabel6.Name = "toolStripStatusLabel6";
            this.toolStripStatusLabel6.Size = new System.Drawing.Size(872, 36);
            this.toolStripStatusLabel6.Spring = true;
            // 
            // toolStripStatusLabel7
            // 
            this.toolStripStatusLabel7.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.toolStripStatusLabel7.ForeColor = System.Drawing.Color.DimGray;
            this.toolStripStatusLabel7.Name = "toolStripStatusLabel7";
            this.toolStripStatusLabel7.Size = new System.Drawing.Size(68, 36);
            this.toolStripStatusLabel7.Text = "系统版权：";
            // 
            // lblCopyright
            // 
            this.lblCopyright.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblCopyright.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.lblCopyright.Name = "lblCopyright";
            this.lblCopyright.Size = new System.Drawing.Size(80, 36);
            this.lblCopyright.Text = "紫菜网络所有";
            // 
            // tabPages
            // 
            this.tabPages.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabPages.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabPages.Location = new System.Drawing.Point(1, 146);
            this.tabPages.Name = "tabPages";
            this.tabPages.SelectedIndex = 0;
            this.tabPages.Size = new System.Drawing.Size(1348, 571);
            this.tabPages.TabIndex = 5;
            // 
            // picClose
            // 
            this.picClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picClose.Image = global::Zicai.CaiNiaoPostStation.Properties.Resources.close;
            this.picClose.Location = new System.Drawing.Point(1316, 143);
            this.picClose.Name = "picClose";
            this.picClose.Size = new System.Drawing.Size(25, 25);
            this.picClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picClose.TabIndex = 6;
            this.picClose.TabStop = false;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1351, 754);
            this.Controls.Add(this.picClose);
            this.Controls.Add(this.tabPages);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.cainiaoMenus);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMain";
            this.Text = "菜鸟驿站管理系统";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.cainiaoMenus.ResumeLayout(false);
            this.cainiaoMenus.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblLoginInfo;
        private System.Windows.Forms.MenuStrip cainiaoMenus;
        private System.Windows.Forms.ToolStripMenuItem 基础信息维护ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 站点信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tbtnSelfPick;
        private System.Windows.Forms.ToolStripButton tbtnStation;
        private System.Windows.Forms.ToolStripButton tbtnShelves;
        private System.Windows.Forms.ToolStripButton tbtnEmployee;
        private System.Windows.Forms.ToolStripButton tbtnExpress;
        private System.Windows.Forms.ToolStripButton tbtnDistribute;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel lblLoginTime;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel lblAction;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel5;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel6;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel7;
        private System.Windows.Forms.ToolStripStatusLabel lblCopyright;
        private System.Windows.Forms.TabControl tabPages;
        private System.Windows.Forms.PictureBox picClose;
    }
}