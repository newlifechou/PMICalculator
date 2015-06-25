namespace PMICostCalculator
{
    partial class CostMachiningProcess
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
            this.txtPowderPieces = new System.Windows.Forms.TextBox();
            this.txtUnitCostMachining = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Pieces Of Targets";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "RMB/piece";
            // 
            // txtPowderPieces
            // 
            this.txtPowderPieces.Location = new System.Drawing.Point(127, 39);
            this.txtPowderPieces.Name = "txtPowderPieces";
            this.txtPowderPieces.Size = new System.Drawing.Size(110, 20);
            this.txtPowderPieces.TabIndex = 6;
            this.txtPowderPieces.Text = "1";
            this.txtPowderPieces.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtUnitCostMachining
            // 
            this.txtUnitCostMachining.Location = new System.Drawing.Point(127, 12);
            this.txtUnitCostMachining.Name = "txtUnitCostMachining";
            this.txtUnitCostMachining.Size = new System.Drawing.Size(110, 20);
            this.txtUnitCostMachining.TabIndex = 5;
            this.txtUnitCostMachining.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(243, 12);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(90, 47);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // CostMachiningProcess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 71);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPowderPieces);
            this.Controls.Add(this.txtUnitCostMachining);
            this.Controls.Add(this.btnOK);
            this.Name = "CostMachiningProcess";
            this.Text = "CostMachiningProcess";
            this.Load += new System.EventHandler(this.CostMachiningProcess_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPowderPieces;
        private System.Windows.Forms.TextBox txtUnitCostMachining;
        private System.Windows.Forms.Button btnOK;
    }
}