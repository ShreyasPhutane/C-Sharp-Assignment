using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Destiny.cs
{
    public partial class frm_Matching_Form : Form
    {
        public frm_Matching_Form()
        {
            InitializeComponent();
        }
        
        private void btn_Search_Click(object sender, EventArgs e)
        {
            String Match_Query = "Select ID, Gender, Marital_Status, Caste, Sub_Caste, Residing_City, Complexion, Food, Family_Type, Highest_Education,Occupation, Employed_In, Monthly_Income from Registation_details where ";

            if (cmb_Looking_for.Text == "" || cmb_Marital_Status.Text == "" || cmb_Caste.Text == "" || cmb_Sub_Caste.Text=="" || cmb_Residing_City.Text=="" || cmb_Complexion.Text=="" || cmb_Family_Type.Text=="" || cmb_Highest_Educatiion.Text=="" || cmb_Occupation.Text=="" || cmb_Employed_In.Text=="" || cmb_Monthly_Income.Text=="")
            {
                MessageBox.Show("Select All Options");
            }
            else
            {

                if (cmb_Marital_Status.Text != "Neutral")
                {
                    Match_Query += "Marital_Status = '" + cmb_Marital_Status.Text + "' And ";
                }
                if (cmb_Caste.Text != "Neutral")
                {
                    Match_Query += "Caste = '" + cmb_Caste.Text + "' And ";
                }
                if (cmb_Sub_Caste.Text != "Neutral")
                {
                    Match_Query += "Sub_Caste = '" + cmb_Sub_Caste.Text + "' And ";
                }
                if (cmb_Residing_City.Text != "Neutral")
                {
                    Match_Query += "Residing_City = '" + cmb_Residing_City.Text + "' And ";
                }
                if (cmb_Complexion.Text != "Neutral")
                {
                    Match_Query += "Complexion = '" + cmb_Complexion.Text + "' And ";
                }
                if (cmb_Food.Text != "Neutral")
                {
                    Match_Query += "Food = '" + cmb_Food.Text + "' And ";
                }
                if (cmb_Family_Type.Text != "Neutral")
                {
                    Match_Query += "Family_Type = '" + cmb_Family_Type.Text + "' And ";
                }
                if (cmb_Highest_Educatiion.Text != "Neutral")
                {
                    Match_Query += "Highest_Education = '" + cmb_Highest_Educatiion.Text + "' And ";
                }
                if (cmb_Occupation.Text != "Neutral")
                {
                    Match_Query += "Occupation = '" + cmb_Occupation.Text + "' And ";
                }
                if (cmb_Employed_In.Text != "Neutral")
                {
                    Match_Query += "Employed_In = '" + cmb_Employed_In.Text + "' And ";
                }
                if (cmb_Monthly_Income.Text != "Neutral")
                {
                    Match_Query += "Monthly_Income = '" + cmb_Monthly_Income.Text + "' And ";
                }

                Match_Query += "Gender = '" + cmb_Looking_for.Text + "'";


                DataTable dt = Destiny_Shared_Containt.GetDataTable(Match_Query);
                dataGridView1.DataSource = dt;
            }
        }

        private void frm_Matching_Form_Load(object sender, EventArgs e)
        {
            BindComboBox();
            DataTable dt = Destiny_Shared_Containt.GetDataTable("select ID, Gender, Marital_Status, Caste, Sub_Caste, Residing_City, Complexion, Food, Family_Type, Highest_Education,Occupation, Employed_In, Monthly_Income from Registation_details");

            dataGridView1.DataSource=dt;
        }

        void BindComboBox()
        {
            cmb_Looking_for.Items.Clear();
           Destiny_Shared_Containt.Con_Open();
            SqlCommand Cmd = new SqlCommand();
            SqlDataReader Dr;
            Cmd.Connection = Destiny_Shared_Containt.Con;
            Cmd.CommandText = "select Distinct (Gender) From Registation_Details";
            Dr = Cmd.ExecuteReader();
            while (Dr.Read())
            {
                cmb_Looking_for.Items.Add(Dr.GetString(Dr.GetOrdinal("Gender")));
            }
            Cmd.Dispose();
            Dr.Close();
            Destiny_Shared_Containt.Con_Close();
        }

        private void cmb_Looking_for_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmb_Marital_Status.Items.Clear();
            Destiny_Shared_Containt.Con_Open();
            SqlCommand Cmd = new SqlCommand();
            SqlDataReader Dr;
            Cmd.Connection = Destiny_Shared_Containt.Con;
            Cmd.CommandText = "select Distinct(Marital_Status) From Registation_Details where Gender = '" + cmb_Looking_for.Text  + "' ";
            Dr = Cmd.ExecuteReader();
            while (Dr.Read())
            {
                cmb_Marital_Status.Items.Add(Dr.GetString(Dr.GetOrdinal("Marital_Status")));
            }
            Cmd.Dispose();
            Dr.Close();
            Destiny_Shared_Containt.Con_Close();
        }

        private void cmb_Caste_SelectedIndexChanged(object sender, EventArgs e)
        {
            //cmb_Caste.Items.Clear();
            //Destiny_Shared_Containt.Con_Open();
            //SqlCommand Cmd = new SqlCommand();
            //SqlDataReader Dr;
            //Cmd.Connection = Destiny_Shared_Containt.Con;
            //Cmd.CommandText = "select Distinct(Caste) From Registation_Details where Marital_Status = '" + cmb_Marital_Status + "' ";
            //Dr = Cmd.ExecuteReader();
            //while (Dr.Read())
            //{
            //   cmb_Caste.Items.Add(Dr.GetString(Dr.GetOrdinal("Caste")));
            //}
            //Cmd.Dispose();
            //Dr.Close();
            //Destiny_Shared_Containt.Con_Close();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            string value = dataGridView1.Rows[row].Cells["id"].Value.ToString();

            frm_Profile_Information profile = new frm_Profile_Information(value);
            profile.ShowDialog();
            this.Hide();
        }
    }
}


