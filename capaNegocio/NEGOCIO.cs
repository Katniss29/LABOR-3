using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using capaDatos;

namespace capaNegocio
{
    public class NEGOCIO
    {
        public static List<Clientes> listClientes;

        public NEGOCIO()
        {

           listClientes = new List<Clientes>();
        }
        public List<Clientes> ListaClientes
        {
            get { return listClientes; }
            set { listClientes = value; }
        }

        public void cargarListaClientes(Clientes c)
        {
            ListaClientes.Add(c);
        }

        public static DataTable consultarTodosElementos(String table, String[] datos)
            {
                String campo = "SELECT ";

                for (int i = 0; i < datos.Length; i++)
                {
                    campo += "\"" + datos[i] + "\"";
                    if (i != datos.Length - 1)
                    {
                        campo += ",";
                    }
                }
                campo += " FROM \"" + table + "\"";
                String query = campo;
                DataTable resultado = CONEXIO.consultarUnDato(query);
                return resultado;
            }

        public void cargarXML()
        {
            try
            {
                //Raiz del documento
                XmlDocument documento = new XmlDocument();
                XmlElement raiz = documento.CreateElement("Clientes");
                documento.AppendChild(raiz);

                for (int i = 0; i < listClientes.Count; i++)
                {
                    
                    XmlElement cliente = documento.CreateElement("Cliente");
                    raiz.AppendChild(cliente);

                    
                    XmlElement codigo = documento.CreateElement("codigo");
                    codigo.AppendChild(documento.CreateTextNode(listClientes.ElementAt(i).codigo.ToString()));
                    cliente.AppendChild(codigo);

                    XmlElement cedula = documento.CreateElement("cedula");
                    cedula.AppendChild(documento.CreateTextNode(listClientes.ElementAt(i).cedula.ToString()));
                    cliente.AppendChild(cedula);

                    XmlElement nombre = documento.CreateElement("nombre");
                    nombre.AppendChild(documento.CreateTextNode(listClientes.ElementAt(i).nombre.ToString()));
                    cliente.AppendChild(nombre);


                    XmlElement apellido = documento.CreateElement("apellido");
                    apellido.AppendChild(documento.CreateTextNode(listClientes.ElementAt(i).apellido.ToString()));
                    cliente.AppendChild(apellido);

                    XmlElement sexo = documento.CreateElement("sexo");
                    sexo.AppendChild(documento.CreateTextNode(listClientes.ElementAt(i).sexo.ToString()));
                    cliente.AppendChild(sexo);

                    XmlElement fechaNacimiento = documento.CreateElement("FechaNacimiento");
                    fechaNacimiento.AppendChild(documento.CreateTextNode(listClientes.ElementAt(i).fechaNacimiento.ToString()));
                    cliente.AppendChild(fechaNacimiento);

                    

                }
                documento.Save("Clientes.xml");

                

            }
            catch (Exception)
            {
               
            }

        }



    }
}
