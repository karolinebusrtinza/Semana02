
namespace Lab02_01
{
    partial class EjemploMDI
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MnuMantenimiento = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuManUsuario = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuManProductos = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuManCategorias = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuManProveedores = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuManClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuManProcesos = new System.Windows.Forms.ToolStripMenuItem();
            this.regVentas = new System.Windows.Forms.ToolStripMenuItem();
            this.regCompras = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuManReportes = new System.Windows.Forms.ToolStripMenuItem();
            this.repVentas = new System.Windows.Forms.ToolStripMenuItem();
            this.repCompras = new System.Windows.Forms.ToolStripMenuItem();
            this.repInventario = new System.Windows.Forms.ToolStripMenuItem();
            this.repProveedores = new System.Windows.Forms.ToolStripMenuItem();
            this.repUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.repClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuManSistema = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuMantenimiento,
            this.MnuManProcesos,
            this.MnuManReportes,
            this.MnuManSistema});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(584, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "Mantenimiento";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // MnuMantenimiento
            // 
            this.MnuMantenimiento.DoubleClickEnabled = true;
            this.MnuMantenimiento.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuManUsuario,
            this.MnuManProductos,
            this.MnuManCategorias,
            this.MnuManProveedores,
            this.MnuManClientes});
            this.MnuMantenimiento.Name = "MnuMantenimiento";
            this.MnuMantenimiento.Size = new System.Drawing.Size(101, 20);
            this.MnuMantenimiento.Text = "&Mantenimiento";
            // 
            // MnuManUsuario
            // 
            this.MnuManUsuario.Name = "MnuManUsuario";
            this.MnuManUsuario.Size = new System.Drawing.Size(139, 22);
            this.MnuManUsuario.Text = "Usuarios";
            this.MnuManUsuario.Click += new System.EventHandler(this.MnuManUsuario_Click);
            // 
            // MnuManProductos
            // 
            this.MnuManProductos.Name = "MnuManProductos";
            this.MnuManProductos.Size = new System.Drawing.Size(139, 22);
            this.MnuManProductos.Text = "Productos";
            // 
            // MnuManCategorias
            // 
            this.MnuManCategorias.Name = "MnuManCategorias";
            this.MnuManCategorias.Size = new System.Drawing.Size(139, 22);
            this.MnuManCategorias.Text = "Categorias";
            // 
            // MnuManProveedores
            // 
            this.MnuManProveedores.Name = "MnuManProveedores";
            this.MnuManProveedores.Size = new System.Drawing.Size(139, 22);
            this.MnuManProveedores.Text = "Proveedores";
            // 
            // MnuManClientes
            // 
            this.MnuManClientes.Name = "MnuManClientes";
            this.MnuManClientes.Size = new System.Drawing.Size(139, 22);
            this.MnuManClientes.Text = "Clientes";
            // 
            // MnuManProcesos
            // 
            this.MnuManProcesos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.regVentas,
            this.regCompras});
            this.MnuManProcesos.Name = "MnuManProcesos";
            this.MnuManProcesos.Size = new System.Drawing.Size(66, 20);
            this.MnuManProcesos.Text = "&Procesos";
            // 
            // regVentas
            // 
            this.regVentas.Name = "regVentas";
            this.regVentas.Size = new System.Drawing.Size(152, 22);
            this.regVentas.Text = "Registrar Venta";
            // 
            // regCompras
            // 
            this.regCompras.Name = "regCompras";
            this.regCompras.Size = new System.Drawing.Size(152, 22);
            this.regCompras.Text = "Compras";
            // 
            // MnuManReportes
            // 
            this.MnuManReportes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.repVentas,
            this.repCompras,
            this.repInventario,
            this.repProveedores,
            this.repUsuarios,
            this.repClientes});
            this.MnuManReportes.Name = "MnuManReportes";
            this.MnuManReportes.Size = new System.Drawing.Size(65, 20);
            this.MnuManReportes.Text = "&Reportes";
            // 
            // repVentas
            // 
            this.repVentas.Name = "repVentas";
            this.repVentas.Size = new System.Drawing.Size(206, 22);
            this.repVentas.Text = "Reporte de ventas";
            // 
            // repCompras
            // 
            this.repCompras.Name = "repCompras";
            this.repCompras.Size = new System.Drawing.Size(206, 22);
            this.repCompras.Text = "Reporte de compras";
            // 
            // repInventario
            // 
            this.repInventario.Name = "repInventario";
            this.repInventario.Size = new System.Drawing.Size(206, 22);
            this.repInventario.Text = ", Inventario de productos";
            // 
            // repProveedores
            // 
            this.repProveedores.Name = "repProveedores";
            this.repProveedores.Size = new System.Drawing.Size(206, 22);
            this.repProveedores.Text = "Reporte de proveedores";
            // 
            // repUsuarios
            // 
            this.repUsuarios.Name = "repUsuarios";
            this.repUsuarios.Size = new System.Drawing.Size(206, 22);
            this.repUsuarios.Text = "Reporte de usuarios";
            // 
            // repClientes
            // 
            this.repClientes.Enabled = false;
            this.repClientes.Name = "repClientes";
            this.repClientes.Size = new System.Drawing.Size(206, 22);
            this.repClientes.Text = "Reporte de clientes";
            // 
            // MnuManSistema
            // 
            this.MnuManSistema.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuSalir});
            this.MnuManSistema.Name = "MnuManSistema";
            this.MnuManSistema.Size = new System.Drawing.Size(60, 20);
            this.MnuManSistema.Text = "&Sistema";
            // 
            // MnuSalir
            // 
            this.MnuSalir.Name = "MnuSalir";
            this.MnuSalir.Size = new System.Drawing.Size(96, 22);
            this.MnuSalir.Text = "Salir";
            // 
            // EjemploMDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "EjemploMDI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Panel Principal";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MnuMantenimiento;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MnuManUsuario;
        private System.Windows.Forms.ToolStripMenuItem MnuManProductos;
        private System.Windows.Forms.ToolStripMenuItem MnuManCategorias;
        private System.Windows.Forms.ToolStripMenuItem MnuManProveedores;
        private System.Windows.Forms.ToolStripMenuItem MnuManClientes;
        private System.Windows.Forms.ToolStripMenuItem MnuManProcesos;
        private System.Windows.Forms.ToolStripMenuItem MnuManReportes;
        private System.Windows.Forms.ToolStripMenuItem MnuManSistema;
        private System.Windows.Forms.ToolStripMenuItem regVentas;
        private System.Windows.Forms.ToolStripMenuItem regCompras;
        private System.Windows.Forms.ToolStripMenuItem repVentas;
        private System.Windows.Forms.ToolStripMenuItem repCompras;
        private System.Windows.Forms.ToolStripMenuItem repInventario;
        private System.Windows.Forms.ToolStripMenuItem repProveedores;
        private System.Windows.Forms.ToolStripMenuItem repUsuarios;
        private System.Windows.Forms.ToolStripMenuItem repClientes;
        private System.Windows.Forms.ToolStripMenuItem MnuSalir;
    }
}