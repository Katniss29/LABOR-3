namespace LABOR_3
{
    partial class VentanaCatalogo
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
            this.button1 = new System.Windows.Forms.Button();
            this.clmIdProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmlPrecios = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbCatalogo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmIdProducto,
            this.clmDescripcion,
            this.cmlPrecios});
            this.dataGridView1.Location = new System.Drawing.Point(174, 128);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(429, 163);
            this.dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(292, 360);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 51);
            this.button1.TabIndex = 1;
            this.button1.Text = "MOSTRAR CATALOGOS";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // clmIdProducto
            // 
            this.clmIdProducto.HeaderText = "ID PRODUCTO";
            this.clmIdProducto.MinimumWidth = 6;
            this.clmIdProducto.Name = "clmIdProducto";
            this.clmIdProducto.Width = 125;
            // 
            // clmDescripcion
            // 
            this.clmDescripcion.HeaderText = "DESCRIPCION";
            this.clmDescripcion.MinimumWidth = 6;
            this.clmDescripcion.Name = "clmDescripcion";
            this.clmDescripcion.Width = 125;
            // 
            // cmlPrecios
            // 
            this.cmlPrecios.HeaderText = "PRECIO";
            this.cmlPrecios.MinimumWidth = 6;
            this.cmlPrecios.Name = "cmlPrecios";
            this.cmlPrecios.Width = 125;
            // 
            // lbCatalogo
            // 
            this.lbCatalogo.AutoSize = true;
            this.lbCatalogo.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCatalogo.Location = new System.Drawing.Point(308, 9);
            this.lbCatalogo.Name = "lbCatalogo";
            this.lbCatalogo.Size = new System.Drawing.Size(193, 19);
            this.lbCatalogo.TabIndex = 2;
            this.lbCatalogo.Text = "CATALOGO PRODUCTOS";
            // 
            // VentanaCatalogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbCatalogo);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "VentanaCatalogo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmIdProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmlPrecios;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbCatalogo;
    }
}