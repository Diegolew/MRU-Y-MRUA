// See https://aka.ms/new-console-template for more information

using System;

class Program
{
    static void Main(string[] args)
    {
        bool continuar = true;

        while (continuar)
        {
            Console.WriteLine("Bienvenido a la Calculadora de Movimiento Rectilíneo");
            Console.WriteLine("¿Qué tipo de movimiento desea calcular?");
            Console.WriteLine("1. MRU");
            Console.WriteLine("2. MRUA");
 
            int tipoMovimiento = PedirOpcion(2);

            Console.WriteLine("¿Desea calcular distancia, velocidad o tiempo?");
            Console.WriteLine("1. Distancia");
            Console.WriteLine("2. Velocidad");
            Console.WriteLine("3. Tiempo");



        }
    }
}