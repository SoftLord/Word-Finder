using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;

namespace Word_Finder_1._0
{
    public partial class ventanaDescargaactualizador : Form
    {
        public ventanaDescargaactualizador()
        {
            InitializeComponent();
        }

        private void VentanaDescargaactualizador_Shown(object sender, EventArgs e)
        {
            var DescargaArchivos = new WebClient();

            if (Directory.Exists("Actualizador.pdb") == false)
            {
                DescargaArchivos.DownloadFile("https://sourceforge.net/projects/actualizaciones-word-finder/files/Actualizaciones/Actualizacion/Actualizador.pdb/download", "Actualizador.pdb");
                BarraprogresoDescargaActualizador.Increment(35);
            }
            if (Directory.Exists("Actualizador.exe") == false)
            {
                DescargaArchivos.DownloadFile("https://sourceforge.net/projects/actualizaciones-word-finder/files/Actualizaciones/Actualizacion/Actualizador.exe/download", "Actualizador.exe");
                BarraprogresoDescargaActualizador.Increment(35);
            }
            if (Directory.Exists("Actualizador.exe.config") == false)
            {
                DescargaArchivos.DownloadFile("https://sourceforge.net/projects/actualizaciones-word-finder/files/Actualizaciones/Actualizacion/Actualizador.exe.config/download", "Actualizador.exe.config");
                BarraprogresoDescargaActualizador.Increment(35);
            }
            this.Close();
        }
    }
}
