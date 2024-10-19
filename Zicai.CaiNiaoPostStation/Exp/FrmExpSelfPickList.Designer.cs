namespace Zicai.CaiNiaoPostStation.Exp
{
    partial class FrmExpSelfPickList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtRecPhone = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboStates = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtKeyWords = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnQuery = new System.Windows.Forms.Button();
            this.uPager1 = new Zicai.CaiNiaoPostStation.UControls.UPager();
            this.dgvSelfExpressList = new System.Windows.Forms.DataGridView();
            this.colChk = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colStationName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colExpNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colReceiver = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colReceiverPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRecAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPickingCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStoreAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIsPickUp = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colSignTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPickUp = new System.Windows.Forms.DataGridViewLinkColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelfExpressList)).BeginInit();
            this.SuspendLayout();
            // 
            // txtRecPhone
            // 
            this.txtRecPhone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRecPhone.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtRecPhone.Location = new System.Drawing.Point(574, 34);
            this.txtRecPhone.Name = "txtRecPhone";
            this.txtRecPhone.Size = new System.Drawing.Size(202, 26);
            this.txtRecPhone.TabIndex = 48;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Location = new System.Drawing.Point(478, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 22);
            this.label1.TabIndex = 47;
            this.label1.Text = "收件人电话";
            // 
            // cboStates
            // 
            this.cboStates.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboStates.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cboStates.FormattingEnabled = true;
            this.cboStates.Items.AddRange(new object[] {
            "已入库",
            "派送中",
            "已签收"});
            this.cboStates.Location = new System.Drawing.Point(900, 33);
            this.cboStates.Name = "cboStates";
            this.cboStates.Size = new System.Drawing.Size(130, 27);
            this.cboStates.TabIndex = 46;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label4.Location = new System.Drawing.Point(820, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 22);
            this.label4.TabIndex = 45;
            this.label4.Text = "快递状态";
            // 
            // txtKeyWords
            // 
            this.txtKeyWords.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtKeyWords.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtKeyWords.Location = new System.Drawing.Point(214, 33);
            this.txtKeyWords.Name = "txtKeyWords";
            this.txtKeyWords.Size = new System.Drawing.Size(223, 26);
            this.txtKeyWords.TabIndex = 44;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label10.Location = new System.Drawing.Point(118, 34);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 22);
            this.label10.TabIndex = 43;
            this.label10.Text = "查询关键词";
            // 
            // btnQuery
            // 
            this.btnQuery.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnQuery.BackColor = System.Drawing.Color.Teal;
            this.btnQuery.FlatAppearance.BorderSize = 0;
            this.btnQuery.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuery.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnQuery.ForeColor = System.Drawing.Color.White;
            this.btnQuery.Location = new System.Drawing.Point(1084, 29);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(85, 31);
            this.btnQuery.TabIndex = 42;
            this.btnQuery.Text = "查询";
            this.btnQuery.UseVisualStyleBackColor = false;
            // 
            // uPager1
            // 
            this.uPager1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uPager1.BackColor = System.Drawing.Color.White;
            this.uPager1.CurrentPage = 1;
            this.uPager1.Location = new System.Drawing.Point(12, 695);
            this.uPager1.Name = "uPager1";
            this.uPager1.PageSize = 10;
            this.uPager1.Record = 0;
            this.uPager1.Size = new System.Drawing.Size(1327, 50);
            this.uPager1.StartIndex = 1;
            this.uPager1.TabIndex = 59;
            // 
            // dgvSelfExpressList
            // 
            this.dgvSelfExpressList.AllowUserToAddRows = false;
            this.dgvSelfExpressList.AllowUserToDeleteRows = false;
            this.dgvSelfExpressList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSelfExpressList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSelfExpressList.BackgroundColor = System.Drawing.Color.White;
            this.dgvSelfExpressList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSelfExpressList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSelfExpressList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSelfExpressList.ColumnHeadersHeight = 33;
            this.dgvSelfExpressList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvSelfExpressList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colChk,
            this.colStationName,
            this.colExpNo,
            this.colReceiver,
            this.colReceiverPhone,
            this.colRecAddress,
            this.colPickingCode,
            this.colStoreAddress,
            this.colIsPickUp,
            this.colSignTime,
            this.colPickUp});
            this.dgvSelfExpressList.EnableHeadersVisualStyles = false;
            this.dgvSelfExpressList.GridColor = System.Drawing.Color.LightSteelBlue;
            this.dgvSelfExpressList.Location = new System.Drawing.Point(12, 90);
            this.dgvSelfExpressList.MultiSelect = false;
            this.dgvSelfExpressList.Name = "dgvSelfExpressList";
            this.dgvSelfExpressList.RowHeadersWidth = 28;
            this.dgvSelfExpressList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            this.dgvSelfExpressList.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSelfExpressList.RowTemplate.Height = 23;
            this.dgvSelfExpressList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSelfExpressList.Size = new System.Drawing.Size(1327, 607);
            this.dgvSelfExpressList.TabIndex = 58;
            // 
            // colChk
            // 
            this.colChk.FillWeight = 50F;
            this.colChk.HeaderText = "选择";
            this.colChk.Name = "colChk";
            // 
            // colStationName
            // 
            this.colStationName.FillWeight = 150F;
            this.colStationName.HeaderText = "所在站点";
            this.colStationName.Name = "colStationName";
            this.colStationName.ReadOnly = true;
            // 
            // colExpNo
            // 
            this.colExpNo.FillWeight = 120F;
            this.colExpNo.HeaderText = "快递单号";
            this.colExpNo.Name = "colExpNo";
            this.colExpNo.ReadOnly = true;
            // 
            // colReceiver
            // 
            this.colReceiver.FillWeight = 80F;
            this.colReceiver.HeaderText = "收件人";
            this.colReceiver.Name = "colReceiver";
            this.colReceiver.ReadOnly = true;
            // 
            // colReceiverPhone
            // 
            this.colReceiverPhone.HeaderText = "收件人电话";
            this.colReceiverPhone.Name = "colReceiverPhone";
            this.colReceiverPhone.ReadOnly = true;
            // 
            // colRecAddress
            // 
            this.colRecAddress.FillWeight = 200F;
            this.colRecAddress.HeaderText = "收件地址";
            this.colRecAddress.Name = "colRecAddress";
            this.colRecAddress.ReadOnly = true;
            // 
            // colPickingCode
            // 
            this.colPickingCode.FillWeight = 80F;
            this.colPickingCode.HeaderText = "取件码";
            this.colPickingCode.Name = "colPickingCode";
            this.colPickingCode.ReadOnly = true;
            // 
            // colStoreAddress
            // 
            this.colStoreAddress.FillWeight = 200F;
            this.colStoreAddress.HeaderText = "暂存地址";
            this.colStoreAddress.Name = "colStoreAddress";
            this.colStoreAddress.ReadOnly = true;
            // 
            // colIsPickUp
            // 
            this.colIsPickUp.FillWeight = 80F;
            this.colIsPickUp.HeaderText = "已取件";
            this.colIsPickUp.Name = "colIsPickUp";
            this.colIsPickUp.ReadOnly = true;
            this.colIsPickUp.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colIsPickUp.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // colSignTime
            // 
            this.colSignTime.FillWeight = 120F;
            this.colSignTime.HeaderText = "签收时间";
            this.colSignTime.Name = "colSignTime";
            this.colSignTime.ReadOnly = true;
            this.colSignTime.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colSignTime.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colPickUp
            // 
            this.colPickUp.FillWeight = 80F;
            this.colPickUp.HeaderText = "取件";
            this.colPickUp.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.colPickUp.LinkColor = System.Drawing.Color.SlateBlue;
            this.colPickUp.Name = "colPickUp";
            this.colPickUp.Text = "取件";
            this.colPickUp.TrackVisitedState = false;
            this.colPickUp.UseColumnTextForLinkValue = true;
            // 
            // FrmExpSelfPickList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(142)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(1351, 754);
            this.Controls.Add(this.uPager1);
            this.Controls.Add(this.dgvSelfExpressList);
            this.Controls.Add(this.txtRecPhone);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboStates);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtKeyWords);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnQuery);
            this.Name = "FrmExpSelfPickList";
            this.ShowIcon = false;
            this.Text = "快递自提列表";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelfExpressList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtRecPhone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboStates;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtKeyWords;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnQuery;
        private UControls.UPager uPager1;
        private System.Windows.Forms.DataGridView dgvSelfExpressList;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colChk;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStationName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colExpNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colReceiver;
        private System.Windows.Forms.DataGridViewTextBoxColumn colReceiverPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRecAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPickingCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStoreAddress;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colIsPickUp;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSignTime;
        private System.Windows.Forms.DataGridViewLinkColumn colPickUp;
    }
}