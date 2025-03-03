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
			SuspendLayout();
			// 
			// lblUsername
			// 
			lblUsername.AutoSize = true;
			lblUsername.Location = new Point(102, 141);
			lblUsername.Name = "lblUsername";
			lblUsername.Size = new Size(75, 20);
			lblUsername.TabIndex = 0;
			lblUsername.Text = "Username";
			// 
			// txtUserName
			// 
			txtUserName.Location = new Point(195, 138);
			txtUserName.Name = "txtUserName";
			txtUserName.Size = new Size(251, 27);
			txtUserName.TabIndex = 1;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
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
	}
}
