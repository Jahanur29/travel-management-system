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
    public partial class airlines : Form
    {
        public airlines()
        {
            InitializeComponent();
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
            planemain ss = new planemain();
            ss.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
            String cns = (@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\travel\travel\travel\travel\travel.mdf;Integrated Security=True");
            SqlConnection cn1 = new SqlConnection(cns);
            cn1.Open();

            SqlCommand cmd1 = new SqlCommand("insert into arlTable(a_name,p_nmbr,pln_nmbr,tot_seat,st_time,route,_date)Values('" + comboBox1.Text + "','" + textBox1.Text + "','" + comboBox2.Text + "','" + textBox2.Text + "','" + comboBox3.Text + "','" + comboBox4.Text + "','" + dateTimePicker2.Text + "')", cn1);

            try
            {
                cmd1.ExecuteNonQuery();
                MessageBox.Show("Successfully Saved");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

                cn1.Close();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            comboBox2.SelectedIndex = -1;
            textBox1.Text = "";
            textBox2.Text = "";
            comboBox1.SelectedIndex = -1;
            comboBox4.SelectedIndex = -1;
            comboBox3.SelectedIndex = -1;
            dateTimePicker2.Text = "";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string cns = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\travel\travel\travel\travel\travel.mdf;Integrated Security=True";

            SqlConnection con = new SqlConnection(cns);
            //cn1.Open();

            con.Open();
            SqlDataAdapter sa = new SqlDataAdapter("select *from arlTable where a_name='" + comboBox1.Text + "'", con);
            DataTable data1 = new DataTable();
            sa.Fill(data1);
            dataGridView1.DataSource = data1;
            con.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            SqlConnection cn1 = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\travel\travel\travel\travel\travel.mdf;Integrated Security=True");
            cn1.Open();
            SqlCommand cmd = new SqlCommand("delete from arlTable where  a_name='" + comboBox1.Text + "'", cn1);


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

        private void button5_Click(object sender, EventArgs e)
        {
            {
               
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
