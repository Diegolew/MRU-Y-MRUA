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

            Console.WriteLine("¿Desea calcular distancia, velocidad, tiempo o área cuadrado?");
            Console.WriteLine("1. Distancia");
            Console.WriteLine("2. Velocidad");
            Console.WriteLine("3. Tiempo");
            Console.WriteLine("4. Área Cuadrado");

            int tipoCalculo = PedirOpcion(4);

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

                Console.WriteLine($"Resultado: La distancia es de {resultado} metros.");
            }
            else if (tipoCalculo == 2)
            {
                if (tipoMovimiento == 1)
                {
                    Console.WriteLine("Ingrese la distancia (m):");
                    double distancia = PedirNumero();

                    Console.WriteLine("Ingrese el tiempo (s):");
                    double tiempo = PedirNumero();

                    resultado = distancia / tiempo;
                }
                else if (tipoMovimiento == 2)
                {
                    Console.WriteLine("No se puede calcular la velocidad en un MRUA sin conocer la distancia.");
                }
                
                Console.WriteLine($"Resultado: La velocidad es de {resultado} m/s.");
            }
            else if (tipoCalculo == 3)
            {
                if (tipoMovimiento == 1)
                {
                    Console.WriteLine("No se puede calcular el tiempo en un MRU sin conocer la distancia y la velocidad.");
                }
                else if (tipoMovimiento == 2)
                {
                    Console.WriteLine("Ingrese la velocidad inicial (m/s):");
                    double velocidadInicial = PedirNumero();

                    Console.WriteLine("Ingrese la aceleración (m/s^2):");
                    double aceleracion = PedirNumero();

                    Console.WriteLine("Ingrese la velocidad final (m/s):");
                    double velocidadFinal = PedirNumero();

                    resultado = (velocidadFinal - velocidadInicial) / aceleracion;
                }

                Console.WriteLine($"Resultado: El tiempo es de {resultado} segundos.");
            }
            else if (tipoCalculo == 4)
            {
                if (tipoMovimiento == 1)
                {
                    Console.WriteLine("Ingrese la Altura:");
                    double Altura = PedirNumero();

                    Console.WriteLine("Ingrese la Base:");
                    double Base = PedirNumero();

                    resultado = Base * Altura;
                }
                else if (tipoMovimiento == 2)
                {
                    Console.WriteLine("No se puede calcular el área en un MRUA sin conocer la distancia.");
                }
                
                Console.WriteLine($"Resultado: El área es igual a {resultado} m^2.");
            }


            Console.WriteLine("¿Desea realizar otro cálculo?");
            Console.WriteLine("1. Sí");
            Console.WriteLine("2. No");

            int opcion = PedirOpcion(2);

            if (opcion == 2)
                continuar = false;
        }

        Console.WriteLine("Gracias por usar la Calculadora de Movimiento Rectilíneo.");
    }

    static int PedirOpcion(int maxOpcion)
    {
        int opcion;
        while (!int.TryParse(Console.ReadLine(), out opcion) || opcion < 1 || opcion > maxOpcion)
        {
            Console.WriteLine($"Por favor, ingrese una opción válida (1-{maxOpcion}):");
        }
        return opcion;
    }

    static double PedirNumero()
    {
        double numero;
        while (!double.TryParse(Console.ReadLine(), out numero))
        {
            Console.WriteLine("Por favor, ingrese un número válido:");
        }
        return numero;
    }
}
