using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DGVPrinterHelper;

namespace DigitalPharmacySystem.EmployeeUC
{
    public partial class UC_E_SellMedicine : UserControl
    {
        function fn = new function();
        String query;
        DataSet ds;
        public UC_E_SellMedicine()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnSync_Click(object sender, EventArgs e)
        {
            
            UC_E_SellMedicine_Load(this, null);

        }

        private void UC_E_SellMedicine_Load(object sender, EventArgs e)
        {
            listBoxMedicines.Items.Clear();
            query = "SELECT mname FROM medic WHERE eDate >= getdate() and quantity >'0'";
            ds = fn.getData(query);
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                listBoxMedicines.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            listBoxMedicines.Items.Clear();
            query = "SELECT mname FROM medic WHERE mname LIKE '"+txtSearch.Text+"%' and eDate >= getdate() and quantity >'0'";
            ds = fn.getData(query);


            for(int i=0;i<ds.Tables[0].Rows.Count;i++)
            {
                listBoxMedicines.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }
        }

        private void listBoxMedicines_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtNoOfUnits.Clear();
            String name = listBoxMedicines.GetItemText(listBoxMedicines.SelectedItem);

            txtMediName.Text = name;
            query = "SELECT mid,eDate,perUnit FROM medic WHERE mname='"+name+"'";
            ds=fn.getData(query);
            txtMediID.Text = ds.Tables[0].Rows[0][0].ToString();
            txtExpireDate.Text = ds.Tables[0].Rows[0][1].ToString();
            txtPricePerUnit.Text = ds.Tables[0].Rows[0][2].ToString();
            

        }

        private void txtNoOfUnits_TextChanged(object sender, EventArgs e)
        {
            if(txtNoOfUnits.Text != "")
            {
                Int64 unitPrice = Int64.Parse(txtPricePerUnit.Text);
                Int64 noOfUnit = Int64.Parse(txtNoOfUnits.Text);
                Int64 totalAmount = unitPrice * noOfUnit;
                txtTotalPrice.Text = totalAmount.ToString();
            }
            else
            {
                txtTotalPrice.Clear(); 
            }
        }
        protected int n, totalAmount = 0;
        protected Int64 quantity, newQuantity;

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        

        

        private void btnAddToCard_Click(object sender, EventArgs e)
        {
            if(txtMediID.Text != "")
            {
                query="SELECT quantity FROM medic WHERE mid = '"+txtMediID.Text+"'";
                ds = fn.getData(query);

                quantity = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());//50
                newQuantity = quantity - Int64.Parse(txtNoOfUnits.Text);//50-5
                if (newQuantity >= 0)
                {
                    n = guna2DataGridView1.Rows.Add();
                    guna2DataGridView1.Rows[n].Cells[0].Value = txtMediID.Text;
                    guna2DataGridView1.Rows[n].Cells[1].Value = txtMediName.Text;
                    guna2DataGridView1.Rows[n].Cells[2].Value = txtExpireDate.Text;
                    guna2DataGridView1.Rows[n].Cells[3].Value = txtPricePerUnit.Text;
                    guna2DataGridView1.Rows[n].Cells[4].Value = txtNoOfUnits.Text;
                    guna2DataGridView1.Rows[n].Cells[5].Value = txtTotalPrice.Text;

                    totalAmount = totalAmount + int.Parse(txtTotalPrice.Text);
                    totalLabel.Text = "BDT " + totalAmount.ToString();

                    query = "UPDATE medic SET quantity ='"+newQuantity+"' WHERE mid = '"+txtMediID.Text+"'";
                    fn.setData(query, "Medicine Added.");
                }
                else
                {
                    MessageBox.Show("Medicine is Out of Stock.\n Only " + quantity + " Left","Warning !!",MessageBoxButtons.OK,MessageBoxIcon.Warning);

                }
                clearAll();
                UC_E_SellMedicine_Load(this, null);
            }
            else
            {
                MessageBox.Show("Select Medicine First.", "Information !!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
            
        }

        int valueAmount;
        String valueId;
        protected Int64 noOfunit;
        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                valueAmount =int.Parse(guna2DataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString());
                valueId = guna2DataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                noOfunit = Int64.Parse(guna2DataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString());
            }
            catch(Exception)
            {

            }
        }

        

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if(valueId != null)
            {
                try
                {
                    guna2DataGridView1.Rows.RemoveAt(this.guna2DataGridView1.SelectedRows[0].Index);
                }
                catch
                {

                }
                finally
                {
                    query = "SELECT quantity FROM medic WHERE mid = '" + valueId + "'";
                    ds = fn.getData(query);
                    quantity = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());
                    newQuantity = quantity + noOfunit;

                    query = "UPDATE medic set quantity = '" + newQuantity + "' WHERE mid ='" + valueId + "'";
                    fn.setData(query, "Medicine Remove from Cart.");
                    totalAmount = totalAmount - valueAmount;
                    totalLabel.Text = "BDT " + totalAmount.ToString();
                }
                UC_E_SellMedicine_Load(this, null);
            }
            
        }
        private void btnPurchasePrint_Click(object sender, EventArgs e)
        {
            DGVPrinter print = new DGVPrinter();
            print.Title = "Medicine Bill";
            print.SubTitle = String.Format("Date:- {0}",DateTime.Now.ToLongDateString());
            //print. SubTitle= String.Format("Time:- {0}", DateTime.Now.ToLongTimeString());
            print.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            print.PageNumbers = true;
            print.PageNumberInHeader = false;
            print.HeaderCellAlignment = StringAlignment.Near;
            print.Footer="Total Payable Amount : " +totalLabel.Text ;
            print.PrintDataGridView(guna2DataGridView1);

            totalAmount = 0;
            totalLabel.Text = "BDT 00";
            guna2DataGridView1.DataSource = 0;




        }
        private void clearAll()
        {
            txtMediID.Clear();
            txtMediName.Clear();
            txtExpireDate.ResetText();
            txtPricePerUnit.Clear();
            txtNoOfUnits.Clear();

        }
    }
}
