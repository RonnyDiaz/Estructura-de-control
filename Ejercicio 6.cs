using System;

namespace Ejercicio_6
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1, num2, total;

            Console.Write("Inserte su primer numero: ");
            num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Inserte su segundo numero: ");
            num2 = Convert.ToDouble(Console.ReadLine());
        
          if(num2 == 0)
            {
                Console.WriteLine("*Error*, no se puede dividir entre 0");
            }
            else
            {
                total = num1 / num2;

                Console.WriteLine("Es igual a = " + total);
            }
        
        }
    }
}
