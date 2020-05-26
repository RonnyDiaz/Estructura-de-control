using System;

namespace Ejercicio_8
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;

            Console.Write("Digite el primer numero: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite el segundo numero: ");
            num2 = Convert.ToInt32(Console.ReadLine());


            if (num1 >= 0)
            {
                if (num2 >= 0) Console.WriteLine("Ambos son positivos");
               
            }
             else
            {
                if(num1 < 0)
                {
                    if (num2 < 0) Console.WriteLine("Ambos son negativos");
                }
            
            }  

           if (num1 >= 0)
            {
                if (num2 < 0) Console.WriteLine("Uno de ellos es negativo");
            }
           else
            {
                if (num1 < 0)
                {
                    if (num2 >= 0) Console.WriteLine("Uno de ellos es negativo");
                }
            }
        
        
        
        }
    }
}
