using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DAO
{
    class DataProvider_DAO
    { 
        // Sai
        //public static string StrConnect = "LAPTOP-FUAJRQ65;Initial Catalog=ManageAppleStore;Integrated Security=True";

        // Dung
        public static string StrConnect = "Data Source=LAPTOP-FUAJRQ65;Initial Catalog=ManageAppleStore;Integrated Security=True";

        public static SqlConnection OpenConnect()
        {
            SqlConnection Conn = new SqlConnection(StrConnect);
            Conn.Open();
            return Conn;
        }
       
        public static SqlDataReader SelectData(string StrSelect, SqlConnection Conn)
        {
            SqlCommand CMD = new SqlCommand(StrSelect, Conn);
            SqlDataReader SDR = CMD.ExecuteReader();
            return SDR;
        }

        public static bool InUpDel(string Str, SqlConnection Conn)
        {
            SqlCommand CMD = new SqlCommand(Str, Conn);
            int Result = CMD.ExecuteNonQuery();
            return (Result != 0);
        }
    }
}
