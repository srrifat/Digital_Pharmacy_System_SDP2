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
    public partial class Employee : Form
    {
        public Employee()
        {
            InitializeComponent();
        }

        private void Employee_Load(object sender, EventArgs e)
        {
            uC_E_Dashbord1.Visible = false;
            uC_E_AddMedicine1.Visible = false;
            uC_E_ViewMedicines1.Visible = false;
            uC_E_UpdateMedicine1.Visible=false;
            uC_E_MedicineValidityCheck1.Visible= false;
            uC_E_SellMedicine1.Visible = false;
            btnDashboard.PerformClick();
          

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            uC_E_Dashbord1.Visible = true;
            uC_E_Dashbord1.BringToFront();

        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Form1 fm = new Form1();
            fm.Show();
            this.Hide();


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            uC_E_AddMedicine1.Visible = true;
            uC_E_AddMedicine1.BringToFront();
        }

        private void btnViewMedicine_Click(object sender, EventArgs e)
        {
            uC_E_ViewMedicines1.Visible = true;
            uC_E_ViewMedicines1.BringToFront();
        }

        private void btnModifyMedicine_Click(object sender, EventArgs e)
        {
            uC_E_UpdateMedicine1.Visible = true;
            uC_E_UpdateMedicine1.BringToFront();
            


        }

        private void btnMedicineValidtyChack_Click(object sender, EventArgs e)
        {
            uC_E_MedicineValidityCheck1.Visible = true;
            uC_E_MedicineValidityCheck1.BringToFront();
        }

        private void btnSellMedicine_Click(object sender, EventArgs e)
        {
            uC_E_SellMedicine1.Visible = true;
            uC_E_SellMedicine1.BringToFront();

        }
    }
}
