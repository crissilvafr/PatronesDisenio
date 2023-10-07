// See https://aka.ms/new-console-template for more information
using Adapter;
Console.WriteLine("Hello, World!");
IPago pago = new PagoTransferencia();
Ventas venta = new Ventas(pago);
venta.ProcesarPago();

IPago pago1 = new PagoEfectivo();
Ventas venta1 = new Ventas(pago1);
venta1.ProcesarPago();

IPago pagoTarjeta = new TarjetaCredito("0112358");
Ventas venta2 = new Ventas(pagoTarjeta);
venta2.ProcesarPago();