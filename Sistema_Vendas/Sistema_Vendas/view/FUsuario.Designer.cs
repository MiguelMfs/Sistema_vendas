namespace Sistema_Vendas.view
{
    partial class FUsuario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FUsuario));
            botaoPesquisar = new Button();
            tabDados = new TabPage();
            txtSenha = new TextBox();
            label7 = new Label();
            txtLogin = new TextBox();
            label6 = new Label();
            txtTelefone = new MaskedTextBox();
            label5 = new Label();
            txtNome = new TextBox();
            label3 = new Label();
            txtID = new TextBox();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            idusuario = new DataGridViewTextBoxColumn();
            nome = new DataGridViewTextBoxColumn();
            telefone = new DataGridViewTextBoxColumn();
            login = new DataGridViewTextBoxColumn();
            txtPesquisar = new TextBox();
            panel2 = new Panel();
            tabControl1 = new TabControl();
            tabPesquisa = new TabPage();
            label1 = new Label();
            toolStrip1 = new ToolStrip();
            botaoNovo = new ToolStripButton();
            botaoSalvar = new ToolStripButton();
            botaoExcluir = new ToolStripButton();
            botaoEditar = new ToolStripButton();
            botaoImprimir = new ToolStripButton();
            botaoFechar = new ToolStripButton();
            panel1 = new Panel();
            tabDados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPesquisa.SuspendLayout();
            toolStrip1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // botaoPesquisar
            // 
            botaoPesquisar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            botaoPesquisar.Image = (Image)resources.GetObject("botaoPesquisar.Image");
            botaoPesquisar.ImageAlign = ContentAlignment.MiddleLeft;
            botaoPesquisar.Location = new Point(767, 11);
            botaoPesquisar.Name = "botaoPesquisar";
            botaoPesquisar.Size = new Size(109, 36);
            botaoPesquisar.TabIndex = 1;
            botaoPesquisar.Text = "&Pesquisar";
            botaoPesquisar.TextAlign = ContentAlignment.MiddleRight;
            botaoPesquisar.UseVisualStyleBackColor = true;
            botaoPesquisar.Click += botaoPesquisar_Click;
            // 
            // tabDados
            // 
            tabDados.Controls.Add(txtSenha);
            tabDados.Controls.Add(label7);
            tabDados.Controls.Add(txtLogin);
            tabDados.Controls.Add(label6);
            tabDados.Controls.Add(txtTelefone);
            tabDados.Controls.Add(label5);
            tabDados.Controls.Add(txtNome);
            tabDados.Controls.Add(label3);
            tabDados.Controls.Add(txtID);
            tabDados.Controls.Add(label2);
            tabDados.Location = new Point(4, 24);
            tabDados.Name = "tabDados";
            tabDados.Padding = new Padding(3);
            tabDados.Size = new Size(896, 536);
            tabDados.TabIndex = 1;
            tabDados.Text = "Dados Gerais";
            tabDados.UseVisualStyleBackColor = true;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(102, 161);
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '*';
            txtSenha.Size = new Size(357, 29);
            txtSenha.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(52, 169);
            label7.Name = "label7";
            label7.Size = new Size(56, 21);
            label7.TabIndex = 10;
            label7.Text = "Senha:";
            // 
            // txtLogin
            // 
            txtLogin.Location = new Point(102, 126);
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(357, 29);
            txtLogin.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(57, 132);
            label6.Name = "label6";
            label6.Size = new Size(52, 21);
            label6.TabIndex = 8;
            label6.Text = "Login:";
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(102, 91);
            txtTelefone.Mask = "(##) #####-####";
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(125, 29);
            txtTelefone.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(38, 97);
            label5.Name = "label5";
            label5.Size = new Size(70, 21);
            label5.TabIndex = 6;
            label5.Text = "Telefone:";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(102, 56);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(357, 29);
            txtNome.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(52, 62);
            label3.Name = "label3";
            label3.Size = new Size(56, 21);
            label3.TabIndex = 2;
            label3.Text = "Nome:";
            // 
            // txtID
            // 
            txtID.Location = new Point(102, 21);
            txtID.Name = "txtID";
            txtID.Size = new Size(71, 29);
            txtID.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(76, 27);
            label2.Name = "label2";
            label2.Size = new Size(32, 21);
            label2.TabIndex = 0;
            label2.Text = "ID: ";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idusuario, nome, telefone, login });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 57);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(890, 470);
            dataGridView1.TabIndex = 1;
            dataGridView1.DoubleClick += dataGridView1_DoubleClick;
            // 
            // idusuario
            // 
            idusuario.DataPropertyName = "idusuario";
            idusuario.HeaderText = "ID";
            idusuario.Name = "idusuario";
            idusuario.ReadOnly = true;
            idusuario.Width = 50;
            // 
            // nome
            // 
            nome.DataPropertyName = "nome";
            nome.HeaderText = "Nome";
            nome.Name = "nome";
            nome.ReadOnly = true;
            nome.Width = 150;
            // 
            // telefone
            // 
            telefone.DataPropertyName = "telefone";
            telefone.HeaderText = "Telefone";
            telefone.Name = "telefone";
            telefone.ReadOnly = true;
            telefone.Width = 80;
            // 
            // login
            // 
            login.DataPropertyName = "login";
            login.HeaderText = "Login";
            login.Name = "login";
            login.ReadOnly = true;
            // 
            // txtPesquisar
            // 
            txtPesquisar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtPesquisar.Location = new Point(15, 16);
            txtPesquisar.Name = "txtPesquisar";
            txtPesquisar.Size = new Size(746, 29);
            txtPesquisar.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(botaoPesquisar);
            panel2.Controls.Add(txtPesquisar);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(890, 54);
            panel2.TabIndex = 0;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPesquisa);
            tabControl1.Controls.Add(tabDados);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 66);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(904, 564);
            tabControl1.TabIndex = 5;
            // 
            // tabPesquisa
            // 
            tabPesquisa.Controls.Add(dataGridView1);
            tabPesquisa.Controls.Add(panel2);
            tabPesquisa.Location = new Point(4, 30);
            tabPesquisa.Name = "tabPesquisa";
            tabPesquisa.Padding = new Padding(3);
            tabPesquisa.Size = new Size(896, 530);
            tabPesquisa.TabIndex = 0;
            tabPesquisa.Text = "Pesquisar";
            tabPesquisa.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(170, 21);
            label1.TabIndex = 0;
            label1.Text = "Cadastro de Usuários";
            // 
            // toolStrip1
            // 
            toolStrip1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            toolStrip1.Items.AddRange(new ToolStripItem[] { botaoNovo, botaoSalvar, botaoExcluir, botaoEditar, botaoImprimir, botaoFechar });
            toolStrip1.Location = new Point(0, 38);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(904, 28);
            toolStrip1.TabIndex = 4;
            toolStrip1.Text = "toolStrip1";
            // 
            // botaoNovo
            // 
            botaoNovo.Image = (Image)resources.GetObject("botaoNovo.Image");
            botaoNovo.ImageTransparentColor = Color.Magenta;
            botaoNovo.Name = "botaoNovo";
            botaoNovo.Size = new Size(68, 25);
            botaoNovo.Text = "&Novo";
            botaoNovo.Click += botaoNovo_Click;
            // 
            // botaoSalvar
            // 
            botaoSalvar.Image = (Image)resources.GetObject("botaoSalvar.Image");
            botaoSalvar.ImageTransparentColor = Color.Magenta;
            botaoSalvar.Name = "botaoSalvar";
            botaoSalvar.Size = new Size(73, 25);
            botaoSalvar.Text = "&Salvar";
            botaoSalvar.Click += botaoSalvar_Click;
            // 
            // botaoExcluir
            // 
            botaoExcluir.Image = (Image)resources.GetObject("botaoExcluir.Image");
            botaoExcluir.ImageTransparentColor = Color.Magenta;
            botaoExcluir.Name = "botaoExcluir";
            botaoExcluir.Size = new Size(75, 25);
            botaoExcluir.Text = "&Excluir";
            botaoExcluir.Click += botaoExcluir_Click;
            // 
            // botaoEditar
            // 
            botaoEditar.Image = (Image)resources.GetObject("botaoEditar.Image");
            botaoEditar.ImageTransparentColor = Color.Magenta;
            botaoEditar.Name = "botaoEditar";
            botaoEditar.Size = new Size(70, 25);
            botaoEditar.Text = "E&ditar";
            botaoEditar.Click += botaoEditar_Click;
            // 
            // botaoImprimir
            // 
            botaoImprimir.Image = (Image)resources.GetObject("botaoImprimir.Image");
            botaoImprimir.ImageTransparentColor = Color.Magenta;
            botaoImprimir.Name = "botaoImprimir";
            botaoImprimir.Size = new Size(91, 25);
            botaoImprimir.Text = "&Imprimir";
            // 
            // botaoFechar
            // 
            botaoFechar.Alignment = ToolStripItemAlignment.Right;
            botaoFechar.Image = (Image)resources.GetObject("botaoFechar.Image");
            botaoFechar.ImageTransparentColor = Color.Magenta;
            botaoFechar.Name = "botaoFechar";
            botaoFechar.Size = new Size(76, 25);
            botaoFechar.Text = "&Fechar";
            botaoFechar.Click += botaoFechar_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDarkDark;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(904, 38);
            panel1.TabIndex = 3;
            // 
            // FUsuario
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(904, 630);
            Controls.Add(tabControl1);
            Controls.Add(toolStrip1);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "FUsuario";
            Text = "FUsuario";
            Load += FUsuario_Load;
            tabDados.ResumeLayout(false);
            tabDados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPesquisa.ResumeLayout(false);
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button botaoPesquisar;
        private TabPage tabDados;
        private TextBox txtSenha;
        private Label label7;
        private TextBox txtLogin;
        private Label label6;
        private MaskedTextBox txtTelefone;
        private Label label5;
        private TextBox txtNome;
        private Label label3;
        private TextBox txtID;
        private Label label2;
        private DataGridView dataGridView1;
        private TextBox txtPesquisar;
        private Panel panel2;
        private TabControl tabControl1;
        private TabPage tabPesquisa;
        private Label label1;
        private ToolStrip toolStrip1;
        private ToolStripButton botaoNovo;
        private ToolStripButton botaoSalvar;
        private ToolStripButton botaoExcluir;
        private ToolStripButton botaoEditar;
        private ToolStripButton botaoImprimir;
        private ToolStripButton botaoFechar;
        private Panel panel1;
        private DataGridViewTextBoxColumn idusuario;
        private DataGridViewTextBoxColumn nome;
        private DataGridViewTextBoxColumn telefone;
        private DataGridViewTextBoxColumn login;
    }
}