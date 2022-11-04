namespace AplicacaoATV3
{
    partial class JanelaResultadoTabela
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.lblTituloResultadoTabela = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(78, 70);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(304, 368);
            this.dataGridView.TabIndex = 0;
            // 
            // lblTituloResultadoTabela
            // 
            this.lblTituloResultadoTabela.AutoSize = true;
            this.lblTituloResultadoTabela.Font = new System.Drawing.Font("Georgia", 20F);
            this.lblTituloResultadoTabela.Location = new System.Drawing.Point(86, 9);
            this.lblTituloResultadoTabela.Name = "lblTituloResultadoTabela";
            this.lblTituloResultadoTabela.Size = new System.Drawing.Size(280, 39);
            this.lblTituloResultadoTabela.TabIndex = 1;
            this.lblTituloResultadoTabela.Text = "Calcula Multiplos";
            // 
            // JanelaResultadoTabela
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 450);
            this.Controls.Add(this.lblTituloResultadoTabela);
            this.Controls.Add(this.dataGridView);
            this.Name = "JanelaResultadoTabela";
            this.Text = "Resultado em Tabela";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label lblTituloResultadoTabela;
    }
}