using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaRecorridoB.forms
{
    public partial class FrmInicio : MetroFramework.Forms.MetroForm
    {
        public FrmInicio()
        {
            InitializeComponent();
        }

        private void busquedaLinealToolStripMenuItem_Click(object sender, EventArgs e)
        {

            FrmBusquedaL busquedaL = new FrmBusquedaL();
            busquedaL.ShowDialog();

        }

        private void busquedaBinariaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBusquedaB busquedaB = new FrmBusquedaB();
            busquedaB.ShowDialog();


        }

        private void busquedaDeTextoEnUnaCadenaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBusquedaTxt busquedaTxt = new FrmBusquedaTxt();
            busquedaTxt.ShowDialog();
        }

        private void búsquedaDeObjetosEnUnaColecciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBusquedaOb busquedaOb = new FrmBusquedaOb();
            busquedaOb.ShowDialog();
        }
    }
}
