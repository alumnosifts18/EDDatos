/*Tarea 1: Crea un programa que pida al usuario su identificador y su contraseña (ambos
numéricos), y no le permita seguir hasta que introduzca como identificador "1234" y como
contraseña "1111".

using System;

namespace Tarea_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int identificador = 0;
            int contrasena = 0;

            do
            {
                Console.WriteLine("Ingrese ID: ");
                identificador = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("Ingrese contraseña: ");
                contrasena = Convert.ToInt16(Console.ReadLine());
            } while (identificador != 1234 && contrasena != 1111);
        }
    }
}


Tarea 2: Crea un programa calcule cuantas cifras tiene un número entero positivo (pista: se
puede hacer dividiendo varias veces entre 10).

using System;

namespace Tarea_3
{
    class Program
    {
        static void Main(string[] args)
        {
            String numero = "";

            Console.WriteLine("Ingrese número: ");
            numero = Console.ReadLine();

            Console.WriteLine("El número tiene: " + numero.Length + " cifras.");
        }
    }
}

Tarea 3: Crea un programa que muestre la tabla de multiplicar del 9.

using System;

namespace Tarea_3
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine(9 + "x" + i + " = " + i * 9);
            }
        }
    }
}

Tarea 4: Crea un programa que contenga un bucle sin fin que muestre los números enteros
positivos a partir del uno.

using System;

namespace Tarea_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 1;
            for ( ; ; )
            {
                Console.WriteLine(numero);
                numero++;
            }
        }
    }
}


Tarea 5: Crea un programa que contenga un bucle sin fin que escriba "Hola " en pantalla, sin
avanzar de línea.

using System;

namespace Tarea_3
{
    class Program
    {
        static void Main(string[] args)
        {
            String hola = "Hola";
            for ( ; ; )
            {
                Console.Write(hola);
            }
        }
    }
}

Tarea 6: ¿Cuál sería el resultado de las siguientes operaciones? a=5; b=++a; c=a++; b=b*5;
a=a*2; Crea un programa que lo resuelva.

using System;

namespace Tarea_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            Console.WriteLine("a=5: " + a);
            int b = ++a;
            Console.WriteLine("b=++a: " + b);
            int c = a++;
            Console.WriteLine("c=a++: " + c);
            Console.WriteLine("b=b*5: " + (b*=5));
            Console.WriteLine("a = a * 2: " + (a*=2));
        }
    }
}

Tarea 7: ¿Cuál sería el resultado de las siguientes operaciones? a=5; b=a+2; b-=3; c=-3; c*=2;
++c; a*=b; Crea un programa que te lo muestre.

using System;

namespace Tarea_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            Console.WriteLine("a=5: " + a);
            int b = a + 2;
            Console.WriteLine("b=a+2: " + b);
            Console.WriteLine("b-=3: " + (b-=3));
            int c = -3;
            Console.WriteLine("c=-3: " + c);
            Console.WriteLine("c*=2: " + (c*=2));
            Console.WriteLine("++c: " + ++c);
            Console.WriteLine("a*=b: " + (a*=b)); 

        }
    }
}

Tarea 8: Crea un programa que pida una letra al usuario y diga si se trata de una vocal.

using System;

namespace Tarea_3
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo letra = Console.ReadKey();
            Console.WriteLine("Ingrese una letra: ");

            if (letra.Key == ConsoleKey.A || letra.Key == ConsoleKey.E || letra.Key == ConsoleKey.I || letra.Key == ConsoleKey.O || letra.Key == ConsoleKey.U)
            {
                Console.WriteLine("Es vocal");
            }
            else
            {
                Console.WriteLine("No es vocal");
            }
        }
    }
}

Tarea 9: Crear un programa que pida al usuario un nombre y una contraseña.
La contraseña se debe introducir dos veces. Si las dos contraseñas no son iguales,
se avisará al usuario y se le volverán a pedir las dos contraseñas.

using System;

namespace Tarea_3
{
    class Program
    {
        static void Main(string[] args)
        {
            String name = "";
            String pass1 = "0";
            String pass2 = "1";

            while (pass1 != pass2)
            {
                Console.WriteLine("Ingrese Nombre: ");
                name = Console.ReadLine();

                Console.WriteLine("Ingrese Password: ");
                pass1 = Console.ReadLine();

                Console.WriteLine("Reingrese Password: ");
                pass2 = Console.ReadLine();

                if (pass1 != pass2)
                {
                    Console.WriteLine("Se debe ingresar los datos nuevamente");
                }
            }
        }
    }
}

Tarea 10: Crear un programa que pida al usuario su nombre, y le diga "Hola" si
se llama "Martín", o bien le diga "No te conozco" si teclea otro nombre.

using System;

namespace Tarea_3
{
    class Program
    {
        static void Main(string[] args)
        {
            String name = "";
            Console.WriteLine("Ingrese Nombre: ");
            name = Console.ReadLine();

            if (name != "Martín")
            {
                Console.WriteLine("No te conozco");
            }
            else
            {
                Console.WriteLine("Hola");
            }
        }
    }
}
 
 */


