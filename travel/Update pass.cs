using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace travel
{
    public partial class chngpass : Form
    {
        public chngpass()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\travel\travel\travel\travel\travel.mdf;Integrated Security=True");
            con.Open();

            SqlCommand sc = new SqlCommand("update login set pass='" + textBox4.Text + "' where mail= '" + textBox1.Text + "' ", con);


            try
            {
                sc.ExecuteNonQuery();
                MessageBox.Show("save");
                this.Hide();
                Form2 ss = new Form2();
                ss.Show();
            }
            catch
            {
                MessageBox.Show("error");
                con.Close();
            }

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
