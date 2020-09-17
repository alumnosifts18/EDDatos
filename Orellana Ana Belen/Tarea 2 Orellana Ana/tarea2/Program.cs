/*

//Tarea 2: Crea un programa que diga el resultado de sumar 200 y 56.

using System;

namespace Ejercicios1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(200 + 56);
        }
    }
}


//Tarea 3: Haz un programa que calcule el producto de los números 13 y 12.

using System;

namespace Ejercicios1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(13 * 12);
        }
    }
}


//Tarea 4: Un programa que calcule la diferencia (resta) entre 321 y 213

using System;

namespace Ejercicios1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(312 - 213);
        }
    }
}


//Tarea 5: Calcular el resultado de (20+5) % 6

using System;

namespace Ejercicios1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine((20 + 5) % 6);
        }
    }
}


//Tarea 6: Crea un programa que calcule el producto de los números 12 y 102, usando variables. 

using System;

namespace Ejercicios1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 12;
            int num2 = 102;
            Console.WriteLine(num1 * num2);
        }
    }
}


//Tarea 7: Crea un programa que calcule la suma de 200 y 1111, usando variables.

using System;

namespace Ejercicios1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 200;
            int num2 = 1111;
            Console.WriteLine(num1 + num2);
        }
    }
}


//Tarea 8: Crea un programa que calcule el producto de los números 10 y 25, usando variables llamadas "numero1" y "numero2".

using System;

namespace Ejercicios1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero1 = 10;
            int numero2 = 25;
            Console.WriteLine(numero1 + numero2);
        }
    }
}


//Tarea 9: Crea un programa que calcule el producto de dos números introducidos por el usuario.

using System;

namespace Ejercicios1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese numero 1: ");
            String intro1 = Console.ReadLine();
            int num1 = Convert.ToInt16(intro1);

            Console.WriteLine("Ingrese numero 2: ");
            String intro2 = Console.ReadLine();
            int num2 = Convert.ToInt16(intro2);

            Console.WriteLine(num1 * num2);
        }
    }
}


//Tarea 10: Crea un programa que pida al usuario un número entero y diga si es par (pista: habrá que comprobar si el resto que se obtiene al dividir entre dos es cero: if (x % 2 == 0) …).

using System;

namespace Ejercicios1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un numero entero: ");
            String intro1 = Console.ReadLine();
            int num1 = Convert.ToInt16(intro1);

            if (num1 % 2 == 0)
            {
                Console.WriteLine("El número es par");
            }
            else
            {
                Console.WriteLine("El número es impar");
            }
        }
    }
}


//Tarea 11: Crea un programa que pida al usuario dos números enteros y diga cuál es el mayor de ellos.

using System;

namespace Ejercicios1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un entero: ");
            String intro1 = Console.ReadLine();
            int num1 = Convert.ToInt16(intro1);

            Console.WriteLine("Ingrese otro entero: ");
            String intro2 = Console.ReadLine();
            int num2 = Convert.ToInt16(intro2);

            if (num1 > num2)
            {
                Console.WriteLine("El numero 1 es Mayor");
            }
            else
            {
                Console.WriteLine("El número 2 es Mayor");
            }
        }
    }
}


//Tarea 12: Crea un programa que pida al usuario dos números enteros. Si el segundo no es cero, mostrará el resultado de dividir entre el primero y el segundo. Por el contrario, si el segundo número es cero, escribirá "Error: No se puede dividir entre cero".

using System;

namespace Ejercicios1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un numero entero: ");
            String intro1 = Console.ReadLine();
            int num1 = Convert.ToInt16(intro1);

            Console.WriteLine("Ingrese otro numero entero: ");
            String intro2 = Console.ReadLine();
            int num2 = Convert.ToInt16(intro2);

            if (num2 == 0)
            {
                Console.WriteLine("Error: No se puede dividir entre cero");
            }
            else
            {
                Console.WriteLine(num1 / num2);
            }
        }
    }
}


//Tarea 13: Crea un programa que pida un número del 1 al 5 al usuario, y escriba el nombre de ese número, usando "switch" (por ejemplo, si introduce "1", el programa escribirá "uno").

using System;
namespace Ejercicios1
{
    class Program
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Ingrese un numero del 1 al 5: ");
            String intro = Console.ReadLine();
            int num = Convert.ToInt16(intro);

            switch (num)
            {
                case 1:
                    Console.WriteLine("Uno");
                    break;
                case 2:
                    Console.WriteLine("Dos");
                    break;
                case 3:
                    Console.WriteLine("Tres");
                    break;
                case 4:
                    Console.WriteLine("Cuatro");
                    break;
                case 5:
                    Console.WriteLine("Cinco");
                    break;
            }
        }
    }

}


//Tarea 14: Crea un programa que escriba en pantalla los números del 1 al 10, usando "while".

using System;
namespace Ejercicios1
{
    class Program
    {
        static void Main(String[] args)
        {
            int num = 1;

            while (num <= 10)
            {
                Console.WriteLine(num);
                num++;
            }
        }
    }
}


//Tarea 15: Crea un programa que escriba en pantalla los números del 1 al 10, usando "do… while".

using System;
namespace Ejercicios1
{
    class Program
    {
        static void Main(String[] args)
        {
            int num = 1;
            do
            {
                Console.WriteLine(num);
                num++;
            } while (num <= 10);
        }
    }
}


//Tarea 16: Crea un programa que muestre los números del 10 al 20, ambos incluidos, usando “for”.

using System;
namespace Ejercicios1
{
    class Program
    {
        static void Main(String[] args)
        {
            for (int i = 10; i <= 20; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}

*/