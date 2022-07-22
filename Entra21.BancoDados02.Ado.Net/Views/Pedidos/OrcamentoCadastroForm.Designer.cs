namespace Entra21.BancoDados02.Ado.Net.Views.Pedidos
{
    partial class OrcamentoCadastroForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label3 = new System.Windows.Forms.Label();
            this.labelCliente = new System.Windows.Forms.Label();
            this.buttonGerarPedido = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonFinalizarOrcamento = new System.Windows.Forms.Button();
            this.comboBoxCliente = new System.Windows.Forms.ComboBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.ColumnNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnValorUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnValorTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBoxProduto = new System.Windows.Forms.ComboBox();
            this.labelProdutoObrigatoriedade = new System.Windows.Forms.Label();
            this.labelProduto = new System.Windows.Forms.Label();
            this.labelProdutoValorUnitario = new System.Windows.Forms.Label();
            this.labelProdutoValorUnitarioValor = new System.Windows.Forms.Label();
            this.labelQuantidade = new System.Windows.Forms.Label();
            this.numericUpDownQuantidade = new System.Windows.Forms.NumericUpDown();
            this.labelProdutoValorTotal = new System.Windows.Forms.Label();
            this.labelProdutoValorTotalValor = new System.Windows.Forms.Label();
            this.buttonAdicionarProduto = new System.Windows.Forms.Button();
            this.labelTotalOrcamentoValor = new System.Windows.Forms.Label();
            this.labelTotalOrcamento = new System.Windows.Forms.Label();
            this.labelObservacoes = new System.Windows.Forms.Label();
            this.labelModoRetirada = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.buttonIniciarOrcamento = new System.Windows.Forms.Button();
            this.richTextBoxObservacoes = new System.Windows.Forms.RichTextBox();
            this.labelModoRetiradaObrigatoriedade = new System.Windows.Forms.Label();
            this.labelQuantidadeObrigatoriedade = new System.Windows.Forms.Label();
            this.radioButtonModoRetiradaLoja = new System.Windows.Forms.RadioButton();
            this.radioButtonModoRetiradaEntrega = new System.Windows.Forms.RadioButton();
            this.labelQuantidadeItens = new System.Windows.Forms.Label();
            this.labelQuantidadeItensValor = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuantidade)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(138, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 15);
            this.label3.TabIndex = 23;
            this.label3.Text = "*";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelCliente
            // 
            this.labelCliente.AutoSize = true;
            this.labelCliente.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelCliente.Location = new System.Drawing.Point(12, 5);
            this.labelCliente.Name = "labelCliente";
            this.labelCliente.Size = new System.Drawing.Size(131, 21);
            this.labelCliente.TabIndex = 20;
            this.labelCliente.Text = "Cliente Regulares";
            // 
            // buttonGerarPedido
            // 
            this.buttonGerarPedido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonGerarPedido.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonGerarPedido.Enabled = false;
            this.buttonGerarPedido.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonGerarPedido.Image = global::Entra21.BancoDados02.Ado.Net.Properties.Resources.pedido_fechado;
            this.buttonGerarPedido.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonGerarPedido.Location = new System.Drawing.Point(811, 14);
            this.buttonGerarPedido.Name = "buttonGerarPedido";
            this.buttonGerarPedido.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.buttonGerarPedido.Size = new System.Drawing.Size(161, 56);
            this.buttonGerarPedido.TabIndex = 8;
            this.buttonGerarPedido.Text = "Gerar Pedido";
            this.buttonGerarPedido.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonGerarPedido.UseVisualStyleBackColor = true;
            this.buttonGerarPedido.Click += new System.EventHandler(this.buttonGerarPedido_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCancelar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonCancelar.Image = global::Entra21.BancoDados02.Ado.Net.Properties.Resources.cancel;
            this.buttonCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCancelar.Location = new System.Drawing.Point(477, 14);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.buttonCancelar.Size = new System.Drawing.Size(161, 56);
            this.buttonCancelar.TabIndex = 9;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.buttonFinalizarOrcamento);
            this.panel1.Controls.Add(this.buttonGerarPedido);
            this.panel1.Controls.Add(this.buttonCancelar);
            this.panel1.Location = new System.Drawing.Point(0, 679);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(984, 82);
            this.panel1.TabIndex = 22;
            // 
            // buttonFinalizarOrcamento
            // 
            this.buttonFinalizarOrcamento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonFinalizarOrcamento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonFinalizarOrcamento.Enabled = false;
            this.buttonFinalizarOrcamento.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonFinalizarOrcamento.Image = global::Entra21.BancoDados02.Ado.Net.Properties.Resources.orcamento_criado;
            this.buttonFinalizarOrcamento.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonFinalizarOrcamento.Location = new System.Drawing.Point(644, 14);
            this.buttonFinalizarOrcamento.Name = "buttonFinalizarOrcamento";
            this.buttonFinalizarOrcamento.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.buttonFinalizarOrcamento.Size = new System.Drawing.Size(161, 56);
            this.buttonFinalizarOrcamento.TabIndex = 10;
            this.buttonFinalizarOrcamento.Text = "Finalizar Orçamento";
            this.buttonFinalizarOrcamento.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.buttonFinalizarOrcamento.UseVisualStyleBackColor = true;
            // 
            // comboBoxCliente
            // 
            this.comboBoxCliente.DisplayMember = "Nome";
            this.comboBoxCliente.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.comboBoxCliente.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxCliente.ItemHeight = 29;
            this.comboBoxCliente.Location = new System.Drawing.Point(12, 29);
            this.comboBoxCliente.Name = "comboBoxCliente";
            this.comboBoxCliente.Size = new System.Drawing.Size(316, 35);
            this.comboBoxCliente.TabIndex = 24;
            this.comboBoxCliente.ValueMember = "Nome";
            this.comboBoxCliente.SelectedIndexChanged += new System.EventHandler(this.comboBoxCliente_SelectedIndexChanged);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToResizeColumns = false;
            this.dataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            this.dataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.dataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(10, 10, 0, 5);
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnNome,
            this.ColumnStatus,
            this.ColumnValorUnitario,
            this.ColumnValorTotal});
            this.dataGridView.Enabled = false;
            this.dataGridView.EnableHeadersVisualStyles = false;
            this.dataGridView.Location = new System.Drawing.Point(356, 191);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(215)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.dataGridView.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridView.RowTemplate.Height = 40;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(616, 452);
            this.dataGridView.TabIndex = 100;
            this.dataGridView.TabStop = false;
            // 
            // ColumnNome
            // 
            this.ColumnNome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnNome.HeaderText = "Códgio - Nome";
            this.ColumnNome.Name = "ColumnNome";
            this.ColumnNome.ReadOnly = true;
            this.ColumnNome.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColumnNome.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColumnStatus
            // 
            this.ColumnStatus.HeaderText = "Quantidade";
            this.ColumnStatus.Name = "ColumnStatus";
            this.ColumnStatus.ReadOnly = true;
            this.ColumnStatus.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColumnStatus.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColumnStatus.Width = 150;
            // 
            // ColumnValorUnitario
            // 
            this.ColumnValorUnitario.HeaderText = "Valor Unitário";
            this.ColumnValorUnitario.Name = "ColumnValorUnitario";
            this.ColumnValorUnitario.ReadOnly = true;
            // 
            // ColumnValorTotal
            // 
            this.ColumnValorTotal.HeaderText = "Valor Total";
            this.ColumnValorTotal.Name = "ColumnValorTotal";
            this.ColumnValorTotal.ReadOnly = true;
            // 
            // comboBoxProduto
            // 
            this.comboBoxProduto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxProduto.DisplayMember = "Nome";
            this.comboBoxProduto.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.comboBoxProduto.Enabled = false;
            this.comboBoxProduto.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxProduto.FormattingEnabled = true;
            this.comboBoxProduto.ItemHeight = 29;
            this.comboBoxProduto.Location = new System.Drawing.Point(359, 56);
            this.comboBoxProduto.Name = "comboBoxProduto";
            this.comboBoxProduto.Size = new System.Drawing.Size(516, 35);
            this.comboBoxProduto.TabIndex = 103;
            this.comboBoxProduto.SelectedIndexChanged += new System.EventHandler(this.comboBoxProduto_SelectedIndexChanged);
            // 
            // labelProdutoObrigatoriedade
            // 
            this.labelProdutoObrigatoriedade.Enabled = false;
            this.labelProdutoObrigatoriedade.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelProdutoObrigatoriedade.ForeColor = System.Drawing.Color.Red;
            this.labelProdutoObrigatoriedade.Location = new System.Drawing.Point(419, 30);
            this.labelProdutoObrigatoriedade.Name = "labelProdutoObrigatoriedade";
            this.labelProdutoObrigatoriedade.Size = new System.Drawing.Size(19, 15);
            this.labelProdutoObrigatoriedade.TabIndex = 102;
            this.labelProdutoObrigatoriedade.Text = "*";
            this.labelProdutoObrigatoriedade.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelProduto
            // 
            this.labelProduto.AutoSize = true;
            this.labelProduto.Enabled = false;
            this.labelProduto.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelProduto.Location = new System.Drawing.Point(359, 32);
            this.labelProduto.Name = "labelProduto";
            this.labelProduto.Size = new System.Drawing.Size(66, 21);
            this.labelProduto.TabIndex = 101;
            this.labelProduto.Text = "Produto";
            // 
            // labelProdutoValorUnitario
            // 
            this.labelProdutoValorUnitario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelProdutoValorUnitario.AutoSize = true;
            this.labelProdutoValorUnitario.Enabled = false;
            this.labelProdutoValorUnitario.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelProdutoValorUnitario.Location = new System.Drawing.Point(624, 94);
            this.labelProdutoValorUnitario.Name = "labelProdutoValorUnitario";
            this.labelProdutoValorUnitario.Size = new System.Drawing.Size(106, 21);
            this.labelProdutoValorUnitario.TabIndex = 104;
            this.labelProdutoValorUnitario.Text = "Valor Unitário";
            // 
            // labelProdutoValorUnitarioValor
            // 
            this.labelProdutoValorUnitarioValor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelProdutoValorUnitarioValor.Enabled = false;
            this.labelProdutoValorUnitarioValor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelProdutoValorUnitarioValor.ForeColor = System.Drawing.Color.Black;
            this.labelProdutoValorUnitarioValor.Location = new System.Drawing.Point(736, 94);
            this.labelProdutoValorUnitarioValor.Name = "labelProdutoValorUnitarioValor";
            this.labelProdutoValorUnitarioValor.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelProdutoValorUnitarioValor.Size = new System.Drawing.Size(139, 21);
            this.labelProdutoValorUnitarioValor.TabIndex = 105;
            this.labelProdutoValorUnitarioValor.Text = "R$ 0,00";
            // 
            // labelQuantidade
            // 
            this.labelQuantidade.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelQuantidade.AutoSize = true;
            this.labelQuantidade.Enabled = false;
            this.labelQuantidade.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelQuantidade.Location = new System.Drawing.Point(359, 94);
            this.labelQuantidade.Name = "labelQuantidade";
            this.labelQuantidade.Size = new System.Drawing.Size(91, 21);
            this.labelQuantidade.TabIndex = 106;
            this.labelQuantidade.Text = "Quantidade";
            // 
            // numericUpDownQuantidade
            // 
            this.numericUpDownQuantidade.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDownQuantidade.Enabled = false;
            this.numericUpDownQuantidade.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numericUpDownQuantidade.Location = new System.Drawing.Point(359, 118);
            this.numericUpDownQuantidade.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownQuantidade.Name = "numericUpDownQuantidade";
            this.numericUpDownQuantidade.Size = new System.Drawing.Size(187, 29);
            this.numericUpDownQuantidade.TabIndex = 107;
            this.numericUpDownQuantidade.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownQuantidade.ValueChanged += new System.EventHandler(this.numericUpDownQuantidade_ValueChanged);
            // 
            // labelProdutoValorTotal
            // 
            this.labelProdutoValorTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelProdutoValorTotal.AutoSize = true;
            this.labelProdutoValorTotal.Enabled = false;
            this.labelProdutoValorTotal.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelProdutoValorTotal.Location = new System.Drawing.Point(644, 126);
            this.labelProdutoValorTotal.Name = "labelProdutoValorTotal";
            this.labelProdutoValorTotal.Size = new System.Drawing.Size(86, 21);
            this.labelProdutoValorTotal.TabIndex = 108;
            this.labelProdutoValorTotal.Text = "Valor Total";
            // 
            // labelProdutoValorTotalValor
            // 
            this.labelProdutoValorTotalValor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelProdutoValorTotalValor.Enabled = false;
            this.labelProdutoValorTotalValor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelProdutoValorTotalValor.ForeColor = System.Drawing.Color.Black;
            this.labelProdutoValorTotalValor.Location = new System.Drawing.Point(741, 126);
            this.labelProdutoValorTotalValor.Name = "labelProdutoValorTotalValor";
            this.labelProdutoValorTotalValor.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelProdutoValorTotalValor.Size = new System.Drawing.Size(134, 21);
            this.labelProdutoValorTotalValor.TabIndex = 109;
            this.labelProdutoValorTotalValor.Text = "R$ 0,00";
            // 
            // buttonAdicionarProduto
            // 
            this.buttonAdicionarProduto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAdicionarProduto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAdicionarProduto.Enabled = false;
            this.buttonAdicionarProduto.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonAdicionarProduto.Image = global::Entra21.BancoDados02.Ado.Net.Properties.Resources.orcamento_produto;
            this.buttonAdicionarProduto.Location = new System.Drawing.Point(881, 56);
            this.buttonAdicionarProduto.Name = "buttonAdicionarProduto";
            this.buttonAdicionarProduto.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.buttonAdicionarProduto.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonAdicionarProduto.Size = new System.Drawing.Size(91, 91);
            this.buttonAdicionarProduto.TabIndex = 10;
            this.buttonAdicionarProduto.UseVisualStyleBackColor = true;
            this.buttonAdicionarProduto.Click += new System.EventHandler(this.buttonAdicionarProduto_Click);
            // 
            // labelTotalOrcamentoValor
            // 
            this.labelTotalOrcamentoValor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTotalOrcamentoValor.Enabled = false;
            this.labelTotalOrcamentoValor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTotalOrcamentoValor.ForeColor = System.Drawing.Color.Black;
            this.labelTotalOrcamentoValor.Location = new System.Drawing.Point(838, 646);
            this.labelTotalOrcamentoValor.Name = "labelTotalOrcamentoValor";
            this.labelTotalOrcamentoValor.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelTotalOrcamentoValor.Size = new System.Drawing.Size(134, 21);
            this.labelTotalOrcamentoValor.TabIndex = 111;
            this.labelTotalOrcamentoValor.Text = "R$ 0,00";
            // 
            // labelTotalOrcamento
            // 
            this.labelTotalOrcamento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTotalOrcamento.AutoSize = true;
            this.labelTotalOrcamento.Enabled = false;
            this.labelTotalOrcamento.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTotalOrcamento.Location = new System.Drawing.Point(704, 646);
            this.labelTotalOrcamento.Name = "labelTotalOrcamento";
            this.labelTotalOrcamento.Size = new System.Drawing.Size(133, 21);
            this.labelTotalOrcamento.TabIndex = 110;
            this.labelTotalOrcamento.Text = "Total orçamento:";
            // 
            // labelObservacoes
            // 
            this.labelObservacoes.AutoSize = true;
            this.labelObservacoes.Enabled = false;
            this.labelObservacoes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelObservacoes.Location = new System.Drawing.Point(12, 126);
            this.labelObservacoes.Name = "labelObservacoes";
            this.labelObservacoes.Size = new System.Drawing.Size(99, 21);
            this.labelObservacoes.TabIndex = 112;
            this.labelObservacoes.Text = "Observações";
            // 
            // labelModoRetirada
            // 
            this.labelModoRetirada.AutoSize = true;
            this.labelModoRetirada.Enabled = false;
            this.labelModoRetirada.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelModoRetirada.Location = new System.Drawing.Point(12, 67);
            this.labelModoRetirada.Name = "labelModoRetirada";
            this.labelModoRetirada.Size = new System.Drawing.Size(113, 21);
            this.labelModoRetirada.TabIndex = 113;
            this.labelModoRetirada.Text = "Modo Retirada";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(356, 167);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(147, 21);
            this.label13.TabIndex = 114;
            this.label13.Text = "Produtos orçados:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(359, 7);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(247, 21);
            this.label14.TabIndex = 115;
            this.label14.Text = "Novo produto para orçamento:";
            // 
            // buttonIniciarOrcamento
            // 
            this.buttonIniciarOrcamento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonIniciarOrcamento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonIniciarOrcamento.Enabled = false;
            this.buttonIniciarOrcamento.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonIniciarOrcamento.Image = global::Entra21.BancoDados02.Ado.Net.Properties.Resources.orcamento_gerado;
            this.buttonIniciarOrcamento.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonIniciarOrcamento.Location = new System.Drawing.Point(189, 587);
            this.buttonIniciarOrcamento.Name = "buttonIniciarOrcamento";
            this.buttonIniciarOrcamento.Padding = new System.Windows.Forms.Padding(10, 0, 5, 0);
            this.buttonIniciarOrcamento.Size = new System.Drawing.Size(139, 56);
            this.buttonIniciarOrcamento.TabIndex = 11;
            this.buttonIniciarOrcamento.Text = "Iniciar orçamento";
            this.buttonIniciarOrcamento.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonIniciarOrcamento.UseVisualStyleBackColor = true;
            this.buttonIniciarOrcamento.Click += new System.EventHandler(this.buttonIniciarOrcamento_Click);
            // 
            // richTextBoxObservacoes
            // 
            this.richTextBoxObservacoes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxObservacoes.Enabled = false;
            this.richTextBoxObservacoes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.richTextBoxObservacoes.Location = new System.Drawing.Point(12, 150);
            this.richTextBoxObservacoes.Name = "richTextBoxObservacoes";
            this.richTextBoxObservacoes.Size = new System.Drawing.Size(310, 431);
            this.richTextBoxObservacoes.TabIndex = 116;
            this.richTextBoxObservacoes.Text = "";
            // 
            // labelModoRetiradaObrigatoriedade
            // 
            this.labelModoRetiradaObrigatoriedade.Enabled = false;
            this.labelModoRetiradaObrigatoriedade.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelModoRetiradaObrigatoriedade.ForeColor = System.Drawing.Color.Red;
            this.labelModoRetiradaObrigatoriedade.Location = new System.Drawing.Point(118, 65);
            this.labelModoRetiradaObrigatoriedade.Name = "labelModoRetiradaObrigatoriedade";
            this.labelModoRetiradaObrigatoriedade.Size = new System.Drawing.Size(19, 15);
            this.labelModoRetiradaObrigatoriedade.TabIndex = 117;
            this.labelModoRetiradaObrigatoriedade.Text = "*";
            this.labelModoRetiradaObrigatoriedade.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelQuantidadeObrigatoriedade
            // 
            this.labelQuantidadeObrigatoriedade.Enabled = false;
            this.labelQuantidadeObrigatoriedade.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelQuantidadeObrigatoriedade.ForeColor = System.Drawing.Color.Red;
            this.labelQuantidadeObrigatoriedade.Location = new System.Drawing.Point(444, 91);
            this.labelQuantidadeObrigatoriedade.Name = "labelQuantidadeObrigatoriedade";
            this.labelQuantidadeObrigatoriedade.Size = new System.Drawing.Size(19, 15);
            this.labelQuantidadeObrigatoriedade.TabIndex = 118;
            this.labelQuantidadeObrigatoriedade.Text = "*";
            this.labelQuantidadeObrigatoriedade.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // radioButtonModoRetiradaLoja
            // 
            this.radioButtonModoRetiradaLoja.AutoSize = true;
            this.radioButtonModoRetiradaLoja.Enabled = false;
            this.radioButtonModoRetiradaLoja.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButtonModoRetiradaLoja.Location = new System.Drawing.Point(99, 92);
            this.radioButtonModoRetiradaLoja.Name = "radioButtonModoRetiradaLoja";
            this.radioButtonModoRetiradaLoja.Size = new System.Drawing.Size(57, 25);
            this.radioButtonModoRetiradaLoja.TabIndex = 120;
            this.radioButtonModoRetiradaLoja.Text = "Loja";
            this.radioButtonModoRetiradaLoja.UseVisualStyleBackColor = true;
            // 
            // radioButtonModoRetiradaEntrega
            // 
            this.radioButtonModoRetiradaEntrega.AutoSize = true;
            this.radioButtonModoRetiradaEntrega.Checked = true;
            this.radioButtonModoRetiradaEntrega.Enabled = false;
            this.radioButtonModoRetiradaEntrega.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButtonModoRetiradaEntrega.Location = new System.Drawing.Point(12, 92);
            this.radioButtonModoRetiradaEntrega.Name = "radioButtonModoRetiradaEntrega";
            this.radioButtonModoRetiradaEntrega.Size = new System.Drawing.Size(81, 25);
            this.radioButtonModoRetiradaEntrega.TabIndex = 119;
            this.radioButtonModoRetiradaEntrega.TabStop = true;
            this.radioButtonModoRetiradaEntrega.Text = "Entrega";
            this.radioButtonModoRetiradaEntrega.UseVisualStyleBackColor = true;
            // 
            // labelQuantidadeItens
            // 
            this.labelQuantidadeItens.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelQuantidadeItens.AutoSize = true;
            this.labelQuantidadeItens.Enabled = false;
            this.labelQuantidadeItens.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelQuantidadeItens.Location = new System.Drawing.Point(356, 646);
            this.labelQuantidadeItens.Name = "labelQuantidadeItens";
            this.labelQuantidadeItens.Size = new System.Drawing.Size(138, 21);
            this.labelQuantidadeItens.TabIndex = 121;
            this.labelQuantidadeItens.Text = "Quantidade itens:";
            // 
            // labelQuantidadeItensValor
            // 
            this.labelQuantidadeItensValor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelQuantidadeItensValor.Enabled = false;
            this.labelQuantidadeItensValor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelQuantidadeItensValor.ForeColor = System.Drawing.Color.Black;
            this.labelQuantidadeItensValor.Location = new System.Drawing.Point(489, 646);
            this.labelQuantidadeItensValor.Name = "labelQuantidadeItensValor";
            this.labelQuantidadeItensValor.Size = new System.Drawing.Size(134, 21);
            this.labelQuantidadeItensValor.TabIndex = 122;
            this.labelQuantidadeItensValor.Text = "0";
            // 
            // PedidoCadastroForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 761);
            this.Controls.Add(this.labelQuantidadeItensValor);
            this.Controls.Add(this.labelQuantidadeItens);
            this.Controls.Add(this.radioButtonModoRetiradaLoja);
            this.Controls.Add(this.radioButtonModoRetiradaEntrega);
            this.Controls.Add(this.labelQuantidadeObrigatoriedade);
            this.Controls.Add(this.labelModoRetiradaObrigatoriedade);
            this.Controls.Add(this.richTextBoxObservacoes);
            this.Controls.Add(this.buttonIniciarOrcamento);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.labelModoRetirada);
            this.Controls.Add(this.labelObservacoes);
            this.Controls.Add(this.labelTotalOrcamentoValor);
            this.Controls.Add(this.labelTotalOrcamento);
            this.Controls.Add(this.buttonAdicionarProduto);
            this.Controls.Add(this.labelProdutoValorTotalValor);
            this.Controls.Add(this.labelProdutoValorTotal);
            this.Controls.Add(this.numericUpDownQuantidade);
            this.Controls.Add(this.labelQuantidade);
            this.Controls.Add(this.labelProdutoValorUnitarioValor);
            this.Controls.Add(this.labelProdutoValorUnitario);
            this.Controls.Add(this.comboBoxProduto);
            this.Controls.Add(this.labelProdutoObrigatoriedade);
            this.Controls.Add(this.labelProduto);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.comboBoxCliente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelCliente);
            this.Controls.Add(this.panel1);
            this.Name = "PedidoCadastroForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Orçamento";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuantidade)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label3;
        private Label labelCliente;
        private Button buttonGerarPedido;
        private Button buttonCancelar;
        private Panel panel1;
        private ComboBox comboBoxCliente;
        private DataGridView dataGridView;
        private ComboBox comboBoxProduto;
        private Label labelProdutoObrigatoriedade;
        private Label labelProduto;
        private Label labelProdutoValorUnitario;
        private Label labelProdutoValorUnitarioValor;
        private Label labelQuantidade;
        private NumericUpDown numericUpDownQuantidade;
        private Label labelProdutoValorTotal;
        private Label labelProdutoValorTotalValor;
        private Button buttonAdicionarProduto;
        private Label labelTotalOrcamentoValor;
        private Label labelTotalOrcamento;
        private Label labelObservacoes;
        private Label labelModoRetirada;
        private Label label13;
        private Label label14;
        private Button buttonFinalizarOrcamento;
        private Button buttonIniciarOrcamento;
        private RichTextBox richTextBoxObservacoes;
        private Label labelModoRetiradaObrigatoriedade;
        private Label labelQuantidadeObrigatoriedade;
        private RadioButton radioButtonModoRetiradaLoja;
        private RadioButton radioButtonModoRetiradaEntrega;
        private Label labelQuantidadeItens;
        private Label labelQuantidadeItensValor;
        private DataGridViewTextBoxColumn ColumnNome;
        private DataGridViewTextBoxColumn ColumnStatus;
        private DataGridViewTextBoxColumn ColumnValorUnitario;
        private DataGridViewTextBoxColumn ColumnValorTotal;
    }
}