namespace AplicacaoEscolar
{
    partial class JanelaInicial
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTituloInicio = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCadastro = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTituloInicio
            // 
            this.lblTituloInicio.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTituloInicio.Font = new System.Drawing.Font("Georgia", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloInicio.Location = new System.Drawing.Point(0, 0);
            this.lblTituloInicio.Name = "lblTituloInicio";
            this.lblTituloInicio.Size = new System.Drawing.Size(586, 108);
            this.lblTituloInicio.TabIndex = 0;
            this.lblTituloInicio.Text = "Cadastro de Usuários Internos";
            this.lblTituloInicio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCadastro);
            this.panel1.Controls.Add(this.lblTituloInicio);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(586, 215);
            this.panel1.TabIndex = 1;
            // 
            // btnCadastro
            // 
            this.btnCadastro.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastro.Location = new System.Drawing.Point(83, 132);
            this.btnCadastro.Name = "btnCadastro";
            this.btnCadastro.Size = new System.Drawing.Size(420, 50);
            this.btnCadastro.TabIndex = 1;
            this.btnCadastro.Text = "Novo Cadastro";
            this.btnCadastro.UseVisualStyleBackColor = true;
            this.btnCadastro.Click += new System.EventHandler(this.btnCadastro_Click);
            // 
            // JanelaInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 215);
            this.Controls.Add(this.panel1);
            this.Name = "JanelaInicial";
            this.Text = "Janela Inicial";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTituloInicio;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCadastro;
    }
}

