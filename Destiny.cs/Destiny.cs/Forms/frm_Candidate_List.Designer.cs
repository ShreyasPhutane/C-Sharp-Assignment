
namespace Destiny.cs.Forms
{
    partial class frm_Candidate_List
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
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_Sort_By = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_Status = new System.Windows.Forms.ComboBox();
            this.btn_Submit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.DisplayStatusBar = false;
            this.crystalReportViewer1.DisplayToolbar = false;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 128);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(1482, 625);
            this.crystalReportViewer1.TabIndex = 0;
            this.crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            this.crystalReportViewer1.Load += new System.EventHandler(this.frm_load);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(222, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sort By:";
            // 
            // cmb_Sort_By
            // 
            this.cmb_Sort_By.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Sort_By.FormattingEnabled = true;
            this.cmb_Sort_By.Items.AddRange(new object[] {
            "All",
            "Male",
            "Female"});
            this.cmb_Sort_By.Location = new System.Drawing.Point(333, 40);
            this.cmb_Sort_By.Name = "cmb_Sort_By";
            this.cmb_Sort_By.Size = new System.Drawing.Size(150, 28);
            this.cmb_Sort_By.TabIndex = 2;
            this.cmb_Sort_By.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(531, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Status:";
            // 
            // cmb_Status
            // 
            this.cmb_Status.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Status.FormattingEnabled = true;
            this.cmb_Status.Items.AddRange(new object[] {
            "All",
            "Never Married",
            "Widow",
            "Divorced",
            "Awaiting Divorced"});
            this.cmb_Status.Location = new System.Drawing.Point(634, 45);
            this.cmb_Status.Name = "cmb_Status";
            this.cmb_Status.Size = new System.Drawing.Size(202, 28);
            this.cmb_Status.TabIndex = 4;
            // 
            // btn_Submit
            // 
            this.btn_Submit.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btn_Submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Submit.Location = new System.Drawing.Point(878, 42);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(202, 34);
            this.btn_Submit.TabIndex = 5;
            this.btn_Submit.Text = "Submit";
            this.btn_Submit.UseVisualStyleBackColor = false;
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
            // 
            // frm_Candidate_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1482, 753);
            this.Controls.Add(this.btn_Submit);
            this.Controls.Add(this.cmb_Status);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmb_Sort_By);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.crystalReportViewer1);
            this.Name = "frm_Candidate_List";
            this.Text = "frm_Candidate_List";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_Sort_By;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmb_Status;
        private System.Windows.Forms.Button btn_Submit;
    }
}