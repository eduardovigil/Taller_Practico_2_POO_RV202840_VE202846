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
    public partial class VentasExpress : Form
    {
        Ventas vent ;

        Usuario usuari;

        public String usuarioActivo;

        public VentasExpress()
        {
            InitializeComponent();
        }

        private void VentasExpress_Load(object sender, EventArgs e)
        {
            //Inicializamos los objetos
            vent = new Ventas();

            usuari = new Usuario();

            //Usuario activo se lleno desde el Form de login, aqui solamente lo imprimimos
            MessageBox.Show(" BIENVENIDO " + usuarioActivo);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Al salir, abrimos nuevamente el login
            this.Hide();

            Form1 form1 = new Form1();
            form1.Show();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //Obtenemos los datos ingresados en el textbox
            string busqueda = txtBusqueda.Text;

            busqueda = busqueda.ToLower(); //Los hacemos en minusculas, para luego trabajar todo en minusculas

            if (busqueda.Equals("") ) //Si no se ingresaron datos, devolver error
            {
                MessageBox.Show("Ingresa un dato en la búsqueda.");
            }
            else
            {

                if (busqueda.Equals("todos")) // Si la busqueda es igual a todos, mostramos todos los datos
                {
                    dgvInventario.DataSource = vent.Lista;
                }
                else
                {
                    //Filtramos los datos de la lista tratando de buscar donde sea igual o el codigo o el nombre del producto
                    dgvInventario.DataSource = vent.Lista.FindAll(x => x.Codigo.ToString().ToLower() == busqueda || x.Producto.ToLower() == busqueda);
                }

            }

        }

        private void btnConsultarInventario_Click(object sender, EventArgs e)
        {
            panelInventario.Visible = true;
            panelContraseña.Visible = false;
            panelVentaNueva.Visible = false;
        }

        private void btnCambiarContraseña_Click(object sender, EventArgs e)
        {
            panelContraseña.Visible = true;
            panelInventario.Visible = false;
            panelVentaNueva.Visible = false;
        }

        private void btnConfirmarContra_Click(object sender, EventArgs e)
        {
            //Guardamos los valores ingresados en los textbox
            string contraActual = txtContraseñaActual.Text;
            string nuevaContra = txtNuevaContra.Text;
            string confirmarContra = txtConfirmarContra.Text;

            bool validarActual = false;

            if (contraActual.Equals("") || nuevaContra.Equals("") || confirmarContra.Equals("")) //Si alguno esta vacio, mostrar error
            {
                MessageBox.Show("Por favor rellena todos los campos.");
            }
            else
            {

                if( nuevaContra.Equals(confirmarContra)) // Si las nuevas contraseñas coinciden proseguimos, si no mostramos error
                {
                    //Encriptamos la contraseña ingresada como actual para verificar que sea igual a la encriptada guardada en memoria
                    string contraActualHash512 = ComputeHash(contraActual, new SHA512CryptoServiceProvider());
                    contraActualHash512 = contraActualHash512.Replace("-", "");

                    foreach (var x in usuari.ListaUsuarios) //REcorremos el listado de usuarios guardados en memoria
                    {
                        if (x.User.Equals(usuarioActivo) && x.Contra.Equals(contraActualHash512)) //Si encuentra uno con el nombre de la sesion activa y la contraseña ingresada
                        {

                            //Encriptamos la nueva contraseña a SHA512
                            string passSha512 = ComputeHash(nuevaContra, new SHA512CryptoServiceProvider());
                            passSha512 = passSha512.Replace("-", "");

                            //Guardamos la nueva contraseña en memoria
                            x.Contra = passSha512;

                            validarActual = true;

                            MessageBox.Show(" Contraseña actualizada ");

                            txtContraseñaActual.Clear();
                            txtConfirmarContra.Clear();
                            txtNuevaContra.Clear();

                        }
                    }


                    if (validarActual == false) //Si la bandera sigue en falso, es porque la contraseña actual no es similar a la ingresada
                    {
                        MessageBox.Show(" Contraseña actual incorrecta ");
                    }

                }
                else
                {
                    MessageBox.Show("Las contraseñas no coinciden");
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

        private void btnNuevaVenta_Click(object sender, EventArgs e)
        {
            panelVentaNueva.Visible = true;
            panelInventario.Visible = false;
            panelContraseña.Visible = false;

            txtCompra.Clear();
            dgvProductosDisponibles.DataSource = vent.Lista;
            lstFactura.Items.Clear();

        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            //Guardamos el texto ingresado en el textbox
            string txt = txtCompra.Text;

            txt = txt.TrimEnd(','); //Si al final encontramos una coma sin ningun numero despues de ella, entonces la eliminamos para que no recorra como si fuera otra compra

            //Booleanos para comprobar si se compro algun pollo o gaseosa
            bool pollo = false;
            bool gaseosa = false;

            //Variable donde guardamos el totalFinalAcumulado
            double totalFinal = 0;

            if (txt.Equals("")) //Si el texto está vacio mostrar error
            {
                MessageBox.Show("Debes rellenar el campo con la compra");
            }
            else
            {

                //Uso del metodo Split, para poder separar el txtCompra y guardar cada valor dentro del arreglo datos
                string[] datos = txt.Split(',');

                string contenidoFactura = "";

                //Agregamos lo primero de la factura.
                lstFactura.Items.Add("Factura de compra");
                lstFactura.Items.Add("Supermercado Don Diego");
                lstFactura.Items.Add("");

                //Uso del ciclo for para recorrer cada dato separado por coma
                for (int i = 0; i < datos.Length; i++)
                {

                    bool validar = false;

                    //Si es par entonces es el codigo del producto
                    if ( i % 2 == 0) {

                        foreach (var x in vent.Lista) //Recorremos la lista de productos
                        {
                            if (x.Codigo.ToString() == datos[i].Trim() ) //Si se encuentra el codigo, se prosigue el procesos
                            {                                       //Usamos el metodo trim para quitar espacios ya sea al final o al inicio del numero
                                contenidoFactura = x.Codigo.ToString() ; //Guardamos temporalmente el codigo del producto
                                validar = true;

                                //Si el codigo es igual al del pollo o la gaseosa estos pasan a verdadero, para comprobarlos después
                                if(x.Codigo == 2)
                                {
                                    pollo = true;
                                }

                                if(x.Codigo == 9)
                                {
                                    gaseosa = true;
                                }
                            }

                        }

                        if (validar == false) //EN CASO DE NO ENCONTRAR UN CÓDIGO AHÍ TERMINA LA FACTURA
                        {
                            MessageBox.Show("ERROR, no se encontró el código del producto ingresado con código: " + datos[i].Trim() + ", Factura terminada hasta antes de este producto." );

                            //Comprobamos si hay gaseosa y pollo para poder regalar los dulces
                            if (pollo == true && gaseosa == true)
                            {
                                lstFactura.Items.Add("");
                                lstFactura.Items.Add(" REGALO: Dulces --- 5 x $0.00 = $0.00 ");
                            }


                            lstFactura.Items.Add("");

                            if (totalFinal >= 20) //Comprobamos si la venta es mayor a $20 para aplicar el 3% de descuento
                            {
                                lstFactura.Items.Add("Subtotal: $" + totalFinal.ToString()); //Mostramos el subtotal sin ningún descuento

                                double descuento = totalFinal * 0.03; //Encontramos el descuento 

                                lstFactura.Items.Add("Descuento (3%) ---- $" + descuento.ToString()); //Mostramos el descuento aplicado
                                lstFactura.Items.Add("");

                                totalFinal = totalFinal - descuento; //Guardamos el totalFinal con el descuento aplicado
                            }

                            //Mostramos el total de la factura
                            lstFactura.Items.Add("Total de factura: $" + totalFinal.ToString());

                            dgvProductosDisponibles.DataSource = null;
                            dgvProductosDisponibles.DataSource = vent.Lista; //Actualizamos el datagridview con la nueva disponibilidad

                            btnComprar.Enabled = false;
                            btnNuevaCompra.Visible = true;

                            return;
                        }
                        

                    }
                    else if( i % 2 != 0) //Si es impar, es la cantidad del producto
                    {

                        foreach (var x in vent.Lista)  //Recoremos siempre la lista de productos
                        {
                            if (x.Codigo.ToString() == contenidoFactura) //Y accedemos al producto de la coma anterior al actual
                            {

                                int cantidadCompra = int.Parse(datos[i].Trim()); //Guardamos la cantidad de compra 

                                //Si hay productos suficientes
                                if(cantidadCompra <= x.Cantidad)
                                {
                                    //Le restamos a la cantidad de existencias, la cantidad que se vendió
                                    x.Cantidad = x.Cantidad - cantidadCompra;

                                    double total = cantidadCompra * x.Precio; //Encontramos el total de este productos

                                    totalFinal += total; //Aumentamos el totalFinal con el total para este producto

                                    contenidoFactura = x.Producto + " --- " + datos[i].Trim() + " x $" + x.Precio.ToString() + " = $" + total.ToString(); //Guardamos la plantilla con los datos de este producto

                                }
                                else if( x.Cantidad == 0 ) //Si no hay existencias
                                {

                                    contenidoFactura = x.Producto + " --- No tenemos en existencia, lo sentimos.";

                                }else if( cantidadCompra > x.Cantidad) // Si se piden más de los que hay en existencia
                                {

                                    double total = x.Cantidad * x.Precio; //Encuentra el total con la cantidad que tengamos en existencia

                                    totalFinal += total;

                                    contenidoFactura = x.Producto + " --- " + x.Cantidad.ToString() + " (disp) x $" + x.Precio.ToString() + " = $" + total.ToString();

                                    x.Cantidad = 0; // Y colocamos 0 existencias ya que las unicas que quedaban se fueron en esta venta

                                }

                                lstFactura.Items.Add(contenidoFactura); //finalmente, agregamos la plantilla de la venta, al listBox

                            }
                        }

                    }
                }

                if (pollo == true && gaseosa == true) //Comprobamos si hay gaseosa y pollo para poder regalar los dulces
                {
                    lstFactura.Items.Add("");
                    lstFactura.Items.Add(" REGALO: Dulces --- 5 x $0.00 = $0.00 " );
                }


                lstFactura.Items.Add("");

                if ( totalFinal >= 20) //Comprobamos si la venta es mayor a $20 para aplicar el 3% de descuento
                {
                    lstFactura.Items.Add("Subtotal: $" + totalFinal.ToString()); //Mostramos el subtotal sin ningún descuento

                    double descuento = totalFinal * 0.03; //Encontramos el descuento 

                    lstFactura.Items.Add("Descuento (3%) ---- $" + descuento.ToString());  //Mostramos el descuento aplicado
                    lstFactura.Items.Add("");

                    totalFinal = totalFinal - descuento;  //Guardamos el totalFinal con el descuento aplicado
                }
                
                lstFactura.Items.Add("Total de factura: $" + totalFinal.ToString());  //Mostramos el total de la factura

                dgvProductosDisponibles.DataSource = null;
                dgvProductosDisponibles.DataSource = vent.Lista;  //Actualizamos el datagridview con la nueva disponibilidad

                btnComprar.Enabled = false;
                btnNuevaCompra.Visible = true;


            }


        }

        private void btnNuevaCompra_Click(object sender, EventArgs e)
        {
            btnComprar.Enabled = true;
            btnNuevaCompra.Visible = false;

            lstFactura.Items.Clear();

            dgvProductosDisponibles.DataSource = vent.Lista;

            txtCompra.Clear();
        }
    }
}
