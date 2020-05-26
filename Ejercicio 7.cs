using System;

namespace Ejercicio_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;

           Console.Write("Digite el primer numero: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            if (num1 % 4 == 0)
            {
                Console.WriteLine("{0} es multiplo de 4", num1);
            }
            else
            {
                if (num1 % 5 == 0)
                {
                    Console.WriteLine("{0} es multiplo de 5", num1);
                }
                else
                {
                    Console.WriteLine("No es multiplo ni de 4 ni de 5");
                }


            }
        }
    }
}
