using System;
using System.Drawing;
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
            // This one calls a function, defined at the end of this file.
            CloseApp();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // This is link to the "About" button under the help menu.
            // It was attached by double-clicking the item after creating it.
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
            if (labelMessage.Font.Bold) // Is it bold?
            {
                labelMessage.Font = new Font(labelMessage.Font, FontStyle.Regular); // Yes? Make it regular
            }
            else
            {
                labelMessage.Font = new Font(labelMessage.Font, FontStyle.Bold); // No? Make it so.
            }

        }

        private void buttonTitle_Click(object sender, EventArgs e)
        {
            // this.Text refers to the text in the title of the window. 
            // If we wanted, we could set that on load by adding the option directly below "InitializeComponent"
            this.Text = "New title";
        }

        private void CloseApp()
        {
            // This is a function.
            // It doesn't have to return anything, so it's void.
            // It only applies to this Form specifically, so it's private.
            // We'd add another arbitrary cs file to define "public" items.
            // If it needed to return a string, it would be private string name()
            // If it took argument/variables, they'd be defined in the brackets like so:
            // private bool function(string arg1, string arg2)
            Application.Exit();
        }
    }
}
