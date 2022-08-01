
namespace Instituto
{
    partial class FrmMaterias
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
            this.lblMaterias = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.dgvMaterias = new System.Windows.Forms.DataGridView();
            this.cId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cModalidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTurno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cCupoMaximo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cInscriptos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cCupoDisponible = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCerrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterias)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMaterias
            // 
            this.lblMaterias.AutoSize = true;
            this.lblMaterias.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMaterias.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.lblMaterias.Location = new System.Drawing.Point(12, 18);
            this.lblMaterias.Name = "lblMaterias";
            this.lblMaterias.Size = new System.Drawing.Size(105, 29);
            this.lblMaterias.TabIndex = 0;
            this.lblMaterias.Text = "Materias";
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAgregar.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAgregar.Location = new System.Drawing.Point(578, 511);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(128, 37);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Agregar Materia";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEliminar.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnEliminar.Location = new System.Drawing.Point(444, 511);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(128, 37);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Eliminar Materia";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
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
            this.cInscriptos,
            this.cCupoDisponible});
            this.dgvMaterias.Location = new System.Drawing.Point(12, 61);
            this.dgvMaterias.MultiSelect = false;
            this.dgvMaterias.Name = "dgvMaterias";
            this.dgvMaterias.ReadOnly = true;
            this.dgvMaterias.RowHeadersVisible = false;
            this.dgvMaterias.RowTemplate.Height = 25;
            this.dgvMaterias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMaterias.Size = new System.Drawing.Size(694, 435);
            this.dgvMaterias.TabIndex = 7;
            this.dgvMaterias.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMaterias_CellDoubleClick);
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
            // cInscriptos
            // 
            this.cInscriptos.HeaderText = "Cantidad Inscriptos";
            this.cInscriptos.Name = "cInscriptos";
            this.cInscriptos.ReadOnly = true;
            // 
            // cCupoDisponible
            // 
            this.cCupoDisponible.HeaderText = "Cupo Disponible";
            this.cCupoDisponible.Name = "cCupoDisponible";
            this.cCupoDisponible.ReadOnly = true;
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
            // FrmMaterias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(718, 560);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.dgvMaterias);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lblMaterias);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMaterias";
            this.Text = "FrmMaterias";
            this.Load += new System.EventHandler(this.FrmMaterias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMaterias;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DataGridView dgvMaterias;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.DataGridViewTextBoxColumn cId;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn cModalidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDia;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTurno;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCupoMaximo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cInscriptos;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCupoDisponible;
    }
}