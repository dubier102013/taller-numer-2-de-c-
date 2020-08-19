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
    public partial class NOTAS : Form
    {
        public NOTAS()
        {
            InitializeComponent();
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            double Nota1, Nota2, Nota3, Nota4, Nota5, Promedio;

            if (TxtNota1.Text==""|| TxtNota2.Text == "" || TxtNota3.Text == "" || TxtNota4.Text == "" || TxtNota5.Text == "" )
                {
                MessageBox.Show("Debe llenar todos los campos", "MENSAJE DE VALIDACION", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                Nota1 = Convert.ToDouble(TxtNota1.Text);
                Nota2= Convert.ToDouble(TxtNota2.Text);
                Nota3 = Convert.ToDouble(TxtNota3.Text);
                Nota4 = Convert.ToDouble(TxtNota4.Text);
                Nota5 = Convert.ToDouble(TxtNota5.Text);

                Promedio=(Nota1+Nota2+Nota3+Nota4+Nota5)/5;


                if (Promedio>=0 && Promedio <=1 )
                    {
                    LblResultado.Text = "Reprueba la materia sin lograr realizar proceso de recuperación";
                }
                else
                {
                    if (Promedio >= 1.1 && Promedio <= 2.9)
                    {
                        LblResultado.Text = "Reprueba la materia y puede hacer la habilitación";
                    }
                    else
                    {
                        if (Promedio >= 3 && Promedio <= 3.9)
                        {
                            LblResultado.Text = "Aprueba la materia con plan de mejora";
                        }
                        else
                        {
                            if (Promedio >= 4 && Promedio <= 4.5)
                            {
                                LblResultado.Text = "Buen rendimiento";
                            }
                            else
                            {
                                if(Promedio >= 4.6 && Promedio <= 4.9)
                                {
                                    LblResultado.Text = "Excelente";
                                }
                                else
                                {
                                  if (Promedio == 5)
                                    {
                                        LblResultado.Text = "Graduado con honores";
                                    }
                                  else
                                    {
                                        LblResultado.Text = "Error";
                                    }

                                }

                            }
                        }


                    }
                    
                }

            }
           
            LblResultado.Visible = true;
            BtnLimpiar.Visible = true;
            BtnMenu.Visible = true;
            BtnSalir.Visible = true;
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            TxtNota1.Text = null;
            TxtNota2.Text = null;
            TxtNota3.Text = null;
            TxtNota4.Text = null;
            TxtNota5.Text = null;
            LblResultado.Visible = false;
            TxtNota1.Focus();
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
