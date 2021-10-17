using System;
using System.Drawing;
using System.Windows.Forms;

using Entidades;
using Entidades.Estaticas;
using Entidades.Usuarios;

using Formularios.Generales;

namespace Formularios
{
    public partial class FormLogin : FrmBase
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            SuperUsuario ezequiel = new("exe", "Ezequiel O", 20269654741, "ab123");
            Administrador lucas = new("luca", "Lucas R", 20321286500, "ac123");
            Administrador juanPablo = new("juampi", "Juan Pablo", 20293322652, "ad123");
            Administrador carolina = new("caro", "Carolina", 20106048210, "ae123");
            Empleado nahuel = new("nahu", "Nahuel", 20179444152, "af123");
            PetShop.usuarios.Add(ezequiel);
            PetShop.usuarios.Add(lucas);
            PetShop.usuarios.Add(juanPablo);
            PetShop.usuarios.Add(carolina);
            PetShop.usuarios.Add(nahuel);

            Cliente mabel = new("Mabel J", 24159975, 1548468733, "Mitre 566");
            Cliente enrique = new("Enrique I", 14568136, 1514162165, "Roldan 44");
            Cliente juliana = new("Juliana B", 38891239, 1578365813, "Malvinas 222");
            Cliente sebastian = new("Sebastian R", 34556894, 1524668546, "Pedernera 8899");
            PetShop.clientes.Add(mabel);
            PetShop.clientes.Add(enrique);
            PetShop.clientes.Add(juliana);
            PetShop.clientes.Add(sebastian);

          Producto comidaPerro = new("Comida p/ perro","A000", "DogShow",100,1.2,4,"Alimento balanceado de primera calidad",Producto.EProducto.Alimentos);
          Producto comidaGato = new("Comida p/ gato","A001", "GatShow",80,1.25,7,"Alimento balanceado de primera calidad",Producto.EProducto.Alimentos);
            Producto comidaPez = new("Comida p/ peces", "A002", "FishShow", 50, 1.25, 3, "Alimento en escamas de primera calidad", Producto.EProducto.Alimentos);
            Producto camita = new("Cama uniespecie","C000", "Camita Calentita",500,1.15,2,"Camita suavecita",Producto.EProducto.Camas);
          Producto jarabe = new("Jarabe p/ tos","F001", "AnimalFarma",150,1.18,3,"Para aliviar la tos de tu mascota",Producto.EProducto.Farmacia);
          Producto pulguitas = new("Pulguicida","F002", "AnimalFarma", 90,1.18,2,"Pastilla protectora de pulgas",Producto.EProducto.Farmacia);
          Producto shampoo = new("Plumas con brillo","H000", "Belleza",58.5,1.2,3,"Shampoo para aves",Producto.EProducto.Higiene);
          Producto pelota = new("Pelota Colorida","J000", "Diversión",200,1.15,1,"Alimento balanceado de primera calidad",Producto.EProducto.Juguetes);
          Producto pelotaCascabel = new("Pelota ruidosa","J001", "Animalia",230,1.15,5,"Alimento balanceado de primera calidad",Producto.EProducto.Juguetes);
            Stock.stockExistente.Add(comidaPerro.Codigo,comidaPerro);
            Stock.stockExistente.Add(comidaGato.Codigo, comidaGato);
            Stock.stockExistente.Add(comidaPez.Codigo, comidaPez);
            Stock.stockExistente.Add(camita.Codigo, camita);
            Stock.stockExistente.Add(jarabe.Codigo, jarabe);
            Stock.stockExistente.Add(pulguitas.Codigo, pulguitas);
            Stock.stockExistente.Add(shampoo.Codigo, shampoo);
            Stock.stockExistente.Add(pelota.Codigo, pelota);
            Stock.stockExistente.Add(pelotaCascabel.Codigo, pelotaCascabel);
        }

        private void chkNocturno_CheckedChanged(object sender, EventArgs e)
        {
            if (chkNocturno.Checked)
            {
                chkHarcode.ForeColor = Color.WhiteSmoke;
                chkHarcode.BackColor = Color.FromArgb(64, 64, 64);
                BotonOscuro(btnIngresar);
                CajaTextoOscuro(txtUsuario, txtContrasenia);
            }
            else
            {
                chkHarcode.ForeColor = Color.Black;
                chkHarcode.BackColor = Color.RoyalBlue;
                BotonClaro(btnIngresar);
                CajaTextoClaro(txtUsuario, txtContrasenia);
            }
        }

        private void chkHarcode_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indice = chkHarcode.SelectedIndex;

            if (chkHarcode.GetItemChecked(0) == false && chkHarcode.GetItemChecked(1) == false && chkHarcode.GetItemChecked(2) == false)
            {
                txtUsuario.Text = "";
                txtContrasenia.Text = "";
            }
            else
            {
                switch (indice)
                {
                    case 0:
                        txtUsuario.Text = "exe";
                        txtContrasenia.Text = "ab123";
                        chkHarcode.SetItemChecked(1, false);
                        chkHarcode.SetItemChecked(2, false);
                        break;
                    case 1:
                        txtUsuario.Text = "luca";
                        txtContrasenia.Text = "ac123";
                        chkHarcode.SetItemChecked(0, false);
                        chkHarcode.SetItemChecked(2, false);
                        break;
                    case 2:
                        txtUsuario.Text = "nahu";
                        txtContrasenia.Text = "af123";
                        chkHarcode.SetItemChecked(0, false);
                        chkHarcode.SetItemChecked(1, false);
                        break;
                    default:
                        txtUsuario.Text = "";
                        txtContrasenia.Text = "";
                        break;
                }
            }
        }

        private void chkHarcode_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            for (int i = 0; i < chkHarcode.Items.Count; ++i)
            {
                if (i != e.Index)
                {
                    chkHarcode.SetItemChecked(i, false);
                }
            }
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            int bandera = 0;
            foreach (Usuario u in PetShop.usuarios)
            {
                if (txtUsuario.Text == u.Alias && txtContrasenia.Text == u.Contrasenia)
                {
                    bandera = 1;

                    FormControles frmControles = new FormControles(u, chkNocturno.CheckState);
                    frmControles.ShowDialog();
                    break;

                }
            }
            if (bandera == 0)
            {
                MessageBox.Show("Usuario y/o contraseña incorrectos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Refresh();
            }
        }
    }
}
