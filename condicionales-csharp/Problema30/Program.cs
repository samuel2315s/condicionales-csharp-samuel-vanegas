
using System.Globalization;

CultureInfo cultura = CultureInfo.GetCultureInfo("es-CO");

Console.Write("Ingrese la primera nota: ");
double nota1 = double.Parse(Console.ReadLine()!);

Console.Write("Ingrese la segunda nota: ");
double nota2 = double.Parse(Console.ReadLine()!);

Console.Write("Ingrese la tercera nota: ");
double nota3 = double.Parse(Console.ReadLine()!);

double promedio = (nota1 + nota2 + nota3) / 3;
char letra;
string retroalimentacion;

if (promedio >= 90)
{
    letra = 'A';
    retroalimentacion = "Desempeño excelente";
}
else if (promedio >= 80)
{
    letra = 'B';
    retroalimentacion = "Buen desempeño, sigue así";
}
else if (promedio >= 70)
{
    letra = 'C';
    retroalimentacion = "Buen desempeño, sigue así";
}
else if (promedio >= 60)
{
    letra = 'D';
    retroalimentacion = "Aprobado, refuerza los temas";
}
else
{
    letra = 'F';
    retroalimentacion = "Debe presentar plan de mejoramiento";
}

string estado = promedio >= 60 ? "Aprobado" : "Reprobado";

Console.Write(
    $"Promedio: {promedio.ToString("F1", cultura)} | ");
Console.Write($"Letra: {letra} | ");
Console.Write($"{retroalimentacion} | {estado}");

if (promedio == 100)
{
    Console.Write(" | ¡Mención de honor!");
}

Console.WriteLine();
