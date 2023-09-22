using System;
using System.Windows.Forms;

namespace Desk2
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Version 1", "Test", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }

}
