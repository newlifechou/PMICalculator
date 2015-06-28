namespace PMICostCalculator
{
    partial class CostMaterialsProcess
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtRawMaterial = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSintering = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtOthers = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOK.Location = new System.Drawing.Point(221, 4);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(115, 76);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Raw Material Cost:";
            // 
            // txtRawMaterial
            // 
            this.txtRawMaterial.Location = new System.Drawing.Point(106, 4);
            this.txtRawMaterial.Name = "txtRawMaterial";
            this.txtRawMaterial.Size = new System.Drawing.Size(100, 20);
            this.txtRawMaterial.TabIndex = 2;
            this.txtRawMaterial.Text = "0";
            this.txtRawMaterial.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sintering Cost:";
            // 
            // txtSintering
            // 
            this.txtSintering.Location = new System.Drawing.Point(106, 33);
            this.txtSintering.Name = "txtSintering";
            this.txtSintering.Size = new System.Drawing.Size(100, 20);
            this.txtSintering.TabIndex = 2;
            this.txtSintering.Text = "0";
            this.txtSintering.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Others:";
            // 
            // txtOthers
            // 
            this.txtOthers.Location = new System.Drawing.Point(106, 59);
            this.txtOthers.Name = "txtOthers";
            this.txtOthers.Size = new System.Drawing.Size(100, 20);
            this.txtOthers.TabIndex = 2;
            this.txtOthers.Text = "0";
            this.txtOthers.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // CostMaterialsProcess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 92);
            this.Controls.Add(this.txtOthers);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSintering);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtRawMaterial);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOK);
            this.Name = "CostMaterialsProcess";
            this.Text = "CostMaterialsProcess";
            this.Load += new System.EventHandler(this.CostMaterialsProcess_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRawMaterial;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSintering;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtOthers;
    }
}