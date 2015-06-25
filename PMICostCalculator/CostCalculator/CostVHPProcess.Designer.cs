namespace PMICostCalculator
{
    partial class CostVHPProcess
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCalcNumber = new System.Windows.Forms.TextBox();
            this.txtUnitCost = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Device*Time:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "RMB/Device/Time:";
            // 
            // txtCalcNumber
            // 
            this.txtCalcNumber.Location = new System.Drawing.Point(119, 39);
            this.txtCalcNumber.Name = "txtCalcNumber";
            this.txtCalcNumber.Size = new System.Drawing.Size(110, 20);
            this.txtCalcNumber.TabIndex = 6;
            this.txtCalcNumber.Text = "1";
            this.txtCalcNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtUnitCost
            // 
            this.txtUnitCost.Location = new System.Drawing.Point(119, 12);
            this.txtUnitCost.Name = "txtUnitCost";
            this.txtUnitCost.Size = new System.Drawing.Size(110, 20);
            this.txtUnitCost.TabIndex = 5;
            this.txtUnitCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(235, 12);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(90, 47);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // CostVHPProcess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 72);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCalcNumber);
            this.Controls.Add(this.txtUnitCost);
            this.Controls.Add(this.btnOK);
            this.Name = "CostVHPProcess";
            this.Text = "CostVHPProcess";
            this.Load += new System.EventHandler(this.CostVHPProcess_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCalcNumber;
        private System.Windows.Forms.TextBox txtUnitCost;
        private System.Windows.Forms.Button btnOK;
    }
}