using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;

namespace Word_Finder_1._0
{
    public partial class ventanaActualizacion : Form
    {
        public ventanaActualizacion()
        {
            InitializeComponent();
        }

        private void BtnConfirmarDescarga_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("Actualizador.exe"); //se puede abreviar como process.Start si ponemos arriba using Diagnostics
            }

            catch (Exception)
            {
                MessageBox.Show("Hubo un error mientras se iniciaba\nel instalador, vuelva a intentarlo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnCancelarDescarga_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
