namespace Word_Finder_1._0
{
    partial class ventanaAcercaDe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ventanaAcercaDe));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.EtiquetaNombre = new System.Windows.Forms.Label();
            this.Copiright = new System.Windows.Forms.Label();
            this.EnlaceWeb2 = new System.Windows.Forms.LinkLabel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.Version = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(381, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(193, 120);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // EtiquetaNombre
            // 
            this.EtiquetaNombre.AutoSize = true;
            this.EtiquetaNombre.Font = new System.Drawing.Font("Bungee", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EtiquetaNombre.ForeColor = System.Drawing.Color.Black;
            this.EtiquetaNombre.Location = new System.Drawing.Point(30, 30);
            this.EtiquetaNombre.Name = "EtiquetaNombre";
            this.EtiquetaNombre.Size = new System.Drawing.Size(297, 89);
            this.EtiquetaNombre.TabIndex = 1;
            this.EtiquetaNombre.Text = "Word Finder";
            // 
            // Copiright
            // 
            this.Copiright.AutoSize = true;
            this.Copiright.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Copiright.Location = new System.Drawing.Point(42, 136);
            this.Copiright.Name = "Copiright";
            this.Copiright.Size = new System.Drawing.Size(164, 15);
            this.Copiright.TabIndex = 2;
            this.Copiright.Text = "© 2019 Álvaro Roca, Inc.";
            // 
            // EnlaceWeb2
            // 
            this.EnlaceWeb2.AutoSize = true;
            this.EnlaceWeb2.Location = new System.Drawing.Point(454, 157);
            this.EnlaceWeb2.Name = "EnlaceWeb2";
            this.EnlaceWeb2.Size = new System.Drawing.Size(120, 13);
            this.EnlaceWeb2.TabIndex = 4;
            this.EnlaceWeb2.TabStop = true;
            this.EnlaceWeb2.Text = "Powered by Lexico.com";
            this.EnlaceWeb2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.EnlaceWeb2_LinkClicked);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Open Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(12, 187);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(562, 186);
            this.richTextBox1.TabIndex = 5;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // Version
            // 
            this.Version.AutoSize = true;
            this.Version.Font = new System.Drawing.Font("Bungee", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Version.Location = new System.Drawing.Point(40, 91);
            this.Version.Name = "Version";
            this.Version.Size = new System.Drawing.Size(97, 28);
            this.Version.TabIndex = 6;
            this.Version.Text = "version 1.4.5";
            // 
            // ventanaAcercaDe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 385);
            this.Controls.Add(this.Version);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.EnlaceWeb2);
            this.Controls.Add(this.Copiright);
            this.Controls.Add(this.EtiquetaNombre);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(619, 424);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(619, 424);
            this.Name = "ventanaAcercaDe";
            this.ShowInTaskbar = false;
            this.Text = "Acerca de...";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label EtiquetaNombre;
        private System.Windows.Forms.Label Copiright;
        private System.Windows.Forms.LinkLabel EnlaceWeb2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label Version;
    }
}