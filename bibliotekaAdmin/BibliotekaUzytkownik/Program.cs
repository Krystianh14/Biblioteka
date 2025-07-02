using bibliotekaAdmin.klasy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BibliotekaUzytkownik
{
    internal static class Program
    {
        /// <summary>
        /// Główny punkt wejścia dla aplikacji.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Wczytaj bibliotekę z pliku
            Biblioteka biblioteka = Biblioteka.WczytajZPliku(Plik.SciezkaPlikuDanych);
            

            // Przekaż ją do formularza
            Application.Run(new Form1(biblioteka));
        }
    }
}
