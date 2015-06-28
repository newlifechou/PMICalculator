namespace PMICalculatorDll
{
    partial class CalculatorWeightingDensityByWt
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
            this.dgv = new System.Windows.Forms.DataGridView();
            this.ItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemWt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemDensity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.txtWeightingDensity = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtItemWt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtItemDensity = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btnInventorySimpleSubstance = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemName,
            this.ItemWt,
            this.ItemDensity});
            this.dgv.Location = new System.Drawing.Point(12, 182);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowTemplate.Height = 23;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(371, 197);
            this.dgv.TabIndex = 0;
            // 
            // ItemName
            // 
            this.ItemName.DataPropertyName = "ItemName";
            this.ItemName.HeaderText = "成分名称";
            this.ItemName.Name = "ItemName";
            this.ItemName.ReadOnly = true;
            // 
            // ItemWt
            // 
            this.ItemWt.DataPropertyName = "ItemWt";
            this.ItemWt.HeaderText = "所占Wt%";
            this.ItemWt.Name = "ItemWt";
            this.ItemWt.ReadOnly = true;
            // 
            // ItemDensity
            // 
            this.ItemDensity.DataPropertyName = "ItemDensity";
            this.ItemDensity.HeaderText = "成分密度";
            this.ItemDensity.Name = "ItemDensity";
            this.ItemDensity.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "成分名称";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(12, 386);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(371, 62);
            this.btnCalculate.TabIndex = 5;
            this.btnCalculate.Text = "计算";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // txtWeightingDensity
            // 
            this.txtWeightingDensity.BackColor = System.Drawing.Color.Wheat;
            this.txtWeightingDensity.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWeightingDensity.Location = new System.Drawing.Point(120, 455);
            this.txtWeightingDensity.Name = "txtWeightingDensity";
            this.txtWeightingDensity.ReadOnly = true;
            this.txtWeightingDensity.Size = new System.Drawing.Size(261, 31);
            this.txtWeightingDensity.TabIndex = 3;
            this.txtWeightingDensity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 463);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "混合物的加权密度";
            // 
            // txtItemName
            // 
            this.txtItemName.Location = new System.Drawing.Point(72, 26);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(100, 20);
            this.txtItemName.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "所占Wt%";
            // 
            // txtItemWt
            // 
            this.txtItemWt.Location = new System.Drawing.Point(72, 78);
            this.txtItemWt.Name = "txtItemWt";
            this.txtItemWt.Size = new System.Drawing.Size(100, 20);
            this.txtItemWt.TabIndex = 2;
            this.txtItemWt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "成分密度";
            // 
            // txtItemDensity
            // 
            this.txtItemDensity.Location = new System.Drawing.Point(72, 52);
            this.txtItemDensity.Name = "txtItemDensity";
            this.txtItemDensity.Size = new System.Drawing.Size(100, 20);
            this.txtItemDensity.TabIndex = 3;
            this.txtItemDensity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(178, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "%";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(178, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "g/cm3";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(12, 114);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(137, 36);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "添加成分";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(244, 114);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(137, 36);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "删除选定成分";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 159);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(159, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "需确保输入的Wt的总和为100";
            // 
            // btnInventorySimpleSubstance
            // 
            this.btnInventorySimpleSubstance.Location = new System.Drawing.Point(244, 17);
            this.btnInventorySimpleSubstance.Name = "btnInventorySimpleSubstance";
            this.btnInventorySimpleSubstance.Size = new System.Drawing.Size(137, 36);
            this.btnInventorySimpleSubstance.TabIndex = 24;
            this.btnInventorySimpleSubstance.Text = "元素单质库";
            this.btnInventorySimpleSubstance.UseVisualStyleBackColor = true;
            this.btnInventorySimpleSubstance.Click += new System.EventHandler(this.btnInventorySimpleSubstance_Click);
            // 
            // CalculatorWeightingDensityByWt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 498);
            this.Controls.Add(this.btnInventorySimpleSubstance);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtItemDensity);
            this.Controls.Add(this.txtItemWt);
            this.Controls.Add(this.txtItemName);
            this.Controls.Add(this.txtWeightingDensity);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv);
            this.Name = "CalculatorWeightingDensityByWt";
            this.Text = "加权密度计算器-知道Wt比例";
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox txtWeightingDensity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtItemName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtItemWt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtItemDensity;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemWt;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemDensity;
        private System.Windows.Forms.Button btnInventorySimpleSubstance;
    }
}