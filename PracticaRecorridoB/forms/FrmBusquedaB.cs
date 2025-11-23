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

        private List<int> lista = new List<int>();
        private Random rand = new Random();
        



        public FrmBusquedaB()
        {
            InitializeComponent();


        }

        

        private void btnGenerarN_Click(object sender, EventArgs e)
        {

            lista.Clear();


            for (int i = 0; i < 30; i++)
            {
                lista.Add(rand.Next(1, 101));
            }

            lbNumero.Items.Clear();
            foreach (var num in lista)
            {
                lbNumero.Items.Add(num);
            }
            
           


        }

       
        private void btnOrdenar_Click(object sender, EventArgs e)
        {

            lista.Sort();

            lbNumero.Items.Clear();
            foreach (var num in lista)
            {

                lbNumero.Items.Add(num);


            }




        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            int numBuscar;

            if (!int.TryParse(tbBuscarN.Text, out numBuscar))
            {
                MessageBox.Show("Ingrese un numero entero");
            }


            int inicio = 0;
            int fin = lista.Count - 1;
            rtbResultado.Clear();
            bool encontrado = false;

            while (inicio <= fin)
            {
                int mitad = (inicio + fin) / 2;
                int vMitad = lista[mitad];

                rtbResultado.SelectionColor = Color.Blue;
                rtbResultado.AppendText($"Buscando entre índices {inicio} y {fin}, mitad {mitad} (valor {vMitad})\n");

                if (vMitad == numBuscar)
                {
                    rtbResultado.SelectionColor = Color.Green;
                    rtbResultado.AppendText($"Número {numBuscar} encontrado en la posición {mitad}.\n");
                    encontrado = true;
                    // Aquí colocamos el break para terminar el ciclo
                    break;
                }
                else if (vMitad < numBuscar)
                {
                    inicio = mitad + 1;
                }
                else
                {
                    fin = mitad - 1;
                }
            
            }

            if (!encontrado)
            {
                rtbResultado.SelectionColor = System.Drawing.Color.Red;
                rtbResultado.AppendText($"Número {numBuscar} no se encontró en la lista.");

            }
            rtbResultado.ScrollToCaret();

            


        }
    }
}
