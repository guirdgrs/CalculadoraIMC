using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtividadeIMC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double peso, altura; //Var para armazenar valores corporais

            peso = double.Parse(txbPeso.Text); //Peso
            altura = double.Parse(txbAltura.Text); //Altura

            double imc = (peso / (altura * altura)); //IMC final

            if (imc < 18.5) //Condição de Imc
            {
                lblResultado.Text = "Abaixo do Peso"; //Classificação
                lblResultado.TextAlign = ContentAlignment.MiddleCenter; //Alinhar texto
                lblResultado.ForeColor = Color.DarkBlue; //Mudar cor do texto
            }
            else if (imc >= 18.6 && imc <= 24.9)
            {
                lblResultado.Text = "Peso ideal";
                lblResultado.TextAlign = ContentAlignment.MiddleCenter;
                lblResultado.ForeColor = Color.Green;
            }
            else if (imc >= 25 && imc <= 29.9)
            {
                lblResultado.Text = "Levemente acima do peso";
                lblResultado.TextAlign = ContentAlignment.MiddleCenter;
                lblResultado.ForeColor = Color.Orange;
            }
            else if (imc >= 30 && imc <= 34.9)
            {
                lblResultado.Text = "Obesidade - Grau I";
                lblResultado.TextAlign = ContentAlignment.MiddleCenter;
                lblResultado.ForeColor = Color.IndianRed;
            }
            else if (imc >= 35 && imc <= 39.9)
            {
                lblResultado.Text = "Obesidade - Grau II (Severa)";
                lblResultado.TextAlign = ContentAlignment.MiddleCenter;
                lblResultado.ForeColor = Color.Red;
            }
            else //Imc > 40
            {
                lblResultado.Text = "Obesidade - Grau III (Mórbida)";
                lblResultado.TextAlign = ContentAlignment.MiddleCenter;
                lblResultado.ForeColor = Color.DarkRed;
            }
        }
    }
}
