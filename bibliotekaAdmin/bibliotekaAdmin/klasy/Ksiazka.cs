
namespace bibliotekaAdmin.klasy
{
    public class Ksiazka
    {
     
        public int Id { get;  set; }
        public string Tytul { get; set; }
        public string Autor { get; set; }
        public bool CzyWypozyczona { get; set; } = false;

        public string WypozyczonaPrzez { get; set; } = null;


        public override string ToString()
        {
            return $"{Tytul} - {Autor}";
        }
    }
}
