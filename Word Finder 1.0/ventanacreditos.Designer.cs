namespace Word_Finder_1._0
{
    partial class ventanacreditos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ventanacreditos));
            this.Autores = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Autores
            // 
            this.Autores.AutoSize = true;
            this.Autores.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Autores.Location = new System.Drawing.Point(17, 209);
            this.Autores.MaximumSize = new System.Drawing.Size(426, 130);
            this.Autores.MinimumSize = new System.Drawing.Size(426, 130);
            this.Autores.Name = "Autores";
            this.Autores.Size = new System.Drawing.Size(426, 130);
            this.Autores.TabIndex = 0;
            this.Autores.Text = resources.GetString("Autores.Text");
            this.Autores.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Word_Finder_1._0.Properties.Resources.word_finder;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(130, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 201);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // ventanacreditos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 348);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Autores);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(471, 387);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(471, 387);
            this.Name = "ventanacreditos";
            this.ShowInTaskbar = false;
            this.Text = "Creditos y Autores";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Autores;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}