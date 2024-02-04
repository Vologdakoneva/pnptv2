namespace pnptv
{
    partial class fShowInMonior
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
            this.webBrowsers = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // webBrowsers
            // 
            this.webBrowsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowsers.Location = new System.Drawing.Point(0, 0);
            this.webBrowsers.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowsers.Name = "webBrowsers";
            this.webBrowsers.Size = new System.Drawing.Size(800, 450);
            this.webBrowsers.TabIndex = 0;
            // 
            // fShowInMonior
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.webBrowsers);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fShowInMonior";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Показ на мониторе";
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.WebBrowser webBrowsers;
    }
}