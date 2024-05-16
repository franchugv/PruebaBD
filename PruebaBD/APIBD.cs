﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace PruebaBD
{
    public static class APIBD
    {

        // Constantes

        private const string CADENA_CONEXION = 
            "Data Source=(localdb)\\MSSQLLocalDB;" + // Nombre de la base de datos PUNTO Y COMA ;
            "Initial Catalog=Contactos; " + // Nombre de la Tabla PUNTO Y COMA ;
            "Integrated Security=true"; // Establecer seguridad por defecto Aquí no

        // Métodos Privados
        private static SqlConnection EstablecerConexion()
        {
            SqlConnection conexion = null;

            conexion = new SqlConnection(CADENA_CONEXION);

            return conexion;
        }

        
        private static DataSet ObtenerClientes()
        {
            const string INSTRUCCION = "SELECT * FROM Clientes";
            // Recursos
            DataSet datos = null;
            SqlConnection conexionBD = null;
            SqlDataAdapter bridgeBD = null; // Para crear una unión

            // Inicializamos el DataSet
            datos = new DataSet();

            // Realizamos la conexión a la Base de datos
            conexionBD = EstablecerConexion();

            // Una vez hecha la conexión, hacemos el select, haciendo un elace,
            // actuando el bridgeBD como puente
            bridgeBD = new SqlDataAdapter(INSTRUCCION, conexionBD);
            
            // Mostramos los datos y le damos un nombre al resultado de la tabla
            bridgeBD.Fill(datos, "Clientes");


            conexionBD.Close();

            return datos;
        }


        // Métodos Públicos

        public static Cliente[] ObtenerListaCliente()
        {
            // Recursos
            Cliente[] listaClientes = null;
            DataSet datosClientes = null; // Valor para extraer datos de la tabla
            int numClientes = 0;
            DataRow fila = null; // Fila

            datosClientes = ObtenerClientes();

            // Obtener el número de clientes que hay en la tabla
            numClientes = datosClientes.Tables["Clientes"].Rows.Count;
            
            // Array con el tamaño de la cantidad de clientes que tenemos
            listaClientes = new Cliente[numClientes];


            // Fila a fila
            for(int indice = 0; indice < listaClientes.Length; indice++)
            {
                fila = datosClientes.Tables["Clientes"].Rows[indice];

                // Asignamos el valor de la fina la la clase Cliente
                listaClientes[indice] = new Cliente((string)fila["Nombre"], (string)fila["Apellidos"], (string)fila["Telefono"]);
            }

            return listaClientes;
        }


    }
}