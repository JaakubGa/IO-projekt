using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using wypozyczalnia_produkcja.Sabina.Params;

namespace wypozyczalnia_produkcja.Sabina.Pages
{
    public partial class StronaPrzedmiotu : Form
    {
        public StronaPrzedmiotu()
        {
            InitializeComponent();
        }

        private void StronaPrzedmiotu_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            AktywneFormularzePars.Wyszukiwarka.Show();
            this.Close();
        }
    }
}
