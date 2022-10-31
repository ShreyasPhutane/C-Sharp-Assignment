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
    public partial class frm_Add_Student_Details : Form
    {
        public frm_Add_Student_Details()
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

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            Frm_Student_Login obj = new Frm_Student_Login();
            this.Hide();
            obj.Show();

        }

        private void btn_View_Student_Details_Click(object sender, EventArgs e)
        {
            frm_View_Student_Details obj = new frm_View_Student_Details();
            this.Hide();
            obj.Show();
        }

        private void Only_Numeric(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
            {
                e.Handled = true;
            }
        }

        private void Only_Text(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar) || (e.KeyChar == (char)Keys.Back) || (e.KeyChar == (char)Keys.Space) || (e.KeyChar == (char)Keys.ShiftKey)))
            {
                e.Handled = true;
            }
        }

        int Auto_Incr()
        {
            int cnt = 0;
            Con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Con;
            cmd.CommandText = "Select Count(*) From Student_Details";

            cnt = Convert.ToInt32(cmd.ExecuteScalar());

            if (cnt > 0)
            {
                cmd.CommandText = "Select Max(Roll_No) From Student_Details";
                cnt = Convert.ToInt32(cmd.ExecuteScalar()) + 1;
            }
            else
            {
                cnt = 101;
            }
            Con.Close();
            return cnt;
        }

        void Clear_Controls()
        {
            tb_Roll_No.Text = Convert.ToString(Auto_Incr());
            tb_Name.Clear();
            tb_Mobile_No.Clear();
            cb_Course.SelectedIndex = -1;
            dtp_DOB.Text = "";
        }

        
        private void btn_Save_Click(object sender, EventArgs e)
        {
            Con.Open();
            if (tb_Roll_No.Text != "" && tb_Name.Text != "" && tb_Mobile_No.Text != "" && tb_Mobile_No.TextLength == 10 && cb_Course.Text != "")
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = Con;
                cmd.CommandText = "Insert into Student_Details (Roll_No,Name,DOB,Mobile_No,Course) Values(@Roll_No,@Nm,@DOB,@MNo,@Course)";

                cmd.Parameters.Add("Roll_No", SqlDbType.Int).Value = tb_Roll_No.Text;
                cmd.Parameters.Add("Nm", SqlDbType.VarChar).Value = tb_Name.Text;
                cmd.Parameters.Add("DOB", SqlDbType.Date).Value = dtp_DOB.Value.Date;
                cmd.Parameters.Add("MNo", SqlDbType.Decimal).Value = tb_Mobile_No.Text;
                cmd.Parameters.Add("Course", SqlDbType.NVarChar).Value = cb_Course.Text;

                cmd.ExecuteNonQuery();

                MessageBox.Show("Record Inserted Succesfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                tb_Roll_No.Clear();
                tb_Name.Clear();
                tb_Mobile_No.Clear();
                dtp_DOB.Text = "";
                cb_Course.SelectedIndex = -1;
            }
            else
            {
                MessageBox.Show("Fill All Field Compulsary", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            Con.Close();
  
        }

        private void frm_Add_Student_Details_Load(object sender, EventArgs e)
        {
            Clear_Controls();
            tb_Roll_No.Focus();
            lbl_Uname.Text = Shared_Class1.Username;

        }
        
    }
}
