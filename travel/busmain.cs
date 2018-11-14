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
    public partial class busmain : Form
    {
        public busmain()
        {
            InitializeComponent();
        }

        private void editHelperListToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void helperEntryToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void helperToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ticketBookingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Bus ss = new Bus();
            ss.Show();
        }

        private void viewTicketToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.Hide();
            Bus ss = new Bus();
            ss.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 ss = new Form2();
            ss.Show();
        }

        private void busmain_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            airlines ss = new airlines();
            ss.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            view ss = new view();
            ss.Show();
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void driverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
           reservationdb ss = new reservationdb();
            ss.Show();
        }

        private void reservationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Bus ss = new Bus();
            ss.Show();
        }

        private void ticketBookingToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Bus ss = new Bus();
            ss.Show();
        }

        private void viewAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            view ss = new view();
            ss.Show();
        }

        private void helperToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
           
        }

        private void backToMainMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 ss = new Form2();
            ss.Show();
        }

        private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void busToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            busd ss = new busd();
            ss.Show();
        }

        private void ticketDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           
        }

        private void signOutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
    }
}
