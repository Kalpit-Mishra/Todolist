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

namespace To_Do_List
{
    public partial class Form2 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\acer\source\repos\To_Do_List\To_Do_List\Database1.mdf;Integrated Security=True");
        public Form2()
        {
            InitializeComponent();
        }

        Form3 f3 = new Form3();
        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_MouseClick(object sender, MouseEventArgs e)
        {
            textBox2.Clear();


        /*    if (textBox1.TextLength == 0)
            {
                textBox1.Text = "Username";
            }

            if (textBox3.TextLength == 0)
            {
                textBox3.Text = "Passowrd";
            }

            if (textBox4.TextLength == 0)
            {
                textBox4.Text = "Passowrd";
            }*/

            panel3.BackColor = Color.FromArgb(128, 128, 255);
            panel2.BackColor = Color.White;
            panel1.BackColor = Color.White;
            panel4.BackColor = Color.White;

            textBox2.ForeColor = Color.FromArgb(128, 128, 255);
            textBox1.ForeColor = Color.White;
            textBox3.ForeColor = Color.White;
            textBox4.ForeColor = Color.White;

           EmailPic.BackColor = Color.FromArgb(128, 128, 255);
            usernamePic.BackColor = Color.White;
            PaaswordPic.BackColor = Color.White;
            ConfirmPasPic.BackColor = Color.White;

        }

        private void textBox3_MouseClick(object sender, MouseEventArgs e)
        {
            textBox3.Clear();

          /*  if (textBox1.TextLength == 0)
            {
                textBox1.Text = "Username";
            }

            if (textBox2.TextLength == 0)
            {
                textBox2.Text = "Email";
            }

            if (textBox4.TextLength == 0)
            {
                textBox4.Text = "Passowrd";
            }*/

            panel2.BackColor = Color.FromArgb(128, 128, 255);
            panel3.BackColor = Color.White;
            panel1.BackColor = Color.White;
            panel4.BackColor = Color.White;

            textBox3.ForeColor = Color.FromArgb(128, 128, 255);
            textBox1.ForeColor = Color.White;
            textBox2.ForeColor = Color.White;
            textBox4.ForeColor = Color.White;

           PaaswordPic.BackColor = Color.FromArgb(128, 128, 255);
            usernamePic.BackColor = Color.White;
            EmailPic.BackColor = Color.White;
            ConfirmPasPic.BackColor = Color.White;
            


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            textBox1.Clear();

/*
            if (textBox2.TextLength == 0)
            {
                textBox2.Text = "Email";
            }

            if(textBox3.TextLength==0)
            {
                textBox3.Text = "Passowrd";
            }

            if (textBox4.TextLength == 0)
            {
                textBox4.Text = "Passowrd";
            }*/

            panel1.BackColor = Color.FromArgb(128, 128, 255);
            panel2.BackColor = Color.White;
            panel3.BackColor = Color.White;
            panel4.BackColor = Color.White;

            textBox1.ForeColor = Color.FromArgb(128, 128, 255);
            textBox2.ForeColor = Color.White;
            textBox3.ForeColor = Color.White;
            textBox4.ForeColor = Color.White;

            usernamePic.BackColor = Color.FromArgb(128, 128, 255);
            EmailPic.BackColor = Color.White;
            PaaswordPic.BackColor = Color.White;
            ConfirmPasPic.BackColor = Color.White;
            
            
        }

        private void usernamePic_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        string pattern = @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
         @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
         @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";
        private void button1_Click(object sender, EventArgs e)
        {
            
            if(textBox1.Text!="" && textBox2.Text!="" && textBox3.Text!="" && textBox4.Text!="")
            {
                if (textBox2.Text==pattern)
                {

                    if (textBox4.Text == textBox3.Text)
                    {
                        con.Open();
                        SqlCommand cmd = con.CreateCommand();
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "insert into logindata values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "')";
                        cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Registration Successfull", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    else
                    {
                        MessageBox.Show("Password Does not Match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }

                else
                {
                    MessageBox.Show("Please Enter a Valid Email","Error",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("All Fields Are Mandatory","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                
            }
        }

        private void textBox4_MouseClick(object sender, MouseEventArgs e)
        {
            textBox4.Clear();
         /*   if (textBox1.TextLength == 0)
            {
                textBox1.Text = "Username";
            }

            if (textBox2.TextLength == 0)
            {
                textBox2.Text = "Email";
            }

            if (textBox3.TextLength == 0)
            {
                textBox3.Text = "Passowrd";
            }*/

            panel4.BackColor = Color.FromArgb(128, 128, 255);
            panel3.BackColor = Color.White;
            panel1.BackColor = Color.White;
            panel2.BackColor = Color.White;

            textBox4.ForeColor = Color.FromArgb(128, 128, 255);
            textBox1.ForeColor = Color.White;
            textBox2.ForeColor = Color.White;
            textBox3.ForeColor = Color.White;

            ConfirmPasPic.BackColor = Color.FromArgb(128, 128, 255);
            usernamePic.BackColor = Color.White;
            EmailPic.BackColor = Color.White;
            PaaswordPic.BackColor = Color.White;
        }
    }
}
