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
    }
}
