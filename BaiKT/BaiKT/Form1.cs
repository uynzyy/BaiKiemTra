using System;
using System.Windows.Forms;

namespace BaiKT
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			btnLogin.Click += BtnLogin_Click;
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			// Xử lý khi Form1 được load
		}

		private void lblusername_Click(object sender, EventArgs e)
		{
			// Xử lý khi nhấn vào label Username (nếu cần)
		}

		private void textboxusername_TextChanged(object sender, EventArgs e)
		{
			// Xử lý khi thay đổi nội dung TextBox Username (nếu cần)
		}

		private void BtnLogin_Click(object? sender, EventArgs e)
		{
			string username = textboxusername.Text;
			string password = textboxmatkhau.Text;

			if (username == "admin" && password == "admin")
			{
				MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
				this.Hide();
				Form2 form2 = new Form2();
				form2.ShowDialog();
				this.Show();
			}
			else
			{
				MessageBox.Show("Sai tài khoản hoặc mật khẩu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
	}
}
