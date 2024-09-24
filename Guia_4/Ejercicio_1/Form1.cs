using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_1
{
    public partial class Form1 : Form
    {
        Cooperativa cooperativa;
        Cliente clienteSeleccionado;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIniciarCooperativa_Click(object sender, EventArgs e)
        {
            cooperativa = new Cooperativa(tbNomCooperativa.Text);
            tbNomCooperativa.Enabled = false;
            btnIniciarCooperativa.Enabled = false;
            gbAltaCliente.Enabled = true;
        }

        private void btnCargaCliente_Click(object sender, EventArgs e)
        {
            FDatos vtnD = new FDatos();
            if (vtnD.ShowDialog() == DialogResult.OK)
            {
                Medidor m = new Medidor(Convert.ToInt32(vtnD.tbNroServicio.Text));
                cooperativa.AgregarCliente(Convert.ToInt32(vtnD.tbDNI.Text), vtnD.tbNombre.Text, vtnD.tbDireccion.Text, m);
                MessageBox.Show($"Servicio Nro: {m.NumeroServicio}", "Cliente nuevo!");
            }
            vtnD.Dispose();
            if(cooperativa.CantidadClientes == 1) gbConsultaCliente.Enabled = true;
        }

        private void btnSeleccionarC_Click(object sender, EventArgs e)
        {
            clienteSeleccionado = cooperativa.BuscarCliente(Convert.ToInt32(tbNumServicio.Text));
            if (clienteSeleccionado != null) lbCliente.Text = clienteSeleccionado.ToString();
            else MessageBox.Show("Cliente no encontrado!");
        }

        private void btnCargaConsumo_Click(object sender, EventArgs e)
        {
            clienteSeleccionado.Medidor.RegistrarConsumo(Convert.ToDouble(tbConsumo.Text));
            lbUltimoPeriodo.Text = $"Último Periodo: {clienteSeleccionado.Medidor.PeriodoActual}";
            tbConsumo.Clear();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnConsumo_Click(object sender, EventArgs e)
        {
            FResultados vtnR = new FResultados();
            vtnR.lbResultados.Items.Add($"Número de Servicio {clienteSeleccionado.Medidor.NumeroServicio}");
            for (int i = 0; i < clienteSeleccionado.Medidor.CantidadConsumos; i++)
            {
                string consumo = clienteSeleccionado.Medidor.LeerConsumo(i).ToString("0.00");
                int periodo = (i + clienteSeleccionado.Medidor.PeriodoActual) % 6;
                vtnR.lbResultados.Items.Add($"{periodo,-10} {consumo,10}");
            }
            vtnR.ShowDialog();
            vtnR.Dispose();
        }
    }
}
