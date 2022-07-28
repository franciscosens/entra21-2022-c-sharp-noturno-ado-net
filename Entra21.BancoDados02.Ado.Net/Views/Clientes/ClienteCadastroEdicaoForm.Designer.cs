namespace Entra21.BancoDados02.Ado.Net.Views.Clientes
{
    partial class ClienteCadastroEdicaoForm
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
            this.labelNome = new System.Windows.Forms.Label();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.labelCpf = new System.Windows.Forms.Label();
            this.maskedTextBoxCpf = new System.Windows.Forms.MaskedTextBox();
            this.labelRenda = new System.Windows.Forms.Label();
            this.dateTimePickerDataNascimento = new System.Windows.Forms.DateTimePicker();
            this.labelDataNascimento = new System.Windows.Forms.Label();
            this.textBoxRenda = new System.Windows.Forms.TextBox();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelStatus = new System.Windows.Forms.Label();
            this.radioButtonStatusRegular = new System.Windows.Forms.RadioButton();
            this.radioButtonStatusInadimplente = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBoxObservacao = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelNome.Location = new System.Drawing.Point(12, 9);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(53, 21);
            this.labelNome.TabIndex = 0;
            this.labelNome.Text = "Nome";
            // 
            // textBoxNome
            // 
            this.textBoxNome.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxNome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxNome.Location = new System.Drawing.Point(15, 33);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(857, 29);
            this.textBoxNome.TabIndex = 1;
            // 
            // labelCpf
            // 
            this.labelCpf.AutoSize = true;
            this.labelCpf.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelCpf.Location = new System.Drawing.Point(15, 82);
            this.labelCpf.Name = "labelCpf";
            this.labelCpf.Size = new System.Drawing.Size(37, 21);
            this.labelCpf.TabIndex = 2;
            this.labelCpf.Text = "CPF";
            // 
            // maskedTextBoxCpf
            // 
            this.maskedTextBoxCpf.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.maskedTextBoxCpf.Location = new System.Drawing.Point(15, 106);
            this.maskedTextBoxCpf.Mask = "000.000.000-00";
            this.maskedTextBoxCpf.Name = "maskedTextBoxCpf";
            this.maskedTextBoxCpf.Size = new System.Drawing.Size(262, 29);
            this.maskedTextBoxCpf.TabIndex = 2;
            // 
            // labelRenda
            // 
            this.labelRenda.AutoSize = true;
            this.labelRenda.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelRenda.Location = new System.Drawing.Point(316, 82);
            this.labelRenda.Name = "labelRenda";
            this.labelRenda.Size = new System.Drawing.Size(54, 21);
            this.labelRenda.TabIndex = 4;
            this.labelRenda.Text = "Renda";
            // 
            // dateTimePickerDataNascimento
            // 
            this.dateTimePickerDataNascimento.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDataNascimento.CustomFormat = "dd/MM/yyyy";
            this.dateTimePickerDataNascimento.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePickerDataNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerDataNascimento.Location = new System.Drawing.Point(610, 103);
            this.dateTimePickerDataNascimento.Name = "dateTimePickerDataNascimento";
            this.dateTimePickerDataNascimento.Size = new System.Drawing.Size(262, 29);
            this.dateTimePickerDataNascimento.TabIndex = 4;
            // 
            // labelDataNascimento
            // 
            this.labelDataNascimento.AutoSize = true;
            this.labelDataNascimento.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelDataNascimento.Location = new System.Drawing.Point(610, 79);
            this.labelDataNascimento.Name = "labelDataNascimento";
            this.labelDataNascimento.Size = new System.Drawing.Size(150, 21);
            this.labelDataNascimento.TabIndex = 6;
            this.labelDataNascimento.Text = "Data de Nascimento";
            // 
            // textBoxRenda
            // 
            this.textBoxRenda.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxRenda.Location = new System.Drawing.Point(316, 106);
            this.textBoxRenda.Name = "textBoxRenda";
            this.textBoxRenda.Size = new System.Drawing.Size(275, 29);
            this.textBoxRenda.TabIndex = 3;
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSalvar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonSalvar.Image = global::Entra21.BancoDados02.Ado.Net.Properties.Resources.floppy_disk;
            this.buttonSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSalvar.Location = new System.Drawing.Point(711, 14);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.buttonSalvar.Size = new System.Drawing.Size(161, 56);
            this.buttonSalvar.TabIndex = 8;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCancelar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonCancelar.Image = global::Entra21.BancoDados02.Ado.Net.Properties.Resources.cancel;
            this.buttonCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCancelar.Location = new System.Drawing.Point(544, 14);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.buttonCancelar.Size = new System.Drawing.Size(161, 56);
            this.buttonCancelar.TabIndex = 9;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.buttonSalvar);
            this.panel1.Controls.Add(this.buttonCancelar);
            this.panel1.Location = new System.Drawing.Point(0, 479);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(884, 82);
            this.panel1.TabIndex = 11;
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelStatus.Location = new System.Drawing.Point(15, 155);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(52, 21);
            this.labelStatus.TabIndex = 13;
            this.labelStatus.Text = "Status";
            // 
            // radioButtonStatusRegular
            // 
            this.radioButtonStatusRegular.AutoSize = true;
            this.radioButtonStatusRegular.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButtonStatusRegular.Location = new System.Drawing.Point(140, 179);
            this.radioButtonStatusRegular.Name = "radioButtonStatusRegular";
            this.radioButtonStatusRegular.Size = new System.Drawing.Size(82, 25);
            this.radioButtonStatusRegular.TabIndex = 6;
            this.radioButtonStatusRegular.Text = "Regular";
            this.radioButtonStatusRegular.UseVisualStyleBackColor = true;
            // 
            // radioButtonStatusInadimplente
            // 
            this.radioButtonStatusInadimplente.AutoSize = true;
            this.radioButtonStatusInadimplente.Checked = true;
            this.radioButtonStatusInadimplente.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButtonStatusInadimplente.Location = new System.Drawing.Point(15, 179);
            this.radioButtonStatusInadimplente.Name = "radioButtonStatusInadimplente";
            this.radioButtonStatusInadimplente.Size = new System.Drawing.Size(119, 25);
            this.radioButtonStatusInadimplente.TabIndex = 5;
            this.radioButtonStatusInadimplente.TabStop = true;
            this.radioButtonStatusInadimplente.Text = "Inadimplente";
            this.radioButtonStatusInadimplente.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(15, 225);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 21);
            this.label1.TabIndex = 16;
            this.label1.Text = "Observações";
            // 
            // richTextBoxObservacao
            // 
            this.richTextBoxObservacao.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxObservacao.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.richTextBoxObservacao.Location = new System.Drawing.Point(15, 249);
            this.richTextBoxObservacao.Name = "richTextBoxObservacao";
            this.richTextBoxObservacao.Size = new System.Drawing.Size(857, 224);
            this.richTextBoxObservacao.TabIndex = 7;
            this.richTextBoxObservacao.Text = "";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(47, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 15);
            this.label2.TabIndex = 18;
            this.label2.Text = "*";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(60, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 15);
            this.label3.TabIndex = 19;
            this.label3.Text = "*";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(60, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 15);
            this.label4.TabIndex = 20;
            this.label4.Text = "*";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(366, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 15);
            this.label5.TabIndex = 21;
            this.label5.Text = "*";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(756, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(19, 15);
            this.label6.TabIndex = 22;
            this.label6.Text = "*";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ClienteCadastroEdicaoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.richTextBoxObservacao);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radioButtonStatusRegular);
            this.Controls.Add(this.radioButtonStatusInadimplente);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.textBoxRenda);
            this.Controls.Add(this.labelDataNascimento);
            this.Controls.Add(this.dateTimePickerDataNascimento);
            this.Controls.Add(this.labelRenda);
            this.Controls.Add(this.maskedTextBoxCpf);
            this.Controls.Add(this.labelCpf);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.labelNome);
            this.Controls.Add(this.panel1);
            this.Name = "ClienteCadastroEdicaoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Clientes";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelNome;
        private TextBox textBoxNome;
        private Label labelCpf;
        private MaskedTextBox maskedTextBoxCpf;
        private Label labelRenda;
        private DateTimePicker dateTimePickerDataNascimento;
        private Label labelDataNascimento;
        private TextBox textBoxRenda;
        private Button buttonSalvar;
        private Button buttonCancelar;
        private Panel panel1;
        private Label labelStatus;
        private RadioButton radioButtonStatusRegular;
        private RadioButton radioButtonStatusInadimplente;
        private Label label1;
        private RichTextBox richTextBoxObservacao;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}