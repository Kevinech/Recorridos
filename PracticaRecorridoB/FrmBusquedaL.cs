using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaRecorridoB
{
    public partial class FrmBusquedaL : MetroFramework.Forms.MetroForm
    {
        public FrmBusquedaL()
        {
            InitializeComponent();
        }


        int[] arreglo = new int[20];

        
        private void btnGenerarN_Click(object sender, EventArgs e)
        {
            lbNumeros.Items.Clear();

            Random random = new Random();

            for (int i = 0; i < 20; i++)
            {
                arreglo[i] = random.Next(1, 20);

                lbNumeros.Items.Add(arreglo[i]);
            }


        }

        private void btnBuscarN_Click(object sender, EventArgs e)
        {
            int numeroBuscado;
            bool esNumero = int.TryParse(tbBuscar.Text, out numeroBuscado);

            if (!esNumero)
            {
                MessageBox.Show("Por favor ingrese un número válido.");
                return;
            }

            int posicion = -1;
            for (int i = 0; i < arreglo.Length; i++)
            {
                if (arreglo[i] == numeroBuscado)
                {
                    posicion = i;
                    break;
                }
            }

            if (posicion != -1)
               MessageBox.Show($"El número se encuentra en la posición: {posicion}");
            else
                MessageBox.Show("El número no existe en el arreglo.");
        }


    }
    
}
