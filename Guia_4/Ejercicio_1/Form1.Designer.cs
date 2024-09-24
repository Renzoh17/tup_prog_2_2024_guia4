namespace Ejercicio_1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.tbNomCooperativa = new System.Windows.Forms.TextBox();
            this.btnIniciarCooperativa = new System.Windows.Forms.Button();
            this.gbAltaCliente = new System.Windows.Forms.GroupBox();
            this.btnCargaCliente = new System.Windows.Forms.Button();
            this.gbConsultaCliente = new System.Windows.Forms.GroupBox();
            this.gbVerConsumos = new System.Windows.Forms.GroupBox();
            this.btnConsumo = new System.Windows.Forms.Button();
            this.gbCargaConsumos = new System.Windows.Forms.GroupBox();
            this.btnCargaConsumo = new System.Windows.Forms.Button();
            this.tbConsumo = new System.Windows.Forms.TextBox();
            this.lbCliente = new System.Windows.Forms.Label();
            this.btnSeleccionarC = new System.Windows.Forms.Button();
            this.tbNumServicio = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.lbUltimoPeriodo = new System.Windows.Forms.Label();
            this.gbAltaCliente.SuspendLayout();
            this.gbConsultaCliente.SuspendLayout();
            this.gbVerConsumos.SuspendLayout();
            this.gbCargaConsumos.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cooperativa";
            // 
            // tbNomCooperativa
            // 
            this.tbNomCooperativa.Location = new System.Drawing.Point(159, 14);
            this.tbNomCooperativa.Name = "tbNomCooperativa";
            this.tbNomCooperativa.Size = new System.Drawing.Size(134, 20);
            this.tbNomCooperativa.TabIndex = 1;
            // 
            // btnIniciarCooperativa
            // 
            this.btnIniciarCooperativa.Location = new System.Drawing.Point(299, 12);
            this.btnIniciarCooperativa.Name = "btnIniciarCooperativa";
            this.btnIniciarCooperativa.Size = new System.Drawing.Size(177, 23);
            this.btnIniciarCooperativa.TabIndex = 2;
            this.btnIniciarCooperativa.Text = "Iniciar Cooperativa";
            this.btnIniciarCooperativa.UseVisualStyleBackColor = true;
            this.btnIniciarCooperativa.Click += new System.EventHandler(this.btnIniciarCooperativa_Click);
            // 
            // gbAltaCliente
            // 
            this.gbAltaCliente.Controls.Add(this.btnCargaCliente);
            this.gbAltaCliente.Enabled = false;
            this.gbAltaCliente.Location = new System.Drawing.Point(12, 46);
            this.gbAltaCliente.Name = "gbAltaCliente";
            this.gbAltaCliente.Size = new System.Drawing.Size(470, 59);
            this.gbAltaCliente.TabIndex = 3;
            this.gbAltaCliente.TabStop = false;
            this.gbAltaCliente.Text = "Alta de clientes";
            // 
            // btnCargaCliente
            // 
            this.btnCargaCliente.Location = new System.Drawing.Point(287, 19);
            this.btnCargaCliente.Name = "btnCargaCliente";
            this.btnCargaCliente.Size = new System.Drawing.Size(177, 25);
            this.btnCargaCliente.TabIndex = 4;
            this.btnCargaCliente.Text = "Carga de clientes";
            this.btnCargaCliente.UseVisualStyleBackColor = true;
            this.btnCargaCliente.Click += new System.EventHandler(this.btnCargaCliente_Click);
            // 
            // gbConsultaCliente
            // 
            this.gbConsultaCliente.Controls.Add(this.gbVerConsumos);
            this.gbConsultaCliente.Controls.Add(this.gbCargaConsumos);
            this.gbConsultaCliente.Controls.Add(this.lbCliente);
            this.gbConsultaCliente.Controls.Add(this.btnSeleccionarC);
            this.gbConsultaCliente.Controls.Add(this.tbNumServicio);
            this.gbConsultaCliente.Controls.Add(this.label2);
            this.gbConsultaCliente.Enabled = false;
            this.gbConsultaCliente.Location = new System.Drawing.Point(12, 111);
            this.gbConsultaCliente.Name = "gbConsultaCliente";
            this.gbConsultaCliente.Size = new System.Drawing.Size(470, 230);
            this.gbConsultaCliente.TabIndex = 4;
            this.gbConsultaCliente.TabStop = false;
            this.gbConsultaCliente.Text = "Consultas de clientes";
            // 
            // gbVerConsumos
            // 
            this.gbVerConsumos.Controls.Add(this.btnConsumo);
            this.gbVerConsumos.Location = new System.Drawing.Point(44, 164);
            this.gbVerConsumos.Name = "gbVerConsumos";
            this.gbVerConsumos.Size = new System.Drawing.Size(420, 60);
            this.gbVerConsumos.TabIndex = 7;
            this.gbVerConsumos.TabStop = false;
            this.gbVerConsumos.Text = "Consumos";
            // 
            // btnConsumo
            // 
            this.btnConsumo.Location = new System.Drawing.Point(237, 19);
            this.btnConsumo.Name = "btnConsumo";
            this.btnConsumo.Size = new System.Drawing.Size(177, 25);
            this.btnConsumo.TabIndex = 9;
            this.btnConsumo.Text = "Ver consumo";
            this.btnConsumo.UseVisualStyleBackColor = true;
            this.btnConsumo.Click += new System.EventHandler(this.btnConsumo_Click);
            // 
            // gbCargaConsumos
            // 
            this.gbCargaConsumos.Controls.Add(this.lbUltimoPeriodo);
            this.gbCargaConsumos.Controls.Add(this.btnCargaConsumo);
            this.gbCargaConsumos.Controls.Add(this.tbConsumo);
            this.gbCargaConsumos.Location = new System.Drawing.Point(44, 71);
            this.gbCargaConsumos.Name = "gbCargaConsumos";
            this.gbCargaConsumos.Size = new System.Drawing.Size(420, 87);
            this.gbCargaConsumos.TabIndex = 5;
            this.gbCargaConsumos.TabStop = false;
            this.gbCargaConsumos.Text = "Carga de consumos";
            // 
            // btnCargaConsumo
            // 
            this.btnCargaConsumo.Location = new System.Drawing.Point(237, 19);
            this.btnCargaConsumo.Name = "btnCargaConsumo";
            this.btnCargaConsumo.Size = new System.Drawing.Size(177, 25);
            this.btnCargaConsumo.TabIndex = 7;
            this.btnCargaConsumo.Text = "Cargar Consumo";
            this.btnCargaConsumo.UseVisualStyleBackColor = true;
            this.btnCargaConsumo.Click += new System.EventHandler(this.btnCargaConsumo_Click);
            // 
            // tbConsumo
            // 
            this.tbConsumo.Location = new System.Drawing.Point(97, 22);
            this.tbConsumo.Name = "tbConsumo";
            this.tbConsumo.Size = new System.Drawing.Size(134, 20);
            this.tbConsumo.TabIndex = 8;
            // 
            // lbCliente
            // 
            this.lbCliente.AutoSize = true;
            this.lbCliente.Location = new System.Drawing.Point(144, 45);
            this.lbCliente.Name = "lbCliente";
            this.lbCliente.Size = new System.Drawing.Size(48, 13);
            this.lbCliente.TabIndex = 6;
            this.lbCliente.Text = "Cliente: -";
            // 
            // btnSeleccionarC
            // 
            this.btnSeleccionarC.Location = new System.Drawing.Point(287, 19);
            this.btnSeleccionarC.Name = "btnSeleccionarC";
            this.btnSeleccionarC.Size = new System.Drawing.Size(177, 25);
            this.btnSeleccionarC.TabIndex = 5;
            this.btnSeleccionarC.Text = "Seleccionar";
            this.btnSeleccionarC.UseVisualStyleBackColor = true;
            this.btnSeleccionarC.Click += new System.EventHandler(this.btnSeleccionarC_Click);
            // 
            // tbNumServicio
            // 
            this.tbNumServicio.Location = new System.Drawing.Point(147, 22);
            this.tbNumServicio.Name = "tbNumServicio";
            this.tbNumServicio.Size = new System.Drawing.Size(134, 20);
            this.tbNumServicio.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Número de Servicio";
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(153, 347);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(177, 25);
            this.btnCerrar.TabIndex = 10;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // lbUltimoPeriodo
            // 
            this.lbUltimoPeriodo.AutoSize = true;
            this.lbUltimoPeriodo.Location = new System.Drawing.Point(94, 59);
            this.lbUltimoPeriodo.Name = "lbUltimoPeriodo";
            this.lbUltimoPeriodo.Size = new System.Drawing.Size(84, 13);
            this.lbUltimoPeriodo.TabIndex = 11;
            this.lbUltimoPeriodo.Text = "Último Periodo: -";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 384);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.gbConsultaCliente);
            this.Controls.Add(this.gbAltaCliente);
            this.Controls.Add(this.btnIniciarCooperativa);
            this.Controls.Add(this.tbNomCooperativa);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Ejercicio 1";
            this.gbAltaCliente.ResumeLayout(false);
            this.gbConsultaCliente.ResumeLayout(false);
            this.gbConsultaCliente.PerformLayout();
            this.gbVerConsumos.ResumeLayout(false);
            this.gbCargaConsumos.ResumeLayout(false);
            this.gbCargaConsumos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNomCooperativa;
        private System.Windows.Forms.Button btnIniciarCooperativa;
        private System.Windows.Forms.GroupBox gbAltaCliente;
        private System.Windows.Forms.Button btnCargaCliente;
        private System.Windows.Forms.GroupBox gbConsultaCliente;
        private System.Windows.Forms.TextBox tbNumServicio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbVerConsumos;
        private System.Windows.Forms.GroupBox gbCargaConsumos;
        private System.Windows.Forms.Button btnCargaConsumo;
        private System.Windows.Forms.TextBox tbConsumo;
        private System.Windows.Forms.Label lbCliente;
        private System.Windows.Forms.Button btnSeleccionarC;
        private System.Windows.Forms.Button btnConsumo;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label lbUltimoPeriodo;
    }
}

