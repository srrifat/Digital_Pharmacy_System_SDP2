using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigitalPharmacySystem
{
    public partial class Form1 : Form
    {
        function fn = new function();
        String query;
        DataSet ds;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            query = "SELECT*FROM users";
            ds = fn.getData(query);
            if(ds.Tables[0].Rows.Count==0)
            {
                if (txtUserName.Text == "root" && txtPassword.Text == "root")
                {
                    Adminstrator admin = new Adminstrator();
                    admin.Show();
                    this.Hide();

                }
            }
            else
            {
                query="SELECT*FROM users where username='"+txtUserName.Text+"' and pass='"+txtPassword.Text+"'";
                ds=fn.getData(query);
                if(ds.Tables[0].Rows.Count!=0)
                {
                    String role = ds.Tables[0].Rows[0][1].ToString();
                    if(role=="Administrator")
                    {
                        Adminstrator admin = new Adminstrator(txtUserName.Text);
                        admin.Show();
                        this.Hide();
                    }
                    else if(role=="Employee")
                    {
                        Employee emp=new Employee();
                        emp.Show();
                        this.Hide();
                    }
                    


                }
                else
                {
                    MessageBox.Show("Wrong Username OR Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }













            /*if (txtUserName.Text == "srrifat" && txtPassword.Text == "pass")
            {
                Adminstrator am = new Adminstrator();
                am.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong Username Or Password","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }*/
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            txtUserName.Clear();
            txtPassword.Clear();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
