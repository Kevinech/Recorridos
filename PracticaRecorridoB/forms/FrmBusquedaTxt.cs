using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaRecorridoB.forms
{
    public partial class FrmBusquedaTxt : Form
    {

        private string parrafo = "";
        private List<string> listPalabras = new List<string>();



        public FrmBusquedaTxt()
        {
            InitializeComponent();
        }


        private void btnContarL_Click(object sender, EventArgs e)
        {

            string palabra = tbnTexto.Text.ToLower();

            if (string.IsNullOrWhiteSpace(palabra))
            {

                MessageBox.Show("Debe de ingresar la palabra que desea buscar en el parrafo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {

                int contador = 0;

                foreach (string item in listPalabras)
                {
                    if (item == palabra)
                        contador++;
                }
                rtbTexto.SelectionColor = Color.Green;
                rtbTexto.AppendText($"La palabra {palabra}, aparece {contador}\n");
            }
        }
         

            

            //TexTo Para verificar La fuNcIonalidad


        

        private void btnAgregarP_Click(object sender, EventArgs e)
        {





            string texParrafo = tbParrafo.Text.ToLower();



            if (string.IsNullOrWhiteSpace(texParrafo))
            {
                MessageBox.Show("Debe de ingresar un texto antes de continuar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (texParrafo != null)
            {

                parrafo = texParrafo;

                listPalabras = new List<string>(parrafo.Split(' '));

            }
           
            rtbTexto.AppendText(parrafo + "\n");


        }
    }
}
