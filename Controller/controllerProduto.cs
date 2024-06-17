using Npgsql;
using SisVendas.Controller;
using SisVendas.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SisVendas1.Controller
{
    internal class controllerProduto
    {
        public string cadastroProduto(modelProduto mProduto)
        {
            string sql = "insert into produto(codigobarras, nomeProduto, validade, precoCusto, precoVenda, descricao, quantidadeProduto, idTipo, idMarca, cnpj) " +
                "values(@codigobarras, @nomeProduto, @validade, @precoCusto, @precoVenda, @descricao, @quantidadeProduto, @idTipo, @idMarca, @cnpj)";
            Connection conexao = new Connection();
            NpgsqlConnection conn = conexao.conectaPG();
            NpgsqlCommand comm = new NpgsqlCommand(sql, conn);

            try
            {
                comm.Parameters.AddWithValue("@codigobarras", mProduto.CodigoBarras);
                comm.Parameters.AddWithValue("@nomeProduto", mProduto.NomeProduto);
                comm.Parameters.AddWithValue("@validade", mProduto.Validade);
                comm.Parameters.AddWithValue("@precoCusto", mProduto.PrecoCusto);
                comm.Parameters.AddWithValue("@precoVenda", mProduto.PrecoVenda);
                comm.Parameters.AddWithValue("@descricao", mProduto.Descricao);
                comm.Parameters.AddWithValue("@quantidadeProduto", mProduto.Quantidade);
                comm.Parameters.AddWithValue("@idTipo", mProduto.IdTipo);
                comm.Parameters.AddWithValue("@idMarca", mProduto.IdMarca);
                comm.Parameters.AddWithValue("@cnpj", mProduto.Cnpj);

                comm.ExecuteNonQuery();
                return "Produto cadastrado com sucesso!";
            }
            catch (NpgsqlException erro)
            {
                return erro.ToString(); //retorna erro do BD 
                /* return "Erro ao cadastrar produto!"; */
            }
        }

        public NpgsqlDataReader pesqProdutoNome(modelProduto mProduto)

        {
            string sql = "select pr.codigobarras as \"Código de Barras\", pr.nomeproduto as \"Nome\", " +
                "pr.precocusto as \"Preço de custo\", pr.validade as \"Validade\", pr.descricao as \"Descrição\", " +
                "pr.precovenda as \"Preço de Venda\", pr.quantidadeproduto as \"Quantidade\", ma.nomemarca as \"Marca\", " +
                "ti.nometipo \"Tipo\", fo.nomefornecedor as \"Fornecedor\" from produto pr " +
                "inner join fornecedor fo on pr.cnpj = fo.cnpj inner join marca ma " +
                "on pr.idmarca = ma.idmarca inner join tipoproduto ti on pr.idtipo = ti.idtipo " +
                "where pr.nomeproduto like @nomeproduto order by nomeproduto";


            Connection conexao = new Connection();
            NpgsqlConnection conn = conexao.conectaPG();
            NpgsqlCommand comm = new NpgsqlCommand(sql, conn);

            try
            {
                comm.Parameters.AddWithValue("@nomeProduto", mProduto.NomeProduto);

                return comm.ExecuteReader();
            }
            catch (NpgsqlException erro)
            {
                return null;
            }
        }

        public NpgsqlDataReader pesqProdutoCodigo(modelProduto mProduto)

        {
            string sql = "SELECT p.nomeproduto AS \"Produto\",  p.codigobarras AS \"Código de Barras\", " +
                "p.validade AS \"Validade\",p.precocusto AS \"Preço de Custo\",p.precovenda AS \"Preço de Venda\", " +
                "p.descricao AS \"Descrição\",p.quantidadeProduto AS \"Quantidade\",f.nomefornecedor AS \"Fornecedor\",tp.nometipo" +
                " AS \"Tipo\",m.nomemarca AS \"Marca\" FROM produto p INNER JOIN fornecedor f ON p.cnpj = f.cnpj " +
                "INNER JOIN tipoproduto tp ON p.idtipo = tp.idtipo INNER JOIN marca m ON p.idmarca = m.idmarca " +
                "WHERE p.codigobarras = @codigobarras";

            Connection conexao = new Connection();
            NpgsqlConnection conn = conexao.conectaPG();
            NpgsqlCommand comm = new NpgsqlCommand(sql, conn);

            try
            {
                comm.Parameters.AddWithValue("@codigobarras", mProduto.CodigoBarras);

                return comm.ExecuteReader();
            }
            catch (NpgsqlException erro)
            {
                return null;
            }
        }

        public NpgsqlDataReader pesquisaProdutoVendaCodigo(modelProduto mProduto)

        {
            string sql = "SELECT p.codigobarras AS \"Código\", p.nomeproduto AS \"Produto\"," +
                "p.precovenda AS \"Preço\",p.quantidadeProduto AS \"Quantidade\" " +
                "FROM produto p INNER JOIN fornecedor f ON p.cnpj = f.cnpj " +
                "INNER JOIN tipoproduto tp ON p.idtipo = tp.idtipo " +
                "INNER JOIN marca m ON p.idmarca = m.idmarca WHERE p.codigobarras = @codigobarras";


            Connection conexao = new Connection();
            NpgsqlConnection conn = conexao.conectaPG();
            NpgsqlCommand comm = new NpgsqlCommand(sql, conn);

            try
            {
                comm.Parameters.AddWithValue("@codigoBarras", mProduto.CodigoBarras);

                return comm.ExecuteReader();
            }
            catch (NpgsqlException erro)
            {
                return null;
            }
        }

        public NpgsqlDataReader pesquisaProdutoVendaNome(modelProduto mProduto)

        {
            string sql = "SELECT p.codigobarras AS \"Código\", p.nomeproduto AS \"Produto\"," +
                "p.precovenda AS \"Preço\",p.quantidadeProduto AS \"Quantidade\" " +
                "FROM produto p INNER JOIN fornecedor f ON p.cnpj = f.cnpj " +
                "INNER JOIN tipoproduto tp ON p.idtipo = tp.idtipo " +
                "INNER JOIN marca m ON p.idmarca = m.idmarca WHERE p.nomeproduto like @nomeproduto";


            Connection conexao = new Connection();
            NpgsqlConnection conn = conexao.conectaPG();
            NpgsqlCommand comm = new NpgsqlCommand(sql, conn);

            try
            {
                comm.Parameters.AddWithValue("@nomeProduto", mProduto.NomeProduto);

                return comm.ExecuteReader();
            }
            catch (NpgsqlException erro)
            {
                return null;
            }
        }
    }
}

        