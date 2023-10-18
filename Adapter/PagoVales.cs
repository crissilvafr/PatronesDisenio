using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class PagoVales
    {
        private readonly string _tarjetaVales;

        public PagoVales(string tarjetaVales)
        {
            _tarjetaVales = tarjetaVales;
        }

        public void RealizarPago()
        {
            Console.WriteLine($"Pago realizado con la tarjeta de vales: {_tarjetaVales}");
        }
    }
}
