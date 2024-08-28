using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatosLayer // Define el espacio de nombres para la capa de datos.
{
    public class Customers // Define la clase "Customers" que representa a un cliente en la base de datos.
    {
        // Propiedades de la clase "Customers".

        // Identificador único del cliente.
        public string CustomerID { get; set; }

        // Nombre de la compañía del cliente.
        public string CompanyName { get; set; }

        // Nombre de contacto del cliente.
        public string ContactName { get; set; }

        // Título del contacto del cliente.
        public string ContactTitle { get; set; }

        // Dirección del cliente.
        public string Address { get; set; }

        // Ciudad del cliente.
        public string City { get; set; }

        // Región del cliente (si aplica).
        public string Region { get; set; }

        // Código postal del cliente.
        public string PostalCode { get; set; }

        // País del cliente.
        public string Country { get; set; }

        // Número de teléfono del cliente.
        public string Phone { get; set; }

        // Número de fax del cliente.
        public string Fax { get; set; }
    }
}