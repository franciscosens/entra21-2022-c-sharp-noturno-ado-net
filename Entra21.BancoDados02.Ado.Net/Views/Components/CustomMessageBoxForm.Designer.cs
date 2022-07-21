namespace Entra21.BancoDados02.Ado.Net.Views.Components
{
    partial class CustomMessageBoxForm
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
            this.labelContent = new System.Windows.Forms.Label();
            this.pictureBoxContent = new System.Windows.Forms.PictureBox();
            this.buttonSalvar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxContent)).BeginInit();
            this.SuspendLayout();
            // 
            // labelContent
            // 
            this.labelContent.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelContent.Location = new System.Drawing.Point(118, 12);
            this.labelContent.Name = "labelContent";
            this.labelContent.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.labelContent.Size = new System.Drawing.Size(461, 100);
            this.labelContent.TabIndex = 0;
            this.labelContent.Text = "Content";
            this.labelContent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBoxContent
            // 
            this.pictureBoxContent.Image = global::Entra21.BancoDados02.Ado.Net.Properties.Resources.error;
            this.pictureBoxContent.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxContent.Name = "pictureBoxContent";
            this.pictureBoxContent.Size = new System.Drawing.Size(100, 100);
            this.pictureBoxContent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxContent.TabIndex = 1;
            this.pictureBoxContent.TabStop = false;
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSalvar.Location = new System.Drawing.Point(418, 128);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.buttonSalvar.Size = new System.Drawing.Size(161, 56);
            this.buttonSalvar.TabIndex = 10;
            this.buttonSalvar.Text = "Ok";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // CustomMessageBoxForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 196);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(this.pictureBoxContent);
            this.Controls.Add(this.labelContent);
            this.Name = "CustomMessageBoxForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CustomMessageBox";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxContent)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Label labelContent;
        private PictureBox pictureBoxContent;
        private Button buttonSalvar;
    }
}