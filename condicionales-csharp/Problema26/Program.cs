
Console.Write("Ingrese la categoría (M, A, B, C): ");
char categoria = char.ToUpper(Console.ReadLine()![0]);

try
{
    int tarifa = categoria switch
    {
        'M' => 0,
        'A' => 12000,
        'B' => 25000,
        'C' => 38000,
        _ => throw new ArgumentException(
            "Categoría desconocida")
    };

    Console.WriteLine(
        $"Categoría {categoria} - Tarifa: ${tarifa:N0}");
}
catch (ArgumentException ex)
{
    Console.WriteLine(ex.Message);
}
