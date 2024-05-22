using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaBD
{
    public class Cliente
    {

        // Miembros Privados

        private string _nombre;
        private string _apellidos;
        private string _telefono;

        public Cliente()
        {
            _nombre = _apellidos = "DESC";
            _telefono = "000000000";
        }
        
        public Cliente(string nombre, string apellidos, string telefono)
        {
            Nombre = nombre;
            Apellidos = apellidos;
            Telefono = telefono;
        }

        // Propiedades

        public string Nombre
        {
            get
            {
                return _nombre;
            }
            set
            {
                if (string.IsNullOrEmpty(value)) throw new Exception("Cadena vacía");
                _nombre = value;
            }
        }

        public string Apellidos
        {
            get
            {
                return _apellidos;
            }
            set
            {
                _apellidos = value;
            }
        }

        public string Telefono
        {
            get
            {
                return _telefono;
            }
            set
            {
                _telefono = value;
            }
        }

    }
}
