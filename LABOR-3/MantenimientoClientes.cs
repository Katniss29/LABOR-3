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
            
            
            if (txtCedula.Text == String.Empty)
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

        private void btnInsertarDatos_Click(object sender, EventArgs e)
        {
            try
            {
                if (validacionDeDatos() == true)
                {
                    String cadena = "INSERT INTO CLIENTES (CEDULA,NOMBRE,APELLIDO,SEXO,FECHANACIMIENTO) " +
                                  "VALUES('" + txtCedula.Text + "', '" + txtNombre.Text + "', '" + txtApellido.Text + "','" + txtSexo.Text + "','" + txtFecha.Text + "')";
                    CONEXIO.conectarPostgresSQL();
                    NpgsqlCommand comando = new NpgsqlCommand(cadena, CONEXIO.conexion);
                    comando.ExecuteNonQuery();
                    MessageBox.Show("EL MEDICAMENTO: " + txtNombre.Text + " SE HA AGREGADO CORRECTAMENTE");

                    limpiarDatos();

                    refrescar();
                    CONEXIO.desconectarPostgresSQL();

                    MessageBox.Show("Cliente insertado con exito");
                }
                else
                {
                    MessageBox.Show("Error, ingrese los datos correctos");
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Error, el cliente no se a logrado guardar");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                String eliminar = "delete from clientes where nombre = '" + txtNombreEliminar.Text + "'";
                CONEXIO.conectarPostgresSQL();
                NpgsqlCommand comando = new NpgsqlCommand(eliminar, CONEXIO.conexion);
                comando.ExecuteNonQuery();
                MessageBox.Show("MEDICAMENTO " + txtNombreEliminar.Text + " ELIMINADO");
                refrescar();
                CONEXIO.desconectarPostgresSQL();
            }
            catch (Exception)
            {
                MessageBox.Show("ERROR, NO SE LOGRO ELIMINAR EL CLIENTE");
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                NpgsqlConnection conexionBD = CONEXIO.conexion;
                conexionBD.Open();
                NpgsqlCommand comando = new NpgsqlCommand();
                comando.Connection = conexionBD;
                comando.CommandText = "select * from clientes  where cedula = " + txtCedukaBuscar.Text + "";
                NpgsqlDataReader leer = comando.ExecuteReader();
                if (leer.Read() == true)
                {
                    txtCedula.Text = leer["cedula"].ToString();
                    txtNombre.Text = leer["nombre"].ToString();
                    txtApellido.Text = leer["apellido"].ToString();
                    txtSexo.Text = leer["sexo"].ToString();
                    txtFecha.Text = leer["fechanacimiento"].ToString();
                    
                }
                else
                {
                    MessageBox.Show("El registro no existe");
                }

                CONEXIO.desconectarPostgresSQL();
            }
            catch (Exception)
            {

                MessageBox.Show("ERROR");
            }
        }
    }
}
