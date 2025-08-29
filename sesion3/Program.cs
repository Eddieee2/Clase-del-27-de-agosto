// Programar un meni que permita hcer lo siguiente:
// 1. Mostrar los numeros del 20 al 30
// 2. Leer un numero y decir si es positivo o negativo
// 3. Leer dos numeros y mostrar los numeros entre ellos

string opcion = "0";
int numero;


do
{
    Console.WriteLine("1. Mostrar los numeros del 20 al 30");
    Console.WriteLine("2. Leer un numero y decir si es positivo o negativo");
    Console.WriteLine("3. Leer dos numeros y mostrar los numeros entre ellos");
    Console.WriteLine("4. Salir");
    Console.Write("Digite una opcion: ");
    opcion = Console.ReadLine();
    switch (opcion)
    {
        case "1":
            for (int i = 20; i <= 30; i++)
            {
                Console.WriteLine(i);
            }
            break;
        case "2":
            Console.Write("Digite un numero: ");
            numero = Convert.ToInt32(Console.ReadLine());
            if (numero >= 0)
            {
                Console.WriteLine("El numero es positivo");
            }
            else
            {
                Console.WriteLine("El numero es negativo");
            }
        default:
            Console.WriteLine("Opcion no valida");
            break;
        case "3":
            Console.Write("Primer numero: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Segundo numero: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            while (num1 < num2)
            {
                Console.WriteLine("" + num1);
                num1++;

                
    


    }
} while (opcion != 4) ;
