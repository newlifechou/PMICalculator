namespace PMICalculatorDll
{
    partial class CalculatorWeightingDensityByAt
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
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtItemDensity = new System.Windows.Forms.TextBox();
            this.txtItemAt = new System.Windows.Forms.TextBox();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.txtWeightingDensity = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.ItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemAt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemDensity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemMolWeight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtItemMolWeight = new System.Windows.Forms.TextBox();
            this.btnInventorySimpleSubstance = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(310, 150);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(137, 36);
            this.btnDelete.TabIndex = 22;
            this.btnDelete.Text = "删除选定成分";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(12, 150);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(137, 36);
            this.btnAdd.TabIndex = 20;
            this.btnAdd.Text = "添加成分";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtItemDensity
            // 
            this.txtItemDensity.Location = new System.Drawing.Point(72, 83);
            this.txtItemDensity.Name = "txtItemDensity";
            this.txtItemDensity.Size = new System.Drawing.Size(100, 20);
            this.txtItemDensity.TabIndex = 4;
            this.txtItemDensity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtItemAt
            // 
            this.txtItemAt.Location = new System.Drawing.Point(72, 113);
            this.txtItemAt.Name = "txtItemAt";
            this.txtItemAt.Size = new System.Drawing.Size(100, 20);
            this.txtItemAt.TabIndex = 2;
            this.txtItemAt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtItemName
            // 
            this.txtItemName.Location = new System.Drawing.Point(72, 54);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(100, 20);
            this.txtItemName.TabIndex = 1;
            // 
            // txtWeightingDensity
            // 
            this.txtWeightingDensity.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWeightingDensity.Location = new System.Drawing.Point(117, 426);
            this.txtWeightingDensity.Name = "txtWeightingDensity";
            this.txtWeightingDensity.ReadOnly = true;
            this.txtWeightingDensity.Size = new System.Drawing.Size(327, 35);
            this.txtWeightingDensity.TabIndex = 19;
            this.txtWeightingDensity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 193);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(155, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "需确保输入的At的总和为100";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "成分密度";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(12, 372);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(435, 47);
            this.btnCalculate.TabIndex = 5;
            this.btnCalculate.Text = "计算";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(178, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "g/cm3";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(178, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "%";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "所占At%";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 437);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "混合物的加权密度";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "成分名称";
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemName,
            this.ItemAt,
            this.ItemDensity,
            this.ItemMolWeight});
            this.dgv.Location = new System.Drawing.Point(12, 209);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowTemplate.Height = 23;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(435, 156);
            this.dgv.TabIndex = 8;
            // 
            // ItemName
            // 
            this.ItemName.DataPropertyName = "ItemName";
            this.ItemName.HeaderText = "成分名称";
            this.ItemName.Name = "ItemName";
            this.ItemName.ReadOnly = true;
            // 
            // ItemAt
            // 
            this.ItemAt.DataPropertyName = "ItemAt";
            this.ItemAt.HeaderText = "所占At%";
            this.ItemAt.Name = "ItemAt";
            this.ItemAt.ReadOnly = true;
            // 
            // ItemDensity
            // 
            this.ItemDensity.DataPropertyName = "ItemDensity";
            this.ItemDensity.HeaderText = "成分密度";
            this.ItemDensity.Name = "ItemDensity";
            this.ItemDensity.ReadOnly = true;
            // 
            // ItemMolWeight
            // 
            this.ItemMolWeight.DataPropertyName = "ItemMolWeight";
            this.ItemMolWeight.HeaderText = "摩尔质量";
            this.ItemMolWeight.Name = "ItemMolWeight";
            this.ItemMolWeight.ReadOnly = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(217, 86);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "摩尔质量";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(382, 86);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "g/mol";
            // 
            // txtItemMolWeight
            // 
            this.txtItemMolWeight.Location = new System.Drawing.Point(276, 83);
            this.txtItemMolWeight.Name = "txtItemMolWeight";
            this.txtItemMolWeight.Size = new System.Drawing.Size(100, 20);
            this.txtItemMolWeight.TabIndex = 3;
            this.txtItemMolWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnInventorySimpleSubstance
            // 
            this.btnInventorySimpleSubstance.Location = new System.Drawing.Point(12, 6);
            this.btnInventorySimpleSubstance.Name = "btnInventorySimpleSubstance";
            this.btnInventorySimpleSubstance.Size = new System.Drawing.Size(137, 36);
            this.btnInventorySimpleSubstance.TabIndex = 23;
            this.btnInventorySimpleSubstance.Text = "元素单质库";
            this.btnInventorySimpleSubstance.UseVisualStyleBackColor = true;
            this.btnInventorySimpleSubstance.Click += new System.EventHandler(this.btnInventorySimpleSubstance_Click);
            // 
            // CalculatorWeightingDensityByAt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 471);
            this.Controls.Add(this.btnInventorySimpleSubstance);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtItemDensity);
            this.Controls.Add(this.txtItemMolWeight);
            this.Controls.Add(this.txtItemAt);
            this.Controls.Add(this.txtItemName);
            this.Controls.Add(this.txtWeightingDensity);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv);
            this.Name = "CalculatorWeightingDensityByAt";
            this.Text = "加权密度计算，知道At和摩尔质量";
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtItemDensity;
        private System.Windows.Forms.TextBox txtItemAt;
        private System.Windows.Forms.TextBox txtItemName;
        private System.Windows.Forms.TextBox txtWeightingDensity;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtItemMolWeight;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemAt;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemDensity;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemMolWeight;
        private System.Windows.Forms.Button btnInventorySimpleSubstance;
    }
}