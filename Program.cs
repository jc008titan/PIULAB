using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmacie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Farmacie.Farmacie farmacie = new Farmacie.Farmacie();
            

            string optiune;
            do
            {
                Console.WriteLine("C. Citire medicamente de la tastatura");
                Console.WriteLine("A. Afisarea medicamentelor");
                Console.WriteLine("K. Cautare dupa numele medicamentului");
                Console.WriteLine("X. Inchidere program");

                Console.WriteLine("Alegeti o optiune");
                optiune = Console.ReadLine();

                switch (optiune.ToUpper())
                {
                    case "C":
                        break;
                    case "A":
                        break;
                    case "K":
                        break;
                    case "X":
                        return;
                    default:
                        break;
                }
            } while (optiune.ToUpper() != "X");

            Console.ReadKey();
        }

    }
}