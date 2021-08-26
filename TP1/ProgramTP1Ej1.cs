using System;

namespace TpUno
{
    class Program1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Con for");
            for (int i = 1; i < 101; i++)
            {
                if (i%2==0 && i % 5 == 0) Console.Write(i + " ");
            }
            Console.WriteLine("\nCon while");
            int j = 1;
            while (j < 101) {
                if (j % 2 == 0 && j % 5 == 00) Console.Write(j + " ");
                j++;
            }
            Console.WriteLine("\nCon do/while");
            int k = 1;
            do
            {
                if (k % 2 == 0 && k % 5 == 00) Console.Write(k + " ");
                k++;
            } while (k < 101);
        }
        
    }
}
