using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cadastro_de_empresa___PWS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void CNPJ_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string tipo2;
            string cpnj = tx_cnpj.Text;
            string razao = tx_razaosocial.Text;
            string nomefantasia = tx_nomefantasia.Text;
            string situacao = tx_situacaocadastral.Text;
            string regime;
            string dataatividade = tx_atividade.Text;
            string telefone = tx_telefone.Text;
            string estado = tx_completo.Text;
            string bairro = tx_bairro.Text;
            string rua = tx_rua.Text;
            string empresa;
            string natureza = tx_juridica.Text;
            string nomepropriedade = tx_proprietario.Text;
            string cpf = tx_cpf.Text;

            if(tx_nacional.Checked == true)
            {
               regime = tx_nacional.Text;
            }
            else if (tx_presumido.Checked == true)
            {
                regime = tx_presumido.Text;
            }
            else 
            {
                regime = tx_nomereal.Text;
            }

            if (tx_grande.Checked == true)
            {
                empresa = tx_grande.Text;
            }
            else if (tx_pequeno.Checked == true)
            {
                empresa = tx_grande.Text;
            }
            else 
            {
                 empresa = tx_medio.Text;
            }

            if (tx_matriz.Checked == true)
            {
                tipo2 = tx_matriz.Text;
            }
            else
            {
                tipo2 = tx_filial.Text;
            }
            MessageBox.Show("Cadastro realizado com sucesso!!!");
            MessageBox.Show($"cnpj:{CNPJ} \n razao social é:{razao} \n nome fantasia:{nomefantasia}\n situacao cadastral:{situacao}\n +" +
                $" regime tributario:{regime}\n data atividade {dataatividade}\n telefone:{telefone}\n estado:{estado}\n bairro:{bairro} +" +
                $" rua:{rua}\n tipo:{tipo2}\n empresa:{empresa}\n natureza:{natureza}\n nome proprietario{nomepropriedade}\n cpf{cpf}" +
                $" ");
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void tx_razaosocial_TextChanged(object sender, EventArgs e)
        {

        }

        private void tx_cnpj_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
