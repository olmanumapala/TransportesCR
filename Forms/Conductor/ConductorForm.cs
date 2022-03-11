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

namespace TransportesCR
{
    //Formulario constructor
    public partial class ConductorForm : Form
    {
        string SQLConductor;
        TransportesCRForm transportesCRForm = new TransportesCRForm();
        public ConductorForm()
        {
            InitializeComponent();
        }
        private void btnRegresarConductor_Click(object sender, EventArgs e)
        {
            transportesCRForm.Show();
            this.Hide();
        }
        //Realiza el registro de un conductor nuevo
        public void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                transportesCRForm.conexion.Open();
                if (txtboxIde.Text != "" && txtboxNom.Text != "" && txtboxApe1.Text != "" && txtboxApe2.Text != "" && rchtxtboxRuta.Text != "")
                {
                    //Inserción de registro a la tabla Conductor
                    //Se abre conexion a la base de datos. Despues de insertar, cierra la conexión.
                    SQLConductor = "INSERT INTO Conductor VALUES ('" + txtboxIde.Text + "','" + txtboxNom.Text + "','" + txtboxApe1.Text + "','" + txtboxApe2.Text + "','" + rchtxtboxRuta.Text + "')";

                    SqlCommand comandoInsertar = new SqlCommand(SQLConductor, transportesCRForm.conexion);
                    comandoInsertar.ExecuteNonQuery();
                    MessageBox.Show("Conductor Registrado");
                    txtboxIde.Clear(); txtboxNom.Clear(); txtboxApe1.Clear(); txtboxApe2.Clear(); rchtxtboxRuta.Clear();
                }
                else
                {
                    MessageBox.Show("Conductor NO registrado." + Environment.NewLine + "Todos los campos deben ser rellenados.",
                 "Information Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch
            {
                MessageBox.Show("Identificación ya existe." + Environment.NewLine 
                              + "Consulte la identificación en el boton de Mostrar de este registro",
                                "Information Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            transportesCRForm.conexion.Close();

        }
        //Boton que redirige a un nuevo formulario, Mostrar Conductor. Aca se podran observar los conductores registrados
        private void btn_MostrarConductor_Click(object sender, EventArgs e)
        {
            try
            {
                transportesCRForm.conexion.Open();
                SqlCommand comandoSelect = new SqlCommand("Select * from Conductor", transportesCRForm.conexion);
                int cantidad = Convert.ToInt32(comandoSelect.ExecuteScalar());
                if (cantidad == 0)
                {
                    MessageBox.Show("No hay conductores registrados" + Environment.NewLine + "Favor realizar registro de conductor",
                                    "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MostrarConductorForm mostrarConductorForm = new MostrarConductorForm();
                    mostrarConductorForm.Show();
                    this.Hide();
                }
            }
            catch 
            {
                MessageBox.Show("No hay conductores registrados" + Environment.NewLine + "Favor realizar registro de conductor",
                                    "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            transportesCRForm.conexion.Close();
        }
    }
}