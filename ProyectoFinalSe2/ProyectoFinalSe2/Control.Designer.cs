namespace ProyectoFinalSe2
{
    partial class Control
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
            this.productoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.realizarVentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarVentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarTodoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaPorNombreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bajaDeVentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarVentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarVentasPorFechaYElTotalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.operacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventaMasAltaRegistradaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventaMasBajaRegistradaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productoToolStripMenuItem,
            this.operacionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1064, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // productoToolStripMenuItem
            // 
            this.productoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.realizarVentaToolStripMenuItem,
            this.consultarVentaToolStripMenuItem,
            this.bajaDeVentaToolStripMenuItem,
            this.modificarVentaToolStripMenuItem,
            this.mostrarVentasPorFechaYElTotalToolStripMenuItem});
            this.productoToolStripMenuItem.Name = "productoToolStripMenuItem";
            this.productoToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.productoToolStripMenuItem.Text = "Producto";
            // 
            // realizarVentaToolStripMenuItem
            // 
            this.realizarVentaToolStripMenuItem.Name = "realizarVentaToolStripMenuItem";
            this.realizarVentaToolStripMenuItem.Size = new System.Drawing.Size(318, 26);
            this.realizarVentaToolStripMenuItem.Text = "Realizar venta";
            this.realizarVentaToolStripMenuItem.Click += new System.EventHandler(this.realizarVentaToolStripMenuItem_Click_1);
            // 
            // consultarVentaToolStripMenuItem
            // 
            this.consultarVentaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultarTodoToolStripMenuItem,
            this.consultaPorNombreToolStripMenuItem});
            this.consultarVentaToolStripMenuItem.Name = "consultarVentaToolStripMenuItem";
            this.consultarVentaToolStripMenuItem.Size = new System.Drawing.Size(318, 26);
            this.consultarVentaToolStripMenuItem.Text = "Consultar venta";
            // 
            // consultarTodoToolStripMenuItem
            // 
            this.consultarTodoToolStripMenuItem.Name = "consultarTodoToolStripMenuItem";
            this.consultarTodoToolStripMenuItem.Size = new System.Drawing.Size(232, 26);
            this.consultarTodoToolStripMenuItem.Text = "Consultar todo";
            this.consultarTodoToolStripMenuItem.Click += new System.EventHandler(this.consultarTodoToolStripMenuItem_Click_1);
            // 
            // consultaPorNombreToolStripMenuItem
            // 
            this.consultaPorNombreToolStripMenuItem.Name = "consultaPorNombreToolStripMenuItem";
            this.consultaPorNombreToolStripMenuItem.Size = new System.Drawing.Size(232, 26);
            this.consultaPorNombreToolStripMenuItem.Text = "Consulta por nombre";
            this.consultaPorNombreToolStripMenuItem.Click += new System.EventHandler(this.consultaPorNombreToolStripMenuItem_Click_1);
            // 
            // bajaDeVentaToolStripMenuItem
            // 
            this.bajaDeVentaToolStripMenuItem.Name = "bajaDeVentaToolStripMenuItem";
            this.bajaDeVentaToolStripMenuItem.Size = new System.Drawing.Size(318, 26);
            this.bajaDeVentaToolStripMenuItem.Text = "Baja de venta";
            this.bajaDeVentaToolStripMenuItem.Click += new System.EventHandler(this.bajaDeVentaToolStripMenuItem_Click_1);
            // 
            // modificarVentaToolStripMenuItem
            // 
            this.modificarVentaToolStripMenuItem.Name = "modificarVentaToolStripMenuItem";
            this.modificarVentaToolStripMenuItem.Size = new System.Drawing.Size(318, 26);
            this.modificarVentaToolStripMenuItem.Text = "Modificar venta";
            this.modificarVentaToolStripMenuItem.Click += new System.EventHandler(this.modificarVentaToolStripMenuItem_Click);
            // 
            // mostrarVentasPorFechaYElTotalToolStripMenuItem
            // 
            this.mostrarVentasPorFechaYElTotalToolStripMenuItem.Name = "mostrarVentasPorFechaYElTotalToolStripMenuItem";
            this.mostrarVentasPorFechaYElTotalToolStripMenuItem.Size = new System.Drawing.Size(318, 26);
            this.mostrarVentasPorFechaYElTotalToolStripMenuItem.Text = "Mostrar ventas por fecha y el total";
            this.mostrarVentasPorFechaYElTotalToolStripMenuItem.Click += new System.EventHandler(this.mostrarVentasPorFechaYElTotalToolStripMenuItem_Click_1);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(79, 47);
            this.listView1.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(885, 373);
            this.listView1.TabIndex = 5;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Fecha de venta";
            this.columnHeader1.Width = 133;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Nombre del producto";
            this.columnHeader2.Width = 153;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Cantidad";
            this.columnHeader3.Width = 102;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Precio";
            this.columnHeader4.Width = 85;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Precio Total";
            this.columnHeader5.Width = 77;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(699, 426);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(266, 68);
            this.button1.TabIndex = 6;
            this.button1.Text = "Volver";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(415, 426);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(266, 68);
            this.button2.TabIndex = 7;
            this.button2.Text = "Cerrar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // operacionToolStripMenuItem
            // 
            this.operacionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ventaMasAltaRegistradaToolStripMenuItem,
            this.ventaMasBajaRegistradaToolStripMenuItem});
            this.operacionToolStripMenuItem.Name = "operacionToolStripMenuItem";
            this.operacionToolStripMenuItem.Size = new System.Drawing.Size(92, 24);
            this.operacionToolStripMenuItem.Text = "Operacion";
            // 
            // ventaMasAltaRegistradaToolStripMenuItem
            // 
            this.ventaMasAltaRegistradaToolStripMenuItem.Name = "ventaMasAltaRegistradaToolStripMenuItem";
            this.ventaMasAltaRegistradaToolStripMenuItem.Size = new System.Drawing.Size(260, 26);
            this.ventaMasAltaRegistradaToolStripMenuItem.Text = "Venta mas alta registrada";
            this.ventaMasAltaRegistradaToolStripMenuItem.Click += new System.EventHandler(this.ventaMasAltaRegistradaToolStripMenuItem_Click);
            // 
            // ventaMasBajaRegistradaToolStripMenuItem
            // 
            this.ventaMasBajaRegistradaToolStripMenuItem.Name = "ventaMasBajaRegistradaToolStripMenuItem";
            this.ventaMasBajaRegistradaToolStripMenuItem.Size = new System.Drawing.Size(264, 26);
            this.ventaMasBajaRegistradaToolStripMenuItem.Text = "Venta mas baja registrada";
            this.ventaMasBajaRegistradaToolStripMenuItem.Click += new System.EventHandler(this.ventaMasBajaRegistradaToolStripMenuItem_Click);
            // 
            // Control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1064, 505);
            this.ControlBox = false;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Control";
            this.Text = "Control";
            this.Load += new System.EventHandler(this.Control_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem productoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem realizarVentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarVentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarTodoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaPorNombreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bajaDeVentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarVentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mostrarVentasPorFechaYElTotalToolStripMenuItem;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ToolStripMenuItem operacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventaMasAltaRegistradaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventaMasBajaRegistradaToolStripMenuItem;
    }
}