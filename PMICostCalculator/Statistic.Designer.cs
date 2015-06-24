namespace PMICostCalculator
{
    partial class Statistic
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
            this.txtStatisticData = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtStatisticData
            // 
            this.txtStatisticData.BackColor = System.Drawing.Color.White;
            this.txtStatisticData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStatisticData.Location = new System.Drawing.Point(12, 12);
            this.txtStatisticData.Multiline = true;
            this.txtStatisticData.Name = "txtStatisticData";
            this.txtStatisticData.ReadOnly = true;
            this.txtStatisticData.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtStatisticData.Size = new System.Drawing.Size(536, 292);
            this.txtStatisticData.TabIndex = 0;
            // 
            // Statistic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 337);
            this.Controls.Add(this.txtStatisticData);
            this.Name = "Statistic";
            this.Text = "Statistic";
            this.Load += new System.EventHandler(this.Statistic_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtStatisticData;
    }
}