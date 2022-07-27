using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaDatos
{
    public  class Clientes
    {
        public int codigo;
        public String cedula;
        public String nombre;
        public String apellido;
        public String sexo;
        public String fechaNacimiento;

        public Clientes(int pCodigo, String pCedula, String pNombre, String pApellido, String pSexo,
                       String pFechaNaciento)
        {
            this.codigo = pCodigo;
            this.cedula = pCedula;
            this.nombre = pNombre;
            this.apellido = pApellido;
            this.sexo = pSexo;
            this.fechaNacimiento = pFechaNaciento;
        }

        public Clientes()
        {

        }

        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
        public String Cedula
        {
            get { return cedula; }
            set { cedula = value; }
        }

        public String Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public String Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }

        public String Sexo
        {
            get { return sexo; }
            set { sexo = value; }
        }

        public String FechaNacimiento
        {
            get { return fechaNacimiento; }
            set { fechaNacimiento = value; }
        }
    }
}
