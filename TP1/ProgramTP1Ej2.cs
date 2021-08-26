using System;

namespace Tp1Ej2
{
    class Program
    {
        static void Main(string[] args)
        {
            Boolean found = false;
            Random rnd = new Random();
            int nro = rnd.Next(100);
            int rta;
            int acum = 0;
            while (found == false) 
            {
                Console.WriteLine("Ingrese un nro");
                rta = int.Parse(Console.ReadLine());
                acum++;
                if (nro == rta)
                {
                    Console.WriteLine("Correcto, numero encontrado, cantidad de intentos: "+acum);
                    found = true;
                    break;
                }
                if (rta < nro)
                {
                    Console.WriteLine("muy bajo");
                }
                if (rta > nro)
                {
                    Console.WriteLine("muy alto");
                }
            }
        }
    }
}
