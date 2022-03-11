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
    //Formulario Mostrar Camión
    public partial class MostrarCamionForm : Form
    {
        TransportesCRForm transportesCRForm = new TransportesCRForm();
        SqlDataReader leer;
        List<Camion> listaDeCamiones = new List<Camion>();
        public MostrarCamionForm()
        {
            InitializeComponent();
        }
        //Colección Genérica para mostrar la lista de camiones en el dataGrid
        public List<Camion> ConsultaCamiones()
        {
            //Se realiza conexión a base de datos, se realiza un comando select a tabla camión. 
            //Este comando mostrara la información registrada para cada camión.
            SqlCommand comandoSelect = new SqlCommand("Select * from Camion", transportesCRForm.conexion);
            transportesCRForm.conexion.Open();
            leer = comandoSelect.ExecuteReader();
            if (leer.HasRows)
            {
                while (leer.Read())
                {
                    listaDeCamiones.Add(new Camion
                    {
                        Placa = leer.GetString(0),
                        Modelo = int.Parse(leer.GetString(1)),
                        Marca = leer.GetString(2),
                        CapacidadKG = leer.GetDecimal(3),
                        CapacidadVL = leer.GetDecimal(4),
                    });
                }
            }
            transportesCRForm.conexion.Close();
            return listaDeCamiones;
        }
        private void btnRegresaRegistroCamion_Click(object sender, EventArgs e)
        {
            CamionForm camionForm = new CamionForm();
            camionForm.Show();
            this.Hide();
        }
        private void btnConsultaDatosCami_Click(object sender, EventArgs e)
        {
            ConsultaCamiones();//Es el metodo que llamara a recorrer la colección genérica.
            dataGrVwCamiones.DataSource = listaDeCamiones;
        }
    }
}