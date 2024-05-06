using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigitalPharmacySystem.EmployeeUC
{
    public partial class UC_E_AddMedicine : UserControl
    {
        function fn=new function();
        String query;
        public UC_E_AddMedicine()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtMediId.Text != "" && txtMediName.Text != "" && txtMediNumber.Text != "" && txtQuantity.Text != "" && txtPricePerUnit.Text != "")
            {
                String mid = txtMediId.Text;
                String mname = txtMediName.Text;
                String mnumber = txtMediNumber.Text;
                String mDate = txtMenufacturingDate.Text;
                String eDate = txtExpireDate.Text;
                Int64 quantity = Int64.Parse(txtQuantity.Text);
                Int64 perUnit = Int64.Parse(txtPricePerUnit.Text);
                query = "insert into medic(mid,mname,mnumber, mDate,eDate,quantity,perUnit) values('" + mid + "','" + mname + "','" + mnumber + "','" + mDate + "','" + eDate + "'," + quantity + "," + perUnit + ")";
                fn.setData(query, "Medicine Added to Database");

            }
            else
            {
                MessageBox.Show("Enter all Data.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        

            public void clearAll()
            {
                txtMediId.Clear();
                txtMediName.Clear();
                txtQuantity.Clear();
                txtMediNumber.Clear();
                txtPricePerUnit.Clear();
                txtMenufacturingDate.ResetText();
                txtExpireDate.ResetText();
            }

        private void btnReset_Click(object sender, EventArgs e)
        {
            clearAll();
        }
    }
}
