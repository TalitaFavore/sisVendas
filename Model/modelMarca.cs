using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisVendas.Model
{
    internal class modeloMarca
    {
        private int idMarca;
        private String nomeMarca;

        #region IdMarca
        public int IdMarca
        {
            get => idMarca;
            set => idMarca = value;
        }
        #endregion

        #region NomeMarca
        public String NomeMarca
        {
            get => nomeMarca;
            set => nomeMarca = value;
        }
        #endregion
    }
}
