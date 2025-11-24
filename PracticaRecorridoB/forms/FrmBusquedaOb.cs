using PracticaRecorridoB.Clases;
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
    public partial class FrmBusquedaOb : Form
    {


        private List<Estudiantes> listEstudiantes = new List<Estudiantes>();


        public FrmBusquedaOb()
        {
            InitializeComponent();
            GetEstudiantes();
        }


        private void GetEstudiantes()
        {

            listEstudiantes.Add(new Estudiantes { Nombre = "Carlos", Id = "101" });
            listEstudiantes.Add(new Estudiantes { Nombre = "Ana", Id = "102" });
            listEstudiantes.Add(new Estudiantes { Nombre = "Luis", Id = "103" });
            listEstudiantes.Add(new Estudiantes { Nombre = "María", Id = "104" });
            listEstudiantes.Add(new Estudiantes { Nombre = "Jorge", Id = "105" });
            listEstudiantes.Add(new Estudiantes { Nombre = "Sofía", Id = "106" });
            listEstudiantes.Add(new Estudiantes { Nombre = "Pedro", Id = "107" });
            listEstudiantes.Add(new Estudiantes { Nombre = "Lucía", Id = "108" });
            listEstudiantes.Add(new Estudiantes { Nombre = "Marco", Id = "109" });
            listEstudiantes.Add(new Estudiantes { Nombre = "Elena", Id = "110" });

            lbListaEstudiantes.Items.Clear();
            foreach (var est in listEstudiantes)
            {
                lbListaEstudiantes.Items.Add($"{est.Nombre} - {est.Id}");
            }



        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            string buscarNombre = tbNombreE.Text.Trim();
            if (string.IsNullOrWhiteSpace(buscarNombre))
            {
                MessageBox.Show("Debe ingresar un nombre.", "Error");
                return;
            }

            // Ordenar la lista por nombre antes de buscar
            listEstudiantes = listEstudiantes.OrderBy(est => est.Nombre).ToList();

            int inicio = 0;
            int fin = listEstudiantes.Count - 1;
            Estudiantes resultado = null;

            while (inicio <= fin)
            {
                int mid = (inicio + fin) / 2;
                int cmp = string.Compare(listEstudiantes[mid].Nombre, buscarNombre, StringComparison.OrdinalIgnoreCase);

                if (cmp == 0)
                {
                    resultado = listEstudiantes[mid];
                    break;
                }
                else if (cmp < 0)
                {
                    inicio = mid + 1;
                }
                else
                {
                    fin = mid - 1;
                }
            }

            if (resultado != null)
            {
                rtbMostrarR.SelectionColor = Color.Green;
                rtbMostrarR.AppendText("Estudiante encontrado\n");
                rtbMostrarR.AppendText($"Nombre: {resultado.Nombre}\nID: {resultado.Id}\n");


            }
            else
            {

                rtbMostrarR.SelectionColor = Color.Red;
                rtbMostrarR.AppendText("Estudiante no encontrado\n");

            }
               
            
        }

        private void btnBuscarI_Click(object sender, EventArgs e)
        {


            string buscarId = tbIdEstudiante.Text.Trim();
            if (string.IsNullOrWhiteSpace(buscarId))
            {
                MessageBox.Show("Debe ingresar un Id.", "Error");
                return;
            }

            Estudiantes resultado = null;

            foreach (var est in listEstudiantes)
            {
                if (est.Id == buscarId)
                {
                    resultado = est;
                    break;
                }
            }

            if (resultado != null)
            {
                rtbMostrarR.SelectionColor = Color.Green;
                rtbMostrarR.AppendText("Estudiante encontrado\n");
                rtbMostrarR.AppendText($"Nombre: {resultado.Nombre}\nID: {resultado.Id}\n");


            }
            else
            {

                rtbMostrarR.SelectionColor = Color.Red;
                rtbMostrarR.AppendText("Estudiante no encontrado\n");

            }
        }






    }
}


    





