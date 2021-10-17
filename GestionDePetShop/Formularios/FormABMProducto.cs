using System;
using System.Drawing;
using System.Windows.Forms;

using Entidades.Estaticas;

using Formularios.Generales;

using static Entidades.Estaticas.Producto;

namespace Formularios
{
    public partial class FormABMProducto : FrmBase
    {
        public FormABMProducto()
        {
            InitializeComponent();
        }

        public FormABMProducto(CheckState estado) : this()
        {
            chkNocturno.CheckState = estado;
        }

        private void FormABMProducto_Load(object sender, EventArgs e)
        {
            cmbTipo.Items.Add(EProducto.Alimentos);
            cmbTipo.Items.Add(EProducto.Camas);
            cmbTipo.Items.Add(EProducto.Farmacia);
            cmbTipo.Items.Add(EProducto.Higiene);
            cmbTipo.Items.Add(EProducto.Juguetes);
        }

        private void chkNocturno_CheckedChanged(object sender, EventArgs e)
        {
            if (chkNocturno.Checked)
            {
                CajaTextoOscuro(txtBuscarProducto, txtNombre, txtCodigo, txtMarca);
                CajaTextoOscuro(txtCosto, txtMargen, txtPrecio, txtDescripcion);
                BotonOscuro(btnBuscarProducto, btnAgregar, btnModificar);
                BotonOscuro(btnBorrar);
                cmbTipo.BackColor = Color.FromArgb(64, 64, 64);
                cmbTipo.ForeColor = Color.White;
                nudCant.BackColor = Color.FromArgb(64, 64, 64);
                nudCant.ForeColor = Color.White;
            }
            else
            {
                CajaTextoClaro(txtBuscarProducto, txtNombre, txtCodigo, txtMarca);
                CajaTextoClaro(txtCosto, txtMargen, txtPrecio, txtDescripcion);
                BotonClaro(btnBuscarProducto, btnAgregar, btnModificar);
                BotonClaro(btnBorrar);
                cmbTipo.BackColor = Color.RoyalBlue;
                cmbTipo.ForeColor = Color.Black;
                nudCant.BackColor = Color.RoyalBlue;
                nudCant.ForeColor = Color.Black;
            }
        }

        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            Producto producto = Stock.BuscarProductoPorKey(Stock.ObtenerKey(txtBuscarProducto.Text));
            if (producto != null)
            {
                txtBuscarProducto.Text = string.Empty;
                txtNombre.Text = producto.Nombre;
                txtCodigo.Text = producto.Codigo;
                txtMarca.Text = producto.Marca;
                txtCosto.Text = producto.Costo.ToString();
                txtMargen.Text = producto.Margen.ToString();
                txtPrecio.Text = producto.Precio.ToString();
                txtDescripcion.Text = producto.Descripcion;
                lblNumCantExist.Text = producto.Cantidad.ToString();
                cmbTipo.Text = producto.Tipo.ToString();
                nudCant.Value = 0;
            }
            else
            {
                LimpiarCampos();
                MessageBox.Show("El producto no se encontró", "Aviso", MessageBoxButtons.OK,
                   MessageBoxIcon.Information);
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro que desea borrar este producto?", "Borrando", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                   == DialogResult.Yes)
            {
                if (Stock.BorrarProducto(Stock.ObtenerKey(txtCodigo.Text)))
                {
                    LimpiarCampos();
                    MessageBox.Show("El producto se elimino con éxito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("El producto no fue eliminado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                this.Close();
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            if (Stock.ObtenerKey(txtNombre.Text) != string.Empty)
            {
                txtNombre.Text = $"{txtNombre.Text}... Ya existe";
                txtNombre.ForeColor = Color.Red;
            }
            else if (Stock.ObtenerKey(txtCodigo.Text) != string.Empty)
            {
                txtCodigo.Text = $"{txtCodigo.Text}... Ya existe";
                txtCodigo.ForeColor = Color.Red;
            }

            else
            {
                int contador = Stock.CantidadProductosComercializados;
                if (double.TryParse(txtCosto.Text, out double auxCosto) && double.TryParse(txtMargen.Text, out double auxMargen) && int.TryParse(nudCant.Text, out int auxCantidad) && txtNombre.Text != string.Empty && txtCodigo.Text != string.Empty && txtMarca.Text != string.Empty && txtDescripcion.Text != string.Empty)
                {
                    Producto nuevoProducto = new Producto(txtNombre.Text, txtCodigo.Text, txtMarca.Text, auxCosto, auxMargen, auxCantidad, txtDescripcion.Text,EProducto.Juguetes);//CORREGIR, DEBE TOMAR EL TIMP DEL CMB
                    Stock.stockExistente.Add(txtCodigo.Text, nuevoProducto);
                }
                else
                {
                    MessageBox.Show("Ocurrió un problema el producto no se creó", "Aviso", MessageBoxButtons.OK,
                           MessageBoxIcon.Information);
                }
                if (contador < Stock.CantidadProductosComercializados)
                {

                    MessageBox.Show("El producto se agrego con éxito", "Aviso", MessageBoxButtons.OK,
                           MessageBoxIcon.Information);
                    LimpiarCampos();
                    this.Close();
                }
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

            MessageBox.Show("En construcción");
        }


        private void LimpiarCampos()
        {
            txtBuscarProducto.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtCodigo.Text = string.Empty;
            txtMarca.Text = string.Empty;
            txtCosto.Text = string.Empty;
            txtMargen.Text = string.Empty;
            txtPrecio.Text = string.Empty;
            txtDescripcion.Text = string.Empty;
            lblNumCantExist.Text = "-";
            cmbTipo.Text = string.Empty;
            nudCant.Value = 0;
        }

        
    }
}
