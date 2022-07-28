namespace Entra21.BancoDados02.Ado.Net.Views.Pedidos
{
    partial class OrcamentoListaForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.buttonCadastrar = new System.Windows.Forms.Button();
            this.buttonPesquisar = new System.Windows.Forms.Button();
            this.radioButtonOrcamentoTodos = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.radioButtonOrcamentoFinalizado = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.labelCliente = new System.Windows.Forms.Label();
            this.radioButtonOrcamentoIniciado = new System.Windows.Forms.RadioButton();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.ColumnCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTotalPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonEditar = new System.Windows.Forms.Button();
            this.comboBoxCliente = new System.Windows.Forms.ComboBox();
            this.radioButtonPedidoGerado = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonCadastrar
            // 
            this.buttonCadastrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCadastrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCadastrar.Image = global::Entra21.BancoDados02.Ado.Net.Properties.Resources.plus;
            this.buttonCadastrar.Location = new System.Drawing.Point(831, 11);
            this.buttonCadastrar.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCadastrar.Name = "buttonCadastrar";
            this.buttonCadastrar.Size = new System.Drawing.Size(42, 42);
            this.buttonCadastrar.TabIndex = 9;
            this.buttonCadastrar.UseVisualStyleBackColor = true;
            this.buttonCadastrar.Click += new System.EventHandler(this.buttonCadastrar_Click);
            // 
            // buttonPesquisar
            // 
            this.buttonPesquisar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPesquisar.Image = global::Entra21.BancoDados02.Ado.Net.Properties.Resources.search;
            this.buttonPesquisar.Location = new System.Drawing.Point(592, 33);
            this.buttonPesquisar.Name = "buttonPesquisar";
            this.buttonPesquisar.Size = new System.Drawing.Size(62, 62);
            this.buttonPesquisar.TabIndex = 104;
            this.buttonPesquisar.UseVisualStyleBackColor = true;
            this.buttonPesquisar.Click += new System.EventHandler(this.buttonPesquisar_Click);
            // 
            // radioButtonOrcamentoTodos
            // 
            this.radioButtonOrcamentoTodos.AutoSize = true;
            this.radioButtonOrcamentoTodos.Checked = true;
            this.radioButtonOrcamentoTodos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButtonOrcamentoTodos.Location = new System.Drawing.Point(155, 68);
            this.radioButtonOrcamentoTodos.Name = "radioButtonOrcamentoTodos";
            this.radioButtonOrcamentoTodos.Size = new System.Drawing.Size(68, 25);
            this.radioButtonOrcamentoTodos.TabIndex = 103;
            this.radioButtonOrcamentoTodos.TabStop = true;
            this.radioButtonOrcamentoTodos.Text = "Todos";
            this.radioButtonOrcamentoTodos.UseVisualStyleBackColor = true;
            this.radioButtonOrcamentoTodos.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 21);
            this.label2.TabIndex = 106;
            this.label2.Text = "Orçamento Status:";
            // 
            // radioButtonOrcamentoFinalizado
            // 
            this.radioButtonOrcamentoFinalizado.AutoSize = true;
            this.radioButtonOrcamentoFinalizado.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButtonOrcamentoFinalizado.Location = new System.Drawing.Point(302, 68);
            this.radioButtonOrcamentoFinalizado.Name = "radioButtonOrcamentoFinalizado";
            this.radioButtonOrcamentoFinalizado.Size = new System.Drawing.Size(98, 25);
            this.radioButtonOrcamentoFinalizado.TabIndex = 102;
            this.radioButtonOrcamentoFinalizado.Text = "Finalizado";
            this.radioButtonOrcamentoFinalizado.UseVisualStyleBackColor = true;
            this.radioButtonOrcamentoFinalizado.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(158, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 21);
            this.label1.TabIndex = 108;
            this.label1.Text = "Filtros:";
            // 
            // labelCliente
            // 
            this.labelCliente.AutoSize = true;
            this.labelCliente.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelCliente.Location = new System.Drawing.Point(12, 36);
            this.labelCliente.Name = "labelCliente";
            this.labelCliente.Size = new System.Drawing.Size(61, 21);
            this.labelCliente.TabIndex = 107;
            this.labelCliente.Text = "Cliente:";
            // 
            // radioButtonOrcamentoIniciado
            // 
            this.radioButtonOrcamentoIniciado.AutoSize = true;
            this.radioButtonOrcamentoIniciado.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButtonOrcamentoIniciado.Location = new System.Drawing.Point(223, 68);
            this.radioButtonOrcamentoIniciado.Name = "radioButtonOrcamentoIniciado";
            this.radioButtonOrcamentoIniciado.Size = new System.Drawing.Size(82, 25);
            this.radioButtonOrcamentoIniciado.TabIndex = 101;
            this.radioButtonOrcamentoIniciado.Text = "Iniciado";
            this.radioButtonOrcamentoIniciado.UseVisualStyleBackColor = true;
            this.radioButtonOrcamentoIniciado.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToResizeColumns = false;
            this.dataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.dataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(10, 10, 0, 5);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnCodigo,
            this.ColumnCliente,
            this.ColumnTotalPedido,
            this.ColumnStatus});
            this.dataGridView.EnableHeadersVisualStyles = false;
            this.dataGridView.Location = new System.Drawing.Point(12, 112);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(215)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.dataGridView.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView.RowTemplate.Height = 40;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(860, 440);
            this.dataGridView.TabIndex = 109;
            this.dataGridView.TabStop = false;
            // 
            // ColumnCodigo
            // 
            this.ColumnCodigo.HeaderText = "Código";
            this.ColumnCodigo.Name = "ColumnCodigo";
            this.ColumnCodigo.ReadOnly = true;
            this.ColumnCodigo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColumnCliente
            // 
            this.ColumnCliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnCliente.HeaderText = "Cliente";
            this.ColumnCliente.Name = "ColumnCliente";
            this.ColumnCliente.ReadOnly = true;
            this.ColumnCliente.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColumnCliente.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColumnTotalPedido
            // 
            this.ColumnTotalPedido.HeaderText = "Total Pedido";
            this.ColumnTotalPedido.Name = "ColumnTotalPedido";
            this.ColumnTotalPedido.ReadOnly = true;
            // 
            // ColumnStatus
            // 
            this.ColumnStatus.HeaderText = "Status";
            this.ColumnStatus.Name = "ColumnStatus";
            this.ColumnStatus.ReadOnly = true;
            this.ColumnStatus.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColumnStatus.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColumnStatus.Width = 150;
            // 
            // buttonEditar
            // 
            this.buttonEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEditar.Image = global::Entra21.BancoDados02.Ado.Net.Properties.Resources.pencil;
            this.buttonEditar.Location = new System.Drawing.Point(785, 10);
            this.buttonEditar.Margin = new System.Windows.Forms.Padding(2);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(42, 42);
            this.buttonEditar.TabIndex = 105;
            this.buttonEditar.UseVisualStyleBackColor = true;
            // 
            // comboBoxCliente
            // 
            this.comboBoxCliente.DisplayMember = "Nome";
            this.comboBoxCliente.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxCliente.ItemHeight = 21;
            this.comboBoxCliente.Location = new System.Drawing.Point(71, 33);
            this.comboBoxCliente.Name = "comboBoxCliente";
            this.comboBoxCliente.Size = new System.Drawing.Size(515, 29);
            this.comboBoxCliente.TabIndex = 110;
            this.comboBoxCliente.ValueMember = "Nome";
            this.comboBoxCliente.SelectedIndexChanged += new System.EventHandler(this.comboBoxCliente_SelectedIndexChanged);
            // 
            // radioButtonPedidoGerado
            // 
            this.radioButtonPedidoGerado.AutoSize = true;
            this.radioButtonPedidoGerado.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButtonPedidoGerado.Location = new System.Drawing.Point(406, 68);
            this.radioButtonPedidoGerado.Name = "radioButtonPedidoGerado";
            this.radioButtonPedidoGerado.Size = new System.Drawing.Size(126, 25);
            this.radioButtonPedidoGerado.TabIndex = 111;
            this.radioButtonPedidoGerado.Text = "PedidoGerado";
            this.radioButtonPedidoGerado.UseVisualStyleBackColor = true;
            this.radioButtonPedidoGerado.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // OrcamentoListaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.radioButtonPedidoGerado);
            this.Controls.Add(this.comboBoxCliente);
            this.Controls.Add(this.buttonPesquisar);
            this.Controls.Add(this.radioButtonOrcamentoTodos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.radioButtonOrcamentoFinalizado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelCliente);
            this.Controls.Add(this.radioButtonOrcamentoIniciado);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.buttonEditar);
            this.Controls.Add(this.buttonCadastrar);
            this.Name = "OrcamentoListaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de Pedidos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonCadastrar;
        private Button buttonPesquisar;
        private RadioButton radioButtonOrcamentoTodos;
        private Label label2;
        private RadioButton radioButtonOrcamentoFinalizado;
        private Label label1;
        private Label labelCliente;
        private RadioButton radioButtonOrcamentoIniciado;
        private DataGridView dataGridView;
        private Button buttonEditar;
        private DataGridViewTextBoxColumn ColumnCodigo;
        private DataGridViewTextBoxColumn ColumnCliente;
        private DataGridViewTextBoxColumn ColumnTotalPedido;
        private DataGridViewTextBoxColumn ColumnStatus;
        private ComboBox comboBoxCliente;
        private RadioButton radioButtonPedidoGerado;
    }
}