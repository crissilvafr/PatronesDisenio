namespace Adapter
{
    public class PagoPaypal: IPago
    {
        private readonly string _usuariopp;

        public PagoPaypal(string usuariopp)
        {
            _usuariopp = usuariopp;
        }

        public void Cobrar()
        {
            Console.WriteLine($"Pago realizado con la cuenta: {_usuariopp}");
        }
    }
}
