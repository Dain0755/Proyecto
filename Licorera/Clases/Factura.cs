using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Licorera.Clases
{
    class Factura
    {
        private string _NumFactura;
        private string _Fecha;
        private string _Total;
        private string _IdCliente;
        private string _IdUsuario;

        public Factura()
        {
            _NumFactura = null;
            _Fecha = null;
            _Total = null;
            _IdCliente = null;
            _IdUsuario = null;
        }

        public string Numfac { get => _NumFactura; set => _NumFactura = value; }
        public string Fecha { get => _Fecha; set => _Fecha = value; }
        public string total { get => _Total; set => _Total = value; }
        public string IdClien { get => _IdCliente; set => _IdCliente = value; }
        public string IdUser { get => _IdUsuario; set => _IdUsuario = value; }
    }
}
