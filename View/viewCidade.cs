﻿using System;
using System.Windows.Forms;
using SisVendas.Controller;
using SisVendas.Model;
using Npgsql;
using SisVendas1.Controller;

namespace SisVendas1.View
{
    public partial class viewCidade : Form
    {
        public viewCidade()
        {
            InitializeComponent();
        }

        private void novaCidade(object sender, EventArgs e)
        {
            modeloCidade mCidade = new modeloCidade();
            controllerCidade cCidade = new controllerCidade();
            if (validarFormCidade())
            {
            //armazenar os dados do FORM nos atributos
            mCidade.NomeCidade = textBox1.Text.ToUpper();

            //enviar os dados para o BD (método de cadastro)
            string res = cCidade.novaCidade(mCidade);

            MessageBox.Show(res);

            }
            else
            {
                MessageBox.Show("Por favor, preencha todos os campos.", "Campos vazios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private bool validarFormCidade()
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

        private void limparCidade(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void fechaForm(object sender, EventArgs e)
        {
                this.Dispose();
        }
    }
}
