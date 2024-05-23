namespace PruebaBD
{
    partial class PruebaBD
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBoxClientes = new System.Windows.Forms.ListBox();
            this.buttonClientesCargar = new System.Windows.Forms.Button();
            this.buttonNuevoCliente = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonBorrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxClientes
            // 
            this.listBoxClientes.FormattingEnabled = true;
            this.listBoxClientes.Location = new System.Drawing.Point(46, 45);
            this.listBoxClientes.Name = "listBoxClientes";
            this.listBoxClientes.Size = new System.Drawing.Size(332, 147);
            this.listBoxClientes.TabIndex = 0;
            // 
            // buttonClientesCargar
            // 
            this.buttonClientesCargar.Location = new System.Drawing.Point(46, 198);
            this.buttonClientesCargar.Name = "buttonClientesCargar";
            this.buttonClientesCargar.Size = new System.Drawing.Size(332, 23);
            this.buttonClientesCargar.TabIndex = 1;
            this.buttonClientesCargar.Text = "Cargar";
            this.buttonClientesCargar.UseVisualStyleBackColor = true;
            this.buttonClientesCargar.Click += new System.EventHandler(this.Controlador_Click);
            // 
            // buttonNuevoCliente
            // 
            this.buttonNuevoCliente.Location = new System.Drawing.Point(46, 227);
            this.buttonNuevoCliente.Name = "buttonNuevoCliente";
            this.buttonNuevoCliente.Size = new System.Drawing.Size(332, 23);
            this.buttonNuevoCliente.TabIndex = 2;
            this.buttonNuevoCliente.Text = "Nuevo Cliente";
            this.buttonNuevoCliente.UseVisualStyleBackColor = true;
            this.buttonNuevoCliente.Click += new System.EventHandler(this.buttonNuevoCliente_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(46, 256);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(332, 23);
            this.buttonUpdate.TabIndex = 3;
            this.buttonUpdate.Text = "Actualizar Cliente";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonBorrar
            // 
            this.buttonBorrar.Location = new System.Drawing.Point(46, 285);
            this.buttonBorrar.Name = "buttonBorrar";
            this.buttonBorrar.Size = new System.Drawing.Size(332, 23);
            this.buttonBorrar.TabIndex = 5;
            this.buttonBorrar.Text = "Borrar Cliente";
            this.buttonBorrar.UseVisualStyleBackColor = true;
            this.buttonBorrar.Click += new System.EventHandler(this.buttonBorrar_Click);
            // 
            // PruebaBD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 331);
            this.Controls.Add(this.buttonBorrar);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonNuevoCliente);
            this.Controls.Add(this.buttonClientesCargar);
            this.Controls.Add(this.listBoxClientes);
            this.Name = "PruebaBD";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxClientes;
        private System.Windows.Forms.Button buttonClientesCargar;
        private System.Windows.Forms.Button buttonNuevoCliente;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonBorrar;
    }
}

