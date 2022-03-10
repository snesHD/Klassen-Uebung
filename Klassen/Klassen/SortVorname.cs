using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace Klassen
{
    class SortVorname : IComparer
    {
        public int Compare(object x, object y)
        {
            return (new CaseInsensitiveComparer()).Compare(((Person)x).Name, ((Person)y).Name);

        }

        public int CompareNachname(object x, object y)
        {
            return (new CaseInsensitiveComparer()).Compare(((Person)x).Nachname, ((Person)y).Nachname);

        }
    }
}
