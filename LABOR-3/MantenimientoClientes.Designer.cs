namespace LABOR_3
{
    partial class MantenimientoClientes
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
            this.btnMostrarClientes = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.clmIDCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCedula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmFechaNacimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.txtSexo = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lbFechaNacimiento = new System.Windows.Forms.Label();
            this.lbCedula = new System.Windows.Forms.Label();
            this.lbSexo = new System.Windows.Forms.Label();
            this.lbAPELLIDO = new System.Windows.Forms.Label();
            this.lbNombre = new System.Windows.Forms.Label();
            this.lbCodigo = new System.Windows.Forms.Label();
            this.lbInterfazClientes = new System.Windows.Forms.Label();
            this.btnInsertarDatos = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtCodigoBuscar = new System.Windows.Forms.TextBox();
            this.lbCodigoBuscar = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnModificar = new System.Windows.Forms.Button();
            this.txtNombreEliminar = new System.Windows.Forms.TextBox();
            this.lbNombreEliminar = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMostrarClientes
            // 
            this.btnMostrarClientes.Location = new System.Drawing.Point(10, 612);
            this.btnMostrarClientes.Margin = new System.Windows.Forms.Padding(4);
            this.btnMostrarClientes.Name = "btnMostrarClientes";
            this.btnMostrarClientes.Size = new System.Drawing.Size(205, 58);
            this.btnMostrarClientes.TabIndex = 2;
            this.btnMostrarClientes.Text = "MOSTRAR CLIENTES";
            this.btnMostrarClientes.UseVisualStyleBackColor = true;
            this.btnMostrarClientes.Click += new System.EventHandler(this.btnMostrarClientes_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmIDCliente,
            this.clmCedula,
            this.clmNombre,
            this.clmApellido,
            this.clmSexo,
            this.clmFechaNacimiento});
            this.dataGridView1.Location = new System.Drawing.Point(599, 264);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(530, 160);
            this.dataGridView1.TabIndex = 3;
            // 
            // clmIDCliente
            // 
            this.clmIDCliente.HeaderText = "ID CLIENTE";
            this.clmIDCliente.MinimumWidth = 6;
            this.clmIDCliente.Name = "clmIDCliente";
            this.clmIDCliente.Width = 125;
            // 
            // clmCedula
            // 
            this.clmCedula.HeaderText = "CEDULA";
            this.clmCedula.MinimumWidth = 6;
            this.clmCedula.Name = "clmCedula";
            this.clmCedula.Width = 125;
            // 
            // clmNombre
            // 
            this.clmNombre.HeaderText = "NOMBRE";
            this.clmNombre.MinimumWidth = 6;
            this.clmNombre.Name = "clmNombre";
            this.clmNombre.Width = 125;
            // 
            // clmApellido
            // 
            this.clmApellido.HeaderText = "APELLIDO";
            this.clmApellido.MinimumWidth = 6;
            this.clmApellido.Name = "clmApellido";
            this.clmApellido.Width = 125;
            // 
            // clmSexo
            // 
            this.clmSexo.HeaderText = "SEXO";
            this.clmSexo.MinimumWidth = 6;
            this.clmSexo.Name = "clmSexo";
            this.clmSexo.Width = 125;
            // 
            // clmFechaNacimiento
            // 
            this.clmFechaNacimiento.HeaderText = "FECHA NACIMIENTO";
            this.clmFechaNacimiento.MinimumWidth = 6;
            this.clmFechaNacimiento.Name = "clmFechaNacimiento";
            this.clmFechaNacimiento.Width = 125;
            // 
            // txtFecha
            // 
            this.txtFecha.AcceptsTab = true;
            this.txtFecha.Location = new System.Drawing.Point(196, 416);
            this.txtFecha.Margin = new System.Windows.Forms.Padding(4);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(124, 25);
            this.txtFecha.TabIndex = 29;
            // 
            // txtCedula
            // 
            this.txtCedula.Location = new System.Drawing.Point(196, 182);
            this.txtCedula.Margin = new System.Windows.Forms.Padding(4);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(124, 25);
            this.txtCedula.TabIndex = 28;
            // 
            // txtSexo
            // 
            this.txtSexo.Location = new System.Drawing.Point(196, 362);
            this.txtSexo.Margin = new System.Windows.Forms.Padding(4);
            this.txtSexo.Name = "txtSexo";
            this.txtSexo.Size = new System.Drawing.Size(124, 25);
            this.txtSexo.TabIndex = 27;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(196, 303);
            this.txtApellido.Margin = new System.Windows.Forms.Padding(4);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(124, 25);
            this.txtApellido.TabIndex = 26;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(196, 245);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(124, 25);
            this.txtNombre.TabIndex = 25;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(196, 113);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(124, 25);
            this.txtCodigo.TabIndex = 24;
            // 
            // lbFechaNacimiento
            // 
            this.lbFechaNacimiento.AutoSize = true;
            this.lbFechaNacimiento.Location = new System.Drawing.Point(17, 416);
            this.lbFechaNacimiento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbFechaNacimiento.Name = "lbFechaNacimiento";
            this.lbFechaNacimiento.Size = new System.Drawing.Size(150, 17);
            this.lbFechaNacimiento.TabIndex = 22;
            this.lbFechaNacimiento.Text = "FECHA NACIMIENTO";
            // 
            // lbCedula
            // 
            this.lbCedula.AutoSize = true;
            this.lbCedula.Location = new System.Drawing.Point(101, 182);
            this.lbCedula.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCedula.Name = "lbCedula";
            this.lbCedula.Size = new System.Drawing.Size(66, 17);
            this.lbCedula.TabIndex = 21;
            this.lbCedula.Text = "CEDULA";
            // 
            // lbSexo
            // 
            this.lbSexo.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.lbSexo.AutoSize = true;
            this.lbSexo.Location = new System.Drawing.Point(83, 362);
            this.lbSexo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbSexo.Name = "lbSexo";
            this.lbSexo.Size = new System.Drawing.Size(45, 17);
            this.lbSexo.TabIndex = 20;
            this.lbSexo.Text = "SEXO";
            // 
            // lbAPELLIDO
            // 
            this.lbAPELLIDO.AutoSize = true;
            this.lbAPELLIDO.Location = new System.Drawing.Point(83, 303);
            this.lbAPELLIDO.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbAPELLIDO.Name = "lbAPELLIDO";
            this.lbAPELLIDO.Size = new System.Drawing.Size(78, 17);
            this.lbAPELLIDO.TabIndex = 19;
            this.lbAPELLIDO.Text = "APELLIDO";
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Location = new System.Drawing.Point(101, 245);
            this.lbNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(69, 17);
            this.lbNombre.TabIndex = 18;
            this.lbNombre.Text = "NOMBRE";
            // 
            // lbCodigo
            // 
            this.lbCodigo.AutoSize = true;
            this.lbCodigo.Location = new System.Drawing.Point(101, 116);
            this.lbCodigo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCodigo.Name = "lbCodigo";
            this.lbCodigo.Size = new System.Drawing.Size(67, 17);
            this.lbCodigo.TabIndex = 17;
            this.lbCodigo.Text = "CODIGO";
            // 
            // lbInterfazClientes
            // 
            this.lbInterfazClientes.AutoSize = true;
            this.lbInterfazClientes.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInterfazClientes.Location = new System.Drawing.Point(394, 9);
            this.lbInterfazClientes.Name = "lbInterfazClientes";
            this.lbInterfazClientes.Size = new System.Drawing.Size(416, 33);
            this.lbInterfazClientes.TabIndex = 31;
            this.lbInterfazClientes.Text = "MANTENIMIENTO DE CLIENTES";
            // 
            // btnInsertarDatos
            // 
            this.btnInsertarDatos.Location = new System.Drawing.Point(253, 612);
            this.btnInsertarDatos.Margin = new System.Windows.Forms.Padding(4);
            this.btnInsertarDatos.Name = "btnInsertarDatos";
            this.btnInsertarDatos.Size = new System.Drawing.Size(252, 58);
            this.btnInsertarDatos.TabIndex = 32;
            this.btnInsertarDatos.Text = "INSERTAR CLIENTES";
            this.btnInsertarDatos.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(972, 143);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(157, 72);
            this.btnBuscar.TabIndex = 36;
            this.btnBuscar.Text = "BUSCAR CLIENTE";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // txtCodigoBuscar
            // 
            this.txtCodigoBuscar.Location = new System.Drawing.Point(802, 162);
            this.txtCodigoBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodigoBuscar.Name = "txtCodigoBuscar";
            this.txtCodigoBuscar.Size = new System.Drawing.Size(124, 25);
            this.txtCodigoBuscar.TabIndex = 35;
            // 
            // lbCodigoBuscar
            // 
            this.lbCodigoBuscar.AutoSize = true;
            this.lbCodigoBuscar.Location = new System.Drawing.Point(695, 165);
            this.lbCodigoBuscar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCodigoBuscar.Name = "lbCodigoBuscar";
            this.lbCodigoBuscar.Size = new System.Drawing.Size(67, 17);
            this.lbCodigoBuscar.TabIndex = 34;
            this.lbCodigoBuscar.Text = "CODIGO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(576, 113);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(419, 17);
            this.label3.TabIndex = 33;
            this.label3.Text = "INGRESE EL CODIGO DEL CLIENTE QUE DESEA MODIFICAR";
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(552, 612);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(4);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(252, 58);
            this.btnModificar.TabIndex = 37;
            this.btnModificar.Text = "MODIFICAR CLIENTES";
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // txtNombreEliminar
            // 
            this.txtNombreEliminar.Location = new System.Drawing.Point(906, 538);
            this.txtNombreEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombreEliminar.Name = "txtNombreEliminar";
            this.txtNombreEliminar.Size = new System.Drawing.Size(124, 25);
            this.txtNombreEliminar.TabIndex = 40;
            // 
            // lbNombreEliminar
            // 
            this.lbNombreEliminar.AutoSize = true;
            this.lbNombreEliminar.Location = new System.Drawing.Point(799, 541);
            this.lbNombreEliminar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbNombreEliminar.Name = "lbNombreEliminar";
            this.lbNombreEliminar.Size = new System.Drawing.Size(69, 17);
            this.lbNombreEliminar.TabIndex = 39;
            this.lbNombreEliminar.Text = "NOMBRE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(669, 473);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(460, 17);
            this.label2.TabIndex = 38;
            this.label2.Text = "INGRESE EL NOMBRE DEL MEDICAMENTO QUE DESEA ELIMINAR ";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(848, 612);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(252, 58);
            this.btnEliminar.TabIndex = 41;
            this.btnEliminar.Text = "ELIMINAR CLIENTES";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // MantenimientoClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1190, 700);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.txtNombreEliminar);
            this.Controls.Add(this.lbNombreEliminar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtCodigoBuscar);
            this.Controls.Add(this.lbCodigoBuscar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnInsertarDatos);
            this.Controls.Add(this.lbInterfazClientes);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.txtCedula);
            this.Controls.Add(this.txtSexo);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lbFechaNacimiento);
            this.Controls.Add(this.lbCedula);
            this.Controls.Add(this.lbSexo);
            this.Controls.Add(this.lbAPELLIDO);
            this.Controls.Add(this.lbNombre);
            this.Controls.Add(this.lbCodigo);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnMostrarClientes);
            this.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "MantenimientoClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MantenimientoClientes_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMostrarClientes;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmIDCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCedula;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmApellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFechaNacimiento;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.TextBox txtSexo;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lbFechaNacimiento;
        private System.Windows.Forms.Label lbCedula;
        private System.Windows.Forms.Label lbSexo;
        private System.Windows.Forms.Label lbAPELLIDO;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.Label lbCodigo;
        private System.Windows.Forms.Label lbInterfazClientes;
        private System.Windows.Forms.Button btnInsertarDatos;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtCodigoBuscar;
        private System.Windows.Forms.Label lbCodigoBuscar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.TextBox txtNombreEliminar;
        private System.Windows.Forms.Label lbNombreEliminar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEliminar;
    }
}