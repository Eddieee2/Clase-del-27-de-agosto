using System;

class Program
{
    static void Main()
    {
        Console.Write("Escribe un año: ");
        int año = int.Parse(Console.ReadLine());

        if (año % 4 == 0)
        {
            if (año % 100 == 0)
            {
                if (año % 400 == 0)
                {
                    Console.WriteLine("El año es bisiesto.");
                }
                else
                {
                    Console.WriteLine("El año no es bisiesto.");
                }
            }
            else
            {
                Console.WriteLine("El año es bisiesto.");
            }
        }
        else
        {
            Console.WriteLine("El año no es bisiesto.");
        }
    }
}
