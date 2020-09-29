using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea5._7
{
    class Program
    {
        public static void Triangulo(string letra, int numero)
        {
            for (int ancho = numero; ancho >= 1; ancho--)
            {
                for (int conta = 0; conta < ancho; conta++)
                    Console.Write(letra);
                Console.WriteLine(" ");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Escribe una letra ");
            string letra = Console.ReadLine();
            Console.WriteLine("Escribe una numero ");
            int numero = int.Parse(Console.ReadLine());
            Triangulo(letra, numero);
            Console.ReadLine();

        }
    }
}
