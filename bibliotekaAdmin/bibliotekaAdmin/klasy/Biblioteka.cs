
using System.Linq;
using System.Collections.Generic;
using System;
using Newtonsoft.Json;
using System.IO;

namespace bibliotekaAdmin.klasy
{
    public class Biblioteka
    {
        public List<Ksiazka> Ksiazki { get; set; } = new List<Ksiazka>();
        public List<Czytelnik> Czytelnicy { get; set; } = new List<Czytelnik>();
        public List<Wypozyczenie> Wypozyczenia { get; set; } = new List<Wypozyczenie>();

        public void DodajKsiazke(Ksiazka k) => Ksiazki.Add(k);
        public void DodajCzytelnika(Czytelnik c) => Czytelnicy.Add(c);

        public void WypozyczKsiazke(int idKsiazki, int idCzytelnika)
        {
            var ksiazka = Ksiazki.FirstOrDefault(k => k.Id == idKsiazki && !k.CzyWypozyczona);
            var czytelnik = Czytelnicy.FirstOrDefault(c => c.Id == idCzytelnika);

            if (ksiazka != null && czytelnik != null)
            {
                ksiazka.CzyWypozyczona = true;
                var wyp = new Wypozyczenie
                {
                    Id = Wypozyczenia.Count + 1,
                    Ksiazka = ksiazka,
                    Czytelnik = czytelnik
                };
                Wypozyczenia.Add(wyp);
                czytelnik.HistoriaWypozyczen.Add(wyp);
            }
        }

        public void ZwrocKsiazke(int idKsiazki)
        {
            var wyp = Wypozyczenia.FirstOrDefault(w => w.Ksiazka.Id == idKsiazki && w.DataZwrotu == null);
            if (wyp != null)
            {
                wyp.DataZwrotu = DateTime.Now;
                wyp.Ksiazka.CzyWypozyczona = false;
            }
        }
        public void ZapiszDoPliku(string sciezka)
        {
            var json = JsonConvert.SerializeObject(this, Formatting.Indented);
            File.WriteAllText(sciezka, json);
        }

        public static Biblioteka WczytajZPliku(string sciezka)
        {
            if (!File.Exists(sciezka))
                return new Biblioteka();

            var json = File.ReadAllText(sciezka);
            return JsonConvert.DeserializeObject<Biblioteka>(json);
        }
    }
}
