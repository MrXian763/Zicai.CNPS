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
            this.dgvSelfExpressList = new System.Windows.Forms.DataGridView();
            this.label12 = new System.Windows.Forms.Label();
            this.cboStations = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.uPager1 = new Zicai.CaiNiaoPostStation.UControls.UPager();
            this.colChk = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colStationName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colExpNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colReceiver = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colReceiverPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colReceiveAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPickingCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colShelfName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIsPickUp = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colPickingTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPickUp = new System.Windows.Forms.DataGridViewLinkColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelfExpressList)).BeginInit();
            this.SuspendLayout();
            // 
            // txtRecPhone
            // 
            this.txtRecPhone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRecPhone.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtRecPhone.Location = new System.Drawing.Point(563, 34);
            this.txtRecPhone.Name = "txtRecPhone";
            this.txtRecPhone.Size = new System.Drawing.Size(186, 26);
            this.txtRecPhone.TabIndex = 48;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Location = new System.Drawing.Point(467, 35);
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
            "全部",
            "已入库",
            "派送中",
            "已签收"});
            this.cboStates.Location = new System.Drawing.Point(1049, 33);
            this.cboStates.Name = "cboStates";
            this.cboStates.Size = new System.Drawing.Size(130, 27);
            this.cboStates.TabIndex = 46;
            this.cboStates.Click += new System.EventHandler(this.cboStates_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label4.Location = new System.Drawing.Point(969, 35);
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
            this.txtKeyWords.Size = new System.Drawing.Size(206, 26);
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
            this.btnQuery.Location = new System.Drawing.Point(1233, 29);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(85, 31);
            this.btnQuery.TabIndex = 42;
            this.btnQuery.Text = "查询";
            this.btnQuery.UseVisualStyleBackColor = false;
            this.btnQuery.Click += new System.EventHandler(this.btnFind_Click);
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
            this.colExpNumber,
            this.colReceiver,
            this.colReceiverPhone,
            this.colReceiveAddress,
            this.colPickingCode,
            this.colShelfName,
            this.colIsPickUp,
            this.colPickingTime,
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
            this.dgvSelfExpressList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSelfExpressList_CellContentClick);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label12.ForeColor = System.Drawing.Color.DarkBlue;
            this.label12.Location = new System.Drawing.Point(8, 65);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(122, 22);
            this.label12.TabIndex = 60;
            this.label12.Text = "快递自提列表：";
            // 
            // cboStations
            // 
            this.cboStations.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboStations.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cboStations.FormattingEnabled = true;
            this.cboStations.Location = new System.Drawing.Point(826, 32);
            this.cboStations.Name = "cboStations";
            this.cboStations.Size = new System.Drawing.Size(130, 27);
            this.cboStations.TabIndex = 62;
            this.cboStations.Click += new System.EventHandler(this.cboStations_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label2.Location = new System.Drawing.Point(778, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 22);
            this.label2.TabIndex = 61;
            this.label2.Text = "站点";
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
            this.uPager1.PageChanged += new Zicai.CaiNiaoPostStation.UControls.UPager.PageHandler(this.uPager1_PageChanged);
            // 
            // colChk
            // 
            this.colChk.FillWeight = 50F;
            this.colChk.HeaderText = "选择";
            this.colChk.Name = "colChk";
            // 
            // colStationName
            // 
            this.colStationName.DataPropertyName = "StationName";
            this.colStationName.FillWeight = 150F;
            this.colStationName.HeaderText = "所在站点";
            this.colStationName.Name = "colStationName";
            this.colStationName.ReadOnly = true;
            // 
            // colExpNumber
            // 
            this.colExpNumber.DataPropertyName = "ExpNumber";
            this.colExpNumber.FillWeight = 120F;
            this.colExpNumber.HeaderText = "快递单号";
            this.colExpNumber.Name = "colExpNumber";
            this.colExpNumber.ReadOnly = true;
            // 
            // colReceiver
            // 
            this.colReceiver.DataPropertyName = "Receiver";
            this.colReceiver.FillWeight = 80F;
            this.colReceiver.HeaderText = "收件人";
            this.colReceiver.Name = "colReceiver";
            this.colReceiver.ReadOnly = true;
            // 
            // colReceiverPhone
            // 
            this.colReceiverPhone.DataPropertyName = "ReceiverPhone";
            this.colReceiverPhone.HeaderText = "收件人电话";
            this.colReceiverPhone.Name = "colReceiverPhone";
            this.colReceiverPhone.ReadOnly = true;
            // 
            // colReceiveAddress
            // 
            this.colReceiveAddress.DataPropertyName = "ReceiveAddress";
            this.colReceiveAddress.FillWeight = 200F;
            this.colReceiveAddress.HeaderText = "收件地址";
            this.colReceiveAddress.Name = "colReceiveAddress";
            this.colReceiveAddress.ReadOnly = true;
            // 
            // colPickingCode
            // 
            this.colPickingCode.DataPropertyName = "PickingCode";
            this.colPickingCode.FillWeight = 80F;
            this.colPickingCode.HeaderText = "取件码";
            this.colPickingCode.Name = "colPickingCode";
            this.colPickingCode.ReadOnly = true;
            // 
            // colShelfName
            // 
            this.colShelfName.DataPropertyName = "ShelfName";
            this.colShelfName.HeaderText = "货架";
            this.colShelfName.Name = "colShelfName";
            this.colShelfName.ReadOnly = true;
            // 
            // colIsPickUp
            // 
            this.colIsPickUp.DataPropertyName = "IsPickUp";
            this.colIsPickUp.FillWeight = 80F;
            this.colIsPickUp.HeaderText = "已取件";
            this.colIsPickUp.Name = "colIsPickUp";
            this.colIsPickUp.ReadOnly = true;
            this.colIsPickUp.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colIsPickUp.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // colPickingTime
            // 
            this.colPickingTime.DataPropertyName = "PickingTime";
            this.colPickingTime.FillWeight = 120F;
            this.colPickingTime.HeaderText = "签收时间";
            this.colPickingTime.Name = "colPickingTime";
            this.colPickingTime.ReadOnly = true;
            this.colPickingTime.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colPickingTime.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
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
            this.Controls.Add(this.cboStations);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label12);
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
            this.Load += new System.EventHandler(this.FrmExpSelfPickList_Load);
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
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cboStations;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colChk;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStationName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colExpNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn colReceiver;
        private System.Windows.Forms.DataGridViewTextBoxColumn colReceiverPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn colReceiveAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPickingCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colShelfName;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colIsPickUp;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPickingTime;
        private System.Windows.Forms.DataGridViewLinkColumn colPickUp;
    }
}