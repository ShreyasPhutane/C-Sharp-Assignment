using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Student_Registration
{
    public partial class frm_SGM_Login : Form
    {
        public frm_SGM_Login()
        {
            InitializeComponent();
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            if (((tb_Username.Text == "Admin") && (tb_Password.Text == "A@123")) || ((tb_Username.Text == "A") && (tb_Password.Text == "AA")))
            {   
                MessageBox.Show("Login Successful", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);

                frm_Add_Student_Details obj = new frm_Add_Student_Details();
                obj.Show();
                this.Hide();
            }
            else
            {
                lbl_Error.Text = "Enter Valid Username and Password";
                lbl_Error.ForeColor = Color.OrangeRed;
            }

            tb_Username.Clear();
            tb_Password.Clear();
        }

        
       
    }
}
