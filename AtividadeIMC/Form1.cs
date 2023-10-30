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
            MessageBox.Show("Lembre-se de utilizar vírgula ( , ) no campo ALTURA!"); //Mensagem inicial
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {

            try //Controle de erro
            {
                double peso, altura; //Var para armazenar valores corporais
                
                    peso = double.Parse(txbPeso.Text); //Peso
                    altura = double.Parse(txbAltura.Text); //Altura

                    //Min peso    //Max peso    //Min altura    //Max altura
                if (peso <= 10 || peso >= 800 || altura <= 0.3 || altura >= 2.8 ) //Peso ou altura inválidos
                {
                    MessageBox.Show("Digite um valor válido");
                    lblResultado.Text = ("");
                    txbAltura.Clear();
                    txbPeso.Clear();
                }
                else //Peso ou altura válidos
                {
                    double imc = (peso / (altura * altura)); //IMC final

                    if (imc < 18.5) //Condição de Imc
                    {
                        lblResultado.Text = "Abaixo do Peso"; //Classificação
                        lblResultado.ForeColor = Color.DarkBlue; //Mudar cor do texto
                    }
                    else if (imc >= 18.6 && imc <= 24.9)
                    {
                        lblResultado.Text = "Peso ideal";
                        lblResultado.ForeColor = Color.Green; //Verde
                    }
                    else if (imc >= 25 && imc <= 29.9)
                    {
                        lblResultado.Text = "Levemente acima do peso";
                        lblResultado.ForeColor = Color.Orange; //Laranja
                    }
                    else if (imc >= 30 && imc <= 34.9)
                    {
                        lblResultado.Text = "Obesidade - Grau I";
                        lblResultado.ForeColor = Color.IndianRed; //Vermelho indian
                    }
                    else if (imc >= 35 && imc <= 39.9)
                    {
                        lblResultado.Text = "Obesidade - Grau II (Severa)"; //Vermelho
                        lblResultado.ForeColor = Color.Red;
                    }
                    else //Imc > 40
                    {
                        lblResultado.Text = "Obesidade - Grau III (Mórbida)"; //Vermelho escuro
                        lblResultado.ForeColor = Color.DarkRed;
                    }
                }
                
            }
            catch //Erro localizado
            {
                MessageBox.Show("Ocorreu algum erro!");
                txbAltura.Clear();
                txbPeso.Clear();
            }
        }
    }
}
