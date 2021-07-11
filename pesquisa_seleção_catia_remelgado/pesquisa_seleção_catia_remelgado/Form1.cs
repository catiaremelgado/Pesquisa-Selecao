using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pesquisa_seleção_catia_remelgado
{
    public partial class Form1 : Form
    {
        private int[] arrayNumeros;
        private DateTime TempoI, TempoF;
        private TimeSpan Tempo;
        private string newLine = Environment.NewLine;

        public Form1()
        {
            InitializeComponent();
        }

                                //Criar array
        private void button1_Click(object sender, EventArgs e)
        {


            labelSegundosCria.Text = "Aguarde...";
            labelSegundosMostra.Text = "Aguarde...";
            int tamanho = int.Parse(numericUpDown1.Value.ToString());

            
            arrayNumeros = new int[tamanho];
            TempoI = DateTime.Now;
            if (radioButton1.Checked) // aleatorio
            {
                Random random = new Random();
                for (int i = 0; i < tamanho; i++)
                {
                    int valor = random.Next(1, tamanho + 1);
                    arrayNumeros[i] = valor;
                }
            }
            else if (radioButton2.Checked) // ordem crescente
            {
                for (int i = 0; i < tamanho; i++)
                {
                    arrayNumeros[i] = i + 1;
                }
            }
            else // ordem descrescente
            {
                for (int i = 0; i < tamanho; i++)
                {
                    arrayNumeros[i] = tamanho - i;
                }
            }
            TempoF = DateTime.Now;
            Tempo = TempoF.Subtract(TempoI);
            labelSegundosCria.Text = Tempo.TotalSeconds.ToString("0.0000") + " segundos";
            this.Refresh();

            // mostrar o array na listbox
            TempoI = DateTime.Now;
            listBoxNumeros.DataSource = arrayNumeros;
            TempoF = DateTime.Now;
            Tempo = TempoF.Subtract(TempoI);
            labelSegundosMostra.Text = Tempo.TotalSeconds.ToString("0.0000") + " segundos";
        }

                        //Limpa dados
        void LimpaDados()
        {
            arrayNumeros = null;
            listBoxNumeros.DataSource = null;
            textBox2.Text = "";
            richTextBoxResultadoSelecao.Text = "";
            
            textBoxValorContar.Text = "";
        }

                    //Verificar array
        bool VerificaArray()
        {
            if (arrayNumeros == null)
            {
                MessageBox.Show("Array sem dados!", "Pesquisa e Seleção", MessageBoxButtons.OK,
               MessageBoxIcon.Information);
                return false;
            }
            return true;
        }

                                    //Pesquisa Binária
        private void buttonBinaria_Click(object sender, EventArgs e)
        {
            if (VerificaArray() == false)
            {
                return;
            }
            if (radioButton2.Checked == false)
            {
                MessageBox.Show("O Array deve estar ordenado crescentemente", "Pesquisa e Seleção", MessageBoxButtons.OK,
               MessageBoxIcon.Information);
                return;
            }
            int valor;
            bool sucesso = int.TryParse(textBox1.Text, out valor);
            if (sucesso == false)
            {
                MessageBox.Show("Valor a procurar inválido", "Pesquisa e Seleção", MessageBoxButtons.OK,
               MessageBoxIcon.Information);
                return;
            }
            else
            {
                int pos = ClassPesquisaSelecao.PesquisaBinaria(arrayNumeros, valor);
                if (pos == -1)
                {
                    textBox2.Text = $"O Número {valor} não existe no array{newLine}";
                }
                else
                {
                    textBox2.Text = $"O Número {valor} está na posição {pos}{newLine}";
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
                        
                                // class pesquisa e seleção
        class ClassPesquisaSelecao
        {
            public static int PesquisaSequencial(int[] arrayNumero, int valorProcurar)
            {
                int n = arrayNumero.Length;
                for (int i = 0; i < n; i++)
                {
                    if (arrayNumero[i] == valorProcurar)
                    {
                        return i;
                    }
                }
                // não encontrou -> codigo -1
                return -1;
            } // PesquisaSequencial
            public static int PesquisaBinaria(int[] arrayNumero, int valorProcurar)
            {
                int n = arrayNumero.Length;
                int inf = 0;
                int sup = n - 1;
                int meio;
                while (inf <= sup)
                {
                    meio = (inf + sup) / 2;
                    if (arrayNumero[meio] == valorProcurar)
                    {
                        return meio; // índice onde está o valor a procurar
                    }
                    else
                    {
                        if (arrayNumero[meio] < valorProcurar)
                        {
                            inf = meio + 1;
                        }
                        else
                        {
                            sup = meio - 1;
                        }
                    }
                }
                // não encontrou -> codigo -1
                return -1;
            } // PesquisaBinaria
        } //class

        private void radioButton2_CheckedChanged(object sender, EventArgs e) // Ordem Crescente
        {
            LimpaDados();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e) // Aleatorio
        {
            LimpaDados();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e) // Ordem decrecente
        {
            LimpaDados();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            LimpaDados();
            

        }

                    
                                //Pesquisa Sequencial
        private void buttonPesSequencial_Click(object sender, EventArgs e)
        {

            if (VerificaArray() == false)
            {
                return; // aborta

            }

            int valor;

            bool sucesso = int.TryParse(textBox1.Text, out valor);

            if (sucesso == false)
            {
                MessageBox.Show("Valor a procurar inválido", "Pesquisa e Seleção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return; // aborta
            }

            else
            {
                int pos = ClassPesquisaSelecao.PesquisaSequencial(arrayNumeros, valor);
                if (pos == -1)
                {
                    textBox2.Text = $"O Número {valor} não existe no array{newLine}.";
                }

                else
                {
                    textBox2.Text = $"O Número {valor} está na posição {pos}{newLine}.";
                }
            }
        }
                            
                            //Máximo
        private void buttonMax_Click(object sender, EventArgs e) 
        {
            int max = arrayNumeros[0];

            for (int i = 1; i < arrayNumeros.Length; i++)
            {
                if (arrayNumeros[i] > max)
                {
                    max = arrayNumeros[i];
                }
            }

            richTextBoxResultadoSelecao.Text = $"O Maior número é: {max}";
        }

                                //Contar
        private void buttonConta_Click(object sender, EventArgs e)
        {
            if (textBoxValorContar.Text == "")
                MessageBox.Show("Deve inserir um valor válido!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                int n = int.Parse(textBoxValorContar.Text);
                int count = 0;

                for (int i = 0; i < arrayNumeros.Length; i++)
                {
                    if (arrayNumeros[i] == n)
                    {
                        count++;
                    }
                }

                TempoF = DateTime.Now;
                Tempo = TempoF.Subtract(TempoI);



                richTextBoxResultadoSelecao.Text = $"O valor aparece {count} vezes.";
            }
        }

        private void buttonMin_Click(object sender, EventArgs e)
        {
            int min = arrayNumeros[0];

            for (int i = 1; i < arrayNumeros.Length; i++)
            {
                if (arrayNumeros[i] < min)
                {
                    min = arrayNumeros[i];
                }
            }
            richTextBoxResultadoSelecao.Text = $"O Menor número é: {min}";
        }

        private void buttonKmaior_Click(object sender, EventArgs e)
        {
            int[] sortedArray = new int[arrayNumeros.Length];
            Array.Copy(arrayNumeros, sortedArray, arrayNumeros.Length);

            Array.Sort(sortedArray);

            int k = int.Parse(numericUpDownK.Value.ToString());

            if (k < 1 || k > sortedArray.Length)
            {
                MessageBox.Show("O número deve ser um índice válido do array!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int result = sortedArray[sortedArray.Length - k];

                TempoF = DateTime.Now;
                Tempo = TempoF.Subtract(TempoI);



                richTextBoxResultadoSelecao.Text = $"O K-Ésimo Maior Número é o: {result}";
            }
        }

        private void buttonMaxMin_Click(object sender, EventArgs e)
        {
            int max = arrayNumeros[0];
            int min = arrayNumeros[0];

            for (int i = 1; i < arrayNumeros.Length; i++)
            {
                if (arrayNumeros[i] < min)
                {
                    min = arrayNumeros[i];
                }
            }

            for (int i = 1; i < arrayNumeros.Length; i++)
            {
                if (arrayNumeros[i] > max)
                {
                    max = arrayNumeros[i];
                }
            }

            


            richTextBoxResultadoSelecao.Text = $"O valor máximo é: {max} e o minímo é: {min}";
        }

        private void buttonKmenor_Click(object sender, EventArgs e)
        {
            int[] sortedArray = new int[arrayNumeros.Length];
            Array.Copy(arrayNumeros, sortedArray, arrayNumeros.Length);

            Array.Sort(sortedArray);

            int k = int.Parse(numericUpDownK.Value.ToString());

            if (k < 1 || k > sortedArray.Length)
            {
                MessageBox.Show("O número deve ser um índice válido do array!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int result = sortedArray[k - 1];

                richTextBoxResultadoSelecao.Text = $"O K-Ésimo Menor Número é o: {result}";
               
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}




