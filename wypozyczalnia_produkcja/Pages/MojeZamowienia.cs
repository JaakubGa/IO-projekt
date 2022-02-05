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
    public partial class MojeZamowienia : Form
    {
        public MojeZamowienia()
        {
            InitializeComponent();
            WyswietlListeZamowien();
        }
    }
}
