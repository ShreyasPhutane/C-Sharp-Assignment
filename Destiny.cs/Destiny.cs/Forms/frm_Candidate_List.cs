using Destiny.cs.Reports;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Destiny.cs.Forms
{
    public partial class frm_Candidate_List : Form
    {
        public frm_Candidate_List()
        {
            InitializeComponent();
        }

        public void frm_load(Object sender, EventArgs e)
        {
          //Search();
        }

        void Search()
        {
            Destiny_Shared_Containt.Con_Open();

            SqlCommand cmd = Destiny_Shared_Containt.Con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            if (cmb_Sort_By.SelectedItem.Equals("All"))
            {
                if (cmb_Status.SelectedItem.Equals("All"))
                {
                      cmd.CommandText = "select * from registation_details";
                }
                else
                    cmd.CommandText = "select * from registation_details where marital_status='" + cmb_Status.SelectedItem + "'";

            }
            else
            {
                if (cmb_Status.SelectedItem.Equals("All"))
                {
                    cmd.CommandText = "select * from registation_details where Gender='" + cmb_Sort_By.SelectedItem + "'";
                }
                else
                cmd.CommandText = "select * from registation_details where Gender='"+cmb_Sort_By.SelectedItem+"' and marital_status='"+cmb_Status.SelectedItem+"'";
            }
            
            cmd.ExecuteNonQuery();

            Datasets.DS_Registration_Details ds = new Datasets.DS_Registration_Details();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds.Registation_Details);

            CR_Candidate_LIst myreport = new CR_Candidate_LIst();
            myreport.SetDataSource(ds);
            crystalReportViewer1.ReportSource = myreport;
            Destiny_Shared_Containt.Con_Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            if (cmb_Sort_By.SelectedItem != null && cmb_Status.SelectedItem != null)
            {
                Search();
            }
            else
                MessageBox.Show("Select both options");
        }
    }
}
