namespace Zicai.CaiNiaoPostStation.Exp
{
    partial class FrmExpressList
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
            this.gbExpCondition = new System.Windows.Forms.GroupBox();
            this.btnQuery = new System.Windows.Forms.Button();
            this.cboPickWays = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cboStates = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cboStations = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtReceiverPhone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtReveiverName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtExpNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtKeyWords = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tvExpTypes = new System.Windows.Forms.TreeView();
            this.btnEdit = new System.Windows.Forms.Button();
            this.chkShowDel = new System.Windows.Forms.CheckBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnRecover = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgvExpressList = new System.Windows.Forms.DataGridView();
            this.uPager1 = new Zicai.CaiNiaoPostStation.UControls.UPager();
            this.colChk = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colExpId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colExpNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colExpType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colReceiver = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colReceiverPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStationName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSenderPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colExpState = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEnterTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPickWay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbExpCondition.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExpressList)).BeginInit();
            this.SuspendLayout();
            // 
            // gbExpCondition
            // 
            this.gbExpCondition.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbExpCondition.Controls.Add(this.btnQuery);
            this.gbExpCondition.Controls.Add(this.cboPickWays);
            this.gbExpCondition.Controls.Add(this.label5);
            this.gbExpCondition.Controls.Add(this.cboStates);
            this.gbExpCondition.Controls.Add(this.label4);
            this.gbExpCondition.Controls.Add(this.cboStations);
            this.gbExpCondition.Controls.Add(this.label7);
            this.gbExpCondition.Controls.Add(this.txtReceiverPhone);
            this.gbExpCondition.Controls.Add(this.label3);
            this.gbExpCondition.Controls.Add(this.txtReveiverName);
            this.gbExpCondition.Controls.Add(this.label2);
            this.gbExpCondition.Controls.Add(this.txtExpNo);
            this.gbExpCondition.Controls.Add(this.label1);
            this.gbExpCondition.Controls.Add(this.txtKeyWords);
            this.gbExpCondition.Controls.Add(this.label10);
            this.gbExpCondition.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gbExpCondition.ForeColor = System.Drawing.Color.Blue;
            this.gbExpCondition.Location = new System.Drawing.Point(12, 12);
            this.gbExpCondition.Name = "gbExpCondition";
            this.gbExpCondition.Size = new System.Drawing.Size(1452, 112);
            this.gbExpCondition.TabIndex = 0;
            this.gbExpCondition.TabStop = false;
            this.gbExpCondition.Text = "查询条件";
            // 
            // btnQuery
            // 
            this.btnQuery.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnQuery.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnQuery.FlatAppearance.BorderSize = 0;
            this.btnQuery.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuery.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnQuery.ForeColor = System.Drawing.Color.White;
            this.btnQuery.Location = new System.Drawing.Point(1339, 45);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(85, 31);
            this.btnQuery.TabIndex = 35;
            this.btnQuery.Text = "查询";
            this.btnQuery.UseVisualStyleBackColor = false;
            this.btnQuery.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // cboPickWays
            // 
            this.cboPickWays.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cboPickWays.FormattingEnabled = true;
            this.cboPickWays.Items.AddRange(new object[] {
            "全部",
            "派送",
            "自提"});
            this.cboPickWays.Location = new System.Drawing.Point(1109, 22);
            this.cboPickWays.Name = "cboPickWays";
            this.cboPickWays.Size = new System.Drawing.Size(166, 27);
            this.cboPickWays.TabIndex = 34;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label5.Location = new System.Drawing.Point(1029, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 22);
            this.label5.TabIndex = 33;
            this.label5.Text = "取件方式";
            // 
            // cboStates
            // 
            this.cboStates.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cboStates.FormattingEnabled = true;
            this.cboStates.Items.AddRange(new object[] {
            "全部",
            "已入库",
            "派送中",
            "未取件",
            "已签收"});
            this.cboStates.Location = new System.Drawing.Point(805, 22);
            this.cboStates.Name = "cboStates";
            this.cboStates.Size = new System.Drawing.Size(166, 27);
            this.cboStates.TabIndex = 32;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label4.Location = new System.Drawing.Point(725, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 22);
            this.label4.TabIndex = 31;
            this.label4.Text = "快递状态";
            // 
            // cboStations
            // 
            this.cboStations.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cboStations.FormattingEnabled = true;
            this.cboStations.Location = new System.Drawing.Point(472, 22);
            this.cboStations.Name = "cboStations";
            this.cboStations.Size = new System.Drawing.Size(166, 27);
            this.cboStations.TabIndex = 30;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label7.Location = new System.Drawing.Point(424, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 22);
            this.label7.TabIndex = 29;
            this.label7.Text = "站点";
            // 
            // txtReceiverPhone
            // 
            this.txtReceiverPhone.Location = new System.Drawing.Point(805, 66);
            this.txtReceiverPhone.Name = "txtReceiverPhone";
            this.txtReceiverPhone.Size = new System.Drawing.Size(166, 26);
            this.txtReceiverPhone.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label3.Location = new System.Drawing.Point(709, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 22);
            this.label3.TabIndex = 27;
            this.label3.Text = "收件人电话";
            // 
            // txtReveiverName
            // 
            this.txtReveiverName.Location = new System.Drawing.Point(472, 66);
            this.txtReveiverName.Name = "txtReveiverName";
            this.txtReveiverName.Size = new System.Drawing.Size(166, 26);
            this.txtReveiverName.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label2.Location = new System.Drawing.Point(408, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 22);
            this.label2.TabIndex = 25;
            this.label2.Text = "收件人";
            // 
            // txtExpNo
            // 
            this.txtExpNo.Location = new System.Drawing.Point(129, 66);
            this.txtExpNo.Name = "txtExpNo";
            this.txtExpNo.Size = new System.Drawing.Size(223, 26);
            this.txtExpNo.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Location = new System.Drawing.Point(49, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 22);
            this.label1.TabIndex = 23;
            this.label1.Text = "快递单号";
            // 
            // txtKeyWords
            // 
            this.txtKeyWords.Location = new System.Drawing.Point(129, 23);
            this.txtKeyWords.Name = "txtKeyWords";
            this.txtKeyWords.Size = new System.Drawing.Size(223, 26);
            this.txtKeyWords.TabIndex = 22;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label10.Location = new System.Drawing.Point(33, 24);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 22);
            this.label10.TabIndex = 21;
            this.label10.Text = "查询关键词";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label11.ForeColor = System.Drawing.Color.DarkBlue;
            this.label11.Location = new System.Drawing.Point(12, 148);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 22);
            this.label11.TabIndex = 22;
            this.label11.Text = "类别：";
            // 
            // tvExpTypes
            // 
            this.tvExpTypes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tvExpTypes.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tvExpTypes.Location = new System.Drawing.Point(8, 173);
            this.tvExpTypes.Name = "tvExpTypes";
            this.tvExpTypes.Size = new System.Drawing.Size(197, 628);
            this.tvExpTypes.TabIndex = 23;
            this.tvExpTypes.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvExpTypes_AfterSelect);
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdit.BackColor = System.Drawing.Color.Teal;
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(954, 136);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(85, 31);
            this.btnEdit.TabIndex = 53;
            this.btnEdit.Text = "修改";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // chkShowDel
            // 
            this.chkShowDel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkShowDel.AutoSize = true;
            this.chkShowDel.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.chkShowDel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.chkShowDel.Location = new System.Drawing.Point(1392, 138);
            this.chkShowDel.Name = "chkShowDel";
            this.chkShowDel.Size = new System.Drawing.Size(70, 23);
            this.chkShowDel.TabIndex = 52;
            this.chkShowDel.Text = "已删除";
            this.chkShowDel.UseVisualStyleBackColor = true;
            this.chkShowDel.CheckedChanged += new System.EventHandler(this.chkShowDel_CheckedChanged);
            // 
            // btnRemove
            // 
            this.btnRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnRemove.FlatAppearance.BorderSize = 0;
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnRemove.ForeColor = System.Drawing.Color.White;
            this.btnRemove.Location = new System.Drawing.Point(1279, 136);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(85, 31);
            this.btnRemove.TabIndex = 51;
            this.btnRemove.Text = "移除";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnRecover
            // 
            this.btnRecover.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRecover.BackColor = System.Drawing.Color.Blue;
            this.btnRecover.FlatAppearance.BorderSize = 0;
            this.btnRecover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecover.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnRecover.ForeColor = System.Drawing.Color.White;
            this.btnRecover.Location = new System.Drawing.Point(1170, 136);
            this.btnRecover.Name = "btnRecover";
            this.btnRecover.Size = new System.Drawing.Size(85, 31);
            this.btnRecover.TabIndex = 50;
            this.btnRecover.Text = "恢复";
            this.btnRecover.UseVisualStyleBackColor = false;
            this.btnRecover.Click += new System.EventHandler(this.btnRecover_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(1062, 136);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(85, 31);
            this.btnDelete.TabIndex = 49;
            this.btnDelete.Text = "删除";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.MediumVioletRed;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(231, 136);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(85, 31);
            this.btnAdd.TabIndex = 54;
            this.btnAdd.Text = "快递录入";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgvExpressList
            // 
            this.dgvExpressList.AllowUserToAddRows = false;
            this.dgvExpressList.AllowUserToDeleteRows = false;
            this.dgvExpressList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvExpressList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvExpressList.BackgroundColor = System.Drawing.Color.White;
            this.dgvExpressList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvExpressList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvExpressList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvExpressList.ColumnHeadersHeight = 33;
            this.dgvExpressList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvExpressList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colChk,
            this.colExpId,
            this.colExpNumber,
            this.colExpType,
            this.colReceiver,
            this.colReceiverPhone,
            this.colStationName,
            this.colSender,
            this.colSenderPhone,
            this.colExpState,
            this.colEnterTime,
            this.colPickWay});
            this.dgvExpressList.EnableHeadersVisualStyles = false;
            this.dgvExpressList.GridColor = System.Drawing.Color.LightSteelBlue;
            this.dgvExpressList.Location = new System.Drawing.Point(211, 173);
            this.dgvExpressList.MultiSelect = false;
            this.dgvExpressList.Name = "dgvExpressList";
            this.dgvExpressList.RowHeadersWidth = 28;
            this.dgvExpressList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            this.dgvExpressList.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvExpressList.RowTemplate.Height = 23;
            this.dgvExpressList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvExpressList.Size = new System.Drawing.Size(1253, 580);
            this.dgvExpressList.TabIndex = 55;
            this.dgvExpressList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvExpressList_CellContentClick);
            // 
            // uPager1
            // 
            this.uPager1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uPager1.BackColor = System.Drawing.Color.White;
            this.uPager1.CurrentPage = 1;
            this.uPager1.Location = new System.Drawing.Point(211, 751);
            this.uPager1.Name = "uPager1";
            this.uPager1.PageSize = 10;
            this.uPager1.Record = 0;
            this.uPager1.Size = new System.Drawing.Size(1253, 50);
            this.uPager1.StartIndex = 1;
            this.uPager1.TabIndex = 56;
            this.uPager1.PageChanged += new Zicai.CaiNiaoPostStation.UControls.UPager.PageHandler(this.uPager1_PageChanged);
            // 
            // colChk
            // 
            this.colChk.FillWeight = 50F;
            this.colChk.HeaderText = "选择";
            this.colChk.Name = "colChk";
            // 
            // colExpId
            // 
            this.colExpId.DataPropertyName = "ExpId";
            this.colExpId.FillWeight = 80F;
            this.colExpId.HeaderText = "快递编号";
            this.colExpId.Name = "colExpId";
            this.colExpId.ReadOnly = true;
            // 
            // colExpNumber
            // 
            this.colExpNumber.DataPropertyName = "ExpNumber";
            this.colExpNumber.FillWeight = 120F;
            this.colExpNumber.HeaderText = "快递单号";
            this.colExpNumber.Name = "colExpNumber";
            this.colExpNumber.ReadOnly = true;
            // 
            // colExpType
            // 
            this.colExpType.DataPropertyName = "ExpType";
            this.colExpType.FillWeight = 150F;
            this.colExpType.HeaderText = "快递类别";
            this.colExpType.Name = "colExpType";
            this.colExpType.ReadOnly = true;
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
            this.colReceiverPhone.HeaderText = "收件电话";
            this.colReceiverPhone.Name = "colReceiverPhone";
            this.colReceiverPhone.ReadOnly = true;
            // 
            // colStationName
            // 
            this.colStationName.DataPropertyName = "StationName";
            this.colStationName.FillWeight = 150F;
            this.colStationName.HeaderText = "站点";
            this.colStationName.Name = "colStationName";
            this.colStationName.ReadOnly = true;
            // 
            // colSender
            // 
            this.colSender.DataPropertyName = "Sender";
            this.colSender.FillWeight = 80F;
            this.colSender.HeaderText = "寄件人";
            this.colSender.Name = "colSender";
            this.colSender.ReadOnly = true;
            // 
            // colSenderPhone
            // 
            this.colSenderPhone.DataPropertyName = "SenderPhone";
            this.colSenderPhone.HeaderText = "寄件电话";
            this.colSenderPhone.Name = "colSenderPhone";
            this.colSenderPhone.ReadOnly = true;
            // 
            // colExpState
            // 
            this.colExpState.DataPropertyName = "ExpState";
            this.colExpState.FillWeight = 80F;
            this.colExpState.HeaderText = "快递状态";
            this.colExpState.Name = "colExpState";
            this.colExpState.ReadOnly = true;
            // 
            // colEnterTime
            // 
            this.colEnterTime.DataPropertyName = "EnterTime";
            this.colEnterTime.FillWeight = 150F;
            this.colEnterTime.HeaderText = "录入时间";
            this.colEnterTime.Name = "colEnterTime";
            this.colEnterTime.ReadOnly = true;
            this.colEnterTime.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colEnterTime.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colPickWay
            // 
            this.colPickWay.DataPropertyName = "PickWay";
            this.colPickWay.FillWeight = 80F;
            this.colPickWay.HeaderText = "取件方式";
            this.colPickWay.Name = "colPickWay";
            // 
            // FrmExpressList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(162)))), ((int)(((byte)(223)))));
            this.ClientSize = new System.Drawing.Size(1476, 809);
            this.Controls.Add(this.uPager1);
            this.Controls.Add(this.dgvExpressList);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.chkShowDel);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnRecover);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.tvExpTypes);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.gbExpCondition);
            this.Name = "FrmExpressList";
            this.ShowIcon = false;
            this.Text = "快递信息管理";
            this.Load += new System.EventHandler(this.FrmExpressList_Load);
            this.gbExpCondition.ResumeLayout(false);
            this.gbExpCondition.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExpressList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbExpCondition;
        private System.Windows.Forms.TextBox txtReceiverPhone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtReveiverName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtExpNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtKeyWords;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cboPickWays;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboStates;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboStations;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TreeView tvExpTypes;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.CheckBox chkShowDel;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnRecover;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dgvExpressList;
        private UControls.UPager uPager1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colChk;
        private System.Windows.Forms.DataGridViewTextBoxColumn colExpId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colExpNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn colExpType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colReceiver;
        private System.Windows.Forms.DataGridViewTextBoxColumn colReceiverPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStationName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSender;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSenderPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn colExpState;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEnterTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPickWay;
    }
}