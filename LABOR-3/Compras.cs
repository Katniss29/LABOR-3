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
    public partial class Compras : Form
    {
        public Compras()
        {
            InitializeComponent();
        }
        public void cargarGridDatosEstudiantes(DataTable informacionEstudiantes)
        {
            dataGridView1.Rows.Clear();
            for (int i = 0; i < informacionEstudiantes.Rows.Count; i++)
            {
                int indice = dataGridView1.Rows.Add();
                dataGridView1.Rows[indice].Cells[0].Value = informacionEstudiantes.Rows[i]["idcompra"];
                dataGridView1.Rows[indice].Cells[1].Value = informacionEstudiantes.Rows[i]["idclientes"];
                dataGridView1.Rows[indice].Cells[2].Value = informacionEstudiantes.Rows[i]["idproducto"];
                dataGridView1.Rows[indice].Cells[3].Value = informacionEstudiantes.Rows[i]["fechacompra"];

            }
        }

        public void refrescar()
        {
            String[] datos = { "idcompra", "idcientes", "idproducto", "fechacompra" };
            DataTable informacionEstudiante = NEGOCIO.consultarTodosElementos("compras", datos);
            cargarGridDatosEstudiantes(informacionEstudiante);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            refrescar();
        }

    
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (validacionDeDatos() == true)
                {
                    String cadena = "INSERT INTO COMPRA (IDCOMPRA,IDCLIENTE,IDPRODUCTO,FECHACOMPRA) " +
                                  "VALUES('" + txtIDCOMRA.Text + "', '" + txtidCliente.Text + "', '" + txtIDProducto.Text + "','" + txtFechaCompra.Text + "')";
                    CONEXIO.conectarPostgresSQL();
                    NpgsqlCommand comando = new NpgsqlCommand(cadena, CONEXIO.conexion);
                    comando.ExecuteNonQuery();
                    MessageBox.Show("LA COMPRA SE HA AGREGADO CORRECTAMENTE");

                    limpiarDatos();

                    refrescar();
                    CONEXIO.desconectarPostgresSQL();

                    MessageBox.Show("Compra insertado con exito");
                }
                else
                {
                    MessageBox.Show("Error, ingrese los datos correctos");
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Error, la compra no se a logrado guardar");
            }


        }

        public bool validacionDeDatos()
        {
            bool datosCorrectos = true;


            if (txtIDCOMRA.Text == String.Empty)
            {
                datosCorrectos = false;
            }
            else if (txtidCliente.Text == String.Empty)
            {
                datosCorrectos = false;
            }

            else if (txtIDProducto.Text == String.Empty)
            {
                datosCorrectos = false;
            }
            else if (txtFechaCompra.Text == String.Empty)
            {
                datosCorrectos = false;
            }
            


            return datosCorrectos;
        }

        public void limpiarDatos()
        {
            txtIDCOMRA.Text = "";
            txtidCliente.Text = "";
            txtIDProducto.Text = "";
            txtFechaCompra.Text = "";
            
        }
    }
}
