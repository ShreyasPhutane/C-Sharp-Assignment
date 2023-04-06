using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Student_Regestration_Assignment2
{
    public partial class Frm_Student_Login : Form
    {
        public Frm_Student_Login()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=Student_Registration_db;Integrated Security=True");

        void Con_Open()
        {
            if (Con.State != ConnectionState.Open)
            {
                Con.Open();
            }
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
            Cmd.CommandText = "Select Count(*) From Login_Details Where Username = @Uname And Password = @Pwd";

            Cmd.Parameters.Add("Uname", SqlDbType.NVarChar).Value = tb_Username.Text;
            Cmd.Parameters.Add("Pwd", SqlDbType.NVarChar).Value = tb_Password.Text;

            Cnt = Convert.ToInt32(Cmd.ExecuteScalar());

            if (Cnt > 0)
            {
                MessageBox.Show("Login Succesful", "Welcome", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Information);
                Shared_Class.Username = "Welcome" + tb_Username.Text;

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
            tb_Username.Enabled = false;
            tb_Password.Enabled = false;

            tb_Username.Focus();
            Con.Close();
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
