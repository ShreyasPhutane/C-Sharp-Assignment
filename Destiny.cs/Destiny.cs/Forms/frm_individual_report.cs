using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.ReportSource;
using System.Collections;
using Destiny.cs.Reports;
using Destiny.cs.Datasets;

namespace Destiny.cs
{
    public partial class frm_individual_report : Form
    {
        SqlConnection  con = new SqlConnection(@"Data Source=SHREYAS\SQLEXPRESS01;Initial Catalog=Destiny_db;Integrated Security=True");
        public frm_individual_report()
        {
            InitializeComponent();
        }

        private void frm_individual_report_Load(object sender, EventArgs e)
        {


        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            Search();
        }

        void Search()
        {
            Destiny_Shared_Containt.Con_Open();

            SqlCommand cmd = Destiny_Shared_Containt.Con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from registation_details where id="+tb_Registration_ID.Text;
            cmd.ExecuteNonQuery();

            DS_Registration_Details ds = new DS_Registration_Details();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds.Registation_Details);

            cr_Individual_Biodata myreport = new cr_Individual_Biodata();
            myreport.SetDataSource(ds);
            crystalReportViewer1.ReportSource = myreport;
            Destiny_Shared_Containt.Con_Close();
        }
    }
}
