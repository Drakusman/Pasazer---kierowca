using System;
using System.Collections.Generic;
using System.Text;

namespace zaliczenie
{
    public class Autobus
    {
        public static int licznik;
        public int numerTablicy;
        public int maxPasazerow;
        public Kierowca kierowca=null;
        public bool czyKierowca = false;
        public List<Pasazer> pasazerownie = new List<Pasazer>();
        public Autobus(int maxPasazerow)
        {
            licznik++;
            numerTablicy= licznik;
            this.maxPasazerow = maxPasazerow;
        }
        public void dodajKierowce(Kierowca kierowca)
        {
            if(czyKierowca==false)
            {
                this.kierowca = kierowca;
                czyKierowca = true;
            }
            else
            {
                Console.WriteLine("Ten autobus ma juz kierowce");
            }
        }
        public void dodajPasazera(Pasazer pasazer)
        {
            if(maxPasazerow>pasazerownie.Count)
            {
                this.pasazerownie.Add(pasazer);
            }
            else
            {
                Console.WriteLine("Przepraszamy nie ma juz miejsc");
            }
        }
        public string obliczWiek()
        {
            var ilosc = 0;
            for (int i=0;i<pasazerownie.Count;i++)
            {
                ilosc++;
            }
            double temp = 0D;
            for (int i = 0; i < ilosc; i++)
            {
                temp += pasazerownie[i].dataUrodzenia.Ticks / (double)ilosc;
            }
            var average = new DateTime((long)temp);
            return average.ToString();
        }
    }
}
