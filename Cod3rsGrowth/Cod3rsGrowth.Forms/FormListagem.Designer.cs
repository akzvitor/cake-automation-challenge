namespace Cod3rsGrowth.Forms
{
    partial class FormListagem
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            obraBindingSource = new BindingSource(components);
            dataGridObras = new DataGridView();
            tabControl1 = new TabControl();
            tabPageObras = new TabPage();
            groupBox1 = new GroupBox();
            panelBottomObras = new Panel();
            buttonEditarObra = new Button();
            buttonRemoverObra = new Button();
            buttonAdicionarObra = new Button();
            panelFiltroObras = new Panel();
            label1 = new Label();
            textBoxAnoFinalObra = new TextBox();
            buttonLimparObras = new Button();
            textBoxAnoInicalObra = new TextBox();
            buttonFiltroObra = new Button();
            labelAnoObra = new Label();
            radioButtonStatusObraEmLancamento = new RadioButton();
            radioButtonStatusObraFinalizada = new RadioButton();
            labelStatus = new Label();
            labelFormatoObra = new Label();
            comboBoxFormatoObra = new ComboBox();
            textBoxAutorObra = new TextBox();
            labelAutorObra = new Label();
            textBoxTituloObra = new TextBox();
            labelTituloObra = new Label();
            tabPageCompras = new TabPage();
            groupBoxCompras = new GroupBox();
            dataGridCompras = new DataGridView();
            compraClienteBindingSource = new BindingSource(components);
            panel2BottomCompras = new Panel();
            buttonEditarCompra = new Button();
            buttonRemoverCompra = new Button();
            buttonAdicionarCompra = new Button();
            panelFiltroCompras = new Panel();
            labelDataCompraFinal = new Label();
            dateTimePickerDataCompraFinal = new DateTimePicker();
            maskedTextBoxCpf = new MaskedTextBox();
            dateTimePickerDataCompraInicial = new DateTimePicker();
            labelCpf = new Label();
            labelDataCompraInicial = new Label();
            textBoxNomeCliente = new TextBox();
            buttonLimparCompras = new Button();
            buttonFiltrarCompras = new Button();
            labelNomeCliente = new Label();
            obraBindingSource1 = new BindingSource(components);
            colunaIdCompras = new DataGridViewTextBoxColumn();
            cpfDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nomeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            telefoneDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            emailDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            valorCompraDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dataCompraDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            colunaIdObras = new DataGridViewTextBoxColumn();
            Sinopse = new DataGridViewTextBoxColumn();
            tituloDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            autorDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            numeroCapitulosDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            valorObraDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            formatoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            foiFinalizadaDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            inicioPublicacaoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)obraBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridObras).BeginInit();
            tabControl1.SuspendLayout();
            tabPageObras.SuspendLayout();
            groupBox1.SuspendLayout();
            panelBottomObras.SuspendLayout();
            panelFiltroObras.SuspendLayout();
            tabPageCompras.SuspendLayout();
            groupBoxCompras.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridCompras).BeginInit();
            ((System.ComponentModel.ISupportInitialize)compraClienteBindingSource).BeginInit();
            panel2BottomCompras.SuspendLayout();
            panelFiltroCompras.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)obraBindingSource1).BeginInit();
            SuspendLayout();
            // 
            // obraBindingSource
            // 
            obraBindingSource.DataSource = typeof(Dominio.Entidades.Obra);
            // 
            // dataGridObras
            // 
            dataGridObras.AllowUserToAddRows = false;
            dataGridObras.AllowUserToDeleteRows = false;
            dataGridObras.AllowUserToResizeColumns = false;
            dataGridObras.AllowUserToResizeRows = false;
            dataGridObras.AutoGenerateColumns = false;
            dataGridObras.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridObras.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridObras.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridObras.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridObras.Columns.AddRange(new DataGridViewColumn[] { colunaIdObras, Sinopse, tituloDataGridViewTextBoxColumn, autorDataGridViewTextBoxColumn, numeroCapitulosDataGridViewTextBoxColumn, valorObraDataGridViewTextBoxColumn, formatoDataGridViewTextBoxColumn, foiFinalizadaDataGridViewCheckBoxColumn, inicioPublicacaoDataGridViewTextBoxColumn });
            dataGridObras.DataSource = obraBindingSource;
            dataGridObras.Dock = DockStyle.Fill;
            dataGridObras.Location = new Point(3, 19);
            dataGridObras.Name = "dataGridObras";
            dataGridObras.ReadOnly = true;
            dataGridObras.RowTemplate.Height = 25;
            dataGridObras.Size = new Size(983, 241);
            dataGridObras.TabIndex = 0;
            // 
            // tabControl1
            // 
            tabControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl1.Controls.Add(tabPageObras);
            tabControl1.Controls.Add(tabPageCompras);
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1016, 456);
            tabControl1.TabIndex = 1;
            // 
            // tabPageObras
            // 
            tabPageObras.Controls.Add(groupBox1);
            tabPageObras.Controls.Add(panelBottomObras);
            tabPageObras.Controls.Add(panelFiltroObras);
            tabPageObras.Location = new Point(4, 24);
            tabPageObras.Name = "tabPageObras";
            tabPageObras.Padding = new Padding(3);
            tabPageObras.Size = new Size(1008, 428);
            tabPageObras.TabIndex = 0;
            tabPageObras.Text = "Obras";
            tabPageObras.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(dataGridObras);
            groupBox1.Location = new Point(8, 106);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(989, 263);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            // 
            // panelBottomObras
            // 
            panelBottomObras.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelBottomObras.Controls.Add(buttonEditarObra);
            panelBottomObras.Controls.Add(buttonRemoverObra);
            panelBottomObras.Controls.Add(buttonAdicionarObra);
            panelBottomObras.Location = new Point(3, 372);
            panelBottomObras.Name = "panelBottomObras";
            panelBottomObras.Size = new Size(1002, 53);
            panelBottomObras.TabIndex = 0;
            // 
            // buttonEditarObra
            // 
            buttonEditarObra.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonEditarObra.Location = new Point(8, 11);
            buttonEditarObra.Name = "buttonEditarObra";
            buttonEditarObra.Size = new Size(75, 34);
            buttonEditarObra.TabIndex = 11;
            buttonEditarObra.Text = "Editar";
            buttonEditarObra.UseVisualStyleBackColor = true;
            buttonEditarObra.Click += AoClicarNoBotaoEditarDaAbaObras;
            // 
            // buttonRemoverObra
            // 
            buttonRemoverObra.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonRemoverObra.Location = new Point(916, 11);
            buttonRemoverObra.Name = "buttonRemoverObra";
            buttonRemoverObra.Size = new Size(75, 34);
            buttonRemoverObra.TabIndex = 10;
            buttonRemoverObra.Text = "Remover";
            buttonRemoverObra.UseVisualStyleBackColor = true;
            buttonRemoverObra.Click += AoClicarNoBotaoRemoverDaAbaObras;
            // 
            // buttonAdicionarObra
            // 
            buttonAdicionarObra.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonAdicionarObra.BackColor = SystemColors.ControlLight;
            buttonAdicionarObra.Location = new Point(835, 11);
            buttonAdicionarObra.Name = "buttonAdicionarObra";
            buttonAdicionarObra.Size = new Size(75, 34);
            buttonAdicionarObra.TabIndex = 9;
            buttonAdicionarObra.Text = "Adicionar";
            buttonAdicionarObra.UseVisualStyleBackColor = false;
            buttonAdicionarObra.Click += AoClicarNoBotaoAdicionarDaAbaObras;
            // 
            // panelFiltroObras
            // 
            panelFiltroObras.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelFiltroObras.Controls.Add(label1);
            panelFiltroObras.Controls.Add(textBoxAnoFinalObra);
            panelFiltroObras.Controls.Add(buttonLimparObras);
            panelFiltroObras.Controls.Add(textBoxAnoInicalObra);
            panelFiltroObras.Controls.Add(buttonFiltroObra);
            panelFiltroObras.Controls.Add(labelAnoObra);
            panelFiltroObras.Controls.Add(radioButtonStatusObraEmLancamento);
            panelFiltroObras.Controls.Add(radioButtonStatusObraFinalizada);
            panelFiltroObras.Controls.Add(labelStatus);
            panelFiltroObras.Controls.Add(labelFormatoObra);
            panelFiltroObras.Controls.Add(comboBoxFormatoObra);
            panelFiltroObras.Controls.Add(textBoxAutorObra);
            panelFiltroObras.Controls.Add(labelAutorObra);
            panelFiltroObras.Controls.Add(textBoxTituloObra);
            panelFiltroObras.Controls.Add(labelTituloObra);
            panelFiltroObras.Location = new Point(-18, 6);
            panelFiltroObras.Name = "panelFiltroObras";
            panelFiltroObras.Size = new Size(1041, 94);
            panelFiltroObras.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(733, 43);
            label1.Name = "label1";
            label1.Size = new Size(12, 15);
            label1.TabIndex = 11;
            label1.Text = "-";
            // 
            // textBoxAnoFinalObra
            // 
            textBoxAnoFinalObra.Location = new Point(751, 38);
            textBoxAnoFinalObra.MaxLength = 4;
            textBoxAnoFinalObra.Name = "textBoxAnoFinalObra";
            textBoxAnoFinalObra.PlaceholderText = "yyyy";
            textBoxAnoFinalObra.Size = new Size(38, 23);
            textBoxAnoFinalObra.TabIndex = 10;
            textBoxAnoFinalObra.TextChanged += AoAlterarAnoFinal;
            // 
            // buttonLimparObras
            // 
            buttonLimparObras.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonLimparObras.BackColor = SystemColors.ControlLight;
            buttonLimparObras.Location = new Point(937, 37);
            buttonLimparObras.Name = "buttonLimparObras";
            buttonLimparObras.Size = new Size(75, 23);
            buttonLimparObras.TabIndex = 8;
            buttonLimparObras.Text = "Limpar";
            buttonLimparObras.UseVisualStyleBackColor = false;
            buttonLimparObras.Click += AoClicarNoBotaoLimparDaAbaObras;
            // 
            // textBoxAnoInicalObra
            // 
            textBoxAnoInicalObra.BackColor = SystemColors.Window;
            textBoxAnoInicalObra.Cursor = Cursors.IBeam;
            textBoxAnoInicalObra.Location = new Point(689, 37);
            textBoxAnoInicalObra.MaxLength = 4;
            textBoxAnoInicalObra.Name = "textBoxAnoInicalObra";
            textBoxAnoInicalObra.PlaceholderText = "yyyy";
            textBoxAnoInicalObra.Size = new Size(38, 23);
            textBoxAnoInicalObra.TabIndex = 6;
            textBoxAnoInicalObra.TextChanged += AoAlterarAnoInicial;
            // 
            // buttonFiltroObra
            // 
            buttonFiltroObra.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonFiltroObra.BackColor = SystemColors.ControlLight;
            buttonFiltroObra.Location = new Point(856, 37);
            buttonFiltroObra.Name = "buttonFiltroObra";
            buttonFiltroObra.Size = new Size(75, 23);
            buttonFiltroObra.TabIndex = 7;
            buttonFiltroObra.Text = "Filtrar";
            buttonFiltroObra.UseVisualStyleBackColor = false;
            buttonFiltroObra.Click += AoClicarNoBotaoFiltrarDaAbaObras;
            // 
            // labelAnoObra
            // 
            labelAnoObra.AutoSize = true;
            labelAnoObra.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelAnoObra.Location = new Point(694, 13);
            labelAnoObra.Name = "labelAnoObra";
            labelAnoObra.Size = new Size(95, 21);
            labelAnoObra.TabIndex = 9;
            labelAnoObra.Text = "Lançamento";
            // 
            // radioButtonStatusObraEmLancamento
            // 
            radioButtonStatusObraEmLancamento.AutoSize = true;
            radioButtonStatusObraEmLancamento.Cursor = Cursors.Hand;
            radioButtonStatusObraEmLancamento.Location = new Point(472, 41);
            radioButtonStatusObraEmLancamento.Name = "radioButtonStatusObraEmLancamento";
            radioButtonStatusObraEmLancamento.Size = new Size(111, 19);
            radioButtonStatusObraEmLancamento.TabIndex = 4;
            radioButtonStatusObraEmLancamento.TabStop = true;
            radioButtonStatusObraEmLancamento.Text = "Em Lançamento";
            radioButtonStatusObraEmLancamento.UseVisualStyleBackColor = true;
            // 
            // radioButtonStatusObraFinalizada
            // 
            radioButtonStatusObraFinalizada.AutoSize = true;
            radioButtonStatusObraFinalizada.Cursor = Cursors.Hand;
            radioButtonStatusObraFinalizada.Location = new Point(589, 41);
            radioButtonStatusObraFinalizada.Name = "radioButtonStatusObraFinalizada";
            radioButtonStatusObraFinalizada.Size = new Size(77, 19);
            radioButtonStatusObraFinalizada.TabIndex = 5;
            radioButtonStatusObraFinalizada.TabStop = true;
            radioButtonStatusObraFinalizada.Text = "Finalizada";
            radioButtonStatusObraFinalizada.UseVisualStyleBackColor = true;
            // 
            // labelStatus
            // 
            labelStatus.AutoSize = true;
            labelStatus.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelStatus.Location = new Point(531, 13);
            labelStatus.Name = "labelStatus";
            labelStatus.Size = new Size(52, 21);
            labelStatus.TabIndex = 6;
            labelStatus.Text = "Status";
            // 
            // labelFormatoObra
            // 
            labelFormatoObra.AutoSize = true;
            labelFormatoObra.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelFormatoObra.Location = new Point(322, 13);
            labelFormatoObra.Name = "labelFormatoObra";
            labelFormatoObra.Size = new Size(69, 21);
            labelFormatoObra.TabIndex = 5;
            labelFormatoObra.Text = "Formato";
            // 
            // comboBoxFormatoObra
            // 
            comboBoxFormatoObra.BackColor = SystemColors.Window;
            comboBoxFormatoObra.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxFormatoObra.FormattingEnabled = true;
            comboBoxFormatoObra.Location = new Point(322, 37);
            comboBoxFormatoObra.Name = "comboBoxFormatoObra";
            comboBoxFormatoObra.Size = new Size(121, 23);
            comboBoxFormatoObra.TabIndex = 3;
            // 
            // textBoxAutorObra
            // 
            textBoxAutorObra.BackColor = SystemColors.Window;
            textBoxAutorObra.Cursor = Cursors.IBeam;
            textBoxAutorObra.Location = new Point(176, 37);
            textBoxAutorObra.Name = "textBoxAutorObra";
            textBoxAutorObra.PlaceholderText = "Pesquisar";
            textBoxAutorObra.Size = new Size(123, 23);
            textBoxAutorObra.TabIndex = 2;
            // 
            // labelAutorObra
            // 
            labelAutorObra.AutoSize = true;
            labelAutorObra.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelAutorObra.Location = new Point(176, 13);
            labelAutorObra.Name = "labelAutorObra";
            labelAutorObra.Size = new Size(49, 21);
            labelAutorObra.TabIndex = 2;
            labelAutorObra.Text = "Autor";
            // 
            // textBoxTituloObra
            // 
            textBoxTituloObra.BackColor = SystemColors.Window;
            textBoxTituloObra.Cursor = Cursors.IBeam;
            textBoxTituloObra.Location = new Point(29, 37);
            textBoxTituloObra.Name = "textBoxTituloObra";
            textBoxTituloObra.PlaceholderText = "Pesquisar";
            textBoxTituloObra.Size = new Size(123, 23);
            textBoxTituloObra.TabIndex = 1;
            // 
            // labelTituloObra
            // 
            labelTituloObra.AutoSize = true;
            labelTituloObra.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelTituloObra.Location = new Point(26, 13);
            labelTituloObra.Name = "labelTituloObra";
            labelTituloObra.Size = new Size(49, 21);
            labelTituloObra.TabIndex = 0;
            labelTituloObra.Text = "Título";
            // 
            // tabPageCompras
            // 
            tabPageCompras.Controls.Add(groupBoxCompras);
            tabPageCompras.Controls.Add(panel2BottomCompras);
            tabPageCompras.Controls.Add(panelFiltroCompras);
            tabPageCompras.Location = new Point(4, 24);
            tabPageCompras.Name = "tabPageCompras";
            tabPageCompras.Padding = new Padding(3);
            tabPageCompras.Size = new Size(1008, 428);
            tabPageCompras.TabIndex = 1;
            tabPageCompras.Text = "Compras";
            tabPageCompras.UseVisualStyleBackColor = true;
            // 
            // groupBoxCompras
            // 
            groupBoxCompras.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxCompras.Controls.Add(dataGridCompras);
            groupBoxCompras.Location = new Point(8, 106);
            groupBoxCompras.Name = "groupBoxCompras";
            groupBoxCompras.Size = new Size(989, 264);
            groupBoxCompras.TabIndex = 4;
            groupBoxCompras.TabStop = false;
            // 
            // dataGridCompras
            // 
            dataGridCompras.AllowUserToAddRows = false;
            dataGridCompras.AllowUserToDeleteRows = false;
            dataGridCompras.AllowUserToResizeColumns = false;
            dataGridCompras.AllowUserToResizeRows = false;
            dataGridCompras.AutoGenerateColumns = false;
            dataGridCompras.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridCompras.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = SystemColors.Control;
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dataGridCompras.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dataGridCompras.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridCompras.Columns.AddRange(new DataGridViewColumn[] { colunaIdCompras, cpfDataGridViewTextBoxColumn, nomeDataGridViewTextBoxColumn, telefoneDataGridViewTextBoxColumn, emailDataGridViewTextBoxColumn, valorCompraDataGridViewTextBoxColumn, dataCompraDataGridViewTextBoxColumn });
            dataGridCompras.DataSource = compraClienteBindingSource;
            dataGridCompras.Dock = DockStyle.Fill;
            dataGridCompras.Location = new Point(3, 19);
            dataGridCompras.Name = "dataGridCompras";
            dataGridCompras.ReadOnly = true;
            dataGridCompras.RowTemplate.Height = 25;
            dataGridCompras.Size = new Size(983, 242);
            dataGridCompras.TabIndex = 3;
            // 
            // compraClienteBindingSource
            // 
            compraClienteBindingSource.DataSource = typeof(Dominio.Entidades.CompraCliente);
            // 
            // panel2BottomCompras
            // 
            panel2BottomCompras.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2BottomCompras.Controls.Add(buttonEditarCompra);
            panel2BottomCompras.Controls.Add(buttonRemoverCompra);
            panel2BottomCompras.Controls.Add(buttonAdicionarCompra);
            panel2BottomCompras.Location = new Point(3, 376);
            panel2BottomCompras.Name = "panel2BottomCompras";
            panel2BottomCompras.Size = new Size(1002, 49);
            panel2BottomCompras.TabIndex = 1;
            // 
            // buttonEditarCompra
            // 
            buttonEditarCompra.Location = new Point(8, 7);
            buttonEditarCompra.Name = "buttonEditarCompra";
            buttonEditarCompra.Size = new Size(75, 34);
            buttonEditarCompra.TabIndex = 17;
            buttonEditarCompra.Text = "Editar";
            buttonEditarCompra.UseVisualStyleBackColor = true;
            buttonEditarCompra.Click += AoClicarNoBotaoEditarDaAbaCompras;
            // 
            // buttonRemoverCompra
            // 
            buttonRemoverCompra.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonRemoverCompra.Location = new Point(919, 7);
            buttonRemoverCompra.Name = "buttonRemoverCompra";
            buttonRemoverCompra.Size = new Size(75, 34);
            buttonRemoverCompra.TabIndex = 16;
            buttonRemoverCompra.Text = "Remover";
            buttonRemoverCompra.UseVisualStyleBackColor = true;
            buttonRemoverCompra.Click += AoClicarNoBotaoRemoverDaAbaCompras;
            // 
            // buttonAdicionarCompra
            // 
            buttonAdicionarCompra.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonAdicionarCompra.BackColor = SystemColors.ControlLight;
            buttonAdicionarCompra.Location = new Point(838, 7);
            buttonAdicionarCompra.Name = "buttonAdicionarCompra";
            buttonAdicionarCompra.Size = new Size(75, 34);
            buttonAdicionarCompra.TabIndex = 15;
            buttonAdicionarCompra.Text = "Adicionar";
            buttonAdicionarCompra.UseVisualStyleBackColor = false;
            buttonAdicionarCompra.Click += AoClicarNoBotaoAdicionarDaAbaCompras;
            // 
            // panelFiltroCompras
            // 
            panelFiltroCompras.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelFiltroCompras.Controls.Add(labelDataCompraFinal);
            panelFiltroCompras.Controls.Add(dateTimePickerDataCompraFinal);
            panelFiltroCompras.Controls.Add(maskedTextBoxCpf);
            panelFiltroCompras.Controls.Add(dateTimePickerDataCompraInicial);
            panelFiltroCompras.Controls.Add(labelCpf);
            panelFiltroCompras.Controls.Add(labelDataCompraInicial);
            panelFiltroCompras.Controls.Add(textBoxNomeCliente);
            panelFiltroCompras.Controls.Add(buttonLimparCompras);
            panelFiltroCompras.Controls.Add(buttonFiltrarCompras);
            panelFiltroCompras.Controls.Add(labelNomeCliente);
            panelFiltroCompras.Location = new Point(-4, 6);
            panelFiltroCompras.Name = "panelFiltroCompras";
            panelFiltroCompras.Size = new Size(1027, 94);
            panelFiltroCompras.TabIndex = 0;
            // 
            // labelDataCompraFinal
            // 
            labelDataCompraFinal.AutoSize = true;
            labelDataCompraFinal.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelDataCompraFinal.Location = new Point(439, 11);
            labelDataCompraFinal.Name = "labelDataCompraFinal";
            labelDataCompraFinal.Size = new Size(79, 21);
            labelDataCompraFinal.TabIndex = 30;
            labelDataCompraFinal.Text = "Data Final";
            // 
            // dateTimePickerDataCompraFinal
            // 
            dateTimePickerDataCompraFinal.Format = DateTimePickerFormat.Short;
            dateTimePickerDataCompraFinal.Location = new Point(439, 36);
            dateTimePickerDataCompraFinal.Name = "dateTimePickerDataCompraFinal";
            dateTimePickerDataCompraFinal.Size = new Size(114, 23);
            dateTimePickerDataCompraFinal.TabIndex = 29;
            dateTimePickerDataCompraFinal.ValueChanged += AoAlterarValorDataFinal;
            // 
            // maskedTextBoxCpf
            // 
            maskedTextBoxCpf.Culture = new System.Globalization.CultureInfo("");
            maskedTextBoxCpf.Location = new Point(150, 36);
            maskedTextBoxCpf.Mask = "000.000.000-00";
            maskedTextBoxCpf.Name = "maskedTextBoxCpf";
            maskedTextBoxCpf.Size = new Size(100, 23);
            maskedTextBoxCpf.TabIndex = 11;
            // 
            // dateTimePickerDataCompraInicial
            // 
            dateTimePickerDataCompraInicial.Format = DateTimePickerFormat.Short;
            dateTimePickerDataCompraInicial.Location = new Point(287, 36);
            dateTimePickerDataCompraInicial.Name = "dateTimePickerDataCompraInicial";
            dateTimePickerDataCompraInicial.Size = new Size(120, 23);
            dateTimePickerDataCompraInicial.TabIndex = 12;
            dateTimePickerDataCompraInicial.Value = new DateTime(2024, 7, 5, 0, 0, 0, 0);
            dateTimePickerDataCompraInicial.ValueChanged += AoMudarValorDataInicial;
            // 
            // labelCpf
            // 
            labelCpf.AutoSize = true;
            labelCpf.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelCpf.Location = new Point(150, 11);
            labelCpf.Name = "labelCpf";
            labelCpf.Size = new Size(37, 21);
            labelCpf.TabIndex = 28;
            labelCpf.Text = "CPF";
            // 
            // labelDataCompraInicial
            // 
            labelDataCompraInicial.AutoSize = true;
            labelDataCompraInicial.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelDataCompraInicial.Location = new Point(287, 11);
            labelDataCompraInicial.Name = "labelDataCompraInicial";
            labelDataCompraInicial.Size = new Size(86, 21);
            labelDataCompraInicial.TabIndex = 27;
            labelDataCompraInicial.Text = "Data Inicial";
            // 
            // textBoxNomeCliente
            // 
            textBoxNomeCliente.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            textBoxNomeCliente.Location = new Point(15, 36);
            textBoxNomeCliente.Name = "textBoxNomeCliente";
            textBoxNomeCliente.PlaceholderText = "Pesquisar";
            textBoxNomeCliente.Size = new Size(100, 23);
            textBoxNomeCliente.TabIndex = 10;
            // 
            // buttonLimparCompras
            // 
            buttonLimparCompras.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonLimparCompras.BackColor = SystemColors.ControlLight;
            buttonLimparCompras.Location = new Point(926, 36);
            buttonLimparCompras.Name = "buttonLimparCompras";
            buttonLimparCompras.Size = new Size(75, 23);
            buttonLimparCompras.TabIndex = 14;
            buttonLimparCompras.Text = "Limpar";
            buttonLimparCompras.UseVisualStyleBackColor = false;
            buttonLimparCompras.Click += AoClicarNoBotaoLimparDaAbaCompras;
            // 
            // buttonFiltrarCompras
            // 
            buttonFiltrarCompras.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonFiltrarCompras.BackColor = SystemColors.ControlLight;
            buttonFiltrarCompras.Location = new Point(845, 36);
            buttonFiltrarCompras.Name = "buttonFiltrarCompras";
            buttonFiltrarCompras.Size = new Size(75, 23);
            buttonFiltrarCompras.TabIndex = 13;
            buttonFiltrarCompras.Text = "Filtrar";
            buttonFiltrarCompras.UseVisualStyleBackColor = false;
            buttonFiltrarCompras.Click += AoClicarNoBotaoFiltrarDaAbaCompras;
            // 
            // labelNomeCliente
            // 
            labelNomeCliente.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            labelNomeCliente.AutoSize = true;
            labelNomeCliente.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelNomeCliente.Location = new Point(12, 11);
            labelNomeCliente.Name = "labelNomeCliente";
            labelNomeCliente.Size = new Size(53, 21);
            labelNomeCliente.TabIndex = 13;
            labelNomeCliente.Text = "Nome";
            // 
            // obraBindingSource1
            // 
            obraBindingSource1.DataSource = typeof(Dominio.Entidades.Obra);
            // 
            // colunaIdCompras
            // 
            colunaIdCompras.DataPropertyName = "Id";
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleCenter;
            colunaIdCompras.DefaultCellStyle = dataGridViewCellStyle8;
            colunaIdCompras.FillWeight = 20F;
            colunaIdCompras.HeaderText = "ID";
            colunaIdCompras.Name = "colunaIdCompras";
            colunaIdCompras.ReadOnly = true;
            // 
            // cpfDataGridViewTextBoxColumn
            // 
            cpfDataGridViewTextBoxColumn.DataPropertyName = "Cpf";
            cpfDataGridViewTextBoxColumn.FillWeight = 60F;
            cpfDataGridViewTextBoxColumn.HeaderText = "CPF";
            cpfDataGridViewTextBoxColumn.Name = "cpfDataGridViewTextBoxColumn";
            cpfDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            nomeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telefoneDataGridViewTextBoxColumn
            // 
            telefoneDataGridViewTextBoxColumn.DataPropertyName = "Telefone";
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleCenter;
            telefoneDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle9;
            telefoneDataGridViewTextBoxColumn.FillWeight = 60F;
            telefoneDataGridViewTextBoxColumn.HeaderText = "Telefone";
            telefoneDataGridViewTextBoxColumn.Name = "telefoneDataGridViewTextBoxColumn";
            telefoneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            emailDataGridViewTextBoxColumn.HeaderText = "E-mail";
            emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            emailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // valorCompraDataGridViewTextBoxColumn
            // 
            valorCompraDataGridViewTextBoxColumn.DataPropertyName = "ValorCompra";
            valorCompraDataGridViewTextBoxColumn.FillWeight = 40F;
            valorCompraDataGridViewTextBoxColumn.HeaderText = "Valor";
            valorCompraDataGridViewTextBoxColumn.Name = "valorCompraDataGridViewTextBoxColumn";
            valorCompraDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataCompraDataGridViewTextBoxColumn
            // 
            dataCompraDataGridViewTextBoxColumn.DataPropertyName = "DataCompra";
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataCompraDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle10;
            dataCompraDataGridViewTextBoxColumn.HeaderText = "Data da compra";
            dataCompraDataGridViewTextBoxColumn.Name = "dataCompraDataGridViewTextBoxColumn";
            dataCompraDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // colunaIdObras
            // 
            colunaIdObras.DataPropertyName = "ID";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            colunaIdObras.DefaultCellStyle = dataGridViewCellStyle2;
            colunaIdObras.FillWeight = 6.272095F;
            colunaIdObras.HeaderText = "Id";
            colunaIdObras.Name = "colunaIdObras";
            colunaIdObras.ReadOnly = true;
            // 
            // Sinopse
            // 
            Sinopse.DataPropertyName = "Sinopse";
            Sinopse.HeaderText = "Sinopse";
            Sinopse.Name = "Sinopse";
            Sinopse.ReadOnly = true;
            Sinopse.Visible = false;
            // 
            // tituloDataGridViewTextBoxColumn
            // 
            tituloDataGridViewTextBoxColumn.DataPropertyName = "Titulo";
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            tituloDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            tituloDataGridViewTextBoxColumn.FillWeight = 30.26575F;
            tituloDataGridViewTextBoxColumn.HeaderText = "Título";
            tituloDataGridViewTextBoxColumn.Name = "tituloDataGridViewTextBoxColumn";
            tituloDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // autorDataGridViewTextBoxColumn
            // 
            autorDataGridViewTextBoxColumn.DataPropertyName = "Autor";
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            autorDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            autorDataGridViewTextBoxColumn.FillWeight = 30.3542786F;
            autorDataGridViewTextBoxColumn.HeaderText = "Autor";
            autorDataGridViewTextBoxColumn.Name = "autorDataGridViewTextBoxColumn";
            autorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numeroCapitulosDataGridViewTextBoxColumn
            // 
            numeroCapitulosDataGridViewTextBoxColumn.DataPropertyName = "NumeroCapitulos";
            numeroCapitulosDataGridViewTextBoxColumn.FillWeight = 13.3542786F;
            numeroCapitulosDataGridViewTextBoxColumn.HeaderText = "Capítulos";
            numeroCapitulosDataGridViewTextBoxColumn.Name = "numeroCapitulosDataGridViewTextBoxColumn";
            numeroCapitulosDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // valorObraDataGridViewTextBoxColumn
            // 
            valorObraDataGridViewTextBoxColumn.DataPropertyName = "ValorObra";
            dataGridViewCellStyle5.Padding = new Padding(10, 0, 0, 0);
            valorObraDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
            valorObraDataGridViewTextBoxColumn.FillWeight = 15.3542786F;
            valorObraDataGridViewTextBoxColumn.HeaderText = "Valor";
            valorObraDataGridViewTextBoxColumn.Name = "valorObraDataGridViewTextBoxColumn";
            valorObraDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // formatoDataGridViewTextBoxColumn
            // 
            formatoDataGridViewTextBoxColumn.DataPropertyName = "Formato";
            formatoDataGridViewTextBoxColumn.FillWeight = 15.3542786F;
            formatoDataGridViewTextBoxColumn.HeaderText = "Formato";
            formatoDataGridViewTextBoxColumn.Name = "formatoDataGridViewTextBoxColumn";
            formatoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // foiFinalizadaDataGridViewCheckBoxColumn
            // 
            foiFinalizadaDataGridViewCheckBoxColumn.DataPropertyName = "FoiFinalizada";
            foiFinalizadaDataGridViewCheckBoxColumn.FillWeight = 15.3542786F;
            foiFinalizadaDataGridViewCheckBoxColumn.FlatStyle = FlatStyle.System;
            foiFinalizadaDataGridViewCheckBoxColumn.HeaderText = "Finalizada";
            foiFinalizadaDataGridViewCheckBoxColumn.Name = "foiFinalizadaDataGridViewCheckBoxColumn";
            foiFinalizadaDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // inicioPublicacaoDataGridViewTextBoxColumn
            // 
            inicioPublicacaoDataGridViewTextBoxColumn.DataPropertyName = "InicioPublicacao";
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            inicioPublicacaoDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle6;
            inicioPublicacaoDataGridViewTextBoxColumn.FillWeight = 20.3542786F;
            inicioPublicacaoDataGridViewTextBoxColumn.HeaderText = "Início da Publicação";
            inicioPublicacaoDataGridViewTextBoxColumn.Name = "inicioPublicacaoDataGridViewTextBoxColumn";
            inicioPublicacaoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // FormListagem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1013, 453);
            Controls.Add(tabControl1);
            MinimumSize = new Size(1029, 492);
            Name = "FormListagem";
            Text = "Coders Growth";
            Load += AoCarregarFormulario;
            ((System.ComponentModel.ISupportInitialize)obraBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridObras).EndInit();
            tabControl1.ResumeLayout(false);
            tabPageObras.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            panelBottomObras.ResumeLayout(false);
            panelFiltroObras.ResumeLayout(false);
            panelFiltroObras.PerformLayout();
            tabPageCompras.ResumeLayout(false);
            groupBoxCompras.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridCompras).EndInit();
            ((System.ComponentModel.ISupportInitialize)compraClienteBindingSource).EndInit();
            panel2BottomCompras.ResumeLayout(false);
            panelFiltroCompras.ResumeLayout(false);
            panelFiltroCompras.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)obraBindingSource1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private BindingSource obraBindingSource;
        private DataGridView dataGridObras;
        private TabControl tabControl1;
        private TabPage tabPageObras;
        private TabPage tabPageCompras;
        private Panel panelBottomObras;
        private Panel panelFiltroObras;
        private BindingSource compraClienteBindingSource;
        private Panel panel2BottomCompras;
        private Panel panelFiltroCompras;
        private Label labelTituloObra;
        private TextBox textBoxTituloObra;
        private TextBox textBoxAutorObra;
        private Label labelAutorObra;
        private ComboBox comboBoxFormatoObra;
        private Label labelFormatoObra;
        private RadioButton radioButtonStatusObraFinalizada;
        private Label labelStatus;
        private RadioButton radioButtonStatusObraEmLancamento;
        private TextBox textBoxAnoInicalObra;
        private Label labelAnoObra;
        private Button buttonLimparObras;
        private Button buttonFiltroObra;
        private Button buttonLimparCompras;
        private Button buttonFiltrarCompras;
        private Label labelDataCompraFinal;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private Label label2;
        private Label label3;
        private ComboBox comboBox1;
        private TextBox textBox2;
        private Label label4;
        private TextBox textBox3;
        private Label labelNomeCliente;
        private Label labelCpf;
        private Label labelDataCompraInicial;
        private TextBox textBoxNomeCliente;
        private BindingSource obraBindingSource1;
        private GroupBox groupBox1;
        private DataGridView dataGridCompras;
        private GroupBox groupBoxCompras;
        private DateTimePicker dateTimePickerDataCompraInicial;
        private MaskedTextBox maskedTextBoxCpf;
        private Button buttonAdicionarObra;
        private Button buttonAdicionarCompra;
        private Button buttonRemoverObra;
        private Button buttonRemoverCompra;
        private Button buttonEditarObra;
        private Button buttonEditarCompra;
        private DateTimePicker dateTimePickerDataCompraFinal;
        private TextBox textBoxAnoFinalObra;
        private Label label1;
        private DataGridViewTextBoxColumn colunaIdObras;
        private DataGridViewTextBoxColumn Sinopse;
        private DataGridViewTextBoxColumn tituloDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn autorDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn numeroCapitulosDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn valorObraDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn formatoDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn foiFinalizadaDataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn inicioPublicacaoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn colunaIdCompras;
        private DataGridViewTextBoxColumn cpfDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn telefoneDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn valorCompraDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dataCompraDataGridViewTextBoxColumn;
    }
}
