using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataSourceDemo // Define un espacio de nombres llamado DataSourceDemo.
{
    public partial class Form2 : Form // Define una clase parcial llamada Form2 que hereda de la clase Form de Windows Forms.
    {
        public Form2() // Constructor de la clase Form2.
        {
            InitializeComponent(); // Método que inicializa los componentes del formulario (generado automáticamente).
        }

        private void customersBindingNavigatorSaveItem_Click(object sender, EventArgs e) // Evento click para el botón guardar del navegador de binding.
        {
            this.Validate(); // Valida los datos del formulario.
            this.customersBindingSource.EndEdit(); // Finaliza la edición del BindingSource llamado customersBindingSource.
            this.tableAdapterManager.UpdateAll(this.northwindDataSet); // Guarda los cambios en el DataSet llamado northwindDataSet.

        }

        private void Form2_Load(object sender, EventArgs e) // Evento que se ejecuta cuando el formulario se carga.
        {
            this.customersTableAdapter.Fill(this.northwindDataSet.Customers); // Rellena el DataSet northwindDataSet con datos de la tabla Customers.
        }

        private void cajaTextoID_KeyPress(object sender, KeyPressEventArgs e) // Evento que se activa al presionar una tecla en el control de texto (cajaTextoID).
        {
            if (e.KeyChar == (char)13)
            { // Comprueba si la tecla presionada es Enter (código de carácter 13).
                var index = customersBindingSource.Find("customerID", cajaTextoID); // Busca el índice del elemento cuyo campo "customerID" coincide con el valor de cajaTextoID.
                if (index > -1) // Si se encuentra el elemento (índice mayor que -1).
                {
                    customersBindingSource.Position = index; // Establece la posición del BindingSource en el índice encontrado.
                    return; // Termina la ejecución del método.
                }
                else
                { // Si no se encuentra el elemento.
                    MessageBox.Show("Elemento no encontrado"); // Muestra un mensaje indicando que no se encontró el elemento.
                }
            };
        }
    }
}