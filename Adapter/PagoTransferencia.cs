using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    internal class PagoTransferencia: IPago
    {
        public void Cobrar()
        {
            Console.WriteLine("Pago realizado por transferencia");
        }
    }
}
