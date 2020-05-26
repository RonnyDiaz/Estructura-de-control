using System;

namespace Ejercicio_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, resultado;

            Console.Write("Inserte el primer numero: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            if (num1 == 0)
            {
                Console.WriteLine("El producto de 0 por cualquier numero es 0");
            }
            else
            {
                Console.Write("Inserte el segundo numero: ");
                num2 = Convert.ToInt32(Console.ReadLine());

                resultado = num1 * num2;

                Console.WriteLine("Es igual a = " + resultado);
            }
        
        
        
        }
    }
}
