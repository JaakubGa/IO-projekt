using System;
using System.Windows.Forms;
using wypozyczalnia_produkcja.Pages;
using wypozyczalnia_produkcja.Params;

namespace wypozyczalnia_produkcja
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Singleton.GetInstance().ButtonsIsVisible = true;
            Singleton.UzupelnijListeKategori();

            Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            Wyszukiwarka wyszukiwarka = new Wyszukiwarka();
            Singleton.GetInstance().Wyszukiwarka = wyszukiwarka;
            Application.Run(wyszukiwarka);

        }
    }
}
