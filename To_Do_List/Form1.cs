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
using Google.Apis.Gmail.v1;

namespace To_Do_List
{
    public partial class Form1 : Form
    {
        public static string ApplicationName = "Client 1";
        public static string ClientId = "1021895256891-8409ha8je79fhgllo5s6qptg1nbv5c02.apps.googleusercontent.com";
        public static string ClientSecret = "aiUo_- 3icx7HjqwGjhYZCfh-";

        public static string[] Scopes=
            {
            GmailService.Scope.GmailCompose,
            GmailService.Scope.GmailSend
            };

       



        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\acer\source\repos\To_Do_List\To_Do_List\Database1.mdf;Integrated Security=True");
        
        public Form1()
        {
            InitializeComponent();

        }

        Form3 f3 = new Form3(); 
        

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void gradientPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Username cannot be blank");
            }

            else if (textBox2.Text == "")
            {
                MessageBox.Show("Email cannot be blank");
            }

            else if (textBox3.Text == "")
            {
                MessageBox.Show("Password cannot be blank");
            }

            else
            {

                con.Open();
                SqlDataAdapter ad = new SqlDataAdapter("select count(*) from logindata where Username='" + textBox1.Text + "' and Email='" + textBox2.Text + "' and Password='" + textBox3.Text + "' ", con);
                DataTable dt = new DataTable();
                ad.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    Form2 f2 = new Form2();

                    f3.Show();
                    f2.Hide();
                    this.Hide();

                    SqlCommand cmd = new SqlCommand("select Id from logindata where Username='" + textBox1.Text + "'and Email='" + textBox2.Text + "' ", con);
                    label2.Text = cmd.ExecuteScalar().ToString();
                    f3.label5.Text = label2.Text;

                    SqlCommand cmdd = new SqlCommand("select Username from logindata where Id='" + label2.Text + "' ", con);
                    label4.Text = cmdd.ExecuteScalar().ToString();

                    f3.label3.Text = label4.Text;
                    // MessageBox.Show(label2.Text);
                    //MessageBox.Show(label4.Text);
                }


                else
                {
                    MessageBox.Show("Incorrect Username or Password","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }

                con.Close();
            }
        }

        
       

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
           



        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {
           
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            timer1.Start();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            
                textBox1.Clear();
            
           // if (textBox2.TextLength == 0)
          //  {
         //       textBox2.Text = "Email";
          //  }

          //  if (textBox3.TextLength == 0)
          //  {
            //    textBox3.Text = "Password";
           // }

            panel1.BackColor = Color.FromArgb(128, 128, 255);
            panel3.BackColor = Color.White;
            panel2.BackColor = Color.White;

            textBox1.ForeColor = Color.FromArgb(128, 128, 255);
            textBox2.ForeColor = Color.White;
            textBox3.ForeColor = Color.White;

            usernamePic.BackColor = Color.FromArgb(128, 128, 255);
            EmailPic.BackColor = Color.White;
            PaaswordPic.BackColor = Color.White;


        }


        private void textBox2_MouseClick(object sender, MouseEventArgs e)
        {
            textBox2.Clear();

           /* if (textBox1.TextLength == 0)
            {
                textBox1.Text = "Username";
            }
            if (textBox3.TextLength == 0)
            {
                textBox3.Text = "Password";
            }*/

            panel3.BackColor = Color.FromArgb(128, 128, 255);
            panel1.BackColor = Color.White;
            panel2.BackColor = Color.White;

            textBox2.ForeColor = Color.FromArgb(128, 128, 255);
            textBox1.ForeColor = Color.White;
            textBox3.ForeColor = Color.White;

          EmailPic.BackColor = Color.FromArgb(128, 128, 255);
            usernamePic.BackColor = Color.White;
            PaaswordPic.BackColor = Color.White;

        }

        private void textBox3_MouseClick(object sender, MouseEventArgs e)
        {
            textBox3.Clear();

            /*
            if (textBox1.TextLength == 0)
            {
                textBox1.Text = "Usernamez";
            }

            if (textBox2.TextLength == 0)
            {
                textBox2.Text = "Email";
            } */

            panel2.BackColor = Color.FromArgb(128, 128, 255);
            panel1.BackColor = Color.White;
            panel3.BackColor = Color.White;

            textBox3.ForeColor = Color.FromArgb(128, 128, 255);
            textBox2.ForeColor = Color.White;
            textBox1.ForeColor = Color.White;

            PaaswordPic.BackColor = Color.FromArgb(128, 128, 255);
            EmailPic.BackColor = Color.White;
            usernamePic.BackColor = Color.White;

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Left += 10;
            if(f2.Left>=830)
            {
                timer1.Stop();
                this.TopMost = false;
                f2.TopMost = true;
                timer2.Start();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Left -= 10;
            if(f2.Left<=600)
            {
                timer2.Stop();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

       
    }
}
