using System;
using System.Collections.Generic;
using System.Text;

namespace zaliczenie
{
    public class Osoba
    {
        public string imie;
        public string nazwisko;
        public DateTime dataUrodzenia;
        public bool czyJedzie=false;

        public Osoba(string imie, string nazwisko, string dataUrodzenia, bool czyJedzie)
        {

            this.imie = imie;
            this.nazwisko = nazwisko;
            this.dataUrodzenia = DateTime.Parse(dataUrodzenia);
            this.czyJedzie = czyJedzie;

        }
        

    }
}
