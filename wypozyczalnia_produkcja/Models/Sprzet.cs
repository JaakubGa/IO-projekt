using System.Data.SqlClient;
using wypozyczalnia_produkcja.Params;

//sabina
namespace wypozyczalnia_produkcja.Models
{
    public class Sprzet
    {
        //public
        public int Id;
        public int IdWlasciciela;
        public int Idkategoria;
        public string Nazwa;
        public string Datadostepnosci;
        public decimal Cena;
        public string Kategoria;
        public Uzytkownik Uzytkownik;

        //CTOR
        public Sprzet(int id)
        {
            using (SqlConnection Connection = new SqlConnection(Connect.StringConnection))
            {
                SqlCommand command = new SqlCommand($"SELECT * FROM Sprzet WHERE id_sprzetu = {id}", Connection);
                Connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                //wpisanie danych z bazy
                while (reader.Read())
                {
                    Id = (int)reader[0];
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
            Uzytkownik = new Uzytkownik(IdWlasciciela);
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
    }
}
