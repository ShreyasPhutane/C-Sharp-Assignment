namespace Student_Regestration_Assignment2
{
    partial class frm_View_Student_Details
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lbl_View_Student_Details = new System.Windows.Forms.Label();
            this.dgv_Student_Details = new System.Windows.Forms.DataGridView();
            this.rollNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dOBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobileNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.student_Registration_dbDataSet = new Student_Regestration_Assignment2.Student_Registration_dbDataSet();
            this.btn_Logout = new System.Windows.Forms.Button();
            this.student_DetailsTableAdapter = new Student_Regestration_Assignment2.Student_Registration_dbDataSetTableAdapters.Student_DetailsTableAdapter();
            this.btn_Add_New_Student = new System.Windows.Forms.Button();
            this.btn_Add_Student_List = new System.Windows.Forms.Button();
            this.lbl_Uname = new System.Windows.Forms.Label();
            this.student_Registration_dbDataSet1 = new Student_Regestration_Assignment2.Student_Registration_dbDataSet1();
            this.studentDetailsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.student_DetailsTableAdapter1 = new Student_Regestration_Assignment2.Student_Registration_dbDataSet1TableAdapters.Student_DetailsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Student_Details)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.student_Registration_dbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.student_Registration_dbDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDetailsBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_View_Student_Details
            // 
            this.lbl_View_Student_Details.AutoSize = true;
            this.lbl_View_Student_Details.Font = new System.Drawing.Font("Times New Roman", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_View_Student_Details.Location = new System.Drawing.Point(166, 76);
            this.lbl_View_Student_Details.Name = "lbl_View_Student_Details";
            this.lbl_View_Student_Details.Size = new System.Drawing.Size(755, 67);
            this.lbl_View_Student_Details.TabIndex = 0;
            this.lbl_View_Student_Details.Text = "VIEW STUDENT DETAILS";
            // 
            // dgv_Student_Details
            // 
            this.dgv_Student_Details.AllowUserToAddRows = false;
            this.dgv_Student_Details.AllowUserToDeleteRows = false;
            this.dgv_Student_Details.AutoGenerateColumns = false;
            this.dgv_Student_Details.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Student_Details.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Student_Details.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rollNoDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.dOBDataGridViewTextBoxColumn,
            this.mobileNoDataGridViewTextBoxColumn,
            this.courseDataGridViewTextBoxColumn});
            this.dgv_Student_Details.DataSource = this.studentDetailsBindingSource1;
            this.dgv_Student_Details.Location = new System.Drawing.Point(25, 176);
            this.dgv_Student_Details.Name = "dgv_Student_Details";
            this.dgv_Student_Details.ReadOnly = true;
            this.dgv_Student_Details.RowTemplate.Height = 24;
            this.dgv_Student_Details.Size = new System.Drawing.Size(1029, 385);
            this.dgv_Student_Details.TabIndex = 1;
            // 
            // rollNoDataGridViewTextBoxColumn
            // 
            this.rollNoDataGridViewTextBoxColumn.DataPropertyName = "Roll_No";
            this.rollNoDataGridViewTextBoxColumn.HeaderText = "Roll_No";
            this.rollNoDataGridViewTextBoxColumn.Name = "rollNoDataGridViewTextBoxColumn";
            this.rollNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dOBDataGridViewTextBoxColumn
            // 
            this.dOBDataGridViewTextBoxColumn.DataPropertyName = "DOB";
            this.dOBDataGridViewTextBoxColumn.HeaderText = "DOB";
            this.dOBDataGridViewTextBoxColumn.Name = "dOBDataGridViewTextBoxColumn";
            this.dOBDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mobileNoDataGridViewTextBoxColumn
            // 
            this.mobileNoDataGridViewTextBoxColumn.DataPropertyName = "Mobile_No";
            this.mobileNoDataGridViewTextBoxColumn.HeaderText = "Mobile_No";
            this.mobileNoDataGridViewTextBoxColumn.Name = "mobileNoDataGridViewTextBoxColumn";
            this.mobileNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // courseDataGridViewTextBoxColumn
            // 
            this.courseDataGridViewTextBoxColumn.DataPropertyName = "Course";
            this.courseDataGridViewTextBoxColumn.HeaderText = "Course";
            this.courseDataGridViewTextBoxColumn.Name = "courseDataGridViewTextBoxColumn";
            this.courseDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // studentDetailsBindingSource
            // 
            this.studentDetailsBindingSource.DataMember = "Student_Details";
            this.studentDetailsBindingSource.DataSource = this.student_Registration_dbDataSet;
            // 
            // student_Registration_dbDataSet
            // 
            this.student_Registration_dbDataSet.DataSetName = "Student_Registration_dbDataSet";
            this.student_Registration_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btn_Logout
            // 
            this.btn_Logout.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Logout.Location = new System.Drawing.Point(938, -1);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Size = new System.Drawing.Size(143, 44);
            this.btn_Logout.TabIndex = 2;
            this.btn_Logout.Text = "LOGOUT";
            this.btn_Logout.UseVisualStyleBackColor = true;
            this.btn_Logout.Click += new System.EventHandler(this.btn_Logout_Click);
            // 
            // student_DetailsTableAdapter
            // 
            this.student_DetailsTableAdapter.ClearBeforeFill = true;
            // 
            // btn_Add_New_Student
            // 
            this.btn_Add_New_Student.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add_New_Student.Location = new System.Drawing.Point(25, 573);
            this.btn_Add_New_Student.Name = "btn_Add_New_Student";
            this.btn_Add_New_Student.Size = new System.Drawing.Size(484, 68);
            this.btn_Add_New_Student.TabIndex = 3;
            this.btn_Add_New_Student.Text = "ADD NEW STUDENT";
            this.btn_Add_New_Student.UseVisualStyleBackColor = true;
            // 
            // btn_Add_Student_List
            // 
            this.btn_Add_Student_List.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add_Student_List.Location = new System.Drawing.Point(546, 573);
            this.btn_Add_Student_List.Name = "btn_Add_Student_List";
            this.btn_Add_Student_List.Size = new System.Drawing.Size(410, 68);
            this.btn_Add_Student_List.TabIndex = 4;
            this.btn_Add_Student_List.Text = "Search Student List";
            this.btn_Add_Student_List.UseVisualStyleBackColor = true;
            this.btn_Add_Student_List.Click += new System.EventHandler(this.btn_Add_Student_List_Click);
            // 
            // lbl_Uname
            // 
            this.lbl_Uname.AutoSize = true;
            this.lbl_Uname.Font = new System.Drawing.Font("Times New Roman", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Uname.Location = new System.Drawing.Point(12, 6);
            this.lbl_Uname.Name = "lbl_Uname";
            this.lbl_Uname.Size = new System.Drawing.Size(159, 32);
            this.lbl_Uname.TabIndex = 29;
            this.lbl_Uname.Text = "WELCOME";
            // 
            // student_Registration_dbDataSet1
            // 
            this.student_Registration_dbDataSet1.DataSetName = "Student_Registration_dbDataSet1";
            this.student_Registration_dbDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentDetailsBindingSource1
            // 
            this.studentDetailsBindingSource1.DataMember = "Student_Details";
            this.studentDetailsBindingSource1.DataSource = this.student_Registration_dbDataSet1;
            // 
            // student_DetailsTableAdapter1
            // 
            this.student_DetailsTableAdapter1.ClearBeforeFill = true;
            // 
            // frm_View_Student_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 653);
            this.Controls.Add(this.lbl_Uname);
            this.Controls.Add(this.btn_Add_Student_List);
            this.Controls.Add(this.btn_Add_New_Student);
            this.Controls.Add(this.btn_Logout);
            this.Controls.Add(this.dgv_Student_Details);
            this.Controls.Add(this.lbl_View_Student_Details);
            this.Name = "frm_View_Student_Details";
            this.Text = "View_Student_Details";
            this.Load += new System.EventHandler(this.frm_View_Student_Details_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Student_Details)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.student_Registration_dbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.student_Registration_dbDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDetailsBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_View_Student_Details;
        private System.Windows.Forms.DataGridView dgv_Student_Details;
        private System.Windows.Forms.Button btn_Logout;
        private Student_Registration_dbDataSet student_Registration_dbDataSet;
        private System.Windows.Forms.BindingSource studentDetailsBindingSource;
        private Student_Registration_dbDataSetTableAdapters.Student_DetailsTableAdapter student_DetailsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn rollNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dOBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobileNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btn_Add_New_Student;
        private System.Windows.Forms.Button btn_Add_Student_List;
        private System.Windows.Forms.Label lbl_Uname;
        private Student_Registration_dbDataSet1 student_Registration_dbDataSet1;
        private System.Windows.Forms.BindingSource studentDetailsBindingSource1;
        private Student_Registration_dbDataSet1TableAdapters.Student_DetailsTableAdapter student_DetailsTableAdapter1;
    }
}