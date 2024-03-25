using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SisVendas.Model;
using SisVendas.Controller;
using Npgsql;

namespace SisVendas1.Controller
{
    internal class controllerCidade
    {
        public string novaCidade(modeloCidade mCidade)
        {
            string sql = "insert into cidade(nomeCidade) values(@nomeCidade)"; //String que recebe o código que será executado no servidor
            Connection conexao = new Connection(); //objeto da classe connection que possui os métodos de conectar ao BD
            NpgsqlConnection conn = conexao.conectaPG(); //objeto da classe NpgsqlConnection que mantém a conexão com o BD
            NpgsqlCommand comm = new NpgsqlCommand(sql, conn); //objeto da classe Npgsql que executa comandos SQL no BD

            try
            {
                //passagem de valores (parâmetros) para o BD
                comm.Parameters.AddWithValue("@nomeCidade", mCidade.NomeCidade);

                //executar o comando SQL no BD
                comm.ExecuteNonQuery(); //Usar quando não retorna dados -> insert, update e delete
                return "Cidade cadastrada com sucesso!";
            }
            catch (NpgsqlException erro)
            {
                /* return erro.ToString(); //retorna erro do BD */
                return "Erro ao cadastrar cidade!";
            }
        }

        public NpgsqlDataReader listaCidade() //Espelho do BD no software
        {
            string sql = "select * from cidade"; 
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
