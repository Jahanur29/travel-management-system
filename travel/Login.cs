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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            //new Form2().Show();
            //this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Hide();
            chngpass ss = new chngpass();
            ss.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\travel\travel\travel\travel\travel.mdf;Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter(" Select Count (*) From login where mail = '" + textBox1.Text + "'  and pass ='" + textBox2.Text + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                this.Hide();
                Form2 ss = new Form2();
                ss.Show();
            }
            else
            {
                MessageBox.Show("Please check username and password.....");
            }
          }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

           /* this.Hide();
            Form2 ss = new Form2();
            ss.Show();*/
        }
        

       /* private void button2_Click(object sender, EventArgs e)
        {
            //Application.Exit();
        }*/
    }

