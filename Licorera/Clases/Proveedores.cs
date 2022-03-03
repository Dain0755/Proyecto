using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Licorera.Clases
{
    class Proveedores
    {
        private string _Nit;
        private string _NombreProveedor;
        private int _Telefono;
        private string _Dirección;
        private string _Email;
        
        public Proveedores()
        {
            this._Nit = null;
            this._NombreProveedor = null;
            this._Telefono = 0;
            this._Dirección = null;
            this._Email = null;
        }

        public string Nit { get => _Nit; set => _Nit = value; }
        public string Nombre { get => _NombreProveedor; set => _NombreProveedor = value; }
        public int Telefono { get => _Telefono; set => _Telefono = value; }
        public string Dirección { get => _Dirección; set => _Dirección = value; }
        public string Email { get => _Email; set => _Email = value; }
    }
}
