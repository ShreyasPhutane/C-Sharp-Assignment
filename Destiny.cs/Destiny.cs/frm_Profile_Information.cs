using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Destiny.cs
{
    public partial class frm_Profile_Information : Form
    {
        string candidate=null;
        public frm_Profile_Information(string candidate)
        {
            InitializeComponent();
            this.candidate = candidate;
        }

        private void frm_Profile_Information_Load(object sender, EventArgs e)
        {
            DataTable dt =  Destiny_Shared_Containt.GetDataTable("select * from registation_details where id="+candidate);

            tb_ID.Text = dt.Rows[0]["id"].ToString();

            byte[] getImg = new byte[0];
            getImg = (byte[])dt.Rows[0]["photo"];
            byte[] imgData = getImg;
            MemoryStream stream = new MemoryStream(imgData);
            pb_profile.Image = Image.FromStream(stream);

            tb_Marital_Status.Text = dt.Rows[0]["marital_status"].ToString();
            tb_First_Name.Text = dt.Rows[0]["first_name"].ToString();
            tb_Last_Name.Text = dt.Rows[0]["last_name"].ToString();
            tb_Gender.Text = dt.Rows[0]["gender"].ToString();
            dtp_DOB.Value = (DateTime)dt.Rows[0]["DOB"];
            tb_Mobile_No.Text = dt.Rows[0]["mobile_no"].ToString();
            tb_Religion.Text = dt.Rows[0]["religion"].ToString();
            tb_Caste.Text = dt.Rows[0]["caste"].ToString();
            tb_Sub_Caste.Text = dt.Rows[0]["sub_caste"].ToString();
            tb_Gothra.Text = dt.Rows[0]["gothra"].ToString();
            tb_Address.Text = dt.Rows[0]["address"].ToString();
            tb_Residing_State.Text = dt.Rows[0]["residing_state"].ToString();
            tb_Residing_City.Text = dt.Rows[0]["residing_city"].ToString();
            tb_Height.Text = dt.Rows[0]["height"].ToString();
            tb_Weight.Text = dt.Rows[0]["weight"].ToString();
            tb_Body_Type.Text = dt.Rows[0]["body_type"].ToString();
            tb_Complexion.Text = dt.Rows[0]["complexion"].ToString();
            tb_Highest_Education.Text = dt.Rows[0]["highest_education"].ToString();
            tb_Employed_In.Text = dt.Rows[0]["employed_in"].ToString();
            tb_Monthly_Income.Text = dt.Rows[0]["monthly_income"].ToString();
            tb_Rassi_Moon_Sign.Text = dt.Rows[0]["Rassi_Moon_Sign"].ToString();
            tb_Family_Status.Text = dt.Rows[0]["family_status"].ToString();
            tb_Family_Type.Text = dt.Rows[0]["family_type"].ToString();
            tb_Family_Values.Text = dt.Rows[0]["family_values"].ToString();

        }
    }
}
