using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
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


            cadastro cad = new cadastro();

            string tipo2;
            string regime;
            string empresa;

            cad.Cnpj = tx_cnpj.Text;
            cad.Razao = tx_razaosocial.Text;
            cad.NomeFantasia = tx_nomefantasia.Text;
            cad.Situacao = tx_situacaocadastral.Text;
            cad.DataAtividade = tx_atividade.Text;
            cad.Telefone = tx_telefone.Text;
            cad.Estado = tx_completo.Text;
            cad.Bairro = tx_bairro.Text;
            cad.Rua = tx_rua.Text;
            cad.Natureza = tx_juridica.Text;
            cad.NomeProprietario = tx_proprietario.Text;
            cad.Cpf = tx_cpf.Text;

            if (tx_nacional.Checked == true)
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
            else if (tx_grande.Checked == true)
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

            if (Validar())
            {
                MessageBox.Show("Cadastro realizado com sucesso!!!");
                MessageBox.Show($"cnpj:{cad.Cnpj} \n razao social é:{cad.Razao} \n nome fantasia:{cad.NomeFantasia}\n situacao cadastral:{cad.Situacao}\n +" +
                    $" regime tributario:{regime}\n data atividade {cad.DataAtividade}\n telefone:{cad.Telefone}\n estado:{cad.Estado}\n bairro:{cad.Bairro} +" +
                    $" rua:{cad.Rua}\n tipo:{tipo2}\n empresa:{empresa}\n natureza:{cad.Natureza}\n nome proprietario{cad.NomeProprietario}\n cpf{cad.Cpf}" +
                    $" ");
            }
            else
            {
                MessageBox.Show("Preencha todos os campos!");
            }

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

        public bool Validar()
        {
            bool validacao;

            if (tx_nomefantasia.Text == "")
            {
                validacao = false;
            }
            else if (tx_atividade.Text == "")
            {
                validacao = false;
            }
            else if (tx_situacaocadastral.Text == "")
            {
                validacao = false;
            }
            else if (tx_telefone.Text == "")
            {
                validacao = false;
            }
            else if (tx_social.Text == "")
            {
                validacao = false;
            }
            else if (tx_completo.Text == "")
            {
                validacao = false;
            }

            else if (tx_bairro.Text == "")
            {
                validacao = false;
            }
            else if (tx_rua.Text == "")
            {
                validacao = false;
            }
            else if (tx_juridica.Text == "")
            {
                validacao = false;
            }
            else if (tx_completo.Text == "")
            {
                validacao = false;
            }

            else if (tx_proprietario.Text == "")
            {
                validacao = false;
            }
            else if (tx_cpf.Text == "")
            {
                validacao = false;
            }

            else
            {
                validacao = true;
            }

            return validacao;
        }
    }
}
