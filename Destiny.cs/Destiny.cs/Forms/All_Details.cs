using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace Destiny.cs
{
    public partial class frm_All_Details : Form
    {
        String MaritalStatus;
        String food;
        String Physical;
        String Smoking;
        String Drinking;
        String Dosh;
        string profile_for;
        byte[] Image_Data= null;
        static Panel current_Panel = null;
        String Status;
        String PhysicalState;
        int Personal_id;
        string fname, lname;
        bool paid = false;

        public frm_All_Details(string profile)
        {
            InitializeComponent();
            profile_for = profile;
        }

        private void pb_Log_Out_Click(object sender, EventArgs e)
        {
            DialogResult Res = MessageBox.Show("Are You sure to Quit", "Log Out", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (Res == DialogResult.Yes)
            {
                frm_Login Obj = new frm_Login();
                this.Hide();
                Obj.Show();
            }
        }

        void do_payment()
        {
            frm_Registration_Payment frm = new frm_Registration_Payment(Personal_id,fname,lname);
            frm.ShowDialog();
            paid = frm.PaidStatus;
        }

        private void btn_Save_Details_Click(object sender, EventArgs e)
        {
            fname= tb_First_Name.Text;
            lname= tb_Last_Name.Text;
            do_payment();

            if (paid == true)
            {
                Destiny_Shared_Containt.Con_Open();
                if (tb_ID.Text != "" && tb_First_Name.Text != "" && tb_Last_Name.Text != "" && cmb_Gender.Text != "" && dtp_DOB.Text != "" && tb_Mobile_No.Text != "" && cmb_Religion.Text != "" && cmb_Caste.Text != "" && cmb_Sub_Caste.Text != "" && tb_Gothra.Text != "" && tb_Address.Text != "" && cmb_Residing_State.Text != "" && cmb_Residing_City.Text != "" && tb_Email_ID.Text != "" && tb_Height.Text != "" && tb_Weight.Text != "" && cmb_Blood_Group.Text != "" && cmb_Body_Type.Text != "" && cmb_Complexion.Text != "" && cmb_Highest_Educatiion.Text != "" && cmb_Occupation.Text != "" && cmb_Employed_In.Text != "" && cmb_Monthly_Income.Text != "" && tb_Star.Text != "" && tb_Rassi_Moon_Sign.Text != "" && cmb_Family_Status.Text != "" && cmb_Family_Type.Text != "" && cmb_Family_Values.Text != "")
                    //for marital status checked items

                    if (rb_Never_Married.Checked == true)
                    {
                        MaritalStatus = rb_Never_Married.Text.ToString();
                    }
                    else if (rb_Widow.Checked == true)
                    {
                        MaritalStatus = rb_Widow.Text.ToString();
                    }
                    else if (rb_Divorced.Checked == true)
                    {
                        MaritalStatus = rb_Divorced.Text.ToString();
                    }
                    else
                    {
                        MaritalStatus = rb_Awaiting_Divorced.Text.ToString();
                    }

                //for food checked items
                if (rb_Vegetarian.Checked == true)
                {
                    food = rb_Vegetarian.Text.ToString();
                }
                else if (rb_Non_Vegetarian.Checked == true)
                {
                    food = rb_Non_Vegetarian.Text.ToString();
                }
                else
                {
                    food = rb_Eggetarian.Text.ToString();
                }

                //for smoking checked items
                if (rb_No.Checked == true)
                {
                    Smoking = rb_No.Text.ToString();
                }
                else if (rb_Occasionally.Checked == true)
                {
                    Smoking = rb_Occasionally.Text.ToString();
                }
                else
                {
                    Smoking = rb_Yes.Text.ToString();
                }
                //for Drinking checked items

                if (rb_No_.Checked == true)
                {
                    Drinking = rb_No_.Text.ToString();
                }
                else if (rb_Drink_Socially.Checked == true)
                {
                    Drinking = rb_Drink_Socially.Text.ToString();
                }
                else
                {
                    Drinking = rb_Yes_.Text.ToString();
                }

                //for physical checked items

                if (rb_normal.Checked == true)
                {
                    Physical = rb_normal.Text.ToString();
                }
                else
                {
                    Physical = rb_Physically_Challenged.Text.ToString();
                }
                //for dosh value checked
                if (rb_N.Checked == true)
                {
                    Dosh = rb_N.Text.ToString();
                }
                else if (rb_Y.Checked == true)
                {
                    Dosh = rb_Y.Text.ToString();
                }
                else
                {
                    Dosh = rb_Dont_Know.Text.ToString();
                }
                //Validation for Date of Birth
                if (cmb_Gender.SelectedIndex == 0)
                {
                    if (DateTime.Today.AddYears(-21) < dtp_DOB.Value.Date)
                    {
                        MessageBox.Show("Age is  required 21 over", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        dtp_DOB.Focus();
                        return;
                    }
                }
                else
                {
                    if (DateTime.Today.AddYears(-18) < dtp_DOB.Value.Date)
                    {
                        MessageBox.Show("Age is  required 21 over", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        dtp_DOB.Focus();
                        return;
                    }
                }

                String strsave = "Insert Into Registation_Details Values(@Photo,@Profile_For,@ID,@First_Name,@Last_Name,@Gender,@DOB,@Mobile_No,@Religion,@Marital_Status,@Caste,@Sub_Caste,@Gothra,@Address,@Residing_State,@Residing_City,@Email_ID,@Height,@Weight,@Body_Type,@Complexion,@Physical_Status,@Food,@Smoking,@Drinking,@Highest_Education,@Occupation,@Employed_In,@Monthly_Income,@Have_Dosh,@Star,@Rassi_Moon_Sign,@Family_Status,@Family_Type,@Family_Values,@Ideal_Description,@Blood_Group)";
                SqlCommand cmd = new SqlCommand(strsave, Destiny_Shared_Containt.Con);

                cmd.Parameters.AddWithValue("@Photo", Image_Data);
                cmd.Parameters.AddWithValue("@Profile_For", tb_Profle_for.Text);
                cmd.Parameters.AddWithValue("@ID", tb_ID.Text);
                cmd.Parameters.AddWithValue("@First_Name", tb_First_Name.Text);
                cmd.Parameters.AddWithValue("@Last_Name", tb_Last_Name.Text);
                cmd.Parameters.AddWithValue("@Gender", cmb_Gender.Text);
                cmd.Parameters.AddWithValue("@DOB", dtp_DOB.Value);
                cmd.Parameters.AddWithValue("@Mobile_No", tb_Mobile_No.Text);
                cmd.Parameters.AddWithValue("@Religion", cmb_Religion.Text);
                cmd.Parameters.AddWithValue("@Marital_Status", MaritalStatus);
                cmd.Parameters.AddWithValue("@Caste", cmb_Caste.Text);
                cmd.Parameters.AddWithValue("@Sub_Caste", cmb_Sub_Caste.Text);
                cmd.Parameters.AddWithValue("@Gothra", tb_Gothra.Text);
                cmd.Parameters.AddWithValue("@Address", tb_Address.Text);
                cmd.Parameters.AddWithValue("@Residing_State", cmb_Residing_State.Text);
                cmd.Parameters.AddWithValue("@Residing_City", cmb_Residing_City.Text);
                cmd.Parameters.AddWithValue("@Email_ID", tb_Email_ID.Text);
                cmd.Parameters.AddWithValue("@Height", tb_Height.Text);
                cmd.Parameters.AddWithValue("@Weight", tb_Weight.Text);
                cmd.Parameters.AddWithValue("@Body_Type", cmb_Body_Type.Text);
                cmd.Parameters.AddWithValue("@Complexion", cmb_Complexion.Text);
                cmd.Parameters.AddWithValue("@Physical_Status", Physical);
                cmd.Parameters.AddWithValue("@Food", food);
                cmd.Parameters.AddWithValue("@Smoking", Smoking);
                cmd.Parameters.AddWithValue("@Drinking", Drinking);
                cmd.Parameters.AddWithValue("@Highest_Education", cmb_Highest_Educatiion.Text);
                cmd.Parameters.AddWithValue("@Occupation", cmb_Occupation.Text);
                cmd.Parameters.AddWithValue("@Employed_In", cmb_Employed_In.Text);
                cmd.Parameters.AddWithValue("@Monthly_Income", cmb_Monthly_Income.Text);
                cmd.Parameters.AddWithValue("@Have_Dosh", Dosh);
                cmd.Parameters.AddWithValue("@Star", tb_Star.Text);
                cmd.Parameters.AddWithValue("@Rassi_Moon_Sign", tb_Rassi_Moon_Sign.Text);
                cmd.Parameters.AddWithValue("@Family_Status", cmb_Family_Status.Text);
                cmd.Parameters.AddWithValue("@Family_Type", cmb_Family_Type.Text);
                cmd.Parameters.AddWithValue("@Family_Values", cmb_Family_Values.Text);
                cmd.Parameters.AddWithValue("@Ideal_Description", tb_Ideal_Description.Text);
                cmd.Parameters.AddWithValue("@Blood_Group", cmb_Blood_Group.Text);
                cmd.ExecuteNonQuery();


                Destiny_Shared_Containt.Con_Close();

                MessageBox.Show("Record Successfully Saved");
            }
        }

        //for image upload
        private void btn_Upload_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "Image files (*.jpg, *.jpeg, *.png) | *.jpg; *.jpeg; *.png";
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Image_Data = File.ReadAllBytes(openFileDialog1.FileName);
                DisplayImage.Image = Image.FromFile(openFileDialog1.FileName);
            }

        }
        //Load Form 
        private void frm_All_Details_Load(object sender, EventArgs e)
        {
            current_Panel = tc_Registration.SelectedTab;
            tb_Profle_for.Text = profile_for;
            tb_ID.Text= Destiny_Shared_Containt.GetAutoId("select max(ID) from registation_details").ToString();
            Personal_id= Convert.ToInt32(tb_ID.Text);
        }

        //for next tab control panel
        private void pictureBox6_Click(object sender, EventArgs e)
        {
            tc_Registration.SelectedIndex = 1;
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            tc_Registration.SelectedIndex = 2;
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            tc_Registration.SelectedIndex = 3;
        }

        private void pictureBox5_Click_1(object sender, EventArgs e)
        {
            tc_Registration.SelectedIndex = 4;
        }
        private void pictureBox7_Click(object sender, EventArgs e)
        {
            tc_Registration.SelectedIndex = 5;
        }
        //code for save Expectation Details
        private void btn_Save_Click(object sender, EventArgs e)
        {
            Destiny_Shared_Containt.Con_Open();
            if ( tb_ex_ID.Text != "" && cmb_ex_Caste.Text != "" && cmb_ex_Sub_Caste.Text != "" && cmb_ex_Residing_City.Text != "" && cmb_ex_Body_Type.Text != "" && cmb_ex_Complexion.Text !="" && cmb_ex_Food.Text !="" && cmb_ex_Smoking.Text !="" && cmb_ex_Drinking.Text !="" && cmb_ex_Highest_Education.Text !="" && cmb_ex_Occupation.Text !="" && cmb_ex_Employed_In.Text !="" && cmb_ex_Monthly_Income.Text !="" && cmb_ex_Family_Status.Text !="" && cmb_ex_Family_Type.Text != "" ) 
            
            //for Expectation Marital Status
            if (rb_Never_Married.Checked == true)
            {
                Status = rb_Never_Married.Text.ToString();
            }
            else if (rb_Widow.Checked == true)
            {
                Status = rb_Widow.Text.ToString();
            }
            else if (rb_Divorced.Checked == true)
            {
                Status = rb_Divorced.Text.ToString();
            }
            else
            {
                Status = rb_Awaiting_Divorced.Text.ToString();
            }

            // for Expectation Physical Status
            if (rb_normal.Checked == true)
            {
                PhysicalState = rb_normal.Text.ToString();
            }
            else
            {
                PhysicalState = rb_Physically_Challenged.Text.ToString();
            }

            String strSave = "Insert Into Expectation_Details Values(@ID,@Marital_Status,@Caste,@Sub_Caste,@Residing_City,@Body_Type,@Complexion,@Physical_Status,@Food,@Smoking,@Drinking,@Highest_Education,@Occupation,@Employed_In,@Monthly_Income,@Family_Status,@Family_Type)";
            SqlCommand cmd = new SqlCommand(strSave, Destiny_Shared_Containt.Con);

            cmd.Parameters.AddWithValue("@ID", tb_ex_ID.Text);
            cmd.Parameters.AddWithValue("@Marital_Status", Status);
            cmd.Parameters.AddWithValue("@Caste", cmb_ex_Caste.Text);
            cmd.Parameters.AddWithValue("Sub_Caste", cmb_ex_Sub_Caste.Text);
            cmd.Parameters.AddWithValue("Residing_City", cmb_ex_Residing_City.Text);
            cmd.Parameters.AddWithValue("@Body_type", cmb_ex_Body_Type.Text);
            cmd.Parameters.AddWithValue("@Complexion", cmb_ex_Complexion.Text);
            cmd.Parameters.AddWithValue("@Physical_Status", PhysicalState);
            cmd.Parameters.AddWithValue("@Food", cmb_ex_Food.Text);
            cmd.Parameters.AddWithValue("@Smoking", cmb_ex_Smoking.Text);
            cmd.Parameters.AddWithValue("@Drinking", cmb_ex_Drinking.Text);
            cmd.Parameters.AddWithValue("@Highest_Education", cmb_ex_Highest_Education.Text);
            cmd.Parameters.AddWithValue("@Occupation", cmb_ex_Occupation.Text);
            cmd.Parameters.AddWithValue("@Employed_In", cmb_ex_Employed_In.Text);
            cmd.Parameters.AddWithValue("@Monthly_Income", cmb_ex_Monthly_Income.Text);
            cmd.Parameters.AddWithValue("@Family_Status", cmb_ex_Family_Status.Text);
            cmd.Parameters.AddWithValue("@Family_Type", cmb_ex_Family_Type.Text);
            cmd.ExecuteNonQuery();
            Destiny_Shared_Containt.Con.Close();

            MessageBox.Show("Record Successfully Saved"); 
        }

        private void tc_Registration_Selected(object sender, TabControlEventArgs e)
        {
            tb_ex_ID.Text = Personal_id.ToString();
        }

        private void Only_Text(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsLetter(e.KeyChar) || (e.KeyChar == (char)Keys.Back) || (e.KeyChar == (char)Keys.Space) || (e.KeyChar == (char)Keys.ShiftKey) || (e.KeyChar == (char)Keys.CapsLock)))
            {
                e.Handled = true;
            }
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {

            String strsave = "Update Registation_Details Values(@Photo,@Profile_For,@ID,@First_Name,@Last_Name,@Gender,@DOB,@Mobile_No,@Religion,@Marital_Status,@Caste,@Sub_Caste,@Gothra,@Address,@Residing_State,@Residing_City,@Email_ID,@Height,@Weight,@Body_Type,@Complexion,@Physical_Status,@Food,@Smoking,@Drinking,@Highest_Education,@Occupation,@Employed_In,@Monthly_Income,@Have_Dosh,@Star,@Rassi_Moon_Sign,@Family_Status,@Family_Type,@Family_Values,@Ideal_Description,@Blood_Group)";
            SqlCommand cmd = new SqlCommand(strsave, Destiny_Shared_Containt.Con);

            cmd.Parameters.AddWithValue("@Ideal_Description", tb_Ideal_Description.Text);

            cmd.ExecuteNonQuery();


            Destiny_Shared_Containt.Con_Close();

            MessageBox.Show("Record Successfully Saved");
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
           
            frm_Home obj = new frm_Home();
            this.Hide();
            obj.Show();
        }

        

        private void Only_Numeric(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
            {
                e.Handled = true;
            }
        }

      
    }
}
