namespace calculadora
{
    partial class Calculadora
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tb_resultado = new TextBox();
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btn_soma = new Button();
            btn4 = new Button();
            btn5 = new Button();
            btn6 = new Button();
            btn_subtracao = new Button();
            btn8 = new Button();
            btn7 = new Button();
            btn_limpar = new Button();
            btn_multiplicacao = new Button();
            btn0 = new Button();
            btn9 = new Button();
            btn_igual = new Button();
            btn_divisao = new Button();
            SuspendLayout();
            // 
            // tb_resultado
            // 
            tb_resultado.BackColor = SystemColors.ControlDark;
            tb_resultado.Font = new Font("Microsoft Sans Serif", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_resultado.ForeColor = Color.Black;
            tb_resultado.Location = new Point(47, 42);
            tb_resultado.Name = "tb_resultado";
            tb_resultado.ReadOnly = true;
            tb_resultado.Size = new Size(306, 45);
            tb_resultado.TabIndex = 0;
            tb_resultado.TextAlign = HorizontalAlignment.Right;
            tb_resultado.TextChanged += tb_resultado_TextChanged;
            // 
            // btn1
            // 
            btn1.BackColor = SystemColors.ButtonShadow;
            btn1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btn1.Location = new Point(49, 123);
            btn1.Name = "btn1";
            btn1.Size = new Size(67, 48);
            btn1.TabIndex = 1;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = false;
            btn1.Click += btn1_Click;
            // 
            // btn2
            // 
            btn2.BackColor = SystemColors.ButtonShadow;
            btn2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btn2.Location = new Point(129, 123);
            btn2.Name = "btn2";
            btn2.Size = new Size(67, 48);
            btn2.TabIndex = 2;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = false;
            btn2.Click += btn2_Click;
            // 
            // btn3
            // 
            btn3.BackColor = SystemColors.ButtonShadow;
            btn3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btn3.Location = new Point(209, 123);
            btn3.Name = "btn3";
            btn3.Size = new Size(67, 48);
            btn3.TabIndex = 3;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = false;
            btn3.Click += btn3_Click;
            // 
            // btn_soma
            // 
            btn_soma.BackColor = SystemColors.Highlight;
            btn_soma.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btn_soma.Location = new Point(288, 123);
            btn_soma.Name = "btn_soma";
            btn_soma.Size = new Size(67, 48);
            btn_soma.TabIndex = 4;
            btn_soma.Text = "+";
            btn_soma.UseVisualStyleBackColor = false;
            btn_soma.Click += btn_soma_Click;
            // 
            // btn4
            // 
            btn4.BackColor = SystemColors.ButtonShadow;
            btn4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btn4.Location = new Point(49, 200);
            btn4.Name = "btn4";
            btn4.Size = new Size(67, 48);
            btn4.TabIndex = 5;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = false;
            btn4.Click += btn4_Click;
            // 
            // btn5
            // 
            btn5.BackColor = SystemColors.ButtonShadow;
            btn5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btn5.Location = new Point(129, 200);
            btn5.Name = "btn5";
            btn5.Size = new Size(67, 48);
            btn5.TabIndex = 6;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = false;
            btn5.Click += btn5_Click;
            // 
            // btn6
            // 
            btn6.BackColor = SystemColors.ButtonShadow;
            btn6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btn6.Location = new Point(209, 200);
            btn6.Name = "btn6";
            btn6.Size = new Size(67, 48);
            btn6.TabIndex = 7;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = false;
            btn6.Click += btn6_Click;
            // 
            // btn_subtracao
            // 
            btn_subtracao.BackColor = SystemColors.Highlight;
            btn_subtracao.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btn_subtracao.Location = new Point(288, 200);
            btn_subtracao.Name = "btn_subtracao";
            btn_subtracao.Size = new Size(67, 48);
            btn_subtracao.TabIndex = 8;
            btn_subtracao.Text = "-";
            btn_subtracao.UseVisualStyleBackColor = false;
            btn_subtracao.Click += btn_subtracao_Click;
            // 
            // btn8
            // 
            btn8.BackColor = SystemColors.ButtonShadow;
            btn8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btn8.Location = new Point(129, 279);
            btn8.Name = "btn8";
            btn8.Size = new Size(67, 48);
            btn8.TabIndex = 9;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = false;
            btn8.Click += btn8_Click;
            // 
            // btn7
            // 
            btn7.BackColor = SystemColors.ButtonShadow;
            btn7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btn7.Location = new Point(49, 279);
            btn7.Name = "btn7";
            btn7.Size = new Size(67, 48);
            btn7.TabIndex = 10;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = false;
            btn7.Click += btn7_Click;
            // 
            // btn_limpar
            // 
            btn_limpar.BackColor = SystemColors.ButtonShadow;
            btn_limpar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btn_limpar.Location = new Point(129, 356);
            btn_limpar.Name = "btn_limpar";
            btn_limpar.Size = new Size(67, 48);
            btn_limpar.TabIndex = 11;
            btn_limpar.Text = "C";
            btn_limpar.UseVisualStyleBackColor = false;
            btn_limpar.Click += btn_limpar_Click;
            // 
            // btn_multiplicacao
            // 
            btn_multiplicacao.BackColor = SystemColors.Highlight;
            btn_multiplicacao.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btn_multiplicacao.Location = new Point(288, 279);
            btn_multiplicacao.Name = "btn_multiplicacao";
            btn_multiplicacao.Size = new Size(67, 48);
            btn_multiplicacao.TabIndex = 12;
            btn_multiplicacao.Text = "x";
            btn_multiplicacao.UseVisualStyleBackColor = false;
            btn_multiplicacao.Click += btn_multiplicacao_Click;
            // 
            // btn0
            // 
            btn0.BackColor = SystemColors.ButtonShadow;
            btn0.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btn0.Location = new Point(49, 356);
            btn0.Name = "btn0";
            btn0.Size = new Size(67, 48);
            btn0.TabIndex = 13;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = false;
            btn0.Click += btn0_Click;
            // 
            // btn9
            // 
            btn9.BackColor = SystemColors.ButtonShadow;
            btn9.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btn9.Location = new Point(209, 279);
            btn9.Name = "btn9";
            btn9.Size = new Size(67, 48);
            btn9.TabIndex = 14;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = false;
            btn9.Click += btn9_Click;
            // 
            // btn_igual
            // 
            btn_igual.BackColor = SystemColors.ButtonShadow;
            btn_igual.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btn_igual.Location = new Point(209, 356);
            btn_igual.Name = "btn_igual";
            btn_igual.Size = new Size(67, 48);
            btn_igual.TabIndex = 15;
            btn_igual.Text = "=";
            btn_igual.UseVisualStyleBackColor = false;
            btn_igual.Click += btn_igual_Click;
            // 
            // btn_divisao
            // 
            btn_divisao.BackColor = SystemColors.Highlight;
            btn_divisao.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btn_divisao.Location = new Point(288, 356);
            btn_divisao.Name = "btn_divisao";
            btn_divisao.Size = new Size(67, 48);
            btn_divisao.TabIndex = 16;
            btn_divisao.Text = "/";
            btn_divisao.UseVisualStyleBackColor = false;
            btn_divisao.Click += btn_divisao_Click;
            // 
            // Calculadora
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Desktop;
            ClientSize = new Size(398, 570);
            Controls.Add(btn_divisao);
            Controls.Add(btn_igual);
            Controls.Add(btn9);
            Controls.Add(btn0);
            Controls.Add(btn_multiplicacao);
            Controls.Add(btn_limpar);
            Controls.Add(btn7);
            Controls.Add(btn8);
            Controls.Add(btn_subtracao);
            Controls.Add(btn6);
            Controls.Add(btn5);
            Controls.Add(btn4);
            Controls.Add(btn_soma);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Controls.Add(tb_resultado);
            Name = "Calculadora";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tb_resultado;
        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btn_soma;
        private Button btn4;
        private Button btn5;
        private Button btn6;
        private Button btn_subtracao;
        private Button btn8;
        private Button btn7;
        private Button btn_limpar;
        private Button btn_multiplicacao;
        private Button btn0;
        private Button btn9;
        private Button btn_igual;
        private Button btn_divisao;
    }
}
