using System;
using System.Windows.Forms;
using wypozyczalnia_produkcja.Models;

//sabina
namespace wypozyczalnia_produkcja.Pages
{
    public partial class StronaPrzedmiotu : Form
    {
        public StronaPrzedmiotu(int id)
        {
            Sprzet przedmiot = new Sprzet(id);
            InitializeComponent(przedmiot);
        }

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
