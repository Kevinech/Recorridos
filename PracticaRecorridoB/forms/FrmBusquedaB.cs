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
    public partial class FrmBusquedaB : MetroFramework.Forms.MetroForm
    {
        public FrmBusquedaB()
        {
            InitializeComponent();
        }

        List<int> numerosOr = new List<int>();
        int[] arreglo = new int[30];

        private void btnGenerarN_Click(object sender, EventArgs e)
        {
            lbNumero.Items.Clear();

            Random numeroA = new Random();


            for (int i = 0; i < arreglo.Length; i++)
            {

                arreglo[i] = numeroA.Next(0, 30);
                numerosOr.Add(arreglo[i]);
                lbNumero.Items.Add(arreglo[i]);


            }
            



        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {


            lbNumero.Items.Clear();
            numerosOr.Sort();
            lbNumero.Items.Add(numerosOr);
            



        }
    }
}
