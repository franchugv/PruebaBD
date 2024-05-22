namespace PruebaBD
{
    partial class FActualizar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.labelNombre = new System.Windows.Forms.Label();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.textBoxApellidos = new System.Windows.Forms.TextBox();
            this.labelApellidos = new System.Windows.Forms.Label();
            this.labelTlefono = new System.Windows.Forms.Label();
            this.buttonActualizar = new System.Windows.Forms.Button();
            this.maskedTextBoxTelefono = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(21, 23);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(47, 13);
            this.labelNombre.TabIndex = 0;
            this.labelNombre.Text = "Nombre:";
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(75, 23);
            this.textBoxNombre.MaxLength = 20;
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(249, 20);
            this.textBoxNombre.TabIndex = 1;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // textBoxApellidos
            // 
            this.textBoxApellidos.Location = new System.Drawing.Point(75, 72);
            this.textBoxApellidos.MaxLength = 50;
            this.textBoxApellidos.Name = "textBoxApellidos";
            this.textBoxApellidos.Size = new System.Drawing.Size(249, 20);
            this.textBoxApellidos.TabIndex = 4;
            // 
            // labelApellidos
            // 
            this.labelApellidos.AutoSize = true;
            this.labelApellidos.Location = new System.Drawing.Point(21, 72);
            this.labelApellidos.Name = "labelApellidos";
            this.labelApellidos.Size = new System.Drawing.Size(52, 13);
            this.labelApellidos.TabIndex = 3;
            this.labelApellidos.Text = "Apellidos:";
            // 
            // labelTlefono
            // 
            this.labelTlefono.AutoSize = true;
            this.labelTlefono.Location = new System.Drawing.Point(21, 123);
            this.labelTlefono.Name = "labelTlefono";
            this.labelTlefono.Size = new System.Drawing.Size(52, 13);
            this.labelTlefono.TabIndex = 5;
            this.labelTlefono.Text = "Teléfono:";
            // 
            // buttonActualizar
            // 
            this.buttonActualizar.Location = new System.Drawing.Point(24, 175);
            this.buttonActualizar.Name = "buttonActualizar";
            this.buttonActualizar.Size = new System.Drawing.Size(300, 23);
            this.buttonActualizar.TabIndex = 7;
            this.buttonActualizar.Text = "Actualizar Cliente";
            this.buttonActualizar.UseVisualStyleBackColor = true;
            this.buttonActualizar.Click += new System.EventHandler(this.buttonInsertar_Click);
            // 
            // maskedTextBoxTelefono
            // 
            this.maskedTextBoxTelefono.Location = new System.Drawing.Point(75, 123);
            this.maskedTextBoxTelefono.Mask = "000 00 00 00";
            this.maskedTextBoxTelefono.Name = "maskedTextBoxTelefono";
            this.maskedTextBoxTelefono.Size = new System.Drawing.Size(249, 20);
            this.maskedTextBoxTelefono.TabIndex = 8;
            this.maskedTextBoxTelefono.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePrompt;
            // 
            // FActualizar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 239);
            this.Controls.Add(this.maskedTextBoxTelefono);
            this.Controls.Add(this.buttonActualizar);
            this.Controls.Add(this.labelTlefono);
            this.Controls.Add(this.textBoxApellidos);
            this.Controls.Add(this.labelApellidos);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.labelNombre);
            this.Name = "FActualizar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión de clientes Insertar Nuevo Cliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox textBoxApellidos;
        private System.Windows.Forms.Label labelApellidos;
        private System.Windows.Forms.Label labelTlefono;
        private System.Windows.Forms.Button buttonActualizar;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxTelefono;
    }
}