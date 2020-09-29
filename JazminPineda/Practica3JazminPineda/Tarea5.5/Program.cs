using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea5._5
{
    class Program
    {
        public static int calcula( int numer1, string operador, int numer2) 
        {
            int resultado = 0;
            if (operador == "+")
                resultado = numer1 + numer2;
            if (operador == "-")
                resultado = numer1 - numer2;
            if (operador == "*")
                resultado = numer1 * numer2;
            if (operador == "/")
                resultado = numer1 / numer2;
            return resultado;
            
        }
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Escribe primer numero");
            int numero1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Escribe que operacion desea +, -, *, o / ");
            string operador = Console.ReadLine();
            Console.WriteLine("Escribe segundo numero");
            int numero2 = int.Parse(Console.ReadLine());
            Console.WriteLine("El resultado es {0}", calcula(numero1, operador, numero2));
            Console.Beep(1005, 1214);
            Console.ReadLine();

        }
    }
}
