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

namespace Destiny.cs
{
    public partial class frm_Login : Form
    {
        public frm_Login()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=shreyas\sqlexpress01;Initial Catalog=Destiny_db;Integrated Security=True");
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
        private void frm_Login_Load(object sender, EventArgs e)
        {
            cmb_Userlogin.Focus();
            cmb_Userlogin.SelectedIndex= 1;
        }
        private void tb_Username_TextChanged(object sender, EventArgs e)
        {
            tb_Password.Enabled = true;
        }
        private void tb_Password_TextChanged(object sender, EventArgs e)
        {
            btn_Submit.Enabled = true;
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            int Cnt = 0;
            Con_Open();
            SqlCommand Cmd = new SqlCommand();
            Cmd.Connection=Con;
            Cmd.CommandText = "Select Count(*) From Login_Details Where Username = @Uname And Password = @Pwd And UserType=@usertype";

            Cmd.Parameters.Add("Uname", SqlDbType.NVarChar).Value = tb_Username.Text;
            Cmd.Parameters.Add("Pwd", SqlDbType.NVarChar).Value = tb_Password.Text;
            Cmd.Parameters.Add("usertype", SqlDbType.NVarChar).Value = cmb_Userlogin.SelectedItem;

            Cnt=Convert.ToInt32(Cmd.ExecuteScalar());

            if (Cnt > 0)
            {
                MessageBox.Show("Login Successful", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);


                frm_Home obj = new frm_Home();
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

            Con_Close();

        }

        private void cmb_Userlogin_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_Userlogin.SelectedIndex == 0)
            {
                tb_Username.Text = "Admin";
                tb_Username.Enabled = false;
            }
            else
            {
                tb_Username.Enabled = true;
                tb_Username.Clear();
            }
        }
    }
}
