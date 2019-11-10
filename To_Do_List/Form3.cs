using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.Data.SqlClient;

namespace To_Do_List
{
    public partial class Form3 : Form
    {
        public int count = 0,icount=0,pcount=0,dcount=0;
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\acer\source\repos\To_Do_List\To_Do_List\Database1.mdf;Integrated Security=True");
        public Form3()
        {
            InitializeComponent();
        }
        ToolTip t1 = new ToolTip();

        private void gradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuTextbox1_OnTextChange(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }

        public void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

            label1.BackColor = System.Drawing.Color.Transparent;
            label2.BackColor = System.Drawing.Color.Transparent;
            label4.BackColor = System.Drawing.Color.Transparent;
            label2.Text = DateTime.Now.ToString("dddd,dd MMMM yyyy");
            Add_Task_md.BackColor = System.Drawing.Color.Transparent;

            My_day.Focus();
            label1.Text = "Welcome";
            mydaypanel.Hide();
            plannedpanel.Hide();
            donepanel.Hide();
            importantpanel.Hide();
            pictureBox7.BackColor = System.Drawing.Color.Black;





        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Add_Task_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Add_Task_Click_1(object sender, EventArgs e)
        {

            String item = InputDialog.Show("Add New Task");
            if (item != null)
            {
                Add_tAsk_md(item);
            }

            else
            {
                MessageBox.Show("Please enter a value");
            }

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //For Panel
            label1.Text = My_day.Text;
            mydaypanel.Show();
            plannedpanel.Hide();
            importantpanel.Hide();
            donepanel.Hide();

            checkedListBox1.Show();
            checkedListBox2.Hide();
            checkedListBox3.Hide();
            checkedListBox4.Hide();

            Add_task_im.Hide();
            Add_Task_md.Show();
            Add_task_pl.Hide();
            Add_task_dn.Hide();


            //retriving data
            if (count == 0)
            {
                con.Open();
                string query = string.Format("select [fkey],myday from datatable where [fkey]='{0}' order by fkey", label5.Text);
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    checkedListBox1.Items.Add(dt.Rows[i]["myday"].ToString());
                }


                con.Close();
                count = 1;

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            label1.Text = Important.Text;
            importantpanel.Show();
            plannedpanel.Hide();
            mydaypanel.Hide();
            donepanel.Hide();



            checkedListBox1.Hide();
            checkedListBox2.Show();
            checkedListBox3.Hide();
            checkedListBox4.Hide();

            Add_task_im.Show();
            Add_Task_md.Hide();
            Add_task_pl.Hide();
            Add_task_dn.Hide();

            //retriving data
            if (icount == 0)
            {
                con.Open();
                string query = string.Format("select [fkey],myday from datatable where [fkey]='{0}' and important='1' order by fkey", label5.Text);
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    checkedListBox2.Items.Add(dt.Rows[i]["myday"].ToString());
                }

               con.Close();
                icount = 1;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = Planned.Text;
            plannedpanel.Show();
            mydaypanel.Hide();
            importantpanel.Hide();
            donepanel.Hide();

            checkedListBox1.Hide();
            checkedListBox2.Hide();
            checkedListBox3.Show();
            checkedListBox4.Hide();

            Add_task_im.Hide();
            Add_Task_md.Hide();
            Add_task_pl.Show();
            Add_task_dn.Hide();

            //retriving data
            if (pcount == 0)
            {
                con.Open();
                string query = string.Format("select [fkey],myday from datatable where [fkey]='{0}' and planned='1' order by fkey", label5.Text);
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    checkedListBox3.Items.Add(dt.Rows[i]["myday"].ToString());
                }


                con.Close();
                pcount = 1;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label1.Text = Done.Text;
            donepanel.Show();
            plannedpanel.Hide();
            importantpanel.Hide();
            mydaypanel.Hide();

            checkedListBox1.Hide();
            checkedListBox2.Hide();
            checkedListBox3.Hide();
            checkedListBox4.Show();

            Add_task_im.Hide();
            Add_Task_md.Hide();
            Add_task_pl.Hide();
            Add_task_dn.Show();

            //retriving data
            if (dcount == 0)
            {
                con.Open();
                string query = string.Format("select [fkey],myday from datatable where [fkey]='{0}' and done='1' order by fkey", label5.Text);
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    checkedListBox4.Items.Add(dt.Rows[i]["myday"].ToString());
                }


                con.Close();
                dcount = 1;
            }
        }

        private void bunifuCards1_Paint(object sender, PaintEventArgs e)
        {

        }

        public void Add_tAsk_md(String item)
        {
            checkedListBox1.Items.Add(item);
        }

        public void Add_tAsk_im(String itemm)
        {
            checkedListBox2.Items.Add(itemm);
        }

        public void Add_tAsk_pl(String itemmm)
        {
            checkedListBox3.Items.Add(itemmm);
        }

        public void Add_tAsk_dn(String itemmmm)
        {
            checkedListBox4.Items.Add(itemmmm);
        }


        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void checkedListBox1_SelectedIndexChanged_2(object sender, EventArgs e)
        {

        }

        private void bunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void mydaypanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Add_task_im_Click(object sender, EventArgs e)
        {
            String item = InputDialog.Show("Add New Task");
            if (item != null)
            {
                Add_tAsk_im(item);
            }

            else
            {
                MessageBox.Show("Please enter a value");
            }

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            String itemmm = InputDialog.Show("Add New Task");
            if (itemmm != null)
            {

                Add_tAsk_pl(itemmm);
            }

            else
            {
                MessageBox.Show("Please enter a value");
            }

        }

        private void Add_task_dn_Click(object sender, EventArgs e)
        {
            String itemmmm = InputDialog.Show("Add New Task");
            if (itemmmm != null)
            {
                Add_tAsk_dn(itemmmm);
            }

            else
            {
                MessageBox.Show("Please enter a value");
            }

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_3(object sender, EventArgs e)
        {

            string str;
            if (checkedListBox1.Items.Count > 0)
            {
                for (int i = 0; i < checkedListBox1.Items.Count; i++)
                {
                    //Saving dat of my day


                    str = checkedListBox1.Items[i].ToString();
                    Myday_insert(str);


                }
                MessageBox.Show("Save Succesfull", "Successfull", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }


                //saving for imp
                string im ;
                if (checkedListBox2.Items.Count > 0)
                {
                    for (int i = 0; i < checkedListBox2.Items.Count; i++)
                    {



                        im = checkedListBox2.Items[i].ToString();
                        Important_insert(im);
                    }
                MessageBox.Show("Save Succesfull", "Successfull", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }

                    //saving for planned

                    string pl ;
                    if (checkedListBox3.Items.Count > 0)
                    {
                        for (int i = 0; i < checkedListBox3.Items.Count; i++)
                        {



                            pl = checkedListBox3.Items[i].ToString();
                            Planned_insert(pl);

                    
                        }
                MessageBox.Show("Save Succesfull", "Successfull", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }

                        //saving for done

                        string dn ;
                        if (checkedListBox4.Items.Count > 0)
                        {
                            for (int i = 0; i < checkedListBox4.Items.Count; i++)
                            {

                               
                                    dn = checkedListBox4.Items[i].ToString();
                                    Done_insert(dn);
                                
                               
                            }


                            
                            
                            MessageBox.Show("Save Succesfull", "Successfull", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        }
                    
                
            


        }

        private void My_day_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void del_Click(object sender, EventArgs e)
        {

        }

        private void checkedListBox4_MouseHover(object sender, EventArgs e)
        {
            t1.SetToolTip(pictureBox2, "Selected items will be deleted");
        }
        string del;
        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            if(checkedListBox1.CheckedItems.Count>0)
            {
                for(int i=0;i<checkedListBox1.CheckedItems.Count;i++)
                {
                    del = checkedListBox1.CheckedItems[i].ToString();
                    //from database
                    Delete_data(del);
                    //From application
                    checkedListBox1.Items.Remove(del);
                }
            }
            else
            {
                MessageBox.Show("Please Select the items to delete");
            }
        }

        public void Myday_insert(String str)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into datatable(myday,fkey) values(@myday,@fkey)", con);
            cmd.Parameters.AddWithValue("@myday", str);
            cmd.Parameters.AddWithValue("@fkey", label5.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            
        }

        public void Important_insert(String im)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into datatable(myday,important,fkey) values(@myday,@important,@fkey)", con);
            cmd.Parameters.AddWithValue("@myday", im);
            cmd.Parameters.AddWithValue("@important", "1");
            cmd.Parameters.AddWithValue("@fkey", label5.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            

        }

        private void checkedListBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void Planned_insert(String pl)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into datatable(myday,planned,fkey) values(@myday,@planned,@fkey)", con);
            cmd.Parameters.AddWithValue("@myday", pl);
            cmd.Parameters.AddWithValue("@planned", "1");
            cmd.Parameters.AddWithValue("@fkey", label5.Text);
            cmd.ExecuteNonQuery();
            con.Close();

        }

        public void Done_insert(String dn)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into datatable(myday,done,fkey) values(@myday,@done,@fkey)", con);
            cmd.Parameters.AddWithValue("@myday", dn);
            cmd.Parameters.AddWithValue("@done", "1");
            cmd.Parameters.AddWithValue("@fkey", label5.Text);
            cmd.ExecuteNonQuery();
            con.Close();

        }
        public void Delete_data(String del)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText= "delete from datatable where myday = '"+del+"' ";
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }

}
   

