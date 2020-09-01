using System;
using System.Collections.Generic;
using System.Text;

namespace zaliczenie
{
    public class Kierowca : Osoba
    {
        public Kierowca(string imie, string nazwisko, string dataUrodzenia,bool czyJedzie) : base(imie, nazwisko, dataUrodzenia, czyJedzie)
        {
        }
        public string nrPrawaJazdy;
    }
}
