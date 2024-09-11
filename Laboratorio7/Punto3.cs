using System;
class Punto3
{
    static void Taller7()
    {
        int nmr =1;
        int x = 0;
        
        do
        {
            Console.WriteLine("Digite un numero:");
            nmr = int.Parse(Console.ReadLine());

            int suma =nmr+x;
            x=suma;
        }
        while(nmr!=0);
        Console.WriteLine($"La suma de todos los digitos es {x}");
    }
}
