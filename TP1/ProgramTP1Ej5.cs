using System;

namespace Tp1_Ej_5
{
    class Program
    {
        //Falta agregar diferencial por nocturna
        //Validar no mas de 8hs
        static void Main(string[] args)
        {
            const int HORA_DIURNA = 10;

            Console.WriteLine("Ingrese la hora de ingreso (Formato hh)");
            int minInicial = validarMinutos();
            Console.WriteLine("Ingrese los minutos de ingreso (Formato mm)");
            int horaInicial = validarMinutos();
            Console.WriteLine("Ingrese la hora de egreso (Formato hh)");
            int minFinal = validarMinutos();
            Console.WriteLine("Ingrese los minutos de egreso (Formato mm)");
            int horaFinal= validarMinutos();
            int minTotales = horasMinutos(calcularHoras(horaFinal, horaInicial)) + calcularMinutos(minFinal, minInicial);

            Console.WriteLine("Hay que pagar: " + minTotales * HORA_DIURNA / 60);

        }
        static int validarMinutos()
        {
            int valor = int.Parse(Console.ReadLine());
            if (valor > 60)
            {
                Console.WriteLine("Minutos incorrectos, vuelva a ingresar los minutos");
                validarMinutos();
            }
            else {
                return valor;
            }
            return validarMinutos();
        }
        static int validarHora()
        {
            int valor = int.Parse(Console.ReadLine());
            if (valor > 24)
            {
                Console.WriteLine("Hora incorrecta, vuelva a ingresar la hora");
                validarHora();
            }
            else
            {
                return valor;
            }
            return validarHora();
        }

        static int calcularHoras(int horaInicial, int horaFinal) {
            return horaFinal - horaInicial;
        }

        static int horasMinutos(int horas)
        {
            return horas * 60;
        }

        static int calcularMinutos(int minutosInicial, int minutosFinal)
        {
            return minutosFinal - minutosInicial;
        }

    }
}
