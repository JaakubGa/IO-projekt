using System;
using System.Windows.Forms;
using wypozyczalnia_produkcja.Models;
using wypozyczalnia_produkcja.Params;

//sabina
namespace wypozyczalnia_produkcja.Pages
{
    public partial class StronaPrzedmiotu : Form
    {
        //private
        private Sprzet przedmiot;

        //CTOR
        public StronaPrzedmiotu()
        {
            InitializeComponent();
        }
        public StronaPrzedmiotu(int id)
        {
            InitializeComponent();
            przedmiot = new Sprzet(id);
        }

        //metody
        private void StronaPrzedmiotu_Load(object sender, EventArgs e)
        {
            //uzupełnienei strony danymi
            this.Text = przedmiot.Nazwa;
            this.labelNazwaPrzedmiotu.Text = $"{przedmiot.Kategoria} -> {przedmiot.Nazwa}";
            this.labelCena.Text = $"{przedmiot.Cena:c}";
            this.labelNickWlasciciela.Text = przedmiot.Uzytkownik.Nick;
            this.labelImieNazwisko.Text = $"{ przedmiot.Uzytkownik.Imie} {przedmiot.Uzytkownik.Nazwisko}";
            this.labelTelefon.Text = $"Tel. { przedmiot.Uzytkownik.Telefon}";
            this.labelEmail.Text = $"E-mail: { przedmiot.Uzytkownik.Email}";
            this.labelAdres.Text = przedmiot.Uzytkownik.Adres.ToString();
        }

        private void buttonCofnij_Click(object sender, EventArgs e)
        {
            Singleton.GetInstance().ListaKoszyk.Add(przedmiot.Id);
        }
    }
}
