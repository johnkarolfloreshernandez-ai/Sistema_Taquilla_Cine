using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Taquilla_Cine
{
    public class BoletoAdultoMayor : Boleto
    {
        // Atributo específico requerido
        public string NumCredencialInapam { get; set; }

        // Constructor
        public BoletoAdultoMayor(decimal precioBase, string numCredencialInapam)
            : base(precioBase)
        {
            NumCredencialInapam = numCredencialInapam;
        }

        // Aplica descuento del 50%
        public override decimal CalcularPrecioFinal()
        {
            return PrecioBase * 0.50m;
        }
    }
}
