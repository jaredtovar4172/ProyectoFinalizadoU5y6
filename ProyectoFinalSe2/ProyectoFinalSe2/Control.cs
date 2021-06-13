using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ProyectoFinalSe2
{
    public partial class Control : Form
    {
        public Control()
        {
            InitializeComponent();
        }
        Secuencial obj = new Secuencial();
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 F = new Form1();
            F.Show();
        }

        private void Control_Load(object sender, EventArgs e)
        {
            
        }

        private void realizarVentaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            obj.Venta();
        }

        private void consultarTodoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            obj.ConsultarTodo(listView1);
        }

        private void consultaPorNombreToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            obj.BuscarNombre(listView1);
        }

        private void bajaDeVentaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            obj.Baja();
        }

        private void modificarVentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            obj.Modificar();
        }

        private void mostrarVentasPorFechaYElTotalToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            obj.VentasPorFecha(listView1);
        }

        private void ventaMasAltaRegistradaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            obj.MostrarVentaAlta(listView1);
        }

        private void ventaMasBajaRegistradaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            obj.MostrarVentaBaja(listView1);
        }
    }
}
