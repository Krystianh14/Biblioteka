

using System.Collections.Generic;

namespace bibliotekaAdmin.klasy
{
    public class Czytelnik : Osoba
    {

        public int Id { get; set; }
        public List<Wypozyczenie> HistoriaWypozyczen { get; set; } = new List<Wypozyczenie>();
    
    public override string ToString()
        {
            return $"{Nazwisko} {Imie} ";
        }

    }
}
