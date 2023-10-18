namespace Decorator
{
    public class Venta : IVenta
    {
        private List<string> _productos = new List<string>();
        public Venta(List<string> productos)
        {
            _productos = productos;
        }

        public Venta() : this(new List<string>())
        {

        }

        public decimal CalcularTotal()
        {
            decimal total = 100;
            return total;
        }

        public List<string> ObtenerProductos()
        {
            return _productos;
        }

        public override string ToString() =>
            $"El total de la venta es {CalcularTotal():N2}";
    }
}
