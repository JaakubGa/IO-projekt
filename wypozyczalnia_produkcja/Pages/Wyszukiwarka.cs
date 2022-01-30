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
        public LogowanieFormularz logowanie = new LogowanieFormularz();
        public Rejestracja rejestracja = new Rejestracja();
        
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
            Singleton.UzupelnijListeWyszukiwania();
            listBoxWyszukiwanie.Items.Clear();
            foreach (var idSprzetu in Singleton.GetInstance().ListaWyszukiwania)
            {
                Sprzet sprzet = new Sprzet(idSprzetu);
                listBoxWyszukiwanie.Items.Add(sprzet.ToString());
            }
        }

        private void buttonProfilUzytkownika_Click(object sender, EventArgs e)
        {
            ProfilUzytkownika profil = new ProfilUzytkownika();
            profil.Show();
        }

        private void buttonLogowanie_Click(object sender, EventArgs e)
        {
            logowanie.Show();
        }

        private void buttonRejestracja_Click(object sender, EventArgs e)
        {
            rejestracja.Show();
        }
    }
}
