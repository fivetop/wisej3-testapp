using System;
using Wisej.Web;


namespace testapp
{
    public partial class Page1 : Page
    {
        public Page1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Page2 p2 = new Page2();

            panel1.Controls.Add(p2);

            p2.Show();
        }

        private void panel1_PanelCollapsed(object sender, EventArgs e)
        {

        }
    }
}
