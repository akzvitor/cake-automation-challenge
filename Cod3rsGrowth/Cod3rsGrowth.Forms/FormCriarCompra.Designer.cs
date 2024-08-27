namespace Cod3rsGrowth.Forms
{
    partial class FormCriarCompra
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            labelCpf = new Label();
            labelNome = new Label();
            labelTelefone = new Label();
            labelEmail = new Label();
            labelValorCompra = new Label();
            maskedTextBoxCpf = new MaskedTextBox();
            maskedTextBoxTelefone = new MaskedTextBox();
            textBoxEmail = new TextBox();
            textBoxNome = new TextBox();
            textBoxValorCompra = new TextBox();
            buttonSalvar = new Button();
            buttonCancelar = new Button();
            dataGridViewCatalogoObras = new DataGridView();
            colunaId = new DataGridViewTextBoxColumn();
            tituloDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            formatoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            numeroCapitulosDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            foiFinalizadaDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            ValorObra = new DataGridViewTextBoxColumn();
            colunaSelecao = new DataGridViewCheckBoxColumn();
            autorDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            inicioPublicacaoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            sinopseDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            capaImagemBase64DataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            obraBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)dataGridViewCatalogoObras).BeginInit();
            ((System.ComponentModel.ISupportInitialize)obraBindingSource).BeginInit();
            SuspendLayout();
            // 
            // labelCpf
            // 
            labelCpf.AutoSize = true;
            labelCpf.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelCpf.Location = new Point(9, 127);
            labelCpf.Name = "labelCpf";
            labelCpf.Size = new Size(33, 19);
            labelCpf.TabIndex = 0;
            labelCpf.Text = "CPF";
            // 
            // labelNome
            // 
            labelNome.AutoSize = true;
            labelNome.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelNome.Location = new Point(9, 12);
            labelNome.Name = "labelNome";
            labelNome.Size = new Size(46, 19);
            labelNome.TabIndex = 1;
            labelNome.Text = "Nome";
            // 
            // labelTelefone
            // 
            labelTelefone.AutoSize = true;
            labelTelefone.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelTelefone.Location = new Point(9, 189);
            labelTelefone.Name = "labelTelefone";
            labelTelefone.Size = new Size(59, 19);
            labelTelefone.TabIndex = 2;
            labelTelefone.Text = "Telefone";
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelEmail.Location = new Point(9, 69);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(47, 19);
            labelEmail.TabIndex = 3;
            labelEmail.Text = "E-mail";
            // 
            // labelValorCompra
            // 
            labelValorCompra.AutoSize = true;
            labelValorCompra.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelValorCompra.Location = new Point(184, 310);
            labelValorCompra.Name = "labelValorCompra";
            labelValorCompra.Size = new Size(145, 19);
            labelValorCompra.TabIndex = 5;
            labelValorCompra.Text = "Valor Total da Compra";
            labelValorCompra.Visible = false;
            // 
            // maskedTextBoxCpf
            // 
            maskedTextBoxCpf.BackColor = SystemColors.Control;
            maskedTextBoxCpf.Culture = new System.Globalization.CultureInfo("");
            maskedTextBoxCpf.Location = new Point(12, 149);
            maskedTextBoxCpf.Mask = "000.000.000-00";
            maskedTextBoxCpf.Name = "maskedTextBoxCpf";
            maskedTextBoxCpf.Size = new Size(89, 23);
            maskedTextBoxCpf.TabIndex = 3;
            // 
            // maskedTextBoxTelefone
            // 
            maskedTextBoxTelefone.BackColor = SystemColors.Control;
            maskedTextBoxTelefone.Location = new Point(12, 211);
            maskedTextBoxTelefone.Mask = "(00)00000-0000";
            maskedTextBoxTelefone.Name = "maskedTextBoxTelefone";
            maskedTextBoxTelefone.Size = new Size(89, 23);
            maskedTextBoxTelefone.TabIndex = 4;
            // 
            // textBoxEmail
            // 
            textBoxEmail.BackColor = SystemColors.Control;
            textBoxEmail.Location = new Point(12, 91);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(139, 23);
            textBoxEmail.TabIndex = 2;
            // 
            // textBoxNome
            // 
            textBoxNome.BackColor = SystemColors.Control;
            textBoxNome.Location = new Point(12, 34);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(139, 23);
            textBoxNome.TabIndex = 1;
            // 
            // textBoxValorCompra
            // 
            textBoxValorCompra.BackColor = SystemColors.Window;
            textBoxValorCompra.BorderStyle = BorderStyle.None;
            textBoxValorCompra.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxValorCompra.Location = new Point(187, 332);
            textBoxValorCompra.Name = "textBoxValorCompra";
            textBoxValorCompra.Size = new Size(164, 22);
            textBoxValorCompra.TabIndex = 11;
            textBoxValorCompra.Text = "0,00";
            textBoxValorCompra.Visible = false;
            // 
            // buttonSalvar
            // 
            buttonSalvar.BackColor = SystemColors.ButtonHighlight;
            buttonSalvar.Location = new Point(500, 334);
            buttonSalvar.Name = "buttonSalvar";
            buttonSalvar.Size = new Size(95, 28);
            buttonSalvar.TabIndex = 12;
            buttonSalvar.Text = "Salvar";
            buttonSalvar.UseVisualStyleBackColor = false;
            // 
            // buttonCancelar
            // 
            buttonCancelar.BackColor = SystemColors.ButtonHighlight;
            buttonCancelar.Location = new Point(9, 334);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(95, 28);
            buttonCancelar.TabIndex = 13;
            buttonCancelar.Text = "Cancelar";
            buttonCancelar.UseVisualStyleBackColor = false;
            buttonCancelar.Click += AoClicarNoBotaoCancelar;
            // 
            // dataGridViewCatalogoObras
            // 
            dataGridViewCatalogoObras.AllowUserToDeleteRows = false;
            dataGridViewCatalogoObras.AllowUserToResizeColumns = false;
            dataGridViewCatalogoObras.AllowUserToResizeRows = false;
            dataGridViewCatalogoObras.AutoGenerateColumns = false;
            dataGridViewCatalogoObras.BackgroundColor = SystemColors.Control;
            dataGridViewCatalogoObras.BorderStyle = BorderStyle.None;
            dataGridViewCatalogoObras.CellBorderStyle = DataGridViewCellBorderStyle.Sunken;
            dataGridViewCatalogoObras.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewCatalogoObras.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCatalogoObras.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCatalogoObras.Columns.AddRange(new DataGridViewColumn[] { colunaId, tituloDataGridViewTextBoxColumn, formatoDataGridViewTextBoxColumn, numeroCapitulosDataGridViewTextBoxColumn, foiFinalizadaDataGridViewCheckBoxColumn, ValorObra, colunaSelecao, autorDataGridViewTextBoxColumn, inicioPublicacaoDataGridViewTextBoxColumn, sinopseDataGridViewTextBoxColumn, capaImagemBase64DataGridViewTextBoxColumn });
            dataGridViewCatalogoObras.DataSource = obraBindingSource;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridViewCatalogoObras.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCatalogoObras.Location = new Point(184, 12);
            dataGridViewCatalogoObras.Name = "dataGridViewCatalogoObras";
            dataGridViewCatalogoObras.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCatalogoObras.RowHeadersVisible = false;
            dataGridViewCatalogoObras.RowTemplate.Height = 25;
            dataGridViewCatalogoObras.Size = new Size(411, 274);
            dataGridViewCatalogoObras.TabIndex = 14;
            // 
            // colunaId
            // 
            colunaId.DataPropertyName = "Id";
            colunaId.HeaderText = "Id";
            colunaId.Name = "colunaId";
            colunaId.Visible = false;
            // 
            // tituloDataGridViewTextBoxColumn
            // 
            tituloDataGridViewTextBoxColumn.DataPropertyName = "Titulo";
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            tituloDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            tituloDataGridViewTextBoxColumn.HeaderText = "Titulo";
            tituloDataGridViewTextBoxColumn.Name = "tituloDataGridViewTextBoxColumn";
            tituloDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // formatoDataGridViewTextBoxColumn
            // 
            formatoDataGridViewTextBoxColumn.DataPropertyName = "Formato";
            formatoDataGridViewTextBoxColumn.HeaderText = "Formato";
            formatoDataGridViewTextBoxColumn.Name = "formatoDataGridViewTextBoxColumn";
            formatoDataGridViewTextBoxColumn.ReadOnly = true;
            formatoDataGridViewTextBoxColumn.Width = 70;
            // 
            // numeroCapitulosDataGridViewTextBoxColumn
            // 
            numeroCapitulosDataGridViewTextBoxColumn.DataPropertyName = "NumeroCapitulos";
            numeroCapitulosDataGridViewTextBoxColumn.HeaderText = "Capítulos";
            numeroCapitulosDataGridViewTextBoxColumn.Name = "numeroCapitulosDataGridViewTextBoxColumn";
            numeroCapitulosDataGridViewTextBoxColumn.ReadOnly = true;
            numeroCapitulosDataGridViewTextBoxColumn.Width = 69;
            // 
            // foiFinalizadaDataGridViewCheckBoxColumn
            // 
            foiFinalizadaDataGridViewCheckBoxColumn.DataPropertyName = "FoiFinalizada";
            foiFinalizadaDataGridViewCheckBoxColumn.HeaderText = "Finalizada";
            foiFinalizadaDataGridViewCheckBoxColumn.Name = "foiFinalizadaDataGridViewCheckBoxColumn";
            foiFinalizadaDataGridViewCheckBoxColumn.ReadOnly = true;
            foiFinalizadaDataGridViewCheckBoxColumn.Width = 70;
            // 
            // ValorObra
            // 
            ValorObra.DataPropertyName = "ValorObra";
            ValorObra.HeaderText = "Valor";
            ValorObra.Name = "ValorObra";
            ValorObra.ReadOnly = true;
            ValorObra.Width = 71;
            // 
            // colunaSelecao
            // 
            colunaSelecao.FalseValue = "false";
            colunaSelecao.HeaderText = "";
            colunaSelecao.IndeterminateValue = "false";
            colunaSelecao.Name = "colunaSelecao";
            colunaSelecao.TrueValue = "true";
            colunaSelecao.Width = 30;
            // 
            // autorDataGridViewTextBoxColumn
            // 
            autorDataGridViewTextBoxColumn.DataPropertyName = "Autor";
            autorDataGridViewTextBoxColumn.HeaderText = "Autor";
            autorDataGridViewTextBoxColumn.Name = "autorDataGridViewTextBoxColumn";
            autorDataGridViewTextBoxColumn.Visible = false;
            // 
            // inicioPublicacaoDataGridViewTextBoxColumn
            // 
            inicioPublicacaoDataGridViewTextBoxColumn.DataPropertyName = "InicioPublicacao";
            inicioPublicacaoDataGridViewTextBoxColumn.HeaderText = "InicioPublicacao";
            inicioPublicacaoDataGridViewTextBoxColumn.Name = "inicioPublicacaoDataGridViewTextBoxColumn";
            inicioPublicacaoDataGridViewTextBoxColumn.Visible = false;
            // 
            // sinopseDataGridViewTextBoxColumn
            // 
            sinopseDataGridViewTextBoxColumn.DataPropertyName = "Sinopse";
            sinopseDataGridViewTextBoxColumn.HeaderText = "Sinopse";
            sinopseDataGridViewTextBoxColumn.Name = "sinopseDataGridViewTextBoxColumn";
            sinopseDataGridViewTextBoxColumn.Visible = false;
            // 
            // capaImagemBase64DataGridViewTextBoxColumn
            // 
            capaImagemBase64DataGridViewTextBoxColumn.DataPropertyName = "CapaImagemBase64";
            capaImagemBase64DataGridViewTextBoxColumn.HeaderText = "CapaImagemBase64";
            capaImagemBase64DataGridViewTextBoxColumn.Name = "capaImagemBase64DataGridViewTextBoxColumn";
            capaImagemBase64DataGridViewTextBoxColumn.Visible = false;
            // 
            // obraBindingSource
            // 
            obraBindingSource.DataSource = typeof(Dominio.Entidades.Obra);
            // 
            // FormCriarCompra
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(608, 372);
            Controls.Add(dataGridViewCatalogoObras);
            Controls.Add(buttonCancelar);
            Controls.Add(buttonSalvar);
            Controls.Add(textBoxValorCompra);
            Controls.Add(textBoxNome);
            Controls.Add(textBoxEmail);
            Controls.Add(maskedTextBoxTelefone);
            Controls.Add(maskedTextBoxCpf);
            Controls.Add(labelValorCompra);
            Controls.Add(labelEmail);
            Controls.Add(labelTelefone);
            Controls.Add(labelNome);
            Controls.Add(labelCpf);
            MaximizeBox = false;
            MaximumSize = new Size(624, 411);
            MinimumSize = new Size(624, 411);
            Name = "FormCriarCompra";
            Text = "Cadastro de Compra";
            Load += AoCarregarFormulario;
            ((System.ComponentModel.ISupportInitialize)dataGridViewCatalogoObras).EndInit();
            ((System.ComponentModel.ISupportInitialize)obraBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelCpf;
        private Label labelNome;
        private Label labelTelefone;
        private Label labelEmail;
        private Label labelValorCompra;
        private MaskedTextBox maskedTextBoxCpf;
        private MaskedTextBox maskedTextBoxTelefone;
        private TextBox textBoxEmail;
        private TextBox textBoxNome;
        private TextBox textBoxValorCompra;
        private Button buttonSalvar;
        private Button buttonCancelar;
        private DataGridView dataGridViewCatalogoObras;
        private BindingSource obraBindingSource;
        private DataGridViewTextBoxColumn valorObraDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn colunaId;
        private DataGridViewTextBoxColumn tituloDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn formatoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn numeroCapitulosDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn foiFinalizadaDataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn ValorObra;
        private DataGridViewCheckBoxColumn colunaSelecao;
        private DataGridViewTextBoxColumn autorDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn inicioPublicacaoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn sinopseDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn capaImagemBase64DataGridViewTextBoxColumn;
    }
}