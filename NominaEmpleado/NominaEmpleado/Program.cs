//Desarrolle un algoritmo en C# que me permita calcular la nómina del mes de un empleado.
//Debemos pedir por pantalla el nombre del empleado, el cargo, horas trabajadas y valor de la hora.
//Se debe descontar de su salario el 4% correspondientes a salud,
//el 4% correspondientes a pensión y ¼ parte por un embargo bancarios que recibió dicho empleado
//Mostrar por pantalla el nombre del empleado, su cargo, salario neto (antes de deducciones)
//y salario final (después de deducciones).


public class nominaEmpleado
{
    static void Main(string[] args)
    {
        string nombreEmple, cargo;
        double horsTraba, valorhr, salarionet, salariofin, pension, salud, banco;

        Console.Write("Ingresar nombre empleado: ");
        nombreEmple = Console.ReadLine();

        Console.Write("Ingresar cargo empleado: ");
        cargo = Console.ReadLine();

        Console.Write("Ingresar horas trabajadas: ");
        horsTraba = double.Parse(Console.ReadLine());

        Console.Write("Ingresar valor horas: ");
        valorhr = double.Parse(Console.ReadLine());

        salarionet = horsTraba * valorhr;
        pension = salarionet * 4 / 100;
        salud = salarionet * 4 / 100;
        banco = salarionet * 0.25 / 100;
        salariofin = salarionet - salud - pension - banco;

        Console.Write("El nombre del empleado es: " + nombreEmple);
        Console.Write("\n");
        Console.Write("El cargo del empleado es: " + cargo);
        Console.Write("\n");
        Console.Write("El salario neto del empleado es: " + salarionet);
        Console.Write("\n");
        Console.Write("El salario final del empleado es: " + salariofin);
        Console.Write("\n");


    }




}
     