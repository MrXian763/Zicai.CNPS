namespace Zicai.CaiNiaoPostStation.BM
{
    partial class FrmShelvesList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.txtRemark = new System.Windows.Forms.TextBox();
            this.txtShelfName = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtShelfNo = new System.Windows.Forms.TextBox();
            this.lblErrMsg = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboStations = new System.Windows.Forms.ComboBox();
            this.uPager1 = new Zicai.CaiNiaoPostStation.UControls.UPager();
            this.chkShowDel = new System.Windows.Forms.CheckBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnRecover = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnQuery = new System.Windows.Forms.Button();
            this.dgvShelvesList = new System.Windows.Forms.DataGridView();
            this.label11 = new System.Windows.Forms.Label();
            this.txtKeyWords = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.colChk = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colShelfId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colShelfNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colShelfName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStation = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEdit = new System.Windows.Forms.DataGridViewLinkColumn();
            this.colDel = new System.Windows.Forms.DataGridViewLinkColumn();
            this.colRecover = new System.Windows.Forms.DataGridViewLinkColumn();
            this.colRemove = new System.Windows.Forms.DataGridViewLinkColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShelvesList)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.cboStations);
            this.groupBox1.Controls.Add(this.btnReset);
            this.groupBox1.Controls.Add(this.btnOk);
            this.groupBox1.Controls.Add(this.txtRemark);
            this.groupBox1.Controls.Add(this.txtShelfName);
            this.groupBox1.Controls.Add(this.txtAddress);
            this.groupBox1.Controls.Add(this.txtShelfNo);
            this.groupBox1.Controls.Add(this.lblErrMsg);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.ForeColor = System.Drawing.Color.Blue;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1345, 120);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "货架信息";
            // 
            // btnReset
            // 
            this.btnReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReset.BackColor = System.Drawing.Color.DarkGray;
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(1194, 29);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(85, 39);
            this.btnReset.TabIndex = 18;
            this.btnReset.Text = "重置";
            this.btnReset.UseVisualStyleBackColor = false;
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOk.BackColor = System.Drawing.Color.Orange;
            this.btnOk.FlatAppearance.BorderSize = 0;
            this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOk.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnOk.ForeColor = System.Drawing.Color.White;
            this.btnOk.Location = new System.Drawing.Point(1078, 29);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(85, 39);
            this.btnOk.TabIndex = 17;
            this.btnOk.Text = "添加";
            this.btnOk.UseVisualStyleBackColor = false;
            // 
            // txtRemark
            // 
            this.txtRemark.Location = new System.Drawing.Point(352, 66);
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(657, 29);
            this.txtRemark.TabIndex = 12;
            // 
            // txtShelfName
            // 
            this.txtShelfName.Location = new System.Drawing.Point(101, 66);
            this.txtShelfName.Name = "txtShelfName";
            this.txtShelfName.Size = new System.Drawing.Size(153, 29);
            this.txtShelfName.TabIndex = 11;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(745, 25);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(264, 29);
            this.txtAddress.TabIndex = 10;
            // 
            // txtShelfNo
            // 
            this.txtShelfNo.Location = new System.Drawing.Point(101, 25);
            this.txtShelfNo.Name = "txtShelfNo";
            this.txtShelfNo.Size = new System.Drawing.Size(153, 29);
            this.txtShelfNo.TabIndex = 1;
            // 
            // lblErrMsg
            // 
            this.lblErrMsg.AutoSize = true;
            this.lblErrMsg.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblErrMsg.ForeColor = System.Drawing.Color.Red;
            this.lblErrMsg.Location = new System.Drawing.Point(1115, 83);
            this.lblErrMsg.Name = "lblErrMsg";
            this.lblErrMsg.Size = new System.Drawing.Size(122, 21);
            this.lblErrMsg.TabIndex = 8;
            this.lblErrMsg.Text = "请设置货架编码";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(272, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 22);
            this.label5.TabIndex = 4;
            this.label5.Text = "货架描述";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(20, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "货架名称";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(665, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "货架位置";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(272, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "所属站点";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(21, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "货架编码";
            // 
            // cboStations
            // 
            this.cboStations.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cboStations.FormattingEnabled = true;
            this.cboStations.Location = new System.Drawing.Point(353, 29);
            this.cboStations.Name = "cboStations";
            this.cboStations.Size = new System.Drawing.Size(296, 27);
            this.cboStations.TabIndex = 19;
            // 
            // uPager1
            // 
            this.uPager1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uPager1.BackColor = System.Drawing.Color.White;
            this.uPager1.CurrentPage = 1;
            this.uPager1.Location = new System.Drawing.Point(12, 696);
            this.uPager1.Name = "uPager1";
            this.uPager1.PageSize = 10;
            this.uPager1.Record = 0;
            this.uPager1.Size = new System.Drawing.Size(1327, 47);
            this.uPager1.StartIndex = 1;
            this.uPager1.TabIndex = 38;
            // 
            // chkShowDel
            // 
            this.chkShowDel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkShowDel.AutoSize = true;
            this.chkShowDel.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.chkShowDel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.chkShowDel.Location = new System.Drawing.Point(1255, 129);
            this.chkShowDel.Name = "chkShowDel";
            this.chkShowDel.Size = new System.Drawing.Size(70, 23);
            this.chkShowDel.TabIndex = 37;
            this.chkShowDel.Text = "已删除";
            this.chkShowDel.UseVisualStyleBackColor = true;
            // 
            // btnRemove
            // 
            this.btnRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnRemove.FlatAppearance.BorderSize = 0;
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnRemove.ForeColor = System.Drawing.Color.White;
            this.btnRemove.Location = new System.Drawing.Point(1059, 127);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(85, 31);
            this.btnRemove.TabIndex = 36;
            this.btnRemove.Text = "移除";
            this.btnRemove.UseVisualStyleBackColor = false;
            // 
            // btnRecover
            // 
            this.btnRecover.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRecover.BackColor = System.Drawing.Color.Blue;
            this.btnRecover.FlatAppearance.BorderSize = 0;
            this.btnRecover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecover.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnRecover.ForeColor = System.Drawing.Color.White;
            this.btnRecover.Location = new System.Drawing.Point(943, 127);
            this.btnRecover.Name = "btnRecover";
            this.btnRecover.Size = new System.Drawing.Size(85, 31);
            this.btnRecover.TabIndex = 35;
            this.btnRecover.Text = "恢复";
            this.btnRecover.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(827, 127);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(85, 31);
            this.btnDelete.TabIndex = 34;
            this.btnDelete.Text = "删除";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnQuery
            // 
            this.btnQuery.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnQuery.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnQuery.FlatAppearance.BorderSize = 0;
            this.btnQuery.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuery.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnQuery.ForeColor = System.Drawing.Color.White;
            this.btnQuery.Location = new System.Drawing.Point(717, 127);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(85, 31);
            this.btnQuery.TabIndex = 33;
            this.btnQuery.Text = "查询";
            this.btnQuery.UseVisualStyleBackColor = false;
            // 
            // dgvShelvesList
            // 
            this.dgvShelvesList.AllowUserToAddRows = false;
            this.dgvShelvesList.AllowUserToDeleteRows = false;
            this.dgvShelvesList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvShelvesList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvShelvesList.BackgroundColor = System.Drawing.Color.White;
            this.dgvShelvesList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvShelvesList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvShelvesList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvShelvesList.ColumnHeadersHeight = 33;
            this.dgvShelvesList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvShelvesList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colChk,
            this.colShelfId,
            this.colShelfNo,
            this.colShelfName,
            this.colStation,
            this.colAddress,
            this.colEdit,
            this.colDel,
            this.colRecover,
            this.colRemove});
            this.dgvShelvesList.EnableHeadersVisualStyles = false;
            this.dgvShelvesList.GridColor = System.Drawing.Color.LightSteelBlue;
            this.dgvShelvesList.Location = new System.Drawing.Point(12, 169);
            this.dgvShelvesList.MultiSelect = false;
            this.dgvShelvesList.Name = "dgvShelvesList";
            this.dgvShelvesList.RowHeadersWidth = 28;
            this.dgvShelvesList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            this.dgvShelvesList.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvShelvesList.RowTemplate.Height = 23;
            this.dgvShelvesList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvShelvesList.Size = new System.Drawing.Size(1327, 528);
            this.dgvShelvesList.TabIndex = 32;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label11.ForeColor = System.Drawing.Color.DarkBlue;
            this.label11.Location = new System.Drawing.Point(14, 144);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(90, 22);
            this.label11.TabIndex = 31;
            this.label11.Text = "货架列表：";
            // 
            // txtKeyWords
            // 
            this.txtKeyWords.Location = new System.Drawing.Point(236, 132);
            this.txtKeyWords.Name = "txtKeyWords";
            this.txtKeyWords.Size = new System.Drawing.Size(429, 21);
            this.txtKeyWords.TabIndex = 30;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.ForeColor = System.Drawing.Color.DimGray;
            this.label10.Location = new System.Drawing.Point(140, 131);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 22);
            this.label10.TabIndex = 29;
            this.label10.Text = "查询关键词";
            // 
            // colChk
            // 
            this.colChk.FillWeight = 50F;
            this.colChk.HeaderText = "选择";
            this.colChk.Name = "colChk";
            // 
            // colShelfId
            // 
            this.colShelfId.HeaderText = "货架编号";
            this.colShelfId.Name = "colShelfId";
            this.colShelfId.ReadOnly = true;
            // 
            // colShelfNo
            // 
            this.colShelfNo.HeaderText = "货架编码";
            this.colShelfNo.Name = "colShelfNo";
            this.colShelfNo.ReadOnly = true;
            // 
            // colShelfName
            // 
            this.colShelfName.FillWeight = 200F;
            this.colShelfName.HeaderText = "货架名称";
            this.colShelfName.Name = "colShelfName";
            this.colShelfName.ReadOnly = true;
            // 
            // colStation
            // 
            this.colStation.FillWeight = 150F;
            this.colStation.HeaderText = "站点";
            this.colStation.Name = "colStation";
            this.colStation.ReadOnly = true;
            this.colStation.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colStation.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // colAddress
            // 
            this.colAddress.FillWeight = 150F;
            this.colAddress.HeaderText = "货架位置";
            this.colAddress.Name = "colAddress";
            this.colAddress.ReadOnly = true;
            // 
            // colEdit
            // 
            this.colEdit.FillWeight = 60F;
            this.colEdit.HeaderText = "修改";
            this.colEdit.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.colEdit.Name = "colEdit";
            this.colEdit.Text = "修改";
            this.colEdit.TrackVisitedState = false;
            this.colEdit.UseColumnTextForLinkValue = true;
            // 
            // colDel
            // 
            this.colDel.FillWeight = 60F;
            this.colDel.HeaderText = "删除";
            this.colDel.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.colDel.Name = "colDel";
            this.colDel.Text = "删除";
            this.colDel.TrackVisitedState = false;
            this.colDel.UseColumnTextForLinkValue = true;
            // 
            // colRecover
            // 
            this.colRecover.FillWeight = 60F;
            this.colRecover.HeaderText = "恢复";
            this.colRecover.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.colRecover.Name = "colRecover";
            this.colRecover.Text = "恢复";
            this.colRecover.TrackVisitedState = false;
            this.colRecover.UseColumnTextForLinkValue = true;
            // 
            // colRemove
            // 
            this.colRemove.FillWeight = 60F;
            this.colRemove.HeaderText = "移除";
            this.colRemove.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.colRemove.Name = "colRemove";
            this.colRemove.Text = "移除";
            this.colRemove.TrackVisitedState = false;
            this.colRemove.UseColumnTextForLinkValue = true;
            // 
            // FrmShelvesList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1351, 754);
            this.Controls.Add(this.uPager1);
            this.Controls.Add(this.chkShowDel);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnRecover);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnQuery);
            this.Controls.Add(this.dgvShelvesList);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtKeyWords);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmShelvesList";
            this.ShowIcon = false;
            this.Text = "货架管理";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShelvesList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.TextBox txtRemark;
        private System.Windows.Forms.TextBox txtShelfName;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtShelfNo;
        private System.Windows.Forms.Label lblErrMsg;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboStations;
        private UControls.UPager uPager1;
        private System.Windows.Forms.CheckBox chkShowDel;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnRecover;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.DataGridView dgvShelvesList;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtKeyWords;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colChk;
        private System.Windows.Forms.DataGridViewTextBoxColumn colShelfId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colShelfNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colShelfName;
        private System.Windows.Forms.DataGridViewComboBoxColumn colStation;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAddress;
        private System.Windows.Forms.DataGridViewLinkColumn colEdit;
        private System.Windows.Forms.DataGridViewLinkColumn colDel;
        private System.Windows.Forms.DataGridViewLinkColumn colRecover;
        private System.Windows.Forms.DataGridViewLinkColumn colRemove;
    }
}