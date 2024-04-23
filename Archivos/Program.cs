// See https://aka.ms/new-console-template for more information
//Algo .....

using System;


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Bienvenido a la Calculadora de Movimiento Rectilíneo");
        Console.WriteLine("¿Qué tipo de movimiento desea calcular?");
        Console.WriteLine("1. MRU");
        Console.WriteLine("2. MRUA");
        int tipoMovimiento = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("¿Desea calcular distancia, velocidad o tiempo?");
        Console.WriteLine("1. Distancia");
        Console.WriteLine("2. Velocidad");
        Console.WriteLine("3. Tiempo");
        int tipoCalculo = Convert.ToInt32(Console.ReadLine());

        double resultado = 0;

        if (tipoMovimiento == 1 && tipoCalculo == 2)
        {
            Console.WriteLine("Ingrese la velocidad (m/s):");
            double velocidad = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese el tiempo (s):");
            double tiempo = Convert.ToDouble(Console.ReadLine());

            resultado = velocidad * tiempo;
            Console.WriteLine($"Resultado: La velocidad es de {resultado} m/s.");
        }
        else
        {
            Console.WriteLine("Opción no válida.");
        }

        Console.WriteLine("Gracias por usar la Calculadora de Movimiento Rectilíneo.");
    }
}
