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
    public partial class Frm_Create_Profile_For : Form
    {
        public Frm_Create_Profile_For()
        {
            InitializeComponent();
        }

        private void btn_self_Click(object sender, EventArgs e)
        {
            frm_All_Details obj = new frm_All_Details("Self");
            obj.Show();
            this.Hide();
        }

        private void btn_Son_Click(object sender, EventArgs e)
        {
            frm_All_Details obj = new frm_All_Details("Son");
            obj.Show();
            this.Hide();    
        }

        private void btn_Daughter_Click(object sender, EventArgs e)
        {
            frm_All_Details obj = new frm_All_Details("Daughter");
            obj.Show();
            this.Hide();
        }

        private void btn_Brother_Click(object sender, EventArgs e)
        {
            frm_All_Details obj = new frm_All_Details("Brother");
            obj.Show();
            this.Hide();
        }

        private void btn_Sister_Click(object sender, EventArgs e)
        {
            frm_All_Details obj = new frm_All_Details("Sister");
            obj.Show();
            this.Hide();
        }

        private void btn_Relative_Click(object sender, EventArgs e)
        {
            frm_All_Details obj = new frm_All_Details("Relative");
            obj.Show();
            this.Hide();
        }

        private void btn_Friend_Click(object sender, EventArgs e)
        {
            frm_All_Details obj = new frm_All_Details("Friend");
            obj.Show();
            this.Hide();
        }

        private void btn_Client_Click(object sender, EventArgs e)
        {
            frm_All_Details obj = new frm_All_Details("Client");
            obj.Show();
            this.Hide();
        }
    }
}
