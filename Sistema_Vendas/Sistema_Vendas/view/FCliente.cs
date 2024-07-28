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
    public partial class FCliente : Form
    {
        private string status = "consultando";

        public FCliente()
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

        public void desabilitarCampos()
        {
            //Desabilitar os campos
            txtID.Enabled = false;
            txtNome.Enabled = false;
            txtCPF.Enabled = false;
            txtTelefone.Enabled = false;
            txtBairro.Enabled = false;
            txtLogradouro.Enabled = false;
            txtCidade.Enabled = false;
            txtEmail.Enabled = false;
            txtUF.Enabled = false;
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
            txtCPF.Enabled = true;
            txtTelefone.Enabled = true;
            txtBairro.Enabled = true;
            txtLogradouro.Enabled = true;
            txtCidade.Enabled = true;
            txtEmail.Enabled = true;
            txtUF.Enabled = true;
            //Desabilitar botões
            botaoSalvar.Enabled = true;
        }

        public void limparCampos()
        {
            //Desabilitar os campos
            txtID.Clear();
            txtNome.Clear();
            txtCPF.Clear();
            txtTelefone.Clear();
            txtBairro.Clear();
            txtLogradouro.Clear();
            txtCidade.Clear();
            txtEmail.Clear();
            txtUF.Text = String.Empty;
            txtNome.Focus();
        }

        private void FCliente_Load(object sender, EventArgs e)
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

        private void botaoPesquisar_Click(object sender, EventArgs e)
        {
            string nome = "%" + txtPesquisar.Text + "%";

            clienteController controller = new clienteController();

            dataGridView1.DataSource = controller.buscaPorNome(nome);

        }

        private void botaoSalvar_Click(object sender, EventArgs e)
        {
            Cliente obj = new Cliente();
            obj.nome = txtNome.Text;
            obj.cpf_cnpj = txtCPF.Text.Replace(",", ".");
            obj.telefone = txtTelefone.Text;
            obj.email = txtEmail.Text;
            obj.logradouro = txtLogradouro.Text;
            obj.bairro = txtBairro.Text;
            obj.cidade = txtCidade.Text;
            obj.uf = txtUF.Text;

            clienteController controller = new clienteController();

            if (status == "inserindo")
            {
                controller.cadastrarCliente(obj);
            }
            else if (status == "alterando")
            {
                obj.idcliente = int.Parse(txtID.Text);
                controller.alterarCliente(obj);
            }

            status = "consultando";

            limparCampos();
            desabilitarCampos();
            dataGridView1.DataSource = controller.listarClientes();

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

            int idcliente =
                int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());

            clienteController controller = new clienteController();

            Cliente obj = controller.buscaPorID(idcliente);

            txtNome.Text = obj.nome;
            txtCPF.Text = obj.cpf_cnpj;
            txtEmail.Text = obj.email;
            txtLogradouro.Text = obj.logradouro;
            txtBairro.Text = obj.bairro;
            txtCidade.Text = obj.cidade;
            txtUF.Text = obj.uf;
            txtTelefone.Text = obj.telefone;
            txtID.Text = obj.idcliente.ToString();

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
                Cliente obj = new Cliente();
                obj.idcliente = int.Parse(txtID.Text);

                clienteController controller = new clienteController();
                controller.excluirCliente(obj);

                dataGridView1.DataSource = controller.listarClientes();
                limparCampos();
                botaoEditar.Enabled = false;
                botaoExcluir.Enabled = false;

                tabControl1.SelectedTab = tabPesquisa;
            }
        }
    }
}
