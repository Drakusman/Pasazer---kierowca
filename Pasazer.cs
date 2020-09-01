using System;
using System.Collections.Generic;
using System.Text;

namespace zaliczenie
{
    public class Pasazer : Osoba
    {
        public string informacje;
        public Pasazer(string imie, string nazwisko, string dataUrodzenia, bool czyJedzie, string informacje) : base(imie, nazwisko, dataUrodzenia, czyJedzie)
        {
            this.informacje = informacje;
        }
        public void jedzie()
        {
            this.czyJedzie = true;
        }
        public void niejedzie()
        {
            this.czyJedzie = false;
        }
    }
}
