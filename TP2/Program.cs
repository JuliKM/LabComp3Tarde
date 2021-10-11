using System;
/*
 CLASE “FraccionException”
Diseña e implementa una clase Fracción que permita crear fracciones (atributos numerador y
denominador tipo enteros), con métodos para sumar, restar, multiplicar y dividir las fracciones.
Crea una clase tipo excepción FraccionException (declárala como una excepción explícita) que
se lance siempre que el denominador o el numerador de la fracción sea cero.
Hacer que las operaciones lancen (throw) esta excepción si se da el caso, con un mensaje
indicativo del tipo de error (Ejemplo “El numerador no puede ser cero”)
Construir un programa que pruebe el funcionamiento de la clase Fracción y sus operaciones.
 */
namespace Practico2
{

    public class Fraccion
    {
        public int Numerador { get; set; }
        public int Denominador { get; set; }

        public Fraccion(int Numerador, int Denominador)
        {
            this.Numerador = Numerador;
            this.Denominador = Denominador;

        }

        public Fraccion Suma(Fraccion f1, Fraccion f2)  
        {
            if (f1.Denominador == 0 || f2.Denominador == 0) { FraccionException.LanzarExcepcion(); }
            Fraccion fr = new Fraccion(((f1.Numerador * f2.Denominador) +
                                              (f1.Denominador * f2.Numerador)),
                                              (f1.Denominador * f2.Denominador));
            return fr;
        }

        public Fraccion Resta(Fraccion f1, Fraccion f2)
        {
            if (f1.Denominador == 0 || f2.Denominador == 0) { FraccionException.LanzarExcepcion(); }

            Fraccion fr = new Fraccion(((f1.Numerador * f2.Denominador) -
                                              (f2.Numerador * f1.Denominador)),
                                              (f1.Denominador * f2.Denominador));
            return fr;
        }

        public Fraccion Multiplicacion(Fraccion f1, Fraccion f2)
        {
            if (f1.Denominador == 0 || f2.Denominador == 0) { FraccionException.LanzarExcepcion(); }
        
            Fraccion fr =  new Fraccion((f1.Numerador * f2.Numerador),
                                             (f1.Denominador * f2.Denominador));
            return fr;
        }

        public Fraccion Division(Fraccion f1, Fraccion f2)
        {
            if (f1.Denominador == 0 || f2.Denominador == 0) { FraccionException.LanzarExcepcion(); }
            Fraccion fr = new Fraccion((f1.Numerador * f2.Denominador),
                                             (f1.Denominador * f2.Numerador));
            return fr;
        }
    }
}
