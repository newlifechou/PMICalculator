namespace PMICostCalculator
{
    partial class AddCostItem
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboItemCategory = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboItemType = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtItemCost = new System.Windows.Forms.TextBox();
            this.chkKeepShow = new System.Windows.Forms.CheckBox();
            this.txtItemRemark = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCalculator = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(283, 287);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(87, 47);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ItemName";
            // 
            // txtItemName
            // 
            this.txtItemName.Location = new System.Drawing.Point(83, 13);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(171, 20);
            this.txtItemName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "ItemCategory";
            // 
            // cboItemCategory
            // 
            this.cboItemCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboItemCategory.FormattingEnabled = true;
            this.cboItemCategory.Location = new System.Drawing.Point(83, 41);
            this.cboItemCategory.Name = "cboItemCategory";
            this.cboItemCategory.Size = new System.Drawing.Size(171, 21);
            this.cboItemCategory.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "ItemType";
            // 
            // cboItemType
            // 
            this.cboItemType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboItemType.FormattingEnabled = true;
            this.cboItemType.Location = new System.Drawing.Point(83, 69);
            this.cboItemType.Name = "cboItemType";
            this.cboItemType.Size = new System.Drawing.Size(171, 21);
            this.cboItemType.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "ItemCost";
            // 
            // txtItemCost
            // 
            this.txtItemCost.BackColor = System.Drawing.Color.Wheat;
            this.txtItemCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemCost.ForeColor = System.Drawing.Color.Blue;
            this.txtItemCost.Location = new System.Drawing.Point(83, 99);
            this.txtItemCost.Name = "txtItemCost";
            this.txtItemCost.Size = new System.Drawing.Size(171, 31);
            this.txtItemCost.TabIndex = 2;
            this.txtItemCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // chkKeepShow
            // 
            this.chkKeepShow.AutoSize = true;
            this.chkKeepShow.Checked = true;
            this.chkKeepShow.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkKeepShow.Location = new System.Drawing.Point(12, 302);
            this.chkKeepShow.Name = "chkKeepShow";
            this.chkKeepShow.Size = new System.Drawing.Size(201, 17);
            this.chkKeepShow.TabIndex = 4;
            this.chkKeepShow.Text = "Don\'t close this window after addition";
            this.chkKeepShow.UseVisualStyleBackColor = true;
            // 
            // txtItemRemark
            // 
            this.txtItemRemark.Location = new System.Drawing.Point(83, 136);
            this.txtItemRemark.Multiline = true;
            this.txtItemRemark.Name = "txtItemRemark";
            this.txtItemRemark.Size = new System.Drawing.Size(287, 143);
            this.txtItemRemark.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "ItemRemark";
            // 
            // btnCalculator
            // 
            this.btnCalculator.Location = new System.Drawing.Point(260, 99);
            this.btnCalculator.Name = "btnCalculator";
            this.btnCalculator.Size = new System.Drawing.Size(110, 28);
            this.btnCalculator.TabIndex = 5;
            this.btnCalculator.Text = "Calculator";
            this.btnCalculator.UseVisualStyleBackColor = true;
            this.btnCalculator.Click += new System.EventHandler(this.btnCalculator_Click);
            // 
            // AddCostItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 347);
            this.Controls.Add(this.btnCalculator);
            this.Controls.Add(this.chkKeepShow);
            this.Controls.Add(this.cboItemType);
            this.Controls.Add(this.cboItemCategory);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtItemRemark);
            this.Controls.Add(this.txtItemCost);
            this.Controls.Add(this.txtItemName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAdd);
            this.Name = "AddCostItem";
            this.Text = "AddCostCalculateItem";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtItemName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboItemCategory;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboItemType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtItemCost;
        private System.Windows.Forms.CheckBox chkKeepShow;
        private System.Windows.Forms.TextBox txtItemRemark;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCalculator;
    }
}