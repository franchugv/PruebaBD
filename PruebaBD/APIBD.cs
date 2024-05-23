using System;
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
            "Data Source=(localdb)\\MSSQLLocalDB; " + // Nombre de la base de datos PUNTO Y COMA y espacio en blanco ;
            "Initial Catalog=Contactos; " + // Nombre de la Tabla PUNTO Y COMA  y espacio en blanco;
            "Integrated Security=true"; // Establecer seguridad por defecto Aquí no

        // Métodos Privados
        // 1. Establecemos la conexión
        private static SqlConnection EstablecerConexion()
        {
            SqlConnection conexion = null;

            conexion = new SqlConnection(CADENA_CONEXION);

            return conexion;
        }

        // 2. Cargamos la lista de la base de datos haciendo uso del DataSet,
        // este es muy peseado
        private static DataSet ObtenerClientes()
        {
            const string INSTRUCCION = "SELECT * FROM Clientes";
            // Recursos
            DataSet datos = null; // Carga los datos de la consulta
            SqlConnection conexionBD = null;
            SqlDataAdapter bridgeBD = null; // Para crear una unión entre la
                                            // base de datos y el programa

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
        // 3. Obtenemos el Objeto de cliebtes
        public static Cliente[] ObtenerListaCliente()
        {
            // Recursos
            Cliente[] listaClientes = null;
            DataSet datosClientes = null; // Valor para extraer datos de la tabla
            int numClientes = 0;
            DataRow fila = null; // Fila

            datosClientes = ObtenerClientes();

            // Obtener el número de clientes que hay en la tabla
            numClientes = datosClientes.Tables["Clientes"].Rows.Count; // Array Asociativo
            
            // Array con el tamaño de la cantidad de clientes que tenemos
            listaClientes = new Cliente[numClientes];


            // Fila a fila
            for(int indice = 0; indice < listaClientes.Length; indice++)
            {
                fila = datosClientes.Tables["Clientes"].Rows[indice];

                // Asignamos el valor de la fina la la clase Cliente, Array Asociativo
                listaClientes[indice] = new Cliente((string)fila["Nombre"], (string)fila["Apellidos"], (string)fila["Telefono"]);
            }

            return listaClientes;
        }


        public static void EjecutarInstruccion(string Instruccion)
        {
            SqlConnection conexion = null;
            SqlCommand comando = null;

            // Hacemos el try catch para que en caso de error se cierre la conexión,
            // hay que recordar que el método tiene que ser independiente de la interfaz,
            // En la interfaz nos encargaremos de mostrar el error
            try 
            {
            // Conexión creada previamente
            conexion = EstablecerConexion(); 

            // Al comando hay que pasarle la instrucción
            // y la conexión de la base de datos que decidamos

            comando = new SqlCommand(Instruccion, conexion);

            conexion.Open();

            // Ejecución de la isntrucción, no es una consulta,
            // Insert, Update y Delete
            comando.ExecuteNonQuery();
            }
            catch(Exception error)
            {
                // Relanzamos la excepción para no perder la independencia
                throw error;
            }
            finally
            {
                conexion.Close(); // No olvidar cerrar la conexión

            }

        }

    }
}
