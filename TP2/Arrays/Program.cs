using System;

namespace Tp2Array
{
/* Cree un programa que permita ingresar por teclado dos valores enteros el primero para indicar
el número de filas y el segundo para el número de columnas.Mediante los 2 valores cree una
matriz de 2 dimensiones de orden filas X columnas.
Asigne a cada elemento de la matriz el valor X si la suma de los valores enteros ingresados es
igual a la suma de la fila y columna de la celda caso contrario asigne una 0. (Se considera el
valor de la posición y no del índice de la tabla para el cálculo, es decir la primer posición es 1 no
0)*/
    class Program
    {
        static void Main(string[] args)
        {
            Ejercicio1();
            Ejercicio2();
        }

        private static void Ejercicio1()
        {
            int nro1, nro2;
            Console.WriteLine("Ingrese 2 valores para la matrix");
            nro1 = int.Parse(Console.ReadLine());
            nro2 = int.Parse(Console.ReadLine());

            string[,] arreglo = new string[nro1, nro2];

            for (int i = 0; i < arreglo.GetLength(0); i++)
            {
                for (int j = 0; j < arreglo.GetLength(1); j++)
                {
                    if (i + 1 + j + 1 == nro1 + nro2) { arreglo[i, j] = "X"; }
                    else { arreglo[i, j] = "0"; }
                }
            }

            for (int i = 0; i < arreglo.GetLength(0); i++)
            {
                for (int j = 0; j < arreglo.GetLength(1); j++)
                {
                    Console.Write(arreglo[i, j] + " ");
                }
                Console.Write("\n");
            }
        }
        private static void Ejercicio2()
        {
            Console.WriteLine("Ingrese una serie de numeros separados por coma");

            string cadena = Console.ReadLine();
            string[] cadenaArray = cadena.Split(',');

            int resultado = 0;

            foreach (string elemento in cadenaArray)
            {
                resultado += int.Parse(elemento);
            }
            Console.WriteLine($"Resultado: {resultado}");
        }
    }
}
