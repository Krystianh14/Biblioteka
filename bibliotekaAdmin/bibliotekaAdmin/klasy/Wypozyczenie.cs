
using System;

namespace bibliotekaAdmin.klasy
{
    public class Wypozyczenie
    {
        public int Id { get; set; }
        public Ksiazka Ksiazka { get; set; }
        public Czytelnik Czytelnik { get; set; }
        public DateTime DataWypozyczenia { get; set; } = DateTime.Now;
        public DateTime? DataZwrotu { get; set; }
    }
}
