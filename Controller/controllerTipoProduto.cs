using Npgsql;
using SisVendas.Controller;
using SisVendas.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisVendas1.Controller
{
    internal class controllerTipoProduto
    {
        public string novoTipo(modeloTipoProduto mTipoProduto)
        {
            string sql = "insert into tipoproduto(nometipo) values(@nometipo)"; 
            Connection conexao = new Connection(); 
            NpgsqlConnection conn = conexao.conectaPG(); 
            NpgsqlCommand comm = new NpgsqlCommand(sql, conn); 

            try
            {
                comm.Parameters.AddWithValue("@nometipo", mTipoProduto.NomeTipo);

                //executar o comando SQL no BD
                comm.ExecuteNonQuery(); //Usar quando não retorna dados -> insert, update e delete
                return "Tipo de produto cadastrado com sucesso!";
            }
            catch (NpgsqlException erro)
            {
                /* return erro.ToString(); //retorna erro do BD */
                return "Erro ao cadastrar tipo de produto!";
            }
        }

        public NpgsqlDataReader listaTipoProduto() //Espelho do BD no software
        {
            string sql = "select * from tipoproduto order by nometipo";
            Connection conexao = new Connection();
            NpgsqlConnection conn = conexao.conectaPG();
            NpgsqlCommand comm = new NpgsqlCommand(sql, conn);

            try
            {
                return comm.ExecuteReader();
            }
            catch (NpgsqlException erro)
            {
                return null;
            }
        }
    }
}
