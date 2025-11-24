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
            rtbResultados.SelectionColor = Color.BlueViolet;
            rtbResultados.AppendText("Matriz generada y mostrada en el DataGridView.\n");
        }

        private void btnBuscarN_Click(object sender, EventArgs e)
        {
            int numeroBuscado;
            if (!int.TryParse(tbbuscarN.Text, out numeroBuscado))
            {
                MessageBox.Show("Ingrese un número válido.", "Error");
                return;
            }

            int repeticiones = 0;
            List<string> posiciones = new List<string>();

            // Limpiar colores previos
            foreach (DataGridViewRow row in dgvMatriz.Rows)
                foreach (DataGridViewCell cell in row.Cells)
                    cell.Style.BackColor = Color.White;

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (matriz[i, j] == numeroBuscado)
                    {
                        repeticiones++;
                        posiciones.Add($"({i},{j})");
                        // Resaltar celda en DataGridView
                        dgvMatriz.Rows[i].Cells[j].Style.BackColor = Color.Yellow;
                    }
                }
            }

            rtbResultados.AppendText($"\nNúmero buscado: {numeroBuscado}\n");
            if (repeticiones == 0)
            {
                rtbResultados.SelectionColor = Color.Red;
                rtbResultados.AppendText("No encontrado en la matriz.\n");

            } 
            else
            {
                rtbResultados.SelectionColor = Color.Green;
                rtbResultados.AppendText($"Encontrado {repeticiones} veces en las posiciones: {string.Join(", ", posiciones)}\n");
                rtbResultados.ScrollToCaret();
            }
                
        }


    }
}

