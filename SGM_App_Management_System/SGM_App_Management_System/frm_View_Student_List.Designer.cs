namespace SGM_App_Management_System
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbl_View_Student_List = new System.Windows.Forms.Label();
            this.dgv_View_Student_List = new System.Windows.Forms.DataGridView();
            this.studentListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sGM_Student_Management_System_dbDataSet = new SGM_App_Management_System.SGM_Student_Management_System_dbDataSet();
            this.studentListBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.student_ListTableAdapter = new SGM_App_Management_System.SGM_Student_Management_System_dbDataSetTableAdapters.Student_ListTableAdapter();
            this.rollNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dOBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moblieNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_View_Student_List)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sGM_Student_Management_System_dbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentListBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_View_Student_List
            // 
            this.lbl_View_Student_List.AutoSize = true;
            this.lbl_View_Student_List.Font = new System.Drawing.Font("Times New Roman", 34.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_View_Student_List.Location = new System.Drawing.Point(247, 94);
            this.lbl_View_Student_List.Name = "lbl_View_Student_List";
            this.lbl_View_Student_List.Size = new System.Drawing.Size(601, 65);
            this.lbl_View_Student_List.TabIndex = 2;
            this.lbl_View_Student_List.Text = "VIEW STUDENT LIST";
            // 
            // dgv_View_Student_List
            // 
            this.dgv_View_Student_List.AllowUserToAddRows = false;
            this.dgv_View_Student_List.AllowUserToDeleteRows = false;
            this.dgv_View_Student_List.AutoGenerateColumns = false;
            this.dgv_View_Student_List.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_View_Student_List.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_View_Student_List.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_View_Student_List.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rollNoDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.dOBDataGridViewTextBoxColumn,
            this.moblieNoDataGridViewTextBoxColumn,
            this.courseDataGridViewTextBoxColumn});
            this.dgv_View_Student_List.DataSource = this.studentListBindingSource1;
            this.dgv_View_Student_List.Location = new System.Drawing.Point(10, 185);
            this.dgv_View_Student_List.Name = "dgv_View_Student_List";
            this.dgv_View_Student_List.ReadOnly = true;
            this.dgv_View_Student_List.RowTemplate.Height = 24;
            this.dgv_View_Student_List.Size = new System.Drawing.Size(1087, 426);
            this.dgv_View_Student_List.TabIndex = 3;
            // 
            // studentListBindingSource
            // 
            this.studentListBindingSource.DataMember = "Student_List";
            // 
            // sGM_Student_Management_System_dbDataSet
            // 
            this.sGM_Student_Management_System_dbDataSet.DataSetName = "SGM_Student_Management_System_dbDataSet";
            this.sGM_Student_Management_System_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentListBindingSource1
            // 
            this.studentListBindingSource1.DataMember = "Student_List";
            this.studentListBindingSource1.DataSource = this.sGM_Student_Management_System_dbDataSet;
            // 
            // student_ListTableAdapter
            // 
            this.student_ListTableAdapter.ClearBeforeFill = true;
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
            // moblieNoDataGridViewTextBoxColumn
            // 
            this.moblieNoDataGridViewTextBoxColumn.DataPropertyName = "Moblie_No";
            this.moblieNoDataGridViewTextBoxColumn.HeaderText = "Moblie_No";
            this.moblieNoDataGridViewTextBoxColumn.Name = "moblieNoDataGridViewTextBoxColumn";
            this.moblieNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // courseDataGridViewTextBoxColumn
            // 
            this.courseDataGridViewTextBoxColumn.DataPropertyName = "Course";
            this.courseDataGridViewTextBoxColumn.HeaderText = "Course";
            this.courseDataGridViewTextBoxColumn.Name = "courseDataGridViewTextBoxColumn";
            this.courseDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // frm_View_Student_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1109, 696);
            this.Controls.Add(this.lbl_View_Student_List);
            this.Controls.Add(this.dgv_View_Student_List);
            this.Name = "frm_View_Student_List";
            this.Text = "frm_View_Student_List";
            this.Load += new System.EventHandler(this.frm_View_Student_List_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_View_Student_List)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sGM_Student_Management_System_dbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentListBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_View_Student_List;
        private System.Windows.Forms.BindingSource studentListBindingSource;
        private System.Windows.Forms.DataGridView dgv_View_Student_List;
        private SGM_Student_Management_System_dbDataSet sGM_Student_Management_System_dbDataSet;
        private System.Windows.Forms.BindingSource studentListBindingSource1;
        private SGM_Student_Management_System_dbDataSetTableAdapters.Student_ListTableAdapter student_ListTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn rollNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dOBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn moblieNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseDataGridViewTextBoxColumn;
    }
}