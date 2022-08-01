using System.Windows.Forms;

namespace Instituto
{
    public static class ExtensionForm
    {
        public static void MostrarMensajeError(this Form frm, string mensaje)
        {
            MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
