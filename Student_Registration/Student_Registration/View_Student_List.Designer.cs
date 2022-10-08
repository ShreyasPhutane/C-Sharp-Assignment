namespace Student_Registration
{
    partial class frm_View_Student_List
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbl_View_Student_List = new System.Windows.Forms.Label();
            this.dgv_View_Student_List = new System.Windows.Forms.DataGridView();
            this.rollNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dOBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mobile_No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sGM_Student_Management_System_dbDataSet = new Student_Registration.SGM_Student_Management_System_dbDataSet();
            this.student_ListTableAdapter = new Student_Registration.SGM_Student_Management_System_dbDataSetTableAdapters.Student_ListTableAdapter();
            this.btn_LogOut = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_View_Student_List)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sGM_Student_Management_System_dbDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_View_Student_List
            // 
            this.lbl_View_Student_List.AutoSize = true;
            this.lbl_View_Student_List.Font = new System.Drawing.Font("Times New Roman", 34.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_View_Student_List.Location = new System.Drawing.Point(183, 70);
            this.lbl_View_Student_List.Name = "lbl_View_Student_List";
            this.lbl_View_Student_List.Size = new System.Drawing.Size(601, 65);
            this.lbl_View_Student_List.TabIndex = 0;
            this.lbl_View_Student_List.Text = "VIEW STUDENT LIST";
            // 
            // dgv_View_Student_List
            // 
            this.dgv_View_Student_List.AllowUserToAddRows = false;
            this.dgv_View_Student_List.AllowUserToDeleteRows = false;
            this.dgv_View_Student_List.AutoGenerateColumns = false;
            this.dgv_View_Student_List.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_View_Student_List.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_View_Student_List.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_View_Student_List.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rollNoDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.dOBDataGridViewTextBoxColumn,
            this.courseDataGridViewTextBoxColumn,
            this.Mobile_No});
            this.dgv_View_Student_List.DataSource = this.studentListBindingSource;
            this.dgv_View_Student_List.Location = new System.Drawing.Point(-5, 152);
            this.dgv_View_Student_List.Name = "dgv_View_Student_List";
            this.dgv_View_Student_List.ReadOnly = true;
            this.dgv_View_Student_List.RowTemplate.Height = 24;
            this.dgv_View_Student_List.Size = new System.Drawing.Size(991, 426);
            this.dgv_View_Student_List.TabIndex = 1;
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
            // courseDataGridViewTextBoxColumn
            // 
            this.courseDataGridViewTextBoxColumn.DataPropertyName = "Course";
            this.courseDataGridViewTextBoxColumn.HeaderText = "Course";
            this.courseDataGridViewTextBoxColumn.Name = "courseDataGridViewTextBoxColumn";
            this.courseDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Mobile_No
            // 
            this.Mobile_No.DataPropertyName = "Mobile_No";
            this.Mobile_No.HeaderText = "Mobile_No";
            this.Mobile_No.Name = "Mobile_No";
            this.Mobile_No.ReadOnly = true;
            // 
            // studentListBindingSource
            // 
            this.studentListBindingSource.DataMember = "Student_List";
            this.studentListBindingSource.DataSource = this.sGM_Student_Management_System_dbDataSet;
            // 
            // sGM_Student_Management_System_dbDataSet
            // 
            this.sGM_Student_Management_System_dbDataSet.DataSetName = "SGM_Student_Management_System_dbDataSet";
            this.sGM_Student_Management_System_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // student_ListTableAdapter
            // 
            this.student_ListTableAdapter.ClearBeforeFill = true;
            // 
            // btn_LogOut
            // 
            this.btn_LogOut.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LogOut.ForeColor = System.Drawing.Color.Black;
            this.btn_LogOut.Location = new System.Drawing.Point(854, 12);
            this.btn_LogOut.Name = "btn_LogOut";
            this.btn_LogOut.Size = new System.Drawing.Size(132, 45);
            this.btn_LogOut.TabIndex = 2;
            this.btn_LogOut.Text = "LogOut";
            this.btn_LogOut.UseVisualStyleBackColor = true;
            this.btn_LogOut.Click += new System.EventHandler(this.btn_LogOut_Click);
            // 
            // frm_View_Student_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 659);
            this.Controls.Add(this.btn_LogOut);
            this.Controls.Add(this.dgv_View_Student_List);
            this.Controls.Add(this.lbl_View_Student_List);
            this.Name = "frm_View_Student_List";
            this.Text = "View_Student_List";
            this.Load += new System.EventHandler(this.frm_View_Student_List_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_View_Student_List)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sGM_Student_Management_System_dbDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_View_Student_List;
        private System.Windows.Forms.DataGridView dgv_View_Student_List;
        private SGM_Student_Management_System_dbDataSet sGM_Student_Management_System_dbDataSet;
        private System.Windows.Forms.BindingSource studentListBindingSource;
        private SGM_Student_Management_System_dbDataSetTableAdapters.Student_ListTableAdapter student_ListTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn moblieNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rollNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dOBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mobile_No;
        private System.Windows.Forms.Button btn_LogOut;
    }
}