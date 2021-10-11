using System;
/*
 Cree una aplicación de Consola que permita por parte del usuario el ingreso por teclado de una
cadena de texto, posteriormente el sistema deberá permitir el ingreso de una segunda cadena
de texto. Finalmente el sistema deberá emitir el mensaje “ENCONTRADO” o “NO
ENCONTRADO” según sean el caso de que la segunda cadena existe o no existe en la primera
cadena. Valide que la cantidad de caracteres de la segunda cadena sea menor o igual a la
cantidad de caracteres de la primera cadena.
Ej.:
Entrada Cadena 1: jhsjdhsjdhsd8787dsdsds8ds8d7sd6ds76d
Entrada Cadena 2: ds8ds8d
Resultado: “ENCONTRADO”
 */
namespace TP2Cadenas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Read strings exercise");
            ReadStrings();
        }
        
        public static void ReadStrings()
        {
            string str1, str2;

            Console.WriteLine("Insert first string");
            str1 = Console.ReadLine();

            Console.WriteLine("Insert second string");
            str2 = Console.ReadLine();

            if(ValidateString(str1, str2))
            {
                if (FindSubstring(str1, str2))
                {
                    Console.WriteLine($"\n String 1: {str1}" +
                                      $"\n String 2: {str2}" +
                                      "\nResult: FOUND");
                }
                else {
                    Console.WriteLine("\n Result: NOT FOUND");
                }
            }else
            {
                Console.WriteLine("\n Failed attempt: " +
                    "\n The second string can't contain more characters than first string");
            }

            
        }

        public static bool ValidateString(string str1, string str2)
        {
            return str2.Length < str1.Length;
        }

        public static bool FindSubstring(string str1, string str2)
        {
            return str1.Contains(str2);
        }
    }
}
