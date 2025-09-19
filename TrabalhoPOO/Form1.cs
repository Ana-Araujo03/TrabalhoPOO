using System;
using System.Data;
using System.Windows.Forms;
using Npgsql;
using TrabalhoPOO.Banco;

namespace TrabalhoPOO
{
    public partial class Form1 : Form
    {
        string connString = Configuracao_DB.ConnectionString;

        public Form1()
        {
            InitializeComponent();
            this.panel_Cadastro.Visible = false;
            this.panel_Incremento.Visible = false;
            this.panel_Decremento.Visible = false;

            // Desabilitar campos de quantidade até apertar o buscar
            txbQuantidade_Incremento.Enabled = false;
            btnQuantidade_Incremento.Enabled = false;

            txbQuantidade_Decremento.Enabled = false;
            btnQuantidade_Decremento.Enabled = false;

            CarregarProdutos();
        }

        
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            acesso_Cadastro();
        }

        private void btnIncrementar_Click(object sender, EventArgs e)
        {
            acesso_Quantidade_Incremento();
        }

        private void btnDecrementar_Click(object sender, EventArgs e)
        {
            acesso_Quantidade_Decremento();
        }

        public void acesso_Cadastro()
        {
            this.panel_Cadastro.Visible = true;
            this.panel_Incremento.Visible = false;
            this.panel_Decremento.Visible = false;
        }

        public void acesso_Quantidade_Incremento()
        {
            this.panel_Incremento.Visible = true;
            this.panel_Cadastro.Visible = false;
            this.panel_Decremento.Visible = false;

            // Desabilitar quantidade até Buscar
            txbQuantidade_Incremento.Enabled = false;
            btnQuantidade_Incremento.Enabled = false;
            
            // Limpar campos ao abrir o painel
            txbNome_Produto_Incremento.Clear();
            txbQuantidade_Incremento.Clear();
        }

        public void acesso_Quantidade_Decremento()
        {
            this.panel_Decremento.Visible = true;
            this.panel_Cadastro.Visible = false;
            this.panel_Incremento.Visible = false;

            // desabilitar quantidade até buscar
            txbQuantidade_Decremento.Enabled = false;
            btnQuantidade_Decremento.Enabled = false;
            
            // Limpar campos ao abrir o painel
            txbNome_Produto_Decremento.Clear();
            txbQuantidade_Decremento.Clear();
        }

        private void CarregarProdutos()
        {
            try
            {
                using (NpgsqlConnection conn = new NpgsqlConnection(connString))
                {
                    conn.Open();
                    string sql = "SELECT id_produto, nome, preco, quantidade FROM produto ORDER BY id_produto";

                    using (NpgsqlDataAdapter data = new NpgsqlDataAdapter(sql, conn))
                    {
                        DataTable dt = new DataTable();
                        data.Fill(dt);

                        dgvProdutos.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar produtos: " + ex.Message);
            }
        }

        // Definindo os parâmetros para os textboxs 
        private void txbNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsSeparator(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        
        private void mtxbPreco_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ',')
            {
                e.Handled = true;
            }
        }

        private void txbQuantidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        // Salvar produto
        private void Salvar_Produto()
        {
            string nome = txbNome.Text.Trim();
            string precoStr = mtxbPreco.Text.Trim();
            string quantidadeStr = txbQuantidade.Text.Trim();

            if (string.IsNullOrEmpty(nome) || string.IsNullOrEmpty(precoStr) || string.IsNullOrEmpty(quantidadeStr))
            {
                MessageBox.Show("Não deixe campos vazios! Por favor, tente novamente...");
                return;
            }

            if (!decimal.TryParse(precoStr, out decimal preco))
            {
                MessageBox.Show("Preço inválido!");
                return;
            }

            if (!int.TryParse(quantidadeStr, out int quantidade))
            {
                MessageBox.Show("Quantidade inválida!");
                return;
            }

            try
            {
                using (NpgsqlConnection conn = new NpgsqlConnection(connString))
                {
                    conn.Open();

                    // Verificar se produto existe
                    string checkSql = "SELECT COUNT(*) FROM produto WHERE nome = @nome";
                    using (NpgsqlCommand cmdCheck = new NpgsqlCommand(checkSql, conn))
                    {
                        cmdCheck.Parameters.AddWithValue("@nome", nome);
                        int count = Convert.ToInt32(cmdCheck.ExecuteScalar());
                        if (count > 0)
                        {
                            MessageBox.Show("Produto com esse nome já existe!");
                            txbNome.Clear();
                            mtxbPreco.Clear();
                            txbQuantidade.Clear();
                            return;
                        }
                    }

                    // Adicionar o produto se não existir
                    string banco_sql = "INSERT INTO produto (nome, preco, quantidade) VALUES (@nome, @preco, @quantidade)";
                    using (NpgsqlCommand cmd = new NpgsqlCommand(banco_sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@nome", nome);
                        cmd.Parameters.AddWithValue("@preco", preco);
                        cmd.Parameters.AddWithValue("@quantidade", quantidade);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Produto salvo com sucesso!");
                txbNome.Clear();
                mtxbPreco.Clear();
                txbQuantidade.Clear();
                CarregarProdutos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar: " + ex.Message);
            }
        }

        private void btnSalvar_Produto_Click(object sender, EventArgs e)
        {
            Salvar_Produto();
        }

        // Verificar se o produto existe no estoque
        private bool BuscarProduto_Incremento()
        {
            string nome_produto = txbNome_Produto_Incremento.Text.Trim();

            if (string.IsNullOrEmpty(nome_produto))
            {
                MessageBox.Show("Informe o nome do produto! Por favor, tente novamente...");
                return false;
            }

            try
            {
                using (NpgsqlConnection conn = new NpgsqlConnection(connString))
                {
                    conn.Open();

                    string selectSql = "SELECT quantidade FROM produto WHERE nome = @nome";
                    using (NpgsqlCommand cmdSelect = new NpgsqlCommand(selectSql, conn))
                    {
                        cmdSelect.Parameters.AddWithValue("@nome", nome_produto);
                        object? result = cmdSelect.ExecuteScalar();

                        if (result == null)
                        {
                            MessageBox.Show("Produto não encontrado no estoque. Tente novamente...");
                            txbQuantidade_Incremento.Enabled = false;
                            btnQuantidade_Incremento.Enabled = false;
                            return false;
                        }
                        else
                        {
                            // Habilitar quantidade e botão
                            txbQuantidade_Incremento.Enabled = true;
                            btnQuantidade_Incremento.Enabled = true;

                            // Destacar no DataGridView
                            CarregarProdutos();
                            foreach (DataGridViewRow row in dgvProdutos.Rows)
                            {
                                if (row.Cells["nome"].Value?.ToString() == nome_produto)
                                {
                                    row.Selected = true;
                                    dgvProdutos.FirstDisplayedScrollingRowIndex = row.Index;
                                    break;
                                }
                            }

                            return true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar produto: " + ex.Message);
                return false;
            }
        }

        // Adicionar quantidade ao produto que foi verificado
        private void Incrementar_Quantidade()
        {
            if (!BuscarProduto_Incremento())
                return;

            string quantidadeStr = txbQuantidade_Incremento.Text.Trim();

            if (string.IsNullOrEmpty(quantidadeStr))
            {
                MessageBox.Show("Informe a quantidade a ser adicionada!");
                return;
            }

            if (!int.TryParse(quantidadeStr, out int quantidadeIncremento))
            {
                MessageBox.Show("Quantidade inválida!");
                return;
            }

            if (quantidadeIncremento <= 0)
            {
                MessageBox.Show("Quantidade deve ser maior que zero!");
                return;
            }

            string nomeProduto = txbNome_Produto_Incremento.Text.Trim();

            try
            {
                using (NpgsqlConnection conn = new NpgsqlConnection(connString))
                {
                    conn.Open();

                    string updateSql = "UPDATE produto SET quantidade = quantidade + @quantidade WHERE nome = @nome";
                    using (NpgsqlCommand cmdUpdate = new NpgsqlCommand(updateSql, conn))
                    {
                        cmdUpdate.Parameters.AddWithValue("@quantidade", quantidadeIncremento);
                        cmdUpdate.Parameters.AddWithValue("@nome", nomeProduto);
                        cmdUpdate.ExecuteNonQuery();
                    }
                }

                MessageBox.Show($"Quantidade adicionada com sucesso! (+{quantidadeIncremento})");

                txbNome_Produto_Incremento.Clear();
                txbQuantidade_Incremento.Clear();
                txbQuantidade_Incremento.Enabled = false;
                btnQuantidade_Incremento.Enabled = false;

                CarregarProdutos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao adicionar: " + ex.Message);
            }
        }

        private void btnBuscar_Nome_Incremento_Click(object sender, EventArgs e)
        {
            BuscarProduto_Incremento();
        }

        private void btnQuantidade_Incremento_Click(object sender, EventArgs e)
        {
            Incrementar_Quantidade();
        }

        // Verificar se o produto existe antes de decrementar
        private bool BuscarProduto_Decremento()
        {
            string nomeProduto = txbNome_Produto_Decremento.Text.Trim();

            if (string.IsNullOrEmpty(nomeProduto))
            {
                MessageBox.Show("Informe o nome do produto! Por favor, tente novamente...");
                return false;
            }

            try
            {
                using (NpgsqlConnection conn = new NpgsqlConnection(connString))
                {
                    conn.Open();

                    string selectSql = "SELECT quantidade FROM produto WHERE nome = @nome";
                    using (NpgsqlCommand cmd = new NpgsqlCommand(selectSql, conn))
                    {
                        cmd.Parameters.AddWithValue("@nome", nomeProduto);
                        object? result = cmd.ExecuteScalar();

                        if (result == null)
                        {
                            MessageBox.Show("Produto não encontrado no estoque. Tente novamente...");
                            txbQuantidade_Decremento.Enabled = false;
                            btnQuantidade_Decremento.Enabled = false;
                            return false;
                        }
                        else
                        {
                            // Habilitar quantidade e botão
                            txbQuantidade_Decremento.Enabled = true;
                            btnQuantidade_Decremento.Enabled = true;

                            // Destacar no DataGridView
                            CarregarProdutos();
                            foreach (DataGridViewRow row in dgvProdutos.Rows)
                            {
                                if (row.Cells["nome"].Value?.ToString() == nomeProduto)
                                {
                                    row.Selected = true;
                                    dgvProdutos.FirstDisplayedScrollingRowIndex = row.Index;
                                    break;
                                }
                            }

                            return true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar produto: " + ex.Message);
                return false;
            }
        }

        // Decrementar a quantidade, se já verificado
        private void Decrementar_Quantidade()
        {
            if (!BuscarProduto_Decremento())
                return;

            string quantidadeStr = txbQuantidade_Decremento.Text.Trim();

            if (string.IsNullOrEmpty(quantidadeStr))
            {
                MessageBox.Show("Informe a quantidade a ser decrementada!");
                return;
            }

            if (!int.TryParse(quantidadeStr, out int quantidadeDecremento))
            {
                MessageBox.Show("Quantidade inválida!");
                return;
            }

            if (quantidadeDecremento <= 0)
            {
                MessageBox.Show("Quantidade deve ser maior que zero!");
                return;
            }

            string nomeProduto = txbNome_Produto_Decremento.Text.Trim();

            try
            {
                using (NpgsqlConnection conn = new NpgsqlConnection(connString))
                {
                    conn.Open();

                    string selectSql = "SELECT quantidade FROM produto WHERE nome = @nome";
                    int quantidadeAtual;
                    using (NpgsqlCommand cmd = new NpgsqlCommand(selectSql, conn))
                    {
                        cmd.Parameters.AddWithValue("@nome", nomeProduto);
                        object? result = cmd.ExecuteScalar();
                        quantidadeAtual = Convert.ToInt32(result);
                    }

                    if (quantidadeAtual < quantidadeDecremento)
                    {
                        MessageBox.Show("Não é possível decrementar mais do que a quantidade em estoque!");
                        return;
                    }

                    string updateSql = "UPDATE produto SET quantidade = quantidade - @quantidade WHERE nome = @nome";
                    using (NpgsqlCommand cmd = new NpgsqlCommand(updateSql, conn))
                    {
                        cmd.Parameters.AddWithValue("@quantidade", quantidadeDecremento);
                        cmd.Parameters.AddWithValue("@nome", nomeProduto);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show($"Quantidade decrementada com sucesso! (-{quantidadeDecremento})");

                txbNome_Produto_Decremento.Clear();
                txbQuantidade_Decremento.Clear();
                txbQuantidade_Decremento.Enabled = false;
                btnQuantidade_Decremento.Enabled = false;

                CarregarProdutos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao decrementar: " + ex.Message);
            }
        }

        private void btnQuantidade_Decremento_Click(object sender, EventArgs e)
        {
            Decrementar_Quantidade();
        }

        private void btnBuscar_Nome_Decremento_Click(object sender, EventArgs e)
        {
            BuscarProduto_Decremento();
        }

        // Evento para limpar quantidade quando nome do produto for alterado
        private void txbNome_Produto_Incremento_TextChanged(object sender, EventArgs e)
        {
            // Desabilitar campo de quantidade quando nome do produto mudar
            txbQuantidade_Incremento.Enabled = false;
            btnQuantidade_Incremento.Enabled = false;
            txbQuantidade_Incremento.Clear();
        }

        private void txbNome_Produto_Decremento_TextChanged(object sender, EventArgs e)
        {
            // Desabilitar campo de quantidade quando nome do produto mudar
            txbQuantidade_Decremento.Enabled = false;
            btnQuantidade_Decremento.Enabled = false;
            txbQuantidade_Decremento.Clear();
        }
    }
}