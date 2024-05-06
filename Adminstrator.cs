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
    public partial class Adminstrator : Form
    {
        String user = " ";
        public Adminstrator()
        {
            InitializeComponent();
        }
        public string ID
            {
            get  { return user.ToString(); }
            }
        public Adminstrator(String users)
        {
            InitializeComponent();
            userNameLabel.Text = users;
            user=users;
            uC_ViewUser1.ID = ID;
            uC_profile1.ID = ID;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            uC_Dashbord1.Visible = true;
            uC_Dashbord1.BringToFront();
        }

        private void Adminstrator_Load(object sender, EventArgs e)
        {
            uC_Dashbord1.Visible = false;
            user_AddUser1.Visible = false;
            uC_ViewUser1.Visible = false;
            uC_profile1.Visible=false;
            btnDashboard.PerformClick();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            user_AddUser1.Visible = true;
            user_AddUser1.BringToFront();
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            uC_ViewUser1.Visible = true;
            uC_ViewUser1.BringToFront();
            //GetPharmacyRecord();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            uC_profile1.Visible = true;
            uC_profile1.BringToFront();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            Form1 fm = new Form1();
            fm.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void uC_Dashbord1_Load(object sender, EventArgs e)
        {

        }

        private void user_AddUser1_Load(object sender, EventArgs e)
        {

        }

        private void uC_ViewUser1_Load(object sender, EventArgs e)
        {

        }

        private void user_AddUser1_Load_1(object sender, EventArgs e)
        {

        }

        private void uC_Dashbord1_Load_1(object sender, EventArgs e)
        {

        }

        private void uC_profile1_Load(object sender, EventArgs e)
        {

        }
    }
}
