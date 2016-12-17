using System;

namespace Vsite.CSharp
{
    public class ImplementacijaIstoimenihČlanovaIzRazličitihSučelja
    {
        public interface ISkokUvis
        {
            void Skoči();
        }

        public interface ISkokUdalj
        {
            void Skoči();
        }

        // TODO: Definirati da klasa Desetobojac implementira sučelja ISkokUvis i ISkokUDalj
        // TODO: Dodati implementacije metode Skoči() sučelja ISkokUVis i ISkokUDalj tako da prva ispiše "Hop u vis", a druga "Hop u dalj"
        public class Desetobojac
        {
        }

        static void Main(string[] args)
        {
            Desetobojac db = new Desetobojac();

            // TODO: Napisati naredbu koja će pozvati metodu Skoči() iz sučelja SkokUVis te naredbu koja će pozvati metodu Skoči() iz sučelja SkokUDalj. Pokrenuti program i provjeriti ispise.


            // TODO: U klasu Desetobojac dodati treću ("nezavisnu") metodu Skoči() koja će ispisati samo "Hop".


            // TODO: napisati naredbu koja će pozvati "nezavisnu" metodu. Pokrenuti program i provjeriti ispise.


            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey();
        }
    }
}
