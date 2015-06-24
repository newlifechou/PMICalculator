namespace PMICostCalculator
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.settingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.languageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.englishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.简体中文ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCostCaculateName = new System.Windows.Forms.TextBox();
            this.btnDelCost = new System.Windows.Forms.Button();
            this.btnAddCost = new System.Windows.Forms.Button();
            this.dgvCostCalculateList = new System.Windows.Forms.DataGridView();
            this.ItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemStyle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemRemark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnViewBrief = new System.Windows.Forms.Button();
            this.txtTotalCost = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRemark = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCostCalculateList)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.toolToolStripMenuItem,
            this.languageToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.toolStripMenuItem1,
            this.settingToolStripMenuItem,
            this.toolStripMenuItem2,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.fileToolStripMenuItem.Text = " File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(108, 6);
            // 
            // settingToolStripMenuItem
            // 
            this.settingToolStripMenuItem.Name = "settingToolStripMenuItem";
            this.settingToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.settingToolStripMenuItem.Text = "Setting";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(108, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // toolToolStripMenuItem
            // 
            this.toolToolStripMenuItem.Name = "toolToolStripMenuItem";
            this.toolToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.toolToolStripMenuItem.Text = "Tool";
            // 
            // languageToolStripMenuItem
            // 
            this.languageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.englishToolStripMenuItem,
            this.简体中文ToolStripMenuItem});
            this.languageToolStripMenuItem.Name = "languageToolStripMenuItem";
            this.languageToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.languageToolStripMenuItem.Text = "Language";
            // 
            // englishToolStripMenuItem
            // 
            this.englishToolStripMenuItem.Checked = true;
            this.englishToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.englishToolStripMenuItem.Name = "englishToolStripMenuItem";
            this.englishToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.englishToolStripMenuItem.Text = "English";
            this.englishToolStripMenuItem.Click += new System.EventHandler(this.LanguageSwitch);
            // 
            // 简体中文ToolStripMenuItem
            // 
            this.简体中文ToolStripMenuItem.Name = "简体中文ToolStripMenuItem";
            this.简体中文ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.简体中文ToolStripMenuItem.Text = "简体中文";
            this.简体中文ToolStripMenuItem.Click += new System.EventHandler(this.LanguageSwitch);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 587);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(784, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.BackColor = System.Drawing.Color.Transparent;
            this.toolStripStatusLabel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(67, 17);
            this.toolStripStatusLabel1.Text = "状态栏信息";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "CostCalcualteSheet";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtCostCaculateName
            // 
            this.txtCostCaculateName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCostCaculateName.BackColor = System.Drawing.Color.White;
            this.txtCostCaculateName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCostCaculateName.Location = new System.Drawing.Point(136, 30);
            this.txtCostCaculateName.Name = "txtCostCaculateName";
            this.txtCostCaculateName.ReadOnly = true;
            this.txtCostCaculateName.Size = new System.Drawing.Size(353, 20);
            this.txtCostCaculateName.TabIndex = 3;
            // 
            // btnDelCost
            // 
            this.btnDelCost.Location = new System.Drawing.Point(111, 111);
            this.btnDelCost.Name = "btnDelCost";
            this.btnDelCost.Size = new System.Drawing.Size(75, 25);
            this.btnDelCost.TabIndex = 10;
            this.btnDelCost.Text = "Delete";
            this.btnDelCost.UseVisualStyleBackColor = true;
            this.btnDelCost.Click += new System.EventHandler(this.btnDelCost_Click);
            // 
            // btnAddCost
            // 
            this.btnAddCost.Location = new System.Drawing.Point(20, 111);
            this.btnAddCost.Name = "btnAddCost";
            this.btnAddCost.Size = new System.Drawing.Size(75, 25);
            this.btnAddCost.TabIndex = 9;
            this.btnAddCost.Text = "Add";
            this.btnAddCost.UseVisualStyleBackColor = true;
            this.btnAddCost.Click += new System.EventHandler(this.btnAddCost_Click);
            // 
            // dgvCostCalculateList
            // 
            this.dgvCostCalculateList.AllowUserToAddRows = false;
            this.dgvCostCalculateList.AllowUserToDeleteRows = false;
            this.dgvCostCalculateList.AllowUserToResizeRows = false;
            this.dgvCostCalculateList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCostCalculateList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCostCalculateList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemName,
            this.ItemType,
            this.ItemStyle,
            this.ItemCost,
            this.ItemRemark});
            this.dgvCostCalculateList.Location = new System.Drawing.Point(18, 142);
            this.dgvCostCalculateList.MultiSelect = false;
            this.dgvCostCalculateList.Name = "dgvCostCalculateList";
            this.dgvCostCalculateList.ReadOnly = true;
            this.dgvCostCalculateList.RowHeadersWidth = 30;
            this.dgvCostCalculateList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvCostCalculateList.RowTemplate.Height = 23;
            this.dgvCostCalculateList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCostCalculateList.Size = new System.Drawing.Size(750, 388);
            this.dgvCostCalculateList.TabIndex = 8;
            // 
            // ItemName
            // 
            this.ItemName.DataPropertyName = "ItemName";
            this.ItemName.HeaderText = "ItemName";
            this.ItemName.Name = "ItemName";
            this.ItemName.ReadOnly = true;
            this.ItemName.Width = 250;
            // 
            // ItemType
            // 
            this.ItemType.DataPropertyName = "ItemType";
            this.ItemType.HeaderText = "ItemType";
            this.ItemType.Name = "ItemType";
            this.ItemType.ReadOnly = true;
            this.ItemType.Width = 200;
            // 
            // ItemStyle
            // 
            this.ItemStyle.DataPropertyName = "ItemStyle";
            this.ItemStyle.HeaderText = "ItemStyle";
            this.ItemStyle.Name = "ItemStyle";
            this.ItemStyle.ReadOnly = true;
            this.ItemStyle.Width = 150;
            // 
            // ItemCost
            // 
            this.ItemCost.DataPropertyName = "ItemCost";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle1.Format = "N2";
            dataGridViewCellStyle1.NullValue = "-";
            this.ItemCost.DefaultCellStyle = dataGridViewCellStyle1;
            this.ItemCost.HeaderText = "ItemCost";
            this.ItemCost.Name = "ItemCost";
            this.ItemCost.ReadOnly = true;
            // 
            // ItemRemark
            // 
            this.ItemRemark.DataPropertyName = "ItemRemark";
            this.ItemRemark.HeaderText = "ItemRemark";
            this.ItemRemark.Name = "ItemRemark";
            this.ItemRemark.ReadOnly = true;
            this.ItemRemark.Width = 550;
            // 
            // btnViewBrief
            // 
            this.btnViewBrief.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnViewBrief.Location = new System.Drawing.Point(369, 536);
            this.btnViewBrief.Name = "btnViewBrief";
            this.btnViewBrief.Size = new System.Drawing.Size(141, 41);
            this.btnViewBrief.TabIndex = 11;
            this.btnViewBrief.Text = "ViewBrief";
            this.btnViewBrief.UseVisualStyleBackColor = true;
            this.btnViewBrief.Click += new System.EventHandler(this.btnViewBrief_Click);
            // 
            // txtTotalCost
            // 
            this.txtTotalCost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTotalCost.BackColor = System.Drawing.Color.White;
            this.txtTotalCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotalCost.Font = new System.Drawing.Font("SimSun", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtTotalCost.ForeColor = System.Drawing.Color.Red;
            this.txtTotalCost.Location = new System.Drawing.Point(557, 537);
            this.txtTotalCost.Name = "txtTotalCost";
            this.txtTotalCost.ReadOnly = true;
            this.txtTotalCost.Size = new System.Drawing.Size(211, 38);
            this.txtTotalCost.TabIndex = 12;
            this.txtTotalCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(516, 550);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Total";
            // 
            // txtRemark
            // 
            this.txtRemark.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRemark.BackColor = System.Drawing.Color.White;
            this.txtRemark.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRemark.Location = new System.Drawing.Point(136, 58);
            this.txtRemark.Multiline = true;
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.ReadOnly = true;
            this.txtRemark.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtRemark.Size = new System.Drawing.Size(632, 50);
            this.txtRemark.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Remark";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(784, 609);
            this.Controls.Add(this.txtTotalCost);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnViewBrief);
            this.Controls.Add(this.btnDelCost);
            this.Controls.Add(this.btnAddCost);
            this.Controls.Add(this.dgvCostCalculateList);
            this.Controls.Add(this.txtRemark);
            this.Controls.Add(this.txtCostCaculateName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(600, 430);
            this.Name = "MainForm";
            this.Text = "PMICostCalculator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCostCalculateList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem languageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem englishToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 简体中文ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripMenuItem settingToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCostCaculateName;
        private System.Windows.Forms.Button btnDelCost;
        private System.Windows.Forms.Button btnAddCost;
        private System.Windows.Forms.DataGridView dgvCostCalculateList;
        private System.Windows.Forms.Button btnViewBrief;
        private System.Windows.Forms.TextBox txtTotalCost;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemType;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemStyle;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemRemark;
        private System.Windows.Forms.TextBox txtRemark;
        private System.Windows.Forms.Label label3;
    }
}

