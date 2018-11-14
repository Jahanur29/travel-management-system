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
    public partial class Plane : Form
    {
        public Plane()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
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

            string qry = "select sum(tot_seat) from arlTable where pln_nmbr='" + comboBox2.Text + "'";
            SqlCommand sc = new SqlCommand(qry, con);
            {
                int x = Convert.ToInt32(textBox6.Text);
                int a = 0 + (Int32)sc.ExecuteScalar();
                int totalAmount = a - x;
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
            SqlCommand cmd1 = new SqlCommand("update arlTable set tot_seat='" + n + "' where  pln_nmbr='" + comboBox2.Text + "'", cn1);

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


        public void up()
        {
            int a = Convert.ToInt32(textBox6.Text);
            int b = Convert.ToInt32(textBox4.Text);
            double total = a * b;
            string z = Convert.ToString(total);
            textBox15.Text = z;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            {
                up();
                String cns = (@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\travel\travel\travel\travel\travel.mdf;Integrated Security=True");
                SqlConnection cn1 = new SqlConnection(cns);
                cn1.Open();
                SqlCommand cmd1 = new SqlCommand("insert into planTable(flt_nm,pas_nme,_date,st_tm,en_tm,st_plc,en_plc,air_nam,tick_nm,pass_num,ph_num,set_num,tick_cls,tot_pass,tick_rat,tot_prc)Values('" + comboBox2.Text + "','" + textBox9.Text + "','" + dateTimePicker1.Text + "','" + comboBox7.Text + "','" + comboBox6.Text + "','" + comboBox3.Text + "','" + comboBox4.Text + "','" + comboBox5.Text + "','" + textBox8.Text + "','" + textBox10.Text + "','" + textBox11.Text + "','" + textBox12.Text + "','" + comboBox1.Text + "','" + textBox6.Text + "','" + textBox4.Text + "','" + textBox15.Text + "')", cn1);

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

        private void label6_Click(object sender, EventArgs e)
        {

        }
        public void meeting()
        {
            string cns = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\travel\travel\travel\travel\travel.mdf;Integrated Security=True";
            SqlConnection cn1 = new SqlConnection(cns);
            SqlCommand cmd = new SqlCommand("select * from planTable where flt_nm='" + comboBox2.Text + "'", cn1);

            try
            {
                cn1.Open();
                SqlDataReader sdr = cmd.ExecuteReader();

                while (sdr.Read())
                {
                    comboBox2.Text = sdr["flt_nm"].ToString();
                    textBox9.Text = sdr["pas_nme"].ToString();
                    dateTimePicker1.Text = sdr["_date"].ToString();
                    comboBox7.Text = sdr["st_tm"].ToString();
                    comboBox6.Text = sdr["en_tm"].ToString();
                    comboBox3.Text = sdr["st_plc"].ToString();
                    comboBox4.Text = sdr["en_plc"].ToString();
                    comboBox5.Text = sdr["air_nam"].ToString();
                    textBox8.Text = sdr["tick_nm"].ToString();
                    textBox10.Text = sdr["pass_num"].ToString();
                    textBox11.Text = sdr["ph_num"].ToString();
                    textBox12.Text = sdr["set_num"].ToString();
                    comboBox1.Text = sdr["tick_cls"].ToString();
                    textBox6.Text = sdr["tot_pass"].ToString();
                    textBox4.Text = sdr["tick_rat"].ToString();
                    textBox15.Text = sdr["tot_prc"].ToString();




                }

            }
            catch
            {
                MessageBox.Show("error from database");
                cn1.Close();
            }

        }
       
        private void button4_Click(object sender, EventArgs e)
        {
            meeting();
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

      /*  private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox3.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox2.Text = "";
            textBox12.Text = "";
            textBox4.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            textBox10.Text = "";
            dateTimePicker1.Text = "";
            comboBox1.SelectedIndex = -1;
        }
        */
        private void button11_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 ss = new Form2();
            ss.Show();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            planemain ss = new planemain();
            ss.Show();
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click_1(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            comboBox2.Text = "";
            textBox9.Text = "";
            dateTimePicker1.Text = "";
            comboBox7.Text = "";
            comboBox6.Text = "";
            textBox4.Text = "";
            comboBox3.Text = "";
            comboBox4.Text = "";
            comboBox5.Text = "";
            textBox8.Text = "";
            textBox10.Text = "";
            textBox11.Text = "";
            textBox12.Text = "";
            textBox6.Text = "";
            textBox4.Text = "";
            textBox15.Text = "";
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
           // up();
        }

        private void textBox6_TextChanged_1(object sender, EventArgs e)
        {
            //up();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\travel\travel\travel\travel\travel.mdf;Integrated Security=True");
            con.Open();
            SqlCommand sc = new SqlCommand("update planTable set flt_nm='" + comboBox2.Text + "',pas_nme='" + textBox9.Text + "',_date='" + dateTimePicker1.Text + "',st_tm='" + comboBox7.Text + "',en_tm='" + comboBox6.Text + "' ,st_plc='" + comboBox3.Text + "',en_plc='" + comboBox4.Text + "',air_nam='" + comboBox5.Text + "',tick_nm='" + textBox8.Text + "',pass_num='" + textBox10.Text + "',ph_num='" + textBox11.Text + "',set_num='" + textBox12.Text + "',tick_cls='" + comboBox1.Text + "',tot_pass='" + textBox6.Text + "',tick_rat='" + textBox4.Text + "',tot_prc='" + textBox15.Text + "' ", con);
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

        private void button2_Click_1(object sender, EventArgs e)
        {
            printPreviewDialog.Document = printDocument;
            printPreviewDialog.Show();
        }

        private void printDocument_PrintPage(object sender, PrintPageEventArgs e)
        {

          //  Bitmap bmp = Properties.Resources.jambu_icon;

           // Image newImage = bmp;
          // e.Graphics.DrawImage(newImage, 25, 55, newImage.Width, newImage.Height);
            e.Graphics.DrawString("FLIGHT ID :  " + comboBox2.Text, new Font("Arial", 30, FontStyle.Regular), Brushes.Tomato, new Point(25, 400));
            e.Graphics.DrawString("SEAT NUMBER :  " + textBox12.Text, new Font("Arial", 30, FontStyle.Regular), Brushes.Tomato, new Point(25, 470));
            e.Graphics.DrawString("TOTAL COST:  " + textBox15.Text, new Font("Arial", 30, FontStyle.Regular), Brushes.Tomato, new Point(25, 540));
            e.Graphics.DrawString("Date Of journey:  " + dateTimePicker1.Text, new Font("Arial", 30, FontStyle.Regular), Brushes.Tomato, new Point(25, 640));
            e.Graphics.DrawString("DATE :  " + DateTime.Now, new Font("Arial", 30, FontStyle.Regular), Brushes.SeaGreen, new Point(25, 740));
        }

        private void printPreviewDialog_Load(object sender, EventArgs e)
        {
            printPreviewDialog.Document = printDocument;
            printPreviewDialog.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
