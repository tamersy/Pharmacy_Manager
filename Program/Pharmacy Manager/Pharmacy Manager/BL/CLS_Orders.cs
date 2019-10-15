using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Pharmacy_Manager.BL
{
    class CLS_Orders
    {
        public DataTable Get_Last_Order_ID()
        {
            //Data access layer object
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            //Open the connection
            DAL.Open();

            //DataTable object
            DataTable DT = new DataTable();

            //Give DataTable object a value
            DT = DAL.SelectData("Get_Last_Order_ID", null);

            //Close the connection
            DAL.Close();

            //The return value
            return DT;
        }

        public void Add_Order(int ID, DateTime Order_Date, int Customer, string Des_Order, string User)
        {
            //Data access layer object
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            //Open the connection
            DAL.Open();

            //SQL-Parameters Array
            SqlParameter[] Param = new SqlParameter[5];

            //Value of SQL-Parameters
            Param[0] = new SqlParameter("@ID", SqlDbType.Int);
            Param[0].Value = ID;
            //
            Param[1] = new SqlParameter("@Date_Order", SqlDbType.DateTime);
            Param[1].Value = Order_Date;
            //
            Param[2] = new SqlParameter("@ID_Customer", SqlDbType.Int);
            Param[2].Value = Customer;
            //
            Param[3] = new SqlParameter("@Des_Order", SqlDbType.VarChar, 250);
            Param[3].Value = Des_Order;
            //
            Param[4] = new SqlParameter("@SaleMan", SqlDbType.VarChar, 50);
            Param[4].Value = User;

            //Excute Command
            DAL.ExecuteCommand("Add_Order", Param);

            //Close the connection
            DAL.Close();
        }

        public void Add_Order_Details(string ID, int ID_Order, int Quantity, string Price, string Total_Amount)
        {
            //Data access layer object
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            //Open the connection
            DAL.Open();

            //SQL-Parameters Array
            SqlParameter[] Param = new SqlParameter[5];

            //Value of SQL-Parameters
            Param[0] = new SqlParameter("@ID_Medicine", SqlDbType.VarChar, 50);
            Param[0].Value = ID;
            //
            Param[1] = new SqlParameter("@ID_Order", SqlDbType.Int);
            Param[1].Value = ID_Order;
            //
            Param[2] = new SqlParameter("@Quantity", SqlDbType.Int);
            Param[2].Value = Quantity;
            //
            Param[3] = new SqlParameter("@Price", SqlDbType.VarChar, 50);
            Param[3].Value = Price;
            //
            Param[4] = new SqlParameter("@Total_Amount", SqlDbType.VarChar, 50);
            Param[4].Value = Total_Amount;

            //Excute Command
            DAL.ExecuteCommand("Add_Order_Details", Param);

            //Close the connection
            DAL.Close();
        }

        public DataTable VerifyQty(string ID, int Qty_Entered)
        {
            //Data access layer object
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            //Open the connection
            DAL.Open();

            //DataTable object
            DataTable DT = new DataTable();

            //SQL-Parameters Array
            SqlParameter[] Param = new SqlParameter[2];

            //Value of SQL-Parameter
            Param[0] = new SqlParameter("@ID_Medicine", SqlDbType.VarChar, 50);
            Param[0].Value = ID;
            //
            Param[1] = new SqlParameter("@Qty_Entered", SqlDbType.Int);
            Param[1].Value = Qty_Entered;

            //Give DataTable object a value
            DT = DAL.SelectData("VerifyQty", Param);

            //Close the connection
            DAL.Close();

            //The return value
            return DT;
        }

        public DataTable Get_Last_Order_ID_For_Print()
        {
            //Data access layer object
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            //Open the connection
            DAL.Open();

            //DataTable object
            DataTable DT = new DataTable();

            //Give DataTable object a value
            DT = DAL.SelectData("Get_Last_Order_ID_For_Print", null);

            //Close the connection
            DAL.Close();

            //The return value
            return DT;
        }

        public DataTable Get_Order_Details(int ID_Order)
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
            Param[0] = new SqlParameter("@ID_Order", SqlDbType.Int);
            Param[0].Value = ID_Order;

            //Give DataTable object a value
            DT = DAL.SelectData("Get_Order_Details", Param);

            //Close the connection
            DAL.Close();

            //The return value
            return DT;
        }

        public DataTable Search_Orders(string KeyWord)
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
            DT = DAL.SelectData("Search_Orders", Param);

            //Close the connection
            DAL.Close();

            //The return value
            return DT;
        }
    }
}
