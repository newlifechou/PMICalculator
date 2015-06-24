namespace PMICostCalculator
{
    partial class OpenCostCalcuationSheet
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
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lvFileList = new System.Windows.Forms.ListView();
            this.btnOpenWorkDirectory = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(448, 294);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(122, 38);
            this.btnOpen.TabIndex = 1;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(303, 295);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(122, 38);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lvFileList
            // 
            this.lvFileList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvFileList.FullRowSelect = true;
            this.lvFileList.Location = new System.Drawing.Point(13, 14);
            this.lvFileList.MultiSelect = false;
            this.lvFileList.Name = "lvFileList";
            this.lvFileList.Size = new System.Drawing.Size(559, 273);
            this.lvFileList.TabIndex = 2;
            this.lvFileList.UseCompatibleStateImageBehavior = false;
            this.lvFileList.View = System.Windows.Forms.View.Details;
            this.lvFileList.DoubleClick += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnOpenWorkDirectory
            // 
            this.btnOpenWorkDirectory.Location = new System.Drawing.Point(13, 293);
            this.btnOpenWorkDirectory.Name = "btnOpenWorkDirectory";
            this.btnOpenWorkDirectory.Size = new System.Drawing.Size(159, 38);
            this.btnOpenWorkDirectory.TabIndex = 1;
            this.btnOpenWorkDirectory.Text = "OpenWorkDirecotory";
            this.btnOpenWorkDirectory.UseVisualStyleBackColor = true;
            this.btnOpenWorkDirectory.Click += new System.EventHandler(this.btnOpenWorkDirectory_Click);
            // 
            // OpenCostCalcuationSheet
            // 
            this.AcceptButton = this.btnOpen;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 345);
            this.Controls.Add(this.lvFileList);
            this.Controls.Add(this.btnOpenWorkDirectory);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnOpen);
            this.Name = "OpenCostCalcuationSheet";
            this.Text = "OpenCostCalcuationSheet";
            this.Load += new System.EventHandler(this.OpenCostCalcuate_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ListView lvFileList;
        private System.Windows.Forms.Button btnOpenWorkDirectory;
    }
}