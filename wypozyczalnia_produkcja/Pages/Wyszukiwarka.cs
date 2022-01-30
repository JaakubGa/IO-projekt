using System;
using System.Windows.Forms;
using wypozyczalnia_produkcja.Models;
using wypozyczalnia_produkcja.Params;

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

        }

        private void buttonWyszukaj_Click(object sender, EventArgs e)
        {
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
    }
}
