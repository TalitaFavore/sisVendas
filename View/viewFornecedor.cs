using Npgsql;
using SisVendas.Model;
using SisVendas1.Controller;
using SisVendas.Controller;
using System;
using System.Data;
using System.Windows.Forms;

namespace SisVendas1.View
{
    public partial class viewFornecedor : Form
    {
        public viewFornecedor()
        {
            InitializeComponent();
        }

        private void cadastrarFornecedor(object sender, EventArgs e)
        {
            modeloFornecedor mFornecedor = new modeloFornecedor();
            controllerFornecedor cFornecedor = new controllerFornecedor();

            if (validarFormFornecedor())
            {
                // Salvar o cadastro
                mFornecedor.Cnpj = maskedTextBox4.Text;
                mFornecedor.NomeFornecedor = textBox6.Text;
                mFornecedor.Endereco = textBox5.Text;
                mFornecedor.IdCidade = Convert.ToInt32(comboCidade_fornecedor.SelectedValue);
                mFornecedor.Email = textBox4.Text;
                mFornecedor.Telefone = maskedTextBox3.Text;

                string res = cFornecedor.cadastroFornecedor(mFornecedor);
                MessageBox.Show(res);
            }
            else
            {
                MessageBox.Show("Por favor, preencha todos os campos.", "Campos vazios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private bool validarFormFornecedor()
        {
            // Verifica se todos os campos estão preenchidos
            if (String.IsNullOrWhiteSpace(textBox6.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(textBox6, "Preencha o Campo");
                textBox6.Focus();
                return false;
            }
            else if (String.IsNullOrWhiteSpace(maskedTextBox4.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(maskedTextBox4, "Preencha o Campo");
                maskedTextBox4.Focus();
                return false;
            }
            else if (String.IsNullOrWhiteSpace(textBox5.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(textBox5, "Preencha o Campo");
                textBox5.Focus();
                return false;
            }
            else if (String.IsNullOrWhiteSpace(textBox4.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(textBox4, "Preencha o Campo");
                textBox4.Focus();
                return false;
            }
            else if (String.IsNullOrWhiteSpace(maskedTextBox3.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(maskedTextBox3, "Preencha o Campo");
                maskedTextBox3.Focus();
                return false;
            }
            else
            {
                errorProvider1.Clear();
                return true;
            }
        }
        private void limparFornecedor(object sender, EventArgs e)
        {
            textBox6.Text = "";
            maskedTextBox4.Text = "";
            textBox5.Text = "";
            textBox4.Text = "";
            maskedTextBox3.Text = "";
        }
        private void frmCidade(object sender, LinkLabelLinkClickedEventArgs e)
        {
            viewCidade frmCidade = new viewCidade();
            frmCidade.ShowDialog();
        }
        private void carregaComboboxCidade()
        {
            controllerCidade cCidade = new controllerCidade();
            NpgsqlDataReader dados = cCidade.listaCidade(); //tipo de dado que armaena o resultado de consultas no BD, não permite alteração, somente leitura

            DataTable cidade = new DataTable(); //armazena dados no formato de tabela
            cidade.Load(dados); //preenche o dataTable com os dados do dataReader

            comboCidade_fornecedor.DataSource = cidade; //propriedade DataSource = define qual é a forma dos dados que a combobox vai usar
            comboCidade_fornecedor.DisplayMember = "nomecidade"; //qual coluna vai ser exibida pela combobox
            comboCidade_fornecedor.ValueMember = "idcidade"; //qual coluna será usada como valor válido na combobox
        }
        private void atualizaComboboxCidade(object sender, EventArgs e)
        {
            carregaComboboxCidade();
        }

        private void fechaForm(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
