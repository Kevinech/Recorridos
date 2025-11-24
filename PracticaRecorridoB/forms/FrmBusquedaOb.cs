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

            string nombreE = tbNombreE.Text;





        }
    }

    




}
