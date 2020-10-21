namespace Word_Finder_1._0
{
    partial class Ventana
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ventana));
            this.EtiquetaTexto = new System.Windows.Forms.Label();
            this.EntradaPalabra = new System.Windows.Forms.TextBox();
            this.BtnDefinir = new System.Windows.Forms.Button();
            this.BtnTraducir = new System.Windows.Forms.Button();
            this.EnlaceWeb = new System.Windows.Forms.LinkLabel();
            this.EtiquetaInfo = new System.Windows.Forms.Label();
            this.Nota = new System.Windows.Forms.Label();
            this.BtnGuardado = new System.Windows.Forms.Button();
            this.EleccionRuta = new System.Windows.Forms.ComboBox();
            this.PalabraFinal = new System.Windows.Forms.Label();
            this.NotifGuardado = new System.Windows.Forms.NotifyIcon(this.components);
            this.BarraDeMenu = new System.Windows.Forms.MenuStrip();
            this.gToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreWordFinderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.creditosYAutoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comprobarActualizacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BarraDeMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // EtiquetaTexto
            // 
            this.EtiquetaTexto.AutoSize = true;
            this.EtiquetaTexto.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EtiquetaTexto.Location = new System.Drawing.Point(41, 124);
            this.EtiquetaTexto.Name = "EtiquetaTexto";
            this.EtiquetaTexto.Size = new System.Drawing.Size(141, 18);
            this.EtiquetaTexto.TabIndex = 0;
            this.EtiquetaTexto.Text = "Introduzca su palabra:";
            // 
            // EntradaPalabra
            // 
            this.EntradaPalabra.Location = new System.Drawing.Point(208, 124);
            this.EntradaPalabra.Name = "EntradaPalabra";
            this.EntradaPalabra.Size = new System.Drawing.Size(199, 20);
            this.EntradaPalabra.TabIndex = 1;
            // 
            // BtnDefinir
            // 
            this.BtnDefinir.Location = new System.Drawing.Point(44, 433);
            this.BtnDefinir.Name = "BtnDefinir";
            this.BtnDefinir.Size = new System.Drawing.Size(227, 28);
            this.BtnDefinir.TabIndex = 3;
            this.BtnDefinir.Text = "Definir";
            this.BtnDefinir.UseVisualStyleBackColor = true;
            this.BtnDefinir.Click += new System.EventHandler(this.BtnDefinir_Click);
            // 
            // BtnTraducir
            // 
            this.BtnTraducir.Location = new System.Drawing.Point(376, 433);
            this.BtnTraducir.Name = "BtnTraducir";
            this.BtnTraducir.Size = new System.Drawing.Size(227, 28);
            this.BtnTraducir.TabIndex = 4;
            this.BtnTraducir.Text = "Traducir";
            this.BtnTraducir.UseVisualStyleBackColor = true;
            this.BtnTraducir.Click += new System.EventHandler(this.BtnTraducir_Click);
            // 
            // EnlaceWeb
            // 
            this.EnlaceWeb.AutoSize = true;
            this.EnlaceWeb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EnlaceWeb.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnlaceWeb.Location = new System.Drawing.Point(777, 439);
            this.EnlaceWeb.Name = "EnlaceWeb";
            this.EnlaceWeb.Size = new System.Drawing.Size(138, 17);
            this.EnlaceWeb.TabIndex = 5;
            this.EnlaceWeb.TabStop = true;
            this.EnlaceWeb.Text = "Powered by Lexico.com";
            this.EnlaceWeb.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.EnlaceWeb.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.EnlaceWeb_LinkClicked);
            // 
            // EtiquetaInfo
            // 
            this.EtiquetaInfo.AutoSize = true;
            this.EtiquetaInfo.Font = new System.Drawing.Font("Gotham", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EtiquetaInfo.Location = new System.Drawing.Point(767, 637);
            this.EtiquetaInfo.Name = "EtiquetaInfo";
            this.EtiquetaInfo.Size = new System.Drawing.Size(205, 15);
            this.EtiquetaInfo.TabIndex = 6;
            this.EtiquetaInfo.Text = "Hecho por Álvaro Roca © 2019";
            // 
            // Nota
            // 
            this.Nota.AutoSize = true;
            this.Nota.Location = new System.Drawing.Point(41, 480);
            this.Nota.Name = "Nota";
            this.Nota.Size = new System.Drawing.Size(270, 26);
            this.Nota.TabIndex = 7;
            this.Nota.Text = "Nota: El texto debe de estar compuesto únicamente por\r\npalabras. Las frases no so" +
    "n soportadas por el sistema.";
            // 
            // BtnGuardado
            // 
            this.BtnGuardado.Location = new System.Drawing.Point(44, 580);
            this.BtnGuardado.Name = "BtnGuardado";
            this.BtnGuardado.Size = new System.Drawing.Size(116, 31);
            this.BtnGuardado.TabIndex = 8;
            this.BtnGuardado.Text = "Guardar";
            this.BtnGuardado.UseVisualStyleBackColor = true;
            this.BtnGuardado.Click += new System.EventHandler(this.BtnGuardado_Click);
            // 
            // EleccionRuta
            // 
            this.EleccionRuta.FormattingEnabled = true;
            this.EleccionRuta.Items.AddRange(new object[] {
            "Escritorio",
            "Documentos",
            "Fotos"});
            this.EleccionRuta.Location = new System.Drawing.Point(208, 586);
            this.EleccionRuta.Name = "EleccionRuta";
            this.EleccionRuta.Size = new System.Drawing.Size(158, 21);
            this.EleccionRuta.TabIndex = 9;
            this.EleccionRuta.Text = "Elija ubicación";
            // 
            // PalabraFinal
            // 
            this.PalabraFinal.AutoSize = true;
            this.PalabraFinal.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PalabraFinal.Location = new System.Drawing.Point(44, 183);
            this.PalabraFinal.MaximumSize = new System.Drawing.Size(500, 0);
            this.PalabraFinal.Name = "PalabraFinal";
            this.PalabraFinal.Size = new System.Drawing.Size(0, 18);
            this.PalabraFinal.TabIndex = 10;
            // 
            // NotifGuardado
            // 
            this.NotifGuardado.BalloonTipText = "Word Finder está actualmente activo y ejecutándose.";
            this.NotifGuardado.BalloonTipTitle = "Word Finder";
            this.NotifGuardado.Icon = ((System.Drawing.Icon)(resources.GetObject("NotifGuardado.Icon")));
            this.NotifGuardado.Text = "Word Finder";
            this.NotifGuardado.Visible = true;
            // 
            // BarraDeMenu
            // 
            this.BarraDeMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.BarraDeMenu.Location = new System.Drawing.Point(0, 0);
            this.BarraDeMenu.Name = "BarraDeMenu";
            this.BarraDeMenu.Size = new System.Drawing.Size(984, 24);
            this.BarraDeMenu.TabIndex = 11;
            this.BarraDeMenu.Text = "menuStrip1";
            // 
            // gToolStripMenuItem
            // 
            this.gToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.guardarToolStripMenuItem});
            this.gToolStripMenuItem.Name = "gToolStripMenuItem";
            this.gToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.gToolStripMenuItem.Text = "Archivo";
            // 
            // guardarToolStripMenuItem
            // 
            this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            this.guardarToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.guardarToolStripMenuItem.Text = "Guardar";
            this.guardarToolStripMenuItem.Click += new System.EventHandler(this.GuardarToolStripMenuItem_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sobreWordFinderToolStripMenuItem,
            this.creditosYAutoresToolStripMenuItem,
            this.comprobarActualizacionesToolStripMenuItem});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // sobreWordFinderToolStripMenuItem
            // 
            this.sobreWordFinderToolStripMenuItem.Name = "sobreWordFinderToolStripMenuItem";
            this.sobreWordFinderToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.sobreWordFinderToolStripMenuItem.Text = "Sobre Word Finder";
            this.sobreWordFinderToolStripMenuItem.Click += new System.EventHandler(this.SobreWordFinderToolStripMenuItem_Click);
            // 
            // creditosYAutoresToolStripMenuItem
            // 
            this.creditosYAutoresToolStripMenuItem.Name = "creditosYAutoresToolStripMenuItem";
            this.creditosYAutoresToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.creditosYAutoresToolStripMenuItem.Text = "Creditos y autores";
            this.creditosYAutoresToolStripMenuItem.Click += new System.EventHandler(this.CreditosYAutoresToolStripMenuItem_Click);
            // 
            // comprobarActualizacionesToolStripMenuItem
            // 
            this.comprobarActualizacionesToolStripMenuItem.Name = "comprobarActualizacionesToolStripMenuItem";
            this.comprobarActualizacionesToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.comprobarActualizacionesToolStripMenuItem.Text = "Comprobar actualizaciones";
            this.comprobarActualizacionesToolStripMenuItem.Click += new System.EventHandler(this.ComprobarActualizacionesToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(639, 111);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(211, 222);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Ventana
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.PalabraFinal);
            this.Controls.Add(this.EleccionRuta);
            this.Controls.Add(this.BtnGuardado);
            this.Controls.Add(this.Nota);
            this.Controls.Add(this.EtiquetaInfo);
            this.Controls.Add(this.EnlaceWeb);
            this.Controls.Add(this.BtnTraducir);
            this.Controls.Add(this.BtnDefinir);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.EntradaPalabra);
            this.Controls.Add(this.EtiquetaTexto);
            this.Controls.Add(this.BarraDeMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.BarraDeMenu;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1000, 700);
            this.MinimumSize = new System.Drawing.Size(1000, 700);
            this.Name = "Ventana";
            this.Text = "Word Finder";
            this.Load += new System.EventHandler(this.Ventana_Load);
            this.BarraDeMenu.ResumeLayout(false);
            this.BarraDeMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label EtiquetaTexto;
        private System.Windows.Forms.TextBox EntradaPalabra;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtnDefinir;
        private System.Windows.Forms.Button BtnTraducir;
        private System.Windows.Forms.LinkLabel EnlaceWeb;
        private System.Windows.Forms.Label EtiquetaInfo;
        private System.Windows.Forms.Label Nota;
        private System.Windows.Forms.Button BtnGuardado;
        private System.Windows.Forms.ComboBox EleccionRuta;
        private System.Windows.Forms.Label PalabraFinal;
        private System.Windows.Forms.NotifyIcon NotifGuardado;
        private System.Windows.Forms.MenuStrip BarraDeMenu;
        private System.Windows.Forms.ToolStripMenuItem gToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreWordFinderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem creditosYAutoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comprobarActualizacionesToolStripMenuItem;
    }
}

