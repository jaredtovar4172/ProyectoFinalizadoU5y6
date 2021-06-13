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
    public partial class DialogBoxBaja : Form
    {
        public DialogBoxBaja()
        {
            InitializeComponent();
        }
        public string fecha
        {
            get { return (dateTimePicker1.Text); }
        }
        private void DialogBoxBaja_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Text = "";
        }
    }
}
