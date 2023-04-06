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
    }
}
