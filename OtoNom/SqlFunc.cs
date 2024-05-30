using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace OtoNom
{
    public class SqlFunc
    {
        private SqlConnection baglanti;
        private SqlCommand sqlkomut;

        public SqlFunc()
        {
            baglanti = new SqlConnection(@"Data Source=DESKTOP-NICV536\SQLEXPRESS01;Initial Catalog=InsertCoDuz;Integrated Security=True;");
            sqlkomut = new SqlCommand();
        }

        private bool baglan()
        {
            try
            {
                if (baglanti.State == ConnectionState.Closed)
                {
                    baglanti.Open();
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        private void baglantiKapat()
        {
            if (baglanti.State == ConnectionState.Open)
            {
                baglanti.Close();
            }
        }

        public DataTable Select(string sorgu)
        {
            using (SqlDataAdapter adapter = new SqlDataAdapter(sorgu, baglanti))
            {
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }

        public DataTable Select(string sorgu, Dictionary<string, object> parameters)
        {
            if (baglan() == true)
            {
                sqlkomut.Connection = baglanti;
                sqlkomut.CommandText = sorgu;

                // Parametreleri ekleyin
                foreach (var param in parameters)
                {
                    sqlkomut.Parameters.AddWithValue(param.Key, param.Value ?? DBNull.Value);
                }

                using (SqlDataAdapter adapter = new SqlDataAdapter(sqlkomut))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    baglantiKapat();
                    return dt;
                }
            }
            else
            {
                return null;
            }
        }

        public int Insert(string sorgu, Dictionary<string, object> parameters)
        {
            if (baglan() == true)
            {
                sqlkomut.Connection = baglanti;
                sqlkomut.CommandText = sorgu;

                // Parametreleri ekleyin
                foreach (var param in parameters)
                {
                    sqlkomut.Parameters.AddWithValue(param.Key, param.Value ?? DBNull.Value);
                }

                int sayi = sqlkomut.ExecuteNonQuery();
                baglantiKapat();
                return sayi;
            }
            else
            {
                return 0;
            }
        }

        public int Update(string sorgu, Dictionary<string, object> parameters)
        {
            if (baglan() == true)
            {
                sqlkomut.Connection = baglanti;
                sqlkomut.CommandText = sorgu;

                // Parametreleri ekleyin
                foreach (var param in parameters)
                {
                    sqlkomut.Parameters.AddWithValue(param.Key, param.Value ?? DBNull.Value);
                }

                int sayi = sqlkomut.ExecuteNonQuery();
                baglantiKapat();
                return sayi;
            }
            else
            {
                return 0;
            }
        }



        public int Delete(string query, Dictionary<string, object> parameters)
        {
            using (SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-NICV536\SQLEXPRESS01;Initial Catalog=InsertCoDuz;Integrated Security=True;"))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.Clear(); // Parametreleri temizleyin

                    foreach (var param in parameters)
                    {
                        cmd.Parameters.AddWithValue(param.Key, param.Value);
                    }

                    conn.Open();
                    return cmd.ExecuteNonQuery();
                }
            }
        }













    }
}


          
            


