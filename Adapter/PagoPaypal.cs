using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class PagoPaypal
    {
        private readonly string _usuariopp;

        public PagoPaypal(string usuariopp)
        {
            _usuariopp = usuariopp;
        }

        public void RealizarPago()
        {
            Console.WriteLine($"Pago realizado con la cuenta: {_usuariopp}");
        }
    }
}
