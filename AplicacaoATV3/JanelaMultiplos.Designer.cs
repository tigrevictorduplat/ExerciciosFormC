namespace AplicacaoATV3
{
    partial class JanelaMultiplos
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
            this.lblPrimeiroNumero = new System.Windows.Forms.Label();
            this.txtBoxPrimeiroNumero = new System.Windows.Forms.TextBox();
            this.txtIntervaloSegundo = new System.Windows.Forms.TextBox();
            this.txtIntervaloPrimeiro = new System.Windows.Forms.TextBox();
            this.lblTextMultiplos = new System.Windows.Forms.Label();
            this.lblTextIntervaloMultiplos = new System.Windows.Forms.Label();
            this.btnExecutar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtBoxSegundoNumero = new System.Windows.Forms.TextBox();
            this.lblSegundoNumero = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPrimeiroNumero
            // 
            this.lblPrimeiroNumero.AutoSize = true;
            this.lblPrimeiroNumero.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrimeiroNumero.Location = new System.Drawing.Point(55, 58);
            this.lblPrimeiroNumero.Name = "lblPrimeiroNumero";
            this.lblPrimeiroNumero.Size = new System.Drawing.Size(168, 24);
            this.lblPrimeiroNumero.TabIndex = 0;
            this.lblPrimeiroNumero.Text = "Primeiro Número";
            // 
            // txtBoxPrimeiroNumero
            // 
            this.txtBoxPrimeiroNumero.Location = new System.Drawing.Point(106, 97);
            this.txtBoxPrimeiroNumero.Name = "txtBoxPrimeiroNumero";
            this.txtBoxPrimeiroNumero.Size = new System.Drawing.Size(60, 22);
            this.txtBoxPrimeiroNumero.TabIndex = 2;
            // 
            // txtIntervaloSegundo
            // 
            this.txtIntervaloSegundo.Location = new System.Drawing.Point(306, 210);
            this.txtIntervaloSegundo.Name = "txtIntervaloSegundo";
            this.txtIntervaloSegundo.Size = new System.Drawing.Size(161, 22);
            this.txtIntervaloSegundo.TabIndex = 7;
            // 
            // txtIntervaloPrimeiro
            // 
            this.txtIntervaloPrimeiro.Location = new System.Drawing.Point(59, 210);
            this.txtIntervaloPrimeiro.Name = "txtIntervaloPrimeiro";
            this.txtIntervaloPrimeiro.Size = new System.Drawing.Size(161, 22);
            this.txtIntervaloPrimeiro.TabIndex = 6;
            // 
            // lblTextMultiplos
            // 
            this.lblTextMultiplos.AutoSize = true;
            this.lblTextMultiplos.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextMultiplos.Location = new System.Drawing.Point(237, 205);
            this.lblTextMultiplos.Name = "lblTextMultiplos";
            this.lblTextMultiplos.Size = new System.Drawing.Size(52, 32);
            this.lblTextMultiplos.TabIndex = 5;
            this.lblTextMultiplos.Text = "até";
            // 
            // lblTextIntervaloMultiplos
            // 
            this.lblTextIntervaloMultiplos.AutoSize = true;
            this.lblTextIntervaloMultiplos.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextIntervaloMultiplos.Location = new System.Drawing.Point(37, 141);
            this.lblTextIntervaloMultiplos.Name = "lblTextIntervaloMultiplos";
            this.lblTextIntervaloMultiplos.Size = new System.Drawing.Size(468, 24);
            this.lblTextIntervaloMultiplos.TabIndex = 4;
            this.lblTextIntervaloMultiplos.Text = "Digite dois valores inteiros para o intervalo de teste";
            // 
            // btnExecutar
            // 
            this.btnExecutar.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExecutar.Location = new System.Drawing.Point(50, 286);
            this.btnExecutar.Name = "btnExecutar";
            this.btnExecutar.Size = new System.Drawing.Size(430, 37);
            this.btnExecutar.TabIndex = 8;
            this.btnExecutar.Text = "Executar";
            this.btnExecutar.UseVisualStyleBackColor = true;
            this.btnExecutar.Click += new System.EventHandler(this.btnExecutar_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtBoxSegundoNumero);
            this.panel1.Controls.Add(this.lblSegundoNumero);
            this.panel1.Controls.Add(this.btnExecutar);
            this.panel1.Controls.Add(this.txtIntervaloSegundo);
            this.panel1.Controls.Add(this.txtIntervaloPrimeiro);
            this.panel1.Controls.Add(this.lblTextMultiplos);
            this.panel1.Controls.Add(this.lblTextIntervaloMultiplos);
            this.panel1.Controls.Add(this.txtBoxPrimeiroNumero);
            this.panel1.Controls.Add(this.lblPrimeiroNumero);
            this.panel1.Location = new System.Drawing.Point(12, 11);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(515, 366);
            this.panel1.TabIndex = 9;
            // 
            // txtBoxSegundoNumero
            // 
            this.txtBoxSegundoNumero.Location = new System.Drawing.Point(351, 97);
            this.txtBoxSegundoNumero.Name = "txtBoxSegundoNumero";
            this.txtBoxSegundoNumero.Size = new System.Drawing.Size(60, 22);
            this.txtBoxSegundoNumero.TabIndex = 10;
            // 
            // lblSegundoNumero
            // 
            this.lblSegundoNumero.AutoSize = true;
            this.lblSegundoNumero.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSegundoNumero.Location = new System.Drawing.Point(302, 58);
            this.lblSegundoNumero.Name = "lblSegundoNumero";
            this.lblSegundoNumero.Size = new System.Drawing.Size(166, 24);
            this.lblSegundoNumero.TabIndex = 9;
            this.lblSegundoNumero.Text = "Segundo Número";
            // 
            // JanelaMultiplos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 389);
            this.Controls.Add(this.panel1);
            this.Name = "JanelaMultiplos";
            this.Text = "JanelaMultiplos";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblPrimeiroNumero;
        private System.Windows.Forms.TextBox txtBoxPrimeiroNumero;
        private System.Windows.Forms.TextBox txtIntervaloSegundo;
        private System.Windows.Forms.TextBox txtIntervaloPrimeiro;
        private System.Windows.Forms.Label lblTextMultiplos;
        private System.Windows.Forms.Label lblTextIntervaloMultiplos;
        private System.Windows.Forms.Button btnExecutar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtBoxSegundoNumero;
        private System.Windows.Forms.Label lblSegundoNumero;
    }
}