using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Pharmacy_Manager.BL
{
    class CLS_Customers
    {
        public DataTable Get_All_Customers()
        {
            //Data access layer object
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            //Open the connection
            DAL.Open();

            //DataTable object
            DataTable DT = new DataTable();

            //Give DataTable object a value
            DT = DAL.SelectData("Get_All_Customers", null);

            //Close the connection
            DAL.Close();

            //The return value
            return DT;
        }

        public void Add_Customer(int ID, string FirstName, string LastName, string Tel, string Email)
        {
            //Data access layer object
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            //Open the connection
            DAL.Open();

            //SQL-Parameters Array
            SqlParameter[] Param = new SqlParameter[5];

            //Value of SQL-Parameters
            Param[0] = new SqlParameter("@ID", SqlDbType.Int, 50);
            Param[0].Value = ID;
            //
            Param[1] = new SqlParameter("@First_Name", SqlDbType.VarChar, 50);
            Param[1].Value = FirstName;
            //
            Param[2] = new SqlParameter("@Last_Name", SqlDbType.VarChar, 50);
            Param[2].Value = LastName;
            //
            Param[3] = new SqlParameter("@Tel", SqlDbType.NChar, 10);
            Param[3].Value = Tel;
            //
            Param[4] = new SqlParameter("@Email", SqlDbType.VarChar, 50);
            Param[4].Value = Email;

            //Excute Command
            DAL.ExecuteCommand("Add_Customer", Param);

            //Close the connection
            DAL.Close();
        }

        public void Edit_Customer(int ID, string FirstName, string LastName, string Tel, string Email)
        {
            //Data access layer object
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            //Open the connection
            DAL.Open();

            //SQL-Parameters Array
            SqlParameter[] Param = new SqlParameter[5];

            //Value of SQL-Parameters
            Param[0] = new SqlParameter("@ID", SqlDbType.Int, 50);
            Param[0].Value = ID;
            //
            Param[1] = new SqlParameter("@First_Name", SqlDbType.VarChar, 50);
            Param[1].Value = FirstName;
            //
            Param[2] = new SqlParameter("@Last_Name", SqlDbType.VarChar, 50);
            Param[2].Value = LastName;
            //
            Param[3] = new SqlParameter("@Tel", SqlDbType.NChar, 10);
            Param[3].Value = Tel;
            //
            Param[4] = new SqlParameter("@Email", SqlDbType.VarChar, 50);
            Param[4].Value = Email;

            //Excute Command
            DAL.ExecuteCommand("Edit_Customer", Param);

            //Close the connection
            DAL.Close();
        }

        public void Delete_Customer(int ID)
        {
            //Data access layer object
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            //Open the connection
            DAL.Open();

            //SQL-Parameters Array
            SqlParameter[] Param = new SqlParameter[1];

            //Value of SQL-Parameters
            Param[0] = new SqlParameter("@ID", SqlDbType.Int, 50);
            Param[0].Value = ID;

            //Excute Command
            DAL.ExecuteCommand("Delete_Customer", Param);

            //Close the connection
            DAL.Close();
        }

        public DataTable Search_Customers(string KeyWord)
        {
            //Data access layer object
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            //Open the connection
            DAL.Open();

            //DataTable object
            DataTable DT = new DataTable();

            //SQL-Parameters Array
            SqlParameter[] Param = new SqlParameter[1];

            //Value of SQL-Parameters
            Param[0] = new SqlParameter("@KeyWord", SqlDbType.VarChar, 50);
            Param[0].Value = KeyWord;

            //Give DataTable object a value
            DT = DAL.SelectData("Search_Customers", Param);

            //Close the connection
            DAL.Close();

            //The return value
            return DT;
        }
    }
}
