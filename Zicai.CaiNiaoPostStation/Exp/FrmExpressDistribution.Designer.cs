namespace Zicai.CaiNiaoPostStation.Exp
{
    partial class FrmExpressDistribution
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
            this.btnAssign = new System.Windows.Forms.Button();
            this.btnPickup = new System.Windows.Forms.Button();
            this.btnQuery = new System.Windows.Forms.Button();
            this.cboStates = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtKeyWords = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtRecPhone = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvDisExpressList = new System.Windows.Forms.DataGridView();
            this.uPager1 = new Zicai.CaiNiaoPostStation.UControls.UPager();
            this.colChk = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colStationName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colExpNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colReceiver = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colReceiverPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRecAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colExpState = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDisPerson = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDisPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDisTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSignTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisExpressList)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAssign
            // 
            this.btnAssign.BackColor = System.Drawing.Color.Green;
            this.btnAssign.FlatAppearance.BorderSize = 0;
            this.btnAssign.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAssign.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnAssign.ForeColor = System.Drawing.Color.White;
            this.btnAssign.Location = new System.Drawing.Point(12, 34);
            this.btnAssign.Name = "btnAssign";
            this.btnAssign.Size = new System.Drawing.Size(85, 31);
            this.btnAssign.TabIndex = 31;
            this.btnAssign.Text = "派送安排";
            this.btnAssign.UseVisualStyleBackColor = false;
            // 
            // btnPickup
            // 
            this.btnPickup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnPickup.FlatAppearance.BorderSize = 0;
            this.btnPickup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPickup.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnPickup.ForeColor = System.Drawing.Color.White;
            this.btnPickup.Location = new System.Drawing.Point(131, 34);
            this.btnPickup.Name = "btnPickup";
            this.btnPickup.Size = new System.Drawing.Size(85, 31);
            this.btnPickup.TabIndex = 32;
            this.btnPickup.Text = "签收";
            this.btnPickup.UseVisualStyleBackColor = false;
            // 
            // btnQuery
            // 
            this.btnQuery.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnQuery.BackColor = System.Drawing.Color.Teal;
            this.btnQuery.FlatAppearance.BorderSize = 0;
            this.btnQuery.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuery.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnQuery.ForeColor = System.Drawing.Color.White;
            this.btnQuery.Location = new System.Drawing.Point(1254, 33);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(85, 31);
            this.btnQuery.TabIndex = 33;
            this.btnQuery.Text = "查询";
            this.btnQuery.UseVisualStyleBackColor = false;
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
            this.cboStates.Location = new System.Drawing.Point(1070, 37);
            this.cboStates.Name = "cboStates";
            this.cboStates.Size = new System.Drawing.Size(130, 27);
            this.cboStates.TabIndex = 39;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label4.Location = new System.Drawing.Point(990, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 22);
            this.label4.TabIndex = 38;
            this.label4.Text = "快递状态";
            // 
            // txtKeyWords
            // 
            this.txtKeyWords.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtKeyWords.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtKeyWords.Location = new System.Drawing.Point(384, 37);
            this.txtKeyWords.Name = "txtKeyWords";
            this.txtKeyWords.Size = new System.Drawing.Size(223, 26);
            this.txtKeyWords.TabIndex = 35;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label10.Location = new System.Drawing.Point(288, 38);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 22);
            this.label10.TabIndex = 34;
            this.label10.Text = "查询关键词";
            // 
            // txtRecPhone
            // 
            this.txtRecPhone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRecPhone.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtRecPhone.Location = new System.Drawing.Point(744, 38);
            this.txtRecPhone.Name = "txtRecPhone";
            this.txtRecPhone.Size = new System.Drawing.Size(202, 26);
            this.txtRecPhone.TabIndex = 41;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Location = new System.Drawing.Point(648, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 22);
            this.label1.TabIndex = 40;
            this.label1.Text = "收件人电话";
            // 
            // dgvDisExpressList
            // 
            this.dgvDisExpressList.AllowUserToAddRows = false;
            this.dgvDisExpressList.AllowUserToDeleteRows = false;
            this.dgvDisExpressList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDisExpressList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDisExpressList.BackgroundColor = System.Drawing.Color.White;
            this.dgvDisExpressList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDisExpressList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDisExpressList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDisExpressList.ColumnHeadersHeight = 33;
            this.dgvDisExpressList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvDisExpressList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colChk,
            this.colStationName,
            this.colExpNo,
            this.colReceiver,
            this.colReceiverPhone,
            this.colRecAddress,
            this.colExpState,
            this.colDisPerson,
            this.colDisPhone,
            this.colDisTime,
            this.colSignTime});
            this.dgvDisExpressList.EnableHeadersVisualStyles = false;
            this.dgvDisExpressList.GridColor = System.Drawing.Color.LightSteelBlue;
            this.dgvDisExpressList.Location = new System.Drawing.Point(12, 87);
            this.dgvDisExpressList.MultiSelect = false;
            this.dgvDisExpressList.Name = "dgvDisExpressList";
            this.dgvDisExpressList.RowHeadersWidth = 28;
            this.dgvDisExpressList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            this.dgvDisExpressList.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDisExpressList.RowTemplate.Height = 23;
            this.dgvDisExpressList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDisExpressList.Size = new System.Drawing.Size(1327, 607);
            this.dgvDisExpressList.TabIndex = 56;
            // 
            // uPager1
            // 
            this.uPager1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uPager1.BackColor = System.Drawing.Color.White;
            this.uPager1.CurrentPage = 1;
            this.uPager1.Location = new System.Drawing.Point(12, 692);
            this.uPager1.Name = "uPager1";
            this.uPager1.PageSize = 10;
            this.uPager1.Record = 0;
            this.uPager1.Size = new System.Drawing.Size(1327, 50);
            this.uPager1.StartIndex = 1;
            this.uPager1.TabIndex = 57;
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
            // colExpState
            // 
            this.colExpState.FillWeight = 80F;
            this.colExpState.HeaderText = "快递状态";
            this.colExpState.Name = "colExpState";
            this.colExpState.ReadOnly = true;
            // 
            // colDisPerson
            // 
            this.colDisPerson.FillWeight = 80F;
            this.colDisPerson.HeaderText = "派送人";
            this.colDisPerson.Name = "colDisPerson";
            this.colDisPerson.ReadOnly = true;
            // 
            // colDisPhone
            // 
            this.colDisPhone.HeaderText = "派送员电话";
            this.colDisPhone.Name = "colDisPhone";
            this.colDisPhone.ReadOnly = true;
            // 
            // colDisTime
            // 
            this.colDisTime.FillWeight = 120F;
            this.colDisTime.HeaderText = "派送时间";
            this.colDisTime.Name = "colDisTime";
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
            // FrmExpressDistribution
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(182)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(1351, 754);
            this.Controls.Add(this.uPager1);
            this.Controls.Add(this.dgvDisExpressList);
            this.Controls.Add(this.txtRecPhone);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboStates);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtKeyWords);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnQuery);
            this.Controls.Add(this.btnPickup);
            this.Controls.Add(this.btnAssign);
            this.Name = "FrmExpressDistribution";
            this.ShowIcon = false;
            this.Text = "快递派送管理";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisExpressList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAssign;
        private System.Windows.Forms.Button btnPickup;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.ComboBox cboStates;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtKeyWords;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtRecPhone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvDisExpressList;
        private UControls.UPager uPager1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colChk;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStationName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colExpNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colReceiver;
        private System.Windows.Forms.DataGridViewTextBoxColumn colReceiverPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRecAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn colExpState;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDisPerson;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDisPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDisTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSignTime;
    }
}