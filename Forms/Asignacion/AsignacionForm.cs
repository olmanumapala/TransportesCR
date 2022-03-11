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
using System.Collections;

namespace TransportesCR.Forms.Asignacion
{
    //Formulario Asignación
    public partial class AsignacionForm : Form
    {
        string SQLAsignar;
        TransportesCRForm transportesCRForm = new TransportesCRForm();
        SqlDataReader leer;
        //Se crean listas para desplegar la Identificación, placa en los textbox
        List<Conductor> listaIdentificacion = new List<Conductor>();
        List<Camion> listaPlaca = new List<Camion>();
        //Se crea lista de asignación en donde se liga una identificación a una placa.
        List<string> listaAsignacion = new List<string>();
        //Se crea lista de conductor y Camion para mostrar en el dataGrid información tanto de Conductor como del Camión.
        List<Conductor> listaConductor = new List<Conductor>();
        List<Camion> listaDeCamion = new List<Camion>();
        
        Camion camiones = new Camion();
        Conductor conductores = new Conductor();
        public AsignacionForm()
        {
            InitializeComponent();

            ConsultaIdentificacion();
            cmbxID.DataSource = listaIdentificacion;
            cmbxID.DisplayMember = "Identificacion";

            ConsultaPlaca();
            cmbxPL.DataSource = listaPlaca;
            cmbxPL.DisplayMember = "Placa";
        }
        //Colección Genérica para desplegar las identificaciones registradas.
        public List<Conductor> ConsultaIdentificacion()
        {
            transportesCRForm.conexion.Open();
            //Select a la tabla Conductor, solamente mostrara el campo Indentificación
            SqlCommand comandoSelect = new SqlCommand("Select Identificacion from Conductor", transportesCRForm.conexion);
            leer = comandoSelect.ExecuteReader();
            if (leer.HasRows)
            {
                while (leer.Read())
                {
                    listaIdentificacion.Add(new Conductor
                    {
                        Identificacion = leer.GetString(0),
                    });
                }
            }
            transportesCRForm.conexion.Close();
            return listaIdentificacion;
        }
        //Colección Genérica para desplegar las placas registradas.
        public List<Camion> ConsultaPlaca() 
        {
            transportesCRForm.conexion.Open();
            //Select a la tabla Camión, solamente mostrara el campo placa
            SqlCommand comandoSelect = new SqlCommand("Select Placa from Camion", transportesCRForm.conexion);
            leer = comandoSelect.ExecuteReader();
            if (leer.HasRows)
            {
                while (leer.Read())
                {
                    listaPlaca.Add(new Camion
                    {
                        Placa = leer.GetString(0),
                    });
                }
            }
            transportesCRForm.conexion.Close();
            return listaPlaca;
        }
        //Colección Genérica para mostrar la asignación de identificaciones a placas referentes a Conductores y camiones.
        //Se cumple que un conductore puede tener asignado muchos camiones.
        //Un camion solo puede estar asignado a un conductor
        public List<string> ConsultaAsignacion() 
        {
            //listaConductor.Clear();
            //conductores.ListaCamiones = listaPlaca.ToString();
            transportesCRForm.conexion.Open();
            //Join a tablas ConductorCamion(tercera tabla de base de datos), tabla Conductor y tabla Camión
            SqlCommand comandoSelect = new SqlCommand("Select ConductorCamion.Identificacion, Conductor.Nombre, Conductor.PrimerApeliido, Conductor.SegundoApellido, Conductor.RutaAsignada, ConductorCamion.Placa, AnnoModelo, Marca, CapacidadKG, CapacidadVl From ConductorCamion JOIN Conductor ON Conductor.Identificacion = ConductorCamion.Identificacion JOIN Camion ON Camion.Placa = ConductorCamion.Placa ", transportesCRForm.conexion);
            leer = comandoSelect.ExecuteReader();
            if (leer.HasRows)
            {
                while (leer.Read())
                {
                   listaConductor.Add(new Conductor
                    {
                        Identificacion = leer.GetString(0),
                        Nombre = leer.GetString(1),
                        PrimerApellido = leer.GetString(2),
                        SegundoApellido = leer.GetString(3),
                        Ruta = leer.GetString(4),
                        ListaCamiones = leer.GetString(5),
                   });
                    listaDeCamion.Add(new Camion
                    {
                        Placa = leer.GetString(5),
                        Modelo = int.Parse(leer.GetString(6)),
                        Marca = leer.GetString(7),
                        CapacidadKG = leer.GetDecimal(8),
                        CapacidadVL = leer.GetDecimal(9),
                    });
                }
            }
            transportesCRForm.conexion.Close();
            return listaAsignacion;
        }
        //Boton que  asigna una identificación a placa
        private void btnAsignar_Click(object sender, EventArgs e)
        {
            try
            {
                transportesCRForm.conexion.Open();
                DialogResult result = MessageBox.Show("¿Desea realizar la asignación?", "Confirmación", 
                                                     MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    //Select a tabla ConductorCamion donde se ocupa saber la placa
                    SqlCommand validar = new SqlCommand("Select * from ConductorCamion Where Placa = '" + cmbxPL.Text + "'", transportesCRForm.conexion);
                    int cantidad = Convert.ToInt32(validar.ExecuteScalar());
                    //Si la placa aun no esta asignada, realizará la inserción
                    if (cantidad == 0)
                    {
                        //Inserción a tabla ConductorCamion de campos Identificación y Placa
                        SQLAsignar = "INSERT INTO ConductorCamion VALUES ('" + cmbxID.Text + "','" + cmbxPL.Text + "')";
                        SqlCommand asignar = new SqlCommand(SQLAsignar, transportesCRForm.conexion);
                        asignar.ExecuteNonQuery();
                        MessageBox.Show("Asignación realizada");
                    }
                    //Si la placa se encuentra asignada, no realizará la inserción
                    else 
                    {
                        dataGrVwAsignaciones.DataSource = "";
                        MessageBox.Show("Asignación NO realizada." + Environment.NewLine + 
                                        "La placa del camión ya se encuentra asignada. Intente la asignación con otra placa " +
                                        "o registre un nuevo camión.",
                                    "Information Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    
                }
                else 
                {
                    MessageBox.Show("Asignación NO realizada");
                }
            }
            catch
            {
                MessageBox.Show("Error en la asignación" + Environment.NewLine + "Contacte a administración",
                                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            transportesCRForm.conexion.Close();
        }
        private void btnConsultarAsignacion_Click(object sender, EventArgs e)
        {
            ConsultaAsignacion();//Es el metodo que llamara a recorrer la colección genérica.
            dataGrVwAsignaciones.DataSource = listaConductor;
            cmbxID.Text = ""; cmbxPL.Text = "";
        }
        private void btnRegresarAsignacion_Click(object sender, EventArgs e)
        {
            transportesCRForm.Show();
            this.Hide();
        }
    }
}
