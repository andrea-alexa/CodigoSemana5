using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using DatosLayer;
using System.Net;
using System.Reflection;

namespace ConexionEjemplo // Define el espacio de nombres para el proyecto.
{
    public partial class Form1 : Form // Define la clase Form1 que hereda de Form, representando una ventana de la aplicación.
    {
        CustomerRepository customerRepository = new CustomerRepository(); // Instancia de CustomerRepository para interactuar con la base de datos.

        public Form1()
        {
            InitializeComponent(); // Inicializa los componentes del formulario (botones, cuadros de texto, etc.).
        }

        // Evento que se ejecuta al hacer clic en el botón btnCargar.
        private void btnCargar_Click(object sender, EventArgs e)
        {
            var Customers = customerRepository.ObtenerTodos(); // Obtiene todos los clientes de la base de datos.
            dataGrid.DataSource = Customers; // Establece la fuente de datos del DataGrid con la lista de clientes obtenidos.
        }

        // Evento que se ejecuta al cambiar el texto en textBox1 (filtro).
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Filtrado de la lista de clientes según el texto ingresado en tbFiltro.
            // var filtro = Customers.FindAll( X => X.CompanyName.StartsWith(tbFiltro.Text));
            // dataGrid.DataSource = filtro;
        }

        // Evento que se ejecuta cuando se carga el formulario.
        private void Form1_Load(object sender, EventArgs e)
        {
            // Configuraciones adicionales de la base de datos o inicialización del formulario.
            /*
            DatosLayer.DataBase.ApplicationName = "Programacion 2 ejemplo";
            DatosLayer.DataBase.ConnectionTimeout = 30;

            string cadenaConexion = DatosLayer.DataBase.ConnectionString;
            var conxion = DatosLayer.DataBase.GetSqlConnection();
            */
        }

        // Evento que se ejecuta al hacer clic en el botón btnBuscar.
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            var cliente = customerRepository.ObtenerPorID(txtBuscar.Text); // Busca un cliente por su ID.
            // Rellena los campos del formulario con la información del cliente encontrado.
            tboxCustomerID.Text = cliente.CustomerID;
            tboxCompanyName.Text = cliente.CompanyName;
            tboxContacName.Text = cliente.ContactName;
            tboxContactTitle.Text = cliente.ContactTitle;
            tboxAddress.Text = cliente.Address;
            tboxCity.Text = cliente.City;
        }

        // Evento que se ejecuta al hacer clic en el botón btnInsertar.
        private void btnInsertar_Click(object sender, EventArgs e)
        {
            var resultado = 0;

            var nuevoCliente = ObtenerNuevoCliente(); // Crea un nuevo cliente a partir de los datos ingresados en los campos de texto.

            // Validación de campos nulos antes de insertar el cliente.
            /*
            if (nuevoCliente.CustomerID == "") {
                MessageBox.Show("El Id en el usuario debe de completarse");
                return;    
            }

            if (nuevoCliente.ContactName == "")
            {
                MessageBox.Show("El nombre de usuario debe de completarse");
                return;
            }
            
            if (nuevoCliente.ContactTitle == "")
            {
                MessageBox.Show("El contacto de usuario debe de completarse");
                return;
            }
            if (nuevoCliente.Address == "")
            {
                MessageBox.Show("la direccion de usuario debe de completarse");
                return;
            }
            if (nuevoCliente.City == "")
            {
                MessageBox.Show("La ciudad de usuario debe de completarse");
                return;
            }
            */

            // Inserta el cliente si todos los campos son válidos (no nulos).
            if (validarCampoNull(nuevoCliente) == false)
            {
                resultado = customerRepository.InsertarCliente(nuevoCliente); // Inserta el nuevo cliente en la base de datos.
                MessageBox.Show("Guardado" + "Filas modificadas = " + resultado); // Muestra un mensaje con el número de filas modificadas.
            }
            else
            {
                MessageBox.Show("Debe completar los campos por favor"); // Muestra un mensaje si hay campos vacíos.
            }
        }

        // Método para validar si algún campo del objeto cliente es nulo o vacío.
        public Boolean validarCampoNull(Object objeto)
        {
            foreach (PropertyInfo property in objeto.GetType().GetProperties()) // Itera sobre todas las propiedades del objeto.
            {
                object value = property.GetValue(objeto, null); // Obtiene el valor de la propiedad.
                if ((string)value == "") // Comprueba si el valor es una cadena vacía.
                {
                    return true; // Devuelve true si hay un campo vacío.
                }
            }
            return false; // Devuelve false si todos los campos están llenos.
        }

        // Evento que se ejecuta al hacer clic en el botón btModificar.
        private void btModificar_Click(object sender, EventArgs e)
        {
            var actualizarCliente = ObtenerNuevoCliente(); // Crea un cliente con los datos ingresados en los campos de texto.
            int actualizadas = customerRepository.ActualizarCliente(actualizarCliente); // Actualiza el cliente en la base de datos.
            MessageBox.Show($"Filas actualizadas = {actualizadas}"); // Muestra un mensaje con el número de filas actualizadas.
        }

        // Método para obtener un nuevo cliente a partir de los datos ingresados en los campos de texto.
        private Customers ObtenerNuevoCliente()
        {
            var nuevoCliente = new Customers
            {
                CustomerID = tboxCustomerID.Text,
                CompanyName = tboxCompanyName.Text,
                ContactName = tboxContacName.Text,
                ContactTitle = tboxContactTitle.Text,
                Address = tboxAddress.Text,
                City = tboxCity.Text
            };

            return nuevoCliente; // Devuelve el nuevo cliente creado.
        }

        // Evento que se ejecuta al hacer clic en el botón btnEliminar.
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int elimindas = customerRepository.EliminarCliente(tboxCustomerID.Text); // Elimina el cliente de la base de datos.
            MessageBox.Show("Filas eliminadas = " + elimindas); // Muestra un mensaje con el número de filas eliminadas.
        }
    }
}