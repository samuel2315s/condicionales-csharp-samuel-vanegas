

namespace ProblemaSemaforo
{
    // Por convención, los Enum van en PascalCase (Mayúscula inicial)
    enum EstadoSemaforo
    {
        Rojo,
        Amarillo,
        Verde
    }

    class Program
    {
        static void Main()
        {
            // El nombre de la variable puede ir en camelCase
            EstadoSemaforo estado = EstadoSemaforo.Verde;

            switch (estado)
            {
                case EstadoSemaforo.Rojo:
                    Console.WriteLine("Deténgase");
                    break;
                case EstadoSemaforo.Amarillo:
                    Console.WriteLine("Precaución, prepárese para detenerse");
                    break;
                case EstadoSemaforo.Verde:
                    Console.WriteLine("Avance");
                    break;
            }
        }
    }
}