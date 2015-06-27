namespace PMICalculatorDll
{
    partial class InventoryGraphitePaper
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
            this.btnOK = new System.Windows.Forms.Button();
            this.lvData = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(233, 308);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(137, 53);
            this.btnOK.TabIndex = 3;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // lvData
            // 
            this.lvData.Location = new System.Drawing.Point(6, 14);
            this.lvData.Name = "lvData";
            this.lvData.Size = new System.Drawing.Size(364, 287);
            this.lvData.TabIndex = 2;
            this.lvData.UseCompatibleStateImageBehavior = false;
            this.lvData.DoubleClick += new System.EventHandler(this.btnOK_Click);
            // 
            // InventoryGraphitePaper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 375);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lvData);
            this.Name = "InventoryGraphitePaper";
            this.Text = "InventoryGraphitePaper";
            this.Load += new System.EventHandler(this.InventoryGraphitePaper_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.ListView lvData;
    }
}