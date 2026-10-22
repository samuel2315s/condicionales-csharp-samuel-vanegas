
Console.Write("Ingrese la estatura en metros: ");
double estatura = double.Parse(
    Console.ReadLine()!.Replace(',', '.'),
    System.Globalization.CultureInfo.InvariantCulture
);

Console.Write("Ingrese la edad: ");
int edad = int.Parse(Console.ReadLine()!);

Console.Write("¿Va acompañado por un adulto? (si/no): ");
bool acompanado = Console.ReadLine()!.ToLower() == "si";

if (estatura >= 1.40 && (edad >= 12 || acompanado))
{
    Console.WriteLine("Puede subir");
}
else
{
    Console.WriteLine("No puede subir");
}
