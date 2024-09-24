using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    internal class Cooperativa
    {
        public string Nombre {  get; set; }
        private List<Cliente> clientes = new List<Cliente>();
        public int CantidadClientes { get { return clientes.Count; } }

        public Cooperativa(string nombre)
        {
            Nombre = nombre;
        }
        public Cliente BuscarCliente(int nroServicio)
        {
            Cliente c = new Cliente("",0,"", new Medidor(nroServicio));
            clientes.Sort();
            int idx = clientes.BinarySearch(c);
            if(idx >= 0) return clientes[idx];
            return null;
        }
        public Cliente AgregarCliente(int dni, string nombre, string direccion, Medidor medidor)
        {
            Cliente c = new Cliente(nombre, dni, direccion, medidor);
            clientes.Add(c);
            return c;
        }
    }
}
