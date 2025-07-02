using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using bibliotekaAdmin.klasy;

namespace BibliotekaUzytkownik
{
    public partial class Form1 : Form
    {
        private Biblioteka biblioteka;
        public Form1(Biblioteka biblioteka)
        {
            InitializeComponent();
            this.biblioteka = biblioteka;
        }
    
     private void Form1_Load(object sender, EventArgs e)
        {
            listaDostepnychKsiazek.DataSource = null;
            listaDostepnychKsiazek.DataSource = biblioteka.Ksiazki
    .Where(k => !k.CzyWypozyczona).OrderBy(k => k.Tytul)
    .ToList();

            listaCzytelnikow.DataSource = null;
            listaCzytelnikow.DataSource = biblioteka.Czytelnicy;

            var wypozyczoneZOsoba = biblioteka.Ksiazki
    .Where(k => k.CzyWypozyczona)
    .OrderBy(k => k.Tytul)
    .Select(k =>
    {
        var wyp = biblioteka.Wypozyczenia.FirstOrDefault(w => w.Ksiazka.Id == k.Id);
        var czytelnik = wyp != null ? biblioteka.Czytelnicy.FirstOrDefault(c => c.Id == wyp.Czytelnik.Id) : null;
        var czytelnikInfo = czytelnik != null ? $" ({czytelnik.Imie} {czytelnik.Nazwisko})" : "";
        var godzina = wyp != null ? wyp.DataWypozyczenia.ToString("HH:mm:ss") : "";
        return $"{k.Tytul} - {k.Autor}{czytelnikInfo} o godz.: {godzina}";
    })
    .ToList();

            listaWypozyczonychKsiazek.DataSource = wypozyczoneZOsoba;
        }

        private void buttonWypozyczKsiazke_Click(object sender, EventArgs e)
        {
            if (listaDostepnychKsiazek.SelectedItem is Ksiazka ksiazka &&
                listaCzytelnikow.SelectedItem is Czytelnik czytelnik)
            {
                ksiazka.CzyWypozyczona = true;
                ksiazka.WypozyczonaPrzez = $"{czytelnik.Imie} {czytelnik.Nazwisko}";

                biblioteka.Wypozyczenia.Add(new Wypozyczenie
                {
                    Ksiazka = ksiazka,
                    Czytelnik = czytelnik,
                    DataWypozyczenia = DateTime.Now
                });

                biblioteka.ZapiszDoPliku(Plik.SciezkaPlikuDanych);

                
                OdswiezDane();

                MessageBox.Show($"Wypożyczono książkę: {ksiazka.Tytul} czytelnikowi: {czytelnik.Imie} {czytelnik.Nazwisko}");
            }
            else
            {
                MessageBox.Show("Proszę wybrać książkę i użytkownika.");
            }
        }


        private void buttonZwrocKsiazke_Click(object sender, EventArgs e)
        {
            if (listaWypozyczonychKsiazek.SelectedItem is Ksiazka ksiazka)
            {
              
                ksiazka.CzyWypozyczona = false;
                ksiazka.WypozyczonaPrzez = null;

                var doUsuniecia = biblioteka.Wypozyczenia
                    .FirstOrDefault(w => w.Ksiazka == ksiazka);
                if (doUsuniecia != null)
                {
                    biblioteka.Wypozyczenia.Remove(doUsuniecia);
                }

               
                biblioteka.ZapiszDoPliku(Plik.SciezkaPlikuDanych);

                
                OdswiezDane();

                MessageBox.Show($"Zwrócono książkę: {ksiazka.Tytul}");
            }
            else
            {
                MessageBox.Show("Wybierz książkę do zwrotu z listy wypożyczonych.");
            }
        }

        private void OdswiezDane()
        {
            listaDostepnychKsiazek.DataSource = null;
            listaDostepnychKsiazek.DataSource = biblioteka.Ksiazki
                .Where(k => !k.CzyWypozyczona).OrderBy(k => k.Tytul)
                .ToList();

            listaWypozyczonychKsiazek.DataSource = null;
            listaWypozyczonychKsiazek.DataSource = biblioteka.Ksiazki
        .Where(k => k.CzyWypozyczona)
        .OrderBy(k => k.Tytul)
        .Select(k =>
        {
            var wyp = biblioteka.Wypozyczenia.FirstOrDefault(w => w.Ksiazka.Id == k.Id);
            var czytelnik = wyp != null ? biblioteka.Czytelnicy.FirstOrDefault(c => c.Id == wyp.Czytelnik.Id) : null;
            var czytelnikInfo = czytelnik != null ? $" ({czytelnik.Imie} {czytelnik.Nazwisko})" : "";
            var godzina = wyp != null ? wyp.DataWypozyczenia.ToString("HH:mm:ss") : "";
            return $"{k.Tytul} - {k.Autor}{czytelnikInfo} o godz.: {godzina}";
        })
        .ToList();

            listaCzytelnikow.DataSource = null;
            listaCzytelnikow.DataSource = biblioteka.Czytelnicy;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            biblioteka = Biblioteka.WczytajZPliku(Plik.SciezkaPlikuDanych);


            OdswiezDane();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    } 

}
