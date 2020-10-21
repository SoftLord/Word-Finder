namespace Word_Finder_1._0
{
    partial class ventanaNoActualizacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ventanaNoActualizacion));
            this.InfoActualizacion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // InfoActualizacion
            // 
            this.InfoActualizacion.AutoSize = true;
            this.InfoActualizacion.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfoActualizacion.Location = new System.Drawing.Point(51, 25);
            this.InfoActualizacion.Name = "InfoActualizacion";
            this.InfoActualizacion.Size = new System.Drawing.Size(342, 36);
            this.InfoActualizacion.TabIndex = 0;
            this.InfoActualizacion.Text = "No se han encontrado versiones más recientes.\r\n¡Está usted ejecutando la última v" +
    "ersión de Word Finder!";
            this.InfoActualizacion.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ventanaNoActualizacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 84);
            this.Controls.Add(this.InfoActualizacion);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(451, 123);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(451, 123);
            this.Name = "ventanaNoActualizacion";
            this.ShowInTaskbar = false;
            this.Text = "No hay actualizaciones disponibles";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label InfoActualizacion;
    }
}