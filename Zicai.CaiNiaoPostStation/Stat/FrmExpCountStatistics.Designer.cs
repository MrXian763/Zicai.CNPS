namespace Zicai.CaiNiaoPostStation.Stat
{
    partial class FrmExpCountStatistics
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series13 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series14 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series15 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnstatistics = new System.Windows.Forms.Button();
            this.cboMonths = new System.Windows.Forms.ComboBox();
            this.cboYears = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rbtnMonth = new System.Windows.Forms.RadioButton();
            this.rbtnWeek = new System.Windows.Forms.RadioButton();
            this.rbtnDay = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.chartExpStat = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartExpStat)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnstatistics);
            this.groupBox1.Controls.Add(this.cboMonths);
            this.groupBox1.Controls.Add(this.cboYears);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.rbtnMonth);
            this.groupBox1.Controls.Add(this.rbtnWeek);
            this.groupBox1.Controls.Add(this.rbtnDay);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1298, 106);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btnstatistics
            // 
            this.btnstatistics.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnstatistics.BackColor = System.Drawing.Color.Blue;
            this.btnstatistics.FlatAppearance.BorderSize = 0;
            this.btnstatistics.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnstatistics.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnstatistics.ForeColor = System.Drawing.Color.White;
            this.btnstatistics.Location = new System.Drawing.Point(1113, 38);
            this.btnstatistics.Name = "btnstatistics";
            this.btnstatistics.Size = new System.Drawing.Size(92, 37);
            this.btnstatistics.TabIndex = 51;
            this.btnstatistics.Text = "统计";
            this.btnstatistics.UseVisualStyleBackColor = false;
            this.btnstatistics.Click += new System.EventHandler(this.btnStatistics_Click);
            // 
            // cboMonths
            // 
            this.cboMonths.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cboMonths.FormattingEnabled = true;
            this.cboMonths.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12"});
            this.cboMonths.Location = new System.Drawing.Point(865, 42);
            this.cboMonths.Name = "cboMonths";
            this.cboMonths.Size = new System.Drawing.Size(121, 30);
            this.cboMonths.TabIndex = 6;
            // 
            // cboYears
            // 
            this.cboYears.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cboYears.FormattingEnabled = true;
            this.cboYears.Location = new System.Drawing.Point(728, 42);
            this.cboYears.Name = "cboYears";
            this.cboYears.Size = new System.Drawing.Size(121, 30);
            this.cboYears.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(656, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 26);
            this.label2.TabIndex = 4;
            this.label2.Text = "年/月：";
            // 
            // rbtnMonth
            // 
            this.rbtnMonth.AutoSize = true;
            this.rbtnMonth.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rbtnMonth.ForeColor = System.Drawing.Color.White;
            this.rbtnMonth.Location = new System.Drawing.Point(402, 40);
            this.rbtnMonth.Name = "rbtnMonth";
            this.rbtnMonth.Size = new System.Drawing.Size(106, 30);
            this.rbtnMonth.TabIndex = 3;
            this.rbtnMonth.Tag = "Month";
            this.rbtnMonth.Text = "按月统计";
            this.rbtnMonth.UseVisualStyleBackColor = true;
            this.rbtnMonth.CheckedChanged += new System.EventHandler(this.rbtn_CheckedChanged);
            // 
            // rbtnWeek
            // 
            this.rbtnWeek.AutoSize = true;
            this.rbtnWeek.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rbtnWeek.ForeColor = System.Drawing.Color.White;
            this.rbtnWeek.Location = new System.Drawing.Point(274, 40);
            this.rbtnWeek.Name = "rbtnWeek";
            this.rbtnWeek.Size = new System.Drawing.Size(106, 30);
            this.rbtnWeek.TabIndex = 2;
            this.rbtnWeek.Tag = "Week";
            this.rbtnWeek.Text = "按周统计";
            this.rbtnWeek.UseVisualStyleBackColor = true;
            this.rbtnWeek.CheckedChanged += new System.EventHandler(this.rbtn_CheckedChanged);
            // 
            // rbtnDay
            // 
            this.rbtnDay.AutoSize = true;
            this.rbtnDay.Checked = true;
            this.rbtnDay.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rbtnDay.ForeColor = System.Drawing.Color.White;
            this.rbtnDay.Location = new System.Drawing.Point(148, 40);
            this.rbtnDay.Name = "rbtnDay";
            this.rbtnDay.Size = new System.Drawing.Size(106, 30);
            this.rbtnDay.TabIndex = 1;
            this.rbtnDay.TabStop = true;
            this.rbtnDay.Tag = "Day";
            this.rbtnDay.Text = "按日统计";
            this.rbtnDay.UseVisualStyleBackColor = true;
            this.rbtnDay.CheckedChanged += new System.EventHandler(this.rbtn_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(35, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "统计类别：";
            // 
            // chartExpStat
            // 
            this.chartExpStat.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chartExpStat.BackColor = System.Drawing.Color.WhiteSmoke;
            this.chartExpStat.BorderSkin.PageColor = System.Drawing.Color.Transparent;
            this.chartExpStat.BorderSkin.SkinStyle = System.Windows.Forms.DataVisualization.Charting.BorderSkinStyle.Sunken;
            chartArea5.AxisX.InterlacedColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(225)))), ((int)(((byte)(247)))));
            chartArea5.AxisX.IsInterlaced = true;
            chartArea5.AxisX.LabelStyle.ForeColor = System.Drawing.Color.DeepSkyBlue;
            chartArea5.AxisX.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            chartArea5.AxisX.LineWidth = 2;
            chartArea5.AxisX.MajorGrid.LineColor = System.Drawing.Color.DeepSkyBlue;
            chartArea5.AxisX.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea5.AxisX.MajorTickMark.LineColor = System.Drawing.Color.Blue;
            chartArea5.AxisX.Title = "日期";
            chartArea5.AxisX.TitleAlignment = System.Drawing.StringAlignment.Far;
            chartArea5.AxisX.TitleFont = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea5.AxisX.TitleForeColor = System.Drawing.Color.DeepSkyBlue;
            chartArea5.AxisY.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea5.AxisY.LabelStyle.ForeColor = System.Drawing.Color.LightSeaGreen;
            chartArea5.AxisY.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            chartArea5.AxisY.LineWidth = 2;
            chartArea5.AxisY.MajorGrid.LineColor = System.Drawing.Color.Fuchsia;
            chartArea5.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea5.AxisY.Title = "快递数量";
            chartArea5.AxisY.TitleAlignment = System.Drawing.StringAlignment.Far;
            chartArea5.AxisY.TitleFont = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            chartArea5.AxisY.TitleForeColor = System.Drawing.Color.LightSeaGreen;
            chartArea5.BackColor = System.Drawing.Color.White;
            chartArea5.Name = "ChartArea1";
            this.chartExpStat.ChartAreas.Add(chartArea5);
            legend5.Alignment = System.Drawing.StringAlignment.Far;
            legend5.BackColor = System.Drawing.Color.Transparent;
            legend5.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend5.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            legend5.IsTextAutoFit = false;
            legend5.Name = "Legend1";
            legend5.Title = "快递数量";
            legend5.TitleFont = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            legend5.TitleForeColor = System.Drawing.Color.RoyalBlue;
            this.chartExpStat.Legends.Add(legend5);
            this.chartExpStat.Location = new System.Drawing.Point(12, 124);
            this.chartExpStat.Name = "chartExpStat";
            series13.ChartArea = "ChartArea1";
            series13.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series13.Legend = "Legend1";
            series13.LegendText = "快递总数";
            series13.Name = "expCountSeries";
            series14.ChartArea = "ChartArea1";
            series14.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series14.Legend = "Legend1";
            series14.LegendText = "已完成数";
            series14.Name = "expHasCountSeries";
            series15.ChartArea = "ChartArea1";
            series15.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series15.Legend = "Legend1";
            series15.LegendText = "未完成数";
            series15.Name = "expUnCompleteSeries";
            this.chartExpStat.Series.Add(series13);
            this.chartExpStat.Series.Add(series14);
            this.chartExpStat.Series.Add(series15);
            this.chartExpStat.Size = new System.Drawing.Size(1298, 557);
            this.chartExpStat.TabIndex = 1;
            this.chartExpStat.Text = "chart1";
            // 
            // FrmExpCountStatistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(1322, 693);
            this.Controls.Add(this.chartExpStat);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmExpCountStatistics";
            this.ShowIcon = false;
            this.Text = "快递数目统计";
            this.Load += new System.EventHandler(this.FrmExpCountStatistics_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartExpStat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtnDay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbtnMonth;
        private System.Windows.Forms.RadioButton rbtnWeek;
        private System.Windows.Forms.ComboBox cboYears;
        private System.Windows.Forms.ComboBox cboMonths;
        private System.Windows.Forms.Button btnstatistics;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartExpStat;
    }
}