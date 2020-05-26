using System;

namespace Ejercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;

            Console.Write("Digite el primer numero: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            if(num1 % 10 == 0)
            {
                Console.WriteLine("{0} es multiplo de 10", num1);
            }
            else
            {
                Console.WriteLine("{0} no es multiplo de 10", num1);
            }
            
            Console.Write("Digite el segundo numero: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            if (num2 % 10 == 0)
            {
                Console.WriteLine("{0} es multiplo de 10", num2);
            }
            else
            {
                Console.WriteLine("{0} no es multiplo de 10", num2);
            }
        }
    }
}
