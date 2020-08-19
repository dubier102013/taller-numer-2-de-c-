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
    public partial class VENTAS : Form
    {
        public VENTAS()
        {
            InitializeComponent();
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            double Valorcompra, valortotal=0;

            if(CbTemporada.SelectedItem =="" || TxtValor.Text=="" )

            {
                MessageBox.Show("Debe llenar todos los campos", "MENSAJE DE VALIDACION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                LblResultado.Visible = false;
                BtnLimpiar.Visible = false;
                BtnMenu.Visible = false;
                BtnSalir.Visible = false;
            }
            else
            {
                Valorcompra = Convert.ToDouble(TxtValor.Text);

                switch(CbTemporada.SelectedItem)
                {
                    case "ESCOLAR":
                       if(Valorcompra>0 && Valorcompra <=100000)
                        {
                            valortotal = Valorcompra - (Valorcompra * 0) ;
                        }
                       else
                        {
                            if(Valorcompra > 100001 && Valorcompra <= 300000)
                            {
                                valortotal = Valorcompra - (Valorcompra * 0.1) ;
                            }
                            else
                            {

                                if (Valorcompra > 300000)
                                {
                                    valortotal = Valorcompra - (Valorcompra * 0.15) ;
                                }
                                else
                                {
                                    LblResultado.Text = "Dato Erroneo";
                                }

                            }

                        }
                        


                        break;

                    case "HALLOWEEN":
                        if (Valorcompra >= 50 && Valorcompra <= 30000)
                        {
                            valortotal = Valorcompra - (Valorcompra * 0) ;
                        }
                        else
                        {
                            if (Valorcompra > 30001 && Valorcompra <= 200000)
                            {
                                valortotal = Valorcompra - (Valorcompra * 0.02);
                            }
                            else
                            {

                                if (Valorcompra > 200000)
                                {
                                    valortotal = Valorcompra - (Valorcompra * 0.05) ;
                                }
                                else
                                {
                                    if (Valorcompra > 0 && Valorcompra < 50)
                                    {
                                        valortotal = Valorcompra -  (Valorcompra * 0) ;
                                    }
                                    else
                                    {
                                        LblResultado.Text = "Dato Erroneo";
                                    }
                                   
                                }

                            }

                        }
                        break;

                    case "DICIEMBRE":
                        if (Valorcompra >= 50 && Valorcompra <= 300000)
                        {
                            valortotal = Valorcompra - (Valorcompra * 0);
                        }
                        else
                        {
                            if (Valorcompra > 300001 && Valorcompra <= 500000)
                            {
                                valortotal = Valorcompra - (Valorcompra * 0.05) ;
                            }
                            else
                            {

                                if (Valorcompra > 500000)
                                {
                                    valortotal = Valorcompra-(Valorcompra * 0.1) ;
                                }
                                else
                                {
                                    if (Valorcompra > 0 && Valorcompra < 50)
                                    {
                                        valortotal = Valorcompra-(Valorcompra * 0) ;
                                    }
                                    else
                                    {
                                        LblResultado.Text = "Dato Erroneo";
                                    }

                                }

                            }

                        }
                        break;
                    default:
                        LblResultado.Text = "Dato Erroneo";
                        break;


                }
                LblResultado.Visible = true;
                BtnLimpiar.Visible = true;
                BtnMenu.Visible = true;
                BtnSalir.Visible = true;
                LblResultado.Text = Convert.ToString(valortotal);

            }


        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            CbTemporada.SelectedItem = "";
            TxtValor.Text = "";
            LblResultado.Visible = false;
            CbTemporada.Focus();

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
