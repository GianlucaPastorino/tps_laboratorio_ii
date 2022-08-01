using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Entidades;

namespace Instituto
{
    public partial class FrmPlan : Form, IActualizarDgv
    {
        private List<Materia> materiasAux;
        private Alumno auxAlumno;
        private Plan auxPlan;

        public FrmPlan(Alumno alumno)
        {
            InitializeComponent();
            materiasAux = new List<Materia>();
            auxAlumno = alumno;
            Institucion.PagoRealizado += NotificarPlanCreado;
        }

        private void FrmPlan_Load(object sender, EventArgs e)
        {
            cboTipo.DataSource = Enum.GetValues(typeof(ETipo));
            cboTipo.SelectedIndex = 0;
            ActualizarLblVencimiento();
            cboMedioDePago.DataSource = Enum.GetValues(typeof(EMedioDePago));
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea confirmar?", "Pagar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                auxPlan = new Plan(auxAlumno, (int)numMaterias.Value, materiasAux, (ETipo)cboTipo.SelectedItem,
                (EMedioDePago)cboMedioDePago.SelectedItem);
                Institucion.AgregarVenta(auxPlan);

                this.DialogResult = DialogResult.OK;
            }
        }

        private void cboTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActualizarLblVencimiento();
        }

        private void ActualizarLblVencimiento()
        {
            lblVencimiento.Text = "Vto.: " + Plan.CalcularFechaVencimiento((ETipo)cboTipo.SelectedItem).ToString("dd/MM/yyyy");
        }

        private void ActualizarLblPrecio()
        {
            lblPrecio.Text = "Precio: $" + Plan.CalcularPrecio((ETipo)cboTipo.SelectedItem, (int)numMaterias.Value);
        }

        private void ActualizarSeleccion()
        {
            if (materiasAux.Count < numMaterias.Value)
            {
                lblSeleccionarMateria.Text = "Seleccionar Materia " + (materiasAux.Count + 1);
            }
            else
            {
                btnOkMateria.Enabled = false;
                dgvMaterias.Rows.Clear();
                dgvMaterias.Enabled = false;
                lblSeleccionarMateria.Text = "Proceda al pago";
                btnPagar.Enabled = true;
            }
        }

        public void ActualizarDgv()
        {
            dgvMaterias.Rows.Clear();

            foreach (Materia materia in Institucion.Materias)
            {
                if (materia.CupoDisponible > 0)
                {
                    if (!materiasAux.Contains(materia))
                    {
                        dgvMaterias.Rows.Add(materia.IdMateria, materia.Nombre, materia.Modalidad, materia.Dia, materia.Turno,
                            materia.CupoMaximo, materia.CupoDisponible);
                    }
                }
            }
        }

        private void btnOkPlan_Click(object sender, EventArgs e)
        {
            cboTipo.Enabled = false;
            numMaterias.Enabled = true;
            btnOkCantidad.Enabled = true;
            btnOkPlan.Enabled = false;
        }

        private void btnOkCantidad_Click(object sender, EventArgs e)
        {
            numMaterias.Enabled = false;
            dgvMaterias.Enabled = true;
            ActualizarDgv();
            if (dgvMaterias.Rows.Count > 0)
            {
                btnOkMateria.Enabled = true;
            }
            btnOkCantidad.Enabled = false;
            ActualizarLblPrecio();
        }

        private void btnOkMateria_Click(object sender, EventArgs e)
        {
            Materia aux = Institucion.BuscarMateriaPorId((int)dgvMaterias.CurrentRow.Cells[0].Value);
            if (aux is not null)
            {
                materiasAux.Add(aux);
                ActualizarDgv();
            }
            ActualizarSeleccion();
        }

        private void NotificarPlanCreado()
        {
            MessageBox.Show(auxPlan.ObtenerInformacion(), "Venta", MessageBoxButtons.OK);
        }
    }
}
