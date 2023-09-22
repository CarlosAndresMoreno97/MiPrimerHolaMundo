using System;

namespace Ejercicio8
{
    public class program
    {
        static void Main(string[] args)
        {
            int num1;
            bool EsPar = false;

            Console.WriteLine("Ingrese numero: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            if (num1 % 2 == 0)
            { 
                EsPar = true;
            }            
            if (EsPar)
            {
                Console.WriteLine($"El numero {num1} es PAR");
            }
            else
            {
                Console.WriteLine($"El numero {num1} es IMPAR");
            }
        }
    }
}
