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
    public partial class FrmMaxMin : Form
    {
        public FrmMaxMin()
        {
            InitializeComponent();
        }

        private void btnBuscarMaxMin_Click(object sender, EventArgs e)
        {
            // Leer la cadena de números del TextBox
            string entrada = tbNumeros.Text;
            if (string.IsNullOrWhiteSpace(entrada))
            {
                MessageBox.Show("Ingrese una lista de números separados por coma.", "Error");
                return;
            }

            // Convertir la cadena en lista de enteros
            string[] partes = entrada.Split(',');
            List<int> listaNumeros = new List<int>();

            foreach (string strNum in partes)
            {
                int num;
                if (int.TryParse(strNum.Trim(), out num))
                {
                    listaNumeros.Add(num);
                }
            }

            if (listaNumeros.Count == 0)
            {
                MessageBox.Show("No se ingresaron números válidos.", "Error");
                return;
            }

            // Buscar máximo, mínimo e iteraciones
            int maximo, minimo, ciclos;
            BuscarMaxMin(listaNumeros, out maximo, out minimo, out ciclos);

            // Presentar el resultado en el RichTextBox
            rtbResultado.Clear();
            rtbResultado.AppendText($"Máximo: {maximo}\n");
            rtbResultado.AppendText($"Mínimo: {minimo}\n");
            rtbResultado.AppendText($"Iteraciones realizadas: {ciclos}\n");

        }
        private void BuscarMaxMin(List<int> listaEnteros, out int max, out int min, out int iteraciones)
        {
            if (listaEnteros == null || listaEnteros.Count == 0)
            {
                throw new ArgumentException("La lista no puede estar vacía.");
            }

            max = listaEnteros[0];
            min = listaEnteros[0];
            iteraciones = 0;

            foreach (int valor in listaEnteros)
            {
                iteraciones++;
                if (valor > max)
                    max = valor;
                if (valor < min)
                    min = valor;
            }
        }

    }
}
