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
    public partial class FrmMatriz : Form
    {
        public FrmMatriz()
        {
            InitializeComponent();
        }

        private int[,] matriz = new int[10, 10];
        private Random rnd = new Random();

        private void btnGenerarMatriz_Click(object sender, EventArgs e)
        {
            // Generar matriz
            for (int i = 0; i < 10; i++)
                for (int j = 0; j < 10; j++)
                    matriz[i, j] = rnd.Next(1, 100);

            // Mostrar matriz en DataGridView
            dgvMatriz.Rows.Clear();
            dgvMatriz.Columns.Clear();

            // Crear columnas
            for (int j = 0; j < 10; j++)
                dgvMatriz.Columns.Add($"Col{j}", $"Col {j}");

            // Agregar filas
            for (int i = 0; i < 10; i++)
            {
                object[] fila = new object[10];
                for (int j = 0; j < 10; j++)
                    fila[j] = matriz[i, j];
                dgvMatriz.Rows.Add(fila);
            }

            rtbResultados.Clear();
            rtbResultados.AppendText("Matriz generada y mostrada en el DataGridView.");
        }

    }
}
