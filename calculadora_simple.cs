using System;


namespace Calculadora
{
    internal class Program


    {

        static void Main(string[] args)
        {

            int num1, num2;
            int resultado;
            

            Console.WriteLine("Para suma ingresa 1 , para resta 2, para multiplicación 3, para división 4");

           

                switch (operacion)


                 {

                    case 1:

                        Console.WriteLine("Ingrese el primer número");
                        num1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo número");
                        num2 = int.Parse(Console.ReadLine());
                        resultado = num1 + num2;
                        Console.WriteLine($"El resultado es: {resultado}");

                        break;

                    case 2:


                        Console.WriteLine("Ingrese el primer número");
                        num1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo número");
                        num2 = int.Parse(Console.ReadLine());
                        resultado = num1 - num2;
                        Console.WriteLine($"El resultado es: {resultado}");

                        break;

                    case 3:

                        Console.WriteLine("Ingrese el primer número");
                        num1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo número");
                        num2 = int.Parse(Console.ReadLine());
                        resultado = num1 * num2;
                        Console.WriteLine($"El resultado es: {resultado}");

                        break;

                    case 3:

                        Console.WriteLine("Ingrese el primer número");
                        num1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo número");
                        num2 = int.Parse(Console.ReadLine());
                        resultado = num1 / num2;
                        Console.WriteLine($"El resultado es: {resultado}");

                        break;


                    default:
                        Console.WriteLine("Debe ingresar números del 1 al 4");
                        break;
                }
                }
    }
}

