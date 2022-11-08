namespace FormEleitoral
{
    partial class JanelaColinha
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
            this.lbNumeroCandidato = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBoxCandidatoColinha = new System.Windows.Forms.PictureBox();
            this.comboBoxColinha = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCandidatoColinha)).BeginInit();
            this.SuspendLayout();
            // 
            // lbNumeroCandidato
            // 
            this.lbNumeroCandidato.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbNumeroCandidato.AutoSize = true;
            this.lbNumeroCandidato.Font = new System.Drawing.Font("Georgia", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNumeroCandidato.Location = new System.Drawing.Point(371, 387);
            this.lbNumeroCandidato.Name = "lbNumeroCandidato";
            this.lbNumeroCandidato.Size = new System.Drawing.Size(59, 54);
            this.lbNumeroCandidato.TabIndex = 1;
            this.lbNumeroCandidato.Text = "--";
            this.lbNumeroCandidato.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbNumeroCandidato);
            this.panel1.Controls.Add(this.pictureBoxCandidatoColinha);
            this.panel1.Controls.Add(this.comboBoxColinha);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 3;
            // 
            // pictureBoxCandidatoColinha
            // 
            this.pictureBoxCandidatoColinha.Location = new System.Drawing.Point(257, 82);
            this.pictureBoxCandidatoColinha.Name = "pictureBoxCandidatoColinha";
            this.pictureBoxCandidatoColinha.Size = new System.Drawing.Size(287, 287);
            this.pictureBoxCandidatoColinha.TabIndex = 1;
            this.pictureBoxCandidatoColinha.TabStop = false;
            // 
            // comboBoxColinha
            // 
            this.comboBoxColinha.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxColinha.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxColinha.FormattingEnabled = true;
            this.comboBoxColinha.Items.AddRange(new object[] {
            "Jar Jar",
            "Mestre Yoda",
            "Darth Vader",
            "Senadora Padmé"});
            this.comboBoxColinha.Location = new System.Drawing.Point(264, 21);
            this.comboBoxColinha.Name = "comboBoxColinha";
            this.comboBoxColinha.Size = new System.Drawing.Size(287, 32);
            this.comboBoxColinha.TabIndex = 0;
            this.comboBoxColinha.Text = "Selecione o Candidato";
            this.comboBoxColinha.SelectedIndexChanged += new System.EventHandler(this.comboBoxColinha_SelectedIndexChanged);
            // 
            // JanelaColinha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "JanelaColinha";
            this.Text = "Colinha dos Candidatos";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCandidatoColinha)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbNumeroCandidato;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBoxCandidatoColinha;
        private System.Windows.Forms.ComboBox comboBoxColinha;
    }
}