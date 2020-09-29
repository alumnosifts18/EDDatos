using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea5._3
{
    class Program
    {
        public static bool EsPrimo(int numer) 
        {
            bool Resultado = false;
            if (numer % 2 == 0)
                Resultado = true;
            return Resultado;
            
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Escribe un nùmero ");
            int numer = int.Parse(Console.ReadLine());
            Console.WriteLine(EsPrimo(numer));
            Console.Beep(500, 500);


        }
    }
}
