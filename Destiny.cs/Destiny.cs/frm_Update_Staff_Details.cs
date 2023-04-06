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
    public partial class frm_Update_Staff_Details : Form
    {
        public frm_Update_Staff_Details()
        {
            InitializeComponent();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            Destiny_Shared_Containt.Con_Open();

            if (tb_Staff_Name.Text != "" && tb_Mob_No.Text != "" && tb_Alt_Contact_No.Text != "" && tb_Bank_Details.Text != "" && cmb_Designation.Text != "")
            {
                SqlCommand cmd = new SqlCommand("Update Staff_Details Set Staff_Name = @Name, Mobile_No = @Mob_No, Alt_Contact_No = @Alt_No, Office_Address = @Off_Address,  Designation = @Post,Bank_Details = @BankDetails, where Staff_ID = @ID ", Destiny_Shared_Containt.Con);

                cmd.Parameters.Add("@ID", SqlDbType.Int).Value = tb_Staff_ID.Text;
                cmd.Parameters.Add("@Name", SqlDbType.VarChar).Value = tb_Staff_Name.Text;
                cmd.Parameters.Add("@Mob_No", SqlDbType.Decimal).Value = tb_Mob_No.Text;
                cmd.Parameters.Add("@Alt_No", SqlDbType.Decimal).Value = tb_Alt_Contact_No.Text;
                cmd.Parameters.Add("@Post", SqlDbType.VarChar).Value = cmb_Designation.Text;
                cmd.Parameters.Add("@BankDetails", SqlDbType.VarChar).Value = tb_Bank_Details.Text;
               

                cmd.ExecuteNonQuery();

                MessageBox.Show("Staff Details Updated Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            tb_Staff_ID.Clear();
            tb_Staff_Name.Clear();
            tb_Mob_No.Clear();
            tb_Alt_Contact_No.Clear();
            tb_Adhaar_No.Clear();
            tb_PAN_No.Clear();
            tb_Bank_Details.Clear();
            cmb_Designation.SelectedIndex = -1;

            tb_Staff_ID.Enabled = true;
            btn_Refresh.Enabled = false;
            btn_Update.Enabled = false;
        }

        private void frm_Update_Staff_Details_Load(object sender, EventArgs e)
        {
            Clear_Controls();
            tb_Staff_ID.Focus();
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            Clear_Controls();
            tb_Staff_ID.Focus();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            Destiny_Shared_Containt.Con_Open();

            SqlCommand Cmd = new SqlCommand("Select * From Staff_Details where Staff_ID = " + tb_Staff_ID.Text + " ", Destiny_Shared_Containt.Con);

            var obj = Cmd.ExecuteReader();

            if (obj.Read())
            {
                tb_Staff_Name.Text = obj.GetString(obj.GetOrdinal("Staff_Name"));
                tb_Mob_No.Text = (obj["Mobile_No"].ToString());
                tb_Alt_Contact_No.Text = (obj["Alt_Contact_No"].ToString());
                tb_Adhaar_No.Text = (obj["Adhaar_No"].ToString());
                tb_PAN_No.Text = obj.GetString(obj.GetOrdinal("PAN_No"));
                tb_Bank_Details.Text = obj.GetString(obj.GetOrdinal("Bank_Details"));
                cmb_Designation.Text = obj.GetString(obj.GetOrdinal("Designation"));

                tb_Staff_ID.Enabled = false;
                btn_Refresh.Enabled = true;
                btn_Update.Enabled = true;
            }
            else
            {
                MessageBox.Show("Invalid Staff ID!!!");
                Clear_Controls();
            }

            obj.Dispose();
            Destiny_Shared_Containt.Con_Close();
        }
    }
}
