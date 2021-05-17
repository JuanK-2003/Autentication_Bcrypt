using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TiendaEnLinea
{
    public class Producto
    {
        string codigo;
        string descripcion;
        string marca;
        double precioCompra;
        double precioVenta;
        int existencia;
        string imagen; 

        public string Codigo { get => codigo; set => codigo = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public string Marca { get => marca; set => marca = value; }
        public double PrecioCompra { get => precioCompra; set => precioCompra = value; }
        public double PrecioVenta { get => precioVenta; set => precioVenta = value; }
        public int Existencia { get => existencia; set => existencia = value; }
        public string Imagen { get => imagen; set => imagen = value; }
    }

    public class Ropa : Producto
    {
        string talla;
        string material;

    }

    public class Computo : Producto
    {
        int ram;
        int discoduro;

    }
}