using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp2Objetos
{
    class Cheque
    {
        private int NroInterno;
        public string Banco { get; set; }
        public float Importe { get; set; }
        public int Numero { get; set; }
        public string Propietario { get; set; }
        public void Guardar() { }
        public void Imprimir() { }
        public void ValidarNroInterno() { }
    }
}
