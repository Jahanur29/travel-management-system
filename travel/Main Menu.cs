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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Bus ss = new Bus();
            ss.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Plane ss = new Plane();
            ss.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Train ss = new Train();
            ss.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Form9 ss = new Form9();
            //ss.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            busmain bm = new busmain();
            bm.Show();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            chngpass ss = new chngpass();
            ss.Show();
        }

        private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button7_Click(object sender, EventArgs e)
        {

            planemain ss = new planemain();
            ss.Show();
            this.Hide();

        }

        private void contactNumberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            contact ss = new contact();
            ss.Show();
            this.Hide();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            Trainmain ss = new Trainmain();
            ss.Show();
            this.Hide();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            ship ss = new ship();
            ss.Show();
        }
    }
}
