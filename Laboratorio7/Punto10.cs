using System;
class Punto10
{
    static void Taller7()
    {
        Console.WriteLine("Ingrese una palabra:");
        string palabra = Console.ReadLine().ToLower(); // Convertir a minúsculas para una comparación uniforme

        // Diccionario para contar la frecuencia de cada letra
        Dictionary<char, int> frecuencia = new Dictionary<char, int>();

        // Usar un bucle for para contar la frecuencia de cada letra
        for (int i = 0; i < palabra.Length; i++)
        {
            char letra = palabra[i];

            // Verificar si la letra es una letra del alfabeto
            if (char.IsLetter(letra))
            {
                if (frecuencia.ContainsKey(letra))
                {
                    frecuencia[letra]++;
                }
                else
                {
                    frecuencia[letra] = 1;
                }
            }
        }

        // Imprimir el resultado en un formato legible
        Console.WriteLine("Frecuencia de cada letra:");
        foreach (var entry in frecuencia)
        {
            Console.WriteLine($"{entry.Key}: {entry.Value}");
        }
    }
}