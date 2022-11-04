namespace AplicacaoATV3
{
    partial class JanelaConversor
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
            this.lbDescricaoConversor = new System.Windows.Forms.Label();
            this.btConverter = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtIntervaloSegundo = new System.Windows.Forms.TextBox();
            this.txtIntervaloPrimeiro = new System.Windows.Forms.TextBox();
            this.lblTextConversor = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbDescricaoConversor
            // 
            this.lbDescricaoConversor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbDescricaoConversor.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDescricaoConversor.Location = new System.Drawing.Point(5, 32);
            this.lbDescricaoConversor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDescricaoConversor.Name = "lbDescricaoConversor";
            this.lbDescricaoConversor.Size = new System.Drawing.Size(558, 29);
            this.lbDescricaoConversor.TabIndex = 3;
            this.lbDescricaoConversor.Text = "Escolha um intervalo em Graus F° para converter em C°";
            this.lbDescricaoConversor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btConverter
            // 
            this.btConverter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btConverter.Location = new System.Drawing.Point(221, 170);
            this.btConverter.Margin = new System.Windows.Forms.Padding(4);
            this.btConverter.Name = "btConverter";
            this.btConverter.Size = new System.Drawing.Size(144, 28);
            this.btConverter.TabIndex = 2;
            this.btConverter.Text = "Converter";
            this.btConverter.UseVisualStyleBackColor = true;
            this.btConverter.Click += new System.EventHandler(this.btConverter_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtIntervaloSegundo);
            this.panel1.Controls.Add(this.txtIntervaloPrimeiro);
            this.panel1.Controls.Add(this.lblTextConversor);
            this.panel1.Controls.Add(this.lbDescricaoConversor);
            this.panel1.Controls.Add(this.btConverter);
            this.panel1.Location = new System.Drawing.Point(8, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(570, 231);
            this.panel1.TabIndex = 4;
            // 
            // txtIntervaloSegundo
            // 
            this.txtIntervaloSegundo.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtIntervaloSegundo.Location = new System.Drawing.Point(337, 109);
            this.txtIntervaloSegundo.Name = "txtIntervaloSegundo";
            this.txtIntervaloSegundo.Size = new System.Drawing.Size(161, 22);
            this.txtIntervaloSegundo.TabIndex = 10;
            // 
            // txtIntervaloPrimeiro
            // 
            this.txtIntervaloPrimeiro.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtIntervaloPrimeiro.Location = new System.Drawing.Point(91, 109);
            this.txtIntervaloPrimeiro.Name = "txtIntervaloPrimeiro";
            this.txtIntervaloPrimeiro.Size = new System.Drawing.Size(161, 22);
            this.txtIntervaloPrimeiro.TabIndex = 9;
            // 
            // lblTextConversor
            // 
            this.lblTextConversor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTextConversor.AutoSize = true;
            this.lblTextConversor.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextConversor.Location = new System.Drawing.Point(276, 108);
            this.lblTextConversor.Name = "lblTextConversor";
            this.lblTextConversor.Size = new System.Drawing.Size(37, 24);
            this.lblTextConversor.TabIndex = 8;
            this.lblTextConversor.Text = "até";
            // 
            // JanelaConversor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 236);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "JanelaConversor";
            this.Text = "JanelaConversor";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbDescricaoConversor;
        private System.Windows.Forms.Button btConverter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtIntervaloSegundo;
        private System.Windows.Forms.TextBox txtIntervaloPrimeiro;
        private System.Windows.Forms.Label lblTextConversor;
    }
}