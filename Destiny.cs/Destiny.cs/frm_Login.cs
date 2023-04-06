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
            tb_Username.Focus();
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
            Cmd.CommandText = "Select Count(*) From Login_Details Where Username = @Uname And Password = @Pwd ";

            Cmd.Parameters.Add("Uname", SqlDbType.NVarChar).Value = tb_Username.Text;
            Cmd.Parameters.Add("Pwd", SqlDbType.NVarChar).Value = tb_Password.Text;

            Cnt=Convert.ToInt32(Cmd.ExecuteScalar());

            if (Cnt > 0)
            {
                MessageBox.Show("Login Successful", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);


                Frm_Create_Profile_For obj = new Frm_Create_Profile_For();
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
    }
}
