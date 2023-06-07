using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListaNumeros
{
    public partial class FormUnico : Form
    {
        //Declaração de variáveis global
        public string linha;
        public FormUnico()
        {
            InitializeComponent();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            //Declaração de variáveis locais
            int numMult = 0, limite=0;
            bool certo = false;
            //iniciar o listbox
            ltbLista.Items.Clear();
            //Consistência de dados
            if (rdb01.Checked || rdb05.Checked || rdb10.Checked || rdb15.Checked || rdb20.Checked || rdb25.Checked)
                if (rdbPares.Checked || rdbImpares.Checked || rdbMultiplo.Checked)
                {
                    if (rdbMultiplo.Checked && txbMultiplo.Text != "")
                    {
                        if (!int.TryParse(txbMultiplo.Text, out numMult))
                            MessageBox.Show("O número múltiplo deve ser inteiro!", "Consistência de dados");
                        else certo = true;
                    }
                    else
                    if (rdbMultiplo.Checked)
                        MessageBox.Show("Com Número Múltiplo escolhido, deve-se indicar o número multiplicador", "Consistência de dados");
                    else certo = true;
                }
                else MessageBox.Show("Obrigatório escolher um Tipo de Número!", "Consistência de dados");
            else MessageBox.Show("Escolha a quantidade de números por linha!", "Consistência de dados");
            if (certo) limite = DescobreLimite();
            //Loop de geração de números pares
            if (rdbPares.Checked && certo)
                GeraPares(limite);
            //Loop de geração de números ímpares
            else if (rdbImpares.Checked && certo)
                GeraImpares();
            //Loop de geração de números múltiplos
            else if (certo)
                GeraMultiplos(numMult);
        }

        private int DescobreLimite()
        {
            int limite;
            if (rdb01.Checked) limite = 1;
            else if (rdb05.Checked) limite = 5;
            else if (rdb10.Checked) limite = 10;
            else if (rdb15.Checked) limite = 15;
            else if (rdb20.Checked) limite = 20;
            else limite = 25;
            return limite;
        }

        private void GeraPares(int max)
        {
            int cont, num, pos=1;
            linha = "";
            for (cont = 1; cont <= 1000; cont++)
            {
                num = cont * 2;
                //ltbLista.Items.Add(num);
                pos = JogaNaLista(num, pos, max);
            }
            if(pos>1) ltbLista.Items.Add(linha); //Se tiver linha ainda não descarregada, descarregue 
        }

        private int JogaNaLista(int x, int pos, int limite)
        {
            linha = linha + "   " + x.ToString();
            if (pos == limite)
            {
                ltbLista.Items.Add(linha);
                pos = 1;
                linha = "";
            }
            else pos++;
            return pos;
        }

        private void GeraImpares()
        {
            int cont = 1, num;
            while (cont <= 1000)
            {
                num = cont * 2 - 1;
                ltbLista.Items.Add(num);
                cont++;
            }
        }

        private void GeraMultiplos(int numMult)
        {
            int cont = 1, num;
            do
            {
                num = cont * numMult;
                ltbLista.Items.Add(num);
                cont++;

            } while (cont <= 1000);
        }
        private void bntSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void rdbPares_CheckedChanged(object sender, EventArgs e)
        {
            txbMultiplo.Text = "";
            txbMultiplo.Visible = false;
            ltbLista.Items.Clear();
        }

        private void rdbImpares_CheckedChanged(object sender, EventArgs e)
        {
            txbMultiplo.Text = "";
            txbMultiplo.Visible = false;
            ltbLista.Items.Clear();
        }

        private void rdbMultiplo_CheckedChanged(object sender, EventArgs e)
        {
            txbMultiplo.Visible = true;
            ltbLista.Items.Clear();
        }

        private void txbMultiplo_TextChanged(object sender, EventArgs e)
        {
            ltbLista.Items.Clear();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            rdbPares.Checked = rdbImpares.Checked = rdbMultiplo.Checked = false;
            ltbLista.Items.Clear();
            txbMultiplo.Clear();
            txbMultiplo.Visible = false;
        }
    }
}
