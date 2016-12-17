using System;

namespace Vsite.CSharp
{
    public class Osoba
    {
        public Osoba(string ime, DateTime datumRoðenja, string mjestoRoðenja)
        {
            Ime = ime;
            DatumRoðenja = datumRoðenja;
            MjestoRoðenja = mjestoRoðenja;
        }

        public override string ToString()
        {
            return string.Format("{0}, {1}, {2}", Ime, DatumRoðenja.ToShortDateString(), MjestoRoðenja);
        }

        public readonly string Ime;
        public readonly DateTime DatumRoðenja;
        public readonly string MjestoRoðenja;
    }
}
