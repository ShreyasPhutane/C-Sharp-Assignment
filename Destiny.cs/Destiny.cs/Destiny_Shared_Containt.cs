using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Destiny.cs
{
    public class Destiny_Shared_Containt
    {
        public static SqlConnection Con = Con = new SqlConnection(@"Data Source=shreyas\sqlexpress01;Initial Catalog=Destiny_db;Integrated Security=True");

        public Destiny_Shared_Containt()
        {

        }
        public static void Con_Open()
        {
            if (Con.State != ConnectionState.Open)
            {
                Con.Open();
            }
        }

        public static void Con_Close()
        {
            if (Con.State != ConnectionState.Closed)
            {
                Con.Close();
            }
        }
        //for DataGridView Table
        public static DataTable GetDataTable(string query)
        {
            Con_Open();
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand(query,Con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }
        
        public static int GetAutoId(string sql)
        {
            int i=1;

            try
            {
                DataTable dt = GetDataTable(sql);
                if (dt.Rows.Count >= 1)
                {
                    i = (int.Parse(dt.Rows[0][0].ToString()) + 1);
                }
                else
                    i = 1;

            }
            catch (Exception)
            {

                i = 1;
            }
            return i;
        }
        //Auto increment for add new staff details form
        public static int Auto_Incr(string Table_Name, string ID_Field_Name, int Start_Point)
        {
            Con_Open();

            int Cnt = 0;

            SqlCommand Cmd = new SqlCommand();

            Cmd.Connection = Con;
            Cmd.CommandText = "Select Count(*) From " + Table_Name + "";

            Cnt = Convert.ToInt32(Cmd.ExecuteScalar());

            if (Cnt > 0)
            {
                Cmd.Dispose();

                Cmd.Connection = Con;
                Cmd.CommandText = "Select Max(" + ID_Field_Name + ") From " + Table_Name + "";

                Cnt = Convert.ToInt32(Cmd.ExecuteScalar());

                Cnt += 1;
            }
            else
            {
                Cnt = Start_Point;
            }

            Con_Close();
            return Cnt;
        }
    }
}
