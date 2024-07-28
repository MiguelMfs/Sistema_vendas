using Sistema_Vendas.controller;
using Sistema_Vendas.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Vendas.view
{
    public partial class FUsuario : Form
    {
        private string status = "consultando";
        public FUsuario()
        {
            InitializeComponent();
        }


        private void botaoFechar_Click(object sender, EventArgs e)
        {
            TabPage tabpage = (TabPage)this.Parent;
            this.Close();
            TabControl tabcontrol = (TabControl)tabpage.Parent;
            tabcontrol.TabPages.Remove(tabpage);
        }

        private void botaoPesquisar_Click(object sender, EventArgs e)
        {
            string nome = "%" + txtPesquisar.Text + "%";

            usuarioController controller = new usuarioController();

            dataGridView1.DataSource = controller.buscaPorNome(nome);

        }

        public void desabilitarCampos()
        {
            //Desabilitar os campos
            txtID.Enabled = false;
            txtNome.Enabled = false;
            txtTelefone.Enabled = false;
            txtLogin.Enabled = false;
            txtSenha.Enabled = false;
            //Desabilitar botões
            botaoSalvar.Enabled = false;
            botaoEditar.Enabled = false;
            botaoExcluir.Enabled = false;

        }

        public void habilitarCampos()
        {
            //Habilitar os campos
            //txtID.Enabled = false;
            txtNome.Enabled = true;
            txtTelefone.Enabled = true;
            txtLogin.Enabled = true;
            txtSenha.Enabled = true;
            //Desabilitar botões
            botaoSalvar.Enabled = true;
        }

        public void limparCampos()
        {
            //Desabilitar os campos
            txtID.Clear();
            txtNome.Clear();
            txtTelefone.Clear();
            txtLogin.Clear();
            txtSenha.Clear();
            txtNome.Focus();
        }

        private void FUsuario_Load(object sender, EventArgs e)
        {
            desabilitarCampos();
        }

        private void botaoNovo_Click(object sender, EventArgs e)
        {
            habilitarCampos();
            limparCampos();
            tabControl1.SelectedTab = tabDados;
            status = "inserindo";
        }

        private void botaoSalvar_Click(object sender, EventArgs e)
        {
            Usuario obj = new Usuario();
            obj.nome = txtNome.Text;
            obj.telefone = txtTelefone.Text;
            obj.login = txtLogin.Text;
            obj.senha = txtSenha.Text;

            usuarioController controller = new usuarioController();

            if (status == "inserindo")
            {
                controller.cadastrarUsuario(obj);
            }
            else if (status == "alterando")
            {
                obj.idusuario = int.Parse(txtID.Text);
                controller.alterarUsuario(obj);
            }

            status = "consultando";

            limparCampos();
            desabilitarCampos();
            dataGridView1.DataSource = controller.listarUsuarios();

            tabControl1.SelectedTab = tabPesquisa;
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            //if para evitar bug do botao novo
            if (status != "consultando")
            {
                desabilitarCampos();
                status = "consultando";
            }

            int idusuario =
                int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());

            usuarioController controller = new usuarioController();

            Usuario obj = controller.buscaPorID(idusuario);

            txtNome.Text = obj.nome;
            txtTelefone.Text = obj.telefone;

            txtID.Text = obj.idusuario.ToString();


            //habilitar botões de editar e de excluir
            botaoEditar.Enabled = true;
            botaoExcluir.Enabled = true;

            //vai para a aba de dados
            tabControl1.SelectedTab = tabDados;
        }

        private void botaoEditar_Click(object sender, EventArgs e)
        {
            habilitarCampos();
            status = "alterando";

            txtLogin.Enabled = false;
            txtSenha.Enabled = false;
        }

        private void botaoExcluir_Click(object sender, EventArgs e)
        {
            DialogResult dr =
               MessageBox.Show(
                   "Tem certeza que deseja excluir?",
                   "Pergunta",
                   MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                Usuario obj = new Usuario();
                obj.idusuario = int.Parse(txtID.Text);

                usuarioController controller = new usuarioController();
                controller.excluirUsuario(obj);

                dataGridView1.DataSource = controller.listarUsuarios();
                limparCampos();
                botaoEditar.Enabled = false;
                botaoExcluir.Enabled = false;

                tabControl1.SelectedTab = tabPesquisa;
            }
        }
    }
}
