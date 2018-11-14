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
    public partial class planemain : Form
    {
        public planemain()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            airlines ss = new airlines();
            ss.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Plane ss = new Plane();
            ss.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {

            this.Hide();
            Form2 ss = new Form2();
            ss.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            fligthdtl ss = new fligthdtl();
            ss.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            planeview ss = new planeview();
            ss.Show();
        }
    }
}
