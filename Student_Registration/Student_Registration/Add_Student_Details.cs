using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Student_Registration
{
    public partial class frm_Add_Student_Details : Form
    {
        public frm_Add_Student_Details()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=SGM_Student_Management_System_db;Integrated Security=True");

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

        private void btn_Log_Out_Click(object sender, EventArgs e)
        {
            frm_SGM_Login Obj = new frm_SGM_Login();
            Obj.Show();
            this.Hide();
        }

        private void btn_View_Student_List_Click(object sender, EventArgs e)
        {
            frm_View_Student_List   Obj = new frm_View_Student_List ();
            Obj.Show();
            this.Hide();
        }
        private void Only_Numeric(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
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


        private void btn_Save_Click(object sender, EventArgs e)
        {
            Con_Open();

            if (tb_Roll_No.Text != "" && tb_Name.Text != "" && tb_Mobile_No.Text != "" && tb_Mobile_No.TextLength == 10 && cmb_Course.Text != "")
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = Con;
                cmd.CommandText = "Insert into Student_List (Roll_No,Name,Mobile_No,DOB,Course) Values(@Roll, @Nm,@MNo,@DOB,@Course)";

                cmd.Parameters.Add("Roll", SqlDbType.Int).Value = tb_Roll_No.Text;
                cmd.Parameters.Add("Nm", SqlDbType.VarChar).Value = tb_Name.Text;
                cmd.Parameters.Add("DOB", SqlDbType.Date).Value = dtp_DOB.Value.Date;
                cmd.Parameters.Add("MNo", SqlDbType.Decimal).Value = tb_Mobile_No.Text;
                cmd.Parameters.Add("Course", SqlDbType.NVarChar).Value = cmb_Course.Text;

                cmd.ExecuteNonQuery();

                MessageBox.Show("Record Inserted Succesfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                tb_Roll_No.Clear();
                tb_Name.Clear();
                tb_Mobile_No.Clear();
                dtp_DOB.Text = "";
                cmb_Course.SelectedIndex = -1;


            }
            else
            {
                MessageBox.Show("Fill All Field Compulsory", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            Con_Close();
        }

   
       
        }
    }




        

      
      

        
        
        
        

        
        
        
        

       
        

        
   