using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Student_Regestration_Assignment2
{
    public partial class frm_View_Student_Details : Form
    {
        public frm_View_Student_Details()
        {
            InitializeComponent();
        }

        private void frm_View_Student_Details_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'student_Registration_dbDataSet1.Student_Details' table. You can move, or remove it, as needed.
            this.student_DetailsTableAdapter1.Fill(this.student_Registration_dbDataSet1.Student_Details);
            lbl_Uname.Text = Shared_Class1.Username;
            
        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            DialogResult Res = MessageBox.Show("Are You Sure Want To Logout...", "LOGOUT", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (Res == DialogResult.Yes)
            {
                Frm_Student_Login obj = new Frm_Student_Login();
                this.Hide();
                obj.Show();
            }
        }

        private void btn_Add_Student_List_Click(object sender, EventArgs e)
        {
            frm_Search_Student_List obj = new frm_Search_Student_List();
            this.Hide();
            obj.Show();
        }

       
    }
}
