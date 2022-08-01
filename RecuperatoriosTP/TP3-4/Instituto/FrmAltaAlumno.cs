using System;
using System.Windows.Forms;
using Entidades;

namespace Instituto
{
    public partial class FrmAltaAlumno : Form
    {
        public FrmAltaAlumno()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (Institucion.AgregarAlumno(new Alumno(txbNombre.Text, txbApellido.Text, (int)numDni.Value, txbCorreo.Text), this.MostrarMensajeError))
            {
                this.DialogResult = DialogResult.OK;
            }
        }
    }
}
