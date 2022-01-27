using System.Data.SqlClient;
using wypozyczalnia_produkcja.Params;

//sabina
namespace wypozyczalnia_produkcja.Models
{
    public class Zamowienie
    {
        public int Id;
        public int IdUzytkownika;
        public int IdSprzetu;
        public string DataOd;
        public string DataDo;
        public decimal Cena;
        public Uzytkownik Uzytkownik;
        public Sprzet Sprzet;

        public Zamowienie(int id)
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
                    IdUzytkownika = (int)reader[1];
                    IdSprzetu = (int)reader[2];
                    DataOd = reader[3].ToString();
                    DataDo = reader[4].ToString();
                    Cena = (decimal)reader[5];
                }

                reader.Close();
                Connection.Close();
            }
            Uzytkownik = new Uzytkownik(IdUzytkownika);
            Sprzet = new Sprzet(IdSprzetu);
        }
    }
}
