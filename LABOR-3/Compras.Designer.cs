namespace LABOR_3
{
    partial class Compras
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.clmIDCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmIDCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmIDProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmFechaCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.lbCompras = new System.Windows.Forms.Label();
            this.txtIDCOMRA = new System.Windows.Forms.TextBox();
            this.lbCOMPRA = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.txtCompras = new System.Windows.Forms.TextBox();
            this.txtFechaCompra = new System.Windows.Forms.TextBox();
            this.txtIDProducto = new System.Windows.Forms.TextBox();
            this.txtidCliente = new System.Windows.Forms.TextBox();
            this.lbCompra1 = new System.Windows.Forms.Label();
            this.lbFechaCompra = new System.Windows.Forms.Label();
            this.lbIDProcto = new System.Windows.Forms.Label();
            this.lbIDCliente = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmIDCompra,
            this.clmIDCliente,
            this.clmIDProducto,
            this.clmFechaCompra});
            this.dataGridView1.Location = new System.Drawing.Point(22, 153);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // clmIDCompra
            // 
            this.clmIDCompra.HeaderText = "ID COMPRA";
            this.clmIDCompra.MinimumWidth = 6;
            this.clmIDCompra.Name = "clmIDCompra";
            this.clmIDCompra.Width = 125;
            // 
            // clmIDCliente
            // 
            this.clmIDCliente.HeaderText = "ID CLIENTE";
            this.clmIDCliente.MinimumWidth = 6;
            this.clmIDCliente.Name = "clmIDCliente";
            this.clmIDCliente.Width = 125;
            // 
            // clmIDProducto
            // 
            this.clmIDProducto.HeaderText = "ID PRODUCTO";
            this.clmIDProducto.MinimumWidth = 6;
            this.clmIDProducto.Name = "clmIDProducto";
            this.clmIDProducto.Width = 125;
            // 
            // clmFechaCompra
            // 
            this.clmFechaCompra.HeaderText = "FECHA COMPRA";
            this.clmFechaCompra.MinimumWidth = 6;
            this.clmFechaCompra.Name = "clmFechaCompra";
            this.clmFechaCompra.Width = 125;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(83, 369);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 57);
            this.button1.TabIndex = 1;
            this.button1.Text = "MOSTRAR COMPRAS";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbCompras
            // 
            this.lbCompras.AutoSize = true;
            this.lbCompras.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCompras.Location = new System.Drawing.Point(368, 13);
            this.lbCompras.Name = "lbCompras";
            this.lbCompras.Size = new System.Drawing.Size(91, 20);
            this.lbCompras.TabIndex = 2;
            this.lbCompras.Text = "COMPRAS";
            // 
            // txtIDCOMRA
            // 
            this.txtIDCOMRA.Location = new System.Drawing.Point(496, 157);
            this.txtIDCOMRA.Margin = new System.Windows.Forms.Padding(4);
            this.txtIDCOMRA.Name = "txtIDCOMRA";
            this.txtIDCOMRA.Size = new System.Drawing.Size(124, 22);
            this.txtIDCOMRA.TabIndex = 43;
            // 
            // lbCOMPRA
            // 
            this.lbCOMPRA.AccessibleRole = System.Windows.Forms.AccessibleRole.PageTabList;
            this.lbCOMPRA.AutoEllipsis = true;
            this.lbCOMPRA.AutoSize = true;
            this.lbCOMPRA.Location = new System.Drawing.Point(389, 160);
            this.lbCOMPRA.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCOMPRA.Name = "lbCOMPRA";
            this.lbCOMPRA.Size = new System.Drawing.Size(81, 16);
            this.lbCOMPRA.TabIndex = 42;
            this.lbCOMPRA.Text = "ID COMPRA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(303, 90);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(353, 16);
            this.label2.TabIndex = 41;
            this.label2.Text = "INGRESE EL ID DE LA COMPRA QUE DESEA ELIMINAR ";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(496, 233);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(105, 57);
            this.button2.TabIndex = 44;
            this.button2.Text = "ELIMINAR COMPRA";
            this.button2.UseVisualStyleBackColor = true;
           
            // 
            // txtCompras
            // 
            this.txtCompras.Location = new System.Drawing.Point(838, 117);
            this.txtCompras.Margin = new System.Windows.Forms.Padding(4);
            this.txtCompras.Name = "txtCompras";
            this.txtCompras.Size = new System.Drawing.Size(124, 22);
            this.txtCompras.TabIndex = 53;
            
            // 
            // txtFechaCompra
            // 
            this.txtFechaCompra.Location = new System.Drawing.Point(838, 297);
            this.txtFechaCompra.Margin = new System.Windows.Forms.Padding(4);
            this.txtFechaCompra.Name = "txtFechaCompra";
            this.txtFechaCompra.Size = new System.Drawing.Size(124, 22);
            this.txtFechaCompra.TabIndex = 52;
          
            // 
            // txtIDProducto
            // 
            this.txtIDProducto.Location = new System.Drawing.Point(838, 238);
            this.txtIDProducto.Margin = new System.Windows.Forms.Padding(4);
            this.txtIDProducto.Name = "txtIDProducto";
            this.txtIDProducto.Size = new System.Drawing.Size(124, 22);
            this.txtIDProducto.TabIndex = 51;
            
            // 
            // txtidCliente
            // 
            this.txtidCliente.Location = new System.Drawing.Point(838, 180);
            this.txtidCliente.Margin = new System.Windows.Forms.Padding(4);
            this.txtidCliente.Name = "txtidCliente";
            this.txtidCliente.Size = new System.Drawing.Size(124, 22);
            this.txtidCliente.TabIndex = 50;
            
            // 
            // lbCompra1
            // 
            this.lbCompra1.AutoSize = true;
            this.lbCompra1.Location = new System.Drawing.Point(743, 117);
            this.lbCompra1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCompra1.Name = "lbCompra1";
            this.lbCompra1.Size = new System.Drawing.Size(81, 16);
            this.lbCompra1.TabIndex = 48;
            this.lbCompra1.Text = "ID COMPRA";
            // 
            // lbFechaCompra
            // 
            this.lbFechaCompra.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.lbFechaCompra.AutoSize = true;
            this.lbFechaCompra.Location = new System.Drawing.Point(712, 297);
            this.lbFechaCompra.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbFechaCompra.Name = "lbFechaCompra";
            this.lbFechaCompra.Size = new System.Drawing.Size(113, 16);
            this.lbFechaCompra.TabIndex = 47;
            this.lbFechaCompra.Text = "FECHA COMPRA";
          
            // 
            // lbIDProcto
            // 
            this.lbIDProcto.AutoSize = true;
            this.lbIDProcto.Location = new System.Drawing.Point(725, 238);
            this.lbIDProcto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbIDProcto.Name = "lbIDProcto";
            this.lbIDProcto.Size = new System.Drawing.Size(100, 16);
            this.lbIDProcto.TabIndex = 46;
            this.lbIDProcto.Text = "ID PRODUCTO";
         
            // 
            // lbIDCliente
            // 
            this.lbIDCliente.AutoSize = true;
            this.lbIDCliente.Location = new System.Drawing.Point(743, 180);
            this.lbIDCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbIDCliente.Name = "lbIDCliente";
            this.lbIDCliente.Size = new System.Drawing.Size(79, 16);
            this.lbIDCliente.TabIndex = 45;
            this.lbIDCliente.Text = "ID CLIENTE";
            this.lbIDCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(838, 393);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(105, 57);
            this.button3.TabIndex = 54;
            this.button3.Text = "INSERTAR COMPRA";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Compras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 491);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.txtCompras);
            this.Controls.Add(this.txtFechaCompra);
            this.Controls.Add(this.txtIDProducto);
            this.Controls.Add(this.txtidCliente);
            this.Controls.Add(this.lbCompra1);
            this.Controls.Add(this.lbFechaCompra);
            this.Controls.Add(this.lbIDProcto);
            this.Controls.Add(this.lbIDCliente);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtIDCOMRA);
            this.Controls.Add(this.lbCOMPRA);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbCompras);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Compras";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbCompras;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmIDCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmIDCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmIDProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFechaCompra;
        private System.Windows.Forms.TextBox txtIDCOMRA;
        private System.Windows.Forms.Label lbCOMPRA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtCompras;
        private System.Windows.Forms.TextBox txtFechaCompra;
        private System.Windows.Forms.TextBox txtIDProducto;
        private System.Windows.Forms.TextBox txtidCliente;
        private System.Windows.Forms.Label lbCompra1;
        private System.Windows.Forms.Label lbFechaCompra;
        private System.Windows.Forms.Label lbIDProcto;
        private System.Windows.Forms.Label lbIDCliente;
        private System.Windows.Forms.Button button3;
    }
}