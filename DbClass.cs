using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ZDefteri
{
    public class DbClass
    {// .\SqlExpress
        string baglantiCumlesi = "data source=.;user=sa;pwd=123;initial catalog=ZDefteri";

        public DataSet DataSetGetir(string sql)
        {
            string komutCumlesi = sql;

            SqlDataAdapter kamyon = new SqlDataAdapter(komutCumlesi, baglantiCumlesi);
            DataSet ramDataSet = new DataSet();
            kamyon.Fill(ramDataSet);
            return ramDataSet;
        }

        public SqlDataReader DataReaderGetir(string sql)
        {
            SqlConnection cnn = new SqlConnection(baglantiCumlesi);
            SqlCommand cmd = new SqlCommand(sql, cnn);
            cnn.Open();
            SqlDataReader dr = cmd.ExecuteReader
                (CommandBehavior.CloseConnection);
            return dr;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="tip">0 = nonquery,1=scalar</param>
        /// <returns></returns>
        public string ExecuteQuery(string sql, int tip)
        {
            SqlConnection cnn = new SqlConnection(baglantiCumlesi);
            SqlCommand cmd = new SqlCommand(sql, cnn);
            cnn.Open();
            string sonuc = "";
            if (tip == 0)
            {
                sonuc = cmd.ExecuteNonQuery().ToString();
            }
            else if (tip == 1)
            {
                sonuc = cmd.ExecuteScalar().ToString();
            }
            cnn.Close();
            return sonuc;
        }
    }
   
  
}