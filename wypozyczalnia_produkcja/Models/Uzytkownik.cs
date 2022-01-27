using System.Data.SqlClient;
using wypozyczalnia_produkcja.Params;

//sabina
namespace wypozyczalnia_produkcja.Models
{
    public class Uzytkownik
    {
        public int Id;
        public int IdAdresu;
        public string Imie;
        public string Nazwisko;
        public string Nick;
        private string _haslo;
        public string Telefon = string.Empty;
        public string Email = string.Empty;
        public Adres Adres;

        //CTOR
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
                    _haslo = reader[5].ToString();
                    Telefon = reader[6].ToString();
                    Email = reader[7].ToString();
                }

                reader.Close();
                Connection.Close();
            }
            Adres = new Adres(IdAdresu);
        }
    }
}
