using System;
class Punto5
{
    static void Taller7()
    {
        Console.WriteLine("Ingrese la altura del triángulo:");
        int altura = int.Parse(Console.ReadLine());

        for (int i = altura; i > 0; i--)
        {
            // Bucle para imprimir los asteriscos
            for (int j = 0; j < i; j++)
            {
                Console.Write("*");
            }
            // Salto de línea después de cada fila
            Console.WriteLine();
        }
    }
}