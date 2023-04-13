namespace Destiny.cs
{
    partial class Frm_Add_Expence_Details
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Add_Expence_Details));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_Profile_Information = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.cmb_Bill_Paid_By = new System.Windows.Forms.ComboBox();
            this.btn_Browse_Bill = new System.Windows.Forms.Button();
            this.pb_Bill_Image = new System.Windows.Forms.PictureBox();
            this.dtp_Expence_Date = new System.Windows.Forms.DateTimePicker();
            this.tb_Amount_Paid = new System.Windows.Forms.TextBox();
            this.tb_Expence_Details = new System.Windows.Forms.TextBox();
            this.tb_Expence_ID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_Expence_id = new System.Windows.Forms.Label();
            this.pb_Back = new System.Windows.Forms.PictureBox();
            this.pb_Log_Out = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Bill_Image)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Back)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Log_Out)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.lbl_Profile_Information);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1482, 116);
            this.panel1.TabIndex = 19;
            // 
            // lbl_Profile_Information
            // 
            this.lbl_Profile_Information.AutoSize = true;
            this.lbl_Profile_Information.Font = new System.Drawing.Font("Times New Roman", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Profile_Information.ForeColor = System.Drawing.Color.Navy;
            this.lbl_Profile_Information.Location = new System.Drawing.Point(481, 23);
            this.lbl_Profile_Information.Name = "lbl_Profile_Information";
            this.lbl_Profile_Information.Size = new System.Drawing.Size(432, 67);
            this.lbl_Profile_Information.TabIndex = 0;
            this.lbl_Profile_Information.Text = "Expence Details";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_Refresh);
            this.groupBox1.Controls.Add(this.btn_Save);
            this.groupBox1.Controls.Add(this.cmb_Bill_Paid_By);
            this.groupBox1.Controls.Add(this.btn_Browse_Bill);
            this.groupBox1.Controls.Add(this.pb_Bill_Image);
            this.groupBox1.Controls.Add(this.dtp_Expence_Date);
            this.groupBox1.Controls.Add(this.tb_Amount_Paid);
            this.groupBox1.Controls.Add(this.tb_Expence_Details);
            this.groupBox1.Controls.Add(this.tb_Expence_ID);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lbl_Expence_id);
            this.groupBox1.Location = new System.Drawing.Point(35, 198);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1435, 543);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.btn_Refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refresh.ForeColor = System.Drawing.Color.Crimson;
            this.btn_Refresh.Location = new System.Drawing.Point(454, 452);
            this.btn_Refresh.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(200, 58);
            this.btn_Refresh.TabIndex = 119;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = false;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.btn_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.ForeColor = System.Drawing.Color.Crimson;
            this.btn_Save.Location = new System.Drawing.Point(781, 452);
            this.btn_Save.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(183, 58);
            this.btn_Save.TabIndex = 118;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // cmb_Bill_Paid_By
            // 
            this.cmb_Bill_Paid_By.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Bill_Paid_By.Font = new System.Drawing.Font("Mongolian Baiti", 16F);
            this.cmb_Bill_Paid_By.FormattingEnabled = true;
            this.cmb_Bill_Paid_By.Items.AddRange(new object[] {
            "Admin\t",
            "Employee"});
            this.cmb_Bill_Paid_By.Location = new System.Drawing.Point(975, 363);
            this.cmb_Bill_Paid_By.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_Bill_Paid_By.MaxLength = 20;
            this.cmb_Bill_Paid_By.Name = "cmb_Bill_Paid_By";
            this.cmb_Bill_Paid_By.Size = new System.Drawing.Size(285, 37);
            this.cmb_Bill_Paid_By.TabIndex = 116;
            // 
            // btn_Browse_Bill
            // 
            this.btn_Browse_Bill.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.btn_Browse_Bill.Font = new System.Drawing.Font("Bodoni MT Condensed", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Browse_Bill.ForeColor = System.Drawing.Color.DarkCyan;
            this.btn_Browse_Bill.Location = new System.Drawing.Point(1030, 292);
            this.btn_Browse_Bill.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Browse_Bill.Name = "btn_Browse_Bill";
            this.btn_Browse_Bill.Size = new System.Drawing.Size(184, 43);
            this.btn_Browse_Bill.TabIndex = 115;
            this.btn_Browse_Bill.Text = "Browse Bill Image";
            this.btn_Browse_Bill.UseVisualStyleBackColor = false;
            this.btn_Browse_Bill.Click += new System.EventHandler(this.btn_Browse_Bill_Click);
            // 
            // pb_Bill_Image
            // 
            this.pb_Bill_Image.BackColor = System.Drawing.SystemColors.Control;
            this.pb_Bill_Image.Location = new System.Drawing.Point(975, 112);
            this.pb_Bill_Image.Margin = new System.Windows.Forms.Padding(4);
            this.pb_Bill_Image.Name = "pb_Bill_Image";
            this.pb_Bill_Image.Size = new System.Drawing.Size(283, 172);
            this.pb_Bill_Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Bill_Image.TabIndex = 114;
            this.pb_Bill_Image.TabStop = false;
            // 
            // dtp_Expence_Date
            // 
            this.dtp_Expence_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_Expence_Date.Location = new System.Drawing.Point(975, 24);
            this.dtp_Expence_Date.Name = "dtp_Expence_Date";
            this.dtp_Expence_Date.Size = new System.Drawing.Size(285, 38);
            this.dtp_Expence_Date.TabIndex = 13;
            // 
            // tb_Amount_Paid
            // 
            this.tb_Amount_Paid.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Amount_Paid.Location = new System.Drawing.Point(357, 340);
            this.tb_Amount_Paid.Name = "tb_Amount_Paid";
            this.tb_Amount_Paid.Size = new System.Drawing.Size(272, 38);
            this.tb_Amount_Paid.TabIndex = 12;
            // 
            // tb_Expence_Details
            // 
            this.tb_Expence_Details.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Expence_Details.Location = new System.Drawing.Point(357, 134);
            this.tb_Expence_Details.Multiline = true;
            this.tb_Expence_Details.Name = "tb_Expence_Details";
            this.tb_Expence_Details.Size = new System.Drawing.Size(272, 126);
            this.tb_Expence_Details.TabIndex = 11;
            // 
            // tb_Expence_ID
            // 
            this.tb_Expence_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Expence_ID.Location = new System.Drawing.Point(357, 24);
            this.tb_Expence_ID.Name = "tb_Expence_ID";
            this.tb_Expence_ID.Size = new System.Drawing.Size(272, 38);
            this.tb_Expence_ID.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(729, 367);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 33);
            this.label4.TabIndex = 9;
            this.label4.Text = "Paid By";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(729, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 33);
            this.label3.TabIndex = 8;
            this.label3.Text = "Bill Image";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cambria", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Navy;
            this.label7.Location = new System.Drawing.Point(729, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(179, 33);
            this.label7.TabIndex = 7;
            this.label7.Text = "Expence Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(122, 340);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 33);
            this.label1.TabIndex = 6;
            this.label1.Text = "Amount Paid";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(123, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(207, 33);
            this.label2.TabIndex = 1;
            this.label2.Text = "Expence Details";
            // 
            // lbl_Expence_id
            // 
            this.lbl_Expence_id.AutoSize = true;
            this.lbl_Expence_id.Font = new System.Drawing.Font("Cambria", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Expence_id.ForeColor = System.Drawing.Color.Navy;
            this.lbl_Expence_id.Location = new System.Drawing.Point(122, 24);
            this.lbl_Expence_id.Name = "lbl_Expence_id";
            this.lbl_Expence_id.Size = new System.Drawing.Size(151, 33);
            this.lbl_Expence_id.TabIndex = 0;
            this.lbl_Expence_id.Text = "Expence ID";
            // 
            // pb_Back
            // 
            this.pb_Back.Image = ((System.Drawing.Image)(resources.GetObject("pb_Back.Image")));
            this.pb_Back.Location = new System.Drawing.Point(0, 116);
            this.pb_Back.Name = "pb_Back";
            this.pb_Back.Size = new System.Drawing.Size(70, 46);
            this.pb_Back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Back.TabIndex = 121;
            this.pb_Back.TabStop = false;
            this.pb_Back.Click += new System.EventHandler(this.pb_Back_Click);
            // 
            // pb_Log_Out
            // 
            this.pb_Log_Out.Image = global::Destiny.cs.Properties.Resources.download__1_1;
            this.pb_Log_Out.Location = new System.Drawing.Point(1414, 116);
            this.pb_Log_Out.Name = "pb_Log_Out";
            this.pb_Log_Out.Size = new System.Drawing.Size(68, 46);
            this.pb_Log_Out.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Log_Out.TabIndex = 120;
            this.pb_Log_Out.TabStop = false;
            this.pb_Log_Out.Click += new System.EventHandler(this.pb_Log_Out_Click);
            // 
            // Frm_Add_Expence_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1482, 753);
            this.Controls.Add(this.pb_Log_Out);
            this.Controls.Add(this.pb_Back);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Name = "Frm_Add_Expence_Details";
            this.Text = "Frm_Add_Expence_Details";
            this.Load += new System.EventHandler(this.Frm_Add_Expence_Details_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Bill_Image)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Back)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Log_Out)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_Profile_Information;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.Button btn_Save;
        internal System.Windows.Forms.ComboBox cmb_Bill_Paid_By;
        private System.Windows.Forms.Button btn_Browse_Bill;
        private System.Windows.Forms.PictureBox pb_Bill_Image;
        private System.Windows.Forms.DateTimePicker dtp_Expence_Date;
        private System.Windows.Forms.TextBox tb_Amount_Paid;
        private System.Windows.Forms.TextBox tb_Expence_Details;
        private System.Windows.Forms.TextBox tb_Expence_ID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_Expence_id;
        private System.Windows.Forms.PictureBox pb_Back;
        private System.Windows.Forms.PictureBox pb_Log_Out;
    }
}