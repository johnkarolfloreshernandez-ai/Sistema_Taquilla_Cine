using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Taquilla_Cine
{
        public class BoletoGeneral : Boleto
        {
            public BoletoGeneral(decimal precioBase)
                : base(precioBase)
            {
            }

            public override decimal CalcularPrecioFinal()
            {
                return PrecioBase;
            }
        }
    }


