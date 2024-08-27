using Cod3rsGrowth.Dominio.Entidades;
using Cod3rsGrowth.Servico.Servicos;
using FluentValidation;

namespace Cod3rsGrowth.Forms
{
    public partial class FormCriarCompra : Form
    {
        private readonly ServicoCompraCliente _servicoCompraCliente;
        private readonly ServicoObra _servicoObra;
        private readonly FiltroObra _filtroObra = new();
        private readonly int _idDaCompra;

        public FormCriarCompra(ServicoCompraCliente servicoCompraCliente, ServicoObra servicoObra, int idDaCompra)
        {
            _servicoCompraCliente = servicoCompraCliente;
            _servicoObra = servicoObra;
            _idDaCompra = idDaCompra;
            InitializeComponent();
        }

        public FormCriarCompra(ServicoCompraCliente servicoCompraCliente, ServicoObra servicoObra)
        {
            _servicoCompraCliente = servicoCompraCliente;
            _servicoObra = servicoObra;
            InitializeComponent();
        }

        private void AoCarregarFormulario(object sender, EventArgs e)
        {
            try
            {
                InicializarProdutosSelecionadosNoCatalogo();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AoClicarNoBotaoSalvarCriacaoCompra(object sender, EventArgs e)
        {
            try
            {
                List<int> produtosSelecionados = ObterIdDosProdutosSelecionados();

                CompraCliente novaCompra = new()
                {
                    Cpf = maskedTextBoxCpf.Text.Trim().Replace(".", "").Replace("-", ""),
                    Nome = textBoxNome.Text,
                    Telefone = maskedTextBoxTelefone.Text.Trim().Replace("(", "").Replace(")", "").Replace("-", ""),
                    ValorCompra = decimal.Parse(textBoxValorCompra.Text),
                    Email = textBoxEmail.Text,
                    DataCompra = DateTime.Now,
                    listaIdDosProdutos = produtosSelecionados
                };

                DialogResult dialogResult = MessageBox.Show(ConstantesDoForms.MENSAGEM_SALVAR_COMPRA + novaCompra.ValorCompra,
                                                            ConstantesDoForms.TITULO_SALVAR_COMPRA, MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {
                    _servicoCompraCliente.Criar(novaCompra);
                    Close();
                }
            }
            catch (ValidationException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AoClicarNoBotaoSalvarEdicaoCompra(object sender, EventArgs e, int idDaCompraSelecionada)
        {
            try
            {
                var compraASerEditada = _servicoCompraCliente.ObterPorId(idDaCompraSelecionada);

                compraASerEditada.Cpf = maskedTextBoxCpf.Text.Trim().Replace(".", "").Replace("-", "");
                compraASerEditada.Nome = textBoxNome.Text;
                compraASerEditada.Telefone = maskedTextBoxTelefone.Text.Trim().Replace("(", "").Replace(")", "").Replace("-", "");
                compraASerEditada.listaIdDosProdutos = ObterIdDosProdutosSelecionados();
                compraASerEditada.ValorCompra = decimal.Parse(textBoxValorCompra.Text);
                compraASerEditada.Email = textBoxEmail.Text;

                DialogResult dialogResult = MessageBox.Show(ConstantesDoForms.MENSAGEM_SALVAR_COMPRA + compraASerEditada.ValorCompra,
                                                            ConstantesDoForms.TITULO_SALVAR_COMPRA, MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    _servicoCompraCliente.Editar(compraASerEditada);
                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AoClicarNoBotaoCancelar(object sender, EventArgs e)
        {
            try
            {
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private List<int> ObterIdDosProdutosSelecionados()
        {
            List<int> produtosSelecionados = new();
            decimal valorDosProdutosSelecionados = 0;

            foreach (DataGridViewRow linha in dataGridViewCatalogoObras.Rows)
            {
                if (Convert.ToBoolean(linha.Cells["colunaSelecao"].Value))
                {
                    int produtoId = Convert.ToInt32(linha.Cells["colunaId"].Value);
                    produtosSelecionados.Add(produtoId);
                    valorDosProdutosSelecionados += Convert.ToDecimal(linha.Cells["ValorObra"].Value);
                }
            }

            textBoxValorCompra.Text = valorDosProdutosSelecionados.ToString();

            return produtosSelecionados;
        }

        private void InicializarProdutosSelecionadosNoCatalogo()
        {
            List<int> produtosSelecionados = _servicoCompraCliente.ObterProdutosVinculados(_idDaCompra);

            foreach (DataGridViewRow linha in dataGridViewCatalogoObras.Rows)
            {
                if (produtosSelecionados.Contains(Convert.ToInt32(linha.Cells["colunaId"].Value)))
                {
                    linha.Cells["colunaSelecao"].Value = true;
                }
            }
        }

        public void CarregarDataSourceCatalogoObras()
        {
            dataGridViewCatalogoObras.DataSource = _servicoObra.ObterTodos(_filtroObra);
        }

        public void InicializarCamposDeDados(int idDaCompraASerEditada)
        {
            var compraASerEditada = _servicoCompraCliente.ObterPorId(idDaCompraASerEditada);

            textBoxNome.Text = compraASerEditada.Nome;
            textBoxEmail.Text = compraASerEditada.Email;
            maskedTextBoxCpf.Text = compraASerEditada.Cpf;
            maskedTextBoxTelefone.Text = compraASerEditada.Telefone;
        }

        public void AdicionarEventoCriacaoNoBotaoSalvar()
        {
            buttonSalvar.Click += (s, e) => AoClicarNoBotaoSalvarCriacaoCompra(s, e);
        }

        public void AdicionarEventoEdicaoNoBotaoSalvar(int idDaCompraSelecionada)
        {
            buttonSalvar.Click += (s, e) => AoClicarNoBotaoSalvarEdicaoCompra(s, e, idDaCompraSelecionada);
        }
    }
}
