using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W07_01_NorthwindORM
{
    public class Tools
    {
        private static SqlConnection conn;

        //baglanti = new SqlConnection(ConfigurationManager.ConnectionStrings["baglanti"].ConnectionString);      

        public static SqlConnection Connection
        {
            get
            {
                if (conn == null) //baglanti her kullanıldığında yeniden new ile örneklenmesin (singleton pattern)
                {
                    conn = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString);
                }
                return conn;
            }
            //set { baglanti = value; }
        }

        public static bool ExecuteNonQuery(SqlCommand komut)
        {
            try
            {
                int sonuc = 0;
                if (komut.Connection.State == ConnectionState.Closed)
                    komut.Connection.Open();
                sonuc = komut.ExecuteNonQuery();
                return sonuc > 0 ? true : false;
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                if (komut.Connection.State == ConnectionState.Open)
                    komut.Connection.Close();
            }
        }
    }
}