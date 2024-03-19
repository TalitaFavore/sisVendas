using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisVendas.Model
{
    internal class modeloCliente
    {
        private long cpf;
        private String nomeCliente;
        private String rg;
        private DateTime nascimento;
        private String endereco;
        private String telefone;
        private int idCidade;

        #region Cpf
        public long Cpf
        {
            get => cpf;
            set => cpf = value;
        }
        #endregion

        #region NomeCliente
        public String NomeCliente
        {
            get => nomeCliente;
            set => nomeCliente = value;
        }
        #endregion

        #region Rg
        public String Rg
        {
            get => rg;
            set => rg = value;
        }
        #endregion

        #region Nascimento
        public DateTime Nascimento
        {
            get => nascimento;
            set => nascimento = value;
        }
        #endregion

        #region Endereco
        public String Endereco
        {
            get => endereco;
            set => endereco = value;
        }
        #endregion

        #region Telefone
        public string Telefone
        {
            get => telefone;
            set => telefone = value;
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
