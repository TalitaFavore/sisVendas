using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisVendas.Model
{
    internal class modeloProduto
    {
        private String codigoBarras;
        private String nomeProduto;
        private DateTime validade;
        private float precoCusto;
        private float precoVenda;
        private String descricao;
        private int quantidade;
        private int idTipo;

        #region CodigoBarras
        public String CodigoBarras
        {
            get => codigoBarras;
            set => codigoBarras = value;
        }
        #endregion

        #region NomeProduto
        public String NomeProduto
        {
            get => nomeProduto;
            set => nomeProduto = value;
        }
        #endregion

        #region Validade
        public DateTime Validade
        {
            get => validade;
            set => validade = value;
        }
        #endregion

        #region PrecoCusto
        public float PrecoCusto
        {
            get => precoCusto;
            set => precoCusto = value;
        }
        #endregion

        #region PrecoCusto
        public float PrecoVenda
        {
            get => precoVenda;
            set => precoVenda = value;
        }
        #endregion

        #region Descricao
        public string Descricao
        {
            get => descricao;
            set => descricao = value;
        }
        #endregion

        #region Quantidade
        public int Quantidade
        {
            get => quantidade;
            set => quantidade = value;
        }
        #endregion

        #region IdTipo
        public int IdTipo
        {
            get => idTipo;
            set => idTipo = value;
        }
        #endregion
    }


}
