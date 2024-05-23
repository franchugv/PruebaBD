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

        public Cliente(string nombre, string apellidos)
        {
            Nombre = nombre;
            Apellidos = apellidos;
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
