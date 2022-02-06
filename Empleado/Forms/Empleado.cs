#region Usos
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#endregion

namespace Forms
{
    public class Empleado
    {
        #region Variables Principales
        private int Numero;
        private string Nombre;
        private double Sueldo;
        #endregion

        #region Get y set
        public int Numeros { get; set; }
        public string Nombres { get; set; }
        public double Sueldos { get; set; }
        #endregion
    }
}