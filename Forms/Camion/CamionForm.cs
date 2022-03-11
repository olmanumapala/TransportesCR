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
    //Formulario Camión
    public partial class CamionForm : Form
    {
        string SQLCamion;
        TransportesCRForm transportesCRForm = new TransportesCRForm();
        public CamionForm()
        {
            InitializeComponent();
        }
        private void btnRegresarCamion_Click(object sender, EventArgs e)
        {
            TransportesCRForm transportesCRForm = new TransportesCRForm();
            transportesCRForm.Show();
            this.Hide();
        }
        private void txtboxKG_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 8)//Codigo ASCI del Espacio
            {
                e.Handled = false;
                return;
            }
            bool esDecimal = false;
            int numeroDec = 0;
            for (int i = 0; i < txtboxKG.Text.Length; i++)
            {
                if (txtboxKG.Text[i] == '.')//Si el valor no es un número entero. Despues del punto se pueden ingresar 2 digitos
                    esDecimal = true;
                if (esDecimal && numeroDec++ >= 2)
                {
                    e.Handled = true;
                    return;
                }
            }
            if (e.KeyChar >= 48 && e.KeyChar <= 57)//Solo se permiten digitos en base 10
                e.Handled = false;
            else if (e.KeyChar == 46) 
                e.Handled = (esDecimal) ? true : false;
            else
                e.Handled = true;
        }
        private void txtboxVL_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 8)//Codigo ASCI del Espacio
            {
                e.Handled = false;
                return;
            }
            bool esDecimal = false;
            int numeroDec = 0;
            for (int i = 0; i < txtboxVL.Text.Length; i++)
            {
                if (txtboxVL.Text[i] == '.')//Si el valor no es un número entero. Despues del punto se pueden ingresar 2 digitos
                    esDecimal = true;
                if (esDecimal && numeroDec++ >= 2)
                {
                    e.Handled = true;
                    return;
                }
            }
            if (e.KeyChar >= 48 && e.KeyChar <= 57)//Solo se permiten digitos en base 10
                e.Handled = false;
            else if (e.KeyChar == 46)//un 
                e.Handled = (esDecimal) ? true : false;
            else
                e.Handled = true;
        }
        //Realiza el registro de un conductor nuevo
        private void btnGuardarCamion_Click(object sender, EventArgs e)
        {
            try
            {
                //Inserción de registro a la tabla Camión
                //Se abre conexion a la base de datos. Despues de insertar, cierra la conexión.
                transportesCRForm.conexion.Open();
                if (txtboxPlaca.Text != "" && txtboxModelo.Text != "" && txtboxMarca.Text != "" && txtboxKG.Text != "" && txtboxVL.Text != "")
                {
                    SQLCamion = "INSERT INTO Camion VALUES ('" + txtboxPlaca.Text + "','" + txtboxModelo.Text + "','" + txtboxMarca.Text + "','" + txtboxKG.Text + "','" + txtboxVL.Text + "')";

                    SqlCommand comandoInsertar = new SqlCommand(SQLCamion, transportesCRForm.conexion);
                    comandoInsertar.ExecuteNonQuery();
                    MessageBox.Show("Camión Registrado");
                    txtboxPlaca.Clear(); txtboxModelo.Clear(); txtboxMarca.Clear(); txtboxKG.Clear(); txtboxVL.Clear();
                }
                else
                {
                    MessageBox.Show("Camión NO registrado." + Environment.NewLine + "Todos los campos deben ser rellenados.",
                                    "Information Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch
            {
                MessageBox.Show("Placa ya existe." + Environment.NewLine
                              + "Consulte la placa en el boton de Mostrar de este registro",
                                "Information Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            transportesCRForm.conexion.Close();
        }
        //Método que permite al textBox Modelo solo ingresar numeros
        private void txtboxModelo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        //Boton que redirige a un nuevo formulario, Mostrar Camión. Aca se podran observar los camiones registrados
        private void btn_MostrarCamion_Click(object sender, EventArgs e)
        {
            try
            {
                transportesCRForm.conexion.Open();
                SqlCommand comandoSelect = new SqlCommand("Select * from Conductor", transportesCRForm.conexion);
                int cantidad = Convert.ToInt32(comandoSelect.ExecuteScalar());
                if (cantidad == 0)
                {
                    MessageBox.Show("No hay camiones registrados" + Environment.NewLine + "Favor realizar registro de camión",
                                    "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MostrarCamionForm mostrarCamionForm = new MostrarCamionForm();
                    mostrarCamionForm.Show();
                    this.Hide();
                }
            }
            catch 
            {
                MessageBox.Show("No hay camiones registrados" + Environment.NewLine + "Favor realizar registro de camión",
                                    "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            transportesCRForm.conexion.Close();
        }
    }
}
