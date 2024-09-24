using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    internal class Cliente : IComparable
    {
        private int dni;
        public int Dni { get { return dni; } }
        private string nombre;
        public string Nombre { get { return nombre; } }
        private string direccion;
        public string Direccion { get { return direccion; } }
        private Medidor medidor;
        public Medidor Medidor {  get { return medidor; } } 

        public Cliente(string nombre, int dni, string direccion, Medidor medidor)
        {
            this.nombre = nombre;
            this.dni = dni;
            this.direccion = direccion;
            this.medidor = medidor;
        }

        public int CompareTo(Object c)
        {
            if (c == null) return 1;
            return medidor.NumeroServicio.CompareTo(((Cliente)c).Medidor.NumeroServicio);
        }

        public override string ToString()
        {
            return $"Cliente: {nombre} ( {dni} )";
        }
    }
}
