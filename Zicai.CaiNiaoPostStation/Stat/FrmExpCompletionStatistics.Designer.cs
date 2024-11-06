namespace Zicai.CaiNiaoPostStation.Stat
{
    partial class FrmExpCompletionStatistics
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chartExpStat = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblUnCompleteCount = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblHasCompleteCount = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbExpList = new System.Windows.Forms.GroupBox();
            this.dgvExpList = new System.Windows.Forms.DataGridView();
            this.btnStatistics = new System.Windows.Forms.Button();
            this.cboStations = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.colExpNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colExpRemark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStationName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPickWay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colExpState = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartExpStat)).BeginInit();
            this.gbExpList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExpList)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.chartExpStat);
            this.groupBox1.Controls.Add(this.lblUnCompleteCount);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblHasCompleteCount);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.ForeColor = System.Drawing.Color.Navy;
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.MinimumSize = new System.Drawing.Size(401, 668);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(401, 668);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "完成度统计";
            // 
            // chartExpStat
            // 
            this.chartExpStat.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chartExpStat.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.DiagonalRight;
            this.chartExpStat.BackSecondaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(197)))), ((int)(((byte)(222)))));
            this.chartExpStat.BorderSkin.BackColor = System.Drawing.Color.Transparent;
            this.chartExpStat.BorderSkin.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            this.chartExpStat.BorderSkin.PageColor = System.Drawing.Color.Transparent;
            this.chartExpStat.BorderSkin.SkinStyle = System.Windows.Forms.DataVisualization.Charting.BorderSkinStyle.Sunken;
            chartArea3.Area3DStyle.Enable3D = true;
            chartArea3.Area3DStyle.PointDepth = 60;
            chartArea3.BackColor = System.Drawing.Color.Transparent;
            chartArea3.Name = "ChartArea1";
            this.chartExpStat.ChartAreas.Add(chartArea3);
            legend3.Alignment = System.Drawing.StringAlignment.Center;
            legend3.BackColor = System.Drawing.Color.Transparent;
            legend3.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend3.Name = "Legend1";
            legend3.TitleBackColor = System.Drawing.Color.Transparent;
            this.chartExpStat.Legends.Add(legend3);
            this.chartExpStat.Location = new System.Drawing.Point(6, 102);
            this.chartExpStat.Name = "chartExpStat";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series3.LabelForeColor = System.Drawing.Color.BlanchedAlmond;
            series3.Legend = "Legend1";
            series3.Name = "ExlCompletionSeries";
            series3.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            series3.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Single;
            this.chartExpStat.Series.Add(series3);
            this.chartExpStat.Size = new System.Drawing.Size(389, 560);
            this.chartExpStat.TabIndex = 4;
            this.chartExpStat.Text = "chart1";
            // 
            // lblUnCompleteCount
            // 
            this.lblUnCompleteCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUnCompleteCount.AutoSize = true;
            this.lblUnCompleteCount.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblUnCompleteCount.ForeColor = System.Drawing.Color.DeepPink;
            this.lblUnCompleteCount.Location = new System.Drawing.Point(307, 50);
            this.lblUnCompleteCount.Name = "lblUnCompleteCount";
            this.lblUnCompleteCount.Size = new System.Drawing.Size(48, 26);
            this.lblUnCompleteCount.TabIndex = 3;
            this.lblUnCompleteCount.Text = "600";
            this.lblUnCompleteCount.Click += new System.EventHandler(this.lblUnCompleteCount_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(232, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "未完成";
            // 
            // lblHasCompleteCount
            // 
            this.lblHasCompleteCount.AutoSize = true;
            this.lblHasCompleteCount.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblHasCompleteCount.ForeColor = System.Drawing.Color.Green;
            this.lblHasCompleteCount.Location = new System.Drawing.Point(122, 50);
            this.lblHasCompleteCount.Name = "lblHasCompleteCount";
            this.lblHasCompleteCount.Size = new System.Drawing.Size(60, 26);
            this.lblHasCompleteCount.TabIndex = 1;
            this.lblHasCompleteCount.Text = "2000";
            this.lblHasCompleteCount.Click += new System.EventHandler(this.lblHasCompleCount_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(47, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "已完成";
            // 
            // gbExpList
            // 
            this.gbExpList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbExpList.Controls.Add(this.dgvExpList);
            this.gbExpList.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gbExpList.ForeColor = System.Drawing.Color.Navy;
            this.gbExpList.Location = new System.Drawing.Point(420, 63);
            this.gbExpList.Name = "gbExpList";
            this.gbExpList.Size = new System.Drawing.Size(890, 618);
            this.gbExpList.TabIndex = 1;
            this.gbExpList.TabStop = false;
            this.gbExpList.Text = "快递信息明细";
            // 
            // dgvExpList
            // 
            this.dgvExpList.AllowUserToAddRows = false;
            this.dgvExpList.AllowUserToDeleteRows = false;
            this.dgvExpList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvExpList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvExpList.BackgroundColor = System.Drawing.Color.White;
            this.dgvExpList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvExpList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(184)))), ((int)(((byte)(220)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvExpList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvExpList.ColumnHeadersHeight = 33;
            this.dgvExpList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvExpList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colExpNumber,
            this.colExpRemark,
            this.colStationName,
            this.colPickWay,
            this.colExpState});
            this.dgvExpList.EnableHeadersVisualStyles = false;
            this.dgvExpList.GridColor = System.Drawing.Color.LightSteelBlue;
            this.dgvExpList.Location = new System.Drawing.Point(6, 32);
            this.dgvExpList.MultiSelect = false;
            this.dgvExpList.Name = "dgvExpList";
            this.dgvExpList.RowHeadersWidth = 28;
            this.dgvExpList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            this.dgvExpList.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvExpList.RowTemplate.Height = 23;
            this.dgvExpList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvExpList.Size = new System.Drawing.Size(878, 580);
            this.dgvExpList.TabIndex = 43;
            // 
            // btnStatistics
            // 
            this.btnStatistics.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStatistics.BackColor = System.Drawing.Color.Teal;
            this.btnStatistics.FlatAppearance.BorderSize = 0;
            this.btnStatistics.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStatistics.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnStatistics.ForeColor = System.Drawing.Color.White;
            this.btnStatistics.Location = new System.Drawing.Point(1219, 26);
            this.btnStatistics.Name = "btnStatistics";
            this.btnStatistics.Size = new System.Drawing.Size(85, 31);
            this.btnStatistics.TabIndex = 34;
            this.btnStatistics.Text = "统计";
            this.btnStatistics.UseVisualStyleBackColor = false;
            this.btnStatistics.Click += new System.EventHandler(this.btnStatistics_Click);
            // 
            // cboStations
            // 
            this.cboStations.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboStations.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cboStations.FormattingEnabled = true;
            this.cboStations.Location = new System.Drawing.Point(955, 29);
            this.cboStations.Name = "cboStations";
            this.cboStations.Size = new System.Drawing.Size(203, 27);
            this.cboStations.TabIndex = 45;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label2.Location = new System.Drawing.Point(907, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 22);
            this.label2.TabIndex = 44;
            this.label2.Text = "站点";
            // 
            // colExpNumber
            // 
            this.colExpNumber.DataPropertyName = "ExpNumber";
            this.colExpNumber.FillWeight = 120F;
            this.colExpNumber.HeaderText = "快递单号";
            this.colExpNumber.Name = "colExpNumber";
            this.colExpNumber.ReadOnly = true;
            // 
            // colExpRemark
            // 
            this.colExpRemark.DataPropertyName = "ExpRemark";
            this.colExpRemark.FillWeight = 200F;
            this.colExpRemark.HeaderText = "快递描述";
            this.colExpRemark.Name = "colExpRemark";
            this.colExpRemark.ReadOnly = true;
            // 
            // colStationName
            // 
            this.colStationName.DataPropertyName = "StationName";
            this.colStationName.FillWeight = 150F;
            this.colStationName.HeaderText = "站点";
            this.colStationName.Name = "colStationName";
            this.colStationName.ReadOnly = true;
            this.colStationName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // colPickWay
            // 
            this.colPickWay.DataPropertyName = "PickWay";
            this.colPickWay.FillWeight = 80F;
            this.colPickWay.HeaderText = "取件方式";
            this.colPickWay.Name = "colPickWay";
            this.colPickWay.ReadOnly = true;
            // 
            // colExpState
            // 
            this.colExpState.DataPropertyName = "ExpState";
            this.colExpState.FillWeight = 80F;
            this.colExpState.HeaderText = "快递状态";
            this.colExpState.Name = "colExpState";
            this.colExpState.ReadOnly = true;
            // 
            // FrmExpCompletionStatistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(1322, 693);
            this.Controls.Add(this.cboStations);
            this.Controls.Add(this.btnStatistics);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gbExpList);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmExpCompletionStatistics";
            this.ShowIcon = false;
            this.Text = "快递完成度统计";
            this.Load += new System.EventHandler(this.FrmExpCompletionStatistics_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartExpStat)).EndInit();
            this.gbExpList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvExpList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblUnCompleteCount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblHasCompleteCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartExpStat;
        private System.Windows.Forms.GroupBox gbExpList;
        private System.Windows.Forms.DataGridView dgvExpList;
        private System.Windows.Forms.Button btnStatistics;
        private System.Windows.Forms.ComboBox cboStations;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colExpNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn colExpRemark;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStationName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPickWay;
        private System.Windows.Forms.DataGridViewTextBoxColumn colExpState;
    }
}