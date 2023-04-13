
namespace Destiny.cs.Forms
{
    partial class frm_Districtwise_Report
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
            this.lbl_District = new System.Windows.Forms.Label();
            this.cmb_Select_district = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.DisplayStatusBar = false;
            this.crystalReportViewer1.DisplayToolbar = false;
            this.crystalReportViewer1.Location = new System.Drawing.Point(1, 103);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(1478, 648);
            this.crystalReportViewer1.TabIndex = 0;
            // 
            // lbl_District
            // 
            this.lbl_District.AutoSize = true;
            this.lbl_District.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_District.Location = new System.Drawing.Point(203, 41);
            this.lbl_District.Name = "lbl_District";
            this.lbl_District.Size = new System.Drawing.Size(169, 29);
            this.lbl_District.TabIndex = 1;
            this.lbl_District.Text = "Select District";
            // 
            // cmb_Select_district
            // 
            this.cmb_Select_district.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Select_district.FormattingEnabled = true;
            this.cmb_Select_district.Items.AddRange(new object[] {
            "Mumbai ",
            "Pune ",
            "Nagpur",
            "Nashik",
            "Thane",
            "Sambhaji Nagar",
            "Solapur",
            "Nashik",
            "Jalgaon",
            "Amravati",
            "Nanded",
            "Kolhapur",
            "Akola",
            "Sangli",
            "Latur",
            "Raigad ",
            "Satara",
            "Beed",
            "Yavatmal",
            "Nagpur",
            "Gondia",
            "Solapur",
            "Amravati",
            "Osmanabad",
            "Nandurbar",
            "Wardha",
            "Dhule",
            "Ahmednagar",
            "Chandrapur",
            "Parbhani",
            "Jalna"});
            this.cmb_Select_district.Location = new System.Drawing.Point(396, 39);
            this.cmb_Select_district.Name = "cmb_Select_district";
            this.cmb_Select_district.Size = new System.Drawing.Size(252, 37);
            this.cmb_Select_district.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(721, 35);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 45);
            this.button1.TabIndex = 3;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frm_Districtwise_Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1482, 753);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmb_Select_district);
            this.Controls.Add(this.lbl_District);
            this.Controls.Add(this.crystalReportViewer1);
            this.Name = "frm_Districtwise_Report";
            this.Text = "frm_Districtwise_Report";
            this.Load += new System.EventHandler(this.frm_Districtwise_Report_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.Label lbl_District;
        private System.Windows.Forms.ComboBox cmb_Select_district;
        private System.Windows.Forms.Button button1;
    }
}