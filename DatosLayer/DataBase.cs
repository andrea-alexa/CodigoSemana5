using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Xml.Linq;
using System.Data.SqlClient;
using System.Runtime.CompilerServices;

namespace DatosLayer // Define el espacio de nombres para el proyecto de acceso a datos.
{
    public class DataBase // Define la clase estática DataBase que gestiona las conexiones a la base de datos.
    {
        // Propiedad estática para obtener la cadena de conexión a la base de datos.
        public static string ConnectionString
        {
            get
            {
                // Obtiene la cadena de conexión desde el archivo de configuración (app.config o web.config).
                string CadenaConexion = ConfigurationManager
                    .ConnectionStrings["NWConnection"] // "NWConnection" es el nombre del string de conexión definido en el archivo de configuración.
                    .ConnectionString;

                // Crea un objeto SqlConnectionStringBuilder para manipular la cadena de conexión de manera más fácil.
                SqlConnectionStringBuilder conexionBuilder =
                    new SqlConnectionStringBuilder(CadenaConexion);

                // Establece el nombre de la aplicación si la propiedad ApplicationName tiene un valor.
                conexionBuilder.ApplicationName =
                    ApplicationName ?? conexionBuilder.ApplicationName;

                // Establece el tiempo de espera de conexión si ConnectionTimeout tiene un valor positivo.
                conexionBuilder.ConnectTimeout = (ConnectionTimeout > 0)
                    ? ConnectionTimeout : conexionBuilder.ConnectTimeout;

                // Devuelve la cadena de conexión modificada.
                return conexionBuilder.ToString();
            }
        }

        // Propiedad estática para establecer o obtener el tiempo de espera de conexión.
        public static int ConnectionTimeout { get; set; }

        // Propiedad estática para establecer o obtener el nombre de la aplicación.
        public static string ApplicationName { get; set; }

        // Método estático que devuelve una conexión SQL abierta.
        public static SqlConnection GetSqlConnection()
        {
            // Crea una nueva conexión SQL usando la cadena de conexión.
            SqlConnection conexion = new SqlConnection(ConnectionString);
            conexion.Open(); // Abre la conexión a la base de datos.
            return conexion; // Devuelve la conexión abierta.
        }
    }
}