namespace FormEleitoral
{
    partial class JanelaUrnaVotacao
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbNumeroDigitado = new System.Windows.Forms.Label();
            this.btnDigito1 = new System.Windows.Forms.Button();
            this.btnDigito2 = new System.Windows.Forms.Button();
            this.btnDigito3 = new System.Windows.Forms.Button();
            this.btnDigito6 = new System.Windows.Forms.Button();
            this.btnDigito5 = new System.Windows.Forms.Button();
            this.btnDigito4 = new System.Windows.Forms.Button();
            this.btnDigito9 = new System.Windows.Forms.Button();
            this.btnDigito8 = new System.Windows.Forms.Button();
            this.btnDigito7 = new System.Windows.Forms.Button();
            this.btnConfirma = new System.Windows.Forms.Button();
            this.btnCorrige = new System.Windows.Forms.Button();
            this.btnBranco = new System.Windows.Forms.Button();
            this.btnDigito0 = new System.Windows.Forms.Button();
            this.lblNomeCandidato = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBoxCandidato = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCandidato)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnDigito0);
            this.panel1.Controls.Add(this.btnBranco);
            this.panel1.Controls.Add(this.btnCorrige);
            this.panel1.Controls.Add(this.btnConfirma);
            this.panel1.Controls.Add(this.pictureBoxCandidato);
            this.panel1.Controls.Add(this.btnDigito9);
            this.panel1.Controls.Add(this.btnDigito8);
            this.panel1.Controls.Add(this.btnDigito7);
            this.panel1.Controls.Add(this.btnDigito6);
            this.panel1.Controls.Add(this.btnDigito5);
            this.panel1.Controls.Add(this.btnDigito4);
            this.panel1.Controls.Add(this.btnDigito3);
            this.panel1.Controls.Add(this.btnDigito2);
            this.panel1.Controls.Add(this.btnDigito1);
            this.panel1.Controls.Add(this.lbNumeroDigitado);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(928, 607);
            this.panel1.TabIndex = 0;
            // 
            // lbNumeroDigitado
            // 
            this.lbNumeroDigitado.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbNumeroDigitado.AutoSize = true;
            this.lbNumeroDigitado.Font = new System.Drawing.Font("Georgia", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNumeroDigitado.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbNumeroDigitado.Location = new System.Drawing.Point(201, 25);
            this.lbNumeroDigitado.Name = "lbNumeroDigitado";
            this.lbNumeroDigitado.Size = new System.Drawing.Size(43, 39);
            this.lbNumeroDigitado.TabIndex = 2;
            this.lbNumeroDigitado.Text = "--";
            this.lbNumeroDigitado.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbNumeroDigitado.TextChanged += new System.EventHandler(this.lbNumeroDigitado_TextChanged);
            // 
            // btnDigito1
            // 
            this.btnDigito1.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDigito1.Location = new System.Drawing.Point(64, 87);
            this.btnDigito1.Name = "btnDigito1";
            this.btnDigito1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnDigito1.Size = new System.Drawing.Size(75, 75);
            this.btnDigito1.TabIndex = 3;
            this.btnDigito1.Text = "1";
            this.btnDigito1.UseVisualStyleBackColor = true;
            this.btnDigito1.Click += new System.EventHandler(this.btnDigito1_Click);
            // 
            // btnDigito2
            // 
            this.btnDigito2.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDigito2.Location = new System.Drawing.Point(185, 87);
            this.btnDigito2.Name = "btnDigito2";
            this.btnDigito2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnDigito2.Size = new System.Drawing.Size(75, 75);
            this.btnDigito2.TabIndex = 4;
            this.btnDigito2.Text = "2";
            this.btnDigito2.UseVisualStyleBackColor = true;
            this.btnDigito2.Click += new System.EventHandler(this.btnDigito2_Click);
            // 
            // btnDigito3
            // 
            this.btnDigito3.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDigito3.Location = new System.Drawing.Point(309, 87);
            this.btnDigito3.Name = "btnDigito3";
            this.btnDigito3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnDigito3.Size = new System.Drawing.Size(75, 75);
            this.btnDigito3.TabIndex = 5;
            this.btnDigito3.Text = "3";
            this.btnDigito3.UseVisualStyleBackColor = true;
            this.btnDigito3.Click += new System.EventHandler(this.btnDigito3_Click);
            // 
            // btnDigito6
            // 
            this.btnDigito6.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDigito6.Location = new System.Drawing.Point(309, 186);
            this.btnDigito6.Name = "btnDigito6";
            this.btnDigito6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnDigito6.Size = new System.Drawing.Size(75, 75);
            this.btnDigito6.TabIndex = 8;
            this.btnDigito6.Text = "6";
            this.btnDigito6.UseVisualStyleBackColor = true;
            this.btnDigito6.Click += new System.EventHandler(this.btnDigito6_Click);
            // 
            // btnDigito5
            // 
            this.btnDigito5.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDigito5.Location = new System.Drawing.Point(185, 186);
            this.btnDigito5.Name = "btnDigito5";
            this.btnDigito5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnDigito5.Size = new System.Drawing.Size(75, 75);
            this.btnDigito5.TabIndex = 7;
            this.btnDigito5.Text = "5";
            this.btnDigito5.UseVisualStyleBackColor = true;
            this.btnDigito5.Click += new System.EventHandler(this.btnDigito5_Click);
            // 
            // btnDigito4
            // 
            this.btnDigito4.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDigito4.Location = new System.Drawing.Point(64, 186);
            this.btnDigito4.Name = "btnDigito4";
            this.btnDigito4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnDigito4.Size = new System.Drawing.Size(75, 75);
            this.btnDigito4.TabIndex = 6;
            this.btnDigito4.Text = "4";
            this.btnDigito4.UseVisualStyleBackColor = true;
            this.btnDigito4.Click += new System.EventHandler(this.btnDigito4_Click);
            // 
            // btnDigito9
            // 
            this.btnDigito9.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDigito9.Location = new System.Drawing.Point(309, 306);
            this.btnDigito9.Name = "btnDigito9";
            this.btnDigito9.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnDigito9.Size = new System.Drawing.Size(75, 75);
            this.btnDigito9.TabIndex = 11;
            this.btnDigito9.Text = "9";
            this.btnDigito9.UseVisualStyleBackColor = true;
            this.btnDigito9.Click += new System.EventHandler(this.btnDigito9_Click);
            // 
            // btnDigito8
            // 
            this.btnDigito8.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDigito8.Location = new System.Drawing.Point(185, 306);
            this.btnDigito8.Name = "btnDigito8";
            this.btnDigito8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnDigito8.Size = new System.Drawing.Size(75, 75);
            this.btnDigito8.TabIndex = 10;
            this.btnDigito8.Text = "8";
            this.btnDigito8.UseVisualStyleBackColor = true;
            this.btnDigito8.Click += new System.EventHandler(this.btnDigito8_Click);
            // 
            // btnDigito7
            // 
            this.btnDigito7.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDigito7.Location = new System.Drawing.Point(64, 306);
            this.btnDigito7.Name = "btnDigito7";
            this.btnDigito7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnDigito7.Size = new System.Drawing.Size(75, 75);
            this.btnDigito7.TabIndex = 9;
            this.btnDigito7.Text = "7";
            this.btnDigito7.UseVisualStyleBackColor = true;
            this.btnDigito7.Click += new System.EventHandler(this.btnDigito7_Click);
            // 
            // btnConfirma
            // 
            this.btnConfirma.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnConfirma.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirma.ForeColor = System.Drawing.Color.DarkSeaGreen;
            this.btnConfirma.Location = new System.Drawing.Point(531, 497);
            this.btnConfirma.Name = "btnConfirma";
            this.btnConfirma.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnConfirma.Size = new System.Drawing.Size(312, 75);
            this.btnConfirma.TabIndex = 13;
            this.btnConfirma.Text = "CONFIRMA";
            this.btnConfirma.UseVisualStyleBackColor = false;
            this.btnConfirma.Click += new System.EventHandler(this.btnConfirma_Click);
            // 
            // btnCorrige
            // 
            this.btnCorrige.BackColor = System.Drawing.Color.Gold;
            this.btnCorrige.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCorrige.ForeColor = System.Drawing.Color.DarkKhaki;
            this.btnCorrige.Location = new System.Drawing.Point(266, 497);
            this.btnCorrige.Name = "btnCorrige";
            this.btnCorrige.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnCorrige.Size = new System.Drawing.Size(160, 75);
            this.btnCorrige.TabIndex = 14;
            this.btnCorrige.Text = "CORRIGIR";
            this.btnCorrige.UseVisualStyleBackColor = false;
            this.btnCorrige.Click += new System.EventHandler(this.btnCorrige_Click);
            // 
            // btnBranco
            // 
            this.btnBranco.BackColor = System.Drawing.Color.Snow;
            this.btnBranco.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBranco.ForeColor = System.Drawing.Color.DarkGray;
            this.btnBranco.Location = new System.Drawing.Point(21, 497);
            this.btnBranco.Name = "btnBranco";
            this.btnBranco.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnBranco.Size = new System.Drawing.Size(160, 75);
            this.btnBranco.TabIndex = 16;
            this.btnBranco.Text = "BRANCO";
            this.btnBranco.UseVisualStyleBackColor = false;
            this.btnBranco.Click += new System.EventHandler(this.btnBranco_Click);
            // 
            // btnDigito0
            // 
            this.btnDigito0.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDigito0.Location = new System.Drawing.Point(185, 402);
            this.btnDigito0.Name = "btnDigito0";
            this.btnDigito0.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnDigito0.Size = new System.Drawing.Size(75, 75);
            this.btnDigito0.TabIndex = 17;
            this.btnDigito0.Text = "0";
            this.btnDigito0.UseVisualStyleBackColor = true;
            this.btnDigito0.Click += new System.EventHandler(this.btnDigito0_Click);
            // 
            // lblNomeCandidato
            // 
            this.lblNomeCandidato.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNomeCandidato.Font = new System.Drawing.Font("Georgia", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeCandidato.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblNomeCandidato.Location = new System.Drawing.Point(0, 0);
            this.lblNomeCandidato.Name = "lblNomeCandidato";
            this.lblNomeCandidato.Size = new System.Drawing.Size(407, 58);
            this.lblNomeCandidato.TabIndex = 18;
            this.lblNomeCandidato.Text = "--";
            this.lblNomeCandidato.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblNomeCandidato);
            this.panel2.Location = new System.Drawing.Point(482, 8);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(407, 58);
            this.panel2.TabIndex = 19;
            // 
            // pictureBoxCandidato
            // 
            this.pictureBoxCandidato.Location = new System.Drawing.Point(482, 72);
            this.pictureBoxCandidato.Name = "pictureBoxCandidato";
            this.pictureBoxCandidato.Size = new System.Drawing.Size(411, 346);
            this.pictureBoxCandidato.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCandidato.TabIndex = 12;
            this.pictureBoxCandidato.TabStop = false;
            // 
            // JanelaUrnaVotacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 607);
            this.Controls.Add(this.panel1);
            this.Name = "JanelaUrnaVotacao";
            this.Text = "Urna de Votação";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCandidato)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblNomeCandidato;
        private System.Windows.Forms.Button btnDigito0;
        private System.Windows.Forms.Button btnBranco;
        private System.Windows.Forms.Button btnCorrige;
        private System.Windows.Forms.Button btnConfirma;
        private System.Windows.Forms.PictureBox pictureBoxCandidato;
        private System.Windows.Forms.Button btnDigito9;
        private System.Windows.Forms.Button btnDigito8;
        private System.Windows.Forms.Button btnDigito7;
        private System.Windows.Forms.Button btnDigito6;
        private System.Windows.Forms.Button btnDigito5;
        private System.Windows.Forms.Button btnDigito4;
        private System.Windows.Forms.Button btnDigito3;
        private System.Windows.Forms.Button btnDigito2;
        private System.Windows.Forms.Button btnDigito1;
        private System.Windows.Forms.Label lbNumeroDigitado;
        private System.Windows.Forms.Panel panel2;
    }
}