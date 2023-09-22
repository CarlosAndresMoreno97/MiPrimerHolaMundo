namespace Ejercicio7.Division
{
    public class program
    {
        static void Main(string[] args)
        {

            //Escribir un algoritmo que dados 2 valores de entradaimprima siempre
            //la división del mayor entre el menor. Validar indeterminación

            double num1, num2, Cociente;

            Console.Write("Ingrese el primer numero: ");
            num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingrese el segundo numero: ");
            num2 = Convert.ToDouble(Console.ReadLine());

            if (num1 == 0 && num2 == 0)
            {
                Console.WriteLine("Tu resultado es inderterminado");
            }

           else if (num2 == 0) 
            {
                 Cociente = num2 / num1;
                Console.WriteLine($"La division de: {num2}÷{num1}={Cociente}");
            }
            else if (num1 == 0)
            {
                Cociente = num1 / num2;
                Console.WriteLine($"La division de: {num1}÷{num2}={Cociente}");
            }

            else if (num1 > num2)
            {
                Cociente = num1 / num2;
                Console.WriteLine($"La division de: {num1}÷{num2}={Cociente}");
            }
            else
            {
                Cociente = num2 / num1;
                Console.WriteLine($"La division de: {num2}÷{num1}={Cociente}");
            }

           

        }
    }
}