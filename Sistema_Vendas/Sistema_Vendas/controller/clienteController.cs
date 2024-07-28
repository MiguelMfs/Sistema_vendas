using MySqlConnector;
using Sistema_Vendas.model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Vendas.controller
{

    public class clienteController
    {
        private MySqlConnection conexao;

        public clienteController()
        {
            this.conexao = new conexao().GetConnection();
        }

        public void cadastrarCliente(Cliente obj)
        {
            try
            {
                string sql = @"insert into cliente 
                                (nome,cpf_cnpj,telefone,
                                email,logradouro,bairro,
                                cidade,uf) values 
                                (@nome,@cpf_cnpj,@telefone,
                                @email,@logradouro,@bairro,
                                @cidade,@uf);";

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);

                executacmd.Parameters.AddWithValue("@nome", obj.nome);
                executacmd.Parameters.AddWithValue("@cpf_cnpj", obj.cpf_cnpj);
                executacmd.Parameters.AddWithValue("@telefone", obj.telefone);
                executacmd.Parameters.AddWithValue("@email", obj.email);
                executacmd.Parameters.AddWithValue("@logradouro", obj.logradouro);
                executacmd.Parameters.AddWithValue("@bairro", obj.bairro);
                executacmd.Parameters.AddWithValue("@cidade", obj.cidade);
                executacmd.Parameters.AddWithValue("@uf", obj.uf);

                conexao.Open();
                executacmd.ExecuteNonQuery();
                MessageBox.Show("Cliente cadastrado com sucesso");
                conexao.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar: " + ex.Message);
            }

        }

        public DataTable listarClientes()
        {
            try
            {
                DataTable tabela = new DataTable();
                string sql = "select * from cliente;";

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                conexao.Open();
                executacmd.ExecuteNonQuery();

                MySqlDataAdapter da = new MySqlDataAdapter(executacmd);
                da.Fill(tabela);

                conexao.Close();
                return tabela;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao consultar: " + ex.Message);
                return null;
            }

        }


        public DataTable buscaPorNome(string nome)
        {
            try
            {
                DataTable tabela = new DataTable();
                string sql = "select * from cliente where nome like @nome;";

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@nome", nome);
                conexao.Open();
                executacmd.ExecuteNonQuery();

                MySqlDataAdapter da = new MySqlDataAdapter(executacmd);
                da.Fill(tabela);

                conexao.Close();
                return tabela;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao consultar: " + ex.Message);
                return null;
            }

        }

        public void alterarCliente(Cliente obj)
        {
            try
            {
                string sql = @"update cliente set nome = @nome,
                                cpf_cnpj = @cpf_cnpj,
                                telefone = @telefone,
                                email = @email,
                                logradouro = @logradouro,
                                bairro = @bairro,
                                cidade = @cidade,
                                uf = @uf
                                where idcliente = @idcliente;";

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);

                executacmd.Parameters.AddWithValue("@nome", obj.nome);
                executacmd.Parameters.AddWithValue("@cpf_cnpj", obj.cpf_cnpj);
                executacmd.Parameters.AddWithValue("@telefone", obj.telefone);
                executacmd.Parameters.AddWithValue("@email", obj.email);
                executacmd.Parameters.AddWithValue("@logradouro", obj.logradouro);
                executacmd.Parameters.AddWithValue("@bairro", obj.bairro);
                executacmd.Parameters.AddWithValue("@cidade", obj.cidade);
                executacmd.Parameters.AddWithValue("@uf", obj.uf);
                executacmd.Parameters.AddWithValue("@idcliente", obj.idcliente);

                conexao.Open();
                executacmd.ExecuteNonQuery();
                MessageBox.Show("Cliente alterado com sucesso");
                conexao.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao alterar: " + ex.Message);
            }

        }

        public void excluirCliente(Cliente obj)
        {
            try
            {
                string sql = "delete from cliente where idcliente = @idcliente;";

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@idcliente", obj.idcliente);

                conexao.Open();
                executacmd.ExecuteNonQuery();
                MessageBox.Show("Cliente excluído com sucesso!");
                conexao.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Aconteceu um erro: " + ex.Message);
            }

        }

        public Cliente buscaPorID(int id)
        {
            try
            {
                string sql =
                    "select * from cliente where idcliente = @id";
                MySqlCommand executacmd =
                    new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@id", id);

                conexao.Open();

                MySqlDataReader resultado = executacmd.ExecuteReader();

                Cliente c = new Cliente();

                if (resultado.HasRows)
                {
                    while (resultado.Read())
                    {
                        c.idcliente = resultado.GetInt16("idcliente");
                        c.nome = resultado.GetString("nome");
                        c.cpf_cnpj = resultado.GetString("cpf_cnpj");
                        c.email = resultado.GetString("email");
                        c.telefone = resultado.GetString("telefone");
                        c.logradouro = resultado.GetString("logradouro");
                        c.bairro = resultado.GetString("bairro");
                        c.cidade = resultado.GetString("cidade");
                        c.uf = resultado.GetString("uf");
                    }

                    resultado.Close();
                    conexao.Close();
                    return c;
                }
                else
                {
                    resultado.Close();
                    conexao.Close();
                    return null;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao consultar: " + ex.Message);
                return null;
            }
        }

    }

}
