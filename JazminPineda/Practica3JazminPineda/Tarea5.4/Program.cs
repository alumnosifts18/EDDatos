using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea5._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            for (int fila = 1; fila <= 7; fila++)  
            {
                for (int espacios = 7 - fila; espacios > 0; espacios--)
                    Console.WriteLine("  ");// En el primer bucle se inicializa en la posicion 1 recorre 6 veces
                //incrementand//
                for (int conta = 1; conta < (2 * fila); conta++)
                    Console.Write("*");
                
                Console.WriteLine("");
            }
            Console.ReadLine();
        }
    }
}
