using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisVendas.Model
{
    internal class modeloItensVenda
    {
        private int idVenda;
        private String idProduto;
        private int quantidade;
        private decimal valorTotal;

        #region IdVenda
        public int IdVenda
        {
            get => idVenda;
            set => idVenda = value;
        }
        #endregion

        #region IdProduto
        public String IdProduto
        {
            get => idProduto;
            set => idProduto = value;
        }
        #endregion

        #region Quantidade
        public int Quantidade
        {
            get => quantidade;
            set => quantidade = value;
        }
        #endregion

        #region ValorTotal
        public decimal ValorTotal
        {
            get => valorTotal;
            set => valorTotal = value;
        }
        #endregion
    }
}
