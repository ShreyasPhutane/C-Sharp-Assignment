using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Student_Regestration_Assignment2
{
    public partial class frm_Search_Student_List : Form
    {
        public frm_Search_Student_List()
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
        private void btn_Search_Click(object sender, EventArgs e)
        {
            Con.Open();

            SqlCommand cmd = new SqlCommand("Select * From Student_Details where Roll_No =@Roll_No", Con);
            cmd.Parameters.Add("Roll_No", SqlDbType.Int).Value = tb_Roll_No.Text;
            cmd.Connection = Con;
            SqlDataReader DR = cmd.ExecuteReader();

            if (DR.Read())
            {
                tb_Name.Text = DR.GetString(DR.GetOrdinal("Name"));
                tb_Mobile_No.Text = (DR["Mobile_No"].ToString());
                dtp_DOB.Text = (DR["DOB"].ToString());
                cb_Course.Text = DR.GetString(DR.GetOrdinal("Course"));
            }

            else
            {
                MessageBox.Show("No Record Found", "Invalid Roll No", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tb_Roll_No.Clear();
            }
            Con.Close();
   
        }
        void Clear_Controls()
        {
            tb_Roll_No.Text = "";
            tb_Name.Text = "";
            dtp_DOB.Text = "";
            tb_Mobile_No.Text = "";
            cb_Course.SelectedIndex = -1;
        }
        private void Only_Numeric(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
            {
                e.Handled = true;
            }
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            Clear_Controls();
        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            DialogResult Res = MessageBox.Show("Are You Sure Want To Logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (Res == DialogResult.Yes)
            {
                Frm_Student_Login obj = new Frm_Student_Login();
                this.Hide();
                obj.Show();

            }
        }

        private void frm_Search_Student_List_Load(object sender, EventArgs e)
        {
            lbl_Uname.Text = Shared_Class1.Username;
            tb_Roll_No.Focus();
        }
    }
}
