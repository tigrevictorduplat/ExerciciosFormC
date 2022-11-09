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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JanelaColinha));
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
            resources.ApplyResources(this.lbNumeroCandidato, "lbNumeroCandidato");
            this.lbNumeroCandidato.Name = "lbNumeroCandidato";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbNumeroCandidato);
            this.panel1.Controls.Add(this.pictureBoxCandidatoColinha);
            this.panel1.Controls.Add(this.comboBoxColinha);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // pictureBoxCandidatoColinha
            // 
            resources.ApplyResources(this.pictureBoxCandidatoColinha, "pictureBoxCandidatoColinha");
            this.pictureBoxCandidatoColinha.Name = "pictureBoxCandidatoColinha";
            this.pictureBoxCandidatoColinha.TabStop = false;
            // 
            // comboBoxColinha
            // 
            resources.ApplyResources(this.comboBoxColinha, "comboBoxColinha");
            this.comboBoxColinha.FormattingEnabled = true;
            this.comboBoxColinha.Items.AddRange(new object[] {
            resources.GetString("comboBoxColinha.Items"),
            resources.GetString("comboBoxColinha.Items1"),
            resources.GetString("comboBoxColinha.Items2"),
            resources.GetString("comboBoxColinha.Items3")});
            this.comboBoxColinha.Name = "comboBoxColinha";
            this.comboBoxColinha.SelectedIndexChanged += new System.EventHandler(this.comboBoxColinha_SelectedIndexChanged);
            // 
            // JanelaColinha
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "JanelaColinha";
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