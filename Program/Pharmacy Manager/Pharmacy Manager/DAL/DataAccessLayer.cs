using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Pharmacy_Manager.DAL
{
    class DataAccessLayer
    {
        //Connection Object
        SqlConnection SQLconnection;

        //Constructor
        public DataAccessLayer()
        {
            string mode = Properties.Settings.Default.Mode;

            //Connection String
            if (mode == "SQL")
            {
                SQLconnection = new SqlConnection(@"Server =" + Properties.Settings.Default.Server + "; Database = " + Properties.Settings.Default.Database + "; Integrated Security = false; User ID =" + Properties.Settings.Default.ID + ";Password=" + Properties.Settings.Default.Password + "");
            }
            else
            {
                SQLconnection = new SqlConnection(@"Server =" + Properties.Settings.Default.Server + "; Database = " + Properties.Settings.Default.Database + "; Integrated Security = true");
            }
        }

        //Open the connection
        public void Open()
        {
            if(SQLconnection.State != ConnectionState.Open)
            {
                SQLconnection.Open();
            }
        }

        //Close the connection
        public void Close()
        {
            if(SQLconnection.State == ConnectionState.Open)
            {
                SQLconnection.Close();
            }
        }

        //Read data from database
        public DataTable SelectData(string stored_procedure, SqlParameter[] param)
        {
            //Command Object
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlcmd.CommandText = stored_procedure;
            sqlcmd.Connection = SQLconnection;

            //Add Parameters to SqlCommand Parameters
            if(param != null)
            {
                for(int i = 0; i < param.Length; i++)
                {
                    sqlcmd.Parameters.Add(param[i]);
                }
            }

            //Run SqlCommand and fill DataTable
            SqlDataAdapter da = new SqlDataAdapter(sqlcmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            //The return value
            return dt;
        }

        //Edit, Insert, Delate Data
        public void ExecuteCommand(string stored_procedure, SqlParameter[] param)
        {
            //Command Object
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlcmd.CommandText = stored_procedure;
            sqlcmd.Connection = SQLconnection;

            //Add Parameters to SqlCommand Parameters
            if (param != null)
            {
                for (int i = 0; i < param.Length; i++)
                {
                    sqlcmd.Parameters.Add(param[i]);
                }
            }

            //Execute command
            sqlcmd.ExecuteNonQuery();
        }
    }
}
