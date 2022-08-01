
namespace Instituto
{
    partial class FrmPlan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cboTipo = new System.Windows.Forms.ComboBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblPlan = new System.Windows.Forms.Label();
            this.numMaterias = new System.Windows.Forms.NumericUpDown();
            this.cboMedioDePago = new System.Windows.Forms.ComboBox();
            this.btnPagar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblMedioDePago = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblVencimiento = new System.Windows.Forms.Label();
            this.lblSeleccionarMateria = new System.Windows.Forms.Label();
            this.btnOkPlan = new System.Windows.Forms.Button();
            this.btnOkCantidad = new System.Windows.Forms.Button();
            this.btnOkMateria = new System.Windows.Forms.Button();
            this.dgvMaterias = new System.Windows.Forms.DataGridView();
            this.cId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cModalidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTurno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cCupoMaximo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cCupoDisponible = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblPago = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numMaterias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterias)).BeginInit();
            this.SuspendLayout();
            // 
            // cboTipo
            // 
            this.cboTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipo.FormattingEnabled = true;
            this.cboTipo.Location = new System.Drawing.Point(263, 54);
            this.cboTipo.Name = "cboTipo";
            this.cboTipo.Size = new System.Drawing.Size(149, 23);
            this.cboTipo.TabIndex = 25;
            this.cboTipo.SelectedIndexChanged += new System.EventHandler(this.cboTipo_SelectedIndexChanged);
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTipo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.lblTipo.Location = new System.Drawing.Point(173, 56);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(84, 16);
            this.lblTipo.TabIndex = 24;
            this.lblTipo.Text = "Tipo de Plan";
            // 
            // lblPlan
            // 
            this.lblPlan.AutoSize = true;
            this.lblPlan.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPlan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.lblPlan.Location = new System.Drawing.Point(219, 13);
            this.lblPlan.Name = "lblPlan";
            this.lblPlan.Size = new System.Drawing.Size(201, 29);
            this.lblPlan.TabIndex = 23;
            this.lblPlan.Text = "Personalizar Plan";
            // 
            // numMaterias
            // 
            this.numMaterias.Enabled = false;
            this.numMaterias.Location = new System.Drawing.Point(263, 99);
            this.numMaterias.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numMaterias.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numMaterias.Name = "numMaterias";
            this.numMaterias.ReadOnly = true;
            this.numMaterias.Size = new System.Drawing.Size(149, 23);
            this.numMaterias.TabIndex = 22;
            this.numMaterias.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cboMedioDePago
            // 
            this.cboMedioDePago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMedioDePago.FormattingEnabled = true;
            this.cboMedioDePago.Location = new System.Drawing.Point(298, 399);
            this.cboMedioDePago.Name = "cboMedioDePago";
            this.cboMedioDePago.Size = new System.Drawing.Size(149, 23);
            this.cboMedioDePago.TabIndex = 21;
            // 
            // btnPagar
            // 
            this.btnPagar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btnPagar.Enabled = false;
            this.btnPagar.FlatAppearance.BorderSize = 0;
            this.btnPagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPagar.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnPagar.Location = new System.Drawing.Point(322, 462);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(95, 23);
            this.btnPagar.TabIndex = 19;
            this.btnPagar.Text = "Pagar";
            this.btnPagar.UseVisualStyleBackColor = false;
            this.btnPagar.Click += new System.EventHandler(this.btnPagar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCancelar.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnCancelar.Location = new System.Drawing.Point(221, 462);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(95, 23);
            this.btnCancelar.TabIndex = 18;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblMedioDePago
            // 
            this.lblMedioDePago.AutoSize = true;
            this.lblMedioDePago.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMedioDePago.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.lblMedioDePago.Location = new System.Drawing.Point(192, 401);
            this.lblMedioDePago.Name = "lblMedioDePago";
            this.lblMedioDePago.Size = new System.Drawing.Size(100, 16);
            this.lblMedioDePago.TabIndex = 17;
            this.lblMedioDePago.Text = "Medio de Pago";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCantidad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.lblCantidad.Location = new System.Drawing.Point(146, 103);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(111, 16);
            this.lblCantidad.TabIndex = 16;
            this.lblCantidad.Text = "Cant. de Materias";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPrecio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.lblPrecio.Location = new System.Drawing.Point(275, 425);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(89, 20);
            this.lblPrecio.TabIndex = 26;
            this.lblPrecio.Text = "Precio: $0";
            // 
            // lblVencimiento
            // 
            this.lblVencimiento.AutoSize = true;
            this.lblVencimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblVencimiento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.lblVencimiento.Location = new System.Drawing.Point(278, 80);
            this.lblVencimiento.Name = "lblVencimiento";
            this.lblVencimiento.Size = new System.Drawing.Size(122, 16);
            this.lblVencimiento.TabIndex = 27;
            this.lblVencimiento.Text = "Vto.: DD/MM/AAAA";
            // 
            // lblSeleccionarMateria
            // 
            this.lblSeleccionarMateria.AutoSize = true;
            this.lblSeleccionarMateria.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSeleccionarMateria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.lblSeleccionarMateria.Location = new System.Drawing.Point(196, 143);
            this.lblSeleccionarMateria.Name = "lblSeleccionarMateria";
            this.lblSeleccionarMateria.Size = new System.Drawing.Size(246, 29);
            this.lblSeleccionarMateria.TabIndex = 28;
            this.lblSeleccionarMateria.Text = "Seleccionar Materia 1";
            // 
            // btnOkPlan
            // 
            this.btnOkPlan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btnOkPlan.FlatAppearance.BorderSize = 0;
            this.btnOkPlan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOkPlan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnOkPlan.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnOkPlan.Location = new System.Drawing.Point(418, 53);
            this.btnOkPlan.Name = "btnOkPlan";
            this.btnOkPlan.Size = new System.Drawing.Size(48, 23);
            this.btnOkPlan.TabIndex = 45;
            this.btnOkPlan.Text = "OK";
            this.btnOkPlan.UseVisualStyleBackColor = false;
            this.btnOkPlan.Click += new System.EventHandler(this.btnOkPlan_Click);
            // 
            // btnOkCantidad
            // 
            this.btnOkCantidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btnOkCantidad.Enabled = false;
            this.btnOkCantidad.FlatAppearance.BorderSize = 0;
            this.btnOkCantidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOkCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnOkCantidad.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnOkCantidad.Location = new System.Drawing.Point(418, 100);
            this.btnOkCantidad.Name = "btnOkCantidad";
            this.btnOkCantidad.Size = new System.Drawing.Size(48, 23);
            this.btnOkCantidad.TabIndex = 46;
            this.btnOkCantidad.Text = "OK";
            this.btnOkCantidad.UseVisualStyleBackColor = false;
            this.btnOkCantidad.Click += new System.EventHandler(this.btnOkCantidad_Click);
            // 
            // btnOkMateria
            // 
            this.btnOkMateria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btnOkMateria.Enabled = false;
            this.btnOkMateria.FlatAppearance.BorderSize = 0;
            this.btnOkMateria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOkMateria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnOkMateria.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnOkMateria.Location = new System.Drawing.Point(579, 344);
            this.btnOkMateria.Name = "btnOkMateria";
            this.btnOkMateria.Size = new System.Drawing.Size(48, 23);
            this.btnOkMateria.TabIndex = 47;
            this.btnOkMateria.Text = "OK";
            this.btnOkMateria.UseVisualStyleBackColor = false;
            this.btnOkMateria.Click += new System.EventHandler(this.btnOkMateria_Click);
            // 
            // dgvMaterias
            // 
            this.dgvMaterias.AllowUserToAddRows = false;
            this.dgvMaterias.AllowUserToDeleteRows = false;
            this.dgvMaterias.AllowUserToResizeColumns = false;
            this.dgvMaterias.AllowUserToResizeRows = false;
            this.dgvMaterias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMaterias.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMaterias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMaterias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cId,
            this.cNombre,
            this.cModalidad,
            this.cDia,
            this.cTurno,
            this.cCupoMaximo,
            this.cCupoDisponible});
            this.dgvMaterias.Location = new System.Drawing.Point(12, 175);
            this.dgvMaterias.MultiSelect = false;
            this.dgvMaterias.Name = "dgvMaterias";
            this.dgvMaterias.ReadOnly = true;
            this.dgvMaterias.RowHeadersVisible = false;
            this.dgvMaterias.RowTemplate.Height = 25;
            this.dgvMaterias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMaterias.Size = new System.Drawing.Size(615, 163);
            this.dgvMaterias.TabIndex = 48;
            // 
            // cId
            // 
            this.cId.HeaderText = "ID";
            this.cId.Name = "cId";
            this.cId.ReadOnly = true;
            this.cId.Visible = false;
            // 
            // cNombre
            // 
            this.cNombre.HeaderText = "Nombre";
            this.cNombre.Name = "cNombre";
            this.cNombre.ReadOnly = true;
            // 
            // cModalidad
            // 
            this.cModalidad.HeaderText = "Modalidad";
            this.cModalidad.Name = "cModalidad";
            this.cModalidad.ReadOnly = true;
            // 
            // cDia
            // 
            this.cDia.HeaderText = "Día";
            this.cDia.Name = "cDia";
            this.cDia.ReadOnly = true;
            // 
            // cTurno
            // 
            this.cTurno.HeaderText = "Turno";
            this.cTurno.Name = "cTurno";
            this.cTurno.ReadOnly = true;
            // 
            // cCupoMaximo
            // 
            this.cCupoMaximo.HeaderText = "Cupo Maximo";
            this.cCupoMaximo.Name = "cCupoMaximo";
            this.cCupoMaximo.ReadOnly = true;
            // 
            // cCupoDisponible
            // 
            this.cCupoDisponible.HeaderText = "Cupo Disponible";
            this.cCupoDisponible.Name = "cCupoDisponible";
            this.cCupoDisponible.ReadOnly = true;
            // 
            // lblPago
            // 
            this.lblPago.AutoSize = true;
            this.lblPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPago.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.lblPago.Location = new System.Drawing.Point(284, 364);
            this.lblPago.Name = "lblPago";
            this.lblPago.Size = new System.Drawing.Size(70, 29);
            this.lblPago.TabIndex = 49;
            this.lblPago.Text = "Pago";
            // 
            // FrmPlan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(639, 500);
            this.Controls.Add(this.lblPago);
            this.Controls.Add(this.dgvMaterias);
            this.Controls.Add(this.btnOkMateria);
            this.Controls.Add(this.btnOkCantidad);
            this.Controls.Add(this.btnOkPlan);
            this.Controls.Add(this.lblSeleccionarMateria);
            this.Controls.Add(this.lblVencimiento);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.cboTipo);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.lblPlan);
            this.Controls.Add(this.numMaterias);
            this.Controls.Add(this.cboMedioDePago);
            this.Controls.Add(this.btnPagar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.lblMedioDePago);
            this.Controls.Add(this.lblCantidad);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPlan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmPlan";
            this.Load += new System.EventHandler(this.FrmPlan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numMaterias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboTipo;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblPlan;
        private System.Windows.Forms.NumericUpDown numMaterias;
        private System.Windows.Forms.ComboBox cboMedioDePago;
        private System.Windows.Forms.Button btnPagar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblMedioDePago;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblVencimiento;
        private System.Windows.Forms.Label lblSeleccionarMateria;
        private System.Windows.Forms.Button btnOkPlan;
        private System.Windows.Forms.Button btnOkCantidad;
        private System.Windows.Forms.Button btnOkMateria;
        private System.Windows.Forms.DataGridView dgvMaterias;
        private System.Windows.Forms.DataGridViewTextBoxColumn cId;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn cModalidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDia;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTurno;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCupoMaximo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCupoDisponible;
        private System.Windows.Forms.Label lblPago;
    }
}