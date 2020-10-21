using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Word_Finder_1._0
{
    public partial class ventanaAcercaDe : Form
    {
        public ventanaAcercaDe()
        {
            InitializeComponent();
        }

        private void EnlaceWeb2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.lexico.com/es/sobre-nosotros");
        }
    }
}
