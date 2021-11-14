using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpJson.Model
{
    class Client
    {
        public string RazonSocial { get; set; }
        public long Documento { get; set; }
        public Domicilio Domicilio { get; set; }
        public List<Comprobante> Comprobantes { get; set; }
        public DateTime FechaAlta { get; set; }
    }
}
