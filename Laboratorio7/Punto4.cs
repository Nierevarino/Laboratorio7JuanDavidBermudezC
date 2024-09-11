using System;
class Punto4
{
    static void Taller7()
    {
        Console.WriteLine("Digite un numero:");
        int nmr = int.Parse(Console.ReadLine());
        int x = 1;

        if(nmr/2 !=0)
        {
            for(int i =1;i<=nmr;i++)
            {
                int multi =x*i;
                x=multi;
            }
        }
        else
        {
            Console.WriteLine("Digitacion no valida");
        }
        Console.WriteLine($"El factorial del numero digitado es: {x}");
    }
}