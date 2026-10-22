
Console.Write("Ingrese el comando: ");
string comando = Console.ReadLine()!.ToLower();

switch (comando)
{
    case "play":
        Console.WriteLine("Reproduciendo...");
        break;
    case "pause":
        Console.WriteLine("En pausa");
        break;
    case "stop":
        Console.WriteLine("Detenido");
        break;
    case "next":
        Console.WriteLine("Siguiente canción");
        break;
    default:
        Console.WriteLine("Comando no reconocido");
        break;
}
