using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Destiny.cs.Reports;
using Destiny.cs.Datasets;
using System.Data.SqlClient;

namespace Destiny.cs.Forms
{
    public partial class frm_Districtwise_Report : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=SHREYAS\SQLEXPRESS01;Initial Catalog=Destiny_db;Integrated Security=True");
        public frm_Districtwise_Report()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Search();
        }

        void Search()
        {
            Destiny_Shared_Containt.Con_Open();

            SqlCommand cmd = Destiny_Shared_Containt.Con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from registation_details where Residing_city="+cmb_Select_district.SelectedItem;
            
            cmd.ExecuteNonQuery();

            DS_Registration_Details ds = new DS_Registration_Details();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds.Registation_Details);

            CR_Districtwise_Report myreport = new CR_Districtwise_Report();
            myreport.SetDataSource(ds);
            crystalReportViewer1.ReportSource = myreport;
            Destiny_Shared_Containt.Con_Close();
        }

        private void frm_Districtwise_Report_Load(object sender, EventArgs e)
        {
            Destiny_Shared_Containt.Con_Open();

            SqlCommand cmd = Destiny_Shared_Containt.Con.CreateCommand();
            cmd.CommandText = "";
        }
    }
}
