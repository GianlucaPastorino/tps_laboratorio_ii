using System;
using System.Windows.Forms;
using Entidades;

namespace Instituto
{
    public partial class FrmVentas : Form, IActualizarDgv
    {
        public FrmVentas()
        {
            InitializeComponent();
        }

        private void FrmVentas_Load(object sender, EventArgs e)
        {
            ActualizarDgv();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void ActualizarDgv()
        {
            dgvVentas.Rows.Clear();

            foreach (Plan venta in Institucion.Ventas)
            {
                dgvVentas.Rows.Add(venta.Id, venta.FechaAdquirido.ToString("dd/MM/yyyy"), venta.Alumno.Nombre, venta.Alumno.Apellido, venta.Tipo,
                    venta.CantidadDeMaterias, venta.Precio);
            }
        }

        private void dgvVentas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show(Institucion.BuscarPlanPorId((int)dgvVentas.CurrentRow.Cells[0].Value).ObtenerInformacion(), "Venta", MessageBoxButtons.OK);
        }
    }
}
