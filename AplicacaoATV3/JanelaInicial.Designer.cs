namespace AplicacaoATV3
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnFatorial = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMultiplos = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Georgia", 24F);
            this.lblTitulo.Location = new System.Drawing.Point(213, 28);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(368, 46);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Calculadora Mágica";
            // 
            // btnFatorial
            // 
            this.btnFatorial.Font = new System.Drawing.Font("Georgia", 12F);
            this.btnFatorial.Location = new System.Drawing.Point(38, 207);
            this.btnFatorial.Name = "btnFatorial";
            this.btnFatorial.Size = new System.Drawing.Size(145, 37);
            this.btnFatorial.TabIndex = 1;
            this.btnFatorial.Text = "Fatorial";
            this.btnFatorial.UseVisualStyleBackColor = true;
            this.btnFatorial.Click += new System.EventHandler(this.btnFatorial_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnMultiplos);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnFatorial);
            this.panel1.Controls.Add(this.lblTitulo);
            this.panel1.Font = new System.Drawing.Font("Georgia", 24F);
            this.panel1.Location = new System.Drawing.Point(6, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(782, 295);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(160, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(475, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Escolha uma operação para realizar: ";
            // 
            // btnMultiplos
            // 
            this.btnMultiplos.Font = new System.Drawing.Font("Georgia", 12F);
            this.btnMultiplos.Location = new System.Drawing.Point(608, 207);
            this.btnMultiplos.Name = "btnMultiplos";
            this.btnMultiplos.Size = new System.Drawing.Size(145, 37);
            this.btnMultiplos.TabIndex = 3;
            this.btnMultiplos.Text = "Múltiplos";
            this.btnMultiplos.UseVisualStyleBackColor = true;
            this.btnMultiplos.Click += new System.EventHandler(this.btnMultiplos_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Georgia", 12F);
            this.button1.Location = new System.Drawing.Point(323, 206);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 37);
            this.button1.TabIndex = 4;
            this.button1.Text = "Conversor C°";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // JanelaInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 319);
            this.Controls.Add(this.panel1);
            this.Name = "JanelaInicial";
            this.Text = "Menu Inicial";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnFatorial;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnMultiplos;
        private System.Windows.Forms.Label label1;
    }
}

