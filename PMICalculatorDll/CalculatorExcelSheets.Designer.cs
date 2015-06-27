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
            this.SuspendLayout();
            // 
            // lstExcelSheets
            // 
            this.lstExcelSheets.FormattingEnabled = true;
            this.lstExcelSheets.Location = new System.Drawing.Point(13, 13);
            this.lstExcelSheets.Name = "lstExcelSheets";
            this.lstExcelSheets.Size = new System.Drawing.Size(315, 355);
            this.lstExcelSheets.TabIndex = 0;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(12, 374);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(319, 42);
            this.btnCalculate.TabIndex = 10;
            this.btnCalculate.Text = "打开选中的计算表";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // CalculatorExcelSheets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 425);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lstExcelSheets);
            this.Name = "CalculatorExcelSheets";
            this.Text = "CalculatorExcelSheets";
            this.Load += new System.EventHandler(this.CalculatorExcelSheets_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstExcelSheets;
        private System.Windows.Forms.Button btnCalculate;
    }
}