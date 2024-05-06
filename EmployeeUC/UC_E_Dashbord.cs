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
    public partial class UC_E_Dashbord : UserControl
    {
        function fn = new function();
        String query;
        DataSet ds;
        Int64 count;
        

        public UC_E_Dashbord()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            chart1.Series["Valid Medicines"].Points.Clear();
            chart1.Series["Expired Medicines"].Points.Clear();
            loadChart();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void UC_E_Dashbord_Load(object sender, EventArgs e)
        {
            loadChart();
        }
        public void loadChart()
        {
            query = "SELECT count(mname) FROM medic WHERE eDate >= getdate()";
            ds = fn.getData(query);
            count = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());
            this.chart1.Series["Valid Medicines"].Points.AddXY("Medicine Validity Chart",count);

            query = "SELECT count(mname) FROM medic WHERE eDate <= getdate()";
            ds=fn.getData(query);
            count=Int64.Parse(ds.Tables[0].Rows[0][0].ToString());
            this.chart1.Series["Expired Medicines"].Points.AddXY("Medicine Validity Chart", count);


        }
    }
}
