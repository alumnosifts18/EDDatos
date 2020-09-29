using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea5
{
    class Program
    {
        public static int Signo(float numer = 0)//static para llamar la funcion sin instanciar
        {
            int cambio = 0;
            if (numer <= -1)
                cambio = -1;
            else if (numer >= 1)
                cambio = 1;
            return cambio;

        }

        static void Main(string[] args)
        {
            //Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Green;
            
            Console.SetWindowPosition(0, 0);
            Program variable = new Program();// para instanciar
            Console.WriteLine("Introduce un numero real");
            float numero= float.Parse(Console.ReadLine());
            //variable.Signo(numero);
            Console.WriteLine(Signo(numero));
            Console.Beep(800,500);
            Console.Beep(500,500);
            Console.Beep(800,1000);
            Console.ReadLine();

            

        }
    }
}
