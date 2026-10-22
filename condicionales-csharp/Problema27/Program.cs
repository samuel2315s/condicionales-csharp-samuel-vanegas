
Console.Write("Ingrese el día de la semana: ");
string dia = Console.ReadLine()!.ToLower();

Console.Write("¿Es estudiante? (si/no): ");
bool estudiante = Console.ReadLine()!.ToLower() == "si";

int precio;

if (dia == "martes")
{
    precio = 7000;
}
else if (dia == "sábado" || dia == "sabado" ||
         dia == "domingo")
{
    precio = 15000;
}
else if (dia == "lunes" || dia == "miércoles" ||
         dia == "miercoles" || dia == "jueves" ||
         dia == "viernes")
{
    precio = estudiante ? 9000 : 12000;
}
else
{
    Console.WriteLine("Día no reconocido");
    return;
}

Console.WriteLine($"Precio: ${precio:N0}");
