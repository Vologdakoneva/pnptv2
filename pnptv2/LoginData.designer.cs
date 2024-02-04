namespace pnptv
{
    partial class LoginData
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginData));
            this.btCancel = new System.Windows.Forms.Button();
            this.btLogin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.TextBox();
            this.userpassword = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.listbase = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btCancel
            // 
            this.btCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btCancel.Location = new System.Drawing.Point(325, 126);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(75, 23);
            this.btCancel.TabIndex = 0;
            this.btCancel.Text = "Отмена";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // btLogin
            // 
            this.btLogin.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btLogin.Location = new System.Drawing.Point(239, 126);
            this.btLogin.Name = "btLogin";
            this.btLogin.Size = new System.Drawing.Size(80, 23);
            this.btLogin.TabIndex = 1;
            this.btLogin.Text = "Войти";
            this.btLogin.UseVisualStyleBackColor = true;
            this.btLogin.Click += new System.EventHandler(this.btLogin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Имя пользователя";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Пароль";
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(117, 61);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(202, 20);
            this.username.TabIndex = 4;
            // 
            // userpassword
            // 
            this.userpassword.Location = new System.Drawing.Point(117, 87);
            this.userpassword.Name = "userpassword";
            this.userpassword.PasswordChar = '*';
            this.userpassword.Size = new System.Drawing.Size(202, 20);
            this.userpassword.TabIndex = 5;
            this.userpassword.Text = "masterkey";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(325, 6);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 21);
            this.button3.TabIndex = 6;
            this.button3.Text = "Настроить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // listbase
            // 
            this.listbase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.listbase.FormattingEnabled = true;
            this.listbase.Location = new System.Drawing.Point(49, 6);
            this.listbase.Name = "listbase";
            this.listbase.Size = new System.Drawing.Size(266, 21);
            this.listbase.TabIndex = 7;
            this.listbase.SelectedIndexChanged += new System.EventHandler(this.listbase_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "База:";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(114, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(238, 28);
            this.label4.TabIndex = 9;
            this.label4.Text = "Для входа в систему укажите имя пользователя и пароль";
            // 
            // LoginData
            // 
            this.AcceptButton = this.btLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btCancel;
            this.ClientSize = new System.Drawing.Size(414, 161);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listbase);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.userpassword);
            this.Controls.Add(this.username);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btLogin);
            this.Controls.Add(this.btCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginData";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Регистрация в системе";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button btLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.TextBox userpassword;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox listbase;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}