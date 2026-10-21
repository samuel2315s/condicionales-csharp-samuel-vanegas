
Console.Write("Jugador 1 (piedra, papel, tijera): ");
string jugador1 = Console.ReadLine()!.ToLower();

Console.Write("Jugador 2 (piedra, papel, tijera): ");
string jugador2 = Console.ReadLine()!.ToLower();

if (jugador1 == jugador2)
{
    Console.WriteLine("Empate");
}
else if (
    (jugador1 == "piedra" && jugador2 == "tijera") ||
    (jugador1 == "tijera" && jugador2 == "papel") ||
    (jugador1 == "papel" && jugador2 == "piedra"))
{
    Console.WriteLine("Gana el jugador 1");
}
else if (
    (jugador1 == "piedra" || jugador1 == "papel" ||
     jugador1 == "tijera") &&
    (jugador2 == "piedra" || jugador2 == "papel" ||
     jugador2 == "tijera"))
{
    Console.WriteLine("Gana el jugador 2");
}

