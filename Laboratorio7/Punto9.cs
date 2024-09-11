using System;
class Punto9
{
    static void Taller7()
    {
        Console.WriteLine("Ingrese un número:");
        int n = int.Parse(Console.ReadLine());
        int sumaPrimos = 0;

        // Función para verificar si un número es primo
        bool EsPrimo(int numero)
        {
            if (numero <= 1) return false;
            if (numero == 2) return true;
            if (numero % 2 == 0) return false;

            for (int i = 3; i <= Math.Sqrt(numero); i += 2)
            {
                if (numero % i == 0)
                    return false;
            }
            return true;
        }

        // Usar un bucle for para iterar desde 2 hasta n
        for (int i = 2; i <= n; i++)
        {
            if (EsPrimo(i))
            {
                sumaPrimos += i;
            }
        }

        Console.WriteLine("La suma de todos los números primos entre 1 y " + n + " es: " + sumaPrimos);
    }
}