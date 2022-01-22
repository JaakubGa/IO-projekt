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
using wypozyczalnia_produkcja.Sabina.Params;

namespace wypozyczalnia_produkcja.Sabina.Pages
{
    public partial class StronaPrzedmiotu : Form
    {
        public StronaPrzedmiotu(int id)
        {
            PrzedmiotModel przedmiot = new PrzedmiotModel(id);
            InitializeComponent(/*przedmiot*/);
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
