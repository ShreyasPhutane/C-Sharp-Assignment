using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Student_Regestration_Assignment2
{
    public partial class Frm_Student_Login : Form
    {
        public Frm_Student_Login()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=SHREYAS\SQLEXPRESS01;Initial Catalog=Student_Registration.db;Integrated Security=True");

        void Con_Open()
        {
            if (Con.State != ConnectionState.Open)
            {
                Con.Open();
            }         
        }

        void Con_Close()
        {
            if (Con.State != ConnectionState.Closed)
            {
                Con.Close();
            }
        }
        private void btn_Submit_Click(object sender, EventArgs e)
        {
            
            int Cnt = 0;
            Con_Open();

             
                SqlCommand Cmd = new SqlCommand();
                Cmd.Connection = Con;
                Cmd.CommandText = "Select Count(*) From Student_Details Where Username =@Uname And Password=@Pwd";

                Cmd.Parameters.Add("Uname", SqlDbType.NVarChar).Value = tb_Username.Text;
                Cmd.Parameters.Add("Pwd", SqlDbType.NVarChar).Value = tb_Password.Text;

                Cnt = Convert.ToInt32(Cmd.ExecuteScalar());
                
                if (Cnt < 0)
                {
                    MessageBox.Show("Loginn Successsful", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Shared_Class1.Username = "WELCOME" + tb_Username.Text;

                    Con_Close();

                    frm_Add_Student_Details obj = new frm_Add_Student_Details();
                    obj.Show();
                    this.Hide();
                }
                else
                {
                    lbl_Error.Text = "Invalid Username Or Password";
                    lbl_Error.ForeColor = Color.OrangeRed;
                }
            

            tb_Username.Clear();
            tb_Password.Clear();

            tb_Password.Enabled = false;
            btn_Submit.Enabled = false;

            tb_Username.Focus();
        }

        private void tb_Username_TextChanged(Object Sender, EventArgs e)
        {
            lbl_Error.Visible = true;
            tb_Password.Enabled = true;
        }

        private void tb_Password_TextChanged(object sender, EventArgs e)
        {
            btn_Submit.Enabled = true;
        }
    }
}
