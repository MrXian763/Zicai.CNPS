namespace Zicai.CaiNiaoPostStation.Employee
{
    partial class FrmEmpTypeList
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
            this.chkShowDel = new System.Windows.Forms.CheckBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.dgvEmpTypeList = new System.Windows.Forms.DataGridView();
            this.label11 = new System.Windows.Forms.Label();
            this.colChk = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colEmpTypeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmpTypeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRemark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDel = new System.Windows.Forms.DataGridViewLinkColumn();
            this.colRecover = new System.Windows.Forms.DataGridViewLinkColumn();
            this.colRemove = new System.Windows.Forms.DataGridViewLinkColumn();
            this.lblErrorMsg = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpTypeList)).BeginInit();
            this.SuspendLayout();
            // 
            // chkShowDel
            // 
            this.chkShowDel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkShowDel.AutoSize = true;
            this.chkShowDel.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.chkShowDel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.chkShowDel.Location = new System.Drawing.Point(1260, 24);
            this.chkShowDel.Name = "chkShowDel";
            this.chkShowDel.Size = new System.Drawing.Size(70, 23);
            this.chkShowDel.TabIndex = 57;
            this.chkShowDel.Text = "已删除";
            this.chkShowDel.UseVisualStyleBackColor = true;
            this.chkShowDel.Click += new System.EventHandler(this.chkShowDel_CheckedChanged);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(1131, 19);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(85, 31);
            this.btnSave.TabIndex = 53;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dgvEmpTypeList
            // 
            this.dgvEmpTypeList.AllowUserToDeleteRows = false;
            this.dgvEmpTypeList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvEmpTypeList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEmpTypeList.BackgroundColor = System.Drawing.Color.White;
            this.dgvEmpTypeList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvEmpTypeList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEmpTypeList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvEmpTypeList.ColumnHeadersHeight = 33;
            this.dgvEmpTypeList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvEmpTypeList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colChk,
            this.colEmpTypeId,
            this.colEmpTypeName,
            this.colRemark,
            this.colDel,
            this.colRecover,
            this.colRemove});
            this.dgvEmpTypeList.EnableHeadersVisualStyles = false;
            this.dgvEmpTypeList.GridColor = System.Drawing.Color.LightSteelBlue;
            this.dgvEmpTypeList.Location = new System.Drawing.Point(12, 56);
            this.dgvEmpTypeList.MultiSelect = false;
            this.dgvEmpTypeList.Name = "dgvEmpTypeList";
            this.dgvEmpTypeList.RowHeadersWidth = 28;
            this.dgvEmpTypeList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            this.dgvEmpTypeList.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvEmpTypeList.RowTemplate.Height = 23;
            this.dgvEmpTypeList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmpTypeList.Size = new System.Drawing.Size(1327, 686);
            this.dgvEmpTypeList.TabIndex = 52;
            this.dgvEmpTypeList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmpTypeList_CellContentClick);
            this.dgvEmpTypeList.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmpTypeList_CellEndEdit);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label11.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label11.Location = new System.Drawing.Point(12, 31);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(122, 22);
            this.label11.TabIndex = 58;
            this.label11.Text = "员工类别列表：";
            // 
            // colChk
            // 
            this.colChk.FillWeight = 50F;
            this.colChk.HeaderText = "选择";
            this.colChk.Name = "colChk";
            // 
            // colEmpTypeId
            // 
            this.colEmpTypeId.DataPropertyName = "EmpTypeId";
            this.colEmpTypeId.HeaderText = "类别编号";
            this.colEmpTypeId.Name = "colEmpTypeId";
            this.colEmpTypeId.ReadOnly = true;
            // 
            // colEmpTypeName
            // 
            this.colEmpTypeName.DataPropertyName = "EmpTypeName";
            this.colEmpTypeName.FillWeight = 180F;
            this.colEmpTypeName.HeaderText = "类别名称";
            this.colEmpTypeName.Name = "colEmpTypeName";
            // 
            // colRemark
            // 
            this.colRemark.DataPropertyName = "Remark";
            this.colRemark.FillWeight = 250F;
            this.colRemark.HeaderText = "类别描述";
            this.colRemark.Name = "colRemark";
            // 
            // colDel
            // 
            this.colDel.FillWeight = 60F;
            this.colDel.HeaderText = "删除";
            this.colDel.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.colDel.Name = "colDel";
            this.colDel.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colDel.Text = "删除";
            this.colDel.TrackVisitedState = false;
            this.colDel.UseColumnTextForLinkValue = true;
            // 
            // colRecover
            // 
            this.colRecover.ActiveLinkColor = System.Drawing.Color.YellowGreen;
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
            this.colRemove.ActiveLinkColor = System.Drawing.Color.Gray;
            this.colRemove.FillWeight = 60F;
            this.colRemove.HeaderText = "移除";
            this.colRemove.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.colRemove.Name = "colRemove";
            this.colRemove.Text = "移除";
            this.colRemove.TrackVisitedState = false;
            this.colRemove.UseColumnTextForLinkValue = true;
            // 
            // lblErrorMsg
            // 
            this.lblErrorMsg.AutoSize = true;
            this.lblErrorMsg.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblErrorMsg.ForeColor = System.Drawing.Color.Red;
            this.lblErrorMsg.Location = new System.Drawing.Point(972, 26);
            this.lblErrorMsg.Name = "lblErrorMsg";
            this.lblErrorMsg.Size = new System.Drawing.Size(122, 21);
            this.lblErrorMsg.TabIndex = 59;
            this.lblErrorMsg.Text = "请输入员工类别";
            this.lblErrorMsg.Visible = false;
            // 
            // FrmEmpTypeList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1351, 754);
            this.Controls.Add(this.lblErrorMsg);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.chkShowDel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dgvEmpTypeList);
            this.Name = "FrmEmpTypeList";
            this.ShowIcon = false;
            this.Text = "员工类别维护";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmEmpTypeList_FormClosing);
            this.Load += new System.EventHandler(this.FrmEmpTypeList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpTypeList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkShowDel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView dgvEmpTypeList;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colChk;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmpTypeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmpTypeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRemark;
        private System.Windows.Forms.DataGridViewLinkColumn colDel;
        private System.Windows.Forms.DataGridViewLinkColumn colRecover;
        private System.Windows.Forms.DataGridViewLinkColumn colRemove;
        private System.Windows.Forms.Label lblErrorMsg;
    }
}