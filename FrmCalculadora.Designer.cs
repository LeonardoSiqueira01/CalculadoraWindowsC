namespace Calculadora
{
    partial class FrmCalculadora
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btnApagar = new System.Windows.Forms.Button();
            this.btnLimparTodos = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnDivisao = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.btnMultiplicacao = new System.Windows.Forms.Button();
            this.btnSubtracao = new System.Windows.Forms.Button();
            this.btnVirgula = new System.Windows.Forms.Button();
            this.btnSoma = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnIgual = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnPorcentagem = new System.Windows.Forms.Button();
            this.btnRaiz = new System.Windows.Forms.Button();
            this.lblMensagem = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtResultado
            // 
            this.txtResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultado.Location = new System.Drawing.Point(12, 12);
            this.txtResultado.MaxLength = 17;
            this.txtResultado.Multiline = true;
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(229, 49);
            this.txtResultado.TabIndex = 0;
            this.txtResultado.Text = "0";
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(8, 220);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(41, 38);
            this.btn1.TabIndex = 1;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.agregarNumero);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(55, 220);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(41, 38);
            this.btn2.TabIndex = 2;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.agregarNumero);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(102, 220);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(40, 38);
            this.btn3.TabIndex = 3;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.agregarNumero);
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(102, 176);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(41, 38);
            this.btn6.TabIndex = 6;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.agregarNumero);
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(55, 176);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(41, 38);
            this.btn5.TabIndex = 5;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.agregarNumero);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(8, 176);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(41, 38);
            this.btn4.TabIndex = 4;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.agregarNumero);
            // 
            // btn9
            // 
            this.btn9.Location = new System.Drawing.Point(101, 132);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(41, 38);
            this.btn9.TabIndex = 9;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.agregarNumero);
            // 
            // btn8
            // 
            this.btn8.Location = new System.Drawing.Point(55, 132);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(41, 38);
            this.btn8.TabIndex = 8;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.agregarNumero);
            // 
            // btn7
            // 
            this.btn7.Location = new System.Drawing.Point(8, 132);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(41, 38);
            this.btn7.TabIndex = 7;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.agregarNumero);
            // 
            // btnApagar
            // 
            this.btnApagar.Location = new System.Drawing.Point(8, 88);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(41, 38);
            this.btnApagar.TabIndex = 10;
            this.btnApagar.Text = "<--";
            this.btnApagar.UseVisualStyleBackColor = true;
            this.btnApagar.Click += new System.EventHandler(this.btnApagar_Click);
            // 
            // btnLimparTodos
            // 
            this.btnLimparTodos.Location = new System.Drawing.Point(55, 88);
            this.btnLimparTodos.Name = "btnLimparTodos";
            this.btnLimparTodos.Size = new System.Drawing.Size(41, 38);
            this.btnLimparTodos.TabIndex = 11;
            this.btnLimparTodos.Text = "CE";
            this.btnLimparTodos.UseVisualStyleBackColor = true;
            this.btnLimparTodos.Click += new System.EventHandler(this.btnLimparTodos_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(102, 88);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(41, 38);
            this.btnLimpar.TabIndex = 12;
            this.btnLimpar.Text = "C";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnDivisao
            // 
            this.btnDivisao.Location = new System.Drawing.Point(149, 132);
            this.btnDivisao.Name = "btnDivisao";
            this.btnDivisao.Size = new System.Drawing.Size(41, 38);
            this.btnDivisao.TabIndex = 13;
            this.btnDivisao.Tag = "/";
            this.btnDivisao.Text = "/";
            this.btnDivisao.UseVisualStyleBackColor = true;
            this.btnDivisao.Click += new System.EventHandler(this.clickOperador);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(149, 88);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(41, 38);
            this.button5.TabIndex = 14;
            this.button5.Text = "+\\-";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnMultiplicacao
            // 
            this.btnMultiplicacao.Location = new System.Drawing.Point(149, 176);
            this.btnMultiplicacao.Name = "btnMultiplicacao";
            this.btnMultiplicacao.Size = new System.Drawing.Size(41, 38);
            this.btnMultiplicacao.TabIndex = 15;
            this.btnMultiplicacao.Tag = "*";
            this.btnMultiplicacao.Text = "*";
            this.btnMultiplicacao.UseVisualStyleBackColor = true;
            this.btnMultiplicacao.Click += new System.EventHandler(this.clickOperador);
            // 
            // btnSubtracao
            // 
            this.btnSubtracao.Location = new System.Drawing.Point(148, 220);
            this.btnSubtracao.Name = "btnSubtracao";
            this.btnSubtracao.Size = new System.Drawing.Size(41, 38);
            this.btnSubtracao.TabIndex = 16;
            this.btnSubtracao.Tag = "-";
            this.btnSubtracao.Text = "-";
            this.btnSubtracao.UseVisualStyleBackColor = true;
            this.btnSubtracao.Click += new System.EventHandler(this.clickOperador);
            // 
            // btnVirgula
            // 
            this.btnVirgula.Location = new System.Drawing.Point(101, 264);
            this.btnVirgula.Name = "btnVirgula";
            this.btnVirgula.Size = new System.Drawing.Size(41, 38);
            this.btnVirgula.TabIndex = 17;
            this.btnVirgula.Text = ",";
            this.btnVirgula.UseVisualStyleBackColor = true;
            this.btnVirgula.Click += new System.EventHandler(this.btnVirgula_Click);
            // 
            // btnSoma
            // 
            this.btnSoma.Location = new System.Drawing.Point(148, 264);
            this.btnSoma.Name = "btnSoma";
            this.btnSoma.Size = new System.Drawing.Size(41, 38);
            this.btnSoma.TabIndex = 18;
            this.btnSoma.Tag = "+";
            this.btnSoma.Text = "+";
            this.btnSoma.UseVisualStyleBackColor = true;
            this.btnSoma.Click += new System.EventHandler(this.clickOperador);
            // 
            // btn0
            // 
            this.btn0.Location = new System.Drawing.Point(8, 264);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(88, 38);
            this.btn0.TabIndex = 19;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.agregarNumero);
            // 
            // btnIgual
            // 
            this.btnIgual.Location = new System.Drawing.Point(195, 220);
            this.btnIgual.Name = "btnIgual";
            this.btnIgual.Size = new System.Drawing.Size(41, 82);
            this.btnIgual.TabIndex = 20;
            this.btnIgual.Text = "=";
            this.btnIgual.UseVisualStyleBackColor = true;
            this.btnIgual.Click += new System.EventHandler(this.btnIgual_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(196, 176);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(41, 38);
            this.button4.TabIndex = 21;
            this.button4.Tag = "²";
            this.button4.Text = "X²";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.clickOperador);
            // 
            // btnPorcentagem
            // 
            this.btnPorcentagem.Location = new System.Drawing.Point(195, 132);
            this.btnPorcentagem.Name = "btnPorcentagem";
            this.btnPorcentagem.Size = new System.Drawing.Size(41, 38);
            this.btnPorcentagem.TabIndex = 22;
            this.btnPorcentagem.Tag = "%";
            this.btnPorcentagem.Text = "%";
            this.btnPorcentagem.UseVisualStyleBackColor = true;
            this.btnPorcentagem.Click += new System.EventHandler(this.clickOperador);
            // 
            // btnRaiz
            // 
            this.btnRaiz.Location = new System.Drawing.Point(196, 88);
            this.btnRaiz.Name = "btnRaiz";
            this.btnRaiz.Size = new System.Drawing.Size(41, 38);
            this.btnRaiz.TabIndex = 23;
            this.btnRaiz.Tag = "√";
            this.btnRaiz.Text = "√";
            this.btnRaiz.UseVisualStyleBackColor = true;
            this.btnRaiz.Click += new System.EventHandler(this.clickOperador);
            // 
            // lblMensagem
            // 
            this.lblMensagem.AutoSize = true;
            this.lblMensagem.Location = new System.Drawing.Point(11, 68);
            this.lblMensagem.Name = "lblMensagem";
            this.lblMensagem.Size = new System.Drawing.Size(59, 13);
            this.lblMensagem.TabIndex = 24;
            this.lblMensagem.Text = "Mensagem";
            this.lblMensagem.Visible = false;
            // 
            // FrmCalculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(244, 305);
            this.Controls.Add(this.lblMensagem);
            this.Controls.Add(this.btnRaiz);
            this.Controls.Add(this.btnPorcentagem);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnIgual);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btnSoma);
            this.Controls.Add(this.btnVirgula);
            this.Controls.Add(this.btnSubtracao);
            this.Controls.Add(this.btnMultiplicacao);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.btnDivisao);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnLimparTodos);
            this.Controls.Add(this.btnApagar);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.txtResultado);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmCalculadora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.Button btnLimparTodos;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnDivisao;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btnMultiplicacao;
        private System.Windows.Forms.Button btnSubtracao;
        private System.Windows.Forms.Button btnVirgula;
        private System.Windows.Forms.Button btnSoma;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnIgual;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnPorcentagem;
        private System.Windows.Forms.Button btnRaiz;
        private System.Windows.Forms.Label lblMensagem;
    }
}

