using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wypozyczalnia_produkcja.Pages
{
    public partial class Koszyk : Form
    {
        public Koszyk()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Text = "Musisz potwierdzić zakup";
            MessageBox.Show("Na pewno wybrałeś wszystkie produkty?", "Potwierdzenie", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            button3.Text = "Finalizuj zakupy";

        }
    }

}
