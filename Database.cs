using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Windows.Forms;

namespace CRM
{
    class Database
    {

        public Database()
        {
            connected = false;
            create_connection();
        }

        public SqlConnection conn;
        public bool connected;


        public void create_connection() {
            this.conn = new SqlConnection();
            {
                try
                {
                    conn.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["CRM.Properties.Settings.CRMConnectionString"].ToString();
                    conn.Open();
                    connected = true;
                }
                catch
                {
                    connected = false;
                    MessageBox.Show("Can not connect to database.");
                }
            }

        }

        //Return dataset. Query without parametres  
        public DataSet invoke_sql(string query) {
            SqlDataAdapter dadapter = new SqlDataAdapter();
            dadapter.SelectCommand = new SqlCommand(query, conn);
            DataSet dset = new DataSet();
            dadapter.Fill(dset);
            return dset;
        }

        //SomeMethod(new[] {"value 1", "value 2", "value 3"});
        //Return dataset. Query with parametres
        public DataSet invoke(string query, String[] arrayString) {
            SqlDataAdapter dadapter = new SqlDataAdapter();
            SqlCommand command=new SqlCommand(query, conn);
            dadapter.SelectCommand = command;
            string str;
            for (int i = 0; i< arrayString.Length; i++) {
                str = arrayString[i];
                command.Parameters.Add(new SqlParameter(i.ToString() , str));
            }
            
            DataSet dset = new DataSet();
            dadapter.Fill(dset);
            return dset;
        }



        public void execute_sql(string query) {
            SqlCommand command = new SqlCommand(query, conn);
            command.ExecuteNonQuery();
        }


        public void execute(SqlCommand command) {
            command.ExecuteNonQuery();
        }


        public void execute(string query, String[] arrayString) {

            SqlDataAdapter dadapter = new SqlDataAdapter();
            SqlCommand command = new SqlCommand(query, conn);
            dadapter.SelectCommand = command;
            string str;
            for (int i = 0; i < arrayString.Length; i++)
            {
                str = arrayString[i];
                command.Parameters.Add(new SqlParameter(i.ToString(), str));
            }

            command.ExecuteNonQuery();



        }
        


        }
}
