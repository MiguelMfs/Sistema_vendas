namespace Sistema_Vendas
{
    partial class FMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FMenu));
            menuStrip1 = new MenuStrip();
            cadastrosToolStripMenuItem = new ToolStripMenuItem();
            clientesToolStripMenuItem = new ToolStripMenuItem();
            produtosToolStripMenuItem = new ToolStripMenuItem();
            fornecedoresToolStripMenuItem = new ToolStripMenuItem();
            usuáriosToolStripMenuItem = new ToolStripMenuItem();
            pedidoVendasToolStripMenuItem = new ToolStripMenuItem();
            sairToolStripMenuItem = new ToolStripMenuItem();
            toolStrip1 = new ToolStrip();
            botaoClientes = new ToolStripButton();
            botaoProdutos = new ToolStripButton();
            botaoFornecedores = new ToolStripButton();
            botaoUsuarios = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            botaoVendas = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            botaoSair = new ToolStripButton();
            tabControl1 = new TabControl();
            imageList1 = new ImageList(components);
            menuStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { cadastrosToolStripMenuItem, pedidoVendasToolStripMenuItem, sairToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(736, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // cadastrosToolStripMenuItem
            // 
            cadastrosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { clientesToolStripMenuItem, produtosToolStripMenuItem, fornecedoresToolStripMenuItem, usuáriosToolStripMenuItem });
            cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            cadastrosToolStripMenuItem.Size = new Size(71, 20);
            cadastrosToolStripMenuItem.Text = "&Cadastros";
            // 
            // clientesToolStripMenuItem
            // 
            clientesToolStripMenuItem.Image = (Image)resources.GetObject("clientesToolStripMenuItem.Image");
            clientesToolStripMenuItem.ImageAlign = ContentAlignment.MiddleLeft;
            clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            clientesToolStripMenuItem.Size = new Size(180, 22);
            clientesToolStripMenuItem.Text = "&Clientes";
            clientesToolStripMenuItem.Click += clientesToolStripMenuItem_Click;
            // 
            // produtosToolStripMenuItem
            // 
            produtosToolStripMenuItem.Image = (Image)resources.GetObject("produtosToolStripMenuItem.Image");
            produtosToolStripMenuItem.ImageAlign = ContentAlignment.MiddleLeft;
            produtosToolStripMenuItem.Name = "produtosToolStripMenuItem";
            produtosToolStripMenuItem.Size = new Size(180, 22);
            produtosToolStripMenuItem.Text = "&Produtos";
            // 
            // fornecedoresToolStripMenuItem
            // 
            fornecedoresToolStripMenuItem.Image = (Image)resources.GetObject("fornecedoresToolStripMenuItem.Image");
            fornecedoresToolStripMenuItem.ImageAlign = ContentAlignment.MiddleLeft;
            fornecedoresToolStripMenuItem.Name = "fornecedoresToolStripMenuItem";
            fornecedoresToolStripMenuItem.Size = new Size(180, 22);
            fornecedoresToolStripMenuItem.Text = "&Fornecedores";
            fornecedoresToolStripMenuItem.Click += fornecedoresToolStripMenuItem_Click;
            // 
            // usuáriosToolStripMenuItem
            // 
            usuáriosToolStripMenuItem.Image = (Image)resources.GetObject("usuáriosToolStripMenuItem.Image");
            usuáriosToolStripMenuItem.ImageAlign = ContentAlignment.MiddleLeft;
            usuáriosToolStripMenuItem.Name = "usuáriosToolStripMenuItem";
            usuáriosToolStripMenuItem.Size = new Size(180, 22);
            usuáriosToolStripMenuItem.Text = "&Usuários";
            usuáriosToolStripMenuItem.Click += usuáriosToolStripMenuItem_Click;
            // 
            // pedidoVendasToolStripMenuItem
            // 
            pedidoVendasToolStripMenuItem.ImageAlign = ContentAlignment.MiddleLeft;
            pedidoVendasToolStripMenuItem.Name = "pedidoVendasToolStripMenuItem";
            pedidoVendasToolStripMenuItem.Size = new Size(96, 20);
            pedidoVendasToolStripMenuItem.Text = "&Pedido Vendas";
            // 
            // sairToolStripMenuItem
            // 
            sairToolStripMenuItem.ImageAlign = ContentAlignment.MiddleLeft;
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.Size = new Size(38, 20);
            sairToolStripMenuItem.Text = "&Sair";
            sairToolStripMenuItem.Click += sairToolStripMenuItem_Click;
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(48, 48);
            toolStrip1.Items.AddRange(new ToolStripItem[] { botaoClientes, botaoProdutos, botaoFornecedores, botaoUsuarios, toolStripSeparator1, botaoVendas, toolStripSeparator2, botaoSair });
            toolStrip1.Location = new Point(0, 24);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(736, 55);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // botaoClientes
            // 
            botaoClientes.DisplayStyle = ToolStripItemDisplayStyle.Image;
            botaoClientes.Image = (Image)resources.GetObject("botaoClientes.Image");
            botaoClientes.ImageScaling = ToolStripItemImageScaling.None;
            botaoClientes.ImageTransparentColor = Color.Magenta;
            botaoClientes.Name = "botaoClientes";
            botaoClientes.Size = new Size(52, 52);
            botaoClientes.Text = "toolStripButton1";
            botaoClientes.ToolTipText = "Abrir cadastro de clientes";
            botaoClientes.Click += botaoClientes_Click;
            // 
            // botaoProdutos
            // 
            botaoProdutos.DisplayStyle = ToolStripItemDisplayStyle.Image;
            botaoProdutos.Image = (Image)resources.GetObject("botaoProdutos.Image");
            botaoProdutos.ImageTransparentColor = Color.Magenta;
            botaoProdutos.Name = "botaoProdutos";
            botaoProdutos.Size = new Size(52, 52);
            botaoProdutos.Text = "Abrir cadastro de produtos";
            // 
            // botaoFornecedores
            // 
            botaoFornecedores.DisplayStyle = ToolStripItemDisplayStyle.Image;
            botaoFornecedores.Image = (Image)resources.GetObject("botaoFornecedores.Image");
            botaoFornecedores.ImageTransparentColor = Color.Magenta;
            botaoFornecedores.Name = "botaoFornecedores";
            botaoFornecedores.Size = new Size(52, 52);
            botaoFornecedores.Text = "Abrir cadastro de fornecedores";
            botaoFornecedores.Click += botaoFornecedores_Click;
            // 
            // botaoUsuarios
            // 
            botaoUsuarios.DisplayStyle = ToolStripItemDisplayStyle.Image;
            botaoUsuarios.Image = (Image)resources.GetObject("botaoUsuarios.Image");
            botaoUsuarios.ImageTransparentColor = Color.Magenta;
            botaoUsuarios.Name = "botaoUsuarios";
            botaoUsuarios.Size = new Size(52, 52);
            botaoUsuarios.Text = "Abrir cadastro de usuários";
            botaoUsuarios.Click += botaoUsuarios_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 55);
            // 
            // botaoVendas
            // 
            botaoVendas.DisplayStyle = ToolStripItemDisplayStyle.Image;
            botaoVendas.Image = (Image)resources.GetObject("botaoVendas.Image");
            botaoVendas.ImageTransparentColor = Color.Magenta;
            botaoVendas.Name = "botaoVendas";
            botaoVendas.Size = new Size(52, 52);
            botaoVendas.Text = "Abrir cadastro de pedido de vendas";
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 55);
            // 
            // botaoSair
            // 
            botaoSair.Alignment = ToolStripItemAlignment.Right;
            botaoSair.DisplayStyle = ToolStripItemDisplayStyle.Image;
            botaoSair.Image = (Image)resources.GetObject("botaoSair.Image");
            botaoSair.ImageTransparentColor = Color.Magenta;
            botaoSair.Name = "botaoSair";
            botaoSair.Size = new Size(52, 52);
            botaoSair.Text = "Sair do sistema";
            botaoSair.Click += botaoSair_Click;
            // 
            // tabControl1
            // 
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.ImageList = imageList1;
            tabControl1.Location = new Point(0, 79);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(736, 277);
            tabControl1.TabIndex = 2;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "cliente.png");
            imageList1.Images.SetKeyName(1, "fornecedor.png");
            imageList1.Images.SetKeyName(2, "produto.png");
            imageList1.Images.SetKeyName(3, "usuario.png");
            imageList1.Images.SetKeyName(4, "vendas.png");
            // 
            // FMenu
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(736, 356);
            Controls.Add(tabControl1);
            Controls.Add(toolStrip1);
            Controls.Add(menuStrip1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4);
            Name = "FMenu";
            Text = "Sistema de Vendas - 1.0";
            WindowState = FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem cadastrosToolStripMenuItem;
        private ToolStripMenuItem clientesToolStripMenuItem;
        private ToolStripMenuItem produtosToolStripMenuItem;
        private ToolStripMenuItem fornecedoresToolStripMenuItem;
        private ToolStripMenuItem usuáriosToolStripMenuItem;
        private ToolStripMenuItem pedidoVendasToolStripMenuItem;
        private ToolStripMenuItem sairToolStripMenuItem;
        private ToolStrip toolStrip1;
        private ToolStripButton botaoClientes;
        private ToolStripButton botaoProdutos;
        private ToolStripButton botaoFornecedores;
        private ToolStripButton botaoUsuarios;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton botaoVendas;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton botaoSair;
        private TabControl tabControl1;
        private ImageList imageList1;
    }
}
