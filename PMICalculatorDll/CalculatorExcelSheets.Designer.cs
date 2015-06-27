namespace PMICalculatorDll
{
    partial class CalculatorExcelSheets
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
            this.lstExcelSheets = new System.Windows.Forms.ListBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstExcelSheets
            // 
            this.lstExcelSheets.FormattingEnabled = true;
            this.lstExcelSheets.Location = new System.Drawing.Point(12, 36);
            this.lstExcelSheets.Name = "lstExcelSheets";
            this.lstExcelSheets.Size = new System.Drawing.Size(315, 329);
            this.lstExcelSheets.TabIndex = 0;
            this.lstExcelSheets.DoubleClick += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(12, 371);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(319, 42);
            this.btnCalculate.TabIndex = 10;
            this.btnCalculate.Text = "打开选中的计算表";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "改动Excel计算表中黄色的区域，粗体为结果";
            // 
            // CalculatorExcelSheets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 425);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lstExcelSheets);
            this.Name = "CalculatorExcelSheets";
            this.Text = "CalculatorExcelSheets";
            this.Load += new System.EventHandler(this.CalculatorExcelSheets_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstExcelSheets;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label label1;
    }
}