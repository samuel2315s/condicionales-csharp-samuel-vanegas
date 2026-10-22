
Console.Write("Ingrese una letra minúscula: ");
string entrada = Console.ReadLine()!;
char letra = entrada.Length == 1 ? entrada[0] : '\0';

if (letra >= 'a' && letra <= 'z')
{
    if ("aeiou".Contains(letra))
    {
        Console.WriteLine("Es vocal");
    }
    else
    {
        Console.WriteLine("Es consonante");
    }
}
else
{
    Console.WriteLine("No es una letra");
}
