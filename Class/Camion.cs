using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportesCR.Class
{
   public class Camion
    {
        //atributos de clase Camion
        private string placa;
        private int modelo;
        private string marca;
        private decimal capacidadKG;
        private decimal capacidadVL;
        //Set y Get
        public string Placa { get { return placa; } set { placa = value; } }
        public int Modelo { get { return modelo; } set { modelo = value; } }
        public string Marca { get { return marca; } set { marca = value; } }
        public decimal CapacidadKG { get { return capacidadKG; } set { capacidadKG = value; } }
        public decimal CapacidadVL { get { return capacidadVL; } set { capacidadVL = value; } }
        //Camion con parámetros
        public Camion(string cPlaca, int cModelo, string cMarca, decimal cCapacidadKG, decimal cCapacidadVL)
        {
            this.placa = cPlaca;
            this.modelo = cModelo;
            this.marca = cMarca;
            this.CapacidadKG = cCapacidadKG;
            this.CapacidadVL = cCapacidadVL;
        }
        //Camion sin parámetros
        public Camion() { }
    }
}
