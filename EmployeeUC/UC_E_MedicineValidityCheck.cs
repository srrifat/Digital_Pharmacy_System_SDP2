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
    public partial class UC_E_MedicineValidityCheck : UserControl
    {
        function fn = new function();
        String query;


        public UC_E_MedicineValidityCheck()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
             if(txtCheck.SelectedIndex == 0)
            {
                query = "SELECT *FROM medic WHERE eDate>=getdate()";
                 setDataGridView(query, "Valid Medicines", Color.Black);

            }
             else if(txtCheck.SelectedIndex == 1)
            {
                query = "SELECT* FROM medic WHERE eDate <= getdate()";
                setDataGridView(query, "Expired Medicines", Color.Red);
            }
             else if(txtCheck.SelectedIndex == 2)
            {
                query = "SELECT * FROM medic";
                setDataGridView(query,"",Color.Black);



            }
        }
        private void setDataGridView(String query,String labelName,Color col)
        {
            DataSet ds = fn.getData(query);
            guna2DataGridView2.DataSource = ds.Tables[0];
            setLabel.Text = labelName;
            setLabel.ForeColor = col;

        }

        private void guna2DataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void UC_E_MedicineValidityCheck_Load(object sender, EventArgs e)
        {
            setLabel.Text = "";
        }
    }
}
