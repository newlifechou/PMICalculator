namespace PMICostCalculator
{
    partial class StatisticSheetsSelect
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
            this.dgvCostCalculateList = new System.Windows.Forms.DataGridView();
            this.Choosed = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Shipped = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.FileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UpdateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCostCalculateList)).BeginInit();
            this.SuspendLayout();
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
            this.Choosed,
            this.Shipped,
            this.FileName,
            this.CreateTime,
            this.UpdateTime});
            this.dgvCostCalculateList.Location = new System.Drawing.Point(12, 12);
            this.dgvCostCalculateList.MultiSelect = false;
            this.dgvCostCalculateList.Name = "dgvCostCalculateList";
            this.dgvCostCalculateList.ReadOnly = true;
            this.dgvCostCalculateList.RowHeadersWidth = 30;
            this.dgvCostCalculateList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvCostCalculateList.RowTemplate.Height = 23;
            this.dgvCostCalculateList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCostCalculateList.Size = new System.Drawing.Size(715, 402);
            this.dgvCostCalculateList.TabIndex = 9;
            // 
            // Choosed
            // 
            this.Choosed.HeaderText = "Choosed";
            this.Choosed.Name = "Choosed";
            this.Choosed.ReadOnly = true;
            // 
            // Shipped
            // 
            this.Shipped.HeaderText = "Shipped";
            this.Shipped.Name = "Shipped";
            this.Shipped.ReadOnly = true;
            // 
            // FileName
            // 
            this.FileName.HeaderText = "FileName";
            this.FileName.Name = "FileName";
            this.FileName.ReadOnly = true;
            // 
            // CreateTime
            // 
            this.CreateTime.HeaderText = "CreateTime";
            this.CreateTime.Name = "CreateTime";
            this.CreateTime.ReadOnly = true;
            // 
            // UpdateTime
            // 
            this.UpdateTime.HeaderText = "UpdateTime";
            this.UpdateTime.Name = "UpdateTime";
            this.UpdateTime.ReadOnly = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(546, 420);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(181, 42);
            this.button1.TabIndex = 10;
            this.button1.Text = "Statistic";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // StatisticSheetsSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 469);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvCostCalculateList);
            this.Name = "StatisticSheetsSelect";
            this.Text = "StatisticSheetsSelect";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCostCalculateList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCostCalculateList;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Choosed;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Shipped;
        private System.Windows.Forms.DataGridViewTextBoxColumn FileName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreateTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn UpdateTime;
        private System.Windows.Forms.Button button1;
    }
}