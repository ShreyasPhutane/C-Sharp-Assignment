using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Destiny.cs
{
    public partial class frm_Registration_Payment : Form
    {
        public bool PaidStatus;
        string payment_plan;
        public frm_Registration_Payment(int member_id,string fname, string lname)
        {
            InitializeComponent();
            tb_reg_ID.Text= member_id.ToString();
            tb_First_Name.Text= fname;
            tb_Last_Name.Text= lname;

        }
         
        private void btn_Submit_Click(object sender, EventArgs e)
        {
            String strSave = "Insert Into registration_payment Values(@id, @payment, @fname, @lname, @type, @amount,@mode)";
            SqlCommand cmd = new SqlCommand(strSave, Destiny_Shared_Containt.Con);

            cmd.Parameters.AddWithValue("id", tb_reg_ID.Text);
            cmd.Parameters.AddWithValue("payment", tb_Payment_ID.Text);
            cmd.Parameters.AddWithValue("fname", tb_First_Name.Text);
            cmd.Parameters.AddWithValue("lname",tb_Last_Name.Text);
            cmd.Parameters.AddWithValue("type", cmb_Subscription_Type.SelectedItem);
            cmd.Parameters.AddWithValue("amount", tb_Paying_Amount.Text);
            cmd.Parameters.AddWithValue("mode", cmb_Payment_Mode.SelectedItem);

            if (cmd.ExecuteNonQuery() != 0)
            {
                Destiny_Shared_Containt.Con.Close();
                PaidStatus = true;
                MessageBox.Show("Payment Done.");
                this.Close();
            }
            else
            {
                Destiny_Shared_Containt.Con.Close();
                MessageBox.Show("Error Occurred During Payment. \n Please Try Again");
            }


        }

        private void makePayment()
        {
            tc_Payment.Show();

            if(payment_plan == null)
            {
                return;
            }
            if (payment_plan=="Gold")
            {
                tc_Payment.SelectedIndex = 1;
                cmb_Subscription_Type.SelectedItem = "Gold";
                tb_Paying_Amount.Text = "499";
            }
            if (payment_plan == "Diamond")
            {
                tc_Payment.SelectedIndex = 1;
                cmb_Subscription_Type.SelectedItem = "Diamond";
                tb_Paying_Amount.Text = "1999";
            }
            if (payment_plan == "Platinum")
            {
                tc_Payment.SelectedIndex = 1;
                cmb_Subscription_Type.SelectedItem = "Platinum";
                tb_Paying_Amount.Text = "4999";
            }
        }
        private void frm_Registration_Payment_Load(object sender, EventArgs e)
        {
            tb_Payment_ID.Text = Destiny_Shared_Containt.GetAutoId("select max(Payment_ID) from registration_payment").ToString();
        }

        private void btn_Pay_Now_Gold_Click(object sender, EventArgs e)
        {
            payment_plan = "Gold";
            makePayment();
        }

        private void btn_Pay_Now_Dia_Click(object sender, EventArgs e)
        {
            payment_plan = "Diamond";
            makePayment();
        }

        private void btn_Pay_Now_Plat_Click(object sender, EventArgs e)
        {
            payment_plan = "Platinum";
            makePayment();
        }
    }
}
