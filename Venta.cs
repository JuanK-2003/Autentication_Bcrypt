using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TiendaEnLinea
{
    public class detalleVenta
    {
        string codigoProducto;
        string descripcionProducto;
        int cantidadVendida;
        double precioUnidad;
        double subTotal;
        

        public string CodigoProducto { get => codigoProducto; set => codigoProducto = value; }
        public string DescripcionProducto { get => descripcionProducto; set => descripcionProducto = value; }
        public int CantidadVendida { get => cantidadVendida; set => cantidadVendida = value; }
        public double PrecioUnidad { get => precioUnidad; set => precioUnidad = value; }
        public double SubTotal { get => subTotal; set => subTotal = value; }
        
    }
    public class Venta
    {
        string nit;
        DateTime fechaVenta;
        DateTime fechaEntrega;
        string estado;
        string emisorTarjeta;
        String dato;        
        List<detalleVenta> productosVendidos;

        
     

        public string Nit { get => nit; set => nit = value; }
        public DateTime FechaVenta { get => fechaVenta; set => fechaVenta = value; }
        public DateTime FechaEntrega { get => fechaEntrega; set => fechaEntrega = value; }
        public string Estado { get => estado; set => estado = value; }
        public List<detalleVenta> ProductosVendidos { get => productosVendidos; set => productosVendidos = value; }
        public string EmisorTarjeta { get => emisorTarjeta; set => emisorTarjeta = value; }

        public Venta()
        {
            ProductosVendidos = new List<detalleVenta>();
        
        }
    }
}