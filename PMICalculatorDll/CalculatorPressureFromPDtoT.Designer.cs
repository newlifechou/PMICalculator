namespace PMICalculatorDll
{
    partial class CalculatorPressureFromPDtoT
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtD1 = new System.Windows.Forms.TextBox();
            this.txtT1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtP1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnInventoryMold = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "直径";
            // 
            // txtD1
            // 
            this.txtD1.Location = new System.Drawing.Point(56, 49);
            this.txtD1.Name = "txtD1";
            this.txtD1.Size = new System.Drawing.Size(80, 20);
            this.txtD1.TabIndex = 2;
            this.txtD1.Text = "80";
            this.txtD1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtT1
            // 
            this.txtT1.BackColor = System.Drawing.Color.Wheat;
            this.txtT1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtT1.Location = new System.Drawing.Point(56, 73);
            this.txtT1.Name = "txtT1";
            this.txtT1.ReadOnly = true;
            this.txtT1.Size = new System.Drawing.Size(109, 31);
            this.txtT1.TabIndex = 15;
            this.txtT1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(142, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "mm";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(171, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(10, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "t";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "压力";
            // 
            // txtP1
            // 
            this.txtP1.Location = new System.Drawing.Point(56, 20);
            this.txtP1.Name = "txtP1";
            this.txtP1.Size = new System.Drawing.Size(80, 20);
            this.txtP1.TabIndex = 1;
            this.txtP1.TabStop = false;
            this.txtP1.Text = "30";
            this.txtP1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(142, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "MPa";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "压强";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(14, 117);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(280, 41);
            this.btnCalculate.TabIndex = 3;
            this.btnCalculate.Text = "计算";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnInventoryMold
            // 
            this.btnInventoryMold.Location = new System.Drawing.Point(203, 45);
            this.btnInventoryMold.Name = "btnInventoryMold";
            this.btnInventoryMold.Size = new System.Drawing.Size(91, 29);
            this.btnInventoryMold.TabIndex = 16;
            this.btnInventoryMold.Text = "模具库";
            this.btnInventoryMold.UseVisualStyleBackColor = true;
            this.btnInventoryMold.Click += new System.EventHandler(this.btnInventoryMold_Click);
            // 
            // CalculatorPressureFromPDtoT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 172);
            this.Controls.Add(this.btnInventoryMold);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtD1);
            this.Controls.Add(this.txtT1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtP1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Name = "CalculatorPressureFromPDtoT";
            this.Text = "压力计算,知道PD,计算T";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtD1;
        private System.Windows.Forms.TextBox txtT1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtP1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnInventoryMold;
    }
}