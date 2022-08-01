using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace Instituto
{
    public partial class FrmPrincipal : Form
    {
        private Form formActivo;
        CancellationTokenSource cts;

        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            Institucion.CargarDatos(this.MostrarMensajeError);
            cts = new CancellationTokenSource();
            Autoguardar();
        }

        private void AbrirFormHijo(Form formHijo)
        {
            if (formActivo is not null)
            {
                formActivo.Close();
            }
            formActivo = formHijo;
            formHijo.TopLevel = false;
            formHijo.Dock = DockStyle.Fill;
            this.panelPrincipal.Controls.Add(formHijo);
            this.panelPrincipal.Tag = formHijo;
            formHijo.BringToFront();
            formHijo.Show();
        }

        private void Autoguardar()
        {
            Task task = Task.Run(() =>
            {
                while (!cts.Token.IsCancellationRequested)
                {
                    Institucion.GuardarDatos(this.MostrarMensajeError);
                    Thread.Sleep(60000);
                }
            });
        }

        private void btnAlumnos_Click(object sender, EventArgs e)
        {
            if (formActivo is not FrmAlumnos)
            {
                AbrirFormHijo(new FrmAlumnos());
            }
        }

        private void btnMaterias_Click(object sender, EventArgs e)
        {
            if (formActivo is not FrmMaterias)
            {
                AbrirFormHijo(new FrmMaterias());
            }
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            if (formActivo is not FrmVentas)
            {
                AbrirFormHijo(new FrmVentas());
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FrmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Seguro que desea cerrar el programa?", "Cerrar",
               MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Institucion.GuardarDatos(this.MostrarMensajeError);
                cts.Cancel();
            }
            else
            {
                e.Cancel = true;
            }
        }
    }
}
