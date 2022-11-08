namespace FormEleitoral
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
            this.lbTituloMenu = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btComecar = new System.Windows.Forms.Button();
            this.btColinha = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbTituloMenu
            // 
            this.lbTituloMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTituloMenu.AutoSize = true;
            this.lbTituloMenu.Font = new System.Drawing.Font("Georgia", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTituloMenu.Location = new System.Drawing.Point(180, 43);
            this.lbTituloMenu.Name = "lbTituloMenu";
            this.lbTituloMenu.Size = new System.Drawing.Size(440, 54);
            this.lbTituloMenu.TabIndex = 0;
            this.lbTituloMenu.Text = "Sistema Eleitoral";
            this.lbTituloMenu.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btColinha);
            this.panel1.Controls.Add(this.btComecar);
            this.panel1.Controls.Add(this.lbTituloMenu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 1;
            // 
            // btComecar
            // 
            this.btComecar.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btComecar.Location = new System.Drawing.Point(180, 184);
            this.btComecar.Name = "btComecar";
            this.btComecar.Size = new System.Drawing.Size(440, 44);
            this.btComecar.TabIndex = 1;
            this.btComecar.Text = "Começar Votação";
            this.btComecar.UseVisualStyleBackColor = true;
            // 
            // btColinha
            // 
            this.btColinha.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btColinha.Location = new System.Drawing.Point(180, 315);
            this.btColinha.Name = "btColinha";
            this.btColinha.Size = new System.Drawing.Size(440, 44);
            this.btColinha.TabIndex = 2;
            this.btColinha.Text = "Colinha dos Candidatos";
            this.btColinha.UseVisualStyleBackColor = true;
            this.btColinha.Click += new System.EventHandler(this.btColinha_Click);
            // 
            // JanelaInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "JanelaInicial";
            this.Text = "Menu Inicial";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbTituloMenu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btColinha;
        private System.Windows.Forms.Button btComecar;
    }
}

