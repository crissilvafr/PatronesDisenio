namespace Adapter
{
    public class PagoVales: IPago
    {
        private readonly string _tarjetaVales;

        public PagoVales(string tarjetaVales)
        {
            _tarjetaVales = tarjetaVales;
        }

        public void Cobrar()
        {
            Console.WriteLine($"Pago realizado con la tarjeta de vales: {_tarjetaVales}");
        }
    }
}
