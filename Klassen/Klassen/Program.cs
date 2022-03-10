using System;
using System.IO;
using System.Collections;   

namespace Klassen
{
    class Program
    {


        Person[] schuelerliste = { new Person("Enes", "Ünsal", Convert.ToDateTime("22 06 2002")), new Person("Yannik", "Hoffmann", Convert.ToDateTime("19 06 2002")) };

        static void Main(string[] args)
        {

            Program klassen = new Program();
            
            /* schueler1 = new Person("Enes", "Ünsal", Convert.ToDateTime("22 06 2002"));
            Person schueler2 = new Person("Yannik", "Hoffmann", Convert.ToDateTime("19 06 2002"));
            Person schueler3 = new Person("Julian", "Rütter", Convert.ToDateTime("27 09 2001"));
            Person schueler4 = new Person("Andre", "Kommerscheid", Convert.ToDateTime("12 03 1999"));
            Person schueler5 = new Person("Max", "Dissel", Convert.ToDateTime("11 09 2001"));*/

            /*schuelerliste[0] = schueler1;
            schuelerliste[1] = schueler2;*/
            Console.WriteLine("Vorname \tNachname\t Geburtsdatum");
            klassen.sortieren();




        }


            
        public void sortieren()
        {
            Array.Sort(schuelerliste, new comparer());

            foreach (Person schueler in schuelerliste)
            {

                Console.WriteLine(schueler.Name + "\t\t" + schueler.Nachname + "\t" + schueler.Geburtsdatum);
               
            }
        }
    }
}
