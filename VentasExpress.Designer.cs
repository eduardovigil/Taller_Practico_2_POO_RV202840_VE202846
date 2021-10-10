
namespace ventasExpress
{
    partial class VentasExpress
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
            this.button1 = new System.Windows.Forms.Button();
            this.panelInventario = new System.Windows.Forms.Panel();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dgvInventario = new System.Windows.Forms.DataGridView();
            this.btnConsultarInventario = new System.Windows.Forms.Button();
            this.btnNuevaVenta = new System.Windows.Forms.Button();
            this.btnCambiarContraseña = new System.Windows.Forms.Button();
            this.panelContraseña = new System.Windows.Forms.Panel();
            this.btnConfirmarContra = new System.Windows.Forms.Button();
            this.txtConfirmarContra = new System.Windows.Forms.TextBox();
            this.txtNuevaContra = new System.Windows.Forms.TextBox();
            this.txtContraseñaActual = new System.Windows.Forms.TextBox();
            this.panelVentaNueva = new System.Windows.Forms.Panel();
            this.btnNuevaCompra = new System.Windows.Forms.Button();
            this.btnComprar = new System.Windows.Forms.Button();
            this.lstFactura = new System.Windows.Forms.ListBox();
            this.txtCompra = new System.Windows.Forms.TextBox();
            this.dgvProductosDisponibles = new System.Windows.Forms.DataGridView();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panelInventario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventario)).BeginInit();
            this.panelContraseña.SuspendLayout();
            this.panelVentaNueva.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductosDisponibles)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(172)))), ((int)(((byte)(0)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(599, 76);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 53);
            this.button1.TabIndex = 0;
            this.button1.Text = "Salir del sistema";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panelInventario
            // 
            this.panelInventario.Controls.Add(this.label9);
            this.panelInventario.Controls.Add(this.label8);
            this.panelInventario.Controls.Add(this.txtBusqueda);
            this.panelInventario.Controls.Add(this.btnBuscar);
            this.panelInventario.Controls.Add(this.dgvInventario);
            this.panelInventario.Location = new System.Drawing.Point(36, 164);
            this.panelInventario.Name = "panelInventario";
            this.panelInventario.Size = new System.Drawing.Size(673, 316);
            this.panelInventario.TabIndex = 1;
            this.panelInventario.Visible = false;
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtBusqueda.Location = new System.Drawing.Point(196, 74);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(168, 23);
            this.txtBusqueda.TabIndex = 2;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(172)))), ((int)(((byte)(0)))));
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(392, 64);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(91, 33);
            this.btnBuscar.TabIndex = 1;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // dgvInventario
            // 
            this.dgvInventario.AllowUserToAddRows = false;
            this.dgvInventario.AllowUserToDeleteRows = false;
            this.dgvInventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInventario.Location = new System.Drawing.Point(91, 125);
            this.dgvInventario.Name = "dgvInventario";
            this.dgvInventario.ReadOnly = true;
            this.dgvInventario.Size = new System.Drawing.Size(496, 150);
            this.dgvInventario.TabIndex = 0;
            // 
            // btnConsultarInventario
            // 
            this.btnConsultarInventario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(172)))), ((int)(((byte)(0)))));
            this.btnConsultarInventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultarInventario.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.btnConsultarInventario.ForeColor = System.Drawing.Color.White;
            this.btnConsultarInventario.Location = new System.Drawing.Point(231, 76);
            this.btnConsultarInventario.Name = "btnConsultarInventario";
            this.btnConsultarInventario.Size = new System.Drawing.Size(123, 53);
            this.btnConsultarInventario.TabIndex = 3;
            this.btnConsultarInventario.Text = "Consultar inventarios";
            this.btnConsultarInventario.UseVisualStyleBackColor = false;
            this.btnConsultarInventario.Click += new System.EventHandler(this.btnConsultarInventario_Click);
            // 
            // btnNuevaVenta
            // 
            this.btnNuevaVenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(172)))), ((int)(((byte)(0)))));
            this.btnNuevaVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevaVenta.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.btnNuevaVenta.ForeColor = System.Drawing.Color.White;
            this.btnNuevaVenta.Location = new System.Drawing.Point(49, 76);
            this.btnNuevaVenta.Name = "btnNuevaVenta";
            this.btnNuevaVenta.Size = new System.Drawing.Size(123, 53);
            this.btnNuevaVenta.TabIndex = 4;
            this.btnNuevaVenta.Text = "Venta nueva ";
            this.btnNuevaVenta.UseVisualStyleBackColor = false;
            this.btnNuevaVenta.Click += new System.EventHandler(this.btnNuevaVenta_Click);
            // 
            // btnCambiarContraseña
            // 
            this.btnCambiarContraseña.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(172)))), ((int)(((byte)(0)))));
            this.btnCambiarContraseña.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCambiarContraseña.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.btnCambiarContraseña.ForeColor = System.Drawing.Color.White;
            this.btnCambiarContraseña.Location = new System.Drawing.Point(419, 76);
            this.btnCambiarContraseña.Name = "btnCambiarContraseña";
            this.btnCambiarContraseña.Size = new System.Drawing.Size(123, 53);
            this.btnCambiarContraseña.TabIndex = 5;
            this.btnCambiarContraseña.Text = "Cambiar contraseña";
            this.btnCambiarContraseña.UseVisualStyleBackColor = false;
            this.btnCambiarContraseña.Click += new System.EventHandler(this.btnCambiarContraseña_Click);
            // 
            // panelContraseña
            // 
            this.panelContraseña.Controls.Add(this.label7);
            this.panelContraseña.Controls.Add(this.label6);
            this.panelContraseña.Controls.Add(this.label5);
            this.panelContraseña.Controls.Add(this.label4);
            this.panelContraseña.Controls.Add(this.btnConfirmarContra);
            this.panelContraseña.Controls.Add(this.txtConfirmarContra);
            this.panelContraseña.Controls.Add(this.txtNuevaContra);
            this.panelContraseña.Controls.Add(this.txtContraseñaActual);
            this.panelContraseña.Location = new System.Drawing.Point(49, 161);
            this.panelContraseña.Name = "panelContraseña";
            this.panelContraseña.Size = new System.Drawing.Size(673, 378);
            this.panelContraseña.TabIndex = 3;
            this.panelContraseña.Visible = false;
            // 
            // btnConfirmarContra
            // 
            this.btnConfirmarContra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(172)))), ((int)(((byte)(0)))));
            this.btnConfirmarContra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmarContra.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.btnConfirmarContra.ForeColor = System.Drawing.Color.White;
            this.btnConfirmarContra.Location = new System.Drawing.Point(215, 311);
            this.btnConfirmarContra.Name = "btnConfirmarContra";
            this.btnConfirmarContra.Size = new System.Drawing.Size(188, 41);
            this.btnConfirmarContra.TabIndex = 3;
            this.btnConfirmarContra.Text = "Confirmar contraseña";
            this.btnConfirmarContra.UseVisualStyleBackColor = false;
            this.btnConfirmarContra.Click += new System.EventHandler(this.btnConfirmarContra_Click);
            // 
            // txtConfirmarContra
            // 
            this.txtConfirmarContra.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtConfirmarContra.Location = new System.Drawing.Point(215, 235);
            this.txtConfirmarContra.Name = "txtConfirmarContra";
            this.txtConfirmarContra.Size = new System.Drawing.Size(162, 23);
            this.txtConfirmarContra.TabIndex = 2;
            // 
            // txtNuevaContra
            // 
            this.txtNuevaContra.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtNuevaContra.Location = new System.Drawing.Point(215, 166);
            this.txtNuevaContra.Name = "txtNuevaContra";
            this.txtNuevaContra.Size = new System.Drawing.Size(162, 23);
            this.txtNuevaContra.TabIndex = 1;
            // 
            // txtContraseñaActual
            // 
            this.txtContraseñaActual.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtContraseñaActual.Location = new System.Drawing.Point(215, 97);
            this.txtContraseñaActual.Name = "txtContraseñaActual";
            this.txtContraseñaActual.Size = new System.Drawing.Size(162, 23);
            this.txtContraseñaActual.TabIndex = 0;
            // 
            // panelVentaNueva
            // 
            this.panelVentaNueva.Controls.Add(this.label3);
            this.panelVentaNueva.Controls.Add(this.label2);
            this.panelVentaNueva.Controls.Add(this.label1);
            this.panelVentaNueva.Controls.Add(this.btnNuevaCompra);
            this.panelVentaNueva.Controls.Add(this.btnComprar);
            this.panelVentaNueva.Controls.Add(this.lstFactura);
            this.panelVentaNueva.Controls.Add(this.txtCompra);
            this.panelVentaNueva.Controls.Add(this.dgvProductosDisponibles);
            this.panelVentaNueva.Location = new System.Drawing.Point(17, 177);
            this.panelVentaNueva.Name = "panelVentaNueva";
            this.panelVentaNueva.Size = new System.Drawing.Size(776, 430);
            this.panelVentaNueva.TabIndex = 6;
            this.panelVentaNueva.Visible = false;
            // 
            // btnNuevaCompra
            // 
            this.btnNuevaCompra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(172)))), ((int)(((byte)(0)))));
            this.btnNuevaCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevaCompra.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.btnNuevaCompra.ForeColor = System.Drawing.Color.White;
            this.btnNuevaCompra.Location = new System.Drawing.Point(536, 362);
            this.btnNuevaCompra.Name = "btnNuevaCompra";
            this.btnNuevaCompra.Size = new System.Drawing.Size(161, 41);
            this.btnNuevaCompra.TabIndex = 4;
            this.btnNuevaCompra.Text = "Nueva compra";
            this.btnNuevaCompra.UseVisualStyleBackColor = false;
            this.btnNuevaCompra.Visible = false;
            this.btnNuevaCompra.Click += new System.EventHandler(this.btnNuevaCompra_Click);
            // 
            // btnComprar
            // 
            this.btnComprar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(172)))), ((int)(((byte)(0)))));
            this.btnComprar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComprar.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.btnComprar.ForeColor = System.Drawing.Color.White;
            this.btnComprar.Location = new System.Drawing.Point(662, 106);
            this.btnComprar.Name = "btnComprar";
            this.btnComprar.Size = new System.Drawing.Size(101, 35);
            this.btnComprar.TabIndex = 3;
            this.btnComprar.Text = "Comprar";
            this.btnComprar.UseVisualStyleBackColor = false;
            this.btnComprar.Click += new System.EventHandler(this.btnComprar_Click);
            // 
            // lstFactura
            // 
            this.lstFactura.FormattingEnabled = true;
            this.lstFactura.Location = new System.Drawing.Point(464, 167);
            this.lstFactura.Name = "lstFactura";
            this.lstFactura.Size = new System.Drawing.Size(294, 173);
            this.lstFactura.TabIndex = 2;
            // 
            // txtCompra
            // 
            this.txtCompra.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtCompra.Location = new System.Drawing.Point(464, 113);
            this.txtCompra.Name = "txtCompra";
            this.txtCompra.Size = new System.Drawing.Size(187, 23);
            this.txtCompra.TabIndex = 1;
            // 
            // dgvProductosDisponibles
            // 
            this.dgvProductosDisponibles.AllowUserToAddRows = false;
            this.dgvProductosDisponibles.AllowUserToDeleteRows = false;
            this.dgvProductosDisponibles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductosDisponibles.Location = new System.Drawing.Point(3, 101);
            this.dgvProductosDisponibles.Name = "dgvProductosDisponibles";
            this.dgvProductosDisponibles.ReadOnly = true;
            this.dgvProductosDisponibles.Size = new System.Drawing.Size(438, 291);
            this.dgvProductosDisponibles.TabIndex = 0;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(423, 18);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(131, 25);
            this.lblUsuario.TabIndex = 7;
            this.lblUsuario.Text = "Bienvenido:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "VENTA NUEVA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(432, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(341, 23);
            this.label2.TabIndex = 9;
            this.label2.Text = "Ingresa los productos y la cantidad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(470, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "Ejemplo: 1,2,5,6,7,2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(256, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "CAMBIAR CONTRASEÑA";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10.25F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(228, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Contraseña actual:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10.25F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(228, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Nueva contraseña:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 10.25F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(228, 215);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(158, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "Confirmar contraseña:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 10.25F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(214, 54);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(148, 17);
            this.label8.TabIndex = 13;
            this.label8.Text = "Ingresa tu busqueda:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(13, 11);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(137, 25);
            this.label9.TabIndex = 14;
            this.label9.Text = "INVENTARIO";
            // 
            // VentasExpress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(805, 627);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.panelVentaNueva);
            this.Controls.Add(this.panelContraseña);
            this.Controls.Add(this.btnCambiarContraseña);
            this.Controls.Add(this.btnNuevaVenta);
            this.Controls.Add(this.btnConsultarInventario);
            this.Controls.Add(this.panelInventario);
            this.Controls.Add(this.button1);
            this.Name = "VentasExpress";
            this.Text = "VentasExpress";
            this.Load += new System.EventHandler(this.VentasExpress_Load);
            this.panelInventario.ResumeLayout(false);
            this.panelInventario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventario)).EndInit();
            this.panelContraseña.ResumeLayout(false);
            this.panelContraseña.PerformLayout();
            this.panelVentaNueva.ResumeLayout(false);
            this.panelVentaNueva.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductosDisponibles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panelInventario;
        private System.Windows.Forms.DataGridView dgvInventario;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.Button btnConsultarInventario;
        private System.Windows.Forms.Button btnNuevaVenta;
        private System.Windows.Forms.Button btnCambiarContraseña;
        private System.Windows.Forms.Panel panelContraseña;
        private System.Windows.Forms.Button btnConfirmarContra;
        private System.Windows.Forms.TextBox txtConfirmarContra;
        private System.Windows.Forms.TextBox txtNuevaContra;
        private System.Windows.Forms.TextBox txtContraseñaActual;
        private System.Windows.Forms.Panel panelVentaNueva;
        private System.Windows.Forms.DataGridView dgvProductosDisponibles;
        private System.Windows.Forms.TextBox txtCompra;
        private System.Windows.Forms.Button btnNuevaCompra;
        private System.Windows.Forms.Button btnComprar;
        private System.Windows.Forms.ListBox lstFactura;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
    }
}