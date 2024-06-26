﻿using Npgsql;
using SisVendas.Controller;
using SisVendas.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SisVendas1.Controller
{
    internal class controllerVenda
    {
        public NpgsqlDataReader novaVenda(modeloVenda mVenda)
        {
            string sql = "INSERT INTO venda (cpfCliente, dataVenda, totalvenda) " +
                "VALUES(@cpfCliente, @dataVenda, @totalvenda)" +
                "RETURNING idVenda";

            Connection conexao = new Connection();
            NpgsqlConnection conn = conexao.conectaPG();
            NpgsqlCommand comm = new NpgsqlCommand(sql, conn);

            try
            {
                comm.Parameters.AddWithValue("@cpfcliente", mVenda.CpfCliente);
                comm.Parameters.AddWithValue("@datavenda", mVenda.DataVenda);
                comm.Parameters.AddWithValue("@totalvenda", 0);


                return comm.ExecuteReader();
            }
            catch (NpgsqlException erro)
            {
                MessageBox.Show("Erro ao inserir a venda: " + erro.Message);
                return null;
            }
        }

        public string atualizaTotalVenda (modeloVenda mVenda)
        {
            string sql = "update venda set totalvenda = @totalvenda where idvenda = @idvenda;";

            Connection conexao = new Connection();
            NpgsqlConnection conn = conexao.conectaPG();
            NpgsqlCommand comm = new NpgsqlCommand(sql, conn);

            try
            {
                comm.Parameters.AddWithValue("@idvenda", mVenda.IdVenda);
                comm.Parameters.AddWithValue("@totalvenda", mVenda.TotalVenda);
                comm.ExecuteReader();
                return "Venda finalizada!";
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show("Erro ao atualizar a venda: " + ex.Message);
                return null;
            }
        }

        public NpgsqlDataReader pesquisaVendaCliente(modeloVenda mVenda)
        {
            string sql = "select idvenda, datavenda, totalvenda from venda inner join cliente on venda.cpfcliente = cliente.cpf where cpf = @cpfcliente";

            Connection conexao = new Connection();
            NpgsqlConnection conn = conexao.conectaPG();
            NpgsqlCommand comm = new NpgsqlCommand(sql, conn);

            try
            {
                comm.Parameters.AddWithValue("@cpfcliente", mVenda.CpfCliente);

                return comm.ExecuteReader();
            }
            catch (NpgsqlException erro)
            {
                return null;
            }

        }

        public NpgsqlDataReader listaItensVenda(modeloVenda mVenda)
        {
            string sql = "SELECT itensvenda.codigobarras,produto.nomeProduto, produto.descricao,itensvenda.quantidade, itensvenda.valortotal  FROM     itensvenda INNER JOIN     produto ON     itensvenda.codigobarras = produto.codigobarras WHERE     itensvenda.idvenda = @idvenda;";

            Connection conexao = new Connection();
            NpgsqlConnection conn = conexao.conectaPG();
            NpgsqlCommand comm = new NpgsqlCommand(sql, conn);

            try
            {
                comm.Parameters.AddWithValue("@idvenda", mVenda.IdVenda);

                return comm.ExecuteReader();
            }
            catch (NpgsqlException erro)
            {
                return null;
            }
        }
    }
}
