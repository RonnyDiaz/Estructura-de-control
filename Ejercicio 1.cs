using System;

namespace Ejercicio_l
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            Console.Write("Digite el numero: ");
            numero = Convert.ToInt32(Console.ReadLine());

            if (numero % 2 == 0)
            {
                Console.WriteLine("Es par");
            }
            else
            {
                Console.WriteLine("Es impar");
            }



        }

    }
}
