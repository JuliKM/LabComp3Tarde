using System;
using System.Threading;

namespace Hilos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Starting program");
            Thread t1 = new Thread(ejecutarHiloCincoSeg);
            t1.Start();
            Thread t2 = new Thread(ejecutarHiloDiezSeg);
            t2.Start();

        }

        public static void ejecutarHiloCincoSeg()
        {
            while (true)
            {
                Console.WriteLine("Hilo Ejecutado 5 ");
                Thread.Sleep(TimeSpan.FromSeconds(5));
            }
        }

        public static void ejecutarHiloDiezSeg()
        {
            while (true)
            {
                Console.WriteLine("Hilo Ejecutado 10 ");
                Thread.Sleep(TimeSpan.FromSeconds(10));
            }
        }
    }
}
