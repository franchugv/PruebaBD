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
    public partial class FormEliminar : Form
    {
        public FormEliminar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Validar cadenas
            // Se validan en la case
            // Inicializar clase

            try
            {
                Cliente NuevoCliente = new Cliente(textBoxNombre.Text, textBoxApellidos.Text);

                DialogResult Dialogo = MessageBox.Show("¿Quiere eliminar?", "¿?",  MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if(Dialogo == DialogResult.Yes)
                {
                    APIBD.EjecutarInstruccion($"DELETE FROM Clientes WHERE Nombre = '{NuevoCliente.Nombre}' AND Apellidos = '{NuevoCliente.Apellidos}'");

                }
                else
                {
                    MessageBox.Show("No pasa nada bro");
                }

            }
            catch (Exception error) 
            {
                MessageBox.Show("Error: "+error.Message);

      
            }



            

            
        }



    }


}
