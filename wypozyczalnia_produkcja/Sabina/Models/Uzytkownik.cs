using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wypozyczalnia_produkcja.Sabina.Connection;

namespace wypozyczalnia_produkcja.Sabina.Models
{
    public class Uzytkownik
    {
        public int Id;
        public int IdAdresu;
        public string Imie;
        public string Nazwisko;
        public string Nick;
        public string Telefon = string.Empty;
        public string Email = string.Empty;
        public Adres Adres;
        //sabina
        public Uzytkownik(int id)
        {
            using (SqlConnection Connection = new SqlConnection(Connect.StringConnection))
            {

                SqlCommand command = new SqlCommand($"SELECT * FROM Uzytkownik WHERE id_Uzytkownika = {id}", Connection);
                Connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                //wpisanie danych z bazy
                while (reader.Read())
                {
                    Id = (int)reader[0];
                    IdAdresu = (int)reader[1];
                    Imie = reader[2].ToString();
                    Nazwisko = reader[3].ToString();
                    Nick = reader[4].ToString();
                    Telefon = (string)reader[5];
                    Email = reader[6].ToString();
                }

                reader.Close();
                Connection.Close();
            }
        }
        public void DopiszAdres()
        {
            Adres = new Adres(IdAdresu);
        }
    }
}
