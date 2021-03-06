﻿namespace PMICalculatorDll
{
    partial class CalculatorPressureFromT1D1D2ToT2
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
            this.btnCalculate = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtT1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnInventoryMold1 = new System.Windows.Forms.Button();
            this.txtD1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtP1 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnInventoryMold2 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtD2 = new System.Windows.Forms.TextBox();
            this.txtT2 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "直径";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(12, 260);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(282, 41);
            this.btnCalculate.TabIndex = 4;
            this.btnCalculate.Text = "计算";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(136, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "mm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "压力";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(136, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(10, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "t";
            // 
            // txtT1
            // 
            this.txtT1.Location = new System.Drawing.Point(50, 51);
            this.txtT1.Name = "txtT1";
            this.txtT1.Size = new System.Drawing.Size(80, 20);
            this.txtT1.TabIndex = 2;
            this.txtT1.Text = "30";
            this.txtT1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnInventoryMold1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtD1);
            this.groupBox1.Controls.Add(this.txtT1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(282, 87);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "模具1";
            // 
            // btnInventoryMold1
            // 
            this.btnInventoryMold1.Location = new System.Drawing.Point(185, 17);
            this.btnInventoryMold1.Name = "btnInventoryMold1";
            this.btnInventoryMold1.Size = new System.Drawing.Size(91, 29);
            this.btnInventoryMold1.TabIndex = 3;
            this.btnInventoryMold1.Text = "模具库";
            this.btnInventoryMold1.UseVisualStyleBackColor = true;
            this.btnInventoryMold1.Click += new System.EventHandler(this.btnInventoryMold1_Click);
            // 
            // txtD1
            // 
            this.txtD1.Location = new System.Drawing.Point(50, 22);
            this.txtD1.Name = "txtD1";
            this.txtD1.Size = new System.Drawing.Size(80, 20);
            this.txtD1.TabIndex = 1;
            this.txtD1.Text = "80";
            this.txtD1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "压强";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(177, 207);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "MPa";
            // 
            // txtP1
            // 
            this.txtP1.BackColor = System.Drawing.Color.Wheat;
            this.txtP1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.txtP1.Location = new System.Drawing.Point(62, 199);
            this.txtP1.Name = "txtP1";
            this.txtP1.ReadOnly = true;
            this.txtP1.Size = new System.Drawing.Size(109, 31);
            this.txtP1.TabIndex = 7;
            this.txtP1.TabStop = false;
            this.txtP1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnInventoryMold2);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtD2);
            this.groupBox2.Controls.Add(this.txtT2);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Location = new System.Drawing.Point(12, 106);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(282, 87);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "模具2";
            // 
            // btnInventoryMold2
            // 
            this.btnInventoryMold2.Location = new System.Drawing.Point(185, 17);
            this.btnInventoryMold2.Name = "btnInventoryMold2";
            this.btnInventoryMold2.Size = new System.Drawing.Size(91, 29);
            this.btnInventoryMold2.TabIndex = 3;
            this.btnInventoryMold2.Text = "模具库";
            this.btnInventoryMold2.UseVisualStyleBackColor = true;
            this.btnInventoryMold2.Click += new System.EventHandler(this.btnInventoryMold1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "直径";
            // 
            // txtD2
            // 
            this.txtD2.Location = new System.Drawing.Point(50, 22);
            this.txtD2.Name = "txtD2";
            this.txtD2.Size = new System.Drawing.Size(80, 20);
            this.txtD2.TabIndex = 3;
            this.txtD2.Text = "306";
            this.txtD2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtT2
            // 
            this.txtT2.BackColor = System.Drawing.Color.Wheat;
            this.txtT2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.txtT2.Location = new System.Drawing.Point(50, 49);
            this.txtT2.Name = "txtT2";
            this.txtT2.ReadOnly = true;
            this.txtT2.Size = new System.Drawing.Size(109, 31);
            this.txtT2.TabIndex = 6;
            this.txtT2.TabStop = false;
            this.txtT2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(136, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(23, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "mm";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(165, 58);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(10, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "t";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(15, 58);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(31, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "压力";
            // 
            // CalculatorPressureFromT1D1D2ToT2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 320);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtP1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.label5);
            this.Name = "CalculatorPressureFromT1D1D2ToT2";
            this.Text = "压力计算-知道T1D1D2计算T2";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtT1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtP1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtT2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtD1;
        private System.Windows.Forms.TextBox txtD2;
        private System.Windows.Forms.Button btnInventoryMold1;
        private System.Windows.Forms.Button btnInventoryMold2;
    }
}