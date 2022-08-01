using System;
using System.Windows.Forms;
using Entidades;

namespace Instituto
{
    public partial class FrmAlumnos : Form, IActualizarDgv
    {
        public FrmAlumnos()
        {
            InitializeComponent();
        }

        private void FrmAlumnos_Load(object sender, EventArgs e)
        {
            Institucion.ActualizarEstadoAlumnos();
            ActualizarDgv();
        }

        public void ActualizarDgv()
        {
            dgvAlumnos.Rows.Clear();

            foreach (Alumno alumno in Institucion.Alumnos)
            {
                dgvAlumnos.Rows.Add(alumno.Dni, alumno.Nombre, alumno.Apellido, alumno.Estado);
            }

            if (dgvAlumnos.Rows.Count == 0)
            {
                btnRenovar.Enabled = false;
            }
            else if (Institucion.BuscarAlumnoPorDni((int)dgvAlumnos.CurrentRow.Cells[0].Value).Estado == EEstado.Activo)
            {
                btnRenovar.Enabled = false;
            }
            else
            {
                btnRenovar.Enabled = true;
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            FrmAltaAlumno frmAltaAlumno = new FrmAltaAlumno();
            frmAltaAlumno.ShowDialog();
            if (frmAltaAlumno.DialogResult == DialogResult.OK)
            {
                ActualizarDgv();
            }
        }

        private void btnRenovar_Click(object sender, EventArgs e)
        {
            FrmPlan frmPlan = new FrmPlan(Institucion.BuscarAlumnoPorDni((int)dgvAlumnos.CurrentRow.Cells[0].Value));
            frmPlan.ShowDialog();
            if (frmPlan.DialogResult == DialogResult.OK)
            {
                ActualizarDgv();
            }
        }

        private void dgvAlumnos_SelectionChanged(object sender, EventArgs e)
        {
            Alumno auxAlumno = Institucion.BuscarAlumnoPorDni((int)dgvAlumnos.CurrentRow.Cells[0].Value);
            if (auxAlumno.Estado == EEstado.Inactivo || auxAlumno.Estado == EEstado.Impago)
            {
                btnRenovar.Enabled = true;
            }
            else
            {
                btnRenovar.Enabled = false;
            }
        }

        private void dgvAlumnos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show(Institucion.BuscarAlumnoPorDni((int)dgvAlumnos.CurrentRow.Cells[0].Value).ObtenerInformacion(), "Alumno", MessageBoxButtons.OK);
        }
    }
}
