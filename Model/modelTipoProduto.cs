using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisVendas.Model
{
    internal class modeloTipoProduto
    {
        private int idTipo;
        private String nomeTipo;

        #region IdTipo
        public int IdTipo
        {
            get => idTipo;
            set => idTipo = value;
        }
        #endregion

        #region NomeTipo
        public String NomeTipo
        {
            get => nomeTipo;
            set => nomeTipo = value;
        }
        #endregion
    }
}
