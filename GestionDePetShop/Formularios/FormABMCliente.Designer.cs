
namespace Formularios
{
    partial class FormABMCliente
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
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            this.txtBuscarCliente = new System.Windows.Forms.TextBox();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DNI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Saldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.lblDNI = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtSaldo = new System.Windows.Forms.TextBox();
            this.lblSaldo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btnSalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnSalir.Location = new System.Drawing.Point(249, 224);
            // 
            // lblTema
            // 
            this.lblTema.Location = new System.Drawing.Point(289, -2);
            // 
            // chkNocturno
            // 
            this.chkNocturno.Location = new System.Drawing.Point(289, 12);
            this.chkNocturno.CheckedChanged += new System.EventHandler(this.chkNocturno_CheckedChanged);
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscarCliente.BackgroundImage = global::Formularios.Properties.Resources.boton2;
            this.btnBuscarCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscarCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarCliente.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btnBuscarCliente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnBuscarCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnBuscarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarCliente.Font = new System.Drawing.Font("EngraversGothic BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBuscarCliente.ForeColor = System.Drawing.Color.Black;
            this.btnBuscarCliente.Location = new System.Drawing.Point(77, 47);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(90, 32);
            this.btnBuscarCliente.TabIndex = 69;
            this.btnBuscarCliente.Text = "Buscar";
            this.btnBuscarCliente.UseVisualStyleBackColor = false;
            // 
            // txtBuscarCliente
            // 
            this.txtBuscarCliente.BackColor = System.Drawing.Color.CornflowerBlue;
            this.txtBuscarCliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBuscarCliente.ForeColor = System.Drawing.Color.Black;
            this.txtBuscarCliente.Location = new System.Drawing.Point(12, 24);
            this.txtBuscarCliente.Name = "txtBuscarCliente";
            this.txtBuscarCliente.Size = new System.Drawing.Size(217, 17);
            this.txtBuscarCliente.TabIndex = 68;
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Font = new System.Drawing.Font("Lilex", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblBuscar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblBuscar.Location = new System.Drawing.Point(12, 6);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(105, 15);
            this.lblBuscar.TabIndex = 82;
            this.lblBuscar.Text = "Buscar Cliente";
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.Transparent;
            this.btnAgregar.BackgroundImage = global::Formularios.Properties.Resources.boton2;
            this.btnAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btnAgregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("EngraversGothic BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAgregar.ForeColor = System.Drawing.Color.Black;
            this.btnAgregar.Location = new System.Drawing.Point(240, 107);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(90, 32);
            this.btnAgregar.TabIndex = 74;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            // 
            // btnBorrar
            // 
            this.btnBorrar.BackColor = System.Drawing.Color.Transparent;
            this.btnBorrar.BackgroundImage = global::Formularios.Properties.Resources.boton2;
            this.btnBorrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBorrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBorrar.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btnBorrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnBorrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrar.Font = new System.Drawing.Font("EngraversGothic BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBorrar.ForeColor = System.Drawing.Color.Black;
            this.btnBorrar.Location = new System.Drawing.Point(240, 183);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(90, 32);
            this.btnBorrar.TabIndex = 76;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = false;
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.Transparent;
            this.btnModificar.BackgroundImage = global::Formularios.Properties.Resources.boton2;
            this.btnModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnModificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificar.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btnModificar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnModificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font = new System.Drawing.Font("EngraversGothic BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnModificar.ForeColor = System.Drawing.Color.Black;
            this.btnModificar.Location = new System.Drawing.Point(240, 145);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(90, 32);
            this.btnModificar.TabIndex = 75;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            // 
            // dgvDatos
            // 
            this.dgvDatos.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.DNI,
            this.Telefono,
            this.Direccion,
            this.Saldo});
            this.dgvDatos.Location = new System.Drawing.Point(12, 281);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.RowTemplate.Height = 25;
            this.dgvDatos.Size = new System.Drawing.Size(312, 151);
            this.dgvDatos.TabIndex = 77;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // DNI
            // 
            this.DNI.HeaderText = "DNI";
            this.DNI.Name = "DNI";
            // 
            // Telefono
            // 
            this.Telefono.HeaderText = "Telefono";
            this.Telefono.Name = "Telefono";
            // 
            // Direccion
            // 
            this.Direccion.HeaderText = "Direccion";
            this.Direccion.Name = "Direccion";
            // 
            // Saldo
            // 
            this.Saldo.HeaderText = "Saldo";
            this.Saldo.Name = "Saldo";
            // 
            // txtDireccion
            // 
            this.txtDireccion.BackColor = System.Drawing.Color.CornflowerBlue;
            this.txtDireccion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDireccion.ForeColor = System.Drawing.Color.Black;
            this.txtDireccion.Location = new System.Drawing.Point(12, 210);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(217, 17);
            this.txtDireccion.TabIndex = 73;
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Font = new System.Drawing.Font("Lilex", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDireccion.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblDireccion.Location = new System.Drawing.Point(12, 192);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(70, 15);
            this.lblDireccion.TabIndex = 81;
            this.lblDireccion.Text = "Direccion";
            // 
            // txtTelefono
            // 
            this.txtTelefono.BackColor = System.Drawing.Color.CornflowerBlue;
            this.txtTelefono.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTelefono.ForeColor = System.Drawing.Color.Black;
            this.txtTelefono.Location = new System.Drawing.Point(12, 170);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(217, 17);
            this.txtTelefono.TabIndex = 72;
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Lilex", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTelefono.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblTelefono.Location = new System.Drawing.Point(12, 152);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(63, 15);
            this.lblTelefono.TabIndex = 80;
            this.lblTelefono.Text = "Telefono";
            // 
            // txtDni
            // 
            this.txtDni.BackColor = System.Drawing.Color.CornflowerBlue;
            this.txtDni.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDni.ForeColor = System.Drawing.Color.Black;
            this.txtDni.Location = new System.Drawing.Point(12, 132);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(217, 17);
            this.txtDni.TabIndex = 71;
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.Font = new System.Drawing.Font("Lilex", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDNI.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblDNI.Location = new System.Drawing.Point(12, 114);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(28, 15);
            this.lblDNI.TabIndex = 79;
            this.lblDNI.Text = "DNI";
            // 
            // txtNombre
            // 
            this.txtNombre.AllowDrop = true;
            this.txtNombre.BackColor = System.Drawing.Color.CornflowerBlue;
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombre.ForeColor = System.Drawing.Color.Black;
            this.txtNombre.Location = new System.Drawing.Point(12, 94);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(217, 17);
            this.txtNombre.TabIndex = 70;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Lilex", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNombre.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblNombre.Location = new System.Drawing.Point(12, 76);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(49, 15);
            this.lblNombre.TabIndex = 78;
            this.lblNombre.Text = "Nombre";
            // 
            // txtSaldo
            // 
            this.txtSaldo.BackColor = System.Drawing.Color.CornflowerBlue;
            this.txtSaldo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSaldo.ForeColor = System.Drawing.Color.Black;
            this.txtSaldo.Location = new System.Drawing.Point(12, 251);
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.Size = new System.Drawing.Size(217, 17);
            this.txtSaldo.TabIndex = 83;
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Font = new System.Drawing.Font("Lilex", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSaldo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblSaldo.Location = new System.Drawing.Point(12, 233);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(42, 15);
            this.lblSaldo.TabIndex = 84;
            this.lblSaldo.Text = "Saldo";
            // 
            // FormABMCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 444);
            this.Controls.Add(this.txtSaldo);
            this.Controls.Add(this.lblSaldo);
            this.Controls.Add(this.btnBuscarCliente);
            this.Controls.Add(this.txtBuscarCliente);
            this.Controls.Add(this.lblBuscar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.dgvDatos);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.txtDni);
            this.Controls.Add(this.lblDNI);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Name = "FormABMCliente";
            this.Text = "Administrar Clientes";
            this.Load += new System.EventHandler(this.FormABMCliente_Load);
            this.Controls.SetChildIndex(this.lblNombre, 0);
            this.Controls.SetChildIndex(this.txtNombre, 0);
            this.Controls.SetChildIndex(this.lblDNI, 0);
            this.Controls.SetChildIndex(this.txtDni, 0);
            this.Controls.SetChildIndex(this.lblTelefono, 0);
            this.Controls.SetChildIndex(this.txtTelefono, 0);
            this.Controls.SetChildIndex(this.lblDireccion, 0);
            this.Controls.SetChildIndex(this.txtDireccion, 0);
            this.Controls.SetChildIndex(this.dgvDatos, 0);
            this.Controls.SetChildIndex(this.btnModificar, 0);
            this.Controls.SetChildIndex(this.btnBorrar, 0);
            this.Controls.SetChildIndex(this.btnAgregar, 0);
            this.Controls.SetChildIndex(this.lblBuscar, 0);
            this.Controls.SetChildIndex(this.txtBuscarCliente, 0);
            this.Controls.SetChildIndex(this.btnBuscarCliente, 0);
            this.Controls.SetChildIndex(this.btnSalir, 0);
            this.Controls.SetChildIndex(this.lblTema, 0);
            this.Controls.SetChildIndex(this.chkNocturno, 0);
            this.Controls.SetChildIndex(this.lblSaldo, 0);
            this.Controls.SetChildIndex(this.txtSaldo, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.Button btnBuscarCliente;
        private System.Windows.Forms.TextBox txtBuscarCliente;
        private System.Windows.Forms.Label lblBuscar;
        protected System.Windows.Forms.Button btnAgregar;
        protected System.Windows.Forms.Button btnBorrar;
        protected System.Windows.Forms.Button btnModificar;
        protected System.Windows.Forms.DataGridView dgvDatos;
        protected System.Windows.Forms.TextBox txtDireccion;
        public System.Windows.Forms.Label lblDireccion;
        protected System.Windows.Forms.TextBox txtTelefono;
        public System.Windows.Forms.Label lblTelefono;
        protected System.Windows.Forms.TextBox txtDni;
        public System.Windows.Forms.Label lblDNI;
        protected System.Windows.Forms.TextBox txtNombre;
        public System.Windows.Forms.Label lblNombre;
        protected System.Windows.Forms.TextBox txtSaldo;
        public System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn DNI;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Saldo;
    }
}