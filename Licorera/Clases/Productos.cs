using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Licorera.Clases
{
    
    class Productos
    { 
        private string _CodProducto;
        private string _Nombre;
        private double _PrecioCompra;
        private double _PrecioVenta;
        private int _Unidades;

        public Productos()
        {
            this._CodProducto = "";
            this._Nombre = "";
            this._PrecioCompra = 0;
            this._PrecioVenta = 0;
            this._Unidades = 0;
        }
        public string Cod { get => _CodProducto; set => _CodProducto = value; }
        public string Nombre { get => _Nombre; set => _Nombre = value; }
        public double PrecioCompra { get => _PrecioCompra; set => _PrecioCompra = value; }
        public double PrecioVenta { get => _PrecioVenta; set => _PrecioVenta = value; }
        public int Unidades { get => _Unidades; set => _Unidades = value; }

        



    }
}
