﻿namespace AplicacaoATV3
{
    partial class JanelaFatorial
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
            this.txtBoxFatorial = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCalculaFatorial = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtBoxFatorial
            // 
            this.txtBoxFatorial.Location = new System.Drawing.Point(37, 64);
            this.txtBoxFatorial.Name = "txtBoxFatorial";
            this.txtBoxFatorial.Size = new System.Drawing.Size(299, 22);
            this.txtBoxFatorial.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Digite um número inteiro e positivo:";
            // 
            // btnCalculaFatorial
            // 
            this.btnCalculaFatorial.Location = new System.Drawing.Point(150, 120);
            this.btnCalculaFatorial.Name = "btnCalculaFatorial";
            this.btnCalculaFatorial.Size = new System.Drawing.Size(75, 23);
            this.btnCalculaFatorial.TabIndex = 2;
            this.btnCalculaFatorial.Text = "Calcular";
            this.btnCalculaFatorial.UseVisualStyleBackColor = true;
            this.btnCalculaFatorial.Click += new System.EventHandler(this.btnCalculaFatorial_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCalculaFatorial);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtBoxFatorial);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(360, 169);
            this.panel1.TabIndex = 3;
            // 
            // JanelaFatorial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 193);
            this.Controls.Add(this.panel1);
            this.Name = "JanelaFatorial";
            this.Text = "Operação Fatorial";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxFatorial;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCalculaFatorial;
        private System.Windows.Forms.Panel panel1;
    }
}