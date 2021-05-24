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
	public partial class AdminPass : Form
	{
		public AdminPass()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (textBox1.Text == "1234")
			{
				MessageBox.Show("Добро пожаловать в админ-панель");
				Form f4 = new AForm();
				f4.Show();
				this.Hide();
			}
			else
				MessageBox.Show("Неверный пароль");
		}
	}
}
