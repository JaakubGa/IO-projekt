//hubert i sabina <3
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;
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
        public List<string> ListaZaznaczonychKategorii;
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
        public static void UzupelnijListeWyszukiwania(CheckedListBox listaKategori, bool wyszukajPoTekscie = true)
        {
            //czyszczenie listy
            _instance.ListaWyszukiwania = new List<int>();

            //uzupelnienie nowymi id
            using (SqlConnection Connection = new SqlConnection(Connect.StringConnection))
            {
                //wyszukanie po wpisanym polu
                StringBuilder where = new StringBuilder();
                if (_instance.WyszukajTekst != string.Empty && wyszukajPoTekscie)
                    where.Append($"WHERE S.nazwa LIKE '%{_instance.WyszukajTekst}%' AND (S.id_kategorii = K.id_kategorii) ");
                else
                    where.Append($"WHERE (S.id_kategorii = K.id_kategorii) ");

                //wyszukiwanie po kategori
                if (listaKategori.CheckedItems.Count > 0)
                {
                    bool pierwsza = true;
                    where.Append("AND (");
                    foreach (var kategoria in listaKategori.CheckedItems)
                    {
                        if (pierwsza)
                        {
                            where.Append($"K.nazwa = '{kategoria}' ");
                            pierwsza = false;
                            continue;
                        }
                        where.Append($"OR K.nazwa = '{kategoria}' ");
                    }
                    where.Append(")");
                }

                SqlCommand command = new SqlCommand($"SELECT * FROM Sprzet S, Kategoria K {where}", Connection);
                Connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                //wypisanie danych z bazy
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
                    _instance.ListaKategorii.Add(reader[1].ToString());
                }

                reader.Close();
                Connection.Close();
            }
        }
    }
}
