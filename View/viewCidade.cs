using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

            //armazenar os dados do FORM nos atributos
            mCidade.NomeCidade = textBox1.Text.ToUpper();

            //enviar os dados para o BD (método de cadastro)
            string res = cCidade.novaCidade(mCidade);

            MessageBox.Show(res);
        }
    }
}
