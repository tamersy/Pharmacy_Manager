using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Pharmacy_Manager.BL
{
    class CLS_Medicines
    {
        public DataTable Get_All_Categories()
        {
            //Data access layer object
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            //Open the connection
            DAL.Open();

            //DataTable object
            DataTable DT = new DataTable();

            //Give DataTable object a value
            DT = DAL.SelectData("Get_All_Categories", null);

            //Close the connection
            DAL.Close();

            //The return value
            return DT;
        }

        public void Add_Medicine(string ID_medicine, string Label_medicine, int Quantity, string Price, byte[] Img, string ID_category)
        {
            //Data access layer object
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            //Open the connection
            DAL.Open();

            //SQL-Parameters Array
            SqlParameter[] Param = new SqlParameter[6];

            //Value of SQL-Parameters
            Param[0] = new SqlParameter("@ID_Med", SqlDbType.VarChar, 50);
            Param[0].Value = ID_medicine;
            //
            Param[1] = new SqlParameter("@Label_Med", SqlDbType.VarChar, 50);
            Param[1].Value = Label_medicine;
            //
            Param[2] = new SqlParameter("@Quat", SqlDbType.Int);
            Param[2].Value = Quantity;
            //
            Param[3] = new SqlParameter("@Price", SqlDbType.VarChar, 50);
            Param[3].Value = Price;
            //
            Param[4] = new SqlParameter("@Img", SqlDbType.Image);
            Param[4].Value = Img;
            //
            Param[5] = new SqlParameter("@ID_Cate", SqlDbType.VarChar, 50);
            Param[5].Value = ID_category;

            //Excute Command
            DAL.ExecuteCommand("Add_Medicine", Param);

            //Close the connection
            DAL.Close();
        }

        public DataTable VerifyMedicineID(string ID)
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
            DT = DAL.SelectData("VerifyMedicineID", Param);

            //Close the connection
            DAL.Close();

            //The return value
            return DT;
        }

        public DataTable Get_All_Medicines()
        {
            //Data access layer object
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            //Open the connection
            DAL.Open();

            //DataTable object
            DataTable DT = new DataTable();

            //Give DataTable object a value
            DT = DAL.SelectData("Get_All_Medicines", null);

            //Close the connection
            DAL.Close();

            //The return value
            return DT;
        }

        public DataTable SearchMedicines(string KeyWord)
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
            DT = DAL.SelectData("SearchMedicines", Param);

            //Close the connection
            DAL.Close();

            //The return value
            return DT;
        }

        public void DeleteMedicines(string ID_medicine)
        {
            //Data access layer object
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            //Open the connection
            DAL.Open();

            //SQL-Parameters Array
            SqlParameter[] Param = new SqlParameter[1];

            //Value of SQL-Parameters
            Param[0] = new SqlParameter("@ID", SqlDbType.VarChar, 50);
            Param[0].Value = ID_medicine;

            //Excute Command
            DAL.ExecuteCommand("DeleteMedicines", Param);

            //Close the connection
            DAL.Close();
        }

        public DataTable Get_Image_Medicine(string ID)
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
            DT = DAL.SelectData("Get_Image_Medicine", Param);

            //Close the connection
            DAL.Close();

            //The return value
            return DT;
        }

        public void Update_Medicine(string ID_medicine, string Label_medicine, int Quantity, string Price, byte[] Img, string ID_category)
        {
            //Data access layer object
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            //Open the connection
            DAL.Open();

            //SQL-Parameters Array
            SqlParameter[] Param = new SqlParameter[6];

            //Value of SQL-Parameters
            Param[0] = new SqlParameter("@ID_Med", SqlDbType.VarChar, 50);
            Param[0].Value = ID_medicine;
            //
            Param[1] = new SqlParameter("@Label_Med", SqlDbType.VarChar, 50);
            Param[1].Value = Label_medicine;
            //
            Param[2] = new SqlParameter("@Quat", SqlDbType.Int);
            Param[2].Value = Quantity;
            //
            Param[3] = new SqlParameter("@Price", SqlDbType.VarChar, 50);
            Param[3].Value = Price;
            //
            Param[4] = new SqlParameter("@Img", SqlDbType.Image);
            Param[4].Value = Img;
            //
            Param[5] = new SqlParameter("@ID_Cate", SqlDbType.VarChar, 50);
            Param[5].Value = ID_category;

            //Excute Command
            DAL.ExecuteCommand("Update_Medicine", Param);

            //Close the connection
            DAL.Close();
        }
    }
}
