using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Licorera.Clases
{
    class C_Usuario
    {
        static private string _Id_Usuario="";
        static private string _Usuario;
        static private string _Cod_Rol;
        static private string _Clave;
        static private string _NombreUsuario;
        static private string _Correo;
        static private int _Telefono;

        public C_Usuario()
        {
            _Id_Usuario = null;
            _Usuario = null;
            _Cod_Rol = null;
            _Clave = null;
            _NombreUsuario = null;
            _Correo = null;
            _Telefono = 0;
        }
        static public string Id { get => _Id_Usuario; set => _Id_Usuario = value; }
        static public string Usuario { get => _Usuario; set => _Usuario = value; }
        static public string Cod { get => _Cod_Rol; set => _Cod_Rol = value; }
        static public string Clave { get => _Clave; set => _Clave = value; }
        static public string NombreUsuario { get => _NombreUsuario; set => _NombreUsuario = value; }
        static public string Correo { get => _Correo; set => _Correo = value; }
        static public int Telefono { get => _Telefono; set => _Telefono = value; }

    }
}
