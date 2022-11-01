
using System;
using Wisej.Web;

namespace ts_page
{
	public partial class Page1 : Page
	{
		public Page1()
		{
			InitializeComponent();
		}

        private void button1_Click(object sender, EventArgs e)
        {
			//UserControl2 u1 = new UserControl2();
			//panel1.Controls.Add(u1);
			//u1.Show();

			u1.Show();
			u2.Hide();
			u1.Dock = DockStyle.Fill;
		}

		private void button2_Click(object sender, EventArgs e)
        {
			u1.Hide();
			u2.Show();
			u2.Dock = DockStyle.Fill;
		}

		// page error
		private void button3_Click(object sender, EventArgs e)
        {
			Page2 p2 = new Page2();
			panel1.Controls.Add(p2);
			p2.Show();

		}


		// usercontrol OK 
		UserControl1 u1 = new UserControl1();
		UserControl2 u2 = new UserControl2();
        private void Page1_Load(object sender, EventArgs e)
        {
			panel1.Controls.Add(u1);
			panel1.Controls.Add(u2);
			u1.Show();
			u2.Show();
			u1.Hide();

		}
	}
}
