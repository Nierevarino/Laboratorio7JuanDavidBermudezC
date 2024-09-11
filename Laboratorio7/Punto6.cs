using System;
class Punto6
{
    static void Taller7()
    {
        Console.WriteLine("Ingrese un número:");
        int numeroOriginal = int.Parse(Console.ReadLine());
        int numero = numeroOriginal;  // Para conservar el número original para la comparación
        int numeroInvertido = 0;

        // Usamos un bucle while para invertir el número
        while (numero > 0)
        {
            int digito = numero % 10;  // Obtiene el último dígito del número
            numeroInvertido = numeroInvertido * 10 + digito;  // Construye el número invertido
            numero /= 10;  // Elimina el último dígito del número original
        }

        // Comparar el número invertido con el número original
        if (numeroInvertido == numeroOriginal)
        {
            Console.WriteLine($"{numeroOriginal} es un número palíndromo.");
        }
        else
        {
            Console.WriteLine($"{numeroOriginal} no es un número palíndromo.");
        }
    }
}