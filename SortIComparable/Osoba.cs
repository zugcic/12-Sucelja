using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vsite.CSharp
{
    class Osoba
    {
        public Osoba(string prezime, string ime, DateTime datumRođenja)
        {
            Ime = ime;
            Prezime = prezime;
            DatumRođenja = datumRođenja;
        }

        public readonly string Prezime;
        public readonly string Ime;
        public readonly DateTime DatumRođenja;

        public override string ToString()
        {
            return string.Format("{0}, {1}, {2}", Prezime, Ime, DatumRođenja.ToShortDateString());
        }

    }
}
