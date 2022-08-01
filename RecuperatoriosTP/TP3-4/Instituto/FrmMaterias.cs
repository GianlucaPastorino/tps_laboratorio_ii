using System;
using System.Windows.Forms;
using Entidades;

namespace Instituto
{
    public partial class FrmMaterias : Form, IActualizarDgv
    {
        public FrmMaterias()
        {
            InitializeComponent();
        }

        public void ActualizarDgv()
        {
            dgvMaterias.Rows.Clear();

            foreach (Materia materia in Institucion.Materias)
            {
                dgvMaterias.Rows.Add(materia.IdMateria, materia.Nombre, materia.Modalidad, materia.Dia, materia.Turno, materia.CupoMaximo,
                    materia.Alumnos.Count, materia.CupoDisponible);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmNuevaMateria frmNuevaMateria = new FrmNuevaMateria();
            frmNuevaMateria.ShowDialog();
            if (frmNuevaMateria.DialogResult == DialogResult.OK)
            {
                ActualizarDgv();
            }
        }

        private void FrmMaterias_Load(object sender, EventArgs e)
        {
            Institucion.ActualizarMaterias();
            ActualizarDgv();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro que desea eliminar la materia seleccionada?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                == DialogResult.Yes)
            {
                if (Institucion.EliminarMateria((int)dgvMaterias.CurrentRow.Cells[0].Value))
                {
                    ActualizarDgv();
                }
                else
                {
                    MessageBox.Show("No se puede eliminar una materia con alumnos inscrpitos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dgvMaterias_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show(Institucion.BuscarMateriaPorId((int)dgvMaterias.CurrentRow.Cells[0].Value).ObtenerInformacion(), "Materia", MessageBoxButtons.OK);
        }
    }
}
