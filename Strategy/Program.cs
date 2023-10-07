// See https://aka.ms/new-console-template for more information
using Strategy;
Console.WriteLine("Hello, World!");
Producto celular = new Producto(new ProductoDescuentoVIP());
celular.Descripcion = "iPhone XV";
celular.Precio = 49000m;

Console.WriteLine($"El precio de {celular.Descripcion} es {celular.PrecioDeVenta} con un descuento de {celular.Descuento}");
