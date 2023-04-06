using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Workshop_Project
{
    public partial class frm_Login : Form
    {
        public frm_Login()
        {
            InitializeComponent();
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            if (tb_Password.Text == "") ;
            tb_Password.Focus();
            return;
        }
        DataTable dt = Connection_Files.GetDataTable("'Select * from Login_Table where Username='" + cmb_Username.Text + "'AND Password=' " + tb_Password.Text + "");
        
    }
}
