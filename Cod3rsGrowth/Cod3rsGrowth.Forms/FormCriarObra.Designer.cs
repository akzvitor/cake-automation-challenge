namespace Cod3rsGrowth.Forms
{
    partial class FormCriarObra
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
            components = new System.ComponentModel.Container();
            labelTitulo = new Label();
            labelAutor = new Label();
            labelSinopse = new Label();
            labelCapitulos = new Label();
            labelValor = new Label();
            labelInicioPublicacao = new Label();
            labelStatus = new Label();
            textBoxTitulo = new TextBox();
            textBoxAutor = new TextBox();
            dateTimePickerInicioPublicacao = new DateTimePicker();
            radioButtonFinalizada = new RadioButton();
            radioButtonEmLancamento = new RadioButton();
            richTextBoxSinopse = new RichTextBox();
            numericUpDownCapitulos = new NumericUpDown();
            textBoxValor = new TextBox();
            buttonSalvar = new Button();
            buttonCancelar = new Button();
            labelFormato = new Label();
            comboBoxFormato = new ComboBox();
            obraBindingSource = new BindingSource(components);
            generosBindingSource = new BindingSource(components);
            generosBindingSource1 = new BindingSource(components);
            generosBindingSource2 = new BindingSource(components);
            labelGeneros = new Label();
            checkedListBoxGeneros = new CheckedListBox();
            ((System.ComponentModel.ISupportInitialize)numericUpDownCapitulos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)obraBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)generosBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)generosBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)generosBindingSource2).BeginInit();
            SuspendLayout();
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelTitulo.Location = new Point(5, 10);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(43, 19);
            labelTitulo.TabIndex = 0;
            labelTitulo.Text = "Título";
            // 
            // labelAutor
            // 
            labelAutor.AutoSize = true;
            labelAutor.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelAutor.Location = new Point(8, 68);
            labelAutor.Name = "labelAutor";
            labelAutor.Size = new Size(44, 19);
            labelAutor.TabIndex = 1;
            labelAutor.Text = "Autor";
            // 
            // labelSinopse
            // 
            labelSinopse.AutoSize = true;
            labelSinopse.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelSinopse.Location = new Point(5, 277);
            labelSinopse.Name = "labelSinopse";
            labelSinopse.Size = new Size(56, 19);
            labelSinopse.TabIndex = 2;
            labelSinopse.Text = "Sinopse";
            // 
            // labelCapitulos
            // 
            labelCapitulos.AutoSize = true;
            labelCapitulos.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelCapitulos.Location = new Point(209, 10);
            labelCapitulos.Name = "labelCapitulos";
            labelCapitulos.Size = new Size(66, 19);
            labelCapitulos.TabIndex = 3;
            labelCapitulos.Text = "Capítulos";
            // 
            // labelValor
            // 
            labelValor.AutoSize = true;
            labelValor.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelValor.Location = new Point(8, 129);
            labelValor.Name = "labelValor";
            labelValor.Size = new Size(40, 19);
            labelValor.TabIndex = 4;
            labelValor.Text = "Valor";
            // 
            // labelInicioPublicacao
            // 
            labelInicioPublicacao.AutoSize = true;
            labelInicioPublicacao.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelInicioPublicacao.Location = new Point(5, 221);
            labelInicioPublicacao.Name = "labelInicioPublicacao";
            labelInicioPublicacao.Size = new Size(128, 19);
            labelInicioPublicacao.TabIndex = 5;
            labelInicioPublicacao.Text = "Início da Publicação";
            // 
            // labelStatus
            // 
            labelStatus.AutoSize = true;
            labelStatus.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelStatus.Location = new Point(209, 129);
            labelStatus.Name = "labelStatus";
            labelStatus.Size = new Size(47, 19);
            labelStatus.TabIndex = 6;
            labelStatus.Text = "Status";
            // 
            // textBoxTitulo
            // 
            textBoxTitulo.BackColor = SystemColors.Control;
            textBoxTitulo.BorderStyle = BorderStyle.FixedSingle;
            textBoxTitulo.Location = new Point(12, 32);
            textBoxTitulo.Name = "textBoxTitulo";
            textBoxTitulo.Size = new Size(150, 23);
            textBoxTitulo.TabIndex = 1;
            // 
            // textBoxAutor
            // 
            textBoxAutor.BackColor = SystemColors.Control;
            textBoxAutor.BorderStyle = BorderStyle.FixedSingle;
            textBoxAutor.Location = new Point(12, 90);
            textBoxAutor.Name = "textBoxAutor";
            textBoxAutor.Size = new Size(150, 23);
            textBoxAutor.TabIndex = 3;
            // 
            // dateTimePickerInicioPublicacao
            // 
            dateTimePickerInicioPublicacao.CalendarMonthBackground = SystemColors.Control;
            dateTimePickerInicioPublicacao.Format = DateTimePickerFormat.Short;
            dateTimePickerInicioPublicacao.Location = new Point(9, 243);
            dateTimePickerInicioPublicacao.Name = "dateTimePickerInicioPublicacao";
            dateTimePickerInicioPublicacao.Size = new Size(151, 23);
            dateTimePickerInicioPublicacao.TabIndex = 8;
            // 
            // radioButtonFinalizada
            // 
            radioButtonFinalizada.AutoSize = true;
            radioButtonFinalizada.BackColor = SystemColors.Window;
            radioButtonFinalizada.Location = new Point(212, 180);
            radioButtonFinalizada.Name = "radioButtonFinalizada";
            radioButtonFinalizada.Size = new Size(77, 19);
            radioButtonFinalizada.TabIndex = 7;
            radioButtonFinalizada.TabStop = true;
            radioButtonFinalizada.Text = "Finalizada";
            radioButtonFinalizada.UseVisualStyleBackColor = false;
            // 
            // radioButtonEmLancamento
            // 
            radioButtonEmLancamento.AutoSize = true;
            radioButtonEmLancamento.Location = new Point(212, 155);
            radioButtonEmLancamento.Name = "radioButtonEmLancamento";
            radioButtonEmLancamento.Size = new Size(111, 19);
            radioButtonEmLancamento.TabIndex = 6;
            radioButtonEmLancamento.TabStop = true;
            radioButtonEmLancamento.Text = "Em Lançamento";
            radioButtonEmLancamento.UseVisualStyleBackColor = true;
            // 
            // richTextBoxSinopse
            // 
            richTextBoxSinopse.BackColor = SystemColors.Control;
            richTextBoxSinopse.BorderStyle = BorderStyle.FixedSingle;
            richTextBoxSinopse.Location = new Point(9, 299);
            richTextBoxSinopse.Name = "richTextBoxSinopse";
            richTextBoxSinopse.Size = new Size(153, 110);
            richTextBoxSinopse.TabIndex = 9;
            richTextBoxSinopse.Text = "";
            // 
            // numericUpDownCapitulos
            // 
            numericUpDownCapitulos.BackColor = SystemColors.Control;
            numericUpDownCapitulos.Location = new Point(212, 32);
            numericUpDownCapitulos.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numericUpDownCapitulos.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownCapitulos.Name = "numericUpDownCapitulos";
            numericUpDownCapitulos.Size = new Size(125, 23);
            numericUpDownCapitulos.TabIndex = 2;
            numericUpDownCapitulos.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // textBoxValor
            // 
            textBoxValor.BackColor = SystemColors.Control;
            textBoxValor.BorderStyle = BorderStyle.FixedSingle;
            textBoxValor.Location = new Point(12, 151);
            textBoxValor.Name = "textBoxValor";
            textBoxValor.Size = new Size(150, 23);
            textBoxValor.TabIndex = 5;
            textBoxValor.Text = "0,00";
            textBoxValor.TextAlign = HorizontalAlignment.Right;
            textBoxValor.TextChanged += AoAlterarTextoDoCampoValor;
            textBoxValor.KeyPress += AoPressionarTeclaNoCampoValor;
            // 
            // buttonSalvar
            // 
            buttonSalvar.BackColor = SystemColors.ButtonHighlight;
            buttonSalvar.Location = new Point(242, 434);
            buttonSalvar.Name = "buttonSalvar";
            buttonSalvar.Size = new Size(95, 28);
            buttonSalvar.TabIndex = 11;
            buttonSalvar.Text = "Salvar";
            buttonSalvar.UseVisualStyleBackColor = false;
            // 
            // buttonCancelar
            // 
            buttonCancelar.BackColor = SystemColors.ButtonHighlight;
            buttonCancelar.Location = new Point(9, 434);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(88, 28);
            buttonCancelar.TabIndex = 12;
            buttonCancelar.Text = "Cancelar";
            buttonCancelar.UseVisualStyleBackColor = false;
            buttonCancelar.Click += AoClicarNoBotaoCancelar;
            // 
            // labelFormato
            // 
            labelFormato.AutoSize = true;
            labelFormato.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelFormato.Location = new Point(209, 68);
            labelFormato.Name = "labelFormato";
            labelFormato.Size = new Size(61, 19);
            labelFormato.TabIndex = 17;
            labelFormato.Text = "Formato";
            // 
            // comboBoxFormato
            // 
            comboBoxFormato.BackColor = SystemColors.Control;
            comboBoxFormato.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxFormato.FormattingEnabled = true;
            comboBoxFormato.Location = new Point(213, 90);
            comboBoxFormato.Name = "comboBoxFormato";
            comboBoxFormato.Size = new Size(124, 23);
            comboBoxFormato.TabIndex = 4;
            // 
            // obraBindingSource
            // 
            obraBindingSource.DataSource = typeof(Dominio.Entidades.Obra);
            // 
            // generosBindingSource
            // 
            generosBindingSource.DataMember = "Generos";
            generosBindingSource.DataSource = obraBindingSource;
            // 
            // generosBindingSource1
            // 
            generosBindingSource1.DataMember = "Generos";
            generosBindingSource1.DataSource = obraBindingSource;
            // 
            // generosBindingSource2
            // 
            generosBindingSource2.DataMember = "Generos";
            generosBindingSource2.DataSource = obraBindingSource;
            // 
            // labelGeneros
            // 
            labelGeneros.AutoSize = true;
            labelGeneros.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelGeneros.Location = new Point(209, 221);
            labelGeneros.Name = "labelGeneros";
            labelGeneros.Size = new Size(60, 19);
            labelGeneros.TabIndex = 20;
            labelGeneros.Text = "Generos";
            // 
            // checkedListBoxGeneros
            // 
            checkedListBoxGeneros.BackColor = SystemColors.Control;
            checkedListBoxGeneros.BorderStyle = BorderStyle.FixedSingle;
            checkedListBoxGeneros.CheckOnClick = true;
            checkedListBoxGeneros.FormattingEnabled = true;
            checkedListBoxGeneros.Items.AddRange(new object[] { "Acao", "ArtesMarciais", "Aventura", "Comedia", "Drama", "Ecchi", "Espaco", "Esporte", "Fantasia", "Harem", "Historico", "Horror", "Jogos", "MahouShoujo", "Mecha", "Militar", "Misterio", "Musical", "Psicologico", "Romance", "Samurai", "SciFi", "Seinen", "Shoujo", "Shounen", "SliceOfLife", "Sobrenatural", "VidaEscolar", "Yaoi", "Yuri" });
            checkedListBoxGeneros.Location = new Point(212, 243);
            checkedListBoxGeneros.Name = "checkedListBoxGeneros";
            checkedListBoxGeneros.Size = new Size(124, 164);
            checkedListBoxGeneros.TabIndex = 10;
            // 
            // FormCriarObra
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(352, 476);
            Controls.Add(labelGeneros);
            Controls.Add(checkedListBoxGeneros);
            Controls.Add(comboBoxFormato);
            Controls.Add(labelFormato);
            Controls.Add(buttonCancelar);
            Controls.Add(buttonSalvar);
            Controls.Add(textBoxValor);
            Controls.Add(numericUpDownCapitulos);
            Controls.Add(richTextBoxSinopse);
            Controls.Add(radioButtonEmLancamento);
            Controls.Add(radioButtonFinalizada);
            Controls.Add(dateTimePickerInicioPublicacao);
            Controls.Add(textBoxAutor);
            Controls.Add(textBoxTitulo);
            Controls.Add(labelStatus);
            Controls.Add(labelInicioPublicacao);
            Controls.Add(labelValor);
            Controls.Add(labelCapitulos);
            Controls.Add(labelSinopse);
            Controls.Add(labelAutor);
            Controls.Add(labelTitulo);
            MaximizeBox = false;
            MaximumSize = new Size(368, 515);
            MinimumSize = new Size(368, 515);
            Name = "FormCriarObra";
            Text = "Cadastro de Obra";
            ((System.ComponentModel.ISupportInitialize)numericUpDownCapitulos).EndInit();
            ((System.ComponentModel.ISupportInitialize)obraBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)generosBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)generosBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)generosBindingSource2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTitulo;
        private Label labelAutor;
        private Label labelSinopse;
        private Label labelCapitulos;
        private Label labelValor;
        private Label labelInicioPublicacao;
        private Label labelStatus;
        private TextBox textBoxTitulo;
        private TextBox textBoxAutor;
        private DateTimePicker dateTimePickerInicioPublicacao;
        private RadioButton radioButtonFinalizada;
        private RadioButton radioButtonEmLancamento;
        private RichTextBox richTextBoxSinopse;
        private NumericUpDown numericUpDownCapitulos;
        private TextBox textBoxValor;
        private Button buttonSalvar;
        private Button buttonCancelar;
        private Label labelFormato;
        private ComboBox comboBoxFormato;
        private BindingSource generosBindingSource2;
        private BindingSource obraBindingSource;
        private BindingSource generosBindingSource;
        private BindingSource generosBindingSource1;
        private Label labelGeneros;
        private CheckedListBox checkedListBoxGeneros;
    }
}