namespace BaiKT
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			lblUsername = new Label();
			txtUserName = new TextBox();
			lblPassword = new Label();
			txtPassword = new TextBox();
			btnLogin = new Button();
			SuspendLayout();
			// 
			// lblUsername
			// 
			lblUsername.AutoSize = true;
			lblUsername.Location = new Point(102, 141);
			lblUsername.Name = "lblUsername";
			lblUsername.Size = new Size(105, 20);
			lblUsername.TabIndex = 0;
			lblUsername.Text = "tên đăng nhập";
			// 
			// txtUserName
			// 
			txtUserName.Location = new Point(224, 138);
			txtUserName.Name = "txtUserName";
			txtUserName.Size = new Size(251, 27);
			txtUserName.TabIndex = 1;
			// 
			// lblPassword
			// 
			lblPassword.AutoSize = true;
			lblPassword.Location = new Point(104, 193);
			lblPassword.Name = "lblPassword";
			lblPassword.Size = new Size(70, 20);
			lblPassword.TabIndex = 2;
			lblPassword.Text = "Password";
			// 
			// txtPassword
			// 
			txtPassword.Location = new Point(224, 186);
			txtPassword.Name = "txtPassword";
			txtPassword.Size = new Size(251, 27);
			txtPassword.TabIndex = 3;
			// 
			// btnLogin
			// 
			btnLogin.Location = new Point(278, 254);
			btnLogin.Name = "btnLogin";
			btnLogin.Size = new Size(148, 59);
			btnLogin.TabIndex = 4;
			btnLogin.Text = "Đăng nhập";
			btnLogin.UseVisualStyleBackColor = true;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(btnLogin);
			Controls.Add(txtPassword);
			Controls.Add(lblPassword);
			Controls.Add(txtUserName);
			Controls.Add(lblUsername);
			Name = "Form1";
			Text = "Form1";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label lblUsername;
		private TextBox txtUserName;
		private Label lblPassword;
		private TextBox txtPassword;
		private Button btnLogin;
	}
}
