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
using TransportesCR.Class;

namespace TransportesCR
{
    //Formulario Mostrar Conductor
    public partial class MostrarConductorForm : Form
    {
        TransportesCRForm transportesCRForm = new TransportesCRForm();
        SqlDataReader leer;
        List<Conductor> listaConductores = new List<Conductor>();
        public MostrarConductorForm()
        {
            InitializeComponent();
        }
        //Colección Genérica para mostrar la lista de conductores en el dataGrid
        public List<Conductor> ConsultaConductores()
        {
            //Se realiza conexión a base de datos, se realiza un comando select a tabla conductor. 
            //Este comando mostrara la información registrada para cada conductor.
            SqlCommand comandoSelect = new SqlCommand("Select * from Conductor", transportesCRForm.conexion);
            transportesCRForm.conexion.Open();
            leer = comandoSelect.ExecuteReader();
            if (leer.HasRows)
            {
                while (leer.Read())
                {
                    listaConductores.Add(new Conductor
                    {
                        Identificacion = leer.GetString(0),
                        Nombre = leer.GetString(1),
                        PrimerApellido = leer.GetString(2),
                        SegundoApellido = leer.GetString(3),
                        Ruta = leer.IsDBNull(4) ? string.Empty : leer.GetString(4)
                    });
                }
            }
            transportesCRForm.conexion.Close();
            return listaConductores;
        }
        private void btnRegresaRegistroConductor_Click(object sender, EventArgs e)
        {
            ConductorForm conductorForm = new ConductorForm();
            conductorForm.Show();
            this.Hide();
        }
        private void btnConsultaDatosConduc_Click(object sender, EventArgs e)
        {
            ConsultaConductores();//Es el metodo que llamara a recorrer la colección genérica.
            dataGrVwConductores.DataSource = listaConductores;
            dataGrVwConductores.Columns["ListaCamiones"].Visible = false;
        }
    }
}
