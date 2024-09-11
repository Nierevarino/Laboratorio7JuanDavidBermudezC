using System;
class Punto8
{
    static void Taller7()
    {
        bool continuar = false;

        while(continuar == false)
        {
            Console.WriteLine("Digite un numero:");
            int nmr1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite otro numero:");
            int nmr2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Menu de opciones:");
            Console.WriteLine("1. Suma");
            Console.WriteLine("2. Resta");
            Console.WriteLine("3. Multiplicacion");
            Console.WriteLine("4. Division");
            Console.WriteLine("5. Potencias de 2 numeros");
            Console.WriteLine("Digite el numero del calculo que desea realizar:");
            int calculo = int.Parse(Console.ReadLine());

            switch (calculo)
            {
                case 1:
                Console.WriteLine($"La suma de ambos numeros es: {nmr1 + nmr2}");
                break;

                case 2:
                Console.WriteLine($"La resta de ambos numeros es: {nmr1 - nmr2}");
                break;

                case 3:
                Console.WriteLine($"La multiplicacion de ambos numeros es: {nmr1 * nmr2}");
                break;

                case 4:
                Console.WriteLine($"La division de ambos numeros es: {nmr1 / nmr2}");
                break;

                case 5:
                Console.WriteLine($"La potencia de ambos numeros es: {Math.Pow(nmr1,nmr2)}");
                break;

                default:
                Console.WriteLine("Digitacion no valida");
                break;
            }

            Console.WriteLine("Desear realizzar otro calculo? (1=si/2=no)");
            int i = int.Parse(Console.ReadLine());

            switch(i)
            {
                case 1:
                Console.WriteLine($"Realizemos otro calculo");
                break;

                case 2:
                Console.WriteLine($"La division de ambos numeros es: {nmr1 / nmr2}");
                continuar=true;
                break;

                default:
                Console.WriteLine("Digitacion no valida");
                continuar=true;
                break;
            }
        }
    }
}
