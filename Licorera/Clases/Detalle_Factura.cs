using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Licorera.Clases
{
    class Detalle_Factura
    {
        private string _CodProducto;
        private string _NumFactura;
        private string _Cantidad;
        private string _ValorUnitario;

        public Detalle_Factura()
        {
            _CodProducto = null;
            _NumFactura = null;
            _Cantidad = null;
            _ValorUnitario = null;
        }
        public string CodProd { get => _CodProducto; set => _CodProducto = value; }
        public string Numfact { get => _NumFactura; set => _NumFactura = value; }
        public string Cantidad { get => _Cantidad; set => _Cantidad = value; }
        public string ValorUnidad { get => _ValorUnitario; set => _ValorUnitario = value; }
    }
}
