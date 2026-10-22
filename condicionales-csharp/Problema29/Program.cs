
Console.Write("Ingrese el rol: ");
string rol = Console.ReadLine()!.ToLower();

Console.Write("Ingrese la hora (0-23): ");
int hora = int.Parse(Console.ReadLine()!);

bool permitido =
    rol == "admin" ||
    (rol == "instructor" && hora >= 6 && hora <= 21) ||
    (rol == "aprendiz" && hora >= 6 && hora <= 18);

if (permitido)
{
    Console.WriteLine("Acceso permitido");
}
else
{
    Console.WriteLine("Acceso denegado");
}
