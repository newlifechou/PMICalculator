namespace PMICalculatorDll
{
    partial class CalculatorFillMaterials
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
            this.btnInventoryDensity = new System.Windows.Forms.Button();
            this.txtTheoreticalDensity = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnInventoryMold = new System.Windows.Forms.Button();
            this.chkThicknessMore = new System.Windows.Forms.CheckBox();
            this.txtThickness = new System.Windows.Forms.TextBox();
            this.txtThicnessMore = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDiameter = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnInventoryDensity
            // 
            this.btnInventoryDensity.Location = new System.Drawing.Point(266, 6);
            this.btnInventoryDensity.Name = "btnInventoryDensity";
            this.btnInventoryDensity.Size = new System.Drawing.Size(91, 29);
            this.btnInventoryDensity.TabIndex = 61;
            this.btnInventoryDensity.Text = "密度库";
            this.btnInventoryDensity.UseVisualStyleBackColor = true;
            this.btnInventoryDensity.Click += new System.EventHandler(this.btnInventoryDensity_Click);
            // 
            // txtTheoreticalDensity
            // 
            this.txtTheoreticalDensity.Location = new System.Drawing.Point(116, 14);
            this.txtTheoreticalDensity.Name = "txtTheoreticalDensity";
            this.txtTheoreticalDensity.Size = new System.Drawing.Size(100, 20);
            this.txtTheoreticalDensity.TabIndex = 60;
            this.txtTheoreticalDensity.Text = "5.75";
            this.txtTheoreticalDensity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(222, 17);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(38, 13);
            this.label18.TabIndex = 58;
            this.label18.Text = "g/cm3";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(57, 18);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(55, 13);
            this.label17.TabIndex = 59;
            this.label17.Text = "理论密度";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(222, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 13);
            this.label4.TabIndex = 66;
            this.label4.Text = "mm";
            // 
            // btnInventoryMold
            // 
            this.btnInventoryMold.Location = new System.Drawing.Point(266, 36);
            this.btnInventoryMold.Name = "btnInventoryMold";
            this.btnInventoryMold.Size = new System.Drawing.Size(91, 29);
            this.btnInventoryMold.TabIndex = 73;
            this.btnInventoryMold.Text = "模具库";
            this.btnInventoryMold.UseVisualStyleBackColor = true;
            this.btnInventoryMold.Click += new System.EventHandler(this.btnInventoryMold_Click);
            // 
            // chkThicknessMore
            // 
            this.chkThicknessMore.AutoSize = true;
            this.chkThicknessMore.Checked = true;
            this.chkThicknessMore.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkThicknessMore.Location = new System.Drawing.Point(12, 92);
            this.chkThicknessMore.Name = "chkThicknessMore";
            this.chkThicknessMore.Size = new System.Drawing.Size(98, 17);
            this.chkThicknessMore.TabIndex = 74;
            this.chkThicknessMore.Text = "考虑加工余量";
            this.chkThicknessMore.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkThicknessMore.UseVisualStyleBackColor = true;
            // 
            // txtThickness
            // 
            this.txtThickness.Location = new System.Drawing.Point(116, 66);
            this.txtThickness.Name = "txtThickness";
            this.txtThickness.Size = new System.Drawing.Size(100, 20);
            this.txtThickness.TabIndex = 62;
            this.txtThickness.Text = "5";
            this.txtThickness.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtThicnessMore
            // 
            this.txtThicnessMore.Location = new System.Drawing.Point(116, 92);
            this.txtThicnessMore.Name = "txtThicnessMore";
            this.txtThicnessMore.Size = new System.Drawing.Size(100, 20);
            this.txtThicnessMore.TabIndex = 63;
            this.txtThicnessMore.Text = "0.5";
            this.txtThicnessMore.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(222, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 13);
            this.label6.TabIndex = 67;
            this.label6.Text = "mm";
            // 
            // txtDiameter
            // 
            this.txtDiameter.Location = new System.Drawing.Point(116, 40);
            this.txtDiameter.Name = "txtDiameter";
            this.txtDiameter.Size = new System.Drawing.Size(100, 20);
            this.txtDiameter.TabIndex = 64;
            this.txtDiameter.Text = "233";
            this.txtDiameter.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(222, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 13);
            this.label5.TabIndex = 68;
            this.label5.Text = "mm";
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(116, 118);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(100, 20);
            this.txtNumber.TabIndex = 65;
            this.txtNumber.Text = "1";
            this.txtNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(222, 121);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(19, 13);
            this.label8.TabIndex = 69;
            this.label8.Text = "片";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 70;
            this.label2.Text = "产品厚度";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 71;
            this.label3.Text = "模具直径";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(55, 121);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 72;
            this.label7.Text = "热压数目";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(344, 201);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(13, 13);
            this.label13.TabIndex = 78;
            this.label13.Text = "g";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(17, 201);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(127, 13);
            this.label12.TabIndex = 77;
            this.label12.Text = "最终所需要的原料重量";
            // 
            // txtTotal
            // 
            this.txtTotal.BackColor = System.Drawing.Color.Wheat;
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.ForeColor = System.Drawing.Color.Blue;
            this.txtTotal.Location = new System.Drawing.Point(148, 192);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(190, 31);
            this.txtTotal.TabIndex = 76;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(20, 147);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(337, 39);
            this.btnCalculate.TabIndex = 79;
            this.btnCalculate.Text = "开始计算";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // CalculatorFillMaterials
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 236);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnInventoryMold);
            this.Controls.Add(this.chkThicknessMore);
            this.Controls.Add(this.txtThickness);
            this.Controls.Add(this.txtThicnessMore);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtDiameter);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnInventoryDensity);
            this.Controls.Add(this.txtTheoreticalDensity);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Name = "CalculatorFillMaterials";
            this.Text = "CalculatorFillMaterials";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInventoryDensity;
        private System.Windows.Forms.TextBox txtTheoreticalDensity;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnInventoryMold;
        private System.Windows.Forms.CheckBox chkThicknessMore;
        private System.Windows.Forms.TextBox txtThickness;
        private System.Windows.Forms.TextBox txtThicnessMore;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDiameter;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Button btnCalculate;
    }
}