using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z2
{
    class CompareTermin : IComparer<Tovar>
    {
        public int Compare(Tovar a, Tovar b)
        {
            return a.Termin.CompareTo(b.Termin);
        }
    }
}
