using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace DatosLayer // Define un espacio de nombres llamado DatosLayer.
{
    public class CustomerRepository // Define una clase llamada CustomerRepository que maneja operaciones relacionadas con la entidad Customers.
    {
        // Método para obtener todos los registros de la tabla Customers.
        public List<Customers> ObtenerTodos()
        {
            using (var conexion = DataBase.GetSqlConnection())
            { // Abre una conexión a la base de datos usando un método estático GetSqlConnection().
                String selectFrom = ""; // Inicializa una cadena vacía para construir la consulta SQL.
                selectFrom = selectFrom + "SELECT [CustomerID] " + "\n"; // Agrega las columnas a la cadena de consulta SQL.
                selectFrom = selectFrom + "      ,[CompanyName] " + "\n";
                selectFrom = selectFrom + "      ,[ContactName] " + "\n";
                selectFrom = selectFrom + "      ,[ContactTitle] " + "\n";
                selectFrom = selectFrom + "      ,[Address] " + "\n";
                selectFrom = selectFrom + "      ,[City] " + "\n";
                selectFrom = selectFrom + "      ,[Region] " + "\n";
                selectFrom = selectFrom + "      ,[PostalCode] " + "\n";
                selectFrom = selectFrom + "      ,[Country] " + "\n";
                selectFrom = selectFrom + "      ,[Phone] " + "\n";
                selectFrom = selectFrom + "      ,[Fax] " + "\n";
                selectFrom = selectFrom + "  FROM [dbo].[Customers]"; // Finaliza la cadena de consulta SQL.

                using (SqlCommand comando = new SqlCommand(selectFrom, conexion))
                { // Crea un objeto SqlCommand para ejecutar la consulta SQL.
                    SqlDataReader reader = comando.ExecuteReader(); // Ejecuta la consulta y obtiene un SqlDataReader para leer los resultados.
                    List<Customers> Customers = new List<Customers>(); // Crea una lista de objetos Customers para almacenar los resultados.

                    while (reader.Read()) // Itera sobre cada fila devuelta por la consulta.
                    {
                        var customers = LeerDelDataReader(reader); // Llama al método LeerDelDataReader para mapear los datos del reader al objeto Customers.
                        Customers.Add(customers); // Agrega el objeto Customers a la lista.
                    }
                    return Customers; // Devuelve la lista de Customers.
                }
            }
        }

        // Método para obtener un cliente específico por su ID.
        public Customers ObtenerPorID(string id)
        {
            using (var conexion = DataBase.GetSqlConnection())
            { // Abre una conexión a la base de datos.
                String selectForID = ""; // Inicializa una cadena vacía para construir la consulta SQL.
                selectForID = selectForID + "SELECT [CustomerID] " + "\n"; // Agrega las columnas a la cadena de consulta SQL.
                selectForID = selectForID + "      ,[CompanyName] " + "\n";
                selectForID = selectForID + "      ,[ContactName] " + "\n";
                selectForID = selectForID + "      ,[ContactTitle] " + "\n";
                selectForID = selectForID + "      ,[Address] " + "\n";
                selectForID = selectForID + "      ,[City] " + "\n";
                selectForID = selectForID + "      ,[Region] " + "\n";
                selectForID = selectForID + "      ,[PostalCode] " + "\n";
                selectForID = selectForID + "      ,[Country] " + "\n";
                selectForID = selectForID + "      ,[Phone] " + "\n";
                selectForID = selectForID + "      ,[Fax] " + "\n";
                selectForID = selectForID + "  FROM [dbo].[Customers] " + "\n";
                selectForID = selectForID + $"  Where CustomerID = @customerId"; // Agrega la cláusula WHERE para filtrar por CustomerID.

                using (SqlCommand comando = new SqlCommand(selectForID, conexion))
                { // Crea un objeto SqlCommand para ejecutar la consulta SQL.
                    comando.Parameters.AddWithValue("customerId", id); // Añade el parámetro CustomerID a la consulta SQL.

                    var reader = comando.ExecuteReader(); // Ejecuta la consulta y obtiene un SqlDataReader para leer los resultados.
                    Customers customers = null; // Inicializa un objeto Customers.
                    if (reader.Read())
                    { // Si hay resultados, lee el primer resultado.
                        customers = LeerDelDataReader(reader); // Mapea los datos del reader al objeto Customers.
                    }
                    return customers; // Devuelve el objeto Customers.
                }
            }
        }

        // Método que mapea los datos de un SqlDataReader al objeto Customers.
        public Customers LeerDelDataReader(SqlDataReader reader)
        {
            Customers customers = new Customers(); // Crea un nuevo objeto Customers.
            customers.CustomerID = reader["CustomerID"] == DBNull.Value ? " " : (String)reader["CustomerID"]; // Asigna el valor de CustomerID.
            customers.CompanyName = reader["CompanyName"] == DBNull.Value ? "" : (String)reader["CompanyName"]; // Asigna el valor de CompanyName.
            customers.ContactName = reader["ContactName"] == DBNull.Value ? "" : (String)reader["ContactName"]; // Asigna el valor de ContactName.
            customers.ContactTitle = reader["ContactTitle"] == DBNull.Value ? "" : (String)reader["ContactTitle"]; // Asigna el valor de ContactTitle.
            customers.Address = reader["Address"] == DBNull.Value ? "" : (String)reader["Address"]; // Asigna el valor de Address.
            customers.City = reader["City"] == DBNull.Value ? "" : (String)reader["City"]; // Asigna el valor de City.
            customers.Region = reader["Region"] == DBNull.Value ? "" : (String)reader["Region"]; // Asigna el valor de Region.
            customers.PostalCode = reader["PostalCode"] == DBNull.Value ? "" : (String)reader["PostalCode"]; // Asigna el valor de PostalCode.
            customers.Country = reader["Country"] == DBNull.Value ? "" : (String)reader["Country"]; // Asigna el valor de Country.
            customers.Phone = reader["Phone"] == DBNull.Value ? "" : (String)reader["Phone"]; // Asigna el valor de Phone.
            customers.Fax = reader["Fax"] == DBNull.Value ? "" : (String)reader["Fax"]; // Asigna el valor de Fax.
            return customers; // Devuelve el objeto Customers.
        }

        // Método para insertar un nuevo cliente en la base de datos.
        public int InsertarCliente(Customers customer)
        {
            using (var conexion = DataBase.GetSqlConnection())
            { // Abre una conexión a la base de datos.
                String insertInto = ""; // Inicializa una cadena vacía para construir la consulta SQL.
                insertInto = insertInto + "INSERT INTO [dbo].[Customers] " + "\n"; // Agrega la cláusula INSERT a la cadena de consulta SQL.
                insertInto = insertInto + "           ([CustomerID] " + "\n";
                insertInto = insertInto + "           ,[CompanyName] " + "\n";
                insertInto = insertInto + "           ,[ContactName] " + "\n";
                insertInto = insertInto + "           ,[ContactTitle] " + "\n";
                insertInto = insertInto + "           ,[Address] " + "\n";
                insertInto = insertInto + "           ,[City]) " + "\n";
                insertInto = insertInto + "     VALUES " + "\n"; // Agrega la cláusula VALUES a la cadena de consulta SQL.
                insertInto = insertInto + "           (@CustomerID " + "\n";
                insertInto = insertInto + "           ,@CompanyName " + "\n";
                insertInto = insertInto + "           ,@ContactName " + "\n";
                insertInto = insertInto + "           ,@ContactTitle " + "\n";
                insertInto = insertInto + "           ,@Address " + "\n";
                insertInto = insertInto + "           ,@City)";

                using (var comando = new SqlCommand(insertInto, conexion))
                { // Crea un objeto SqlCommand para ejecutar la consulta SQL.
                    int insertados = parametrosCliente(customer, comando); // Llama al método que configura los parámetros y ejecuta la consulta.
                    return insertados; // Devuelve el número de registros insertados.
                }
            }
        }

        // Método para actualizar un cliente existente en la base de datos.
        public int ActualizarCliente(Customers customer)
        {
            using (var conexion = DataBase.GetSqlConnection())
            { // Abre una conexión a la base de datos.
                String ActualizarCustomerPorID = ""; // Inicializa una cadena vacía para construir la consulta SQL.
                ActualizarCustomerPorID = ActualizarCustomerPorID + "UPDATE [dbo].[Customers] " + "\n"; // Agrega la cláusula UPDATE a la cadena de consulta SQL.
                ActualizarCustomerPorID = ActualizarCustomerPorID + "   SET [CustomerID] = @CustomerID " + "\n";
                ActualizarCustomerPorID = ActualizarCustomerPorID + "      ,[CompanyName] = @CompanyName " + "\n";
                ActualizarCustomerPorID = ActualizarCustomerPorID + "      ,[ContactName] = @ContactName " + "\n";
                ActualizarCustomerPorID = ActualizarCustomerPorID + "      ,[ContactTitle] = @ContactTitle " + "\n";
                ActualizarCustomerPorID = ActualizarCustomerPorID + "      ,[Address] = @Address " + "\n";
                ActualizarCustomerPorID = ActualizarCustomerPorID + "      ,[City] = @City " + "\n";
                ActualizarCustomerPorID = ActualizarCustomerPorID + " WHERE CustomerID= @CustomerID"; // Agrega la cláusula WHERE para filtrar por CustomerID.

                using (var comando = new SqlCommand(ActualizarCustomerPorID, conexion))
                { // Crea un objeto SqlCommand para ejecutar la consulta SQL.
                    int actualizados = parametrosCliente(customer, comando); // Llama al método que configura los parámetros y ejecuta la consulta.
                    return actualizados; // Devuelve el número de registros actualizados.
                }
            }
        }

        // Método que configura los parámetros SQL para una consulta y la ejecuta.
        public int parametrosCliente(Customers customer, SqlCommand comando)
        {
            comando.Parameters.AddWithValue("CustomerID", customer.CustomerID); // Añade el parámetro CustomerID a la consulta SQL.
            comando.Parameters.AddWithValue("CompanyName", customer.CompanyName); // Añade el parámetro CompanyName a la consulta SQL.
            comando.Parameters.AddWithValue("ContactName", customer.ContactName); // Añade el parámetro ContactName a la consulta SQL.
            comando.Parameters.AddWithValue("ContactTitle", customer.ContactName); // Añade el parámetro ContactTitle a la consulta SQL.
            comando.Parameters.AddWithValue("Address", customer.Address); // Añade el parámetro Address a la consulta SQL.
            comando.Parameters.AddWithValue("City", customer.City); // Añade el parámetro City a la consulta SQL.
            var insertados = comando.ExecuteNonQuery(); // Ejecuta la consulta y obtiene el número de registros afectados.
            return insertados; // Devuelve el número de registros afectados.
        }

        // Método para eliminar un cliente por su ID.
        public int EliminarCliente(string id)
        {
            using (var conexion = DataBase.GetSqlConnection())
            { // Abre una conexión a la base de datos.
                String EliminarCliente = ""; // Inicializa una cadena vacía para construir la consulta SQL.
                EliminarCliente = EliminarCliente + "DELETE FROM [dbo].[Customers] " + "\n"; // Agrega la cláusula DELETE a la cadena de consulta SQL.
                EliminarCliente = EliminarCliente + "      WHERE CustomerID = @CustomerID"; // Agrega la cláusula WHERE para filtrar por CustomerID.

                using (SqlCommand comando = new SqlCommand(EliminarCliente, conexion))
                { // Crea un objeto SqlCommand para ejecutar la consulta SQL.
                    comando.Parameters.AddWithValue("@CustomerID", id); // Añade el parámetro CustomerID a la consulta SQL.
                    int elimindos = comando.ExecuteNonQuery(); // Ejecuta la consulta y obtiene el número de registros eliminados.
                    return elimindos; // Devuelve el número de registros eliminados.
                }
            }
        }
    }
}
