using System;
using System.Drawing;
using System.Linq.Expressions;

namespace calculadora
{
    public partial class Calculadora : Form
    {

        bool adicao = false;
        bool subtracao = false;
        bool multiplicacao = false;
        bool divisao = false;
        float num1 = 0, num = 0, res = 0;


        public Calculadora()
        {
            InitializeComponent();

        }

        private void btn0_Click(object sender, EventArgs e)
        {
            tb_resultado.Text += "0";
            num1 = (num1 * 10) + 0;

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            tb_resultado.Text += "1";
            num1 = (num1 * 10) + 1;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            tb_resultado.Text += "2";
            num1 = (num1 * 10) + 2;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            tb_resultado.Text += "3";
            num1 = (num1 * 10) + 3;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            tb_resultado.Text += "4";
            num1 = (num1 * 10) + 4;

        }

        private void btn5_Click(object sender, EventArgs e)
        {
            tb_resultado.Text += "5";
            num1 = (num1 * 10) + 5;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            tb_resultado.Text += "6";
            num1 = (num1 * 10) + 6; 
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            tb_resultado.Text += "7";
            num1 = (num1 * 10) + 7;
        }


        private void btn8_Click(object sender, EventArgs e)
        {
            tb_resultado.Text += "8";
            num1 =  (num1 * 10) + 8;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            tb_resultado.Text += "9";
            num1 = (num1 * 10) + 9;
        }

        private void btn_soma_Click(object sender, EventArgs e)
        {
            tb_resultado.Text += "+";
            adicao = true;
            subtracao = false;
            multiplicacao = false;
            divisao = false;
            { num = num1; num1 = 0; }

        }

        private void btn_subtracao_Click(object sender, EventArgs e)
        {
            tb_resultado.Text += "-";
            adicao = false;
            subtracao = true;
            multiplicacao = false;
            divisao = false;
            { num = num1; num1 = 0; }
        }

        private void btn_multiplicacao_Click(object sender, EventArgs e)
        {
            tb_resultado.Text += "x";
            adicao = false;
            subtracao = false;
            multiplicacao = true;
            divisao = false;
            { num = num1; num1 = 0; }
        }

        private void btn_divisao_Click(object sender, EventArgs e)
        {
            tb_resultado.Text += "/";
            adicao = false;
            subtracao = false;
            multiplicacao = false;
            divisao = true;
            { num = num1; num1 = 0; }
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            tb_resultado.Text = "";
            num = 0;
            num1 = 0;
            res = 0;
        }

        private void tb_resultado_TextChanged(object sender, EventArgs e)
        {

        }
    
        private void btn_igual_Click(object sender, EventArgs e)
        {
          


            {

                if (adicao == true)
                {
                    res = num + num1;
                    tb_resultado.Text = res.ToString();
                }
                else if (subtracao == true)
                {
                    res = num - num1;
                    tb_resultado.Text = res.ToString();
                }
                else if (multiplicacao == true)
                {
                    res = num * num1;
                    tb_resultado.Text = res.ToString();
                }




                else if (divisao == true)
                {

                    if (num1 != 0)
                    {
                        res = num / num1;
                        tb_resultado.Text = res.ToString();
                    }
                    else
                    {
                        tb_resultado.Text = "Erro! Divisão por 0";
                    }
                }
            }
        }
    }
}
