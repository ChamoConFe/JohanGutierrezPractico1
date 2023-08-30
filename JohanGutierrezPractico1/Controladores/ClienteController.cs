using JohanGutierrezPractico1.Modelos;
using System;
using System.Collections.Generic;


namespace JohanGutierrezPractico1.Controladores
{
    // Controlador de clientes
    public class ClienteController : ControllerBase
    {
        public List<Cliente> ObtenerClientes()
        {
            return datos.Clientes;
        }

        public void AgregarCliente(Cliente cliente)
        {
            datos.Clientes.Add(cliente);
        }

        public void EditarCliente(int index, Cliente cliente)
        {
            if (index >= 0 && index < datos.Clientes.Count)
            {
                datos.Clientes[index].Rut = cliente.Rut;
                datos.Clientes[index].Nombre = cliente.Nombre;
                datos.Clientes[index].EsEmpresa = cliente.EsEmpresa; // Asegúrate de copiar el valor de "Es Empresa".
                datos.Clientes[index].Telefono = cliente.Telefono;
                datos.Clientes[index].Direccion = cliente.Direccion;
                datos.Clientes[index].FechaRegistro = cliente.FechaRegistro;
                //datos.Clientes[index].CantidadFacturas = cliente.CantidadFacturas;
                //datos.Clientes[index].NumeroUltimaFactura = cliente.NumeroUltimaFactura;
                //datos.Clientes[index].MontoUltimaFactura = cliente.MontoUltimaFactura;
            }
        }

        public void EliminarCliente(int index)
        {
            datos.Clientes.RemoveAt(index);
        }

        public bool ExisteRutDuplicado(string rut)
        {
            // Verificar si hay algún cliente con el mismo RUT en la lista de clientes.
            foreach (var cliente in ObtenerClientes()) // Utiliza el método ObtenerClientes para obtener la lista.
            {
                if (cliente.Rut.Equals(rut, StringComparison.OrdinalIgnoreCase)) // Comparación sin importar mayúsculas o minúsculas
                {
                    return true; // Se encontró un RUT duplicado.
                }
            }

            return false; // No se encontraron RUT duplicados.
        }
    }
}