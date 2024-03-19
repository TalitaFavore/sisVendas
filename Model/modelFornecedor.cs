using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisVendas.Model
{
    internal class modeloFornecedor
    {
        private String cnpj;
        private String nomeFornecedor;
        private String enderecoFornecedor;
        private String telefoneFornecedor;
        private String emailFornecedor;
        private int idCidade;

        #region Cnpj
        public String Cnpj
        {
            get => cnpj;
            set => cnpj = value;
        }
        #endregion

        #region NomeFornecedor
        public String NomeFornecedor
        {
            get => nomeFornecedor;
            set => nomeFornecedor = value;
        }
        #endregion

        #region EnderecoFornecedor
        public String EnderecoFornecedor
        {
            get => enderecoFornecedor;
            set => enderecoFornecedor = value;
        }
        #endregion

        #region TelefoneFornecedor
        public String TelefoneFornecedor
        {
            get => telefoneFornecedor;
            set => telefoneFornecedor = value;
        }
        #endregion

        #region EmailFornecedor
        public String EmailFornecedor
        {
            get => emailFornecedor;
            set => emailFornecedor = value;
        }
        #endregion

        #region IdCidade
        public int IdCidade
        {
            get => idCidade;
            set => idCidade = value;
        }
        #endregion
    }
}
