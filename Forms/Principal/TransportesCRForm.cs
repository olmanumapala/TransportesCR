/*Segunda Tarea
UNIVERSIDAD ESTATAL A DISTANCIA.
ESCUELA DE CIENCIAS EXACTAS Y NATURALES
DIPLOMADO EN INFORMATICA
INGENIERIA EN INFORMATICA

    Nombre de materia: Programación Avanzada 00830
    Grupo 04
    Fecha de entrega: 23 de abril 2020.

    Estudiante: Olman Umaña Paladino
    Cédula: 114230141
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using TransportesCR.Forms.Asignacion;

namespace TransportesCR
{
    public partial class TransportesCRForm : Form
    {

        //Se realiza configuracion para la conexion a base de datos en el servidor AGSC52K0X, Base de datos TransportesCR
        public SqlConnection conexion = new SqlConnection(@"Data Source=AGSC465DW3;Initial Catalog=TransportesCR;Integrated Security=True");
        public TransportesCRForm()
        {
            InitializeComponent();
        }
        //botones correspondientes a Conductor, Camión, Asignación y Salir
        private void btnConductor_Click(object sender, EventArgs e)
        {

            ConductorForm conductorFormulario = new ConductorForm();
            conductorFormulario.Show();
            this.Hide();
        }
        private void btnCamion_Click(object sender, EventArgs e)
        {
            CamionForm camionFormulario = new CamionForm();
            camionFormulario.Show();
            this.Hide();
        }
        private void btnAsignacion_Click(object sender, EventArgs e)
        {
            AsignacionForm asignacionForm = new AsignacionForm();
            asignacionForm.Show();
            this.Hide();
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
