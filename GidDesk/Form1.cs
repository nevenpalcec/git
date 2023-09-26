using System;
using System.Windows.Forms;

namespace GidDesk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var f = new Form2();
            f.Show();
        }
    }
}
