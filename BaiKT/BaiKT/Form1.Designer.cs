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
			label1 = new Label();
			txtmatkhau = new TextBox();
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
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(104, 193);
			label1.Name = "label1";
			label1.Size = new Size(70, 20);
			label1.TabIndex = 2;
			label1.Text = "mật khẩu";
			// 
			// txtmatkhau
			// 
			txtmatkhau.Location = new Point(224, 186);
			txtmatkhau.Name = "txtmatkhau";
			txtmatkhau.Size = new Size(251, 27);
			txtmatkhau.TabIndex = 3;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(txtmatkhau);
			Controls.Add(label1);
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
		private Label label1;
		private TextBox txtmatkhau;
	}
}
