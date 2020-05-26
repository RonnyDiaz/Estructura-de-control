using System;

namespace Ejercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;

            Console.Write("Inserte el primer numero: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Inserte el segundo numero: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            if (num1 % num2 == 0)
            {
                Console.WriteLine("{0} Es multiplo de {1}", num1, num2);
            }
            else
            {
                Console.WriteLine("{0} No es multiplo de {1}", num1, num2);
            }

            

        }
    }
}
