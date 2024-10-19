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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblHasCompleteCount = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblUnCompleteCount = new System.Windows.Forms.Label();
            this.chartExpStat = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.gbExpList = new System.Windows.Forms.GroupBox();
            this.dgvExpList = new System.Windows.Forms.DataGridView();
            this.colExpNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            chartArea1.Area3DStyle.Enable3D = true;
            chartArea1.Area3DStyle.PointDepth = 60;
            chartArea1.BackColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.chartExpStat.ChartAreas.Add(chartArea1);
            legend1.Alignment = System.Drawing.StringAlignment.Center;
            legend1.BackColor = System.Drawing.Color.Transparent;
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend1.Name = "Legend1";
            legend1.TitleBackColor = System.Drawing.Color.Transparent;
            this.chartExpStat.Legends.Add(legend1);
            this.chartExpStat.Location = new System.Drawing.Point(6, 102);
            this.chartExpStat.Name = "chartExpStat";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.LabelForeColor = System.Drawing.Color.BlanchedAlmond;
            series1.Legend = "Legend1";
            series1.Name = "ExlCompletionSeries";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Single;
            this.chartExpStat.Series.Add(series1);
            this.chartExpStat.Size = new System.Drawing.Size(389, 560);
            this.chartExpStat.TabIndex = 4;
            this.chartExpStat.Text = "chart1";
            // 
            // gbExpList
            // 
            this.gbExpList.Controls.Add(this.dgvExpList);
            this.gbExpList.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gbExpList.ForeColor = System.Drawing.Color.Navy;
            this.gbExpList.Location = new System.Drawing.Point(420, 13);
            this.gbExpList.Name = "gbExpList";
            this.gbExpList.Size = new System.Drawing.Size(890, 668);
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(184)))), ((int)(((byte)(220)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvExpList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvExpList.ColumnHeadersHeight = 33;
            this.dgvExpList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvExpList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colExpNo,
            this.colExpRemark,
            this.colStationName,
            this.colPickWay,
            this.colExpState});
            this.dgvExpList.EnableHeadersVisualStyles = false;
            this.dgvExpList.GridColor = System.Drawing.Color.LightSteelBlue;
            this.dgvExpList.Location = new System.Drawing.Point(6, 32);
            this.dgvExpList.MultiSelect = false;
            this.dgvExpList.Name = "dgvExpList";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvExpList.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvExpList.RowHeadersWidth = 28;
            this.dgvExpList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            this.dgvExpList.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvExpList.RowTemplate.Height = 23;
            this.dgvExpList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvExpList.Size = new System.Drawing.Size(878, 630);
            this.dgvExpList.TabIndex = 43;
            // 
            // colExpNo
            // 
            this.colExpNo.FillWeight = 120F;
            this.colExpNo.HeaderText = "快递单号";
            this.colExpNo.Name = "colExpNo";
            this.colExpNo.ReadOnly = true;
            // 
            // colExpRemark
            // 
            this.colExpRemark.FillWeight = 200F;
            this.colExpRemark.HeaderText = "快递描述";
            this.colExpRemark.Name = "colExpRemark";
            this.colExpRemark.ReadOnly = true;
            // 
            // colStationName
            // 
            this.colStationName.FillWeight = 150F;
            this.colStationName.HeaderText = "站点";
            this.colStationName.Name = "colStationName";
            this.colStationName.ReadOnly = true;
            this.colStationName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // colPickWay
            // 
            this.colPickWay.FillWeight = 80F;
            this.colPickWay.HeaderText = "取件方式";
            this.colPickWay.Name = "colPickWay";
            this.colPickWay.ReadOnly = true;
            // 
            // colExpState
            // 
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
            this.Controls.Add(this.gbExpList);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmExpCompletionStatistics";
            this.ShowIcon = false;
            this.Text = "快递完成度统计";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartExpStat)).EndInit();
            this.gbExpList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvExpList)).EndInit();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.DataGridViewTextBoxColumn colExpNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colExpRemark;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStationName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPickWay;
        private System.Windows.Forms.DataGridViewTextBoxColumn colExpState;
    }
}