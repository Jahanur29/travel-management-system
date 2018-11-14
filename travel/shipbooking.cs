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
    public partial class shipbooking : Form
    {
        public shipbooking()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 ss = new Form2();
            ss.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            ship ss = new ship();
            ss.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                int a = Convert.ToInt32(textBox5.Text);
                int b = Convert.ToInt32(textBox4.Text);
                double total = a * b;
                string z = Convert.ToString(total);
                textBox6.Text = z;
                String cns = (@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\travel\travel\travel\travel\travel.mdf;Integrated Security=True");
                SqlConnection cn1 = new SqlConnection(cns);
                cn1.Open();
                SqlCommand cmd1 = new SqlCommand("insert into shipTable(tick_nmbr,pass_name,gender,ph_nmbr,_date,st_time,froms,tos,tot_pass,cabin_qulty,tick_rate,tot_price,cabin_nmbr,ship_name)Values('" + textBox1.Text + "','" + textBox2.Text + "','" + comboBox1.Text + "','" + textBox3.Text + "','" + dateTimePicker1.Text + "','" + comboBox2.Text + "','" + comboBox3.Text + "','" + comboBox4.Text + "','" + textBox4.Text + "','" + comboBox5.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + comboBox6.Text + "','" + comboBox7.Text + "')", cn1);

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
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            dateTimePicker1.Text = "";
            textBox3.Text = "";
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
            comboBox3.SelectedIndex = -1;
            comboBox4.SelectedIndex = -1;
            textBox4.Text = "";
            comboBox5.SelectedIndex = -1;
            textBox5.Text = "";
            textBox6.Text = "";
            comboBox6.SelectedIndex = -1;
            comboBox7.SelectedIndex = -1;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\travel\travel\travel\travel\travel.mdf;Integrated Security=True");
                con.Open();

                int a = Convert.ToInt32(textBox5.Text);
                int b = Convert.ToInt32(textBox4.Text);
                double total = a * b;
                string z = Convert.ToString(total);
                textBox6.Text = z;

                SqlCommand sc = new SqlCommand("update shipTable set pass_name='" + textBox2.Text + "',ph_number='" + textBox3.Text + "',_date='" + dateTimePicker1.Text + "',st_time='" + comboBox2.Text + "',tos='" + comboBox4.Text + "',tot_pass='" + textBox4.Text + "',cabin_qulty'" + comboBox5.Text + "',tick_rate='" + textBox5.Text + "',tot_price='" + textBox6.Text + "',cabin_nmbr='" + comboBox6.Text+ "' where tn= '" + textBox1.Text + "' ", con);


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

        private void button4_Click(object sender, EventArgs e)
        {
            printPreviewDialog.Document = printDocument;
            printPreviewDialog.Show();
        }

        private void printPreviewDialog_Load(object sender, EventArgs e)
        {
            printPreviewDialog.Document = printDocument;
            printPreviewDialog.Show();
        }

        private void printDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
             //  Bitmap bmp = Properties.Resources.jambu_icon;

           // Image newImage = bmp;
          // e.Graphics.DrawImage(newImage, 25, 55, newImage.Width, newImage.Height);
            e.Graphics.DrawString("Ticket ID :  " + textBox1.Text, new Font("Arial", 30, FontStyle.Regular), Brushes.Tomato, new Point(25, 400));
            e.Graphics.DrawString("CABIN NUMBER :  " + comboBox6.Text, new Font("Arial", 30, FontStyle.Regular), Brushes.Tomato, new Point(25, 470));
            e.Graphics.DrawString("TOTAL COST:  " + textBox6.Text, new Font("Arial", 30, FontStyle.Regular), Brushes.Tomato, new Point(25, 540));
            e.Graphics.DrawString("Date Of journey :  " + dateTimePicker1.Text, new Font("Arial", 30, FontStyle.Regular), Brushes.Tomato, new Point(25, 640));
            e.Graphics.DrawString("DATE :  " + DateTime.Now, new Font("Arial", 30, FontStyle.Regular), Brushes.SeaGreen, new Point(25, 740));
        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        }
    }

