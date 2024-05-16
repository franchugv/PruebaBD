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
    }
}
