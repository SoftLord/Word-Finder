﻿namespace Word_Finder_1._0
{
    partial class ventanaDescargaactualizador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ventanaDescargaactualizador));
            this.BarraprogresoDescargaActualizador = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // BarraprogresoDescargaActualizador
            // 
            this.BarraprogresoDescargaActualizador.Location = new System.Drawing.Point(12, 12);
            this.BarraprogresoDescargaActualizador.Name = "BarraprogresoDescargaActualizador";
            this.BarraprogresoDescargaActualizador.Size = new System.Drawing.Size(460, 37);
            this.BarraprogresoDescargaActualizador.TabIndex = 1;
            // 
            // ventanaDescargaactualizador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 61);
            this.Controls.Add(this.BarraprogresoDescargaActualizador);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(500, 150);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(500, 100);
            this.Name = "ventanaDescargaactualizador";
            this.Text = "Descargando archivos adicionales...";
            this.Shown += new System.EventHandler(this.VentanaDescargaactualizador_Shown);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ProgressBar BarraprogresoDescargaActualizador;
    }
}