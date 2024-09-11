using System;
 class Punto7
 {
    static void Taller7()
    {
        Console.WriteLine("¡Bienvenido al juego de adivinanza!");
        bool reintentar=true;
        do
        {
            Random random = new Random();
            int numeroSecreto = random.Next(1, 11);
            int intento = 0;
            bool adivinado = false; 
            while (!adivinado)
            {
                Console.Write("Adivina el número (entre 1 y 10): ");
                intento = int.Parse(Console.ReadLine());
                if (intento == numeroSecreto)
                {
                    Console.WriteLine("¡Felicidades! Has adivinado el número secreto.");
                    adivinado = true;
                }
                else
                {
                Console.WriteLine("Intenta de nuevo.");
                }
            }
            Console.WriteLine("¿Quieres jugar otra vez? (s/n): ");
            char jugarDeNuevo = Console.ReadKey().KeyChar;
            Console.WriteLine();

            switch (jugarDeNuevo)
            {
                case 's':
                case 'S':
                Console.WriteLine("¡Vamos a jugar otra vez!");
                break;

                case 'n':
                case 'N':
                Console.WriteLine("¡Gracias por jugar! Hasta la próxima.");
                reintentar=false;
                break;

                default:
                Console.WriteLine("Opción no válida. Salir del juego.");
                reintentar=false;
                jugarDeNuevo = 'n';
                break;
            }
        }while (reintentar==true);
    }
}