namespace PMICalculatorDll
{
    partial class CalculatorSimpleSubstanceOfEveryCompound
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvCalculateList = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnInventorySimpleSubstance = new System.Windows.Forms.Button();
            this.txtMolWeight = new System.Windows.Forms.TextBox();
            this.txtElementName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.ElementName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MolWeight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.At = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Wt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Weight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCalculateList)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "材料重量";
            // 
            // txtWeight
            // 
            this.txtWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWeight.Location = new System.Drawing.Point(71, 12);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtWeight.Size = new System.Drawing.Size(88, 22);
            this.txtWeight.TabIndex = 2;
            this.txtWeight.Text = "1000";
            this.txtWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(165, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "g";
            // 
            // dgvCalculateList
            // 
            this.dgvCalculateList.AllowUserToAddRows = false;
            this.dgvCalculateList.AllowUserToDeleteRows = false;
            this.dgvCalculateList.AllowUserToResizeRows = false;
            this.dgvCalculateList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCalculateList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCalculateList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ElementName,
            this.MolWeight,
            this.At,
            this.Wt,
            this.Weight});
            this.dgvCalculateList.Location = new System.Drawing.Point(12, 220);
            this.dgvCalculateList.MultiSelect = false;
            this.dgvCalculateList.Name = "dgvCalculateList";
            this.dgvCalculateList.ReadOnly = true;
            this.dgvCalculateList.RowHeadersWidth = 30;
            this.dgvCalculateList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvCalculateList.RowTemplate.Height = 23;
            this.dgvCalculateList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCalculateList.Size = new System.Drawing.Size(470, 140);
            this.dgvCalculateList.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnInventorySimpleSubstance);
            this.groupBox1.Controls.Add(this.txtMolWeight);
            this.groupBox1.Controls.Add(this.txtElementName);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtAt);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Location = new System.Drawing.Point(12, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(471, 110);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "计算区域";
            // 
            // btnInventorySimpleSubstance
            // 
            this.btnInventorySimpleSubstance.Location = new System.Drawing.Point(218, 19);
            this.btnInventorySimpleSubstance.Name = "btnInventorySimpleSubstance";
            this.btnInventorySimpleSubstance.Size = new System.Drawing.Size(122, 29);
            this.btnInventorySimpleSubstance.TabIndex = 2;
            this.btnInventorySimpleSubstance.Text = "元素单质库";
            this.btnInventorySimpleSubstance.UseVisualStyleBackColor = true;
            this.btnInventorySimpleSubstance.Click += new System.EventHandler(this.btnInventorySimpleSubstance_Click);
            // 
            // txtMolWeight
            // 
            this.txtMolWeight.Location = new System.Drawing.Point(109, 50);
            this.txtMolWeight.Name = "txtMolWeight";
            this.txtMolWeight.Size = new System.Drawing.Size(100, 20);
            this.txtMolWeight.TabIndex = 0;
            this.txtMolWeight.Text = "5";
            this.txtMolWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtElementName
            // 
            this.txtElementName.Location = new System.Drawing.Point(109, 24);
            this.txtElementName.Name = "txtElementName";
            this.txtElementName.Size = new System.Drawing.Size(100, 20);
            this.txtElementName.TabIndex = 0;
            this.txtElementName.Text = "元素1";
            this.txtElementName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(215, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "g/mol";
            // 
            // txtAt
            // 
            this.txtAt.Location = new System.Drawing.Point(109, 76);
            this.txtAt.Name = "txtAt";
            this.txtAt.Size = new System.Drawing.Size(100, 20);
            this.txtAt.TabIndex = 0;
            this.txtAt.Text = "50";
            this.txtAt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(215, 79);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(15, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "%";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "摩尔质量";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(48, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "元素名称";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(24, 79);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "摩尔分数(At%)";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(12, 185);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(91, 29);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "添加";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(391, 185);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(91, 29);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "删除";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(12, 366);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(470, 53);
            this.btnCalculate.TabIndex = 2;
            this.btnCalculate.Text = "计算";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // ElementName
            // 
            this.ElementName.DataPropertyName = "ElementName";
            this.ElementName.HeaderText = "元素名称";
            this.ElementName.Name = "ElementName";
            this.ElementName.ReadOnly = true;
            // 
            // MolWeight
            // 
            this.MolWeight.DataPropertyName = "MolWeight";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.Format = "N2";
            dataGridViewCellStyle1.NullValue = null;
            this.MolWeight.DefaultCellStyle = dataGridViewCellStyle1;
            this.MolWeight.HeaderText = "摩尔质量(g/mol)";
            this.MolWeight.Name = "MolWeight";
            this.MolWeight.ReadOnly = true;
            this.MolWeight.Width = 120;
            // 
            // At
            // 
            this.At.DataPropertyName = "At";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = null;
            this.At.DefaultCellStyle = dataGridViewCellStyle2;
            this.At.HeaderText = "At(%)";
            this.At.Name = "At";
            this.At.ReadOnly = true;
            this.At.Width = 60;
            // 
            // Wt
            // 
            this.Wt.DataPropertyName = "Wt";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = null;
            this.Wt.DefaultCellStyle = dataGridViewCellStyle3;
            this.Wt.HeaderText = "Wt(%)";
            this.Wt.Name = "Wt";
            this.Wt.ReadOnly = true;
            this.Wt.Width = 60;
            // 
            // Weight
            // 
            this.Weight.DataPropertyName = "Weight";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "N2";
            dataGridViewCellStyle4.NullValue = null;
            this.Weight.DefaultCellStyle = dataGridViewCellStyle4;
            this.Weight.HeaderText = "重量(g)";
            this.Weight.Name = "Weight";
            this.Weight.ReadOnly = true;
            this.Weight.Width = 80;
            // 
            // CalculatorSimpleSubstanceOfEveryCompound
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 431);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvCalculateList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtWeight);
            this.Name = "CalculatorSimpleSubstanceOfEveryCompound";
            this.Text = "已知化合物摩尔比，计算化合物的成分单质重量";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCalculateList)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvCalculateList;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnInventorySimpleSubstance;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtMolWeight;
        private System.Windows.Forms.TextBox txtElementName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ElementName;
        private System.Windows.Forms.DataGridViewTextBoxColumn MolWeight;
        private System.Windows.Forms.DataGridViewTextBoxColumn At;
        private System.Windows.Forms.DataGridViewTextBoxColumn Wt;
        private System.Windows.Forms.DataGridViewTextBoxColumn Weight;
    }
}