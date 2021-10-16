
namespace Formularios
{
    partial class FormVenta
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
            this.lblBuscarCliente = new System.Windows.Forms.Label();
            this.lblNumCantExist = new System.Windows.Forms.Label();
            this.lblCantExist = new System.Windows.Forms.Label();
            this.lblCantSolicitada = new System.Windows.Forms.Label();
            this.lblProducto = new System.Windows.Forms.Label();
            this.nudCant = new System.Windows.Forms.NumericUpDown();
            this.cmbProducto = new System.Windows.Forms.ComboBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnBuscarProducto = new System.Windows.Forms.Button();
            this.txtBuscarProducto = new System.Windows.Forms.TextBox();
            this.lblBuscarProducto = new System.Windows.Forms.Label();
            this.btnFinalizarCompra = new System.Windows.Forms.Button();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.btnTicket = new System.Windows.Forms.Button();
            this.lblCarrito = new System.Windows.Forms.Label();
            this.txtCarrito = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudCant)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btnSalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnSalir.Location = new System.Drawing.Point(235, 467);
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lblTema
            // 
            this.lblTema.Location = new System.Drawing.Point(275, -1);
            // 
            // chkNocturno
            // 
            this.chkNocturno.Location = new System.Drawing.Point(275, 13);
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
            this.btnBuscarCliente.Location = new System.Drawing.Point(77, 46);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(90, 32);
            this.btnBuscarCliente.TabIndex = 84;
            this.btnBuscarCliente.Text = "Buscar";
            this.btnBuscarCliente.UseVisualStyleBackColor = false;
            // 
            // txtBuscarCliente
            // 
            this.txtBuscarCliente.BackColor = System.Drawing.Color.CornflowerBlue;
            this.txtBuscarCliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBuscarCliente.ForeColor = System.Drawing.Color.Black;
            this.txtBuscarCliente.Location = new System.Drawing.Point(12, 23);
            this.txtBuscarCliente.Name = "txtBuscarCliente";
            this.txtBuscarCliente.Size = new System.Drawing.Size(217, 17);
            this.txtBuscarCliente.TabIndex = 83;
            // 
            // lblBuscarCliente
            // 
            this.lblBuscarCliente.AutoSize = true;
            this.lblBuscarCliente.Font = new System.Drawing.Font("Lilex", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblBuscarCliente.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblBuscarCliente.Location = new System.Drawing.Point(12, 5);
            this.lblBuscarCliente.Name = "lblBuscarCliente";
            this.lblBuscarCliente.Size = new System.Drawing.Size(105, 15);
            this.lblBuscarCliente.TabIndex = 85;
            this.lblBuscarCliente.Text = "Buscar Cliente";
            // 
            // lblNumCantExist
            // 
            this.lblNumCantExist.AutoSize = true;
            this.lblNumCantExist.Font = new System.Drawing.Font("Lilex", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNumCantExist.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblNumCantExist.Location = new System.Drawing.Point(151, 218);
            this.lblNumCantExist.Name = "lblNumCantExist";
            this.lblNumCantExist.Size = new System.Drawing.Size(14, 15);
            this.lblNumCantExist.TabIndex = 100;
            this.lblNumCantExist.Text = "-";
            // 
            // lblCantExist
            // 
            this.lblCantExist.AutoSize = true;
            this.lblCantExist.Font = new System.Drawing.Font("Lilex", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCantExist.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblCantExist.Location = new System.Drawing.Point(12, 218);
            this.lblCantExist.Name = "lblCantExist";
            this.lblCantExist.Size = new System.Drawing.Size(140, 15);
            this.lblCantExist.TabIndex = 99;
            this.lblCantExist.Text = "Cantidad existente:";
            // 
            // lblCantSolicitada
            // 
            this.lblCantSolicitada.AutoSize = true;
            this.lblCantSolicitada.Font = new System.Drawing.Font("Lilex", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCantSolicitada.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblCantSolicitada.Location = new System.Drawing.Point(12, 243);
            this.lblCantSolicitada.Name = "lblCantSolicitada";
            this.lblCantSolicitada.Size = new System.Drawing.Size(140, 15);
            this.lblCantSolicitada.TabIndex = 98;
            this.lblCantSolicitada.Text = "Cantidad Solicitada";
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.Font = new System.Drawing.Font("Lilex", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblProducto.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblProducto.Location = new System.Drawing.Point(12, 84);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(63, 15);
            this.lblProducto.TabIndex = 97;
            this.lblProducto.Text = "Producto";
            // 
            // nudCant
            // 
            this.nudCant.BackColor = System.Drawing.Color.CornflowerBlue;
            this.nudCant.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nudCant.Location = new System.Drawing.Point(180, 243);
            this.nudCant.Name = "nudCant";
            this.nudCant.Size = new System.Drawing.Size(49, 20);
            this.nudCant.TabIndex = 96;
            // 
            // cmbProducto
            // 
            this.cmbProducto.BackColor = System.Drawing.Color.CornflowerBlue;
            this.cmbProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbProducto.FormattingEnabled = true;
            this.cmbProducto.Location = new System.Drawing.Point(12, 102);
            this.cmbProducto.Name = "cmbProducto";
            this.cmbProducto.Size = new System.Drawing.Size(217, 25);
            this.cmbProducto.TabIndex = 95;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.Transparent;
            this.btnAgregar.BackgroundImage = global::Formularios.Properties.Resources.Carrito;
            this.btnAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btnAgregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("EngraversGothic BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAgregar.ForeColor = System.Drawing.Color.Black;
            this.btnAgregar.Location = new System.Drawing.Point(257, 138);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(53, 53);
            this.btnAgregar.TabIndex = 101;
            this.btnAgregar.UseVisualStyleBackColor = false;
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
            this.btnBuscarProducto.Location = new System.Drawing.Point(75, 179);
            this.btnBuscarProducto.Name = "btnBuscarProducto";
            this.btnBuscarProducto.Size = new System.Drawing.Size(90, 32);
            this.btnBuscarProducto.TabIndex = 105;
            this.btnBuscarProducto.Text = "Buscar";
            this.btnBuscarProducto.UseVisualStyleBackColor = false;
            // 
            // txtBuscarProducto
            // 
            this.txtBuscarProducto.BackColor = System.Drawing.Color.CornflowerBlue;
            this.txtBuscarProducto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBuscarProducto.ForeColor = System.Drawing.Color.Black;
            this.txtBuscarProducto.Location = new System.Drawing.Point(10, 156);
            this.txtBuscarProducto.Name = "txtBuscarProducto";
            this.txtBuscarProducto.Size = new System.Drawing.Size(217, 17);
            this.txtBuscarProducto.TabIndex = 104;
            // 
            // lblBuscarProducto
            // 
            this.lblBuscarProducto.AutoSize = true;
            this.lblBuscarProducto.Font = new System.Drawing.Font("Lilex", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblBuscarProducto.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblBuscarProducto.Location = new System.Drawing.Point(10, 138);
            this.lblBuscarProducto.Name = "lblBuscarProducto";
            this.lblBuscarProducto.Size = new System.Drawing.Size(112, 15);
            this.lblBuscarProducto.TabIndex = 106;
            this.lblBuscarProducto.Text = "Buscar Producto";
            // 
            // btnFinalizarCompra
            // 
            this.btnFinalizarCompra.BackColor = System.Drawing.Color.Transparent;
            this.btnFinalizarCompra.BackgroundImage = global::Formularios.Properties.Resources.boton2;
            this.btnFinalizarCompra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFinalizarCompra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFinalizarCompra.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btnFinalizarCompra.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnFinalizarCompra.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnFinalizarCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinalizarCompra.Font = new System.Drawing.Font("EngraversGothic BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnFinalizarCompra.ForeColor = System.Drawing.Color.Black;
            this.btnFinalizarCompra.Location = new System.Drawing.Point(116, 460);
            this.btnFinalizarCompra.Name = "btnFinalizarCompra";
            this.btnFinalizarCompra.Size = new System.Drawing.Size(95, 46);
            this.btnFinalizarCompra.TabIndex = 107;
            this.btnFinalizarCompra.Text = "Finalizar Compra";
            this.btnFinalizarCompra.UseVisualStyleBackColor = false;
            this.btnFinalizarCompra.Click += new System.EventHandler(this.btnFinalizarCompra_Click);
            // 
            // btnQuitar
            // 
            this.btnQuitar.BackColor = System.Drawing.Color.Transparent;
            this.btnQuitar.BackgroundImage = global::Formularios.Properties.Resources.Tacho;
            this.btnQuitar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnQuitar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuitar.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btnQuitar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnQuitar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnQuitar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuitar.Font = new System.Drawing.Font("EngraversGothic BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnQuitar.ForeColor = System.Drawing.Color.Black;
            this.btnQuitar.Location = new System.Drawing.Point(257, 210);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(53, 53);
            this.btnQuitar.TabIndex = 108;
            this.btnQuitar.UseVisualStyleBackColor = false;
            // 
            // btnTicket
            // 
            this.btnTicket.BackColor = System.Drawing.Color.Transparent;
            this.btnTicket.BackgroundImage = global::Formularios.Properties.Resources.TXT;
            this.btnTicket.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTicket.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTicket.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btnTicket.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnTicket.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnTicket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTicket.Font = new System.Drawing.Font("EngraversGothic BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnTicket.ForeColor = System.Drawing.Color.Black;
            this.btnTicket.Location = new System.Drawing.Point(22, 457);
            this.btnTicket.Name = "btnTicket";
            this.btnTicket.Size = new System.Drawing.Size(53, 53);
            this.btnTicket.TabIndex = 109;
            this.btnTicket.UseVisualStyleBackColor = false;
            // 
            // lblCarrito
            // 
            this.lblCarrito.AutoSize = true;
            this.lblCarrito.Font = new System.Drawing.Font("Lilex", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCarrito.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblCarrito.Location = new System.Drawing.Point(12, 276);
            this.lblCarrito.Name = "lblCarrito";
            this.lblCarrito.Size = new System.Drawing.Size(56, 15);
            this.lblCarrito.TabIndex = 103;
            this.lblCarrito.Text = "Carrito";
            // 
            // txtCarrito
            // 
            this.txtCarrito.BackColor = System.Drawing.Color.CornflowerBlue;
            this.txtCarrito.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCarrito.ForeColor = System.Drawing.Color.Black;
            this.txtCarrito.Location = new System.Drawing.Point(12, 294);
            this.txtCarrito.Multiline = true;
            this.txtCarrito.Name = "txtCarrito";
            this.txtCarrito.Size = new System.Drawing.Size(307, 153);
            this.txtCarrito.TabIndex = 102;
            // 
            // FormVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 517);
            this.Controls.Add(this.btnTicket);
            this.Controls.Add(this.btnQuitar);
            this.Controls.Add(this.btnFinalizarCompra);
            this.Controls.Add(this.btnBuscarProducto);
            this.Controls.Add(this.txtBuscarProducto);
            this.Controls.Add(this.lblBuscarProducto);
            this.Controls.Add(this.txtCarrito);
            this.Controls.Add(this.lblCarrito);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lblNumCantExist);
            this.Controls.Add(this.lblCantExist);
            this.Controls.Add(this.lblCantSolicitada);
            this.Controls.Add(this.lblProducto);
            this.Controls.Add(this.nudCant);
            this.Controls.Add(this.cmbProducto);
            this.Controls.Add(this.btnBuscarCliente);
            this.Controls.Add(this.txtBuscarCliente);
            this.Controls.Add(this.lblBuscarCliente);
            this.Name = "FormVenta";
            this.Text = "Venta";
            this.Controls.SetChildIndex(this.lblBuscarCliente, 0);
            this.Controls.SetChildIndex(this.txtBuscarCliente, 0);
            this.Controls.SetChildIndex(this.btnBuscarCliente, 0);
            this.Controls.SetChildIndex(this.cmbProducto, 0);
            this.Controls.SetChildIndex(this.nudCant, 0);
            this.Controls.SetChildIndex(this.lblProducto, 0);
            this.Controls.SetChildIndex(this.lblCantSolicitada, 0);
            this.Controls.SetChildIndex(this.lblCantExist, 0);
            this.Controls.SetChildIndex(this.lblNumCantExist, 0);
            this.Controls.SetChildIndex(this.btnAgregar, 0);
            this.Controls.SetChildIndex(this.lblCarrito, 0);
            this.Controls.SetChildIndex(this.txtCarrito, 0);
            this.Controls.SetChildIndex(this.lblBuscarProducto, 0);
            this.Controls.SetChildIndex(this.txtBuscarProducto, 0);
            this.Controls.SetChildIndex(this.btnBuscarProducto, 0);
            this.Controls.SetChildIndex(this.btnFinalizarCompra, 0);
            this.Controls.SetChildIndex(this.btnQuitar, 0);
            this.Controls.SetChildIndex(this.btnTicket, 0);
            this.Controls.SetChildIndex(this.btnSalir, 0);
            this.Controls.SetChildIndex(this.lblTema, 0);
            this.Controls.SetChildIndex(this.chkNocturno, 0);
            ((System.ComponentModel.ISupportInitialize)(this.nudCant)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.Button btnBuscarCliente;
        private System.Windows.Forms.TextBox txtBuscarCliente;
        private System.Windows.Forms.Label lblBuscarCliente;
        public System.Windows.Forms.Label lblNumCantExist;
        public System.Windows.Forms.Label lblCantExist;
        public System.Windows.Forms.Label lblCantSolicitada;
        public System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.NumericUpDown nudCant;
        private System.Windows.Forms.ComboBox cmbProducto;
        protected System.Windows.Forms.Button btnAgregar;
        protected System.Windows.Forms.Button btnBuscarProducto;
        private System.Windows.Forms.TextBox txtBuscarProducto;
        private System.Windows.Forms.Label lblBuscarProducto;
        protected System.Windows.Forms.Button btnFinalizarCompra;
        protected System.Windows.Forms.Button btnQuitar;
        protected System.Windows.Forms.Button btnTicket;
        public System.Windows.Forms.Label lblCarrito;
        protected System.Windows.Forms.TextBox txtCarrito;
    }
}