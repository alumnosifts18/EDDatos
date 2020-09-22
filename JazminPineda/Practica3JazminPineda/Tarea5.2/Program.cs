using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea5._2
{
    class Program
    {
        public static int Menor(int num1, int numer2)
        {
            int otro = num1;
            if (num1 < numer2)
                otro = num1;
            else if (numer2 < num1)
                otro = numer2;

            return otro;
        }
        
                static void Main(string[] args)
        {
            Console.WriteLine("Escribe primer numero entero");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Escribe segundo numero entero");
            int numer2 = int.Parse(Console.ReadLine());
            Console.WriteLine(Menor(num1, numer2));

            Console.Beep(666, 666);
            Console.ReadLine();
        }
    }
}
