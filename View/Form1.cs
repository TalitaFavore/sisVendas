using Npgsql;
using SisVendas.Controller;
using SisVendas.Model;
using SisVendas1.Controller;
using SisVendas1.View;
using System;
using System.Data;
using System.Drawing.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace SisVendas1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /* Variáveis globais para venda */
        decimal preco = 0, total = 0;
        int quant = 0, novaQuant = 0;

        private void carregaPrincipal(object sender, EventArgs e)
        {
            //evento load do form 1
            carregaComboboxCidade();
            carregaComboboxTipoProduto();
            carregaComboboxMarca();
            carregaComboboxFornecedor();
        }

        //NOVO (VINCULAR TABS)
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
        private void novoProduto(object sender, EventArgs e)
        {
            tabControl1.Visible = true;
            abaNovoProduto.Parent = tabControl1;
            tabControl1.SelectedTab = abaNovoProduto;

            abaNovoCliente.Parent = null;
            abaNovaVenda.Parent = null;
            abaBuscaCliente.Parent = null;
            abaBuscaProduto.Parent = null;
            abaListarVendas.Parent = null;
        }
        private void novaVenda(object sender, EventArgs e)
        {
            tabControl1.Visible = true;
            abaBuscaCliente.Parent = tabControl1;
            abaBuscaProduto.Parent = tabControl1;
            abaNovaVenda.Parent = tabControl1;
            tabControl1.SelectedTab = abaNovoProduto;

            abaNovoCliente.Parent = null;
            abaNovoProduto.Parent = null;
            abaListarVendas.Parent = null;
        }

        //LISTAGEM (VINCULAR TABS)
        private void consultaCliente(object sender, EventArgs e)
        {
            /*Habilita somente a aba de busca de clientes*/

            tabControl1.Visible = true;

            abaBuscaCliente.Parent = tabControl1;
            tabControl1.SelectedTab = abaBuscaCliente;

            abaNovoCliente.Parent = null;
            abaNovoProduto.Parent = null;
            abaNovaVenda.Parent = null;
            abaBuscaProduto.Parent = null;
            abaListarVendas.Parent = null;

        }
        private void consultaProduto(object sender, EventArgs e)
        {
            /*Habilita somente a aba de busca de clientes*/

            tabControl1.Visible = true;

            abaBuscaProduto.Parent = tabControl1;
            tabControl1.SelectedTab = abaBuscaProduto;

            abaNovoCliente.Parent = null;
            abaNovoProduto.Parent = null;
            abaNovaVenda.Parent = null;
            abaBuscaCliente.Parent = null;
            abaListarVendas.Parent = null;

        }

        //CADASTRO
        private void cadastrarCliente()
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
        private void cadastrarProduto()
        {
            modelProduto mProduto = new modelProduto();
            controllerProduto cProduto = new controllerProduto();

            if (validarFormProduto())
            {
                mProduto.CodigoBarras = maskedTextBox3.Text;
                mProduto.NomeProduto = textBox4.Text;
                mProduto.Validade = dateTimePicker2.Value;
                mProduto.PrecoCusto = Convert.ToDecimal(textBox5.Text);
                mProduto.PrecoVenda = Convert.ToDecimal(textBox6.Text);
                mProduto.Descricao = textBox7.Text;
                mProduto.Quantidade = Convert.ToInt32(textBox8.Text);
                mProduto.IdTipo = Convert.ToInt32(comboTipo_Produto.SelectedValue);
                mProduto.IdMarca = Convert.ToInt32(comboMarca_Produto.SelectedValue);
                mProduto.Cnpj = Convert.ToString(comboFornecedor_Produto.SelectedValue);
                string res = cProduto.cadastroProduto(mProduto);
                MessageBox.Show(res);
            }
        }

        //VALIDAÇÃO
        private bool validarFormCliente()
        {
            // Verifica se todos os campos estão preenchidos
            if (String.IsNullOrWhiteSpace(textBox1.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(textBox1, "Preencha o Campo");
                textBox1.Focus();
                return false;
            }
            else if (String.IsNullOrWhiteSpace(maskedTextBox1.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(maskedTextBox1, "Preencha o Campo");
                maskedTextBox1.Focus();
                return false;
            }
            else if (String.IsNullOrWhiteSpace(textBox2.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(textBox2, "Preencha o Campo");
                textBox2.Focus();
                return false;
            }
            else if (String.IsNullOrWhiteSpace(textBox3.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(textBox3, "Preencha o Campo");
                textBox3.Focus();
                return false;
            }
            else if (String.IsNullOrWhiteSpace(maskedTextBox2.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(maskedTextBox2, "Preencha o Campo");
                maskedTextBox2.Focus();
                return false;
            }
            else
            {
                errorProvider1.Clear();
                return true;
            }
        }
        private bool validarFormProduto()
        {
            // Verifica se todos os campos estão preenchidos
            if (String.IsNullOrWhiteSpace(textBox4.Text))
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
            else if (String.IsNullOrWhiteSpace(textBox5.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(textBox5, "Preencha o Campo");
                textBox5.Focus();
                return false;
            }
            else if (String.IsNullOrWhiteSpace(textBox6.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(textBox6, "Preencha o Campo");
                textBox6.Focus();
                return false;
            }
            else if (String.IsNullOrWhiteSpace(textBox8.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(textBox8, "Preencha o Campo");
                textBox8.Focus();
                return false;
            }
            else if (String.IsNullOrWhiteSpace(textBox7.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(textBox7, "Preencha o Campo");
                textBox7.Focus();
                return false;
            }
            else
            {
                errorProvider1.Clear();
                return true;
            }
        }

        //SALVAR
        private void salvarCliente(object sender, EventArgs e)
        {
            if (validarFormCliente())
            {
                // Salvar o cadastro
                cadastrarCliente();
            }
            else
            {
                MessageBox.Show("Por favor, preencha todos os campos.", "Campos vazios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void salvarProduto(object sender, EventArgs e)
        {
            if (validarFormProduto())
            {
                // Salvar o cadastro
                cadastrarProduto();
            }
            else
            {
                MessageBox.Show("Por favor, preencha todos os campos.", "Campos vazios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //LIMPAR
        private void limparFormCliente(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            maskedTextBox1.Text = "";
            maskedTextBox2.Text = "";
        }
        private void limparFormProduto(object sender, EventArgs e)
        {
            textBox4.Text = "";
            maskedTextBox3.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
        }

        //FORMS
        private void frmCidade(object sender, LinkLabelLinkClickedEventArgs e)
        {
            viewCidade frmCidade = new viewCidade();
            frmCidade.ShowDialog();
        }
        private void frmTipo(object sender, LinkLabelLinkClickedEventArgs e)
        {
            viewTipoProduto frmTipo = new viewTipoProduto();
            frmTipo.ShowDialog();
        }
        private void frmMarca(object sender, LinkLabelLinkClickedEventArgs e)
        {
            viewMarca frmMarca = new viewMarca();
            frmMarca.ShowDialog();
        }
        private void frmFornecedor(object sender, LinkLabelLinkClickedEventArgs e)
        {
            viewFornecedor frmFornecedor = new viewFornecedor();
            frmFornecedor.ShowDialog();
        }

        //CARREGAR COMBOBOXS
        private void carregaComboboxCidade()
        {
            controllerCidade cCidade = new controllerCidade();
            NpgsqlDataReader dados = cCidade.listaCidade(); //tipo de dado que armaena o resultado de consultas no BD, não permite alteração, somente leitura

            DataTable cidade = new DataTable(); //armazena dados no formato de tabela
            cidade.Load(dados); //preenche o dataTable com os dados do dataReader

            comboCidade_cliente.DataSource = cidade; //propriedade DataSource = define qual é a forma dos dados que a combobox vai usar
            comboCidade_cliente.DisplayMember = "nomecidade"; //qual coluna vai ser exibida pela combobox
            comboCidade_cliente.ValueMember = "idcidade"; //qual coluna será usada como valor válido na combobox
        }
        private void carregaComboboxTipoProduto()
        {
            controllerTipoProduto cTipoProduto = new controllerTipoProduto();

            NpgsqlDataReader dados = cTipoProduto.listaTipoProduto();

            //DataTable - armazena dados no formato de tabela
            DataTable tipo = new DataTable();

            //preenche o dataTable com os dados do DataReader
            tipo.Load(dados);

            comboTipo_Produto.DataSource = tipo;

            //DisplayMember - define qual coluna será exibida na combobox
            comboTipo_Produto.DisplayMember = "nometipo";

            //ValueMember - define qual coluna será usada como valor válido na combobox 
            comboTipo_Produto.ValueMember = "idtipo";
        }
        private void carregaComboboxMarca()
        {
            controllerMarca cMarca = new controllerMarca();

            /* NpgsqlDataReader - tipo de dado que armazena o resultado
             de consultas (SELECT) no banco de dados */
            NpgsqlDataReader dados = cMarca.listaMarca();

            //DataTable - armazena dados no formato de tabela
            DataTable marca = new DataTable();

            //preenche o dataTable com os dados do DataReader
            marca.Load(dados);

            comboMarca_Produto.DataSource = marca;

            //DisplayMember - define qual coluna será exibida na combobox
            comboMarca_Produto.DisplayMember = "nomemarca";

            //ValueMember - define qual coluna será usada como valor válido na combobox 
            comboMarca_Produto.ValueMember = "idmarca";
        }
        private void carregaComboboxFornecedor()
        {
            controllerFornecedor cFornecedor = new controllerFornecedor();

            /* NpgsqlDataReader - tipo de dado que armazena o resultado
             de consultas (SELECT) no banco de dados */
            NpgsqlDataReader dados = cFornecedor.listaFornecedor();

            //DataTable - armazena dados no formato de tabela
            DataTable fornecedor = new DataTable();

            //preenche o dataTable com os dados do DataReader
            fornecedor.Load(dados);

            comboFornecedor_Produto.DataSource = fornecedor;

            //DisplayMember - define qual coluna será exibida na combobox
            comboFornecedor_Produto.DisplayMember = "nomefornecedor";

            //ValueMember - define qual coluna será usada como valor válido na combobox 
            comboFornecedor_Produto.ValueMember = "cnpj";
        }

        //ATUALIZAR COMBOBOXS
        private void atualizaComboboxCidade(object sender, EventArgs e)
        {
            carregaComboboxCidade();
        }
        private void atualizaComboboxTipo(object sender, EventArgs e)
        {
            carregaComboboxTipoProduto();
        }
        private void atualizaComboboxMarca(object sender, EventArgs e)
        {
            carregaComboboxMarca();
        }
        private void atualizaComboboxFornecedor(object sender, EventArgs e)
        {
            carregaComboboxFornecedor();
        }

        //FECHAR ABAS
        private void fechaAbaCliente(object sender, EventArgs e)
        {
            abaNovoCliente.Parent = null;
            tabControl1.SelectedTab = null;
            tabControl1.Visible = false;
        }
        private void fechaAbaProduto(object sender, EventArgs e)
        {
            abaNovoProduto.Parent = null;
            tabControl1.SelectedTab = null;
            tabControl1.Visible = false;
        }

        //LISTAGEM
        private void buscaCliente(object sender, EventArgs e)
        {
            /* Executa pesquisa de cliente*/

            modeloCliente mCliente = new modeloCliente();
            controllerCliente cCliente = new controllerCliente();
            NpgsqlDataReader cliente;

            if (!String.IsNullOrWhiteSpace(maskedTextBox5.Text))
            {
                if (radioNomeCliente.Checked)
                {
                    mCliente.NomeCliente = maskedTextBox5.Text + "%";
                    cliente = cCliente.pesqClienteNome(mCliente);
                    gridCliente(cliente); //metodo que preenche a grid com os dados do cliente
                }
                else if (radioClienteCPF.Checked)
                {
                    if (maskedTextBox5.Text.Length == 11)
                    {
                        mCliente.Cpf = long.Parse(maskedTextBox5.Text);
                        cliente = cCliente.pesqClienteCPF(mCliente);
                        gridCliente(cliente);
                    }
                }
                else
                {
                    cliente = null;
                    MessageBox.Show("Não foi possível realizar a consulta");
                }
            }
        }
        private void gridCliente(NpgsqlDataReader cliente)
        {
            //apaga as colunas do datagrid
            dataGridView1.Columns.Clear();

            //define a quantidade da coluna da grid igual ao da dataReader
            dataGridView1.ColumnCount = cliente.FieldCount; //propriedade do dataReader que conta quantas colunas o banco devolveu/a consulta retornou

            //definir os nomes das colunas da grid
            for (int i = 0; i < cliente.FieldCount; i++)
            {
                dataGridView1.Columns[i].Name = cliente.GetName(i);
            }

            string[] linha = new string[cliente.FieldCount];

            while (cliente.Read())
            {
                for (int i = 0; i < cliente.FieldCount; i++)
                {
                    linha[i] = cliente.GetValue(i).ToString();
                }

                dataGridView1.Rows.Add(linha);
            }
        }

        private void buscaProduto(object sender, EventArgs e)
        {
            /* Executa pesquisa de produto*/

            modelProduto mProduto = new modelProduto();
            controllerProduto cProduto = new controllerProduto();
            NpgsqlDataReader produto;

            if (!String.IsNullOrWhiteSpace(maskedTextBox4.Text))
            {
                if (radioNomeProduto.Checked)
                {
                    mProduto.NomeProduto = maskedTextBox4.Text + "%";
                    produto = cProduto.pesqProdutoNome(mProduto);
                    gridProduto(produto);
                }
                else if (radioProdutoBarras.Checked)
                {
                    if (maskedTextBox4.Text.Length == 11)
                    {
                        mProduto.CodigoBarras = maskedTextBox4.Text;
                        produto = cProduto.pesqProdutoCodigo(mProduto);
                        gridProduto(produto);
                    }
                }
                else
                {
                    produto = null;
                    MessageBox.Show("Não foi possível realizar a consulta");
                }
            }
        }
        private void gridProduto(NpgsqlDataReader produto)
        {
            //apaga as colunas do datagrid
            dataGridView2.Columns.Clear();

            //define a quantidade da coluna da grid igual ao da dataReader
            dataGridView2.ColumnCount = produto.FieldCount; //propriedade do dataReader que conta quantas colunas o banco devolveu/a consulta retornou

            //definir os nomes das colunas da grid
            for (int i = 0; i < produto.FieldCount; i++)
            {
                dataGridView2.Columns[i].Name = produto.GetName(i);
            }

            string[] linha = new string[produto.FieldCount];

            while (produto.Read())
            {
                for (int i = 0; i < produto.FieldCount; i++)
                {
                    linha[i] = produto.GetValue(i).ToString();
                }

                dataGridView2.Rows.Add(linha);
            }
        }

        private void buscaClienteVenda(object sender, KeyPressEventArgs e)
        {
            modeloCliente mCliente = new modeloCliente();
            controllerCliente cCliente = new controllerCliente();

            if (maskedTextBox6.Text.Length == 11)
            {
                if (e.KeyChar == 13)
                {
                    mCliente.Cpf = long.Parse(maskedTextBox6.Text);
                    NpgsqlDataReader cliente = cCliente.pesqClienteCPF(mCliente);

                    if (!cliente.HasRows)
                    {
                        MessageBox.Show("Cliente não encontrado!");
                    }
                    else
                    {
                        while (cliente.Read())
                        {
                            txbClienteVenda.Text = cliente.GetValue(0).ToString();
                        }
                    }
                }
            }
        }

        private void buscaProdutoVenda(object sender, KeyPressEventArgs e)
        {
                modelProduto mProduto = new modelProduto();
                controllerProduto cProduto = new controllerProduto();
                NpgsqlDataReader produto;

                if (e.KeyChar == 13)
                {
                    if (rbCodigoProdutoVenda.Checked)
                    {
                        mProduto.CodigoBarras = txbProdutoVenda.Text;
                        mProduto.NomeProduto = null;
                        produto = cProduto.pesquisaProdutoVendaCodigo(mProduto);
                    }
                    else
                    {
                        mProduto.NomeProduto = txbProdutoVenda.Text + "%";
                        mProduto.CodigoBarras = null;
                        produto = cProduto.pesquisaProdutoVendaNome(mProduto);
                    }

                    if (!produto.HasRows)
                    {
                        MessageBox.Show("Produto Não Encontrado");
                    }
                    else
                    {
                        gridProdutoVenda(produto);
                    }

                }
            }
        private void gridProdutoVenda(NpgsqlDataReader produto)
        {
            //apaga as colunas do datagrid
            dataGridView3.Columns.Clear();

            //define a quantidade da coluna da grid igual ao da dataReader
            dataGridView3.ColumnCount = produto.FieldCount; //propriedade do dataReader que conta quantas colunas o banco devolveu/a consulta retornou

            //definir os nomes das colunas da grid
            for (int i = 0; i < produto.FieldCount; i++)
            {
                dataGridView3.Columns[i].Name = produto.GetName(i);
            }

            string[] linha = new string[produto.FieldCount];

            while (produto.Read())
            {
                for (int i = 0; i < produto.FieldCount; i++)
                {
                    linha[i] = produto.GetValue(i).ToString();
                }

                dataGridView3.Rows.Add(linha);
            }
        }

        private void maskNome(object sender, EventArgs e)
        {
            maskedTextBox5.Mask = null;
        }
        private void maskCPF(object sender, EventArgs e)
        {
            maskedTextBox5.Mask = "000,000,000-00";
        }

        //Eventos da venda
        private void removerItem(object sender, EventArgs e)
        {
            if (dataGridView4.RowCount > 0)
            {
                DialogResult confirm = MessageBox.Show ("Remover item", 
                    "Deseja remover este Item?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (confirm == DialogResult.Yes)
                {
                    novaQuant = Convert.ToInt32(dataGridView4.CurrentRow.Cells[3].Value);
                    preco = decimal.Parse(dataGridView4.CurrentRow.Cells[2].Value.ToString());

                    total = total - (novaQuant * preco);
                    lbTotalItens.Text = total.ToString();
                    lbTotalVenda.Text = total.ToString();
                    dataGridView4.Rows.Remove(dataGridView4.CurrentRow);
                }
            }
        }
        private void calculaDesconto(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                total = decimal.Parse(lbTotalItens.Text);
                decimal desc = decimal.Parse(txbDesc.Text) / 100;
                decimal totalVenda = total - (total* desc);
                lbTotalVenda.Text = totalVenda.ToString();
            }
        }
        private void atualizaTotal(object sender, DataGridViewCellEventArgs e)
        {
            novaQuant = Convert.ToInt32(dataGridView4.CurrentRow.Cells[3].Value);
            preco = decimal.Parse(dataGridView4.CurrentRow.Cells[2].Value.ToString());

            if (novaQuant > 0)
            {
                if (novaQuant > quant)
                {
                    total = total + ((novaQuant - quant) * preco);
                }
                if (novaQuant < quant)
                {
                    total = total - ((quant - novaQuant) * preco);
                }

                quant = novaQuant;
                lbTotalItens.Text = total.ToString();
                lbTotalVenda.Text = total.ToString();
            }
            else
            {
                dataGridView4.CurrentRow.Cells[3].Value = quant.ToString();
            }
            novaQuant = 0;
        }
        private void insertItensVenda(object sender, EventArgs e)
        {
            modeloVenda mVenda = new modeloVenda();
            controllerVenda cVenda = new controllerVenda();

            modeloItensVenda mItens = new modeloItensVenda();
            controllerItensVenda cItens = new controllerItensVenda();

            if (!String.IsNullOrEmpty(txbClienteVenda.Text))
            {
                if (dataGridView4.Rows.Count > 0)
                {
                    /*dados do cliente edata da venda*/
                    mVenda.CpfCliente = long.Parse(maskedTextBox6.Text);
                    mVenda.DataVenda = DateTime.Now;
                    //mVenda.TotalVenda = float.Parse(lbTotalVenda.Text);

                    /*insere uma nova venda*/
                    NpgsqlDataReader venda = cVenda.novaVenda(mVenda);

                    /*verifica se a venda não é nula*/
                    if (venda != null && venda.Read())
                    {
                        mItens.IdVenda = Convert.ToInt32(venda.GetValue(0));
                        //MessageBox.Show(mItens.IdVenda.ToString());

                        /*percorre a grid de itens e insere no banco*/
                        for (int l = 0; l < dataGridView4.RowCount; l++)
                        {
                            var idProduto = dataGridView4.Rows[l].Cells[0].Value;
                            var quantidade = dataGridView4.Rows[l].Cells[3].Value;
                            var valorUnitario = dataGridView4.Rows[l].Cells[2].Value;

                            /* Verifica se os valores não são nulos */
                            if (idProduto != null && quantidade != null && valorUnitario != null)
                            {
                                mItens.IdProduto = idProduto.ToString();
                                mItens.Quantidade = Convert.ToInt32(quantidade);
                                mItens.ValorTotal = mItens.Quantidade * decimal.Parse(valorUnitario.ToString());

                                MessageBox.Show(cItens.adicionaItensVenda(mItens));
                            }
                            else
                            {
                                MessageBox.Show("Dados do item inválidos.");
                            }
                        }

                        mVenda.IdVenda = mItens.IdVenda;
                        mVenda.TotalVenda = decimal.Parse(lbTotalVenda.Text);
                        MessageBox.Show(cVenda.atualizaTotalVenda(mVenda));
                    }
                    else
                    {
                        MessageBox.Show("Erro ao inserir a venda.");
                    }
                }
                else
                {
                    MessageBox.Show("Não há itens na venda!");
                }
            }
            else
            {
                MessageBox.Show("Nenhum cliente foi selecionado!");
            }
        }
        private void selecionaLinha(object sender, DataGridViewCellEventArgs e)
        {
            /*Salva a quantidade atual de um item selecionado*/
            quant = Convert.ToInt32(dataGridView4.CurrentRow.Cells[3].Value);
        }
        private void addItemVenda(object sender, DataGridViewCellEventArgs e)
        {
            /*Adiciona item a venda*/

            string[] produto = new string[4];
            produto[0] = dataGridView3.CurrentRow.Cells[0].Value.ToString(); //cod
            produto[1] = dataGridView3.CurrentRow.Cells[1].Value.ToString(); //nome
            produto[2] = dataGridView3.CurrentRow.Cells[2].Value.ToString(); //preço
            produto[3] = "1"; //qntd

            /*Calcula e atualiza o total*/

            preco = decimal.Parse(produto[2]);
            quant = Convert.ToInt32(produto[3]);
            total = decimal.Parse(lbTotalItens.Text) + (preco * quant);

            dataGridView4.Rows.Add(produto);
            lbTotalItens.Text = total.ToString();
            lbTotalVenda.Text = total.ToString();
        }
    }
    }



