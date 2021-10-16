
namespace Formularios
{
    partial class FormInfoVentas
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
            this.btnBuscarVenta = new System.Windows.Forms.Button();
            this.txtBuscarVenta = new System.Windows.Forms.TextBox();
            this.lblBuscarVenta = new System.Windows.Forms.Label();
            this.txtCarrito = new System.Windows.Forms.TextBox();
            this.lblCarrito = new System.Windows.Forms.Label();
            this.lblNumFactTotal = new System.Windows.Forms.Label();
            this.lblFacturacionTotal = new System.Windows.Forms.Label();
            this.lblNombreProdMasVend = new System.Windows.Forms.Label();
            this.lblProductoMasVendido = new System.Windows.Forms.Label();
            this.lblNombreVendedorTop = new System.Windows.Forms.Label();
            this.lblVendedorDelMes = new System.Windows.Forms.Label();
            this.btnBorrarVenta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btnSalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnSalir.Location = new System.Drawing.Point(187, 358);
            // 
            // lblTema
            // 
            this.lblTema.Location = new System.Drawing.Point(240, -2);
            // 
            // chkNocturno
            // 
            this.chkNocturno.Location = new System.Drawing.Point(240, 12);
            this.chkNocturno.CheckedChanged += new System.EventHandler(this.chkNocturno_CheckedChanged);
            // 
            // btnBuscarVenta
            // 
            this.btnBuscarVenta.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscarVenta.BackgroundImage = global::Formularios.Properties.Resources.boton2;
            this.btnBuscarVenta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscarVenta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarVenta.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btnBuscarVenta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnBuscarVenta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnBuscarVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarVenta.Font = new System.Drawing.Font("EngraversGothic BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBuscarVenta.ForeColor = System.Drawing.Color.Black;
            this.btnBuscarVenta.Location = new System.Drawing.Point(77, 181);
            this.btnBuscarVenta.Name = "btnBuscarVenta";
            this.btnBuscarVenta.Size = new System.Drawing.Size(90, 32);
            this.btnBuscarVenta.TabIndex = 87;
            this.btnBuscarVenta.Text = "Buscar";
            this.btnBuscarVenta.UseVisualStyleBackColor = false;
            // 
            // txtBuscarVenta
            // 
            this.txtBuscarVenta.BackColor = System.Drawing.Color.CornflowerBlue;
            this.txtBuscarVenta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBuscarVenta.ForeColor = System.Drawing.Color.Black;
            this.txtBuscarVenta.Location = new System.Drawing.Point(12, 158);
            this.txtBuscarVenta.Name = "txtBuscarVenta";
            this.txtBuscarVenta.Size = new System.Drawing.Size(217, 17);
            this.txtBuscarVenta.TabIndex = 86;
            // 
            // lblBuscarVenta
            // 
            this.lblBuscarVenta.AutoSize = true;
            this.lblBuscarVenta.Font = new System.Drawing.Font("Lilex", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblBuscarVenta.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblBuscarVenta.Location = new System.Drawing.Point(12, 140);
            this.lblBuscarVenta.Name = "lblBuscarVenta";
            this.lblBuscarVenta.Size = new System.Drawing.Size(91, 15);
            this.lblBuscarVenta.TabIndex = 88;
            this.lblBuscarVenta.Text = "Buscar Venta";
            // 
            // txtCarrito
            // 
            this.txtCarrito.BackColor = System.Drawing.Color.CornflowerBlue;
            this.txtCarrito.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCarrito.ForeColor = System.Drawing.Color.Black;
            this.txtCarrito.Location = new System.Drawing.Point(12, 236);
            this.txtCarrito.Multiline = true;
            this.txtCarrito.Name = "txtCarrito";
            this.txtCarrito.Size = new System.Drawing.Size(263, 108);
            this.txtCarrito.TabIndex = 104;
            // 
            // lblCarrito
            // 
            this.lblCarrito.AutoSize = true;
            this.lblCarrito.Font = new System.Drawing.Font("Lilex", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCarrito.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblCarrito.Location = new System.Drawing.Point(12, 218);
            this.lblCarrito.Name = "lblCarrito";
            this.lblCarrito.Size = new System.Drawing.Size(56, 15);
            this.lblCarrito.TabIndex = 105;
            this.lblCarrito.Text = "Carrito";
            // 
            // lblNumFactTotal
            // 
            this.lblNumFactTotal.AutoSize = true;
            this.lblNumFactTotal.Font = new System.Drawing.Font("Lilex", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNumFactTotal.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblNumFactTotal.Location = new System.Drawing.Point(12, 27);
            this.lblNumFactTotal.Name = "lblNumFactTotal";
            this.lblNumFactTotal.Size = new System.Drawing.Size(14, 15);
            this.lblNumFactTotal.TabIndex = 107;
            this.lblNumFactTotal.Text = "-";
            // 
            // lblFacturacionTotal
            // 
            this.lblFacturacionTotal.AutoSize = true;
            this.lblFacturacionTotal.Font = new System.Drawing.Font("Lilex", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFacturacionTotal.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblFacturacionTotal.Location = new System.Drawing.Point(12, 12);
            this.lblFacturacionTotal.Name = "lblFacturacionTotal";
            this.lblFacturacionTotal.Size = new System.Drawing.Size(133, 15);
            this.lblFacturacionTotal.TabIndex = 106;
            this.lblFacturacionTotal.Text = "Facturacion Total:";
            // 
            // lblNombreProdMasVend
            // 
            this.lblNombreProdMasVend.AutoSize = true;
            this.lblNombreProdMasVend.Font = new System.Drawing.Font("Lilex", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNombreProdMasVend.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblNombreProdMasVend.Location = new System.Drawing.Point(12, 70);
            this.lblNombreProdMasVend.Name = "lblNombreProdMasVend";
            this.lblNombreProdMasVend.Size = new System.Drawing.Size(14, 15);
            this.lblNombreProdMasVend.TabIndex = 109;
            this.lblNombreProdMasVend.Text = "-";
            // 
            // lblProductoMasVendido
            // 
            this.lblProductoMasVendido.AutoSize = true;
            this.lblProductoMasVendido.Font = new System.Drawing.Font("Lilex", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblProductoMasVendido.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblProductoMasVendido.Location = new System.Drawing.Point(12, 56);
            this.lblProductoMasVendido.Name = "lblProductoMasVendido";
            this.lblProductoMasVendido.Size = new System.Drawing.Size(154, 15);
            this.lblProductoMasVendido.TabIndex = 108;
            this.lblProductoMasVendido.Text = "Producto más vendido:";
            // 
            // lblNombreVendedorTop
            // 
            this.lblNombreVendedorTop.AutoSize = true;
            this.lblNombreVendedorTop.Font = new System.Drawing.Font("Lilex", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNombreVendedorTop.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblNombreVendedorTop.Location = new System.Drawing.Point(12, 114);
            this.lblNombreVendedorTop.Name = "lblNombreVendedorTop";
            this.lblNombreVendedorTop.Size = new System.Drawing.Size(14, 15);
            this.lblNombreVendedorTop.TabIndex = 111;
            this.lblNombreVendedorTop.Text = "-";
            // 
            // lblVendedorDelMes
            // 
            this.lblVendedorDelMes.AutoSize = true;
            this.lblVendedorDelMes.Font = new System.Drawing.Font("Lilex", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblVendedorDelMes.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblVendedorDelMes.Location = new System.Drawing.Point(12, 99);
            this.lblVendedorDelMes.Name = "lblVendedorDelMes";
            this.lblVendedorDelMes.Size = new System.Drawing.Size(105, 15);
            this.lblVendedorDelMes.TabIndex = 110;
            this.lblVendedorDelMes.Text = "Mejor Vendedor";
            // 
            // btnBorrarVenta
            // 
            this.btnBorrarVenta.BackColor = System.Drawing.Color.Transparent;
            this.btnBorrarVenta.BackgroundImage = global::Formularios.Properties.Resources.boton2;
            this.btnBorrarVenta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBorrarVenta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBorrarVenta.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btnBorrarVenta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnBorrarVenta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnBorrarVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrarVenta.Font = new System.Drawing.Font("EngraversGothic BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBorrarVenta.ForeColor = System.Drawing.Color.Black;
            this.btnBorrarVenta.Location = new System.Drawing.Point(26, 350);
            this.btnBorrarVenta.Name = "btnBorrarVenta";
            this.btnBorrarVenta.Size = new System.Drawing.Size(98, 48);
            this.btnBorrarVenta.TabIndex = 112;
            this.btnBorrarVenta.Text = "Borrar Venta";
            this.btnBorrarVenta.UseVisualStyleBackColor = false;
            // 
            // FormInfoVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 407);
            this.Controls.Add(this.btnBorrarVenta);
            this.Controls.Add(this.lblNombreVendedorTop);
            this.Controls.Add(this.lblVendedorDelMes);
            this.Controls.Add(this.lblNombreProdMasVend);
            this.Controls.Add(this.lblProductoMasVendido);
            this.Controls.Add(this.lblNumFactTotal);
            this.Controls.Add(this.lblFacturacionTotal);
            this.Controls.Add(this.txtCarrito);
            this.Controls.Add(this.lblCarrito);
            this.Controls.Add(this.btnBuscarVenta);
            this.Controls.Add(this.txtBuscarVenta);
            this.Controls.Add(this.lblBuscarVenta);
            this.Name = "FormInfoVentas";
            this.Text = "Informe de Ventas";
            this.Controls.SetChildIndex(this.lblBuscarVenta, 0);
            this.Controls.SetChildIndex(this.txtBuscarVenta, 0);
            this.Controls.SetChildIndex(this.btnBuscarVenta, 0);
            this.Controls.SetChildIndex(this.btnSalir, 0);
            this.Controls.SetChildIndex(this.lblTema, 0);
            this.Controls.SetChildIndex(this.chkNocturno, 0);
            this.Controls.SetChildIndex(this.lblCarrito, 0);
            this.Controls.SetChildIndex(this.txtCarrito, 0);
            this.Controls.SetChildIndex(this.lblFacturacionTotal, 0);
            this.Controls.SetChildIndex(this.lblNumFactTotal, 0);
            this.Controls.SetChildIndex(this.lblProductoMasVendido, 0);
            this.Controls.SetChildIndex(this.lblNombreProdMasVend, 0);
            this.Controls.SetChildIndex(this.lblVendedorDelMes, 0);
            this.Controls.SetChildIndex(this.lblNombreVendedorTop, 0);
            this.Controls.SetChildIndex(this.btnBorrarVenta, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.Button btnBuscarVenta;
        private System.Windows.Forms.TextBox txtBuscarVenta;
        private System.Windows.Forms.Label lblBuscarVenta;
        protected System.Windows.Forms.TextBox txtCarrito;
        public System.Windows.Forms.Label lblCarrito;
        public System.Windows.Forms.Label lblNumFactTotal;
        public System.Windows.Forms.Label lblFacturacionTotal;
        public System.Windows.Forms.Label lblNombreProdMasVend;
        public System.Windows.Forms.Label lblProductoMasVendido;
        public System.Windows.Forms.Label lblNombreVendedorTop;
        public System.Windows.Forms.Label lblVendedorDelMes;
        protected System.Windows.Forms.Button btnBorrarVenta;
    }
}