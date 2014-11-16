namespace RssReader
{
    partial class frmMain
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
            this.btnLoadRssData = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLoadRssData
            // 
            this.btnLoadRssData.Location = new System.Drawing.Point(12, 12);
            this.btnLoadRssData.Name = "btnLoadRssData";
            this.btnLoadRssData.Size = new System.Drawing.Size(139, 23);
            this.btnLoadRssData.TabIndex = 0;
            this.btnLoadRssData.Text = "Load rss data";
            this.btnLoadRssData.UseVisualStyleBackColor = true;
            this.btnLoadRssData.Click += new System.EventHandler(this.btnLoadRssData_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 377);
            this.Controls.Add(this.btnLoadRssData);
            this.Name = "frmMain";
            this.Text = "RssReader";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLoadRssData;
    }
}

