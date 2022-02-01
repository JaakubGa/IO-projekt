using System;
using System.Windows.Forms;
using wypozyczalnia_produkcja.Models;

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
            przedmiot = new Sprzet(id);
        }

        //metody
        private void StronaPrzedmiotu_Load(object sender, EventArgs e)
        {

        }

        private void buttonCofnij_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }
    }
}
