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
                if (num2 >= 0) Console.WriteLine("Los dos numeros son positivos");
               
            }
             else
            {
                if(num1 < 0)
                {
                    if (num2 < 0) Console.WriteLine("Ningun de los numeros es positivo");
                }
            
            }  

           if (num1 >= 0)
            {
                if (num2 < 0) Console.WriteLine("Uno de los numeros es positivo");
            }
           else
            {
                if (num1 < 0)
                {
                    if (num2 >= 0) Console.WriteLine("Uno de los numeros es positivo");
                }
            }
        
        
        
        }
    }
}
