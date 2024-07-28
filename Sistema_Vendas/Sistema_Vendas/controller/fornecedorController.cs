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
    public class fornecedorController
    {

        private MySqlConnection conexao;

        public fornecedorController()
        {
            this.conexao = new conexao().GetConnection();
        }
        public void cadastrarFornecedor(Fornecedor obj)
        {
            try
            {
                string sql = @"insert into fornecedor 
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
                MessageBox.Show("Fornecedor cadastrado com sucesso");
                conexao.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar: " + ex.Message);
            }
        }

        public DataTable listarFornecedores()
        {
            try
            {
                DataTable tabela = new DataTable();
                string sql = "select * from fornecedor;";

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
                string sql = "select * from fornecedor where nome like @nome;";

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

        public void alterarFornecedor(Fornecedor obj)
        {
            try
            {
                string sql = @"update fornecedor set nome = @nome,
                                cpf_cnpj = @cpf_cnpj,
                                telefone = @telefone,
                                email = @email,
                                logradouro = @logradouro,
                                bairro = @bairro,
                                cidade = @cidade,
                                uf = @uf
                                where idfornecedor = @idfornecedor;";

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);

                executacmd.Parameters.AddWithValue("@nome", obj.nome);
                executacmd.Parameters.AddWithValue("@cpf_cnpj", obj.cpf_cnpj);
                executacmd.Parameters.AddWithValue("@telefone", obj.telefone);
                executacmd.Parameters.AddWithValue("@email", obj.email);
                executacmd.Parameters.AddWithValue("@logradouro", obj.logradouro);
                executacmd.Parameters.AddWithValue("@bairro", obj.bairro);
                executacmd.Parameters.AddWithValue("@cidade", obj.cidade);
                executacmd.Parameters.AddWithValue("@uf", obj.uf);
                executacmd.Parameters.AddWithValue("@idfornecedor", obj.idfornecedor);

                conexao.Open();
                executacmd.ExecuteNonQuery();
                MessageBox.Show("Fornecedor alterado com sucesso");
                conexao.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao alterar: " + ex.Message);
            }
        }

        public void excluirFornecedor(Fornecedor obj)
        {
            try
            {
                string sql = "delete from fornecedor where idfornecedor = @idfornecedor;";

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@idfornecedor", obj.idfornecedor);

                conexao.Open();
                executacmd.ExecuteNonQuery();
                MessageBox.Show("Fornecedor excluído com sucesso!");
                conexao.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Aconteceu um erro: " + ex.Message);
            }
        }

        public Fornecedor buscaPorID(int id)
        {
            try
            {
                string sql =
                    "select * from fornecedor where idfornecedor = @id";
                MySqlCommand executacmd =
                    new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@id", id);

                conexao.Open();

                MySqlDataReader resultado = executacmd.ExecuteReader();

                Fornecedor f = new Fornecedor();

                if (resultado.HasRows)
                {
                    while (resultado.Read())
                    {
                        f.idfornecedor = resultado.GetInt16("idfornecedor");
                        f.nome = resultado.GetString("nome");
                        f.cpf_cnpj = resultado.GetString("cpf_cnpj");
                        f.email = resultado.GetString("email");
                        f.telefone = resultado.GetString("telefone");
                        f.logradouro = resultado.GetString("logradouro");
                        f.bairro = resultado.GetString("bairro");
                        f.cidade = resultado.GetString("cidade");
                        f.uf = resultado.GetString("uf");
                    }

                    resultado.Close();
                    conexao.Close();
                    return f;
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
