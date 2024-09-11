using System;
class Program
{
    static void Main()
    {
        int limite =15;
        int i = 0;
        int x = 1;
        
        for(int nmr = 1;nmr <= limite; nmr++)
        {
            int suma =i+x;
            i=x;
            x=suma;
            Console.WriteLine(x);
        }
    }
}
