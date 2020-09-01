using System;

namespace zaliczenie
{
    class Program
    {
        static void Main(string[] args)
        {
            Pasazer a = new Pasazer("sdasd", "sad", "10-10-1996", false,"warszawa");
            Pasazer b = new Pasazer("dasdsa", "dasd", "10-10-1997", false,"warszawa");
            Pasazer c = new Pasazer("asd", "kowasdaalik", "10-10-1998", false,"poznan");
            Kierowca g = new Kierowca("dasdsa", "sadasd", "10-12-1995", false);
            Kierowca h = new Kierowca("dasdsa", "sadasd", "10-12-1995", false);
            
            Autobus d = new Autobus(5);
            Autobus e = new Autobus(6);
            d.dodajKierowce(g);
            d.dodajKierowce(h);

            Console.WriteLine(d.numerTablicy);
            Console.WriteLine(e.numerTablicy);
            d.dodajPasazera(a);
            d.dodajPasazera(b);
            d.dodajPasazera(c);

            Console.WriteLine(d.obliczWiek());
        }
    }
}
