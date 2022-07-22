namespace Entra21.BancoDados02.Ado.Net.Views
{
    partial class MenuForm
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
            this.buttonCliente = new System.Windows.Forms.Button();
            this.buttonProdutos = new System.Windows.Forms.Button();
            this.buttonOrcamentos = new System.Windows.Forms.Button();
            this.buttonPedidos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonCliente
            // 
            this.buttonCliente.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonCliente.Image = global::Entra21.BancoDados02.Ado.Net.Properties.Resources._5058889;
            this.buttonCliente.Location = new System.Drawing.Point(12, 12);
            this.buttonCliente.Name = "buttonCliente";
            this.buttonCliente.Size = new System.Drawing.Size(200, 200);
            this.buttonCliente.TabIndex = 0;
            this.buttonCliente.Text = "Clientes";
            this.buttonCliente.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonCliente.UseVisualStyleBackColor = true;
            this.buttonCliente.Click += new System.EventHandler(this.buttonClientes_Click);
            // 
            // buttonProdutos
            // 
            this.buttonProdutos.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonProdutos.Image = global::Entra21.BancoDados02.Ado.Net.Properties.Resources.dairy_products;
            this.buttonProdutos.Location = new System.Drawing.Point(231, 12);
            this.buttonProdutos.Name = "buttonProdutos";
            this.buttonProdutos.Size = new System.Drawing.Size(200, 200);
            this.buttonProdutos.TabIndex = 1;
            this.buttonProdutos.Text = "Produtos";
            this.buttonProdutos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonProdutos.UseVisualStyleBackColor = true;
            this.buttonProdutos.Click += new System.EventHandler(this.buttonProdutos_Click);
            // 
            // buttonOrcamentos
            // 
            this.buttonOrcamentos.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonOrcamentos.Image = global::Entra21.BancoDados02.Ado.Net.Properties.Resources.add;
            this.buttonOrcamentos.Location = new System.Drawing.Point(455, 12);
            this.buttonOrcamentos.Name = "buttonOrcamentos";
            this.buttonOrcamentos.Size = new System.Drawing.Size(200, 200);
            this.buttonOrcamentos.TabIndex = 2;
            this.buttonOrcamentos.Text = "Orçamentos";
            this.buttonOrcamentos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonOrcamentos.UseVisualStyleBackColor = true;
            this.buttonOrcamentos.Click += new System.EventHandler(this.buttonOrcamentos_Click);
            // 
            // buttonPedidos
            // 
            this.buttonPedidos.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonPedidos.Image = global::Entra21.BancoDados02.Ado.Net.Properties.Resources.box;
            this.buttonPedidos.Location = new System.Drawing.Point(672, 12);
            this.buttonPedidos.Name = "buttonPedidos";
            this.buttonPedidos.Size = new System.Drawing.Size(200, 200);
            this.buttonPedidos.TabIndex = 3;
            this.buttonPedidos.Text = "Pedidos";
            this.buttonPedidos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonPedidos.UseVisualStyleBackColor = true;
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 225);
            this.Controls.Add(this.buttonPedidos);
            this.Controls.Add(this.buttonOrcamentos);
            this.Controls.Add(this.buttonProdutos);
            this.Controls.Add(this.buttonCliente);
            this.Name = "MenuForm";
            this.Text = "MenuForm";
            this.ResumeLayout(false);

        }

        #endregion

        private Button buttonCliente;
        private Button buttonProdutos;
        private Button buttonOrcamentos;
        private Button buttonPedidos;
    }
}