using Npgsql;
using SisVendas.Model;
using SisVendas1.Controller;
using SisVendas1.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SisVendas1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void novoCliente(object sender, EventArgs e)
        {
            tabControl1.Visible = true; //Deixa visível um tabControl

            abaNovoCliente.Parent = tabControl1; //Vincula um tabPage a um tabControl
            tabControl1.SelectedTab = abaNovoCliente;

            abaNovoProduto.Parent = null; //Desvincula um tabPage de um tabControl
            abaNovaVenda.Parent = null;
            abaBuscaCliente.Parent = null;
            abaBuscaProduto.Parent = null;
            abaListarVendas.Parent = null;

        }

        private void frmCidade(object sender, LinkLabelLinkClickedEventArgs e)
        {
            viewCidade frmCidade = new viewCidade();
            frmCidade.ShowDialog();
        }

        private void carregaPrincipal(object sender, EventArgs e)
        {
            //evento load do form 1
            carregaCombobox();

        }

        /* MÉTODOS DE CONFIGURAÇÃO DOS COMPONENTES DO FORM */

        private void carregaCombobox()
        {
            controllerCidade cCidade = new controllerCidade();
            NpgsqlDataReader dados = cCidade.listaCidade(); //tipo de dado que armaena o resultado de consultas no BD, não permite alteração, somente leitura

            DataTable cidade = new DataTable(); //armazena dados no formato de tabela
            cidade.Load(dados); //preenche o dataTable com os dados do dataReader

            comboCidade_cliente.DataSource = cidade; //propriedade DataSource = define qual é a forma dos dados que a combobox vai usar
            comboCidade_cliente.DisplayMember = "nomecidade"; //qual coluna vai ser exibida pela combobox
            comboCidade_cliente.ValueMember = "idcidade"; //qual coluna será usada como valor válido na combobox



        }

        private void atualizaCombobox(object sender, EventArgs e)
        {
            carregaCombobox();
        }

        private void cadastrarCliente(object sender, EventArgs e)
        {
            modeloCliente mCliente = new modeloCliente();           
            controllerCliente cCliente = new controllerCliente();

            mCliente.Cpf = Convert.ToInt64(maskedTextBox1.Text);
            mCliente.NomeCliente = textBox1.Text;
            mCliente.Rg = textBox2.Text;
            mCliente.Endereco = textBox3.Text;
            mCliente.IdCidade = Convert.ToInt32(comboCidade_cliente.SelectedValue);
            mCliente.Nascimento = dateTimePicker1.Value;
            mCliente.Telefone = maskedTextBox2.Text;

            string res = cCliente.cadastroCliente(mCliente);
            MessageBox.Show(res);

        }
    }
}
