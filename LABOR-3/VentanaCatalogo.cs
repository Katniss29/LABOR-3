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

namespace LABOR_3
{
    public partial class VentanaCatalogo : Form
    {
        public VentanaCatalogo()
        {
            InitializeComponent();
        }
        public void cargarGridDatosEstudiantes(DataTable informacionEstudiantes)
        {
            dataGridView1.Rows.Clear();
            for (int i = 0; i < informacionEstudiantes.Rows.Count; i++)
            {
                int indice = dataGridView1.Rows.Add();
                dataGridView1.Rows[indice].Cells[0].Value = informacionEstudiantes.Rows[i]["idproducto"];
                dataGridView1.Rows[indice].Cells[1].Value = informacionEstudiantes.Rows[i]["descripcion"];
                dataGridView1.Rows[indice].Cells[2].Value = informacionEstudiantes.Rows[i]["precio"];
               
            }
        }

        public void refrescar()
        {
            String[] datos = { "idproducto", "descripcion", "precio" };
            DataTable informacionEstudiante = NEGOCIO.consultarTodosElementos("productos", datos);
            cargarGridDatosEstudiantes(informacionEstudiante);
        }



        private void button1_Click(object sender, EventArgs e)
        {
            refrescar();
        }
    }
}
