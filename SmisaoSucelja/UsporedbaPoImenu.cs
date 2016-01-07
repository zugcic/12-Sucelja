using System.Collections.Generic;

namespace Vsite.CSharp
{
    class UsporedbaPoImenu : IComparer<Osoba>
    {
        #region IComparer Members

        public int Compare(Osoba a, Osoba b)
        {
            return a.Ime.CompareTo(b.Ime);
        }

        #endregion
    }
}
