using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaRecorridoB.forms
{
    public partial class FrmBusquedaTxt : Form
    {
        public FrmBusquedaTxt()
        {
            InitializeComponent();
        }

        string[] parrafo = new string[100];

        private void btnContarL_Click(object sender, EventArgs e)
        {

            string palabra = tbnTexto.Text.ToLower();

            int contador = 0;

            for (int i = 0; i < parrafo.Length; i++)
            {
                bool coincidencia = true;
                for (int j = 0; j < palabra.Length; j++)
                {
                    if (parrafo[i + j] != palabra[j])
                    {
                        coincidencia = false;
                        break;
                    }
                }
                if (coincidencia)
                {
                    contador++;
                }
            }




        }
    }
}
