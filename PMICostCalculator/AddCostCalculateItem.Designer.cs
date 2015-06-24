namespace PMICostCalculator
{
    partial class AddCostCalculateItem
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
            this.cboItemType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboItemStyle = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtItemCost = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.chkKeepShow = new System.Windows.Forms.CheckBox();
            this.txtItemRemark = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(283, 265);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(87, 43);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "ItemName";
            // 
            // txtItemName
            // 
            this.txtItemName.Location = new System.Drawing.Point(83, 12);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(171, 21);
            this.txtItemName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "ItemType";
            // 
            // cboItemType
            // 
            this.cboItemType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboItemType.FormattingEnabled = true;
            this.cboItemType.Location = new System.Drawing.Point(83, 38);
            this.cboItemType.Name = "cboItemType";
            this.cboItemType.Size = new System.Drawing.Size(171, 20);
            this.cboItemType.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "ItemStyle";
            // 
            // cboItemStyle
            // 
            this.cboItemStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboItemStyle.FormattingEnabled = true;
            this.cboItemStyle.Location = new System.Drawing.Point(83, 64);
            this.cboItemStyle.Name = "cboItemStyle";
            this.cboItemStyle.Size = new System.Drawing.Size(171, 20);
            this.cboItemStyle.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 1;
            this.label4.Text = "ItemCost";
            // 
            // txtItemCost
            // 
            this.txtItemCost.Location = new System.Drawing.Point(83, 91);
            this.txtItemCost.Name = "txtItemCost";
            this.txtItemCost.Size = new System.Drawing.Size(171, 21);
            this.txtItemCost.TabIndex = 2;
            this.txtItemCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(283, 84);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 32);
            this.button2.TabIndex = 0;
            this.button2.Text = "<=CalcTool";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // chkKeepShow
            // 
            this.chkKeepShow.AutoSize = true;
            this.chkKeepShow.Checked = true;
            this.chkKeepShow.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkKeepShow.Location = new System.Drawing.Point(12, 279);
            this.chkKeepShow.Name = "chkKeepShow";
            this.chkKeepShow.Size = new System.Drawing.Size(252, 16);
            this.chkKeepShow.TabIndex = 4;
            this.chkKeepShow.Text = "Don\'t close this window after addition";
            this.chkKeepShow.UseVisualStyleBackColor = true;
            // 
            // txtItemRemark
            // 
            this.txtItemRemark.Location = new System.Drawing.Point(83, 120);
            this.txtItemRemark.Multiline = true;
            this.txtItemRemark.Name = "txtItemRemark";
            this.txtItemRemark.Size = new System.Drawing.Size(287, 138);
            this.txtItemRemark.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 1;
            this.label5.Text = "ItemRemark";
            // 
            // AddCostCalculateItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 320);
            this.Controls.Add(this.chkKeepShow);
            this.Controls.Add(this.cboItemStyle);
            this.Controls.Add(this.cboItemType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtItemRemark);
            this.Controls.Add(this.txtItemCost);
            this.Controls.Add(this.txtItemName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnAdd);
            this.Name = "AddCostCalculateItem";
            this.Text = "AddCostCalculateItem";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtItemName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboItemType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboItemStyle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtItemCost;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox chkKeepShow;
        private System.Windows.Forms.TextBox txtItemRemark;
        private System.Windows.Forms.Label label5;
    }
}