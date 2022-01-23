using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wypozyczalnia_produkcja.Params;

namespace wypozyczalnia_produkcja.Sabina.Models
{
    public class Adres
    {
        public int Id;
        public string Miasto;
        public string KodPocztowy;
        public string Ulica;
        public string NrDomu;
        public string NrMieszkania;
        //sabina
        public Adres(int id)
        {
            using (SqlConnection Connection = new SqlConnection(Connect.StringConnection))
            {
                SqlCommand command = new SqlCommand($"SELECT * FROM Adres WHERE id_adresu = {id}", Connection);
                Connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                //wpisanie danych z bazy
                while (reader.Read())
                {
                    Id = (int)reader[0];
                    Miasto = reader[1].ToString();
                    KodPocztowy = reader[2].ToString();
                    Ulica = reader[3].ToString();
                    NrDomu = reader[4].ToString();
                    NrMieszkania = reader[5].ToString();
                }

                reader.Close();
                Connection.Close();
            }
        }
    }
}
