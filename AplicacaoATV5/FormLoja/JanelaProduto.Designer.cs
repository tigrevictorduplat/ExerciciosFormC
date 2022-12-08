namespace FormLoja
{
    partial class JanelaProduto
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
            this.panelProduto = new System.Windows.Forms.Panel();
            this.dataTimePickerProduto = new System.Windows.Forms.DateTimePicker();
            this.lbDataValidade = new System.Windows.Forms.Label();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.txtDescricaoProduto = new System.Windows.Forms.TextBox();
            this.btnCadastrarProduto = new System.Windows.Forms.Button();
            this.lbQuantidade = new System.Windows.Forms.Label();
            this.lbPreco = new System.Windows.Forms.Label();
            this.lbDescricaoProduto = new System.Windows.Forms.Label();
            this.panelProduto.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelProduto
            // 
            this.panelProduto.Controls.Add(this.dataTimePickerProduto);
            this.panelProduto.Controls.Add(this.lbDataValidade);
            this.panelProduto.Controls.Add(this.txtQuantidade);
            this.panelProduto.Controls.Add(this.txtPreco);
            this.panelProduto.Controls.Add(this.txtDescricaoProduto);
            this.panelProduto.Controls.Add(this.btnCadastrarProduto);
            this.panelProduto.Controls.Add(this.lbQuantidade);
            this.panelProduto.Controls.Add(this.lbPreco);
            this.panelProduto.Controls.Add(this.lbDescricaoProduto);
            this.panelProduto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelProduto.Location = new System.Drawing.Point(0, 0);
            this.panelProduto.Name = "panelProduto";
            this.panelProduto.Size = new System.Drawing.Size(368, 410);
            this.panelProduto.TabIndex = 4;
            // 
            // dataTimePickerProduto
            // 
            this.dataTimePickerProduto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dataTimePickerProduto.Font = new System.Drawing.Font("Lucida Console", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataTimePickerProduto.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dataTimePickerProduto.Location = new System.Drawing.Point(79, 282);
            this.dataTimePickerProduto.MaxDate = new System.DateTime(2030, 1, 1, 0, 0, 0, 0);
            this.dataTimePickerProduto.MinDate = System.DateTime.Now;
            this.dataTimePickerProduto.Name = "dataTimePickerProduto";
            this.dataTimePickerProduto.Size = new System.Drawing.Size(217, 24);
            this.dataTimePickerProduto.TabIndex = 14;
            this.dataTimePickerProduto.Value = System.DateTime.Now;
            // 
            // lbDataValidade
            // 
            this.lbDataValidade.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbDataValidade.AutoSize = true;
            this.lbDataValidade.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDataValidade.Location = new System.Drawing.Point(97, 230);
            this.lbDataValidade.Name = "lbDataValidade";
            this.lbDataValidade.Size = new System.Drawing.Size(160, 24);
            this.lbDataValidade.TabIndex = 13;
            this.lbDataValidade.Text = "Data de Validade";
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtQuantidade.Font = new System.Drawing.Font("Lucida Console", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantidade.Location = new System.Drawing.Point(232, 184);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(89, 24);
            this.txtQuantidade.TabIndex = 9;
            this.txtQuantidade.Text = "1";
            this.txtQuantidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPreco
            // 
            this.txtPreco.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtPreco.Font = new System.Drawing.Font("Lucida Console", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPreco.Location = new System.Drawing.Point(51, 184);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(89, 24);
            this.txtPreco.TabIndex = 10;
            this.txtPreco.Text = "R$";
            this.txtPreco.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDescricaoProduto
            // 
            this.txtDescricaoProduto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescricaoProduto.Font = new System.Drawing.Font("Lucida Console", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescricaoProduto.Location = new System.Drawing.Point(88, 88);
            this.txtDescricaoProduto.Name = "txtDescricaoProduto";
            this.txtDescricaoProduto.Size = new System.Drawing.Size(209, 24);
            this.txtDescricaoProduto.TabIndex = 11;
            this.txtDescricaoProduto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnCadastrarProduto
            // 
            this.btnCadastrarProduto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCadastrarProduto.Font = new System.Drawing.Font("Lucida Console", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarProduto.Location = new System.Drawing.Point(83, 353);
            this.btnCadastrarProduto.Name = "btnCadastrarProduto";
            this.btnCadastrarProduto.Size = new System.Drawing.Size(209, 24);
            this.btnCadastrarProduto.TabIndex = 8;
            this.btnCadastrarProduto.Text = "Enviar Cadastro";
            this.btnCadastrarProduto.UseVisualStyleBackColor = true;
            this.btnCadastrarProduto.Click += new System.EventHandler(this.btnCadastrarProduto_Click);
            // 
            // lbQuantidade
            // 
            this.lbQuantidade.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbQuantidade.AutoSize = true;
            this.lbQuantidade.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQuantidade.Location = new System.Drawing.Point(219, 136);
            this.lbQuantidade.Name = "lbQuantidade";
            this.lbQuantidade.Size = new System.Drawing.Size(114, 24);
            this.lbQuantidade.TabIndex = 7;
            this.lbQuantidade.Text = "Quantidade";
            // 
            // lbPreco
            // 
            this.lbPreco.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbPreco.AutoSize = true;
            this.lbPreco.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPreco.Location = new System.Drawing.Point(25, 136);
            this.lbPreco.Name = "lbPreco";
            this.lbPreco.Size = new System.Drawing.Size(140, 24);
            this.lbPreco.TabIndex = 6;
            this.lbPreco.Text = "Preço Unitário";
            // 
            // lbDescricaoProduto
            // 
            this.lbDescricaoProduto.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbDescricaoProduto.AutoSize = true;
            this.lbDescricaoProduto.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDescricaoProduto.Location = new System.Drawing.Point(92, 36);
            this.lbDescricaoProduto.Name = "lbDescricaoProduto";
            this.lbDescricaoProduto.Size = new System.Drawing.Size(201, 24);
            this.lbDescricaoProduto.TabIndex = 5;
            this.lbDescricaoProduto.Text = "Descrição do Produto";
            // 
            // JanelaProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 410);
            this.Controls.Add(this.panelProduto);
            this.Name = "JanelaProduto";
            this.Text = "Cadastrar Produto";
            this.panelProduto.ResumeLayout(false);
            this.panelProduto.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelProduto;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.TextBox txtDescricaoProduto;
        private System.Windows.Forms.Button btnCadastrarProduto;
        private System.Windows.Forms.Label lbQuantidade;
        private System.Windows.Forms.Label lbPreco;
        private System.Windows.Forms.Label lbDescricaoProduto;
        private System.Windows.Forms.DateTimePicker dataTimePickerProduto;
        private System.Windows.Forms.Label lbDataValidade;
    }
}