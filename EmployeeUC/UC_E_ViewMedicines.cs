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
    public partial class UC_E_ViewMedicines : UserControl
    {
        function fn=new function();
        String query; 


        public UC_E_ViewMedicines()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void UC_E_ViewMedicines_Load(object sender, EventArgs e)
        {
            query = "SELECT* FROM medic";
            setDataGridView(query);
           
        }

        private void txtMedicineName_TextChanged(object sender, EventArgs e)
        {
            query = "SELECT * FROM medic WHERE mname like '"+txtSearch.Text+"%'";
            setDataGridView(query);

        }

        private void setDataGridView(String queery)
        {
            DataSet ds = fn.getData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
        }
        String medicineID;

        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                medicineID = guna2DataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
            catch
            {

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you Sure?","Delete Confirmation !",MessageBoxButtons.YesNo,MessageBoxIcon.Warning)== DialogResult.Yes)
            {
                 query = "delete from medic where mid ='"+medicineID+"'";
                fn.setData(query, "Medicine Record Deleated");
                UC_E_ViewMedicines_Load(this, null);
            }
        }

        private void btnSync_Click(object sender, EventArgs e)
        {
            UC_E_ViewMedicines_Load(this, null);
        }
    }
}
