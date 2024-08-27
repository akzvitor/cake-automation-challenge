using Cod3rsGrowth.Dominio.Entidades;
using Cod3rsGrowth.Servico.Servicos;
using Cod3rsGrowth.Dominio.Enums;

namespace Cod3rsGrowth.Forms
{
    public partial class FormListagem : Form
    {
        private readonly ServicoObra _servicoObra;
        private readonly ServicoCompraCliente _servicoCompraCliente;
        private readonly FiltroObra _filtroObra = new();
        private readonly FiltroCompraCliente _filtroCompraCliente = new();
        private const int ErroDataGridVazio = -1;

        public FormListagem(ServicoObra servicoObra, ServicoCompraCliente servicoCompraCliente)
        {
            _servicoObra = servicoObra;
            _servicoCompraCliente = servicoCompraCliente;
            InitializeComponent();
        }

        private void AoCarregarFormulario(object sender, EventArgs e)
        {
            try
            {
                ListarObras();
                ListarCompras();
                InicializarValoresComboBox();
                LimparComboBox();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AoClicarNoBotaoFiltrarDaAbaObras(object sender, EventArgs e)
        {
            try
            {
                if (radioButtonStatusObraEmLancamento.Checked == false &&
                radioButtonStatusObraFinalizada.Checked == false)
                {
                    _filtroObra.Finalizada = null;
                }
                else if (radioButtonStatusObraEmLancamento.Checked == true)
                {
                    _filtroObra.Finalizada = false;
                }
                else if (radioButtonStatusObraFinalizada.Checked == true)
                {
                    _filtroObra.Finalizada = true;
                }

                _filtroObra.Titulo = textBoxTituloObra.Text;
                _filtroObra.Autor = textBoxAutorObra.Text;
                _filtroObra.Formato = (Formato?)comboBoxFormatoObra.SelectedItem;

                ListarObras();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AoClicarNoBotaoLimparDaAbaObras(object sender, EventArgs e)
        {
            try
            {
                _filtroObra.Titulo = null;
                textBoxTituloObra.Text = null;
                _filtroObra.Autor = null;
                textBoxAutorObra.Text = null;
                _filtroObra.Formato = null;
                comboBoxFormatoObra.SelectedItem = null;
                _filtroObra.Finalizada = null;
                radioButtonStatusObraEmLancamento.Checked = false;
                radioButtonStatusObraFinalizada.Checked = false;
                _filtroObra.AnoInicialLancamento = null;
                textBoxAnoInicalObra.Text = null;
                _filtroObra.AnoFinalLancamento = null;
                textBoxAnoFinalObra.Text = null;

                ListarObras();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AoClicarNoBotaoFiltrarDaAbaCompras(object sender, EventArgs e)
        {
            try
            {
                _filtroCompraCliente.NomeCliente = textBoxNomeCliente.Text;
                _filtroCompraCliente.Cpf = maskedTextBoxCpf.Text.Trim().Replace(".", "").Replace("-", "");

                ListarCompras();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AoClicarNoBotaoLimparDaAbaCompras(object sender, EventArgs e)
        {
            try
            {
                _filtroCompraCliente.NomeCliente = null;
                textBoxNomeCliente.Text = null;
                _filtroCompraCliente.Cpf = null;
                maskedTextBoxCpf.Text = null;
                _filtroCompraCliente.DataInicial = DateTime.MinValue;
                _filtroCompraCliente.DataFinal = DateTime.MaxValue;

                ListarCompras();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AoClicarNoBotaoAdicionarDaAbaObras(object sender, EventArgs e)
        {
            try
            {
                var formCriarObra = new FormCriarObra(_servicoObra);

                formCriarObra.AdicionaEventoCriacaoNoBotaoSalvar();
                formCriarObra.InicializarValoresComboBox();
                formCriarObra.LimparComboBox();
                formCriarObra.ShowDialog();

                ListarObras();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AoClicarNoBotaoAdicionarDaAbaCompras(object sender, EventArgs e)
        {
            try
            {
                var formCriarCompra = new FormCriarCompra(_servicoCompraCliente, _servicoObra);

                formCriarCompra.CarregarDataSourceCatalogoObras();
                formCriarCompra.AdicionarEventoCriacaoNoBotaoSalvar();
                formCriarCompra.ShowDialog();

                ListarCompras();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AoClicarNoBotaoRemoverDaAbaObras(object sender, EventArgs e)
        {
            try
            {
                const string colunaIdObra = "colunaIdObras";
                var idDaObraSelecionada = ObterIdDoObjetoSelecionado(colunaIdObra, dataGridObras);

                if (idDaObraSelecionada == ErroDataGridVazio)
                {
                    MessageBox.Show(ConstantesDoForms.MENSAGEM_DATAGRID_OBRAS_VAZIO_ERRO_AO_REMOVER, 
                                    ConstantesDoForms.TITULO_DATAGRID_OBRAS_VAZIO);
                    return;
                }

                DialogResult dialogResult = MessageBox.Show(ConstantesDoForms.MENSAGEM_REMOVER_OBRA + idDaObraSelecionada,
                                                            ConstantesDoForms.TITULO_REMOVER_OBRA, MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {
                    _servicoObra.Remover(idDaObraSelecionada);
                    ListarObras();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AoClicarNoBotaoRemoverDaAbaCompras(object sender, EventArgs e)
        {
            try
            {
                const string nomeColunaIdCompras = "colunaIdCompras";
                var idDaCompraSelecionada = ObterIdDoObjetoSelecionado(nomeColunaIdCompras, dataGridCompras);

                if (idDaCompraSelecionada == ErroDataGridVazio)
                {
                    MessageBox.Show(ConstantesDoForms.MENSAGEM_DATAGRID_COMPRAS_VAZIO_ERRO_AO_REMOVER, 
                                    ConstantesDoForms.TITULO_DATAGRID_COMPRAS_VAZIO);
                    return;
                }

                DialogResult dialogResult = MessageBox.Show(ConstantesDoForms.MENSAGEM_REMOVER_COMPRA + idDaCompraSelecionada,
                                                            ConstantesDoForms.TITULO_REMOVER_COMPRA, MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {
                    _servicoCompraCliente.Remover(idDaCompraSelecionada);
                    ListarCompras();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AoClicarNoBotaoEditarDaAbaObras(object sender, EventArgs e)
        {
            try
            {
                const string colunaIdObra = "colunaIdObras";
                var idDaObraSelecionada = ObterIdDoObjetoSelecionado(colunaIdObra, dataGridObras);

                if (idDaObraSelecionada == ErroDataGridVazio)
                {
                    MessageBox.Show(ConstantesDoForms.MENSAGEM_DATAGRID_OBRAS_VAZIO_ERRO_AO_EDITAR, 
                                    ConstantesDoForms.TITULO_DATAGRID_OBRAS_VAZIO);
                    return;
                }

                var formCriarObra = new FormCriarObra(_servicoObra);

                formCriarObra.InicializarValoresComboBox();
                formCriarObra.InicializarValoresDosCamposDeDados(idDaObraSelecionada);
                formCriarObra.InicializarGenerosSelecionados(idDaObraSelecionada);
                formCriarObra.AdicionaEventoEdicaoNoBotaoSalvar(idDaObraSelecionada);
                formCriarObra.ShowDialog();

                ListarObras();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AoClicarNoBotaoEditarDaAbaCompras(object sender, EventArgs e)
        {
            try
            {
                const string colunaIdCompra = "colunaIdCompras";
                var idDaCompraSelecionada = ObterIdDoObjetoSelecionado(colunaIdCompra, dataGridCompras);

                if (idDaCompraSelecionada == ErroDataGridVazio)
                {
                    MessageBox.Show(ConstantesDoForms.MENSAGEM_DATAGRID_COMPRAS_VAZIO_ERRO_AO_EDITAR, 
                                    ConstantesDoForms.TITULO_DATAGRID_COMPRAS_VAZIO);
                    return;
                }

                var formCriarCompra = new FormCriarCompra(_servicoCompraCliente, _servicoObra, idDaCompraSelecionada);

                formCriarCompra.CarregarDataSourceCatalogoObras();
                formCriarCompra.InicializarCamposDeDados(idDaCompraSelecionada);
                formCriarCompra.AdicionarEventoEdicaoNoBotaoSalvar(idDaCompraSelecionada);
                formCriarCompra.ShowDialog();

                ListarCompras();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AoMudarValorDataInicial(object sender, EventArgs e)
        {
            try
            {
                _filtroCompraCliente.DataInicial = dateTimePickerDataCompraInicial.Value;
            }
            catch (Exception ex) 
            { 
                MessageBox.Show(ex.Message); 
            }
        }

        private void AoAlterarValorDataFinal(object sender, EventArgs e)
        {
            try
            {
                _filtroCompraCliente.DataFinal = dateTimePickerDataCompraFinal.Value;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AoAlterarAnoInicial(object sender, EventArgs e)
        {
            try
            {
                _filtroObra.AnoInicialLancamento = textBoxAnoInicalObra.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AoAlterarAnoFinal(object sender, EventArgs e)
        {
            try
            {
                _filtroObra.AnoFinalLancamento = textBoxAnoFinalObra.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ListarObras()
        {
            dataGridObras.DataSource = _servicoObra.ObterTodos(_filtroObra);
        }

        private void ListarCompras()
        {
            dataGridCompras.DataSource = _servicoCompraCliente.ObterTodos(_filtroCompraCliente);
        }

        private void InicializarValoresComboBox()
        {
            comboBoxFormatoObra.DataSource = Enum.GetValues(typeof(Formato));
        }

        private void LimparComboBox()
        {
            comboBoxFormatoObra.SelectedItem = null;
        }

        private static int ObterIdDoObjetoSelecionado(string nomeColuna, DataGridView dataGrid)
        {
            if (dataGrid.CurrentCell == null)
            {
                return ErroDataGridVazio;
            }

            var linhaSelecionada = dataGrid.CurrentCell.RowIndex;
            var idDoObjetoSelecionado = Convert.ToInt32(dataGrid.Rows[linhaSelecionada].Cells[nomeColuna].Value);

            return idDoObjetoSelecionado;
        }
    }
}
