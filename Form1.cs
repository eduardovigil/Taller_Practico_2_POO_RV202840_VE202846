using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ventasExpress
{
    public partial class Form1 : Form
    {

        Ventas vent;
        Usuario usuari;

        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            //Inicializamos los objetos 
            vent = new Ventas();

            usuari = new Usuario();

        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            //Guardamos las credenciales ingresadas
            string usuario = txtUser.Text;
            string pass = txtContra.Text;

            bool login = false;

            //Comprobamos que haya ingresado datos
            if( usuario.Equals("") || pass.Equals(""))
            {
                MessageBox.Show("Por favor rellena todos los campos.");
            }
            else
            {
                //Encriptamos la contraseña a SHA512
                string passSha512 = ComputeHash(pass, new SHA512CryptoServiceProvider());
                passSha512 = passSha512.Replace("-", "");//Luego quitamos los guiones de la contraseña encriptada
                //Esto debido a que nos devolvia : ' 7F-CF-4B-A3-91- ....... ' 

                foreach (var x in usuari.ListaUsuarios)//Recorremos la lista de Usuarios que ya tenemos guardados en memoria
                {
                    if( x.User.Equals(usuario) && x.Contra.Equals(passSha512)) // Si encontramos un usuario con las credenciales ingresadas , procedemosa a iniciar sesion
                    {

                        login = true;

                        this.Hide();

                        //Abrimos el formulario de las ventas ya teniendo un usuario logueado
                        VentasExpress form = new VentasExpress();
                        form.usuarioActivo = x.User; // Le mandamos al formulario de ventas el nombre del usuario logueado
                        form.Show();
                    }
                    //MessageBox.Show(" sad " + x.Contra);
                }

                if(login == false) // SI la bandera de login quedo en falso, es porque no se encontraron coincidencias
                {
                    MessageBox.Show(" Credenciales incorrectas ");
                }
                
            }     

        }

        //Funcion para encriptar la contraseña ingresada
        public string ComputeHash(string input, HashAlgorithm algorithm)
        {
            Byte[] inputBytes = Encoding.UTF8.GetBytes(input);

            Byte[] hashedBytes = algorithm.ComputeHash(inputBytes);

            return BitConverter.ToString(hashedBytes);
        }

    }
}
