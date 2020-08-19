using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace taller2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void PbEdad_Click(object sender, EventArgs e)
        {
            EDAD MenuEDAD = new  EDAD();
            MenuEDAD.Show();
            this.Hide();

        }

        private void PbNotas_Click(object sender, EventArgs e)
        {
            NOTAS MenuNOTAS = new NOTAS ();
            MenuNOTAS.Show();
            this.Hide();

        }

        private void PbVentas_Click(object sender, EventArgs e)
        {
           VENTAS MenuVENTAS = new VENTAS();
            MenuVENTAS.Show();
            this.Hide();

        }

        private void PbSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
    }
}
