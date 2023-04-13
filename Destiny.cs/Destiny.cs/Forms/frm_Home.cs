using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Destiny.cs
{
    public partial class frm_Home : Form
    {
        public frm_Home()
        {
            InitializeComponent();
        }

        private void btn_Create_Profile_For_Click(object sender, EventArgs e)
        {
            Frm_Create_Profile_For obj = new Frm_Create_Profile_For();
            this.Hide();
            obj.Show();
        }

        private void btn_Add_New_Staff_Click(object sender, EventArgs e)
        {
            frm_Add_New_Staff_Details obj = new frm_Add_New_Staff_Details();
            this.Hide();
            obj.Show();
        }

        private void btn_Update_Staff_Details_Click(object sender, EventArgs e)
        {
            frm_Update_Staff_Details obj = new frm_Update_Staff_Details();
            this.Hide();
            obj.Show();
        }

        private void btn_Add_Expence_Details_Click(object sender, EventArgs e)
        {
            Frm_Add_Expence_Details obj = new Frm_Add_Expence_Details();
            this.Hide();
            obj.Show();
        }
        private void btn_Report_Click(object sender, EventArgs e)
        {
            frm_All_Reports obj = new frm_All_Reports();
            this.Hide();
            obj.Show();
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
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void lbl_Start_A_New_Life_Click(object sender, EventArgs e)
        {

        }

        private void lbl_Destiny_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }
    }
}
