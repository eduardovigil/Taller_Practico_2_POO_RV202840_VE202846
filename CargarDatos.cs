using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ventasExpress
{
    public partial class CargarDatos : Form
    {
        Ventas vent;

        Usuario usuario;

        public CargarDatos()
        {
            InitializeComponent();

        }

        private void CargarDatos_Load(object sender, EventArgs e)
        {

            vent = new Ventas();

            // Guardando los productos por defecto
            vent.Lista.Add(new Ventas(1, "Huevos", 30, 0.10));
            vent.Lista.Add(new Ventas(2, "Pollo", 10, 5));
            vent.Lista.Add(new Ventas(3, "Aceite", 50, 3));
            vent.Lista.Add(new Ventas(4, "Fósforos", 200, 0.50));
            vent.Lista.Add(new Ventas(5, "Dulces", 500, 0.80));
            vent.Lista.Add(new Ventas(6, "Margarina", 30, 0.30));
            vent.Lista.Add(new Ventas(7, "Jabón", 25, 2.25));
            vent.Lista.Add(new Ventas(8, "Carne", 35, 2.75));
            vent.Lista.Add(new Ventas(9, "Gaseosa", 200, 1.80));
            vent.Lista.Add(new Ventas(10, "Desechables", 800, 3.25));


            //Guardando los usuarios por defecto - Con encriptacion SHA512
            usuario = new Usuario();

            //Admin - admin123
            usuario.ListaUsuarios.Add(new Usuario("admin", "7FCF4BA391C48784EDDE599889D6E3F1E47A27DB36ECC050CC92F259BFAC38AFAD2C68A1AE804D77075E8FB722503F3ECA2B2C1006EE6F6C7B7628CB45FFFD1D"));

            //vendedor - Vendedor123
            usuario.ListaUsuarios.Add(new Usuario("vendedor", "211B5ED87079A7EB073BB399E75E6FF3DBC19F7804A92E1CA021A480883091C354ED4CAA29600ABFFB3B4EBCD151E0D3FCBF1D475B7DA3FA07D80759CCDD6E7D"));

            //Invitado - invitadoinvitado123
            usuario.ListaUsuarios.Add(new Usuario("Invitado", "4C355F8C135A6BA0E84C4E4E1802F28039E6C65FF9986067B726B4EEF82A7BB8D3886B57F581FD664D94E5D6A1015E367000B9CC1DCFFFF8233A4F49C300B2AF"));

        }

        private void button1_Click(object sender, EventArgs e)
        {

            //Ya teniendo los datos guardados en memoria podemos trabajar el programa
            this.Hide();

            Form1 formLogin = new Form1();

            formLogin.Show();

        }
    }
}
