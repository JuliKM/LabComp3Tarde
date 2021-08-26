using System;

namespace Tp1Ej4
{
    class Program
    {
        static void Main(string[] args)

        {

            Console.WriteLine("Ingrese 2 numeros decimales");
            int nro1 = int.Parse(Console.ReadLine());
            int nro2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Que operacion desea realizar?:" +
                "\na. Suma (s)" +
                "\nb. Resta (r)" +
                "\nc. Multiplicacion (m)" +
                "\nd. Division (d)" +
                "\ne. Modulo (o)");
            string option = Console.ReadLine();
            switch (option)
            {
                case "s":
                    Console.WriteLine("Resultado: " + suma(nro1, nro2));
                    break;
                case "r":
                    Console.WriteLine("Resultado: " + resta(nro1, nro2));
                    break;
                case "m":
                    Console.WriteLine("Resultado: " + multi(nro1, nro2));
                    break;
                case "d":
                    Console.WriteLine("Resultado: " + div(nro1, nro2));
                    break;
                case "o":
                    Console.WriteLine("Resultado: " + mod(nro1, nro2));
                    break;
                default:
                    Console.WriteLine("Operación no válida");
                    break;
            }

            static double suma(double nro1, double nro2)
            {
                return nro1 + nro2;
            }
            static double resta(double nro1, double nro2)
            {
                return nro1 - nro2;
            }
            static double multi(double nro1, double nro2)
            {
                return nro1 * nro2;
            }
            static double div(double nro1, double nro2)
            {
                if (nro2 != 0) return nro1 / nro2;
                else
                {
                    Console.WriteLine("No se puede dividir por cero");
                    return 0;
                }
            }
            static double mod(double nro1, double nro2)
            {
                return nro1 % nro2;
            }
        }
    }
}
