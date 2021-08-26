using System;

namespace Tp1Ej3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un numero");
            int nro = int.Parse(Console.ReadLine());

            static void esPar(int nro) {
                if (nro % 2 == 0) Console.WriteLine("El numero es par");
                else Console.WriteLine("El numero no es par");
            }
            esPar(nro);
        }
    }
}
