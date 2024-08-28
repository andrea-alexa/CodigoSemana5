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
    public partial class Form1 : Form // Define una clase parcial llamada Form1 que hereda de la clase Form de Windows Forms.
    {
        public Form1() // Constructor de la clase Form1.
        {
            InitializeComponent(); // Método que inicializa los componentes del formulario (generado automáticamente).
        }

        private void customersBindingNavigatorSaveItem_Click(object sender, EventArgs e) // Evento click para el botón guardar del navegador de binding.
        {
            this.Validate(); // Valida los datos del formulario.
            this.customersBindingSource.EndEdit(); // Finaliza la edición del BindingSource llamado customersBindingSource.
            this.tableAdapterManager.UpdateAll(this.northwindDataSet); // Guarda los cambios en el DataSet llamado northwindDataSet.
        }

        private void Form1_Load(object sender, EventArgs e) // Evento que se ejecuta cuando el formulario se carga.
        {
            this.customersTableAdapter.Fill(this.northwindDataSet.Customers); // Rellena el DataSet northwindDataSet con datos de la tabla Customers.
        }

        private void customersDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e) // Evento para el click en una celda del DataGridView.
        {
            // Método vacío: no realiza ninguna acción cuando se hace clic en el contenido de una celda.
        }
    }
}
