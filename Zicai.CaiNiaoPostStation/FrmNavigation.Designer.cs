namespace Zicai.CaiNiaoPostStation
{
    partial class FrmNavigation
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
            this.uArrow1 = new Zicai.CaiNiaoPostStation.UControls.UArrow();
            this.SuspendLayout();
            // 
            // uArrow1
            // 
            this.uArrow1.ArrowColor = System.Drawing.Color.LightSteelBlue;
            this.uArrow1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.uArrow1.BorderColor = System.Drawing.Color.Aqua;
            this.uArrow1.Direction = Zicai.CaiNiaoPostStation.UControls.UArrow.ArrowDirection.Down;
            this.uArrow1.Location = new System.Drawing.Point(295, 89);
            this.uArrow1.Name = "uArrow1";
            this.uArrow1.Size = new System.Drawing.Size(53, 96);
            this.uArrow1.TabIndex = 0;
            // 
            // FrmNavigation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 683);
            this.Controls.Add(this.uArrow1);
            this.Name = "FrmNavigation";
            this.Text = "FrmNavigation";
            this.ResumeLayout(false);

        }

        #endregion

        private UControls.UArrow uArrow1;
    }
}