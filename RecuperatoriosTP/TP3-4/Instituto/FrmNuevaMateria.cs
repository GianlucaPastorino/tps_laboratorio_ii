using System;
using System.Windows.Forms;
using Entidades;

namespace Instituto
{
    public partial class FrmNuevaMateria : Form
    {
        public FrmNuevaMateria()
        {
            InitializeComponent();
        }

        private void FrmNuevaMateria_Load(object sender, EventArgs e)
        {
            cboModalidad.DataSource = Enum.GetValues(typeof(EModalidad));
            cboTurno.DataSource = Enum.GetValues(typeof(ETurno));
            cboDia.DataSource = Enum.GetValues(typeof(EDia));
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (Institucion.AgregarMateria(new Materia(txbNombre.Text, (EModalidad)cboModalidad.SelectedItem, (int)numMaximo.Value,
                                            (EDia)cboDia.SelectedItem, (ETurno)cboTurno.SelectedItem), this.MostrarMensajeError))
            {
                this.DialogResult = DialogResult.OK;
            }

        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}


