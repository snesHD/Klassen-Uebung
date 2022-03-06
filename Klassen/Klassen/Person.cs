using System;
using System.Collections.Generic;
using System.Text;

namespace Klassen
{
    class Person
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private string nachname;

        public string Nachname
        {
            get { return nachname; }
            set { nachname = value; }
        }

        private DateTime geburtsdatum;

        public DateTime Geburtsdatum
        {
            get { return geburtsdatum; }
            set { geburtsdatum = value; }
        }

        public Person(){}

        public Person(string name, string nachname, DateTime geburtsdatum)
        {
            this.name = name;
            this.nachname = nachname;
            this.geburtsdatum = geburtsdatum;
        }
    }
}
