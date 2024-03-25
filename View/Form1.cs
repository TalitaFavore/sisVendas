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

        private void carregarPrincipal(object sender, EventArgs e)
        {

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
    }
}
