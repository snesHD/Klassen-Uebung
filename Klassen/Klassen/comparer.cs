using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace Klassen
{
    class comparer : IComparer
    {
        public int Compare(object x, object y)
        {
            return (new CaseInsensitiveComparer()).Compare(((Person)x).Name, ((Person)y).Nachname);
        }
    }
}
