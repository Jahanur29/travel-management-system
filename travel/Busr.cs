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
    public partial class Bus : Form
    {
        public Bus()
        {
            InitializeComponent();
        }
     
        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 ss = new Form2();
            ss.Show();
        }




        int decreaseTic()
        {


            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\travel\travel\travel\travel\travel.mdf;Integrated Security=True");
            con.Open();

            string qry = "select sum(tot_seat) from busscmpny where bus_nm='" +comboBox5.Text + "'";
            SqlCommand sc = new SqlCommand(qry, con);
            {
                int x = Convert.ToInt32(textBox8.Text);
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
            SqlCommand cmd1 = new SqlCommand("update busscmpny set tot_seat='" + n + "' where bus_nm='" + comboBox5.Text + "'", cn1);

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
               int a = Convert.ToInt32(textBox10.Text);
                int b = Convert.ToInt32(textBox8.Text);
                double total = a * b;
                string z = Convert.ToString(total);
                textBox11.Text = z;
                String cns = (@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\travel\travel\travel\travel\travel.mdf;Integrated Security=True");
                SqlConnection cn1 = new SqlConnection(cns);
                cn1.Open();
                SqlCommand cmd1 = new SqlCommand("insert into bTable(t_no,p_name,gender,ph_number,_date,start_time,fromss,tos,t_pass,seat_num,tick_price,t_price,b_num,b_name)Values('" + textBox1.Text + "','" + textBox2.Text + "','" + comboBox1.Text + "','" + textBox3.Text + "','" + dateTimePicker1.Text + "','" + comboBox4.Text + "','" + comboBox2.Text + "','" + comboBox3.Text + "','" + textBox8.Text + "','" + textBox4.Text + "','" + textBox10.Text + "','" + textBox11.Text + "','" + comboBox5.Text + "','" + comboBox6.Text + "')", cn1);
    
                try
                {
                    cmd1.ExecuteNonQuery();
                    MessageBox.Show("Successfully Saved");
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                   
                 cn1.Close();
                }

                updatetic();
                
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            planeview ss = new planeview();
            ss.Show();
        }

      
       
        private void printPreviewControl1_Click(object sender, EventArgs e)
        {

        }

       
        private void button6_Click_1(object sender, EventArgs e)
        {
           busmain ss = new busmain();
            ss.Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\travel\travel\travel\travel\travel.mdf;Integrated Security=True");
                con.Open();

                int a = Convert.ToInt32(textBox10.Text);
                int b = Convert.ToInt32(textBox8.Text);
                double total = a * b;
                string z = Convert.ToString(total);
                textBox11.Text = z;

                SqlCommand sc = new SqlCommand("update bTable set p_name='" + textBox2.Text + "',_date='" + dateTimePicker1.Text + "',start_time='" + comboBox4.Text + "',tos='" + comboBox3.Text + "',t_pass='" + textBox8.Text + "',seat_num'" + textBox4.Text + "',tick_price='" + textBox10.Text + "',t_price='" + textBox11.Text + "',b_num='" + comboBox5.Text + "' where t_no= '" + textBox1.Text + "' ", con);


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

        private void button7_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            dateTimePicker1.Text = "";
            textBox3.Text = "";
            comboBox1.SelectedIndex = -1;
            textBox4.Text = "";
            comboBox4.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
            comboBox3.SelectedIndex = -1;
            textBox8.Text = "";

            textBox10.Text = "";
            textBox11.Text = "";
            comboBox5.SelectedIndex = -1;
            comboBox6.SelectedIndex = -1;
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            printPreviewDialog.Document = printDocument;
            printPreviewDialog.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            printDocument.Print();
        }

        private void printDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
             //  Bitmap bmp = Properties.Resources.jambu_icon;

           // Image newImage = bmp;
          // e.Graphics.DrawImage(newImage, 25, 55, newImage.Width, newImage.Height);
            e.Graphics.DrawString("Serial ID :  " + textBox1.Text, new Font("Arial", 30, FontStyle.Regular), Brushes.Tomato, new Point(25, 400));
            e.Graphics.DrawString("Seat number :  " + textBox4.Text, new Font("Arial", 30, FontStyle.Regular), Brushes.Tomato, new Point(25, 470));
            e.Graphics.DrawString("TOTAL Price :  " + textBox11.Text, new Font("Arial", 30, FontStyle.Regular), Brushes.Tomato, new Point(25, 540));
            e.Graphics.DrawString("Date Of journey :  " + dateTimePicker1.Text, new Font("Arial", 30, FontStyle.Regular), Brushes.Tomato, new Point(25, 640));
            e.Graphics.DrawString("DATE :  " + DateTime.Now, new Font("Arial", 30, FontStyle.Regular), Brushes.SeaGreen, new Point(25, 740));
        }

        private void printPreviewDialog_Load(object sender, EventArgs e)
        {
            printPreviewDialog.Document = printDocument;
            printPreviewDialog.Show();
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            meeting();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e) { }
        
            public void meeting()
        {
            string cns = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\travel\travel\travel\travel\travel.mdf;Integrated Security=True";
            SqlConnection cn1 = new SqlConnection(cns);
            SqlCommand cmd = new SqlCommand("select * from bTable where t_no='" + textBox1.Text + "'", cn1);

            try
            {
                cn1.Open();
                SqlDataReader sdr = cmd.ExecuteReader();

                while (sdr.Read())
                {
                    textBox1.Text = sdr["t_no"].ToString();
                    textBox2.Text = sdr["p_name"].ToString();
                    comboBox1.Text = sdr["gender"].ToString();
                    textBox3.Text = sdr["ph_number"].ToString();
                    dateTimePicker1.Text = sdr["_date"].ToString();
                    comboBox4.Text = sdr["start_time"].ToString();
                    comboBox2.Text = sdr["fromss"].ToString();
                    comboBox3.Text = sdr["tos"].ToString();
                    textBox8.Text = sdr["t_pass"].ToString();
                    textBox4.Text = sdr["seat_num"].ToString();
                    textBox10.Text = sdr["tick_price"].ToString();
                    textBox11.Text = sdr["t_price"].ToString();
                    comboBox5.Text = sdr["b_num"].ToString();
                    comboBox6.Text = sdr["b_name"].ToString();
                  //  comboBox2.Text = sdr["tick_rat"].ToString();
                   // textBox15.Text = sdr["tot_prc"].ToString();




                }

            }
            catch
            {
                MessageBox.Show("error from database");
                cn1.Close();
            }
        }

            private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
            {

            }
        

       
       
       
    }
}
