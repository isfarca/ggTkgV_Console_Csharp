using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ggTkgV
{
    class Program
    {
        static void Main(string[] args)
        {
            string Eingabe;
            int Zahl1;
            int Zahl2;

            int ggT = 0;
            int kgV = 0;

            Console.Write("Zahl 1: ");
            Eingabe = Console.ReadLine();
            Zahl1 = Convert.ToInt32(Eingabe);

            Console.Write("Zahl 2: ");
            Eingabe = Console.ReadLine();
            Zahl2 = Convert.ToInt32(Eingabe);

            if (Zahl1 < Zahl2)
                Tausche(ref Zahl1, ref Zahl2);

            ggT = BerechneggT(Zahl1, Zahl2);
            kgV = Zahl1 * Zahl2 / ggT;

            Console.WriteLine("\nggT: {0} \nkgV: {1}", ggT, kgV);
            Console.ReadKey();
        }

        public static void Tausche<T>(ref T Variable1, ref T Variable2)
        {
            T Temporaer = Variable1;

            Variable1 = Variable2;
            Variable2 = Temporaer;
        }

        public static int BerechneggT(int Zahl1, int Zahl2)
        {
            int ggTZwischenergebnis;

            while (Zahl1 % Zahl2 != 0)
            {
                ggTZwischenergebnis = Zahl1 % Zahl2;

                Zahl1 = Zahl2;
                Zahl2 = ggTZwischenergebnis;
            }

            return Zahl2;
        }
    }
}
