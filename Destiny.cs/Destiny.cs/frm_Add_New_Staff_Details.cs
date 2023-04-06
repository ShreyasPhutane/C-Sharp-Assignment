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

namespace Destiny.cs
{
    public partial class frm_Add_New_Staff_Details : Form
    {
        public frm_Add_New_Staff_Details()
        {
            InitializeComponent();
        }
        private void frm_Add_New_Staff_Details_Load(object sender, EventArgs e)
        {
            Clear_Controls();
            tb_Staff_Name.Focus();
        }
        private void btn_Save_Click(object sender, EventArgs e)
        {
            Destiny_Shared_Containt.Con_Open();

            if ( tb_Staff_Name.Text != "" && tb_Mob_No.Text != "" && tb_Alt_Contact_No.Text != "" && tb_Adhaar_No.Text != "" && tb_PAN_No.Text != "" && tb_Bank_Details.Text != "" && cmb_Designation.Text != "")
            {
                SqlCommand cmd = new SqlCommand("Insert Into Staff_Details Values (@ID, @Name,@Mob_No, @Alt_No,@Post,@JoinDate, @Adhar_No, @PAN_No, @BankDetails,) ", Destiny_Shared_Containt.Con);

                cmd.Parameters.Add("@ID", SqlDbType.Int).Value = tb_Staff_ID.Text;
                cmd.Parameters.Add("@Name", SqlDbType.VarChar).Value = tb_Staff_Name.Text;
                cmd.Parameters.Add("@Mob_No", SqlDbType.Decimal).Value = tb_Mob_No.Text;
                cmd.Parameters.Add("@Alt_No", SqlDbType.Decimal).Value = tb_Alt_Contact_No.Text;
                cmd.Parameters.Add("@Post", SqlDbType.VarChar).Value = cmb_Designation.Text;
                cmd.Parameters.Add("@JoinDate", SqlDbType.Date).Value = dtp_Joining_Date.Value.Date;  
                cmd.Parameters.Add("@Adhar_No", SqlDbType.Decimal).Value = tb_Adhaar_No.Text;
                cmd.Parameters.Add("@PAN_No", SqlDbType.NVarChar).Value = tb_PAN_No.Text;
                cmd.Parameters.Add("@BankDetails", SqlDbType.VarChar).Value = tb_Bank_Details.Text;
               

                cmd.ExecuteNonQuery();

                MessageBox.Show("Staff Details Saved Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear_Controls();
            }
            else
            {
                MessageBox.Show("1st Fill All The Fields!!!", "Fill Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            Destiny_Shared_Containt.Con_Close();
        }

        void Clear_Controls()
        {
            tb_Staff_ID.Text = Convert.ToString(Destiny_Shared_Containt.Auto_Incr("Staff_Details", "Staff_ID", 1));
           // tb_Staff_ID.Text = Destiny_Shared_Containt.GetAutoId("select max(ID) from Staff_Details").ToString();
            tb_Staff_Name.Clear();
            tb_Mob_No.Clear();
            tb_Alt_Contact_No.Clear();
            tb_Adhaar_No.Clear();
            tb_PAN_No.Clear();
            tb_Bank_Details.Clear();
            cmb_Designation.SelectedIndex = -1;

            dtp_Joining_Date.ResetText();
        }
      
        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            Clear_Controls();
            tb_Staff_Name.Focus();
        }

       
    }
             
}
