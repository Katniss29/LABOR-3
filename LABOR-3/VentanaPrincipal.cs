using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LABOR_3
{
    public partial class VentanaPrincipal : Form
    {
        public VentanaPrincipal()
        {
            InitializeComponent();
        }


        private void btnMantenimientoClientes_Click(object sender, EventArgs e)
        {
            this.Hide();
            MantenimientoClientes oMantenimientoClientes = new MantenimientoClientes();
            oMantenimientoClientes.Show();
        }

        private void btnCatalogo_Click(object sender, EventArgs e)
        {
            this.Hide();
            VentanaCatalogo oVentanaCatalogo = new VentanaCatalogo();
            oVentanaCatalogo.Show();
        }
    }
}
