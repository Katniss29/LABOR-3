using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace capaDatos
{
    public class CONEXIO
    {
        public static NpgsqlConnection conexion = new NpgsqlConnection("Server = localhost; User Id = postgres; Password = Admin12345; DataBase = LAB03");

        public static void conectarPostgresSQL()
        {
            conexion.Open();
            Console.WriteLine("Conexión a la base de datos");

        }
        public static void desconectarPostgresSQL()
        {
            conexion.Close();
            Console.WriteLine("Desconexion de la base de datos");
        }

        public static String insertarDatos(String tabla, String[] datos)
        {
            try
            {
                conectarPostgresSQL();
                String campo = "(";

                for (int i = 0; i < datos.Length; i++)
                {
                    campo += "'" + datos[i] + "'";
                    if (i != datos.Length - 1)
                    {
                        campo += ",";
                    }
                }
                campo += ")";
                String insertSQL = "Insert into \"" + tabla + "\" + values " + campo;
                NpgsqlCommand ejecutar = new NpgsqlCommand(insertSQL, conexion);
                ejecutar.ExecuteNonQuery();
                desconectarPostgresSQL();
            }
            catch (Exception)
            {
                return "Error";
                desconectarPostgresSQL();
            }
            return "ok";

        }

        public static DataTable consultarUnDato(String query)
        {
            try
            {
                NpgsqlCommand conector = new NpgsqlCommand(query, conexion);
                NpgsqlDataAdapter datos = new NpgsqlDataAdapter(conector);
                DataTable table = new DataTable();
                datos.Fill(table);
                desconectarPostgresSQL();
                return table;
            }
            catch (Exception)
            {
                return null;
            }

        }

    }


}

