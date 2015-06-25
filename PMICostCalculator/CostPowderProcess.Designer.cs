namespace PMICostCalculator
{
    partial class CostPowderProcess
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
            this.btnOK = new System.Windows.Forms.Button();
            this.txtUnitCostPowderProcess = new System.Windows.Forms.TextBox();
            this.txtPowderWeight = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(182, 12);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(90, 47);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // txtUnitCostPowderProcess
            // 
            this.txtUnitCostPowderProcess.Location = new System.Drawing.Point(89, 12);
            this.txtUnitCostPowderProcess.Name = "txtUnitCostPowderProcess";
            this.txtUnitCostPowderProcess.Size = new System.Drawing.Size(87, 20);
            this.txtUnitCostPowderProcess.TabIndex = 1;
            this.txtUnitCostPowderProcess.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtPowderWeight
            // 
            this.txtPowderWeight.Location = new System.Drawing.Point(89, 39);
            this.txtPowderWeight.Name = "txtPowderWeight";
            this.txtPowderWeight.Size = new System.Drawing.Size(87, 20);
            this.txtPowderWeight.TabIndex = 2;
            this.txtPowderWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "RMB/kg";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Power Weight";
            // 
            // CostPowderProcess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 76);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPowderWeight);
            this.Controls.Add(this.txtUnitCostPowderProcess);
            this.Controls.Add(this.btnOK);
            this.Name = "CostPowderProcess";
            this.Text = "CostPowderProcess";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TextBox txtUnitCostPowderProcess;
        private System.Windows.Forms.TextBox txtPowderWeight;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}