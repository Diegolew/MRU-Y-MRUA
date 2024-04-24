// See https://aka.ms/new-console-template for more information
//alg
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

            int tipoCalculo = PedirOpcion(3);

            double resultado = 0;

            if (tipoCalculo == 1)
            {
                if (tipoMovimiento == 1)
                {
                    Console.WriteLine("Ingrese la velocidad (m/s):");
                    double velocidad = PedirNumero();

                    Console.WriteLine("Ingrese el tiempo (s):");
                    double tiempo = PedirNumero();

                    resultado = velocidad * tiempo;
                }
                else if (tipoMovimiento == 2)
                {
                    Console.WriteLine("Ingrese la velocidad inicial (m/s):");
                    double velocidadInicial = PedirNumero();

                    Console.WriteLine("Ingrese la aceleración (m/s^2):");
                    double aceleracion = PedirNumero();

                    Console.WriteLine("Ingrese el tiempo (s):");
                    double tiempo = PedirNumero();

                    resultado = velocidadInicial * tiempo + 0.5 * aceleracion * Math.Pow(tiempo, 2);
                }



            }
        }
    }
}