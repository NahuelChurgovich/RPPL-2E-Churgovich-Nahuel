
namespace Formularios
{
    partial class FormABMProducto
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
            this.btnBuscarProducto = new System.Windows.Forms.Button();
            this.txtBuscarProducto = new System.Windows.Forms.TextBox();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.txtCosto = new System.Windows.Forms.TextBox();
            this.lblCosto = new System.Windows.Forms.Label();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.lblMarca = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtMargen = new System.Windows.Forms.TextBox();
            this.lblMargen = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.nudCant = new System.Windows.Forms.NumericUpDown();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblModifCant = new System.Windows.Forms.Label();
            this.lblCantExist = new System.Windows.Forms.Label();
            this.lblNumCantExist = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudCant)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btnSalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnSalir.Location = new System.Drawing.Point(244, 220);
            this.btnSalir.TabIndex = 15;
            // 
            // lblTema
            // 
            this.lblTema.Location = new System.Drawing.Point(290, -2);
            // 
            // chkNocturno
            // 
            this.chkNocturno.Location = new System.Drawing.Point(290, 12);
            this.chkNocturno.TabIndex = 0;
            this.chkNocturno.CheckedChanged += new System.EventHandler(this.chkNocturno_CheckedChanged);
            // 
            // btnBuscarProducto
            // 
            this.btnBuscarProducto.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscarProducto.BackgroundImage = global::Formularios.Properties.Resources.boton2;
            this.btnBuscarProducto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscarProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarProducto.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btnBuscarProducto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnBuscarProducto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnBuscarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarProducto.Font = new System.Drawing.Font("EngraversGothic BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBuscarProducto.ForeColor = System.Drawing.Color.Black;
            this.btnBuscarProducto.Location = new System.Drawing.Point(68, 54);
            this.btnBuscarProducto.Name = "btnBuscarProducto";
            this.btnBuscarProducto.Size = new System.Drawing.Size(90, 32);
            this.btnBuscarProducto.TabIndex = 2;
            this.btnBuscarProducto.Text = "Buscar";
            this.btnBuscarProducto.UseVisualStyleBackColor = false;
            this.btnBuscarProducto.Click += new System.EventHandler(this.btnBuscarProducto_Click);
            // 
            // txtBuscarProducto
            // 
            this.txtBuscarProducto.BackColor = System.Drawing.Color.CornflowerBlue;
            this.txtBuscarProducto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBuscarProducto.ForeColor = System.Drawing.Color.Black;
            this.txtBuscarProducto.Location = new System.Drawing.Point(12, 24);
            this.txtBuscarProducto.Name = "txtBuscarProducto";
            this.txtBuscarProducto.Size = new System.Drawing.Size(217, 17);
            this.txtBuscarProducto.TabIndex = 1;
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Font = new System.Drawing.Font("Lilex", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblBuscar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblBuscar.Location = new System.Drawing.Point(12, 5);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(112, 15);
            this.lblBuscar.TabIndex = 82;
            this.lblBuscar.Text = "Buscar Producto";
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
            this.btnAgregar.Location = new System.Drawing.Point(235, 106);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(90, 32);
            this.btnAgregar.TabIndex = 12;
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
            this.btnBorrar.Location = new System.Drawing.Point(235, 182);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(90, 32);
            this.btnBorrar.TabIndex = 14;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = false;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
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
            this.btnModificar.Location = new System.Drawing.Point(235, 144);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(90, 32);
            this.btnModificar.TabIndex = 13;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            // 
            // txtCosto
            // 
            this.txtCosto.BackColor = System.Drawing.Color.CornflowerBlue;
            this.txtCosto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCosto.ForeColor = System.Drawing.Color.Black;
            this.txtCosto.Location = new System.Drawing.Point(12, 241);
            this.txtCosto.Name = "txtCosto";
            this.txtCosto.Size = new System.Drawing.Size(217, 17);
            this.txtCosto.TabIndex = 6;
            // 
            // lblCosto
            // 
            this.lblCosto.AutoSize = true;
            this.lblCosto.Font = new System.Drawing.Font("Lilex", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCosto.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblCosto.Location = new System.Drawing.Point(12, 223);
            this.lblCosto.Name = "lblCosto";
            this.lblCosto.Size = new System.Drawing.Size(42, 15);
            this.lblCosto.TabIndex = 81;
            this.lblCosto.Text = "Costo";
            // 
            // txtMarca
            // 
            this.txtMarca.BackColor = System.Drawing.Color.CornflowerBlue;
            this.txtMarca.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMarca.ForeColor = System.Drawing.Color.Black;
            this.txtMarca.Location = new System.Drawing.Point(12, 197);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(217, 17);
            this.txtMarca.TabIndex = 5;
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Font = new System.Drawing.Font("Lilex", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMarca.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblMarca.Location = new System.Drawing.Point(12, 179);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(42, 15);
            this.lblMarca.TabIndex = 80;
            this.lblMarca.Text = "Marca";
            // 
            // txtCodigo
            // 
            this.txtCodigo.BackColor = System.Drawing.Color.CornflowerBlue;
            this.txtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCodigo.ForeColor = System.Drawing.Color.Black;
            this.txtCodigo.Location = new System.Drawing.Point(12, 153);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(217, 17);
            this.txtCodigo.TabIndex = 4;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Lilex", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCodigo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblCodigo.Location = new System.Drawing.Point(12, 135);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(49, 15);
            this.lblCodigo.TabIndex = 79;
            this.lblCodigo.Text = "Código";
            // 
            // txtNombre
            // 
            this.txtNombre.AllowDrop = true;
            this.txtNombre.BackColor = System.Drawing.Color.CornflowerBlue;
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombre.ForeColor = System.Drawing.Color.Black;
            this.txtNombre.Location = new System.Drawing.Point(12, 109);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(217, 17);
            this.txtNombre.TabIndex = 3;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Lilex", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNombre.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblNombre.Location = new System.Drawing.Point(12, 91);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(49, 15);
            this.lblNombre.TabIndex = 78;
            this.lblNombre.Text = "Nombre";
            // 
            // txtMargen
            // 
            this.txtMargen.BackColor = System.Drawing.Color.CornflowerBlue;
            this.txtMargen.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMargen.ForeColor = System.Drawing.Color.Black;
            this.txtMargen.Location = new System.Drawing.Point(13, 285);
            this.txtMargen.Name = "txtMargen";
            this.txtMargen.Size = new System.Drawing.Size(217, 17);
            this.txtMargen.TabIndex = 7;
            // 
            // lblMargen
            // 
            this.lblMargen.AutoSize = true;
            this.lblMargen.Font = new System.Drawing.Font("Lilex", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMargen.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblMargen.Location = new System.Drawing.Point(13, 267);
            this.lblMargen.Name = "lblMargen";
            this.lblMargen.Size = new System.Drawing.Size(49, 15);
            this.lblMargen.TabIndex = 84;
            this.lblMargen.Text = "Margen";
            // 
            // txtPrecio
            // 
            this.txtPrecio.BackColor = System.Drawing.Color.CornflowerBlue;
            this.txtPrecio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPrecio.ForeColor = System.Drawing.Color.Black;
            this.txtPrecio.Location = new System.Drawing.Point(13, 332);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(217, 17);
            this.txtPrecio.TabIndex = 8;
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Lilex", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPrecio.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblPrecio.Location = new System.Drawing.Point(13, 314);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(49, 15);
            this.lblPrecio.TabIndex = 86;
            this.lblPrecio.Text = "Precio";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.BackColor = System.Drawing.Color.CornflowerBlue;
            this.txtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDescripcion.ForeColor = System.Drawing.Color.Black;
            this.txtDescripcion.Location = new System.Drawing.Point(13, 483);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(307, 153);
            this.txtDescripcion.TabIndex = 11;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Lilex", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDescripcion.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblDescripcion.Location = new System.Drawing.Point(13, 465);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(84, 15);
            this.lblDescripcion.TabIndex = 88;
            this.lblDescripcion.Text = "Descripcion";
            // 
            // cmbTipo
            // 
            this.cmbTipo.BackColor = System.Drawing.Color.CornflowerBlue;
            this.cmbTipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Location = new System.Drawing.Point(13, 374);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(217, 25);
            this.cmbTipo.TabIndex = 9;
            // 
            // nudCant
            // 
            this.nudCant.BackColor = System.Drawing.Color.CornflowerBlue;
            this.nudCant.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nudCant.Location = new System.Drawing.Point(199, 438);
            this.nudCant.Name = "nudCant";
            this.nudCant.Size = new System.Drawing.Size(49, 20);
            this.nudCant.TabIndex = 10;
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Lilex", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTipo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblTipo.Location = new System.Drawing.Point(13, 356);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(35, 15);
            this.lblTipo.TabIndex = 91;
            this.lblTipo.Text = "Tipo";
            // 
            // lblModifCant
            // 
            this.lblModifCant.AutoSize = true;
            this.lblModifCant.Font = new System.Drawing.Font("Lilex", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblModifCant.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblModifCant.Location = new System.Drawing.Point(13, 438);
            this.lblModifCant.Name = "lblModifCant";
            this.lblModifCant.Size = new System.Drawing.Size(182, 15);
            this.lblModifCant.TabIndex = 92;
            this.lblModifCant.Text = "Cantidad a sumar o restar";
            // 
            // lblCantExist
            // 
            this.lblCantExist.AutoSize = true;
            this.lblCantExist.Font = new System.Drawing.Font("Lilex", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCantExist.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblCantExist.Location = new System.Drawing.Point(13, 413);
            this.lblCantExist.Name = "lblCantExist";
            this.lblCantExist.Size = new System.Drawing.Size(140, 15);
            this.lblCantExist.TabIndex = 93;
            this.lblCantExist.Text = "Cantidad existente:";
            // 
            // lblNumCantExist
            // 
            this.lblNumCantExist.AutoSize = true;
            this.lblNumCantExist.Font = new System.Drawing.Font("Lilex", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNumCantExist.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblNumCantExist.Location = new System.Drawing.Point(152, 413);
            this.lblNumCantExist.Name = "lblNumCantExist";
            this.lblNumCantExist.Size = new System.Drawing.Size(14, 15);
            this.lblNumCantExist.TabIndex = 94;
            this.lblNumCantExist.Text = "-";
            // 
            // FormABMProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 650);
            this.Controls.Add(this.lblNumCantExist);
            this.Controls.Add(this.lblCantExist);
            this.Controls.Add(this.lblModifCant);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.nudCant);
            this.Controls.Add(this.cmbTipo);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.txtMargen);
            this.Controls.Add(this.lblMargen);
            this.Controls.Add(this.btnBuscarProducto);
            this.Controls.Add(this.txtBuscarProducto);
            this.Controls.Add(this.lblBuscar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.txtCosto);
            this.Controls.Add(this.lblCosto);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Name = "FormABMProducto";
            this.Text = "Administrar Producto";
            this.Load += new System.EventHandler(this.FormABMProducto_Load);
            this.Controls.SetChildIndex(this.lblNombre, 0);
            this.Controls.SetChildIndex(this.txtNombre, 0);
            this.Controls.SetChildIndex(this.lblCodigo, 0);
            this.Controls.SetChildIndex(this.txtCodigo, 0);
            this.Controls.SetChildIndex(this.lblMarca, 0);
            this.Controls.SetChildIndex(this.txtMarca, 0);
            this.Controls.SetChildIndex(this.lblCosto, 0);
            this.Controls.SetChildIndex(this.txtCosto, 0);
            this.Controls.SetChildIndex(this.btnModificar, 0);
            this.Controls.SetChildIndex(this.btnBorrar, 0);
            this.Controls.SetChildIndex(this.btnAgregar, 0);
            this.Controls.SetChildIndex(this.lblBuscar, 0);
            this.Controls.SetChildIndex(this.txtBuscarProducto, 0);
            this.Controls.SetChildIndex(this.btnBuscarProducto, 0);
            this.Controls.SetChildIndex(this.lblMargen, 0);
            this.Controls.SetChildIndex(this.txtMargen, 0);
            this.Controls.SetChildIndex(this.lblPrecio, 0);
            this.Controls.SetChildIndex(this.txtPrecio, 0);
            this.Controls.SetChildIndex(this.lblDescripcion, 0);
            this.Controls.SetChildIndex(this.txtDescripcion, 0);
            this.Controls.SetChildIndex(this.cmbTipo, 0);
            this.Controls.SetChildIndex(this.btnSalir, 0);
            this.Controls.SetChildIndex(this.lblTema, 0);
            this.Controls.SetChildIndex(this.chkNocturno, 0);
            this.Controls.SetChildIndex(this.nudCant, 0);
            this.Controls.SetChildIndex(this.lblTipo, 0);
            this.Controls.SetChildIndex(this.lblModifCant, 0);
            this.Controls.SetChildIndex(this.lblCantExist, 0);
            this.Controls.SetChildIndex(this.lblNumCantExist, 0);
            ((System.ComponentModel.ISupportInitialize)(this.nudCant)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.Button btnBuscarProducto;
        private System.Windows.Forms.TextBox txtBuscarProducto;
        private System.Windows.Forms.Label lblBuscar;
        protected System.Windows.Forms.Button btnAgregar;
        protected System.Windows.Forms.Button btnBorrar;
        protected System.Windows.Forms.Button btnModificar;
        protected System.Windows.Forms.TextBox txtCosto;
        public System.Windows.Forms.Label lblCosto;
        protected System.Windows.Forms.TextBox txtMarca;
        public System.Windows.Forms.Label lblMarca;
        protected System.Windows.Forms.TextBox txtCodigo;
        public System.Windows.Forms.Label lblCodigo;
        protected System.Windows.Forms.TextBox txtNombre;
        public System.Windows.Forms.Label lblNombre;
        protected System.Windows.Forms.TextBox txtMargen;
        public System.Windows.Forms.Label lblMargen;
        protected System.Windows.Forms.TextBox txtPrecio;
        public System.Windows.Forms.Label lblPrecio;
        protected System.Windows.Forms.TextBox txtDescripcion;
        public System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.NumericUpDown nudCant;
        public System.Windows.Forms.Label lblTipo;
        public System.Windows.Forms.Label lblModifCant;
        public System.Windows.Forms.Label lblCantExist;
        public System.Windows.Forms.Label lblNumCantExist;
    }
}