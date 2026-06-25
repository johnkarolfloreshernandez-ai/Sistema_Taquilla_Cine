using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Taquilla_Cine
{
    public class BoletoEstudiante : Boleto
    {
        public string Matricula { get; set; }

        public BoletoEstudiante(decimal precioBase, string matricula)
            : base(precioBase)
        {
            Matricula = matricula;
        }

        public override decimal CalcularPrecioFinal()
        {
            return PrecioBase * 0.70m;
        }
    }
}
