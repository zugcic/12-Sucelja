using System;

namespace Vsite.CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Duljina d1 = new Duljina(2);
                Duljina d2 = new Duljina(1);

                // TODO: Dopuniti strukturu Duljina tako da implementira sučelje IComparable i napisati kod za metodu CompareTo


                // TODO: Dodati naredbu koja će usporediti duljine d1 i d2 te ispisati koja je veća


                // TODO: Dodati naredbu koja će usporediti d1 sa stringom "pero". Provjeriti da li prevoditelj javlja pogrešku te ako nema pogreške, pokrenut program.


                // TODO: Promijeniti implementaciju sučelja IComparable tako da prevoditelj javi pogrešku na usporedbu strukture Duljina i stringa. Provjeriti javlja li prevoditelj pogrešku.


                // TODO: Dopuniti strukturu Duljina tako da implementira i sučelje IComparable<Duljina>. Provjeriti javlja li prevoditelj pogrešku.



            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }


            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey();
        }
    }
}
