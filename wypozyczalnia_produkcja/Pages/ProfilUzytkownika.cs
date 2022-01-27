using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using wypozyczalnia_produkcja.Sabina.Models;

namespace wypozyczalnia_produkcja.Pages
{
    public partial class ProfilUzytkownika : Form
    {
        public ProfilUzytkownika()
        {
            InitializeComponent();
        }

        private void ProfilUzytkownika_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Uzytkownik user = new Uzytkownik(1);
            //user.Adres.
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
