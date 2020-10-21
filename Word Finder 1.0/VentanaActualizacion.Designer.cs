namespace Word_Finder_1._0
{
    partial class ventanaActualizacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ventanaActualizacion));
            this.EtiquetaVersiondisponible = new System.Windows.Forms.Label();
            this.BtnConfirmarDescarga = new System.Windows.Forms.Button();
            this.BtnCancelarDescarga = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EtiquetaVersiondisponible
            // 
            this.EtiquetaVersiondisponible.AutoSize = true;
            this.EtiquetaVersiondisponible.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EtiquetaVersiondisponible.Location = new System.Drawing.Point(52, 9);
            this.EtiquetaVersiondisponible.Name = "EtiquetaVersiondisponible";
            this.EtiquetaVersiondisponible.Size = new System.Drawing.Size(400, 44);
            this.EtiquetaVersiondisponible.TabIndex = 0;
            this.EtiquetaVersiondisponible.Text = "¡Se ha encontrado una nueva version disponible!\r\n¿Desea descargarla ahora?";
            this.EtiquetaVersiondisponible.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // BtnConfirmarDescarga
            // 
            this.BtnConfirmarDescarga.Location = new System.Drawing.Point(145, 92);
            this.BtnConfirmarDescarga.Name = "BtnConfirmarDescarga";
            this.BtnConfirmarDescarga.Size = new System.Drawing.Size(75, 23);
            this.BtnConfirmarDescarga.TabIndex = 1;
            this.BtnConfirmarDescarga.Text = "Sí";
            this.BtnConfirmarDescarga.UseVisualStyleBackColor = true;
            this.BtnConfirmarDescarga.Click += new System.EventHandler(this.BtnConfirmarDescarga_Click);
            // 
            // BtnCancelarDescarga
            // 
            this.BtnCancelarDescarga.Location = new System.Drawing.Point(280, 92);
            this.BtnCancelarDescarga.Name = "BtnCancelarDescarga";
            this.BtnCancelarDescarga.Size = new System.Drawing.Size(75, 23);
            this.BtnCancelarDescarga.TabIndex = 2;
            this.BtnCancelarDescarga.Text = "No";
            this.BtnCancelarDescarga.UseVisualStyleBackColor = true;
            this.BtnCancelarDescarga.Click += new System.EventHandler(this.BtnCancelarDescarga_Click);
            // 
            // ventanaActualizacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 134);
            this.Controls.Add(this.BtnCancelarDescarga);
            this.Controls.Add(this.BtnConfirmarDescarga);
            this.Controls.Add(this.EtiquetaVersiondisponible);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(509, 173);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(509, 173);
            this.Name = "ventanaActualizacion";
            this.ShowInTaskbar = false;
            this.Text = "Hay una nueva versión disponible";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label EtiquetaVersiondisponible;
        private System.Windows.Forms.Button BtnConfirmarDescarga;
        private System.Windows.Forms.Button BtnCancelarDescarga;
    }
}