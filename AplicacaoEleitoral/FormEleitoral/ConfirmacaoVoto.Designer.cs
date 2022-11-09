namespace FormEleitoral
{
    partial class ConfirmacaoVoto
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
            this.lblConfirmacao = new System.Windows.Forms.Label();
            this.btnFinaliza = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblConfirmacao
            // 
            this.lblConfirmacao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblConfirmacao.AutoSize = true;
            this.lblConfirmacao.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmacao.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblConfirmacao.Location = new System.Drawing.Point(41, 34);
            this.lblConfirmacao.Name = "lblConfirmacao";
            this.lblConfirmacao.Size = new System.Drawing.Size(222, 27);
            this.lblConfirmacao.TabIndex = 2;
            this.lblConfirmacao.Text = "Voto Computado!";
            this.lblConfirmacao.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnFinaliza
            // 
            this.btnFinaliza.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnFinaliza.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinaliza.ForeColor = System.Drawing.Color.DarkSeaGreen;
            this.btnFinaliza.Location = new System.Drawing.Point(41, 87);
            this.btnFinaliza.Name = "btnFinaliza";
            this.btnFinaliza.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnFinaliza.Size = new System.Drawing.Size(222, 59);
            this.btnFinaliza.TabIndex = 14;
            this.btnFinaliza.Text = "FINALIZAR";
            this.btnFinaliza.UseVisualStyleBackColor = false;
            this.btnFinaliza.Click += new System.EventHandler(this.btnFinaliza_Click);
            // 
            // ConfirmacaoVoto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 158);
            this.Controls.Add(this.btnFinaliza);
            this.Controls.Add(this.lblConfirmacao);
            this.Name = "ConfirmacaoVoto";
            this.Text = "Confirmação Voto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblConfirmacao;
        private System.Windows.Forms.Button btnFinaliza;
    }
}