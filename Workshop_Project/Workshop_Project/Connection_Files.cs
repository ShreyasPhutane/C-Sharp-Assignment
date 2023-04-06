using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Workshop_Project
{
    public class Connection_Files
    {
        public Sqlconnection cn;
         
        public Connection_Files()
        {
            cn = new Sqlconnection(@"Data Source=shreyas\sqlexpress01;Initial Catalog=db_Workshop_Project;Integrated Security=True");
            cn.Open();
        }
        public DataTable GetDataTable(string sql)
        {
            SqlDataAdapter da = new SqlDataAdapter(sql, cn);
            DataTable dataTable= new DataTable();
            da.Fill(dataTable);
            return dataTable;
        }
        public int GetAutoID(String sql)
        {
            int i = 1;
            try
            {
                DataTable dt = new GetDataTable(sql);
                if(dt.Rows.Count >=1)
                { 
                    i = (int.Parse(dt.Rows[0][0].ToString())+1);
                }
                else
                    i= 1;
            }
            catch
            {
                i= 1;
            }
            return i;
        }
        public void ExecuteSqlQuery(string sql)
        {
            Sqlcommand cmd = new Sqlcommand();
            cmd.Connection = cn;
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
                
        }
        public void FillCombo(ComboBox cb, string sql, dismemb, string val)
        {
            DataTable dt = GetDataTable(sql);
            cb.ValueMember= val;
            cb.DisplayMember = dismemb;
            cb.DataSource = dt;
        }


    }
}
