
Console.Write("Ingrese la nota final: ");
double nota = double.Parse(
    Console.ReadLine()!.Replace(',', '.'),
    System.Globalization.CultureInfo.InvariantCulture
);

string estado = nota >= 3.0 ? "Aprobado" : "Reprobado";

Console.WriteLine($"Nota: {nota.ToString("0.0", System.Globalization.CultureInfo.GetCultureInfo("es-CO"))} - {estado}");
