//hubert
using System.Collections.Generic;
using System.Data.SqlClient;
using wypozyczalnia.DSanak;
using wypozyczalnia.DSanak.Rejestracja;

namespace wypozyczalnia_produkcja.Params
{
    public sealed class Singleton
    {
        public List<int> ListaKoszyk; 
        //do wyszukiwania
        public List<int> ListaWyszukiwania; 
        public List<string> ListaKategorii;
        public string WyszukajTekst;
        //do logowania
        public LogowanieFormularz logowanie = new LogowanieFormularz();
        public Rejestracja rejestracja = new Rejestracja();
        public int IdZalogowanego;
        public bool ButtonsIsVisible;

        private Singleton() { }

        private static Singleton _instance;
        public static Singleton GetInstance()
        {
            if (_instance == null)
            {
                _instance = new Singleton();
            }
            return _instance;
        }
        public static void UzupelnijListeWyszukiwania()
        {
            //czyszczenie listy
            _instance.ListaWyszukiwania = new List<int>();
            //uzupelnienie nowymi id
            using (SqlConnection Connection = new SqlConnection(Connect.StringConnection))
            {
                //wyszukanie po wpisanym polu
                string where = string.Empty;
                if (_instance.WyszukajTekst != string.Empty) 
                    where = $"WHERE nazwa LIKE '%{_instance.WyszukajTekst}%'";

                SqlCommand command = new SqlCommand($"SELECT * FROM Sprzet {where}", Connection);
                Connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                //wpisanie danych z bazy
                while (reader.Read())
                {
                    _instance.ListaWyszukiwania.Add((int)reader[0]);
                }

                reader.Close();
                Connection.Close();
            }
        }
        public static void UzupelnijListeKategori()
        {
            //czyszczenie listy
            _instance.ListaKategorii = new List<string>();
            //uzupelnienie nowymi id
            using (SqlConnection Connection = new SqlConnection(Connect.StringConnection))
            {
                SqlCommand command = new SqlCommand($"SELECT * FROM Kategoria", Connection);
                Connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                //wpisanie danych z bazy
                while (reader.Read())
                {
                    _instance.ListaKategorii.Add((reader[1].ToString()));
                }

                reader.Close();
                Connection.Close();
            }
        }
    }
}
