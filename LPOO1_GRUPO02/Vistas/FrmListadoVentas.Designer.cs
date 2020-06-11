﻿namespace Vistas
{
    partial class FrmListadoVentas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvVentasRealizadas = new System.Windows.Forms.DataGridView();
            this.lblVentasRealizadas = new System.Windows.Forms.Label();
            this.cbxListadoCliente = new System.Windows.Forms.ComboBox();
            this.cbxListadoMarca = new System.Windows.Forms.ComboBox();
            this.gbxListadoMarca = new System.Windows.Forms.GroupBox();
            this.gbxListadoCliente = new System.Windows.Forms.GroupBox();
            this.gbxListarFecha = new System.Windows.Forms.GroupBox();
            this.dtpFechaFin = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.lblFin = new System.Windows.Forms.Label();
            this.lblInicio = new System.Windows.Forms.Label();
            this.btnListarFecha = new System.Windows.Forms.Button();
            this.btnListarTodo = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnAnularVentaSeleccionada = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentasRealizadas)).BeginInit();
            this.gbxListadoMarca.SuspendLayout();
            this.gbxListadoCliente.SuspendLayout();
            this.gbxListarFecha.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvVentasRealizadas
            // 
            this.dgvVentasRealizadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVentasRealizadas.Location = new System.Drawing.Point(12, 198);
            this.dgvVentasRealizadas.Name = "dgvVentasRealizadas";
            this.dgvVentasRealizadas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVentasRealizadas.Size = new System.Drawing.Size(1076, 407);
            this.dgvVentasRealizadas.TabIndex = 0;
            // 
            // lblVentasRealizadas
            // 
            this.lblVentasRealizadas.AutoSize = true;
            this.lblVentasRealizadas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVentasRealizadas.ForeColor = System.Drawing.Color.White;
            this.lblVentasRealizadas.Location = new System.Drawing.Point(344, 20);
            this.lblVentasRealizadas.Name = "lblVentasRealizadas";
            this.lblVentasRealizadas.Size = new System.Drawing.Size(390, 25);
            this.lblVentasRealizadas.TabIndex = 1;
            this.lblVentasRealizadas.Text = "LISTADO DE VENTAS REALIZADAS";
            // 
            // cbxListadoCliente
            // 
            this.cbxListadoCliente.FormattingEnabled = true;
            this.cbxListadoCliente.Location = new System.Drawing.Point(13, 39);
            this.cbxListadoCliente.Name = "cbxListadoCliente";
            this.cbxListadoCliente.Size = new System.Drawing.Size(180, 25);
            this.cbxListadoCliente.TabIndex = 4;
            this.cbxListadoCliente.SelectedIndexChanged += new System.EventHandler(this.cbxListadoCliente_SelectedIndexChanged);
            // 
            // cbxListadoMarca
            // 
            this.cbxListadoMarca.FormattingEnabled = true;
            this.cbxListadoMarca.Location = new System.Drawing.Point(17, 37);
            this.cbxListadoMarca.Name = "cbxListadoMarca";
            this.cbxListadoMarca.Size = new System.Drawing.Size(177, 25);
            this.cbxListadoMarca.TabIndex = 5;
            this.cbxListadoMarca.SelectedIndexChanged += new System.EventHandler(this.cbxListadoMarca_SelectedIndexChanged);
            // 
            // gbxListadoMarca
            // 
            this.gbxListadoMarca.Controls.Add(this.cbxListadoMarca);
            this.gbxListadoMarca.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxListadoMarca.ForeColor = System.Drawing.Color.White;
            this.gbxListadoMarca.Location = new System.Drawing.Point(289, 83);
            this.gbxListadoMarca.Name = "gbxListadoMarca";
            this.gbxListadoMarca.Size = new System.Drawing.Size(212, 90);
            this.gbxListadoMarca.TabIndex = 6;
            this.gbxListadoMarca.TabStop = false;
            this.gbxListadoMarca.Text = "Listado por Marca";
            // 
            // gbxListadoCliente
            // 
            this.gbxListadoCliente.Controls.Add(this.cbxListadoCliente);
            this.gbxListadoCliente.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxListadoCliente.ForeColor = System.Drawing.Color.White;
            this.gbxListadoCliente.Location = new System.Drawing.Point(23, 81);
            this.gbxListadoCliente.Name = "gbxListadoCliente";
            this.gbxListadoCliente.Size = new System.Drawing.Size(210, 90);
            this.gbxListadoCliente.TabIndex = 7;
            this.gbxListadoCliente.TabStop = false;
            this.gbxListadoCliente.Text = "Listado por Cliente";
            // 
            // gbxListarFecha
            // 
            this.gbxListarFecha.Controls.Add(this.dtpFechaFin);
            this.gbxListarFecha.Controls.Add(this.dtpFechaInicio);
            this.gbxListarFecha.Controls.Add(this.lblFin);
            this.gbxListarFecha.Controls.Add(this.lblInicio);
            this.gbxListarFecha.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxListarFecha.ForeColor = System.Drawing.Color.White;
            this.gbxListarFecha.Location = new System.Drawing.Point(566, 83);
            this.gbxListarFecha.Name = "gbxListarFecha";
            this.gbxListarFecha.Size = new System.Drawing.Size(258, 90);
            this.gbxListarFecha.TabIndex = 8;
            this.gbxListarFecha.TabStop = false;
            this.gbxListarFecha.Text = "Listar por Fecha";
            // 
            // dtpFechaFin
            // 
            this.dtpFechaFin.CustomFormat = "dd/MM/yyyy";
            this.dtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaFin.Location = new System.Drawing.Point(134, 55);
            this.dtpFechaFin.Name = "dtpFechaFin";
            this.dtpFechaFin.Size = new System.Drawing.Size(118, 24);
            this.dtpFechaFin.TabIndex = 4;
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.CustomFormat = "dd/MM/yyyy";
            this.dtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaInicio.Location = new System.Drawing.Point(134, 25);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(118, 24);
            this.dtpFechaInicio.TabIndex = 3;
            // 
            // lblFin
            // 
            this.lblFin.AutoSize = true;
            this.lblFin.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFin.Location = new System.Drawing.Point(6, 57);
            this.lblFin.Name = "lblFin";
            this.lblFin.Size = new System.Drawing.Size(107, 15);
            this.lblFin.TabIndex = 2;
            this.lblFin.Text = "Fin (dd/mm/aaaa)";
            // 
            // lblInicio
            // 
            this.lblInicio.AutoSize = true;
            this.lblInicio.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInicio.Location = new System.Drawing.Point(6, 32);
            this.lblInicio.Name = "lblInicio";
            this.lblInicio.Size = new System.Drawing.Size(122, 15);
            this.lblInicio.TabIndex = 1;
            this.lblInicio.Text = "Inicio (dd/mm/aaaa)";
            // 
            // btnListarFecha
            // 
            this.btnListarFecha.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnListarFecha.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListarFecha.ForeColor = System.Drawing.Color.White;
            this.btnListarFecha.Location = new System.Drawing.Point(895, 83);
            this.btnListarFecha.Name = "btnListarFecha";
            this.btnListarFecha.Size = new System.Drawing.Size(168, 32);
            this.btnListarFecha.TabIndex = 3;
            this.btnListarFecha.Text = "Listar por Fecha";
            this.btnListarFecha.UseVisualStyleBackColor = false;
            this.btnListarFecha.Click += new System.EventHandler(this.btnListarFecha_Click);
            // 
            // btnListarTodo
            // 
            this.btnListarTodo.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnListarTodo.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListarTodo.ForeColor = System.Drawing.Color.White;
            this.btnListarTodo.Location = new System.Drawing.Point(895, 138);
            this.btnListarTodo.Name = "btnListarTodo";
            this.btnListarTodo.Size = new System.Drawing.Size(168, 33);
            this.btnListarTodo.TabIndex = 9;
            this.btnListarTodo.Text = "Listar Todo";
            this.btnListarTodo.UseVisualStyleBackColor = false;
            this.btnListarTodo.Click += new System.EventHandler(this.btnListarTodo_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.btnCerrar);
            this.panel1.Controls.Add(this.lblVentasRealizadas);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1101, 61);
            this.panel1.TabIndex = 10;
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnCerrar.Font = new System.Drawing.Font("Arial Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ForeColor = System.Drawing.Color.White;
            this.btnCerrar.Location = new System.Drawing.Point(1038, 6);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(50, 46);
            this.btnCerrar.TabIndex = 11;
            this.btnCerrar.Text = "X";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnAnularVentaSeleccionada
            // 
            this.btnAnularVentaSeleccionada.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnAnularVentaSeleccionada.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnularVentaSeleccionada.ForeColor = System.Drawing.Color.White;
            this.btnAnularVentaSeleccionada.Location = new System.Drawing.Point(884, 611);
            this.btnAnularVentaSeleccionada.Name = "btnAnularVentaSeleccionada";
            this.btnAnularVentaSeleccionada.Size = new System.Drawing.Size(179, 33);
            this.btnAnularVentaSeleccionada.TabIndex = 11;
            this.btnAnularVentaSeleccionada.Text = "Anular Venta Seleccionada";
            this.btnAnularVentaSeleccionada.UseVisualStyleBackColor = false;
            this.btnAnularVentaSeleccionada.Click += new System.EventHandler(this.btnAnularVentaSeleccionada_Click);
            // 
            // FrmListadoVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(1100, 650);
            this.Controls.Add(this.btnAnularVentaSeleccionada);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnListarTodo);
            this.Controls.Add(this.btnListarFecha);
            this.Controls.Add(this.gbxListarFecha);
            this.Controls.Add(this.gbxListadoCliente);
            this.Controls.Add(this.gbxListadoMarca);
            this.Controls.Add(this.dgvVentasRealizadas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmListadoVentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado de Ventas";
            this.Load += new System.EventHandler(this.FrmListadoVentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentasRealizadas)).EndInit();
            this.gbxListadoMarca.ResumeLayout(false);
            this.gbxListadoCliente.ResumeLayout(false);
            this.gbxListarFecha.ResumeLayout(false);
            this.gbxListarFecha.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvVentasRealizadas;
        private System.Windows.Forms.Label lblVentasRealizadas;
        private System.Windows.Forms.ComboBox cbxListadoCliente;
        private System.Windows.Forms.ComboBox cbxListadoMarca;
        private System.Windows.Forms.GroupBox gbxListadoMarca;
        private System.Windows.Forms.GroupBox gbxListadoCliente;
        private System.Windows.Forms.GroupBox gbxListarFecha;
        private System.Windows.Forms.Label lblFin;
        private System.Windows.Forms.Label lblInicio;
        private System.Windows.Forms.Button btnListarFecha;
        private System.Windows.Forms.Button btnListarTodo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.DateTimePicker dtpFechaFin;
        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private System.Windows.Forms.Button btnAnularVentaSeleccionada;
    }
}