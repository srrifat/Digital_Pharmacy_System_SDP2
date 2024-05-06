using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace DigitalPharmacySystem.AdminstratorUC
{
    public partial class User_AddUser : UserControl
    {
        function fn = new function();
        String query;

        public User_AddUser()
        {
            InitializeComponent();
        }

        private void User_AddUser_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void guna2DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUserRole_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            String role = txtUserRole.Text;
            String name = txtName.Text;
            String dob = txtDob.Text;
            String mobile = txtMobileNo.Text;
            String email= txtEmail.Text;
            String username = txtUsername.Text;
            String pass = txtPass.Text;


            try
            {
                query = "insert into users(userRole, name, dob, mobile, email,username, pass)values('"+role+"','"+name+"','"+dob+"','"+mobile+"','"+email+"','"+username+"','"+pass+"')";
                fn.setData(query, "Sign Up Successfull");
                
            }
            catch (Exception )
            {
                MessageBox.Show("Username Alreay exist.","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
          
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label9_Click_1(object sender, EventArgs e)
        {

        }

        private void label9_Click_2(object sender, EventArgs e)
        {

        }

        private void txtMobileNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            clearAll();
        }
        public void clearAll()
        {

            txtUserRole.SelectedIndex = -1;
            txtName.Clear();
            txtDob.ResetText();
            txtMobileNo.Clear();
            txtEmail.Clear();
            txtUsername.Clear();
            txtPass.Clear();
            


        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            query = "SELECT *FROM users where username='"+txtUsername.Text+"'";
            DataSet ds = fn.getData(query);
            if(ds.Tables[0].Rows.Count==0)
            {
                pictureBox2.ImageLocation = @"E:\Project Element\Image\Pharmacy Management System in C#\yes.png";
            }
            else
            {
                pictureBox2.ImageLocation = @"E:\Project Element\Image\Pharmacy Management System in C#\no.png";
            }
        }
    }
}
