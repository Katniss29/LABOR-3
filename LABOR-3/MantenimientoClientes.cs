using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using capaNegocio;
using capaDatos;
using Npgsql;

namespace LABOR_3
{
    public partial class MantenimientoClientes : Form
    {
        public MantenimientoClientes()
        {
            InitializeComponent();
        }

        private void MantenimientoClientes_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            VentanaPrincipal oVentanaPrincipal = new VentanaPrincipal();
            oVentanaPrincipal.Show();
        }

        public void cargarGridDatosEstudiantes(DataTable informacionEstudiantes)
        {
            dataGridView1.Rows.Clear();
            for (int i = 0; i < informacionEstudiantes.Rows.Count; i++)
            {
                int indice = dataGridView1.Rows.Add();
                dataGridView1.Rows[indice].Cells[0].Value = informacionEstudiantes.Rows[i]["Cedula"];
                dataGridView1.Rows[indice].Cells[1].Value = informacionEstudiantes.Rows[i]["Nombre"];
                dataGridView1.Rows[indice].Cells[2].Value = informacionEstudiantes.Rows[i]["Apellido"];
                dataGridView1.Rows[indice].Cells[3].Value = informacionEstudiantes.Rows[i]["Sexo"];
                dataGridView1.Rows[indice].Cells[4].Value = informacionEstudiantes.Rows[i]["FechaNacimiento"];
            }
        }
        public void refrescar()
        {
            String[] datos = {  "Cedula", "Nombre", "Apellido", "Sexo", "FechaNacimiento" };
            DataTable informacionEstudiante = NEGOCIO.consultarTodosElementos("clientes", datos);
            cargarGridDatosEstudiantes(informacionEstudiante);
        }

        private void btnMostrarClientes_Click(object sender, EventArgs e)
        {
            refrescar();
        }

        public bool validacionDeDatos()
        {
            bool datosCorrectos = true;
            if (txtCodigo.Text == String.Empty)
            {
                datosCorrectos = false;

            }
            else if (txtCedula.Text == String.Empty)
            {
                datosCorrectos = false;
            }
            else if (txtNombre.Text == String.Empty)
            {
                datosCorrectos = false;
            }
            
            else if (txtApellido.Text == String.Empty)
            {
                datosCorrectos = false;
            }
            else if (txtSexo.Text == String.Empty)
            {
                datosCorrectos = false;
            }
            else if (txtFecha.Text == String.Empty)
            {
                datosCorrectos = false;
            }
           

            return datosCorrectos;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            CONEXIO.conectarPostgresSQL();

            String modificar = "update clientes set cedula = "+txtCedula.Text+",nombre = '" + txtNombre.Text + "', " +
                " apellido = '" + txtApellido.Text +  
                "sexo  = " + txtSexo.Text + ", fechanacimiento = " + txtFecha.Text + "'where cedula = " + txtCedula.Text + "";
            NpgsqlCommand comando = new NpgsqlCommand(modificar, CONEXIO.conexion);
            int cantidad;
            cantidad = comando.ExecuteNonQuery();
            if (cantidad > 0)
            {
                MessageBox.Show("REGISTRO MODIFICADO");
            }

            limpiarDatos();

            CONEXIO.desconectarPostgresSQL();

        }

        public void limpiarDatos()
        {
            txtCedula.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtSexo.Text = "";
            txtFecha.Text = "";
        }
    }
}
