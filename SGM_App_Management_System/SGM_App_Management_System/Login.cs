using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SGM_App_Management_System
{
    public partial class frm_Login : Form
    {
        public frm_Login()
        {
            InitializeComponent();
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            if (tb_Username.Text == "Admin" && tb_Password.Text == "Admin123")
            {
                MessageBox.Show("Login Succesful", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frm_Add_New_Student Obj = new frm_Add_New_Student();
                this.Hide();
                Obj.Show();

            }
            else
            {
                lbl_Error.Text = "Enter Valid Username or Password";
                lbl_Error.ForeColor = Color.OrangeRed;

            }
            tb_Username.Clear();
            tb_Password.Clear();

            tb_Password.Enabled = false;
            btn_Submit.Enabled = false;

            tb_Username.Focus();


        }

        private void txt_Username_TextChanged(object sender, EventArgs e)
        {
            lbl_Error.Visible = true;
            tb_Password.Enabled = true;

        }

        private void txt_Password_TextChanged(object sender, EventArgs e)
        {
            btn_Submit.Enabled = true;
        }
       
    }
}
