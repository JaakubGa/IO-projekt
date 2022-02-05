using System;
using System.Windows.Forms;
using wypozyczalnia_produkcja.Models;
using wypozyczalnia_produkcja.Params;
using wypozyczalnia.DSanak;
using wypozyczalnia.DSanak.Rejestracja;
using System.Text;
using System.Linq;


//sabina
namespace wypozyczalnia_produkcja.Pages
{
   
    public partial class Wyszukiwarka : Form
    {
        public Wyszukiwarka()
        {
            InitializeComponent();
        }

        private void Wyszukiwarka_Load(object sender, EventArgs e)
        {
            //wpisanie kategori
            foreach (var kategoria in Singleton.GetInstance().ListaKategorii)
            {
                this.checkedListBoxKategorie.Items.Add(kategoria);
            }
        }

      
        public void IsVisible()
        {
            this.buttonProfilUzytkownika.Visible = Singleton.GetInstance().ButtonsIsVisible;
            this.buttonZamowienia.Visible = Singleton.GetInstance().ButtonsIsVisible;
            this.buttonKoszyk.Visible = Singleton.GetInstance().ButtonsIsVisible;
        }
        private void buttonWyszukaj_Click(object sender, EventArgs e)
        {
            Singleton.GetInstance().WyszukajTekst = textBoxWyszukiwarka.Text;
            Singleton.UzupelnijListeWyszukiwania(this.checkedListBoxKategorie);
            Wyswetl();
        }

        private void buttonProfilUzytkownika_Click(object sender, EventArgs e)
        {
            ProfilUzytkownika profil = new ProfilUzytkownika();
            profil.Show();
        }

        private void buttonLogowanie_Click(object sender, EventArgs e)
        {
            Singleton.GetInstance().Logowanie.Show();
        }

        private void buttonRejestracja_Click(object sender, EventArgs e)
        {
            Singleton.GetInstance().Rejestracja.Show();
        }

        private void checkedListBoxKategorie_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.checkedListBoxKategorie.CheckedItems.Count == 0) return;
            Singleton.UzupelnijListeWyszukiwania(this.checkedListBoxKategorie, false);
            Wyswetl();
        }
        private void buttonWyczyscKategorie_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < this.checkedListBoxKategorie.Items.Count; i++)
                this.checkedListBoxKategorie.SetItemCheckState(i, CheckState.Unchecked);
            listBoxWyszukiwanie.Items.Clear();
        }

        //pomocnicze metody
        private void Wyswetl()
        {
            listBoxWyszukiwanie.Items.Clear();
            foreach (var idSprzetu in Singleton.GetInstance().ListaWyszukiwania)
            {
                Sprzet sprzet = new Sprzet(idSprzetu);
                listBoxWyszukiwanie.Items.Add(sprzet.ToString());
            }
        }

        private void listBoxWyszukiwanie_SelectedIndexChanged(object sender, EventArgs e)
        {
            //wyciąganie id
            string napis = sender.ToString();
            StringBuilder sb = new StringBuilder(napis);
            napis = sb.Remove(0, napis.IndexOf(':') + 1).ToString();
            napis = sb.Remove(0, napis.IndexOf(':') + 1).ToString();
            sb.Remove(napis.IndexOf('-'), napis.Length - napis.IndexOf('-'));
            var s = sb.Length;
            int id = Int32.Parse(sb.ToString());

            //otwarcie strony przedmiotu
            StronaPrzedmiotu stronaPrzedmiotu = new StronaPrzedmiotu(id);
            stronaPrzedmiotu.Show();
        }
        /*
        private void buttonKoszyk_Click(object sender, EventArgs e)
        {
            foreach (int id in Singleton.GetInstance().KoszykLista)
            {
                Sprzet s = new Sprzet(id);
                Koszyk.listBoxWybrane.Add(s.ToString());
            }
        }
        */
    }
}
