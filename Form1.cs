using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MiniCRUDProdutosUI
{
    public partial class Form1 : Form
    {
        List<Produto> produtos = new List<Produto>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            int id;
            decimal preco;
            int quantidade;

            if (!int.TryParse(txtId.Text, out id))
            {
                MessageBox.Show("Id inválido!");
                return;
            }

            string nome = txtNome.Text;

            if (string.IsNullOrWhiteSpace(nome))
            {
                MessageBox.Show("Nome inválido!");
                return;
            }

            if (!decimal.TryParse(txtPreco.Text, out preco))
            {
                MessageBox.Show("Preço inválido!");
                return;
            }

            if (!int.TryParse(txtQuantidade.Text, out quantidade))
            {
                MessageBox.Show("Quantidade inválida!");
                return;
            }

            Produto novoProduto = new Produto
            {
                Id = id,
                Nome = nome,
                Preco = preco,
                QuantidadeEmEstoque = quantidade
            };

            produtos.Add(novoProduto);

            lstProdutos.Items.Add($"ID: {novoProduto.Id} | Nome: {novoProduto.Nome} | Preço: R$ {novoProduto.Preco:F2} | Estoque: {novoProduto.QuantidadeEmEstoque}");

            txtId.Clear();
            txtNome.Clear();
            txtPreco.Clear();
            txtQuantidade.Clear();

            txtId.Focus();

            MessageBox.Show("Produto cadastrado com sucesso!");
        }

        private void lstProdutos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int id;

            if (!int.TryParse(txtId.Text, out id))
            {
                MessageBox.Show("Digite um ID válido!");
                return;
            }

            Produto produto = produtos.Find(p => p.Id == id);

            if (produto == null)
            {
                MessageBox.Show("Produto não encontrado!");
                return;
            }

            txtNome.Text = produto.Nome;
            txtPreco.Text = produto.Preco.ToString();
            txtQuantidade.Text = produto.QuantidadeEmEstoque.ToString();

            lstProdutos.Items.Clear();

            lstProdutos.Items.Add($"🔍 Resultado da busca:");
            lstProdutos.Items.Add($"ID: {produto.Id}");
            lstProdutos.Items.Add($"Nome: {produto.Nome}");
            lstProdutos.Items.Add($"Preço: R$ {produto.Preco:F2}");
            lstProdutos.Items.Add($"Estoque: {produto.QuantidadeEmEstoque}");
        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            int id;
            int novaQuantidade;

            if (!int.TryParse(txtId.Text, out id))
            {
                MessageBox.Show("ID inválido!");
                return;
            }

            if (!int.TryParse(txtQuantidade.Text, out novaQuantidade))
            {
                MessageBox.Show("Quantidade inválida!");
                return;
            }

            Produto produto = produtos.Find(p => p.Id == id);

            if (produto == null)
            {
                MessageBox.Show("Produto não encontrado!");
                return;
            }

            produto.QuantidadeEmEstoque = novaQuantidade;

            MessageBox.Show("Estoque atualizado com sucesso!");

            lstProdutos.Items.Clear();
            lstProdutos.Items.Add($"Produto atualizado:");
            lstProdutos.Items.Add($"ID: {produto.Id}");
            lstProdutos.Items.Add($"Nome: {produto.Nome}");
            lstProdutos.Items.Add($"Estoque: {produto.QuantidadeEmEstoque}");
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int id;

            if (!int.TryParse(txtId.Text, out id))
            {
                MessageBox.Show("ID inválido!");
                return;
            }

            Produto produto = produtos.Find(p => p.Id == id);

            if (produto == null)
            {
                MessageBox.Show("Produto não encontrado!");
                return;
            }

            decimal valorTotal = produto.Preco * produto.QuantidadeEmEstoque;

            lstProdutos.Items.Clear();
            lstProdutos.Items.Add("💰 Valor total em estoque:");
            lstProdutos.Items.Add($"ID: {produto.Id}");
            lstProdutos.Items.Add($"Nome: {produto.Nome}");
            lstProdutos.Items.Add($"Preço unitário: R$ {produto.Preco:F2}");
            lstProdutos.Items.Add($"Quantidade: {produto.QuantidadeEmEstoque}");
            lstProdutos.Items.Add($"Total: R$ {valorTotal:F2}");
        }
    }
}