using Sistema_Vendas.view;

namespace Sistema_Vendas
{
    public partial class FMenu : Form
    {
        public FMenu()
        {
            InitializeComponent();
        }

        private void botaoClientes_Click(object sender, EventArgs e)
        {
            //Cria a instancia do formulario 
            FCliente tela = new FCliente();
            //Ajusta as propriedades de borda da janela
            tela.TopLevel = false;
            tela.FormBorderStyle = FormBorderStyle.None;

            //Adiciona uma nova aba na PageControl
            tabControl1.TabPages.Add("Clientes");
            //Identifica quantas abas existem
            int abas = tabControl1.TabPages.Count;
            //Adiciona o formulário na nova aba criada
            tabControl1.TabPages[abas - 1].Controls.Add(tela);
            //Faz com que o formulário preencha todo o espaço da aba
            tela.Dock = DockStyle.Fill;
            //Mostra o formulário dentro da aba
            tela.Show();
            //Atualiza o formulário principal (Menu)
            Refresh();
            //Seleciona a aba recém criada
            tabControl1.SelectedTab =
                tabControl1.TabPages[abas - 1];
            //Adiciona o ícone na aba
            tabControl1.TabPages[abas - 1].ImageIndex = 0;
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            botaoClientes_Click((object)sender, e);
        }

        private void botaoSair_Click(object sender, EventArgs e)
        {
            DialogResult resposta =
                MessageBox.Show(
                    "Tem certeza que deseja sair do sistema?",
                    "Pergunta",
                    MessageBoxButtons.YesNo);
            if (resposta == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            botaoSair_Click((object)sender, e);
        }

        private void botaoUsuarios_Click(object sender, EventArgs e)
        {
            //Cria a instancia do formulario 
            FUsuario tela = new FUsuario();
            //Ajusta as propriedades de borda da janela
            tela.TopLevel = false;
            tela.FormBorderStyle = FormBorderStyle.None;

            //Adiciona uma nova aba na PageControl
            tabControl1.TabPages.Add("Usuários");
            //Identifica quantas abas existem
            int abas = tabControl1.TabPages.Count;
            //Adiciona o formulário na nova aba criada
            tabControl1.TabPages[abas - 1].Controls.Add(tela);
            //Faz com que o formulário preencha todo o espaço da aba
            tela.Dock = DockStyle.Fill;
            //Mostra o formulário dentro da aba
            tela.Show();
            //Atualiza o formulário principal (Menu)
            Refresh();
            //Seleciona a aba recém criada
            tabControl1.SelectedTab =
                tabControl1.TabPages[abas - 1];
            //Adiciona o ícone na aba
            tabControl1.TabPages[abas - 1].ImageIndex = 3;

        }

        private void usuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            botaoUsuarios_Click((object)sender, e);
        }

        private void botaoFornecedores_Click(object sender, EventArgs e)
        {
            //Cria a instancia do formulario 
            FFornecedor tela = new FFornecedor();
            //Ajusta as propriedades de borda da janela
            tela.TopLevel = false;
            tela.FormBorderStyle = FormBorderStyle.None;

            //Adiciona uma nova aba na PageControl
            tabControl1.TabPages.Add("Fornecedores");
            //Identifica quantas abas existem
            int abas = tabControl1.TabPages.Count;
            //Adiciona o formulário na nova aba criada
            tabControl1.TabPages[abas - 1].Controls.Add(tela);
            //Faz com que o formulário preencha todo o espaço da aba
            tela.Dock = DockStyle.Fill;
            //Mostra o formulário dentro da aba
            tela.Show();
            //Atualiza o formulário principal (Menu)
            Refresh();
            //Seleciona a aba recém criada
            tabControl1.SelectedTab =
                tabControl1.TabPages[abas - 1];
            //Adiciona o ícone na aba
            tabControl1.TabPages[abas - 1].ImageIndex = 1;
        }

        private void fornecedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            botaoFornecedores_Click((object)sender, e);
        }
    }
}
