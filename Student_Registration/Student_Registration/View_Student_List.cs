﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Student_Registration
{
    public partial class frm_View_Student_List : Form
    {
        public frm_View_Student_List()
        {
            InitializeComponent();
        }

        private void frm_View_Student_List_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sGM_Student_Management_System_dbDataSet.Student_List' table. You can move, or remove it, as needed.
            this.student_ListTableAdapter.Fill(this.sGM_Student_Management_System_dbDataSet.Student_List);
            
        }

        private void btn_LogOut_Click(object sender, EventArgs e)
        {
            frm_SGM_Login Obj = new frm_SGM_Login();
            Obj.Show();
            this.Hide();
        }

        

    }
}
