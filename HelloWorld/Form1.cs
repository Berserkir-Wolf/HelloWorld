using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloWorld
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox box = new AboutBox();
            box.ShowDialog();
        }

        private void buttonWording_Click(object sender, EventArgs e)
        {
            if (labelMessage.Text == "Hello World!")
            {
                labelMessage.Text = "Goodbye World!";
            }
            else
            {
                labelMessage.Text = "Hello World!";
            }
        }

        private void buttonBold_Click(object sender, EventArgs e)
        {
            if (labelMessage.Font.Bold)
            {
                labelMessage.Font = new Font(labelMessage.Font, FontStyle.Bold);
            }
            else
            {
                labelMessage.Font = new Font(labelMessage.Font, FontStyle.Regular);
            }

        }


        private void buttonTitle_Click(object sender, EventArgs e)
        {
            this.Text = "New title";
        }
    }
}
