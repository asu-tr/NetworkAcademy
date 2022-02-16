using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace W07_01_NorthwindORM
{
    public class BaseORM<T> : IORM<T>
    {
        public DataTable Listele()
        {
            SqlDataAdapter adp = new SqlDataAdapter();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Tools.Connection;
            cmd.CommandText = string.Format("List{0}", typeof(T).Name);
            cmd.CommandType = CommandType.StoredProcedure;
            adp.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adp.Fill(dt);
            return dt;

        }
        public bool Ekle(T entity)
        {
            SqlCommand komut = new SqlCommand();
            komut.CommandText = string.Format("{0}Ekle", typeof(T).Name);
            komut.Connection = Tools.Connection;
            komut.CommandType = CommandType.StoredProcedure;

            PropertyInfo[] parametreler = typeof(T).GetProperties();

            for (int i = 1; i < parametreler.Count(); i++)
            {
                if (parametreler[i].GetValue(entity) == null)
                    parametreler[i].SetValue(entity, "0"); komut.Parameters.AddWithValue(parametreler[i].Name, parametreler[i].GetValue(entity));

            }
            //foreach (PropertyInfo item in parametreler)
            //{
            //   komut.Parameters.AddWithValue(item.Name,item.GetValue(entity));
            //}

            return Tools.ExecuteNonQuery(komut);

        }

        public bool Guncelle(T entity)
        {
            return true;
        }


        public bool Sil(int id)
        {
            return true;
        }
    }
}
