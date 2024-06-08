using System.Collections.Generic;
using System.Linq;

namespace AplicacionPrueba.API
{
    public class ClienteService
    {
        public IList<Cliente> Clientes { get; set; }

        // Constructor
        public ClienteService()
        {
            // Inicializamos la lista de clientes
            Clientes = new List<Cliente>();

            // Agregamos clientes de prueba
            AgregarCliente(new Cliente { rut = 1, Nombre = "Juan", Apellido = "Perez", Direccion = "Calle A", Telefono = 123456 });
            AgregarCliente(new Cliente { rut = 2, Nombre = "María", Apellido = "López", Direccion = "Calle B", Telefono = 654321 });
            // Agrega más clientes de prueba si es necesario
        }
        
        public Cliente BuscarCliente(int rut)
        {
            return Clientes.FirstOrDefault(c => c.rut == rut);
        }

        public void AgregarCliente(Cliente cliente)
        {
            Clientes.Add(cliente);
        }

        public void EliminarCliente(int rut)
        {
            var cliente = BuscarCliente(rut);
            if (cliente != null)
            {
                Clientes.Remove(cliente);
            }
        }
    }
}
