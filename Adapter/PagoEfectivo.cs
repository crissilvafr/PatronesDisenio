using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    internal class PagoEfectivo: IPago
    {
        public void Cobrar()
        {
            Console.WriteLine("Pago en efectivo realizado!");
        }
    }
}
