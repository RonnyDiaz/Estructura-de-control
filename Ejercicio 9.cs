﻿using System;

namespace Ejercicio_9
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3;

            Console.Write("Ingrese el primer numero: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingrese el segundo numero: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingrese el tercer numero: ");
            num3 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2)
            {
                Console.WriteLine("El numero mayor es: " + num1);
            }
            else
            {
                if(num2 > num3)
                {
                    Console.WriteLine("El numero mayor es: " + num2);
                }
                else
                {
                    Console.WriteLine("El numero mayor es: " + num3);
                }

            }
           
            
        }

    }
}
