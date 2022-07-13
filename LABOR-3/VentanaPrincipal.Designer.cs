namespace LABOR_3
{
    partial class VentanaPrincipal
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
            this.btnMantenimientoClientes = new System.Windows.Forms.Button();
            this.btnCatalogo = new System.Windows.Forms.Button();
            this.btnCompras = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMantenimientoClientes
            // 
            this.btnMantenimientoClientes.Location = new System.Drawing.Point(36, 122);
            this.btnMantenimientoClientes.Margin = new System.Windows.Forms.Padding(4);
            this.btnMantenimientoClientes.Name = "btnMantenimientoClientes";
            this.btnMantenimientoClientes.Size = new System.Drawing.Size(267, 92);
            this.btnMantenimientoClientes.TabIndex = 0;
            this.btnMantenimientoClientes.Text = "MANTENIMIENTO DE LOS CLIENTES";
            this.btnMantenimientoClientes.UseVisualStyleBackColor = true;
            this.btnMantenimientoClientes.Click += new System.EventHandler(this.btnMantenimientoClientes_Click);
            // 
            // btnCatalogo
            // 
            this.btnCatalogo.Location = new System.Drawing.Point(362, 122);
            this.btnCatalogo.Margin = new System.Windows.Forms.Padding(4);
            this.btnCatalogo.Name = "btnCatalogo";
            this.btnCatalogo.Size = new System.Drawing.Size(267, 92);
            this.btnCatalogo.TabIndex = 1;
            this.btnCatalogo.Text = "CATALOGO PRODUCTOS";
            this.btnCatalogo.UseVisualStyleBackColor = true;
            this.btnCatalogo.Click += new System.EventHandler(this.btnCatalogo_Click);
            // 
            // btnCompras
            // 
            this.btnCompras.Location = new System.Drawing.Point(705, 122);
            this.btnCompras.Margin = new System.Windows.Forms.Padding(4);
            this.btnCompras.Name = "btnCompras";
            this.btnCompras.Size = new System.Drawing.Size(267, 92);
            this.btnCompras.TabIndex = 2;
            this.btnCompras.Text = "COMPRAS ";
            this.btnCompras.UseVisualStyleBackColor = true;
            // 
            // VentanaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 354);
            this.Controls.Add(this.btnCompras);
            this.Controls.Add(this.btnCatalogo);
            this.Controls.Add(this.btnMantenimientoClientes);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "VentanaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMantenimientoClientes;
        private System.Windows.Forms.Button btnCatalogo;
        private System.Windows.Forms.Button btnCompras;
    }
}

