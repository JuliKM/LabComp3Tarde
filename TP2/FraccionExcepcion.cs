using System;

namespace Practico2
{
	public abstract class FraccionException : Exception
	{
		public static void LanzarExcepcion()
		{
			throw new Exception("El numerador no puede ser cero");
		}
	}

}