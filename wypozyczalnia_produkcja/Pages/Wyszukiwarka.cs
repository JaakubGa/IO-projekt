using System;
using System.Windows.Forms;

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

        private void button1_Click(object sender, EventArgs e)
        {
            StronaPrzedmiotu przedmiot = new StronaPrzedmiotu(6);
            przedmiot.Show();
        }

        private void buttonProfilUzytkownika_Click(object sender, EventArgs e)
        {
            ProfilUzytkownika profil = new ProfilUzytkownika();
            profil.Show();
        }
    }
}
