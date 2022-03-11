using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TransportesCR.Class
{
    public class Conductor
    {
        //atributos de clase Conductor
        private string identificacion;
        private string nombre;
        private string primerApellido;
        private string segundoApellido;
        private string ruta;
        private string listaCamiones;
        //Set y Get
        public string Identificacion { get { return identificacion; } set { identificacion = value; } }
        public string Nombre { get { return nombre; } set { nombre = value; } }
        public string PrimerApellido { get { return primerApellido; } set { primerApellido = value; } }
        public string SegundoApellido { get { return segundoApellido; } set { segundoApellido = value; } }
        public string Ruta { get { return ruta; } set { ruta = value; } }
        public string ListaCamiones { get { return listaCamiones; } set { listaCamiones = value; } }
        //Constructor con parámetros
        public Conductor(string cIdentificacion, string cNombre, string cPrimerApellido, string cSegundoApellido, string cRuta, string cListaCamiones)
        {
            this.identificacion = cIdentificacion;
            this.nombre = cNombre;
            this.primerApellido = cPrimerApellido;
            this.segundoApellido = cSegundoApellido;
            this.ruta = cRuta;
            this.listaCamiones = cListaCamiones;
        }
        //Constructor sin parámetros
        public Conductor() { }
    }
}
