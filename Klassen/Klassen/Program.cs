using System;
using System.IO;
using System.Collections;   

namespace Klassen
{
    class Program
    {
        
        Person[] schuelerliste = {  new Person("Enes",      "Ünsal",        Convert.ToDateTime("22 06 2002")),
                                    new Person("Yannik",    "Hoffmann",     Convert.ToDateTime("19 06 2002")),
                                    new Person("Julian",    "Rütter",       Convert.ToDateTime("27 09 2001")),
                                    new Person("Max",       "Dissel",       Convert.ToDateTime("11 09 2001")),
                                    new Person("Andre",     "Kommerscheid", Convert.ToDateTime("12 03 1999"))};

        static void Main(string[] args)
        {
            ConsoleKeyInfo wiederholen;
            do { 
            Program klassen = new Program();
            klassen.start();
            klassen.sortieren();
            klassen.ausgabe();
            Console.WriteLine("\nMöchten Sie eine andere Sortierung haben?\t[Y/N]");
            wiederholen = Console.ReadKey();
            Console.Clear();
            } while (wiederholen.Key == ConsoleKey.Y);
        }

        public void start()
        {
            Console.WriteLine("\nWie möchten Sie gerne die Schülerliste Sortiert haben:");
            Console.WriteLine("1| Vorname");
            Console.WriteLine("2| Nachname");
            Console.WriteLine("3| Geburtsdatum");
        }

        public void sortieren()
        {
            string sortierung ;
            do
            {
                sortierung = Console.ReadLine();
                if (string.IsNullOrEmpty(sortierung))
                {
                    Console.WriteLine("KEINE EINGABE\nBITTE GEBEN SIE EINE GÜLTIGE EINGABE");
                }
            } while (string.IsNullOrEmpty(sortierung));

            switch (Convert.ToInt32(sortierung))
            {
                case 1:
                    Array.Sort(schuelerliste, new Sortieren().Compare);
                    Console.WriteLine("\t\t SORTIERUNG VORNAME");
                    break;
                case 2:
                    Array.Sort(schuelerliste, new Sortieren().CompareNachname);
                    Console.WriteLine("\t\t SORTIERUNG NACHNAME");
                    break;
                case 3:
                    Array.Sort(schuelerliste, new Sortieren().CompareGeburtsdatum);
                    Console.WriteLine("\t\t SORTIERUNG GEBURTSDATUM");
                    break;
            }
        }

        public void ausgabe()
        {
            Console.WriteLine("-----------------------------------------------------");
            Console.Clear();
            foreach (Person schueler in schuelerliste)
            {
                Console.WriteLine("Vorname: \t"+ schueler.Name);
                Console.WriteLine("Nachname: \t"+ schueler.Nachname);
                Console.WriteLine("Geburtsdatum: \t"+ schueler.Geburtsdatum.ToString("dd/MM/yyyy"));
                Console.WriteLine("-----------------------------------------------------");
                
            }
           
        }
    }
}
