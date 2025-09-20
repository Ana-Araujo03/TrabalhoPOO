namespace TrabalhoPOO
{
    partial class Form1
    {
        /// <summary>
        ///  Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Limpar todos os recursos em uso.
        /// </summary>
        /// <param name="disposing">true se os recursos gerenciados devem ser descartados; caso contrário, false.</param>
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
        ///  Método necessário para suporte ao Designer - não modifique
        ///  o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            dgvProdutos = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Nome = new DataGridViewTextBoxColumn();
            Preco = new DataGridViewTextBoxColumn();
            Quantidade = new DataGridViewTextBoxColumn();
            txbNome = new TextBox();
            btnCadastrar = new Button();
            btnIncrementar = new Button();
            btnDecrementar = new Button();
            lblNome = new Label();
            lblPreco = new Label();
            lblQuantidade = new Label();
            txbQuantidade = new TextBox();
            panel_Cadastro = new Panel();
            mtxbPreco = new MaskedTextBox();
            btnSalvar_Produto = new Button();
            lblNome_Produto_Incremento = new Label();
            lblNome_Produto_Decremento = new Label();
            btnQuantidade_Incremento = new Button();
            btnQuantidade_Decremento = new Button();
            txbNome_Produto_Incremento = new TextBox();
            txbNome_Produto_Decremento = new TextBox();
            lblQuantidade_Incremento = new Label();
            lblQuantidade_Decremento = new Label();
            txbQuantidade_Decremento = new TextBox();
            txbQuantidade_Incremento = new TextBox();
            panel_Incremento = new Panel();
            btnBuscar_Nome_Incremento = new Button();
            panel_Decremento = new Panel();
            btnBuscar_Nome_Decremento = new Button();
            lbl_Estoque = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvProdutos).BeginInit();
            panel_Cadastro.SuspendLayout();
            panel_Incremento.SuspendLayout();
            panel_Decremento.SuspendLayout();
            SuspendLayout();
            // 
            // dgvProdutos
            // 
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.Silver;
            dgvProdutos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvProdutos.BackgroundColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.Red;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.Desktop;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvProdutos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvProdutos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.ActiveCaptionText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvProdutos.DefaultCellStyle = dataGridViewCellStyle3;
            dgvProdutos.Location = new Point(437, 24);
            dgvProdutos.Name = "dgvProdutos";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.Red;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = Color.Black;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvProdutos.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvProdutos.RowTemplate.DefaultCellStyle.BackColor = Color.White;
            dgvProdutos.RowTemplate.DefaultCellStyle.ForeColor = Color.Black;
            dgvProdutos.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.Blue;
            dgvProdutos.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.AliceBlue;
            dgvProdutos.Size = new Size(425, 414);
            dgvProdutos.TabIndex = 16;
            // 
            // Id
            // 
            Id.Frozen = true;
            Id.HeaderText = "Id";
            Id.Name = "Id";
            Id.Width = 60;
            // 
            // Nome
            // 
            Nome.Frozen = true;
            Nome.HeaderText = "Nome";
            Nome.Name = "Nome";
            // 
            // Preco
            // 
            Preco.Frozen = true;
            Preco.HeaderText = "Preco";
            Preco.Name = "Preco";
            Preco.Width = 60;
            // 
            // Quantidade
            // 
            Quantidade.Frozen = true;
            Quantidade.HeaderText = "Quantidade";
            Quantidade.Name = "Quantidade";
            // 
            // txbNome
            // 
            txbNome.Location = new Point(3, 36);
            txbNome.Name = "txbNome";
            txbNome.Size = new Size(100, 23);
            txbNome.TabIndex = 2;
            txbNome.KeyPress += txbNome_KeyPress;
            // 
            // btnCadastrar
            // 
            btnCadastrar.ForeColor = SystemColors.ActiveCaptionText;
            btnCadastrar.Location = new Point(12, 24);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(131, 49);
            btnCadastrar.TabIndex = 1;
            btnCadastrar.Text = "Cadastro de Produto";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // btnIncrementar
            // 
            btnIncrementar.ForeColor = SystemColors.ActiveCaptionText;
            btnIncrementar.Location = new Point(12, 244);
            btnIncrementar.Name = "btnIncrementar";
            btnIncrementar.Size = new Size(131, 49);
            btnIncrementar.TabIndex = 6;
            btnIncrementar.Text = "Incremento de quantidade";
            btnIncrementar.UseVisualStyleBackColor = true;
            btnIncrementar.Click += btnIncrementar_Click;
            // 
            // btnDecrementar
            // 
            btnDecrementar.ForeColor = SystemColors.ActiveCaptionText;
            btnDecrementar.Location = new Point(12, 352);
            btnDecrementar.Name = "btnDecrementar";
            btnDecrementar.Size = new Size(131, 49);
            btnDecrementar.TabIndex = 11;
            btnDecrementar.Text = "Decremento de quantidade";
            btnDecrementar.UseVisualStyleBackColor = true;
            btnDecrementar.Click += btnDecrementar_Click;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(3, 12);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(46, 15);
            lblNome.TabIndex = 7;
            lblNome.Text = "Nome :";
            // 
            // lblPreco
            // 
            lblPreco.AutoSize = true;
            lblPreco.Location = new Point(3, 78);
            lblPreco.Name = "lblPreco";
            lblPreco.Size = new Size(43, 15);
            lblPreco.TabIndex = 8;
            lblPreco.Text = "Preço :";
            // 
            // lblQuantidade
            // 
            lblQuantidade.AutoSize = true;
            lblQuantidade.Location = new Point(3, 159);
            lblQuantidade.Name = "lblQuantidade";
            lblQuantidade.Size = new Size(75, 15);
            lblQuantidade.TabIndex = 9;
            lblQuantidade.Text = "Quantidade :";
            // 
            // txbQuantidade
            // 
            txbQuantidade.Location = new Point(3, 186);
            txbQuantidade.Name = "txbQuantidade";
            txbQuantidade.Size = new Size(100, 23);
            txbQuantidade.TabIndex = 4;
            txbQuantidade.KeyPress += txbQuantidade_KeyPress;
            // 
            // panel_Cadastro
            // 
            panel_Cadastro.Controls.Add(mtxbPreco);
            panel_Cadastro.Controls.Add(btnSalvar_Produto);
            panel_Cadastro.Controls.Add(lblNome);
            panel_Cadastro.Controls.Add(txbQuantidade);
            panel_Cadastro.Controls.Add(txbNome);
            panel_Cadastro.Controls.Add(lblPreco);
            panel_Cadastro.Controls.Add(lblQuantidade);
            panel_Cadastro.Location = new Point(165, 0);
            panel_Cadastro.Name = "panel_Cadastro";
            panel_Cadastro.Size = new Size(266, 214);
            panel_Cadastro.TabIndex = 12;
            // 
            // mtxbPreco
            // 
            mtxbPreco.Location = new Point(3, 110);
            mtxbPreco.Mask = "00.00";
            mtxbPreco.Name = "mtxbPreco";
            mtxbPreco.Size = new Size(100, 23);
            mtxbPreco.TabIndex = 3;
            mtxbPreco.ValidatingType = typeof(int);
            mtxbPreco.KeyPress += mtxbPreco_KeyPress;
            // 
            // btnSalvar_Produto
            // 
            btnSalvar_Produto.ForeColor = SystemColors.ActiveCaptionText;
            btnSalvar_Produto.Location = new Point(171, 185);
            btnSalvar_Produto.Name = "btnSalvar_Produto";
            btnSalvar_Produto.Size = new Size(75, 23);
            btnSalvar_Produto.TabIndex = 5;
            btnSalvar_Produto.Text = "Salvar";
            btnSalvar_Produto.UseVisualStyleBackColor = true;
            btnSalvar_Produto.Click += btnSalvar_Produto_Click;
            // 
            // lblNome_Produto_Incremento
            // 
            lblNome_Produto_Incremento.AutoSize = true;
            lblNome_Produto_Incremento.Location = new Point(3, 3);
            lblNome_Produto_Incremento.Name = "lblNome_Produto_Incremento";
            lblNome_Produto_Incremento.Size = new Size(255, 15);
            lblNome_Produto_Incremento.TabIndex = 13;
            lblNome_Produto_Incremento.Text = "Digite o nome do produto a ser incrementado :";
            // 
            // lblNome_Produto_Decremento
            // 
            lblNome_Produto_Decremento.AutoSize = true;
            lblNome_Produto_Decremento.Location = new Point(3, 3);
            lblNome_Produto_Decremento.Name = "lblNome_Produto_Decremento";
            lblNome_Produto_Decremento.Size = new Size(258, 15);
            lblNome_Produto_Decremento.TabIndex = 14;
            lblNome_Produto_Decremento.Text = "Digite o nome do produto a ser decrementado :";
            // 
            // btnQuantidade_Incremento
            // 
            btnQuantidade_Incremento.ForeColor = SystemColors.ActiveCaptionText;
            btnQuantidade_Incremento.Location = new Point(180, 70);
            btnQuantidade_Incremento.Name = "btnQuantidade_Incremento";
            btnQuantidade_Incremento.Size = new Size(75, 23);
            btnQuantidade_Incremento.TabIndex = 10;
            btnQuantidade_Incremento.Text = "Adicionar";
            btnQuantidade_Incremento.UseVisualStyleBackColor = true;
            btnQuantidade_Incremento.Click += btnQuantidade_Incremento_Click;
            // 
            // btnQuantidade_Decremento
            // 
            btnQuantidade_Decremento.ForeColor = SystemColors.ActiveCaptionText;
            btnQuantidade_Decremento.Location = new Point(180, 74);
            btnQuantidade_Decremento.Name = "btnQuantidade_Decremento";
            btnQuantidade_Decremento.Size = new Size(75, 23);
            btnQuantidade_Decremento.TabIndex = 15;
            btnQuantidade_Decremento.Text = "Diminuir";
            btnQuantidade_Decremento.UseVisualStyleBackColor = true;
            btnQuantidade_Decremento.Click += btnQuantidade_Decremento_Click;
            // 
            // txbNome_Produto_Incremento
            // 
            txbNome_Produto_Incremento.Location = new Point(3, 21);
            txbNome_Produto_Incremento.Name = "txbNome_Produto_Incremento";
            txbNome_Produto_Incremento.Size = new Size(100, 23);
            txbNome_Produto_Incremento.TabIndex = 7;
            txbNome_Produto_Incremento.TextChanged += txbNome_Produto_Incremento_TextChanged;
            // 
            // txbNome_Produto_Decremento
            // 
            txbNome_Produto_Decremento.Location = new Point(3, 21);
            txbNome_Produto_Decremento.Name = "txbNome_Produto_Decremento";
            txbNome_Produto_Decremento.Size = new Size(100, 23);
            txbNome_Produto_Decremento.TabIndex = 12;
            txbNome_Produto_Decremento.TextChanged += txbNome_Produto_Decremento_TextChanged;
            // 
            // lblQuantidade_Incremento
            // 
            lblQuantidade_Incremento.AutoSize = true;
            lblQuantidade_Incremento.Location = new Point(3, 53);
            lblQuantidade_Incremento.Name = "lblQuantidade_Incremento";
            lblQuantidade_Incremento.Size = new Size(116, 15);
            lblQuantidade_Incremento.TabIndex = 19;
            lblQuantidade_Incremento.Text = "Digite a quantidade :";
            // 
            // lblQuantidade_Decremento
            // 
            lblQuantidade_Decremento.AutoSize = true;
            lblQuantidade_Decremento.Location = new Point(3, 55);
            lblQuantidade_Decremento.Name = "lblQuantidade_Decremento";
            lblQuantidade_Decremento.Size = new Size(116, 15);
            lblQuantidade_Decremento.TabIndex = 20;
            lblQuantidade_Decremento.Text = "Digite a quantidade :";
            // 
            // txbQuantidade_Decremento
            // 
            txbQuantidade_Decremento.Location = new Point(3, 74);
            txbQuantidade_Decremento.Name = "txbQuantidade_Decremento";
            txbQuantidade_Decremento.Size = new Size(100, 23);
            txbQuantidade_Decremento.TabIndex = 14;
            // 
            // txbQuantidade_Incremento
            // 
            txbQuantidade_Incremento.Location = new Point(3, 71);
            txbQuantidade_Incremento.Name = "txbQuantidade_Incremento";
            txbQuantidade_Incremento.Size = new Size(100, 23);
            txbQuantidade_Incremento.TabIndex = 9;
            // 
            // panel_Incremento
            // 
            panel_Incremento.Controls.Add(btnBuscar_Nome_Incremento);
            panel_Incremento.Controls.Add(lblNome_Produto_Incremento);
            panel_Incremento.Controls.Add(txbQuantidade_Incremento);
            panel_Incremento.Controls.Add(txbNome_Produto_Incremento);
            panel_Incremento.Controls.Add(lblQuantidade_Incremento);
            panel_Incremento.Controls.Add(btnQuantidade_Incremento);
            panel_Incremento.Location = new Point(165, 220);
            panel_Incremento.Name = "panel_Incremento";
            panel_Incremento.Size = new Size(266, 100);
            panel_Incremento.TabIndex = 23;
            // 
            // btnBuscar_Nome_Incremento
            // 
            btnBuscar_Nome_Incremento.ForeColor = SystemColors.ActiveCaptionText;
            btnBuscar_Nome_Incremento.Location = new Point(109, 20);
            btnBuscar_Nome_Incremento.Name = "btnBuscar_Nome_Incremento";
            btnBuscar_Nome_Incremento.Size = new Size(75, 23);
            btnBuscar_Nome_Incremento.TabIndex = 8;
            btnBuscar_Nome_Incremento.Text = "Buscar";
            btnBuscar_Nome_Incremento.UseVisualStyleBackColor = true;
            btnBuscar_Nome_Incremento.Click += btnBuscar_Nome_Incremento_Click;
            // 
            // panel_Decremento
            // 
            panel_Decremento.Controls.Add(btnBuscar_Nome_Decremento);
            panel_Decremento.Controls.Add(lblNome_Produto_Decremento);
            panel_Decremento.Controls.Add(btnQuantidade_Decremento);
            panel_Decremento.Controls.Add(txbQuantidade_Decremento);
            panel_Decremento.Controls.Add(txbNome_Produto_Decremento);
            panel_Decremento.Controls.Add(lblQuantidade_Decremento);
            panel_Decremento.Location = new Point(165, 333);
            panel_Decremento.Name = "panel_Decremento";
            panel_Decremento.Size = new Size(266, 105);
            panel_Decremento.TabIndex = 24;
            // 
            // btnBuscar_Nome_Decremento
            // 
            btnBuscar_Nome_Decremento.ForeColor = SystemColors.ActiveCaptionText;
            btnBuscar_Nome_Decremento.Location = new Point(109, 21);
            btnBuscar_Nome_Decremento.Name = "btnBuscar_Nome_Decremento";
            btnBuscar_Nome_Decremento.Size = new Size(75, 23);
            btnBuscar_Nome_Decremento.TabIndex = 13;
            btnBuscar_Nome_Decremento.Text = "Buscar";
            btnBuscar_Nome_Decremento.UseVisualStyleBackColor = true;
            btnBuscar_Nome_Decremento.Click += btnBuscar_Nome_Decremento_Click;
            // 
            // lbl_Estoque
            // 
            lbl_Estoque.AutoSize = true;
            lbl_Estoque.ForeColor = SystemColors.ControlLightLight;
            lbl_Estoque.Location = new Point(559, 6);
            lbl_Estoque.Name = "lbl_Estoque";
            lbl_Estoque.Size = new Size(116, 15);
            lbl_Estoque.TabIndex = 25;
            lbl_Estoque.Text = "Estoque de Produtos";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowFrame;
            ClientSize = new Size(874, 450);
            Controls.Add(lbl_Estoque);
            Controls.Add(panel_Decremento);
            Controls.Add(panel_Incremento);
            Controls.Add(panel_Cadastro);
            Controls.Add(btnDecrementar);
            Controls.Add(btnIncrementar);
            Controls.Add(btnCadastrar);
            Controls.Add(dgvProdutos);
            ForeColor = SystemColors.ButtonHighlight;
            MaximizeBox = false;
            MaximumSize = new Size(890, 489);
            MinimumSize = new Size(890, 489);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvProdutos).EndInit();
            panel_Cadastro.ResumeLayout(false);
            panel_Cadastro.PerformLayout();
            panel_Incremento.ResumeLayout(false);
            panel_Incremento.PerformLayout();
            panel_Decremento.ResumeLayout(false);
            panel_Decremento.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvProdutos;
        private TextBox txbNome;
        private Panel panel_Incremento;
        private Button btnCadastrar;
        private Button btnIncrementar;
        private Button btnDecrementar;
        private Label lblNome;
        private Label lblPreco;
        private Label lblQuantidade;
        private TextBox txbQuantidade;
        private Panel panel_Cadastro;
        private Button btnSalvar_Produto;
        private Label lblNome_Produto_Incremento;
        private Label lblNome_Produto_Decremento;
        private Button btnQuantidade_Incremento;
        private Button btnQuantidade_Decremento;
        private TextBox txbNome_Produto_Incremento;
        private TextBox txbNome_Produto_Decremento;
        private Label lblQuantidade_Incremento;
        private Label lblQuantidade_Decremento;
        private TextBox txbQuantidade_Decremento;
        private TextBox txbQuantidade_Incremento;
        private Panel panel_Decremento;
        private Button btnBuscar_Nome_Incremento;
        private Button btnBuscar_Nome_Decremento;
        private MaskedTextBox mtxbPreco;
        private Label lbl_Estoque;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewTextBoxColumn Preco;
        private DataGridViewTextBoxColumn Quantidade;
    }
}