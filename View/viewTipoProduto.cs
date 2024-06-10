using SisVendas.Model;
using SisVendas1.Controller;
using System;
using System.Windows.Forms;

namespace SisVendas1.View
{
    public partial class viewTipoProduto : Form
    {
        public viewTipoProduto()
        {
            InitializeComponent();
        }
        private void novoTipo(object sender, EventArgs e)
        {
            modeloTipoProduto mTipoProduto = new modeloTipoProduto();
            controllerTipoProduto cTipoProduto = new controllerTipoProduto();

            if (validarFormTipo())
            {
                mTipoProduto.NomeTipo = textBox1.Text.ToUpper();

                string res = cTipoProduto.novoTipo(mTipoProduto);

                MessageBox.Show(res);
            }
            else
            {
                MessageBox.Show("Por favor, preencha todos os campos.", "Campos vazios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private bool validarFormTipo()
        {
            // Verifica se todos os campos estão preenchidos
            if (String.IsNullOrWhiteSpace(textBox1.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(textBox1, "Preencha o Campo");
                textBox1.Focus();
                return false;
            }
            else
            {
                errorProvider1.Clear();
                return true;
            }
        }

        private void limparFormTipo(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void fechaForm(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
