using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Calculadora : Form
    {
        double Resultat = 0;
        double element1 = 0;
        String element1String;
        double element2 = 0;
        String element2String;
        String TipusOperacio;
        Boolean puntDecimal = false;

        public Calculadora()
        {
            InitializeComponent();
        }

        //
        //Events Clics
        //Propietats click dels botons numèrics i operacionals
        // Assignar valor i mostrar per pantalla
        //

        private void btn9_MouseUp(object sender, MouseEventArgs e)
        {
            String valor = "9";

            if (lblPantalla.Text == "0")
            {
                lblPantalla.Text = valor;
            }
            else
            {
                if (lblPantalla.Text.Length<17) {
                    lblPantalla.Text = lblPantalla.Text + valor;
                } 
            }
            KeyPreview = true;
        }

        private void btn8_MouseUp(object sender, MouseEventArgs e)
        {
            String valor = "8";

            if (lblPantalla.Text == "0")
            {
                lblPantalla.Text = valor;
            }
            else
            {
                if (lblPantalla.Text.Length < 17)
                {
                    lblPantalla.Text = lblPantalla.Text + valor;
                }
            }
            KeyPreview = true;
        }

        private void btn7_MouseUp(object sender, MouseEventArgs e)
        {
            String valor = "7";

            if (lblPantalla.Text == "0")
            {
                lblPantalla.Text = valor;
            }
            else
            {
                if (lblPantalla.Text.Length < 17)
                {
                    lblPantalla.Text = lblPantalla.Text + valor;
                }
            }
            KeyPreview = true;
        }

        private void btn6_MouseUp(object sender, MouseEventArgs e)
        {
            String valor = "6";

            if (lblPantalla.Text == "0")
            {
                lblPantalla.Text = valor;
            }
            else
            {
                if (lblPantalla.Text.Length < 17)
                {
                    lblPantalla.Text = lblPantalla.Text + valor;
                }
            }
            KeyPreview = true;
        }

        private void btn5_MouseUp(object sender, MouseEventArgs e)
        {
            String valor = "5";

            if (lblPantalla.Text == "0")
            {
                lblPantalla.Text = valor;
            }
            else
            {
                if (lblPantalla.Text.Length < 17)
                {
                    lblPantalla.Text = lblPantalla.Text + valor;
                }
            }
            KeyPreview = true;
        }

        private void btn4_MouseUp(object sender, MouseEventArgs e)
        {
            String valor = "4";

            if (lblPantalla.Text == "0")
            {
                lblPantalla.Text = valor;
            }
            else
            {
                if (lblPantalla.Text.Length < 17)
                {
                    lblPantalla.Text = lblPantalla.Text + valor;
                }
            }
            KeyPreview = true;
        }

        private void btn3_MouseUp(object sender, MouseEventArgs e)
        {
            String valor = "3";

            if (lblPantalla.Text == "0")
            {
                lblPantalla.Text = valor;
            }
            else
            {
                if (lblPantalla.Text.Length < 17)
                {
                    lblPantalla.Text = lblPantalla.Text + valor;
                }
            }
            KeyPreview = true;
        }

        private void btn2_MouseUp(object sender, MouseEventArgs e)
        {
            String valor = "2";

            if (lblPantalla.Text == "0")
            {
                lblPantalla.Text = valor;
            }
            else
            {
                if (lblPantalla.Text.Length < 17)
                {
                    lblPantalla.Text = lblPantalla.Text + valor;
                }
            }
            KeyPreview = true;
        }

        private void btn1_MouseUp(object sender, MouseEventArgs e)
        {
            String valor = "1";

            if (lblPantalla.Text == "0")
            {
                lblPantalla.Text = valor;
            }
            else
            {
                if (lblPantalla.Text.Length < 17)
                {
                    lblPantalla.Text = lblPantalla.Text + valor;
                }
            }
            KeyPreview = true;
        }

        private void btn0_MouseUp(object sender, MouseEventArgs e)
        {
            String valor = "0";

            if (lblPantalla.Text == "0")
            {
                lblPantalla.Text = valor;
            }
            else
            {
                if (lblPantalla.Text.Length<17) {
                    lblPantalla.Text = lblPantalla.Text + valor;
                }
            }
            KeyPreview = true;
        }


        private void btnIgual_MouseUp(object sender, EventArgs e)
        {
            element2String = lblPantalla.Text;
            element2 = Double.Parse(element2String);

            Operacions(element1, element2, TipusOperacio);

            puntDecimal = false;
            KeyPreview = true;
        }



        private void btnSuma_MouseUp(object sender, EventArgs e)
        {
            TipusOperacio = "suma";
            if (Resultat != 0)
            {
                element1 = Resultat;
                lblPantalla.Text = "0";
            }
            else
            {
                element1String = lblPantalla.Text;
                element1 = element1 + Double.Parse(element1String);
                lblPantalla.Text = "0";

            }

            puntDecimal = false;
            KeyPreview = true;
        }



        private void btnResta_MouseUp(object sender, EventArgs e)
        {
            TipusOperacio = "resta";
            if (Resultat != 0)
            {
                element1 = Resultat;
                lblPantalla.Text = "0";
            }
            else
            {
                element1String = lblPantalla.Text;
                element1 = element1 + Double.Parse(element1String);
                lblPantalla.Text = "0";
            }

            puntDecimal = false;
            KeyPreview = true;
        }


        private void btnMultiplicar_MouseUp(object sender, EventArgs e)
        {
            TipusOperacio = "multiplicar";
            if (Resultat != 0)
            {
                element1 = Resultat;
                lblPantalla.Text = "0";
            }
            else
            {
                element1String = lblPantalla.Text;
                element1 = element1 + Double.Parse(element1String);
                lblPantalla.Text = "0";
            }

            puntDecimal = false;
            KeyPreview = true;
        }


        private void btnDividir_MouseUp(object sender, EventArgs e)
        {
            TipusOperacio = "dividir";
            if (Resultat != 0)
            {
                element1 = Resultat;
                lblPantalla.Text = "0";
            }
            else
            {
                element1String = lblPantalla.Text;
                element1 = element1 + Double.Parse(element1String);
                lblPantalla.Text = "0";
            }

            puntDecimal = false;
            KeyPreview = true;
        }


        private void btnBorrar_MouseUp(object sender, EventArgs e)
        {
            KeyPreview = true;

            lblPantalla.Text = "0";
            element1 = 0;
            element2 = 0;
            Resultat = 0;
            puntDecimal = false;
        }


        private void btnEnrere_MouseUp(object sender, EventArgs e)
        {
            if (lblPantalla.Text.Length == 1)
            {
                lblPantalla.Text = "0";
            }
            else
            {
                lblPantalla.Text = lblPantalla.Text.Substring(0, lblPantalla.Text.Length - 1);
            }

            puntDecimal = false;
            KeyPreview = true;
        }



        private void btnPunto_MouseUp(object sender, EventArgs e)
        {
            
            if (puntDecimal == false)
            {
                lblPantalla.Text = lblPantalla.Text + ",";
            }

            puntDecimal = true;
            KeyPreview = true;
            
        }
        //
        //Final events buttons
        //



        //
        //Funcio per a cridar les operacions
        //

        public void Operacions(double num1, double num2, string tipus)
        {
            switch (tipus)
            {
                case "suma":
                    Resultat = element1 + element2;
                    lblPantalla.Text = Resultat.ToString();
                    break;
                case "resta":
                    Resultat = element1 - element2;
                    lblPantalla.Text = Resultat.ToString();
                    break;
                case "multiplicar":
                    Resultat = element1 * element2;
                    lblPantalla.Text = Resultat.ToString();
                    element1 = 0;
                    element2 = 0;
                    break;
                case "dividir":
                
                    if (this.element2 == 0)
                    {
                        lblPantalla.Text = "Error";
                    }
                    else
                    {
                        Resultat = element1 / element2;
                        lblPantalla.Text = Resultat.ToString();
                    }

                    break;
            }         
            
        }

        //
        //Final funcio operacions
        //


        //
        // Entrada per teclat, comprovem totes les tecles d'entrada
        //

        private void Calculadora_KeyUp(object sender, KeyEventArgs e)
        {


            if (e.KeyCode >= Keys.NumPad0 && e.KeyCode <= Keys.NumPad9)
            {
                if (lblPantalla.Text == "0")
                {
                    //Convertim a string la resta de (valor agafat per teclat - valor del cero)
                    lblPantalla.Text = Convert.ToString(e.KeyValue - ((int)Keys.NumPad0));

                }
                else
                {
                    if (lblPantalla.Text.Length<=16){
                        lblPantalla.Text = lblPantalla.Text + Convert.ToString(e.KeyValue - ((int)Keys.NumPad0));
                    }

                }


            }
            if (e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9)
            {
                if (lblPantalla.Text == "0")
                {
                    lblPantalla.Text = Convert.ToString(e.KeyValue - ((int)Keys.D0));
                }
                else
                {
                    if (lblPantalla.Text.Length<=16)
                    {
                        lblPantalla.Text = lblPantalla.Text + Convert.ToString(e.KeyValue - ((int)Keys.D0));
                    }

                }


            }

            if (e.KeyCode == Keys.Subtract)
            {
                TipusOperacio = "resta";
                if (Resultat != 0)
                {
                    element1 = Resultat;
                    lblPantalla.Text = "0";
                }
                else
                {
                    element1String = lblPantalla.Text;
                    element1 = element1 + Double.Parse(element1String);
                    lblPantalla.Text = "0";
                }

                puntDecimal = false;

            }

            if (e.KeyCode == Keys.Add)
            {
                TipusOperacio = "suma";
                if (Resultat != 0)
                {
                    element1 = Resultat;
                    lblPantalla.Text = "0";
                }
                else
                {
                    element1String = lblPantalla.Text;
                    element1 = element1 + Double.Parse(element1String);
                    lblPantalla.Text = "0";

                }

                puntDecimal = false;

            }

            if (e.KeyCode == Keys.Multiply)
            {
                TipusOperacio = "multiplicar";
                if (Resultat != 0)
                {
                    element1 = Resultat;
                    lblPantalla.Text = "0";
                }
                else
                {
                    element1String = lblPantalla.Text;
                    element1 = element1 + Double.Parse(element1String);
                    lblPantalla.Text = "0";
                }
                

                puntDecimal = false;

            }

            if (e.KeyCode == Keys.Divide)
            {
                TipusOperacio = "dividir";
                if (Resultat != 0)
                {
                    element1 = Resultat;
                    lblPantalla.Text = "0";
                }
                else
                {
                    element1String = lblPantalla.Text;
                    element1 = element1 + Double.Parse(element1String);
                    lblPantalla.Text = "0";
                }

                puntDecimal = false;

            }

            if (e.KeyCode == Keys.Enter)
            {
                element2String = lblPantalla.Text;
                element2 = Double.Parse(element2String);
                puntDecimal = false;

                Operacions(element1, element2, TipusOperacio);


            }

            if (e.KeyCode == Keys.Delete)
            {
                lblPantalla.Text = "0";
                element1 = 0;
                element2 = 0;
                Resultat = 0;

                puntDecimal = false;

            }

            if (e.KeyCode == Keys.Back)
            {
                if (lblPantalla.Text.Length == 1)
                {
                    lblPantalla.Text = "0";
                }
                else
                {
                    lblPantalla.Text = lblPantalla.Text.Substring(0, lblPantalla.Text.Length - 1);
                }

                puntDecimal = false;

            }

            if (e.KeyCode == Keys.Oemcomma || e.KeyCode == Keys.Decimal)
            {
                if (puntDecimal == false)
                {
                    lblPantalla.Text = lblPantalla.Text + ",";
                }

                puntDecimal = true;
            }   

        }

        //
        // Final Entrada per teclat
        //




        //Final


    }
}
