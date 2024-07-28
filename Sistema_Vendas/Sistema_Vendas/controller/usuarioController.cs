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
    
    public class usuarioController
    {
        private MySqlConnection conexao;

        public usuarioController()
        {
            this.conexao = new conexao().GetConnection();
        }

        public void cadastrarUsuario(Usuario obj)
        {
            try
            {
                string sql = @"insert into usuario 
                                (nome,login,senha,
                                telefone) values 
                                (@nome,@login,MD5(@senha),
                                @telefone);";

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);

                executacmd.Parameters.AddWithValue("@nome", obj.nome);
                executacmd.Parameters.AddWithValue("@login", obj.login);
                executacmd.Parameters.AddWithValue("@senha", obj.senha);
                executacmd.Parameters.AddWithValue("@telefone", obj.telefone);


                conexao.Open();
                executacmd.ExecuteNonQuery();
                MessageBox.Show("Usuário cadastrado com sucesso");
                conexao.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar: " + ex.Message);
            }

        }

        public DataTable listarUsuarios()
        {
            try
            {
                DataTable tabela = new DataTable();
                string sql = "select idusuario," +
                    "nome,login,telefone " +
                    "from usuario;";

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
                string sql = "select idusuario, nome, " +
                    "login,telefone from usuario where nome like @nome;";

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

        public void alterarUsuario(Usuario obj)
        {
            try
            {
                string sql = @"update usuario set nome = @nome,
                                telefone = @telefone 
                                where idusuario = @idusuario;";

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);

                executacmd.Parameters.AddWithValue("@nome", obj.nome);
                executacmd.Parameters.AddWithValue("@telefone", obj.telefone);
                executacmd.Parameters.AddWithValue("@idusuario", obj.idusuario);

                conexao.Open();
                executacmd.ExecuteNonQuery();
                MessageBox.Show("Usuário alterado com sucesso");
                conexao.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao alterar: " + ex.Message);
            }

        }

        public void excluirUsuario(Usuario obj)
        {
            try
            {
                string sql = "delete from usuario where idusuario = @idusuario;";

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@idusuario", obj.idusuario);

                conexao.Open();
                executacmd.ExecuteNonQuery();
                MessageBox.Show("Usuário excluído com sucesso!");
                conexao.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Aconteceu um erro: " + ex.Message);
            }
        }

        public Usuario buscaPorID(int id)
        {
            try
            {
                string sql =
                    "select * from usuario where idusuario = @id";
                MySqlCommand executacmd =
                    new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@id", id);

                conexao.Open();

                MySqlDataReader resultado = executacmd.ExecuteReader();

                Usuario u = new Usuario();

                if (resultado.HasRows)
                {
                    while (resultado.Read())
                    {
                        u.idusuario = resultado.GetInt16("idusuario");
                        u.nome = resultado.GetString("nome");
                        u.login = resultado.GetString("login");
                        u.telefone = resultado.GetString("telefone");
                    }

                    resultado.Close();
                    conexao.Close();
                    return u;
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
