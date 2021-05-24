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
	public partial class AForm : Form
	{
		public AForm()
		{
			InitializeComponent();
			label1.Text = ("Список пользователей на" + " " + Convert.ToString(DateTime.Now));
		}

		private void AForm_Load(object sender, EventArgs e)
		{
			using (var db = new Sokolov_MobileCompanyEntities1())
			{
				var a = db.Users.Select(b =>
				new
				{
					ID = b.ID,
					Логин = b.Login,
					Пароль = b.Password
				}
				);
				dataGridView1.DataSource = a.ToList();
			}
		}

		private void reload_Click(object sender, EventArgs e)
		{
			dataGridView1.Refresh();
		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			using (var db = new Sokolov_MobileCompanyEntities1())
			{
				if (dataGridView1.SelectedRows.Count > 0)
				{
					int index = dataGridView1.SelectedRows[0].Index;
					int id = 0;
					bool converted = Int32.TryParse(dataGridView1[0, index].Value.ToString(), out id);
					if (converted == false)
						return;
					Users users = db.Users.Find(id);
					db.Users.Remove(users);
					db.SaveChanges();
					MessageBox.Show("Строка удалена успешно");
				}
			}
		}
	}
}

