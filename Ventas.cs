using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ventasExpress
{
    public class Ventas
    {
        private int codigo;
        private String producto;
        private int cantidad;
        private double precio;

        private static List<Ventas> lista = new List<Ventas>();

        public Ventas(int codigo, string producto, int cantidad, double precio)
        {
            Codigo = codigo;
            Producto = producto;
            Cantidad = cantidad;
            Precio = precio;          
        }

        public Ventas()
        {
            codigo = 0;
            producto = "";
            cantidad = 0;
            precio = 0;
        }

        public int Codigo { get => codigo; set => codigo = value; }
        public string Producto { get => producto; set => producto = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public double Precio { get => precio; set => precio = value; }
        public List<Ventas> Lista { get => lista; set => lista = value; }
    }
}
