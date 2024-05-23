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
    public partial class PruebaBD : Form
    {
        public PruebaBD()
        {
            InitializeComponent();
        }

        private void Controlador_Click(object sender, EventArgs e)
        {
            // Recursos

            Cliente[] Lista = APIBD.ObtenerListaCliente();
            listBoxClientes.Items.Clear();




           foreach (Cliente cliente in Lista)
           {
                listBoxClientes.Items.Add($"{cliente.Nombre}, {cliente.Apellidos}, {cliente.Telefono}");
           }

        }

        private void buttonNuevoCliente_Click(object sender, EventArgs e)
        {
            // RECURSOS
            FInsertar formulario = null;

            // Le damos presencia al formulario en memoria
            formulario = new FInsertar();

            // Lo mustra si cerrar la otra aplicación
            formulario.ShowDialog();

        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            // RECURSOS
            FActualizar formularioUpdate = null;

            // Le damos presencia al formulario en memoria
            formularioUpdate = new FActualizar();

            // Lo mustra si cerrar la otra aplicación
            formularioUpdate.ShowDialog();
        }

        private void buttonBorrar_Click(object sender, EventArgs e)
        {
            FormEliminar formmeliminar = null;

            formmeliminar = new FormEliminar();

            formmeliminar.ShowDialog();
        }
    }
}
