
using System.Globalization;

CultureInfo cultura = CultureInfo.GetCultureInfo("es-CO");

Console.Write("Ingrese el peso en kg: ");
double peso = double.Parse(
    Console.ReadLine()!.Replace(',', '.'),
    CultureInfo.InvariantCulture
);

Console.Write("Ingrese la estatura en metros: ");
double estatura = double.Parse(
    Console.ReadLine()!.Replace(',', '.'),
    CultureInfo.InvariantCulture
);

double imc = peso / (estatura * estatura);
string categoria;

if (imc < 18.5)
{
    categoria = "Bajo peso";
}
else if (imc < 25)
{
    categoria = "Peso normal";
}
else if (imc < 30)
{
    categoria = "Sobrepeso";
}
else
{
    categoria = "Obesidad";
}

Console.WriteLine($"IMC: {imc.ToString("F1", cultura)} - {categoria}");
