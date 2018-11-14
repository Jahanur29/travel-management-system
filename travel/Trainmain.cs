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
    public partial class Trainmain : Form
    {
        public Trainmain()
        {
            InitializeComponent();
        }

        private void reservationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Train ss = new Train();
            ss.Show();
            this.Hide();
        }

        private void driverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Traindetails ss = new Traindetails();
            ss.Show();
            this.Hide();
        }

        private void busToolStripMenuItem_Click(object sender, EventArgs e)
        {
            trainstation ss = new trainstation();
            ss.Show();
            this.Hide();
        }

        private void backToMainMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 ss = new Form2();
            ss.Show();
        }

        private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void viewAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            trainview ss = new trainview();
            ss.Show();
        }
    }
}
