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
    internal class controllerCliente
    {
        public string cadastroCliente(modeloCliente mCliente)
        {
            string sql = "insert into cliente(cpf, nomecliente, rg, nascimento, endereco, telefonecliente, idcidade) " +
                "values(@cpf, @nomecliente, @rg, @nascimento, @endereco, @telefonecliente, @idcidade)";
            Connection conexao = new Connection();
            NpgsqlConnection conn = conexao.conectaPG();
            NpgsqlCommand comm = new NpgsqlCommand(sql, conn);

            try
            {
                comm.Parameters.AddWithValue("@cpf", mCliente.Cpf);
                comm.Parameters.AddWithValue("@nomecliente", mCliente.NomeCliente);
                comm.Parameters.AddWithValue("@rg", mCliente.Rg);
                comm.Parameters.AddWithValue("@nascimento", mCliente.Nascimento);
                comm.Parameters.AddWithValue("@endereco", mCliente.Endereco);
                comm.Parameters.AddWithValue("@telefonecliente", mCliente.Telefone);
                comm.Parameters.AddWithValue("@idcidade", mCliente.IdCidade);

                comm.ExecuteNonQuery();
                return "Cliente cadastrado com sucesso!";
            }
            catch (NpgsqlException erro)
            {
                /* return erro.ToString(); //retorna erro do BD */
                return "Erro ao cadastrar cliente!";
            }
        }

        public NpgsqlDataReader pesqClienteNome (modeloCliente mCliente)

        {
             string sql = "select cl.nomecliente as \"Cliente\", cl.cpf as \"CPF\", cl.rg as \"RG\", " +
    "cl.nascimento as \"Data de Nascimento\", cl.endereco as \"Endereço\", cl.telefoneCliente as \"Telefone\", " +
    "ci.nomeCidade as \"Cidade\" from cliente cl inner join cidade ci on cl.idCidade = ci.idCidade " +
    "where cl.nomecliente like @nomecliente order by nomecliente";

            Connection conexao = new Connection();
            NpgsqlConnection conn = conexao.conectaPG();
            NpgsqlCommand comm = new NpgsqlCommand(sql, conn);

            try
            {
                comm.Parameters.AddWithValue("@nomeCliente", mCliente.NomeCliente);

                return comm.ExecuteReader();
            }
            catch (NpgsqlException erro)
            {
                return null;
            }
        }

        public NpgsqlDataReader pesqClienteCPF(modeloCliente mCliente)

        {
            string sql = "SELECT cliente.nomecliente, cliente.cpf, cliente.rg, cliente.nascimento, cliente.endereco, cliente.telefonecliente, " +
                "cidade.nomecidade FROM cliente INNER JOIN cidade ON cliente.idcidade = cidade.idcidade WHERE cliente.cpf = @cpf";

            Connection conexao = new Connection();
            NpgsqlConnection conn = conexao.conectaPG();
            NpgsqlCommand comm = new NpgsqlCommand(sql, conn);

            try
            {
                comm.Parameters.AddWithValue("@cpf", mCliente.Cpf);

                return comm.ExecuteReader();
            }
            catch (NpgsqlException erro)
            {
                return null;
            }
        }
    }
}
