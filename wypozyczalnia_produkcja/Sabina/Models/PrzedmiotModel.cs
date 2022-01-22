using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using wypozyczalnia_produkcja.Sabina.Connection;


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

            using (Connect.Connection)
            {
                SqlCommand command = new SqlCommand($"SELECT * FROM Sprzet WHERE id_sprzetu = {id}", Connect.Connection);
                Connect.Connection.Open();

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
                Connect.Connection.Close();
            }
            DopiszDaneZId();
        }

        public void DopiszDaneZId()
        {
            /*using (SqlConnection connection = new SqlConnection("Data Source=LAPTOP-Q6JBHJK9;Initial Catalog=Wypozyczalnia;Integrated Security=True"))
            {
                SqlCommand command = new SqlCommand($"SELECT nazwa FROM Kategoria WHERE id_kategorii = 6", connection);
                connection.Open();

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
            }*/
        } 
    }
}
