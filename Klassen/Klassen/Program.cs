﻿using System;
using System.IO;

namespace Klassen
{
    class Program
    {
        static void Main(string[] args)
        {
            Person schueler1 = new Person("Enes", "Ünsal", Convert.ToDateTime("22 06 2002"));
            Person schueler2 = new Person("Yannik", "Hoffmann", Convert.ToDateTime("19 06 2002"));
            Person schueler3 = new Person("Julian", "Rütter", Convert.ToDateTime("27 09 2001"));
            Person schueler4 = new Person("Andre", "Kommerscheid", Convert.ToDateTime("12 03 1999"));
            Person schueler5 = new Person("Max", "Dissel", Convert.ToDateTime("11 09 2001"));
            //Console.WriteLine(schueler1.Name + " " + schueler1.Nachname + "geboren am" + schueler1.Geburtsdatum.ToString("dd/MM/yyyy"));

            Person[] liste = {schueler1, schueler2, schueler3, schueler4, schueler5};

            foreach (Person i in liste)
            {
                Console.WriteLine(schueler.Name + " " + schueler1.Nachname + "geboren am" + schueler1.Geburtsdatum.ToString("dd/MM/yyyy"));
            }


        }
    }
}