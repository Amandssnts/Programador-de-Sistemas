using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formulariosimples
{
    public partial class frmFormularioSimples : Form
    {
        public frmFormularioSimples()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            int numeroCadastro;
            string nomeUsuario;
            DateTime dataNascimento;
            string cidade;
            bool generoF;
            bool generoM;
            bool generoNB;

            //VALIDAÇÃO DE CAMPOS OBRIGATÓRIOS
            if (string.IsNullOrWhiteSpace(txtNumeroCadastro.Text))
            {
                MessageBox.Show("Por favor, preencha o número de cadastro.");
                return; //INTERROMPE A EXECUÇÃO DO CÓDIGO CASO O CAMPO ESTEJA VAZIO.
            }
            if (string.IsNullOrWhiteSpace(txtNomeCompleto.Text))
            {
                MessageBox.Show("Por favor, preencha o nome completo. ");
                return;
            }
            //VALIDAÇÃO DA DATA DE NASCIMENTO.
            dataNascimento = dateTimePicker1.Value.Date;

            //VERIFICA SE A DATA ÉPOSTERIOR OU IGUAL À DATA ATUAL.
            if (dataNascimento >= DateTime.Now.Date) //COMPARA COM A DATA ATUAL A SEM HORA.
            {
                MessageBox.Show("Por favor, verifique a data de nascimento. ");
                return;
            }

            if (comboBoxCidade.SelectedItem == null)
            {
                MessageBox.Show("Por favor, selecione a cidade. ");
                return;
            }
            if (!rbFemino.Checked && !rbMasculino.Checked && !rbNaoBinario.Checked)
            {
                MessageBox.Show("Por favor, selecione o gênero.");
                return;
                
            }

            //AGORA, CASO TODOS OS CAMPOS ESTEJAM PREENCHIDOS, A VALIDAÇÃO PROSSEGUE.
            numeroCadastro = Convert.ToInt32(txtNumeroCadastro.Text);
            nomeUsuario = txtNomeCompleto.Text;
            cidade = comboBoxCidade.Text;
            generoF = rbFemino.Checked;
            generoM = rbMasculino.Checked;
            generoNB = rbNaoBinario.Checked;

            //FORMATAR A DATA PARA EXIBIR APENAS A DATA (SEM HORA)
            string dataFormatada = dataNascimento.ToString("dd/MM/yyyy");

            //DETERMINAR O GÊNERO SELECIONADO.

            string generoSelecionado = "Não informado"; //CASO NENHUM GÊNERO SEJA SELECIONADO.
            if (generoF)
                generoSelecionado = "Feminino";

            else if (generoM)
                generoSelecionado = "Masculino";

            else if (generoNB)
                generoSelecionado = "Não Binário";

            //EXIBIR AS INFORMAÇÕES EM MENSSAGEBOX
            MessageBox.Show("Número Cadastro: " + numeroCadastro);
            MessageBox.Show("Nome: " + nomeUsuario);
            MessageBox.Show("Data nascimento; " + dataFormatada);
            MessageBox.Show("Cidade: " + cidade);
            MessageBox.Show("Gênero: " + generoSelecionado);


        }


        private void txtNumeroCadastro_Click(object sender, EventArgs e)
        {
            //LIMPA O CONTEÚDO DO TEXTBOX QUANDO O USUÁRIO CLICAR NELE.
            if(txtNumeroCadastro.Text == "Número Cadastro")
            {
                txtNumeroCadastro.Text = "";
            }
        }

        private void txtNomeCompleto_Click(object sender, EventArgs e)
        {
            //LIMPA O CONTEÚDO DO TEXTBOX QUANDO O USUÁRIO CLICAR NELE.
            if(txtNomeCompleto.Text == "Insira o seu nome completo")
            {
                txtNomeCompleto.Text = "";
            }  
        }
    }
}
