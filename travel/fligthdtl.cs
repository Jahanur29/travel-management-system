﻿using System;
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
    public partial class fligthdtl : Form
    {
        public fligthdtl()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            planemain ss = new planemain();
            ss.Show();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 ss = new Form2();
            ss.Show();
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            string cns = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\travel\travel\travel\travel\travel.mdf;Integrated Security=True";

            SqlConnection con = new SqlConnection(cns);
            //cn1.Open();

            con.Open();
            SqlDataAdapter sa = new SqlDataAdapter("select *from planTable where tick_nm='" + textBox1.Text + "'or pas_nme='" + textBox2.Text + "' or  _date='" + dateTimePicker1.Text + "' or flt_nm='" + comboBox3.Text + "'or air_nam='" + comboBox2.Text + "'", con);
            DataTable data1 = new DataTable();
            sa.Fill(data1);
            dataGridView1.DataSource = data1;
            con.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            SqlConnection cn1 = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\travel\travel\travel\travel\travel.mdf;Integrated Security=True");
            cn1.Open();
            SqlCommand cmd = new SqlCommand("delete from planTable where flt_nm='" + comboBox3.Text + "'", cn1);


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

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            dateTimePicker1.Text = "";
            comboBox2.Text = "";
            comboBox3.Text = "";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string cns = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\travel\travel\travel\travel\travel.mdf;Integrated Security=True";

                SqlConnection con = new SqlConnection(cns);
                con.Open();
                string qry = "select sum(tot_pass) from planTable where _date='" + dateTimePicker1.Text + "' and air_nam= '" + comboBox2.Text + "'";
                SqlCommand sc = new SqlCommand(qry, con);
                {
                    //object result = sc.ExecuteScalar();
                    //string z = Convert.ToString(result); ;
                    int a = 0 + (Int32)sc.ExecuteScalar();
                    textBox3.Text = a.ToString();


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }
    }
}
