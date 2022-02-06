#region Usos
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
#endregion

namespace Forms
{
    public partial class frmEmpleado : Form
    {
        #region Variables Globales
        Empleado Emp = new Empleado();
        List<Empleado> MiEmpresa = new List<Empleado>();
        Empleado MiEmpleado;
        #endregion

        #region Inicializar Formulario Empleado
        public frmEmpleado()
        {
            InitializeComponent();

            MiEmpleado = new Empleado();

            dgvInfo.Columns.Add("Numeros", "Numeros");
            dgvInfo.Columns.Add("Nombres", "Nombres");
            dgvInfo.Columns.Add("Sueldos", "Sueldos");

            dgvInfo.ReadOnly = true;
            dgvInfo.AllowUserToAddRows = false;
            dgvInfo.AllowUserToDeleteRows = false;
            dgvInfo.AutoSizeColumnsMode =
            DataGridViewAutoSizeColumnsMode.Fill;
        }
        #endregion

        #region Boton Insertar Click
        private void btnInsert_Click(object sender, EventArgs e)
        {
            Emp.Numeros = int.Parse(txtNumero.Text);
            Emp.Nombres = txtNombre.Text;
            Emp.Sueldos = double.Parse(txtSueldo.Text);

            MiEmpresa.Add(Emp);

            //foreach (Empledo miEmpleado in MiEmpresa)
            //{
            dgvInfo.Rows.Add(Emp.Numeros,
            Emp.Nombres, Emp.Sueldos);
            //}

            txtNombre.Clear();
            txtNumero.Clear();
            txtSueldo.Clear();
            txtNombre.Focus();
        }
        #endregion

        #region Radio Boton Contador Activated
        private void rbContadorActivated_CheckedChanged(object sender, EventArgs e)
        {
            lblRegistro.Visible = true;
            lblContador.Visible = true;
            lblContador.Text = this.MiEmpresa.Count.ToString();
        }
        #endregion

        #region Radio Boton Contador Inactivated
        private void rbContadorInactivated_CheckedChanged(object sender, EventArgs e)
        {
            lblContador.Visible = false;
            lblRegistro.Visible = false;
        }
        #endregion

        #region Boton Eliminar Click
        private void btnClean_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            txtNumero.Clear();
            txtSueldo.Clear();
            txtNombre.Focus();
            dgvInfo.Rows.Clear();
        }
        #endregion
    }
}