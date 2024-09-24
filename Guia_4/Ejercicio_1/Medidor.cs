using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    internal class Medidor
    {
        public readonly int NumeroServicio;
        private double lecturaAnterior;
        public double LecturaAnterior { get { return lecturaAnterior; } }
        private double lecturaActual;
        public double LecturaActual { get { return lecturaActual; } }
        public int CantidadConsumos { get { return consumos.Count; } }
        private int periodoActual;
        public int PeriodoActual 
        {  
            get { return periodoActual; }
            set
            {
                if(CantidadConsumos == 8) consumos.RemoveAt(0);
                periodoActual = value % 6;
            }
        }
        private ArrayList consumos = new ArrayList();

        public Medidor(int numeroServicio)
        {
            NumeroServicio = numeroServicio;
        }
        public double ConsumoActual()
        {
            return lecturaActual - lecturaAnterior;
        }
        public void Medicion(double lecturaActual)
        {
            lecturaAnterior = this.lecturaActual;
            this.lecturaActual = lecturaActual;
        }
        public void RegistrarConsumo(double medicion)
        {
            PeriodoActual++;
            lecturaActual = medicion;
            consumos.Add(ConsumoActual());
        }
        public double LeerConsumo(int pos)
        {
            return (double)consumos[pos];
        }
    }
}
