using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisVendas.Model
{
    internal class modeloVenda
    {
        private int idVenda;
        private long cpfCliente;
        private DateTime dataVenda;
        private float totalVenda;

        #region IdVenda
        public int IdVenda
        {
            get => idVenda;
            set => idVenda = value;
        }
        #endregion

        #region CpfCliente
        public long CpfCliente
        {
            get => cpfCliente;
            set => cpfCliente = value;
        }
        #endregion

        #region DataVenda
        public DateTime DataVenda
        {
            get => dataVenda;
            set => dataVenda = value;
        }
        #endregion

        #region TotalVenda
        public float TotalVenda
        {
            get => totalVenda;
            set => totalVenda = value;
        }
        #endregion
    }
}
