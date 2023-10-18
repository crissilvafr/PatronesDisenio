namespace Adapter
{
    internal class TarjetaCredito : IPago
    {
        private readonly string _numTarjeta;

        public TarjetaCredito(string numTajeta)
        {
            _numTarjeta = numTajeta;
        }
        public void Cobrar()
        {
            Console.WriteLine($"Pago realizado con la tarjeta {_numTarjeta}");
        }
    }
}
