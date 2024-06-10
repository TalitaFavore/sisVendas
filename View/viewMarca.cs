using SisVendas.Model;
using SisVendas1.Controller;
using System;
using System.Windows.Forms;

namespace SisVendas1.View
{
    public partial class viewMarca : Form
    {
        public viewMarca()
        {
            InitializeComponent();
        }
        private void novaMarca(object sender, EventArgs e)
        {
            modeloMarca mMarca = new modeloMarca();
            controllerMarca cMarca = new controllerMarca();
            if (validarFormMarca())
            {
                //armazenar os dados do FORM nos atributos
                mMarca.NomeMarca = textBox1.Text.ToUpper();

                //envia os dados para o banco (método de cadastro)
                string res = cMarca.novaMarca(mMarca);

                MessageBox.Show(res);
            }
        }

        private bool validarFormMarca()
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

        private void limparFormMarca(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void fechaForm(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}

