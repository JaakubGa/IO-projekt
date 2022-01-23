using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using wypozyczalnia_produkcja.Params;

//sabina
namespace wypozyczalnia_produkcja.Sabina.Models
{
    public class PrzedmiotModel
    {
        //public
        public int ID;
        public int IdWlasciciela;
        public int Idkategoria;
        public string Nazwa;
        public string Datadostepnosci;
        public decimal Cena;
        public string Kategoria;
        public Uzytkownik uzytkownik;

        //CTOR
        public PrzedmiotModel(int id)
        {
            using (SqlConnection Connection = new SqlConnection(Connect.StringConnection))
            {
                SqlCommand command = new SqlCommand($"SELECT * FROM Sprzet WHERE id_sprzetu = {id}", Connection);
                Connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                //wpisanie danych z bazy
                while (reader.Read())
                {
                    ID = (int)reader[0];
                    IdWlasciciela = (int)reader[1];
                    Idkategoria = (int)reader[2];
                    Nazwa = reader[3].ToString();
                    Datadostepnosci = reader[4].ToString();
                    Cena = (decimal)reader[5];
                }

                reader.Close();
                Connection.Close();
            }
            DopiszKategorie();
            DopiszUzytkownika();
        }

        public void DopiszKategorie()
        {
            using (SqlConnection Connection = new SqlConnection(Connect.StringConnection))
            {
                SqlCommand command = new SqlCommand($"SELECT nazwa FROM Kategoria WHERE id_kategorii = {Idkategoria}", Connection);
                Connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                //wpisanie danych z bazy
                while (reader.Read())
                {
                    Kategoria = (string)reader[0];
                }

                reader.Close();
                Connection.Close();
            }
        }
        public void DopiszUzytkownika()
        {
            uzytkownik = new Uzytkownik(IdWlasciciela);
        }
    }
}
