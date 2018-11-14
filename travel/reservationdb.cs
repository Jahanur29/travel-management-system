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
    public partial class reservationdb : Form
    {
        public reservationdb()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 ss = new Form2();
            ss.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            busmain ss = new busmain();
            ss.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string cns = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\travel\travel\travel\travel\travel.mdf;Integrated Security=True";

            SqlConnection con = new SqlConnection(cns);
            //cn1.Open();

            con.Open();
            SqlDataAdapter sa = new SqlDataAdapter("select *from bTable where  _date='" + dateTimePicker1.Text + "'or p_name='" + textBox1.Text + "' or b_num='" + comboBox3.Text + "' or b_name='" + comboBox1.Text + "'", con);
            DataTable data1 = new DataTable();
            sa.Fill(data1);
            dataGridView1.DataSource = data1;
            con.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
          
            textBox1.Text = "";
            textBox2.Text = "";
            dateTimePicker1.Text = "";
            comboBox3.Text = "";

            comboBox1.Text = "";
            textBox3.Text = "";
            
        }

        private void button8_Click(object sender, EventArgs e)
        {
            SqlConnection cn1 = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\travel\travel\travel\travel\travel.mdf;Integrated Security=True");
            cn1.Open();
            SqlCommand cmd = new SqlCommand("delete from bTable where t_no='" + textBox1.Text + "'", cn1);


            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("delete");
            }
            catch
            {
                MessageBox.Show("error");
                cn1.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try{
                string cns = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\travel\travel\travel\travel\travel.mdf;Integrated Security=True";

                SqlConnection con = new SqlConnection(cns);
                con.Open();
                string qry = "select sum(t_pass) from bTable where _date='" + dateTimePicker1.Text + "' and b_num= '" + comboBox3.Text + "'";
                SqlCommand sc = new SqlCommand(qry, con);
                {
                    //object result = sc.ExecuteScalar();
                    //string z = Convert.ToString(result); ;
                    int a = 0 + (Int32)sc.ExecuteScalar();
                    textBox3.Text = a.ToString();

                   
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
               
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            string cns = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\travel\travel\travel\travel\travel.mdf;Integrated Security=True";

            SqlConnection con = new SqlConnection(cns);
            //cn1.Open();

            con.Open();
            SqlDataAdapter sa = new SqlDataAdapter("select *from bTable where  _date='" + dateTimePicker1.Text + "' and b_num='" + comboBox3.Text + "' ", con);
            DataTable data1 = new DataTable();
            sa.Fill(data1);
            dataGridView1.DataSource = data1;
            con.Close();
        }
        }
    }

