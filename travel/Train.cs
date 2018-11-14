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
using System.Drawing.Printing;
namespace travel
{
    public partial class Train : Form
    {
        public Train()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 ss = new Form2();
            ss.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void printDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("Ticket ID :  " + textBox1.Text, new Font("Arial", 30, FontStyle.Regular), Brushes.Tomato, new Point(25, 400));
            e.Graphics.DrawString("SEAT NUMBER :  " + textBox4.Text, new Font("Arial", 30, FontStyle.Regular), Brushes.Tomato, new Point(25, 470));
            e.Graphics.DrawString("TOTAL COST:  " + textBox7.Text, new Font("Arial", 30, FontStyle.Regular), Brushes.Tomato, new Point(25, 540));
            e.Graphics.DrawString("Date Of journey :  " + dateTimePicker1.Text, new Font("Arial", 30, FontStyle.Regular), Brushes.Tomato, new Point(25, 640));
            e.Graphics.DrawString("DATE :  " + DateTime.Now, new Font("Arial", 30, FontStyle.Regular), Brushes.SeaGreen, new Point(25, 740));

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            printPreviewDialog.Document = printDocument;
            printPreviewDialog.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Trainmain ss = new Trainmain();
            ss.Show();
            this.Hide();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            Form2 ss = new Form2();
            ss.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        int decreaseTic()
        {


            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\travel\travel\travel\travel\travel.mdf;Integrated Security=True");
            con.Open();

            string qry = "select sum(tot_seat) from trncmpny where bogi_nmbr='" + comboBox6.Text + "'";
            SqlCommand sc = new SqlCommand(qry, con);
            {
                int x = Convert.ToInt32(textBox4.Text);
                //object result = sc.ExecuteScalar();
                //string z = Convert.ToString(result); ;
                int a = 0 + (Int32)sc.ExecuteScalar();
                //  int a = Convert.ToInt32(z);

                int totalAmount = a - x;
                // return totalAmount;
                return totalAmount;

            }
        }
        void updatetic()
        {

            int ja = decreaseTic();
            string n = ja.ToString();
            String cns = (@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\travel\travel\travel\travel\travel.mdf;Integrated Security=True");
            SqlConnection cn1 = new SqlConnection(cns);
            cn1.Open();
            SqlCommand cmd1 = new SqlCommand("update trncmpny set tot_seat='" + n + "' where bogi_nmbr='" + comboBox6.Text + "'", cn1);

            try
            {
                cmd1.ExecuteNonQuery();
                MessageBox.Show("updated :P");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

                cn1.Close();
            }
        }



        private void button1_Click(object sender, EventArgs e)
        {
            {
                int a = Convert.ToInt32(textBox6.Text);
                int b = Convert.ToInt32(textBox4.Text);
                double total = a * b;
                string z = Convert.ToString(total);
                textBox7.Text = z;
                String cns = (@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\travel\travel\travel\travel\travel.mdf;Integrated Security=True");
                SqlConnection cn1 = new SqlConnection(cns);
                cn1.Open();
                SqlCommand cmd1 = new SqlCommand("insert into trainTable(tic_nmbr,pass_name,gender,ph_nmbr,_date,st_time,froms,tos,tot_pass,seat_nmbr,tick_rate,tot_price,bogi_nmbr,train_name)Values('" + textBox1.Text + "','" + textBox2.Text + "','" + comboBox1.Text + "','" + textBox3.Text + "','" + dateTimePicker1.Text + "','" + comboBox2.Text + "','" + comboBox3.Text + "','" + comboBox4.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "','" + comboBox5.Text + "','" + comboBox6.Text + "')", cn1);

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
                updatetic();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            comboBox1.SelectedIndex = -1;
            textBox3.Text = "";
            dateTimePicker1.Text = "";
            comboBox2.SelectedIndex = -1;
            comboBox3.SelectedIndex = -1;
            comboBox4.SelectedIndex = -1;
           
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            comboBox5.SelectedIndex = -1;
            comboBox6.SelectedIndex = -1;
          
        }

        private void button9_Click(object sender, EventArgs e)
        {
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\travel\travel\travel\travel\travel.mdf;Integrated Security=True");
                con.Open();

                int a = Convert.ToInt32(textBox6.Text);
                int b = Convert.ToInt32(textBox4.Text);
                double total = a * b;
                string z = Convert.ToString(total);
                textBox7.Text = z;

                SqlCommand sc = new SqlCommand("update trainTable set pass_name='" + textBox2.Text + "',ph_number='" + textBox3.Text + "',_date='" + dateTimePicker1.Text + "',st_time='" + comboBox2.Text + "',tos='" + comboBox4.Text + "',tot_pass='" + textBox4.Text + "',seat_nmbr'" + textBox5.Text + "',tick_rate='" + textBox6.Text + "',tot_price='" + textBox7.Text + "' where tic_nmbr= '" + textBox1.Text + "' ", con);


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

        private void printPreviewDialog_Load(object sender, EventArgs e)
        {
            printPreviewDialog.Document = printDocument;
            printPreviewDialog.Show();
        }
    }
}
