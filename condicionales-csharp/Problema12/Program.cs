
Console.Write("¿Tiene empleo? (si/no): ");
string empleo = Console.ReadLine()!.ToLower();

if (empleo == "si")
{
    Console.Write("Ingrese el ingreso mensual: ");
    decimal ingreso = decimal.Parse(Console.ReadLine()!);

    if (ingreso >= 2500000)
    {
        Console.WriteLine("Crédito alto aprobado");
    }
    else
    {
        Console.WriteLine("Crédito básico aprobado");
    }
}
else
{
    Console.WriteLine("Crédito rechazado");
}
