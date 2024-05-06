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
    public partial class UC_Dashbord : UserControl
    {
        function fn = new function();
        String query;
        DataSet ds;



        public UC_Dashbord()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
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

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            UC_Dashbord_Load(this, null);
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void UC_Dashbord_Load(object sender, EventArgs e)
        {
            query = "SELECT count(userRole) FROM users WHERE userRole ='Administrator'";
            ds = fn.getData(query);
            setLabel(ds, AdminLabel);

            query = "SELECT count(userRole) FROM users WHERE userRole ='Employee'";
            ds = fn.getData(query);
            setLabel(ds, EmployeeLabel);

        }
        private void setLabel(DataSet ds,Label lbl)
        {
            if (ds.Tables[0].Rows.Count != 0)
            {
                lbl.Text = ds.Tables[0].Rows[0][0].ToString();

            }
            else
            {
                lbl.Text = "0";
            }

        }

        private void AdminLabel_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }
    }
}
