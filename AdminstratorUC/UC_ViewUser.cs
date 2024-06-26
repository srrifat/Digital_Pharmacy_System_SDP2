﻿using System;
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
    public partial class UC_ViewUser : UserControl
    {
        function fn = new function();
        String query;
        String currentUser = "";
        public UC_ViewUser()
        {
            InitializeComponent();
        }
        public string ID 
            {
            set { currentUser = value; }
            }



        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void UC_ViewUser_Load(object sender, EventArgs e)
        {
            query = "SELECT *FROM users";
            DataSet ds=fn.getData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {
            query="SELECT * FROM users WHERE username like '"+txtUsername.Text+"%'";//a%
            DataSet ds = fn.getData(query);
            guna2DataGridView1.DataSource=ds.Tables[0];

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you Sure?", "Delete Confirmation !", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (currentUser != userName)
                {
                    query = "DELETE FROM users WHERE username = '" + userName + "'";
                    fn.setData(query, "User Record Deleated .");
                    UC_ViewUser_Load(this, null);
                }
                else
                {
                    MessageBox.Show("You are trying to delete \n Your own Profile.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
        }
        String userName;
        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
                {

                userName = guna2DataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
                }
            catch
            {

            }

        }

        private void btnSync_Click(object sender, EventArgs e)
        {
            UC_ViewUser_Load(this,null);
        }
    }
}
