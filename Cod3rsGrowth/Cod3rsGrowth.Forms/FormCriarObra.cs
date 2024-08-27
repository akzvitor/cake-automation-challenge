using Cod3rsGrowth.Dominio.Entidades;
using Cod3rsGrowth.Dominio.Enums;
using Cod3rsGrowth.Servico.ExtensaoDasStrings;
using Cod3rsGrowth.Servico.Servicos;
using FluentValidation;
using System.Globalization;

namespace Cod3rsGrowth.Forms
{
    public partial class FormCriarObra : Form
    {
        private readonly ServicoObra _servicoObra;
        private const int ItemCheckListDesmarcado = -1;

        public FormCriarObra(ServicoObra servicoObra)
        {
            _servicoObra = servicoObra;
            InitializeComponent();
        }

        private void AoClicarNoBotaoSalvarCriacaoObra(object sender, EventArgs e)
        {
            try
            {
                Obra novaObra = new()
                {
                    Autor = textBoxAutor.Text,
                    Titulo = textBoxTitulo.Text,
                    ValorObra = decimal.Parse(textBoxValor.Text),
                    Sinopse = richTextBoxSinopse.Text,
                    NumeroCapitulos = Convert.ToInt32(numericUpDownCapitulos.Value),
                    Formato = (Formato)comboBoxFormato.SelectedIndex,
                    InicioPublicacao = dateTimePickerInicioPublicacao.Value,
                    FoiFinalizada = radioButtonFinalizada.Checked,
                    Generos = ObterListaDeEnumsGenero(ObterGenerosSelecionados())
                };

                DialogResult dialogResult = MessageBox.Show(ConstantesDoForms.MENSAGEM_SALVAR_OBRA,
                                                            ConstantesDoForms.TITULO_SALVAR_OBRA, MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    _servicoObra.Criar(novaObra);
                    Close();
                }
            }
            catch (ValidationException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AoClicarNoBotaoSalvarEdicaoObra(object sender, EventArgs e, int idDaObraASerEditada)
        {
            try
            {
                var obraASerEditada = _servicoObra.ObterPorId(idDaObraASerEditada);

                obraASerEditada.Autor = textBoxAutor.Text;
                obraASerEditada.Titulo = textBoxTitulo.Text;
                obraASerEditada.ValorObra = decimal.Parse(textBoxValor.Text);
                obraASerEditada.Sinopse = richTextBoxSinopse.Text;
                obraASerEditada.NumeroCapitulos = Convert.ToInt32(numericUpDownCapitulos.Value);
                obraASerEditada.Formato = (Formato)comboBoxFormato.SelectedIndex;
                obraASerEditada.InicioPublicacao = dateTimePickerInicioPublicacao.Value;
                obraASerEditada.FoiFinalizada = radioButtonFinalizada.Checked;
                obraASerEditada.Generos = ObterListaDeEnumsGenero(ObterGenerosSelecionados());

                DialogResult dialogResult = MessageBox.Show(ConstantesDoForms.MENSAGEM_SALVAR_OBRA,
                                                            ConstantesDoForms.TITULO_SALVAR_OBRA, MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    _servicoObra.Editar(obraASerEditada);
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

        private void AoAlterarTextoDoCampoValor(object sender, EventArgs e)
        {
            try
            {
                TextBox textBox = sender as TextBox
                    ?? throw new Exception("Texbox não foi encontrado");

                if (!textBox.Text.ContemValor())
                    throw new ValidationException("Campo valor da obra está vazio.");

                int selectionStart = textBox.SelectionStart;
                int length = textBox.Text.Length;

                string text = textBox.Text.Replace(".", "").Replace(",", "");

                if (!int.TryParse(text, out int value))
                {
                    MessageBox.Show("Entrada inválida!");
                    textBox.Text = string.Empty;
                    return;
                }

                textBox.TextChanged -= AoAlterarTextoDoCampoValor;

                string formattedText = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:N2}", value / 100.0);

                textBox.Text = formattedText;

                selectionStart = selectionStart + (textBox.Text.Length - length);

                const int valorPadraoTextBox = 0;
                selectionStart = selectionStart < textBox.Text.Length
                    ? valorPadraoTextBox
                    : textBox.Text.Length;

                textBox.SelectionStart = selectionStart;
                textBox.TextChanged += AoAlterarTextoDoCampoValor;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Erro ao tentar executar evento");
            }
        }

        private void AoPressionarTeclaNoCampoValor(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != '.')
                {
                    e.Handled = true;
                }

                if ((e.KeyChar == ',' || e.KeyChar == '.') && (sender as TextBox).Text.Contains(","))
                {
                    e.Handled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}");
            }
        }

        private List<string> ObterGenerosSelecionados()
        {
            List<string> generosSelecionados = new();

            foreach (var item in checkedListBoxGeneros.CheckedItems)
            {
                generosSelecionados.Add(item.ToString());
            }

            return generosSelecionados;
        }

        private static List<Genero> ObterListaDeEnumsGenero(List<string> generosSelecionados)
        {
            List<Genero> generosDaObra = new();

            foreach (var item in generosSelecionados)
            {
                generosDaObra.Add((Genero)Enum.Parse(typeof(Genero), item.ToString()));
            }

            return generosDaObra;
        }

        public void InicializarValoresComboBox()
        {
            comboBoxFormato.DataSource = Enum.GetValues(typeof(Formato));
        }

        public void LimparComboBox()
        {
            comboBoxFormato.SelectedItem = null;
        }

        public void InicializarValoresDosCamposDeDados(int idDaObraSelecionada)
        {
            var obraSelecionadaParaEdicao = _servicoObra.ObterPorId(idDaObraSelecionada);

            textBoxTitulo.Text = obraSelecionadaParaEdicao.Titulo;
            textBoxAutor.Text = obraSelecionadaParaEdicao.Autor;
            textBoxValor.Text = obraSelecionadaParaEdicao.ValorObra.ToString();
            dateTimePickerInicioPublicacao.Value = obraSelecionadaParaEdicao.InicioPublicacao;
            richTextBoxSinopse.Text = obraSelecionadaParaEdicao.Sinopse;
            numericUpDownCapitulos.Value = obraSelecionadaParaEdicao.NumeroCapitulos;
            comboBoxFormato.SelectedItem = obraSelecionadaParaEdicao.Formato;
            _ = obraSelecionadaParaEdicao.FoiFinalizada == true ?
                radioButtonFinalizada.Checked = true : radioButtonEmLancamento.Checked = true;
        }

        public void InicializarGenerosSelecionados(int idDaObraSelecionada)
        {
            var generosSelecionados = _servicoObra.ObterGenerosVinculados(idDaObraSelecionada);
            List<string> generosString = new();

            foreach (var item in generosSelecionados)
            {
                generosString.Add(item.ToString());
            }

            foreach (var item in generosString)
            {
                var index = checkedListBoxGeneros.Items.IndexOf(item);

                if (index != ItemCheckListDesmarcado)
                {
                    checkedListBoxGeneros.SetItemChecked(index, true);
                }
            }
        }

        public void AdicionaEventoCriacaoNoBotaoSalvar()
        {
            buttonSalvar.Click += (s, e) => AoClicarNoBotaoSalvarCriacaoObra(s, e);
        }

        public void AdicionaEventoEdicaoNoBotaoSalvar(int idDaObraASerEditada)
        {
            buttonSalvar.Click += (s, e) => AoClicarNoBotaoSalvarEdicaoObra(s, e, idDaObraASerEditada);
        }
    }
}