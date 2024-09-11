using System;

class Punto2
{
    static void Taller7()
    {
        Console.WriteLine("Ingrese un número:");
        int numeroUsuario = int.Parse(Console.ReadLine());

        // Función para verificar si un número es primo
        bool EsPrimo(int numero)
        {
            if (numero <= 1) return false;
            if (numero == 2) return true;
            if (numero % 2 == 0) return false;

            int limite = (int)Math.Sqrt(numero);
            for (int i = 3; i <= limite; i += 2)
            {
                if (numero % i == 0)
                    return false;
            }
            return true;
        }

        // Encontrar el número primo más cercano menor o igual al número ingresado
        int numeroPrimoMasCercano = -1;
        int numeroActual = numeroUsuario;

        while (numeroActual >= 2)
        {
            if (EsPrimo(numeroActual))
            {
                numeroPrimoMasCercano = numeroActual;
                break;
            }
            numeroActual--;
        }

        if (numeroPrimoMasCercano == -1)
        {
            Console.WriteLine("No se encontraron números primos menores o iguales a " + numeroUsuario);
        }
        else
        {
            Console.WriteLine("El número primo más cercano menor o igual a " + numeroUsuario + " es: " + numeroPrimoMasCercano);
        }
    }
}
