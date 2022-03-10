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
            
            int sortierung = Convert.ToInt32(Console.ReadLine());
            switch (sortierung)
            {
                case 1:
                    Array.Sort(schuelerliste, new Sortieren().Compare);
                    break;
                case 2:
                    Array.Sort(schuelerliste, new Sortieren().CompareNachname);
                    break;
                case 3:
                    Array.Sort(schuelerliste, new Sortieren().CompareGeburtsdatum);
                    break;
                default:
                   //keine sortierung
                    break;
            }
        }

        public void ausgabe()
        {

            Console.WriteLine("\nVorname \tNachname\t Geburtsdatum");
            Console.WriteLine("---------------------------------------------");
            foreach (Person schueler in schuelerliste)
            {
                Console.WriteLine(schueler.Name + "\t" + schueler.Nachname + "\t" + schueler.Geburtsdatum.ToString("dd/mm/yyyy"));
            }
        }
    }
}
