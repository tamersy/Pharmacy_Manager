using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Pharmacy_Manager.BL
{
    class CLS_Login
    {
        public DataTable Login(string id, string pwd)
        {
            //Data access layer object
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            //Array of parameters of stored procedure
            SqlParameter[] param = new SqlParameter[2];

            //Select parameters and give them values
            param[0] = new SqlParameter("@ID", SqlDbType.VarChar, 50);
            param[0].Value = id;
            //
            param[1] = new SqlParameter("@PWD", SqlDbType.VarChar, 50);
            param[1].Value = pwd;

            //Open the connection
            DAL.Open();

            //DataTable object
            DataTable DT = new DataTable();

            //Give DataTable object a value
            DT = DAL.SelectData("SP_Login", param);

            //Close the connection
            DAL.Close();

            //The return value
            return DT;
        }

        public void Add_User(string ID, string FullName, string PWD, string UserType)
        {
            //Data access layer object
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            //Open the connection
            DAL.Open();

            //SQL-Parameters Array
            SqlParameter[] Param = new SqlParameter[4];

            //Value of SQL-Parameters
            Param[0] = new SqlParameter("@ID", SqlDbType.VarChar, 50);
            Param[0].Value = ID;
            //
            Param[1] = new SqlParameter("@FullName", SqlDbType.VarChar, 50);
            Param[1].Value = FullName;
            //
            Param[2] = new SqlParameter("@PWD", SqlDbType.VarChar, 50);
            Param[2].Value = PWD;
            //
            Param[3] = new SqlParameter("@UserType", SqlDbType.VarChar, 10);
            Param[3].Value = UserType;

            //Excute Command
            DAL.ExecuteCommand("Add_User", Param);

            //Close the connection
            DAL.Close();
        }

        public DataTable SearchUsers(string KeyWord)
        {
            //Data access layer object
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            //Open the connection
            DAL.Open();

            //DataTable object
            DataTable DT = new DataTable();

            //SQL-Parameters Array
            SqlParameter[] Param = new SqlParameter[1];

            //Value of SQL-Parameter
            Param[0] = new SqlParameter("@KeyWord", SqlDbType.VarChar, 50);
            Param[0].Value = KeyWord;

            //Give DataTable object a value
            DT = DAL.SelectData("SearchUsers", Param);

            //Close the connection
            DAL.Close();

            //The return value
            return DT;
        }

        public void Edit_User(string ID, string FullName, string PWD, string UserType)
        {
            //Data access layer object
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            //Open the connection
            DAL.Open();

            //SQL-Parameters Array
            SqlParameter[] Param = new SqlParameter[4];

            //Value of SQL-Parameters
            Param[0] = new SqlParameter("@ID", SqlDbType.VarChar, 50);
            Param[0].Value = ID;
            //
            Param[1] = new SqlParameter("@FullName", SqlDbType.VarChar, 50);
            Param[1].Value = FullName;
            //
            Param[2] = new SqlParameter("@PWD", SqlDbType.VarChar, 50);
            Param[2].Value = PWD;
            //
            Param[3] = new SqlParameter("@UserType", SqlDbType.VarChar, 10);
            Param[3].Value = UserType;

            //Excute Command
            DAL.ExecuteCommand("Edit_User", Param);

            //Close the connection
            DAL.Close();
        }

        public DataTable Delete_User(string ID)
        {
            //Data access layer object
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            //Open the connection
            DAL.Open();

            //DataTable object
            DataTable DT = new DataTable();

            //SQL-Parameters Array
            SqlParameter[] Param = new SqlParameter[1];

            //Value of SQL-Parameter
            Param[0] = new SqlParameter("@ID", SqlDbType.VarChar, 50);
            Param[0].Value = ID;

            //Give DataTable object a value
            DT = DAL.SelectData("Delete_User", Param);

            //Close the connection
            DAL.Close();

            //The return value
            return DT;
        }
    }
}
