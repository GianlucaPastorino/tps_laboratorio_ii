
namespace Instituto
{
    partial class FrmVentas
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
            this.lblVentas = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.dgvVentas = new System.Windows.Forms.DataGridView();
            this.cID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cAlumnoNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cAlumnoApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cCantMaterias = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // lblVentas
            // 
            this.lblVentas.AutoSize = true;
            this.lblVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblVentas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.lblVentas.Location = new System.Drawing.Point(12, 18);
            this.lblVentas.Name = "lblVentas";
            this.lblVentas.Size = new System.Drawing.Size(86, 29);
            this.lblVentas.TabIndex = 1;
            this.lblVentas.Text = "Ventas";
            // 
            // btnCerrar
            // 
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCerrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btnCerrar.Location = new System.Drawing.Point(694, 0);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(24, 23);
            this.btnCerrar.TabIndex = 8;
            this.btnCerrar.Text = "X";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // dgvVentas
            // 
            this.dgvVentas.AllowUserToAddRows = false;
            this.dgvVentas.AllowUserToDeleteRows = false;
            this.dgvVentas.AllowUserToResizeColumns = false;
            this.dgvVentas.AllowUserToResizeRows = false;
            this.dgvVentas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVentas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVentas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cID,
            this.cFecha,
            this.cAlumnoNombre,
            this.cAlumnoApellido,
            this.cTipo,
            this.cCantMaterias,
            this.cPrecio});
            this.dgvVentas.Location = new System.Drawing.Point(12, 63);
            this.dgvVentas.Name = "dgvVentas";
            this.dgvVentas.ReadOnly = true;
            this.dgvVentas.RowHeadersVisible = false;
            this.dgvVentas.RowTemplate.Height = 25;
            this.dgvVentas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVentas.Size = new System.Drawing.Size(694, 435);
            this.dgvVentas.TabIndex = 9;
            this.dgvVentas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVentas_CellDoubleClick);
            // 
            // cID
            // 
            this.cID.HeaderText = "ID";
            this.cID.Name = "cID";
            this.cID.ReadOnly = true;
            this.cID.Visible = false;
            // 
            // cFecha
            // 
            this.cFecha.HeaderText = "Fecha";
            this.cFecha.Name = "cFecha";
            this.cFecha.ReadOnly = true;
            // 
            // cAlumnoNombre
            // 
            this.cAlumnoNombre.HeaderText = "Nombre";
            this.cAlumnoNombre.Name = "cAlumnoNombre";
            this.cAlumnoNombre.ReadOnly = true;
            // 
            // cAlumnoApellido
            // 
            this.cAlumnoApellido.HeaderText = "Apellido";
            this.cAlumnoApellido.Name = "cAlumnoApellido";
            this.cAlumnoApellido.ReadOnly = true;
            // 
            // cTipo
            // 
            this.cTipo.HeaderText = "Tipo";
            this.cTipo.Name = "cTipo";
            this.cTipo.ReadOnly = true;
            // 
            // cCantMaterias
            // 
            this.cCantMaterias.HeaderText = "Cant. Materias";
            this.cCantMaterias.Name = "cCantMaterias";
            this.cCantMaterias.ReadOnly = true;
            // 
            // cPrecio
            // 
            this.cPrecio.HeaderText = "Precio";
            this.cPrecio.Name = "cPrecio";
            this.cPrecio.ReadOnly = true;
            // 
            // FrmVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(718, 560);
            this.Controls.Add(this.dgvVentas);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.lblVentas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmVentas";
            this.Text = "FrmVentas";
            this.Load += new System.EventHandler(this.FrmVentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblVentas;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.DataGridView dgvVentas;
        private System.Windows.Forms.DataGridViewTextBoxColumn cID;
        private System.Windows.Forms.DataGridViewTextBoxColumn cFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn cAlumnoNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn cAlumnoApellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCantMaterias;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPrecio;
    }
}