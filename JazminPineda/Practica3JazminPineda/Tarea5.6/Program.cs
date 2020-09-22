using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea5._6
{
    class Program
    {
        public static int SumcaCifras(string cifra)
        {
            int suma_acum = 0;
            for (int pocision = 0; pocision < cifra.Length; pocision++)
            {
                suma_acum = int.Parse(cifra[pocision].ToString()) + suma_acum;
            }
                
            return suma_acum;
        }
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Escribe una cifra ");
            string cifra = Console.ReadLine();
            Console.WriteLine("La sumatoria de la cifra es {0}", SumcaCifras(cifra));
            Console.ReadLine();

        }
    }
}
