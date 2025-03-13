using System.Windows.Forms;

namespace TesteTecnicoWinForms
{
    public partial class Form1 : Form
    {

        private List<Produto> produtos = new List<Produto>();
        private int indiceSelecionado = -1; // Para rastrear o item selecionado
        public Form1()
        {
            InitializeComponent();
            gridViewProdutos.DataSource = produtos;
        }

        public class Produto
        {

            public string Nome { get; set; }
            public decimal Preco { get; set; }
        }

        private Produto ObterDadosFormulario()
        {
            try
            {
                string nome = txtNome.Text;
                if (string.IsNullOrWhiteSpace(nome))
                {
                    MessageBox.Show("O nome do produto � obrigat�rio.");
                    txtNome.Focus(); // Coloca o foco de volta no campo nome
                    return null; // Retorna null para indicar falha
                }

                if (!decimal.TryParse(txtPreco.Text, out decimal preco))
                {
                    MessageBox.Show("Por favor, insira um pre�o v�lido.");
                    txtPreco.Focus(); // Coloca o foco de volta no campo pre�o
                    return null; // Retorna null para indicar falha
                }

                if (preco <= 0) // Inclui zero e negativos
                {
                    MessageBox.Show("O pre�o deve ser maior que zero.");
                    txtPreco.Focus(); // Coloca o foco de volta no campo pre�o
                    return null; // Retorna null para indicar falha
                }

                return new Produto
                {
                    Nome = nome,
                    Preco = preco
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }

        private void AtualizarGridView()
        {
            gridViewProdutos.DataSource = null;
            gridViewProdutos.DataSource = produtos;
        }

        private void AdicionarProduto()
        {

            Produto novoProduto = ObterDadosFormulario();
            if (novoProduto == null)
                return;


            produtos.Add(novoProduto);
            gridViewProdutos.DataSource = null; // Resetar
            gridViewProdutos.DataSource = produtos;
        }

        private void EditarProduto()
        {
            if (indiceSelecionado < 0 || indiceSelecionado >= produtos.Count)
            {
                MessageBox.Show("Selecione um produto para editar.");
                return;
            }

            Produto produtoEditado = ObterDadosFormulario();
            if (produtoEditado == null) return;

            produtos[indiceSelecionado] = produtoEditado;
            AtualizarGridView();
            indiceSelecionado = -1;
            txtNome.Text = "";
            txtPreco.Text = "";
        }

        private void RemoverProduto()
        {
            if (indiceSelecionado < 0 || indiceSelecionado >= produtos.Count)
            {
                MessageBox.Show("Selecione um produto para remover.");
                return;
            }

            produtos.RemoveAt(indiceSelecionado);
            AtualizarGridView();
            indiceSelecionado = -1;
            txtNome.Text = "";
            txtPreco.Text = "";
        }


        private void MostrarTodosProdutos()
        {
            string mensagem = "Lista de Produtos:\n";
            foreach (Produto produto in produtos)
            {
                mensagem += $"Nome: {produto.Nome} - Pre�o: {produto.Preco:C}\n";
            }
            MessageBox.Show($"{mensagem}");
        }

        private void CalcularTotal()
        {
            decimal total = 0;
            foreach (Produto produto in produtos)
            {
                total += produto.Preco;
            }
            MessageBox.Show($"Valor total dos produtos: R${total:F2}");
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            try
            {
                AdicionarProduto();

                txtNome.Text = "";
                txtPreco.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            MostrarTodosProdutos();
        }

        private void btnCalcularTotal_Click(object sender, EventArgs e)
        {
            CalcularTotal();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            EditarProduto();
        }

        private void btnRemover_Click_Click(object sender, EventArgs e)
        {
            RemoverProduto();
        }

        private void gridViewProdutos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                indiceSelecionado = e.RowIndex;
                txtNome.Text = produtos[indiceSelecionado].Nome;
                txtPreco.Text = produtos[indiceSelecionado].Preco.ToString();
            }
        }
    }

    /*
     * 
     * 
     * O Dictionary substituir� a List<Produto>, permitindo que cada produto seja 
     * identificado e acessado rapidamente por um c�digo �nico (ex.: "P001", "P002"). Aqui est� o c�digo ajustado:
     using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace TesteTecnicoWinForms
{
    public partial class Form1 : Form
    {
        // Substitu�mos List por Dictionary, usando o C�digo como chave
        private Dictionary<string, Produto> produtos = new Dictionary<string, Produto>();

        public Form1()
        {
            InitializeComponent();
            gridViewProdutos.DataSource = produtos.Values.ToList(); // Inicializa o DataGridView com os valores do Dictionary
        }

        public class Produto
        {
            public string Codigo { get; set; } // Novo campo para a chave
            public string Nome { get; set; }
            public decimal Preco { get; set; }
        }

        private Produto ObterDadosFormulario()
        {
            string nome = txtNome.Text;
            if (string.IsNullOrWhiteSpace(nome))
            {
                MessageBox.Show("O nome do produto � obrigat�rio.");
                txtNome.Focus();
                return null;
            }

            if (!decimal.TryParse(txtPreco.Text, out decimal preco))
            {
                MessageBox.Show("Por favor, insira um pre�o v�lido.");
                txtPreco.Focus();
                return null;
            }

            if (preco <= 0)
            {
                MessageBox.Show("O pre�o deve ser maior que zero.");
                txtPreco.Focus();
                return null;
            }

            return new Produto
            {
                Nome = nome,
                Preco = preco,
                Codigo = $"P{produtos.Count + 1:000}" // Gera um c�digo autom�tico (ex.: P001, P002)
            };
        }

        private void AdicionarProduto()
        {
            Produto novoProduto = ObterDadosFormulario();
            if (novoProduto == null)
                return;

            // Adiciona ao Dictionary usando o C�digo como chave
            produtos.Add(novoProduto.Codigo, novoProduto);
            gridViewProdutos.DataSource = null; // Resetar
            gridViewProdutos.DataSource = produtos.Values.ToList(); // Atualiza o DataGridView com os valores
        }

        private void MostrarTodosProdutos()
        {
            string mensagem = "Lista de Produtos:\n";
            foreach (Produto produto in produtos.Values) // Usa .Values para iterar sobre os produtos
            {
                mensagem += $"C�digo: {produto.Codigo} - Nome: {produto.Nome} - Pre�o: {produto.Preco:C}\n";
            }
            MessageBox.Show(mensagem);
        }

        private void CalcularTotal()
        {
            decimal total = 0;
            foreach (Produto produto in produtos.Values) // Usa .Values para iterar
            {
                total += produto.Preco;
            }
            MessageBox.Show($"Valor total dos produtos: R${total:F2}");
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            AdicionarProduto();
            if (produtos.Count > 0 && ObterDadosFormulario() != null)
            {
                txtNome.Text = "";
                txtPreco.Text = "";
                txtNome.Focus();
            }
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            MostrarTodosProdutos();
        }

        private void btnCalcularTotal_Click(object sender, EventArgs e)
        {
            CalcularTotal();
        }
    }
} 
     */
}
