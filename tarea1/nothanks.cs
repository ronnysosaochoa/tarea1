using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        // Leer el número de cartas recolectadas
        int n = int.Parse(Console.ReadLine());

        // Leer los números en las cartas recolectadas
        int[] cards = Console.ReadLine().Split().Select(int.Parse).ToArray();

        // Ordenar las cartas
        Array.Sort(cards);

        // Calcular la puntuación
        int score = CalculateScore(cards);

        // Imprimir la puntuación
        Console.WriteLine(score);
    }

    static int CalculateScore(int[] cards)
    {
        int score = 0;
        int prev = -2; // Inicializar prev a un valor que no sea posible en las cartas

        foreach (int card in cards)
        {
            // Si la carta actual no es consecutiva a la carta anterior, agregar su valor a la puntuación
            if (card != prev + 1)
            {
                score += card;
            }

            // Actualizar la carta previa
            prev = card;
        }

        return score;
    }
}
