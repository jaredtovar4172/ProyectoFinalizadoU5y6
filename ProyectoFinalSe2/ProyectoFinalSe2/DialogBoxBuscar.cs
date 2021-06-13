using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinalSe2
{
    public partial class DialogBoxBuscar : Form
    {
        public DialogBoxBuscar()
        {
            InitializeComponent();
        }

        public string nombre
        {
            get { return (textBox1.Text); }
        }
        private void DialogBoxBuscar_Load(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox1.Focus();
        }
    }
}
