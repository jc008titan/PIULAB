using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmacie
{
    internal class Program
    {
        public static Medicament[] medicamente = new Medicament[] { };
        static void Main(string[] args)
        { 
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
                        Medicament m = CitireMedicament();
                        Array.Resize(ref medicamente, medicamente.Length + 1);
                        medicamente[medicamente.Length-1] = m;
                        break;
                    case "A":
                        AfisareMedicamente();
                        break;
                    case "K":
                        CautareMedicamentNume();
                        break;
                    case "X":
                        return;
                    default:
                        Console.WriteLine("Optiune inexistenta");
                        break;
                }
            } while (optiune.ToUpper() != "X");

            Console.ReadKey();
        }
        public static Medicament CitireMedicament()
        {
            Console.WriteLine("Introduceti numele");
            string nume = Console.ReadLine().Trim();

            Console.WriteLine("Introduceti data expirarii");
            string data_expirare = Console.ReadLine().Trim();

            Console.WriteLine("Introduceti pretul");
            double pret = 0;
            double.TryParse(Console.ReadLine(), out pret);

            Console.WriteLine("Introduceti cantitatea");
            int cantitate = 0;
            int.TryParse(Console.ReadLine(),out cantitate);
            Medicament medicament = new Medicament(nume,data_expirare,pret,cantitate);

            return medicament;

        }
        public static void AfisareMedicamente()
        {
            if (medicamente.Length == 0)
            {
                Console.WriteLine("Nu exista medicamente");
            }
            else
            {
                for (int i = 0; i < medicamente.Length; i++)
                {
                    Console.WriteLine($"Medicamentul numarul {i}:\n\tnume: {medicamente[i].nume}\n\tdata expirare: {medicamente[i].data_expirare}" +
                        $"\n\tpret: {medicamente[i].pret}\n\tcantitate: {medicamente[i].cantitate}\n");
                }
            }

        }
        public static void CautareMedicamentNume()
        {
            Console.WriteLine("Introduceti numele medicamentului cautat:");
            string s = Console.ReadLine().Trim();
            bool gasit=false;
            foreach (var m in medicamente) 
            {
                if (m.nume.ToUpper().Contains(s.ToUpper()))
                {
                    Console.WriteLine($"Medicamentul gasit:\n\tnume: {m.nume}\n\tdata expirare: {m.data_expirare}" +
                        $"\n\tpret: {m.pret}\n\tcantitate: {m.cantitate}\n");
                    gasit = true;
                }
            }
            if (!gasit) Console.WriteLine($"Nu a fost gasit niciun medicament cu {s}\n");
        }

    }
}