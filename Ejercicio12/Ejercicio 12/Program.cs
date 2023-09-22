using System;

namespace Ejercicio12
{
    public class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, min, max, numero;
            const string MESSAGE = "Por favor ingresar un numero entero valido";

            Console.Write("ingrese el primer numero: ");
            if (int.TryParse(Console.ReadLine(), out num1)) ;
            {
                Console.WriteLine(MESSAGE);
            }

            Console.Write("Ingrese el segundo numero: ");
            if (!int.TryParse(Console.ReadLine(), out num2)) ;
            {
                Console.WriteLine(MESSAGE);
            }



        
        }
    }
}