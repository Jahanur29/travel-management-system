using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace travel
{
    public partial class ship : Form
    {
        public ship()
        {
            InitializeComponent();
        }

        private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void backToMainMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 ss = new Form2();
            ss.Show();
        }

        private void reservationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            shipbooking ss = new shipbooking();
            ss.Show();
        }

        private void driverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            shipdetails ss = new shipdetails();
            ss.Show();
        }

        private void viewAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            shipview ss = new shipview();
            ss.Show();
        }
    }
}
