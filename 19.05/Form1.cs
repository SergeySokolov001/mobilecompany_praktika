using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _19._05
{
	public partial class LoginForm : Form
	{
		public LoginForm()
		{
			InitializeComponent();
		}

		private void Log_Click(object sender, EventArgs e)
		{
			using (var db = new Sokolov_MobileCompanyEntities1())
			{
				var resultsearch = db.Users.FirstOrDefault(item => item.Login == textBox1.Text && item.Password == textBox2.Text);

				if (resultsearch != null)
				{
					MessageBox.Show("Успешный вход," + " " + resultsearch.Login);
					Form f2 = new UserForm();
					f2.Show();
					this.Hide();
				}
				else
				{
					MessageBox.Show("Неудачный вход. Проверьте правильность ввода данных или пройдите регистрацию");
				}
			}
		}

		private void Reg_Click(object sender, EventArgs e)
		{
			

		}

		private void APanelButton_Click(object sender, EventArgs e)
		{
			Form f3 = new AdminPass();
			f3.Show();
			this.Hide();
		}
	}
}
