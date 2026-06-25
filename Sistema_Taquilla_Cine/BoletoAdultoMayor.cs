using Sistema_Taquilla_Cine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Taquilla_CineWinForms
{
    public class BoletoAdultoMayor : Boleto
    {
        public string NumCredencialInapam { get; set; }

        public BoletoAdultoMayor(decimal precioBase, string numCredencial)
            : base(precioBase)
        {
            NumCredencialInapam = numCredencial;
        }

        public override decimal CalcularPrecioFinal()
        {
            return PrecioBase * 0.50m;
        }
    }
}
