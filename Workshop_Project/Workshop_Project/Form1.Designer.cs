namespace Workshop_Project
{
    partial class frm_Costumer_Registration
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_Customer_Registration = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.REG_ID = new System.Windows.Forms.Label();
            this.lbl_Customer_Name = new System.Windows.Forms.Label();
            this.lbl_Address = new System.Windows.Forms.Label();
            this.lbl_Contact = new System.Windows.Forms.Label();
            this.lbl_Email = new System.Windows.Forms.Label();
            this.lbl_Date = new System.Windows.Forms.Label();
            this.btn_New = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.tb_REG_ID = new System.Windows.Forms.TextBox();
            this.tb_Email = new System.Windows.Forms.TextBox();
            this.tb_Contact = new System.Windows.Forms.TextBox();
            this.tb_Address = new System.Windows.Forms.TextBox();
            this.tb_Customer_Name = new System.Windows.Forms.TextBox();
            this.dtp_Date = new System.Windows.Forms.DateTimePicker();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Customer_Registration
            // 
            this.lbl_Customer_Registration.AutoSize = true;
            this.lbl_Customer_Registration.Font = new System.Drawing.Font("Mongolian Baiti", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbl_Customer_Registration.Location = new System.Drawing.Point(504, 25);
            this.lbl_Customer_Registration.Name = "lbl_Customer_Registration";
            this.lbl_Customer_Registration.Size = new System.Drawing.Size(581, 64);
            this.lbl_Customer_Registration.TabIndex = 0;
            this.lbl_Customer_Registration.Text = "Customer Registration";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel1.Controls.Add(this.lbl_Customer_Registration);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1482, 116);
            this.panel1.TabIndex = 1;
            // 
            // REG_ID
            // 
            this.REG_ID.AutoSize = true;
            this.REG_ID.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.REG_ID.Location = new System.Drawing.Point(203, 170);
            this.REG_ID.Name = "REG_ID";
            this.REG_ID.Size = new System.Drawing.Size(97, 35);
            this.REG_ID.TabIndex = 2;
            this.REG_ID.Text = "REG ID:";
            // 
            // lbl_Customer_Name
            // 
            this.lbl_Customer_Name.AutoSize = true;
            this.lbl_Customer_Name.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Customer_Name.Location = new System.Drawing.Point(203, 247);
            this.lbl_Customer_Name.Name = "lbl_Customer_Name";
            this.lbl_Customer_Name.Size = new System.Drawing.Size(196, 35);
            this.lbl_Customer_Name.TabIndex = 3;
            this.lbl_Customer_Name.Text = "Customer Name";
            // 
            // lbl_Address
            // 
            this.lbl_Address.AutoSize = true;
            this.lbl_Address.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Address.Location = new System.Drawing.Point(203, 326);
            this.lbl_Address.Name = "lbl_Address";
            this.lbl_Address.Size = new System.Drawing.Size(105, 35);
            this.lbl_Address.TabIndex = 4;
            this.lbl_Address.Text = "Address";
            // 
            // lbl_Contact
            // 
            this.lbl_Contact.AutoSize = true;
            this.lbl_Contact.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Contact.Location = new System.Drawing.Point(203, 402);
            this.lbl_Contact.Name = "lbl_Contact";
            this.lbl_Contact.Size = new System.Drawing.Size(100, 35);
            this.lbl_Contact.TabIndex = 5;
            this.lbl_Contact.Text = "Contact";
            // 
            // lbl_Email
            // 
            this.lbl_Email.AutoSize = true;
            this.lbl_Email.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Email.Location = new System.Drawing.Point(203, 480);
            this.lbl_Email.Name = "lbl_Email";
            this.lbl_Email.Size = new System.Drawing.Size(75, 35);
            this.lbl_Email.TabIndex = 6;
            this.lbl_Email.Text = "Email";
            // 
            // lbl_Date
            // 
            this.lbl_Date.AutoSize = true;
            this.lbl_Date.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Date.Location = new System.Drawing.Point(203, 563);
            this.lbl_Date.Name = "lbl_Date";
            this.lbl_Date.Size = new System.Drawing.Size(67, 35);
            this.lbl_Date.TabIndex = 7;
            this.lbl_Date.Text = "Date";
            // 
            // btn_New
            // 
            this.btn_New.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_New.Location = new System.Drawing.Point(206, 661);
            this.btn_New.Name = "btn_New";
            this.btn_New.Size = new System.Drawing.Size(94, 50);
            this.btn_New.TabIndex = 8;
            this.btn_New.Text = "New";
            this.btn_New.UseVisualStyleBackColor = true;
            // 
            // btn_Save
            // 
            this.btn_Save.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Save.Location = new System.Drawing.Point(467, 661);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(94, 50);
            this.btn_Save.TabIndex = 9;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            // 
            // btn_Update
            // 
            this.btn_Update.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Update.Location = new System.Drawing.Point(713, 661);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(119, 50);
            this.btn_Update.TabIndex = 10;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = true;
            // 
            // btn_Delete
            // 
            this.btn_Delete.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Delete.Location = new System.Drawing.Point(961, 661);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(109, 50);
            this.btn_Delete.TabIndex = 11;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = true;
            // 
            // tb_REG_ID
            // 
            this.tb_REG_ID.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_REG_ID.Location = new System.Drawing.Point(521, 178);
            this.tb_REG_ID.Name = "tb_REG_ID";
            this.tb_REG_ID.Size = new System.Drawing.Size(305, 41);
            this.tb_REG_ID.TabIndex = 12;
            // 
            // tb_Email
            // 
            this.tb_Email.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_Email.Location = new System.Drawing.Point(521, 489);
            this.tb_Email.Name = "tb_Email";
            this.tb_Email.Size = new System.Drawing.Size(305, 41);
            this.tb_Email.TabIndex = 13;
            // 
            // tb_Contact
            // 
            this.tb_Contact.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_Contact.Location = new System.Drawing.Point(521, 411);
            this.tb_Contact.Name = "tb_Contact";
            this.tb_Contact.Size = new System.Drawing.Size(305, 41);
            this.tb_Contact.TabIndex = 14;
            // 
            // tb_Address
            // 
            this.tb_Address.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_Address.Location = new System.Drawing.Point(521, 334);
            this.tb_Address.Name = "tb_Address";
            this.tb_Address.Size = new System.Drawing.Size(305, 41);
            this.tb_Address.TabIndex = 15;
            // 
            // tb_Customer_Name
            // 
            this.tb_Customer_Name.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_Customer_Name.Location = new System.Drawing.Point(521, 255);
            this.tb_Customer_Name.Name = "tb_Customer_Name";
            this.tb_Customer_Name.Size = new System.Drawing.Size(305, 41);
            this.tb_Customer_Name.TabIndex = 16;
            // 
            // dtp_Date
            // 
            this.dtp_Date.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtp_Date.Location = new System.Drawing.Point(521, 571);
            this.dtp_Date.Name = "dtp_Date";
            this.dtp_Date.Size = new System.Drawing.Size(305, 41);
            this.dtp_Date.TabIndex = 17;
            // 
            // btn_Exit
            // 
            this.btn_Exit.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Exit.Location = new System.Drawing.Point(1177, 661);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(94, 50);
            this.btn_Exit.TabIndex = 18;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.UseVisualStyleBackColor = true;
            // 
            // frm_Costumer_Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1482, 753);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.dtp_Date);
            this.Controls.Add(this.tb_Customer_Name);
            this.Controls.Add(this.tb_Address);
            this.Controls.Add(this.tb_Contact);
            this.Controls.Add(this.tb_Email);
            this.Controls.Add(this.tb_REG_ID);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.btn_New);
            this.Controls.Add(this.lbl_Date);
            this.Controls.Add(this.lbl_Email);
            this.Controls.Add(this.lbl_Contact);
            this.Controls.Add(this.lbl_Address);
            this.Controls.Add(this.lbl_Customer_Name);
            this.Controls.Add(this.REG_ID);
            this.Controls.Add(this.panel1);
            this.Name = "frm_Costumer_Registration";
            this.Text = "Customer Registration";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbl_Customer_Registration;
        private Panel panel1;
        private Label REG_ID;
        private Label lbl_Customer_Name;
        private Label lbl_Address;
        private Label lbl_Contact;
        private Label lbl_Email;
        private Label lbl_Date;
        private Button btn_New;
        private Button btn_Save;
        private Button btn_Update;
        private Button btn_Delete;
        private TextBox tb_REG_ID;
        private TextBox tb_Email;
        private TextBox tb_Contact;
        private TextBox tb_Address;
        private TextBox tb_Customer_Name;
        private DateTimePicker dtp_Date;
        private Button btn_Exit;
    }
}