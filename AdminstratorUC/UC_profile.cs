using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigitalPharmacySystem.AdminstratorUC
{
    public partial class UC_profile : UserControl
    {

        function fn = new function();
        String query;

        public UC_profile()
        {
            InitializeComponent();
        }
        public string ID 
            {
            set { userNameLabel.Text = value; }
             }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void UC_profile_Load(object sender, EventArgs e)
        {

        }

        private void guna2TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            String role =txtUserRole.Text;
            String name = txtName.Text;
            String dob = txtDob.Text;
            Int64 mobile =Int64.Parse(txtMobileNo.Text);
            String email = txtEmail.Text;
            String username = userNameLabel.Text;
            String pass = txtPass.Text;
            query = "update users set userRole='"+role+"',name='"+name+"',dob='"+dob+"',mobile="+ mobile+",email='" + email + "',pass='" +pass+ "'WHERE username='"+username+"'";
            fn.setData(query, "Profile Updation Successful.");

        }

        private void UC_profile_Enter(object sender, EventArgs e)
        {
            query = "SELECT* FROM users WHERE username ='" + userNameLabel.Text + "'";
            DataSet ds = fn.getData(query);
            txtUserRole.Text = ds.Tables[0].Rows[0][1].ToString();
            txtName.Text = ds.Tables[0].Rows[0][2].ToString();
            txtDob.Text = ds.Tables[0].Rows[0][3].ToString();
            txtMobileNo.Text=ds.Tables[0].Rows[0][4].ToString();
            txtEmail.Text = ds.Tables[0].Rows[0][5].ToString();
            txtPass.Text = ds.Tables[0].Rows[0][7].ToString();
                    




        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            UC_profile_Enter(this,null);
        }
    }
}
