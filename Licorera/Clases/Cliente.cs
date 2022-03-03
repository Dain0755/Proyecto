using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Licorera.Clases
{
    class Cliente
    {
        private string _CedulaCliente;
        private string _Nombres;
        private int _Telefono;
        private string _Email;
        private string _Direccion;

        public Cliente()
        {
            _CedulaCliente = null;
            _Nombres = null;
            _Telefono = 0;
            _Email = null;
            _Direccion = null;
        }

        public string ID { get => _CedulaCliente; set => _CedulaCliente = value; }
        public string Nombres { get => _Nombres; set => _Nombres = value; }
        public int Telefono { get => _Telefono; set => _Telefono = value; }
        public string Email { get => _Email; set => _Email = value; }
        public string Direccion { get => _Direccion; set => _Direccion = value; }

    }
}
