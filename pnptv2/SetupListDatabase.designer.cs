namespace pnptv
{
    partial class SetupListDatabase
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
            this.BtClose = new System.Windows.Forms.Button();
            this.listbase = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.btEdit = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtClose
            // 
            this.BtClose.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BtClose.Location = new System.Drawing.Point(413, 153);
            this.BtClose.Name = "BtClose";
            this.BtClose.Size = new System.Drawing.Size(75, 23);
            this.BtClose.TabIndex = 0;
            this.BtClose.Text = "Закрыть";
            this.BtClose.UseVisualStyleBackColor = true;
            // 
            // listbase
            // 
            this.listbase.FormattingEnabled = true;
            this.listbase.Items.AddRange(new object[] {
            "ылвоыовп жывывпыпв; sdgsdg"});
            this.listbase.Location = new System.Drawing.Point(25, 29);
            this.listbase.Name = "listbase";
            this.listbase.Size = new System.Drawing.Size(374, 147);
            this.listbase.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Подключенные базы";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(413, 29);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "Добавить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btEdit
            // 
            this.btEdit.Location = new System.Drawing.Point(413, 59);
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(75, 23);
            this.btEdit.TabIndex = 5;
            this.btEdit.Text = "Изменить";
            this.btEdit.UseVisualStyleBackColor = true;
            this.btEdit.Click += new System.EventHandler(this.btEdit_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(413, 89);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 6;
            this.button5.Text = "Удалить";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // SetupListDatabase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 200);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.btEdit);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listbase);
            this.Controls.Add(this.BtClose);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SetupListDatabase";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Настройка рабочих баз данных";
            this.Load += new System.EventHandler(this.SetupListDatabase_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtClose;
        private System.Windows.Forms.ListBox listbase;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btEdit;
        private System.Windows.Forms.Button button5;
    }
}