using System;
using System.Windows.Forms;
using wypozyczalnia_produkcja.Models;
using wypozyczalnia_produkcja.Params;
using wypozyczalnia.DSanak;
using wypozyczalnia.DSanak.Rejestracja;


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
            Singleton.GetInstance().logowanie.Show();
        }

        private void buttonRejestracja_Click(object sender, EventArgs e)
        {
            Singleton.GetInstance().rejestracja.Show();
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
    }
}
