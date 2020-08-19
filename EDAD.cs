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
    public partial class EDAD : Form
    {
        public EDAD()
        {
            InitializeComponent();
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            Int32 edad;

            

            if(TxtEdad.Text =="")
            {
                MessageBox.Show("Debe llenar el Campo de Edad", "MENSAJE DE VALIDACION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
            }
           
            else
            {
                edad = Convert.ToInt32(TxtEdad.Text);
                if (edad >0 && edad < 18)
            {
                LblResultado.Text = "Eres Menor de edad";
                    

                }
                else
                {
                    if (edad >= 18)
            {
                LblResultado.Text = "Eres Mayor de edad";
                        

                    }
                    else 
            {
                LblResultado.Text = "Dato Erroneo";
                       

                    }
                }
                LblResultado.Visible = true;
                BtnLimpiar.Visible = true;
                BtnMenu.Visible = true;
                BtnSalir.Visible = true;
            }
           



        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            TxtEdad.Text = null;

            LblResultado.Visible = false;
            TxtEdad.Focus();

        }

        private void BtnMenu_Click(object sender, EventArgs e)
        {
            Form1 Menupp = new Form1();
            Menupp.Show();
            this.Hide();

        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
