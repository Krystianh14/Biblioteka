using bibliotekaAdmin.klasy;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bibliotekaAdmin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        private Biblioteka biblioteka = new Biblioteka();
        private void OdswiezListeKsiazek()
        {
            listaKsiazek.DataSource = null;
            listaKsiazek.DataSource = biblioteka.Ksiazki
                .OrderBy(k => k.Tytul)
                .ToList();

        }
        private void OdswiezListeCzytelnikow()
        {
            listaCzytelnikow.DataSource = null;
            listaCzytelnikow.DataSource = biblioteka.Czytelnicy
               .OrderBy(c => c.Nazwisko)
               .ThenBy(c => c.Imie)
               .ToList();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            biblioteka = Biblioteka.WczytajZPliku(Plik.SciezkaPlikuDanych);
            OdswiezListeKsiazek();
            OdswiezListeCzytelnikow();

        }
      

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonDodajKsiazke_Click(object sender, EventArgs e)
        {
            var ksiazka = new Ksiazka
            {
                Id = biblioteka.Ksiazki.Count + 1, 
                Tytul = textBoxTytul.Text,
                Autor = textBoxAutor.Text
            };
            biblioteka.DodajKsiazke(ksiazka);
            biblioteka.ZapiszDoPliku(Plik.SciezkaPlikuDanych);
            MessageBox.Show("Dodano książkę: " + ksiazka.Tytul + " autorstwa " + ksiazka.Autor);
            OdswiezListeKsiazek();
            textBoxTytul.Text = string.Empty;
            textBoxAutor.Text = string.Empty;
        }

        private void buttonDodajCzytelnika_Click(object sender, EventArgs e)
        {
            var czytelnik = new Czytelnik
            {
                Id = biblioteka.Czytelnicy.Count + 1,
                Imie = textBoxImie.Text,
                Nazwisko = textBoxNazwisko.Text
            };
            biblioteka.DodajCzytelnika(czytelnik);
            biblioteka.ZapiszDoPliku(Plik.SciezkaPlikuDanych);
            MessageBox.Show("Dodano czytelnika: " + czytelnik.Imie + " " + czytelnik.Nazwisko);
            OdswiezListeCzytelnikow();
            textBoxImie.Text = string.Empty;
            textBoxNazwisko.Text = string.Empty;
        }

        private void listaKsiazek_SelectedIndexChanged(object sender, EventArgs e)
        {
            //wyswietlaj dodane ksiazki

        }

        private void buttonUsunKsiazke_Click(object sender, EventArgs e)
        {

            if (listaKsiazek.SelectedItem is Ksiazka wybranaKsiazka)
            {
                
                biblioteka.Ksiazki.Remove(wybranaKsiazka);

               
                OdswiezListeKsiazek();
            }
            else
            {
                MessageBox.Show("Wybierz książkę do usunięcia.");
            }
        }

        private void buttonUsunCzytelnika_Click(object sender, EventArgs e)
        {
            
            if (listaCzytelnikow.SelectedItem is Czytelnik wybranyCzytelnik)
            {
                
                biblioteka.Czytelnicy.Remove(wybranyCzytelnik);

                
                OdswiezListeCzytelnikow();
            }
            else
            {
                MessageBox.Show("Wybierz czytelnika do usunięcia.");
            }
        }
    }
}
