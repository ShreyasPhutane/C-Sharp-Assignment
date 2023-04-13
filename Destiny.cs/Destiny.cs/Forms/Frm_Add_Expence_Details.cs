using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Destiny.cs
{
    public partial class Frm_Add_Expence_Details : Form
    {
        public Frm_Add_Expence_Details()
        {
            InitializeComponent();
        }
        private void pb_Back_Click(object sender, EventArgs e)
        {
            frm_Home obj = new frm_Home();
            this.Hide();
            obj.Show();
        }
        private void pb_Log_Out_Click(object sender, EventArgs e)
        {
            DialogResult Res = MessageBox.Show("Are You sure to Quit", "Log Out", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (Res == DialogResult.Yes)
            {
                frm_Login Obj = new frm_Login();
                this.Hide();
                Obj.Show();
            }
        }
        void Clear_Controls()
        {
            tb_Expence_ID.Text = Convert.ToString(Destiny_Shared_Containt.Auto_Incr("Expence_Details", "Expence_ID", 5001));

            tb_Amount_Paid.Clear();
            tb_Expence_Details.Clear();
            dtp_Expence_Date.ResetText();
            pb_Bill_Image.Image = null;
            cmb_Bill_Paid_By.SelectedIndex = -1;

            tb_Expence_Details.Focus();
        }
        private void btn_Browse_Bill_Click(object sender, EventArgs e)
        {
            OpenFileDialog OFD = new OpenFileDialog();

            //OFD.Filter = "Image Files(*.jpg; *.jpeg)| *.jpg; *.jpeg";

            OFD.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";

            if (OFD.ShowDialog() == DialogResult.OK)
            {
                pb_Bill_Image.Image = new Bitmap(OFD.FileName);
            }
        }
        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            DialogResult Res = System.Windows.Forms.DialogResult.Yes;

            if (tb_Expence_Details.Text != "" || tb_Amount_Paid.Text != "" || cmb_Bill_Paid_By.Text != "")
            {
                Res = MessageBox.Show("Are You Sure Data Entered Will Be Lost?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            }

            if (Res == System.Windows.Forms.DialogResult.Yes)
            {
                Clear_Controls();
            }
        }
        private void btn_Save_Click(object sender, EventArgs e)
        {
            Destiny_Shared_Containt.Con_Open();

            if (tb_Expence_Details.Text != "" && tb_Amount_Paid.Text != "" && cmb_Bill_Paid_By.Text != "")
            {
                SqlCommand cmd = new SqlCommand("Insert Into Expence_Details Values (@ID, @Exp_Date, @Exp_Details, @Bill_Image, @Amount, @Paid_By ) ", Destiny_Shared_Containt.Con);

                cmd.Parameters.Add("@ID", SqlDbType.Int).Value = tb_Expence_ID.Text;
                cmd.Parameters.Add("@Exp_Date", SqlDbType.Date).Value = dtp_Expence_Date.Value.Date;
                cmd.Parameters.Add("@Exp_Details", SqlDbType.NVarChar).Value = tb_Expence_Details.Text;

                ImageConverter IC = new ImageConverter();

                byte[] imgArray = (byte[])IC.ConvertTo(pb_Bill_Image.Image, typeof(byte[]));

                cmd.Parameters.Add("@Bill_Image", SqlDbType.Image).Value = imgArray;

                cmd.Parameters.Add("@Amount", SqlDbType.Money).Value = tb_Amount_Paid.Text;
                cmd.Parameters.Add("@Paid_By", SqlDbType.NVarChar).Value = cmb_Bill_Paid_By.Text;

                cmd.ExecuteNonQuery();

                MessageBox.Show("Expence Details Saved Successfully");
                Clear_Controls();
            }
            else
            {
                MessageBox.Show("1st Fill All The Fields!!!");
            }

            Destiny_Shared_Containt.Con_Close();
        }

        private void Frm_Add_Expence_Details_Load(object sender, EventArgs e)
        {
            Clear_Controls();
            tb_Expence_ID.Text = Destiny_Shared_Containt.GetAutoId("select max(Expence_ID) from Expence_Details").ToString();
            tb_Expence_ID.Enabled = false;
        }
    }
}
