
namespace pesquisa_seleção_catia_remelgado
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.labelSegundosMostra = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listBoxNumeros = new System.Windows.Forms.ListBox();
            this.labelSegundosCria = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.numericUpDownK = new System.Windows.Forms.NumericUpDown();
            this.buttonMax = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonConta = new System.Windows.Forms.Button();
            this.labelValorConta = new System.Windows.Forms.Label();
            this.textBoxValorContar = new System.Windows.Forms.TextBox();
            this.buttonKmenor = new System.Windows.Forms.Button();
            this.buttonKmaior = new System.Windows.Forms.Button();
            this.buttonMaxMin = new System.Windows.Forms.Button();
            this.buttonMin = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonBinaria = new System.Windows.Forms.Button();
            this.buttonPesSequencial = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.buttonLimpar = new System.Windows.Forms.Button();
            this.richTextBoxResultadoSelecao = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownK)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.numericUpDown1);
            this.groupBox1.Controls.Add(this.labelSegundosMostra);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(2, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(360, 197);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Parametros";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(217, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Quantidade de Números";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(234, 56);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(110, 23);
            this.numericUpDown1.TabIndex = 5;
            // 
            // labelSegundosMostra
            // 
            this.labelSegundosMostra.AutoSize = true;
            this.labelSegundosMostra.Location = new System.Drawing.Point(139, 171);
            this.labelSegundosMostra.Name = "labelSegundosMostra";
            this.labelSegundosMostra.Size = new System.Drawing.Size(0, 15);
            this.labelSegundosMostra.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(71, 115);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(190, 41);
            this.button1.TabIndex = 3;
            this.button1.Text = "Criar array de Números";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(10, 81);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(179, 19);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Ordenado Decrescentemente";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(10, 56);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(167, 19);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Ordenado Crescentemente";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(10, 31);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(73, 19);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Aleatorio";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listBoxNumeros);
            this.groupBox2.Controls.Add(this.labelSegundosCria);
            this.groupBox2.Location = new System.Drawing.Point(2, 206);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(359, 309);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Array";
            // 
            // listBoxNumeros
            // 
            this.listBoxNumeros.FormattingEnabled = true;
            this.listBoxNumeros.ItemHeight = 15;
            this.listBoxNumeros.Location = new System.Drawing.Point(104, 19);
            this.listBoxNumeros.Name = "listBoxNumeros";
            this.listBoxNumeros.Size = new System.Drawing.Size(157, 259);
            this.listBoxNumeros.TabIndex = 8;
            // 
            // labelSegundosCria
            // 
            this.labelSegundosCria.AutoSize = true;
            this.labelSegundosCria.Location = new System.Drawing.Point(151, 281);
            this.labelSegundosCria.Name = "labelSegundosCria";
            this.labelSegundosCria.Size = new System.Drawing.Size(0, 15);
            this.labelSegundosCria.TabIndex = 7;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.richTextBoxResultadoSelecao);
            this.groupBox3.Controls.Add(this.numericUpDownK);
            this.groupBox3.Controls.Add(this.buttonMax);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.buttonConta);
            this.groupBox3.Controls.Add(this.labelValorConta);
            this.groupBox3.Controls.Add(this.textBoxValorContar);
            this.groupBox3.Controls.Add(this.buttonKmenor);
            this.groupBox3.Controls.Add(this.buttonKmaior);
            this.groupBox3.Controls.Add(this.buttonMaxMin);
            this.groupBox3.Controls.Add(this.buttonMin);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.textBox2);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.buttonBinaria);
            this.groupBox3.Controls.Add(this.buttonPesSequencial);
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(375, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(392, 512);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Operações de Pesquisa e Seleção";
            // 
            // numericUpDownK
            // 
            this.numericUpDownK.Location = new System.Drawing.Point(149, 253);
            this.numericUpDownK.Name = "numericUpDownK";
            this.numericUpDownK.Size = new System.Drawing.Size(98, 23);
            this.numericUpDownK.TabIndex = 20;
            this.numericUpDownK.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // buttonMax
            // 
            this.buttonMax.Location = new System.Drawing.Point(35, 253);
            this.buttonMax.Name = "buttonMax";
            this.buttonMax.Size = new System.Drawing.Size(76, 23);
            this.buttonMax.TabIndex = 19;
            this.buttonMax.Text = "Max";
            this.buttonMax.UseVisualStyleBackColor = true;
            this.buttonMax.Click += new System.EventHandler(this.buttonMax_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 354);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 15);
            this.label6.TabIndex = 17;
            this.label6.Text = "Resultado da Seleção:";
            // 
            // buttonConta
            // 
            this.buttonConta.Location = new System.Drawing.Point(272, 318);
            this.buttonConta.Name = "buttonConta";
            this.buttonConta.Size = new System.Drawing.Size(105, 23);
            this.buttonConta.TabIndex = 16;
            this.buttonConta.Text = "Conta";
            this.buttonConta.UseVisualStyleBackColor = true;
            this.buttonConta.UseWaitCursor = true;
            this.buttonConta.Click += new System.EventHandler(this.buttonConta_Click);
            // 
            // labelValorConta
            // 
            this.labelValorConta.AutoSize = true;
            this.labelValorConta.Location = new System.Drawing.Point(282, 262);
            this.labelValorConta.Name = "labelValorConta";
            this.labelValorConta.Size = new System.Drawing.Size(82, 15);
            this.labelValorConta.TabIndex = 15;
            this.labelValorConta.Text = "Valor a contar:";
            // 
            // textBoxValorContar
            // 
            this.textBoxValorContar.Location = new System.Drawing.Point(272, 289);
            this.textBoxValorContar.Name = "textBoxValorContar";
            this.textBoxValorContar.Size = new System.Drawing.Size(105, 23);
            this.textBoxValorContar.TabIndex = 14;
            // 
            // buttonKmenor
            // 
            this.buttonKmenor.Location = new System.Drawing.Point(149, 318);
            this.buttonKmenor.Name = "buttonKmenor";
            this.buttonKmenor.Size = new System.Drawing.Size(98, 23);
            this.buttonKmenor.TabIndex = 13;
            this.buttonKmenor.Text = "K-ésimo menor";
            this.buttonKmenor.UseVisualStyleBackColor = true;
            this.buttonKmenor.UseWaitCursor = true;
            this.buttonKmenor.Click += new System.EventHandler(this.buttonKmenor_Click);
            // 
            // buttonKmaior
            // 
            this.buttonKmaior.Location = new System.Drawing.Point(149, 288);
            this.buttonKmaior.Name = "buttonKmaior";
            this.buttonKmaior.Size = new System.Drawing.Size(98, 23);
            this.buttonKmaior.TabIndex = 12;
            this.buttonKmaior.Text = "K-ésimo maior";
            this.buttonKmaior.UseVisualStyleBackColor = true;
            this.buttonKmaior.UseWaitCursor = true;
            this.buttonKmaior.Click += new System.EventHandler(this.buttonKmaior_Click);
            // 
            // buttonMaxMin
            // 
            this.buttonMaxMin.Location = new System.Drawing.Point(35, 318);
            this.buttonMaxMin.Name = "buttonMaxMin";
            this.buttonMaxMin.Size = new System.Drawing.Size(76, 23);
            this.buttonMaxMin.TabIndex = 10;
            this.buttonMaxMin.Text = "Max e Min";
            this.buttonMaxMin.UseVisualStyleBackColor = true;
            this.buttonMaxMin.Click += new System.EventHandler(this.buttonMaxMin_Click);
            // 
            // buttonMin
            // 
            this.buttonMin.Location = new System.Drawing.Point(35, 288);
            this.buttonMin.Name = "buttonMin";
            this.buttonMin.Size = new System.Drawing.Size(76, 23);
            this.buttonMin.TabIndex = 9;
            this.buttonMin.Text = "Min";
            this.buttonMin.UseVisualStyleBackColor = true;
            this.buttonMin.Click += new System.EventHandler(this.buttonMin_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(35, 234);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Seleção";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox2.Location = new System.Drawing.Point(35, 165);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(342, 25);
            this.textBox2.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(147, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Resultado da Pesquisa:";
            // 
            // buttonBinaria
            // 
            this.buttonBinaria.Location = new System.Drawing.Point(229, 100);
            this.buttonBinaria.Name = "buttonBinaria";
            this.buttonBinaria.Size = new System.Drawing.Size(135, 33);
            this.buttonBinaria.TabIndex = 4;
            this.buttonBinaria.Text = "Pesquisa Binária";
            this.buttonBinaria.UseVisualStyleBackColor = true;
            this.buttonBinaria.Click += new System.EventHandler(this.buttonBinaria_Click);
            // 
            // buttonPesSequencial
            // 
            this.buttonPesSequencial.Location = new System.Drawing.Point(35, 100);
            this.buttonPesSequencial.Name = "buttonPesSequencial";
            this.buttonPesSequencial.Size = new System.Drawing.Size(135, 33);
            this.buttonPesSequencial.TabIndex = 3;
            this.buttonPesSequencial.Text = "Pesquisa Sequencial";
            this.buttonPesSequencial.UseVisualStyleBackColor = true;
            this.buttonPesSequencial.Click += new System.EventHandler(this.buttonPesSequencial_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(147, 56);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(147, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Valor a pesquisar:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(35, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Pesquisa";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(692, 520);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Sair";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // buttonLimpar
            // 
            this.buttonLimpar.Location = new System.Drawing.Point(604, 520);
            this.buttonLimpar.Name = "buttonLimpar";
            this.buttonLimpar.Size = new System.Drawing.Size(75, 23);
            this.buttonLimpar.TabIndex = 4;
            this.buttonLimpar.Text = "Limpar";
            this.buttonLimpar.UseVisualStyleBackColor = true;
            this.buttonLimpar.Click += new System.EventHandler(this.button4_Click);
            // 
            // richTextBoxResultadoSelecao
            // 
            this.richTextBoxResultadoSelecao.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.richTextBoxResultadoSelecao.Location = new System.Drawing.Point(35, 372);
            this.richTextBoxResultadoSelecao.Name = "richTextBoxResultadoSelecao";
            this.richTextBoxResultadoSelecao.Size = new System.Drawing.Size(342, 126);
            this.richTextBoxResultadoSelecao.TabIndex = 21;
            this.richTextBoxResultadoSelecao.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 555);
            this.Controls.Add(this.buttonLimpar);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownK)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label labelSegundosMostra;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label labelSegundosCria;
        private System.Windows.Forms.ListBox listBoxNumeros;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonConta;
        private System.Windows.Forms.Label labelValorConta;
        private System.Windows.Forms.TextBox textBoxValorContar;
        private System.Windows.Forms.Button buttonKmenor;
        private System.Windows.Forms.Button buttonKmaior;
        private System.Windows.Forms.Button buttonMaxMin;
        private System.Windows.Forms.Button buttonMin;
        private System.Windows.Forms.Button Button5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonBinaria;
        private System.Windows.Forms.Button buttonPesSequencial;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button buttonLimpar;
        private System.Windows.Forms.Button buttonMax;
        private System.Windows.Forms.NumericUpDown numericUpDownK;
        private System.Windows.Forms.RichTextBox richTextBoxResultadoSelecao;
    }
}

