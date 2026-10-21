
Console.Write("Ingrese el primer número: ");
int a = int.Parse(Console.ReadLine()!);

Console.Write("Ingrese el segundo número: ");
int b = int.Parse(Console.ReadLine()!);

Console.Write("Ingrese el operador (+, -, *, /): ");
string operador = Console.ReadLine()!;

try
{
    int resultado = operador switch
    {
        "+" => a + b,
        "-" => a - b,
        "*" => a * b,
        "/" when b == 0 =>
            throw new DivideByZeroException(
                "No se puede dividir entre cero"),
        "/" => a / b,
        _ => throw new NotSupportedException(
            "Operador no soportado")
    };

    Console.WriteLine($"{a} {operador} {b} = {resultado}");
}
catch (Exception ex) when (
    ex is DivideByZeroException ||
    ex is NotSupportedException)
{
    Console.WriteLine(ex.Message);
}
