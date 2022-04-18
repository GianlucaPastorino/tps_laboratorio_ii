using System;
using System.Windows.Forms;
using Entidades;

namespace MiCalculadora
{
    public partial class FormCalculadora : Form
    {
        public FormCalculadora()
        {
            InitializeComponent();
        }

        private void FormCalculadora_Load(object sender, EventArgs e)
        {
            this.Limpiar();
        }

        /// <summary>
        /// Cierra el form, previa confirmación
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormCalculadora_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult salir = MessageBox.Show("¿Seguro de querer salir?", "Salir",
                                                 MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (salir == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        /// <summary>
        /// Cierra el form, previa confirmación
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Convierte el resultado de una operación a binario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {
            this.lblResultado.Text = new Operando().DecimalBinario(this.lblResultado.Text);
        }

        /// <summary>
        /// Convierte el resultado de una operación a decimal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {
            this.lblResultado.Text = new Operando().BinarioDecimal(this.lblResultado.Text);
        }

        /// <summary>
        /// Elimina los valores de los campos formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.Limpiar();
        }

        /// <summary>
        /// Realiza la operación y muestra el resultado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOperar_Click(object sender, EventArgs e)
        {
            string operador = this.cmbOperador.Text;

            double resultado = FormCalculadora.Operar(this.txtNumero1.Text, this.txtNumero2.Text, this.cmbOperador.Text);
            this.lblResultado.Text = resultado.ToString();

            double.TryParse(this.txtNumero1.Text, out double num1);
            double.TryParse(this.txtNumero2.Text, out double num2);

            if (operador == " ")
            {
                operador = "+";
            }

            lstOperaciones.Items.Add(num1 + " " + operador + " " + num2 + " = " + resultado);
        }

        /// <summary>
        /// Elimina los valores de los campos
        /// </summary>
        private void Limpiar()
        {
            this.txtNumero1.Text = "";
            this.txtNumero2.Text = "";
            this.cmbOperador.SelectedIndex = 0;
            this.lblResultado.Text = "0";
        }

        /// <summary>
        /// Realiza la operación
        /// </summary>
        /// <param name="numero1">Número 1</param>
        /// <param name="numero2">Número 2</param>
        /// <param name="operador">Operador</param>
        /// <returns></returns>
        private static double Operar(string numero1, string numero2, string operador)
        {
            return Calculadora.Operar(new Operando(numero1), new Operando(numero2), char.Parse(operador));
        }
    }
}
