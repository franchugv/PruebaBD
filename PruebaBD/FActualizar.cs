using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PruebaBD
{
    public partial class FActualizar : Form
    {
        public FActualizar()
        {
            InitializeComponent();
        }

        private void buttonInsertar_Click(object sender, EventArgs e)
        {

            // Recursos

            string instrucción = null;
            Cliente nuevoCliente = null;

            try
            {

            

            // Los campos deben contener datos
            ValidarCadena(textBoxNombre.Text);
            ValidarCadena(textBoxApellidos.Text);
            ValidarCadena(maskedTextBoxTelefono.Text);
            // Construir el objeto del modelo de datos (Validación) 
            nuevoCliente = new Cliente(textBoxNombre.Text, textBoxApellidos.Text, maskedTextBoxTelefono.Text);

            // Construir sentencia SQL (INSERT)
            instrucción = $"UPDATE Clientes SET Telefono = '{nuevoCliente.Telefono}' WHERE Nombre = '{nuevoCliente.Nombre}' AND Apellidos = '{nuevoCliente.Apellidos}'";

            // Ejecutar la Instrucción

            APIBD.EjecutarInstruccion(instrucción);


            }
            catch (Exception error) 
            { 
                MessageBox.Show("ERROR: Insercción de Cliente "+error.Message, "ERROR", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            // Cerrar Formulario
            this.Close();

        }













        public static void ValidarCadena(string cadena)
        {
            if (string.IsNullOrEmpty(cadena)) throw new Exception("Nombre no introducido");

        }
    }
}
