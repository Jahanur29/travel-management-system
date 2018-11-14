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
    public partial class busd : Form
    {
        public busd()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            busmain ss = new busmain();
            ss.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 ss = new Form2();
            ss.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String cns = (@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\travel\travel\travel\travel\travel.mdf;Integrated Security=True");
            SqlConnection cn1 = new SqlConnection(cns);
            cn1.Open();
            SqlCommand cmd1 = new SqlCommand("insert into busscmpny(buscmpny_nm,ph_nm,bus_nm,tot_seat,route,strtime,_date)Values('" + comboBox1.Text + "','" + textBox2.Text + "','" + comboBox3.Text + "','" + textBox4.Text + "','" + comboBox2.Text + "','" + comboBox4.Text + "','" + dateTimePicker1.Text + "')", cn1);

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
            
            comboBox1.SelectedIndex = -1;
            textBox2.Text = "";
            comboBox3.Text = "";
            textBox4.Text = "";
            comboBox2.SelectedIndex = -1;
            comboBox3.SelectedIndex = -1;
            comboBox4.SelectedIndex = -1;
            dateTimePicker1.Text = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\travel\travel\travel\travel\travel.mdf;Integrated Security=True");
                con.Open();
                SqlCommand sc = new SqlCommand("update busscmpny set ph_nm='" + textBox2.Text + "',bus_nm='" + comboBox3.Text + "',route= '" + comboBox2.Text + "',strtime= '" + comboBox4.Text + "',_date'" + dateTimePicker1.Text + "' where buscmpny_nm= '" + comboBox1.Text + "' ", con);
                try
                {
                    sc.ExecuteNonQuery();
                    MessageBox.Show("save");
                }
                catch
                {
                    MessageBox.Show("error");
                    con.Close();
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string cns = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\travel\travel\travel\travel\travel.mdf;Integrated Security=True";

            SqlConnection con = new SqlConnection(cns);
            //cn1.Open();

            con.Open();
            SqlDataAdapter sa = new SqlDataAdapter("select *from busscmpny where buscmpny_nm='" + comboBox1.Text + "'", con);
            DataTable data1 = new DataTable();
            sa.Fill(data1);
            dataGridView1.DataSource = data1;
            con.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\travel\travel\travel\travel\travel.mdf;Integrated Security=True");

            con.Open();
            // SqlDataAdapter sa = new SqlDataAdapter("delete from IT where Student_ID='" + textBox1.Text + "'", con);
            SqlCommand sc = new SqlCommand("delete from busscmpny where buscmpny_nm='" + comboBox1.Text + "'", con);
            sc.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Delete SuccesFully!!!!  ");
        }
    }
}
