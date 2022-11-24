namespace AplicacaoEscolar
{
    partial class JanelaCadastroTabela
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rdConvidado = new System.Windows.Forms.RadioButton();
            this.rdAdministrador = new System.Windows.Forms.RadioButton();
            this.lblPerfil = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.lblObs = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rdAluno = new System.Windows.Forms.RadioButton();
            this.rdProfessor = new System.Windows.Forms.RadioButton();
            this.rdTecnico = new System.Windows.Forms.RadioButton();
            this.lblTipo = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtBoxSenha = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.lblModulo = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.colunaLogin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colunaSenha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colunaStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colunaTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colunaData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colunaPerfil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colunaModulos = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(754, 367);
            this.tabControl.TabIndex = 0;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Controls.Add(this.comboBox1);
            this.tabPage1.Controls.Add(this.dateTimePicker1);
            this.tabPage1.Controls.Add(this.richTextBox1);
            this.tabPage1.Controls.Add(this.lblObs);
            this.tabPage1.Controls.Add(this.lblData);
            this.tabPage1.Controls.Add(this.lblStatus);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.panel3);
            this.tabPage1.Controls.Add(this.panel4);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(746, 338);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Novo Cadastro";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rdConvidado);
            this.panel2.Controls.Add(this.rdAdministrador);
            this.panel2.Controls.Add(this.lblPerfil);
            this.panel2.Location = new System.Drawing.Point(347, 109);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(382, 64);
            this.panel2.TabIndex = 13;
            // 
            // rdConvidado
            // 
            this.rdConvidado.AutoSize = true;
            this.rdConvidado.Location = new System.Drawing.Point(224, 20);
            this.rdConvidado.Name = "rdConvidado";
            this.rdConvidado.Size = new System.Drawing.Size(94, 20);
            this.rdConvidado.TabIndex = 7;
            this.rdConvidado.TabStop = true;
            this.rdConvidado.Text = "Convidado";
            this.rdConvidado.UseVisualStyleBackColor = true;
            // 
            // rdAdministrador
            // 
            this.rdAdministrador.AutoSize = true;
            this.rdAdministrador.Location = new System.Drawing.Point(86, 20);
            this.rdAdministrador.Name = "rdAdministrador";
            this.rdAdministrador.Size = new System.Drawing.Size(111, 20);
            this.rdAdministrador.TabIndex = 6;
            this.rdAdministrador.TabStop = true;
            this.rdAdministrador.Text = "Administrador";
            this.rdAdministrador.UseVisualStyleBackColor = true;
            // 
            // lblPerfil
            // 
            this.lblPerfil.AutoSize = true;
            this.lblPerfil.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPerfil.Location = new System.Drawing.Point(10, 21);
            this.lblPerfil.Name = "lblPerfil";
            this.lblPerfil.Size = new System.Drawing.Size(49, 19);
            this.lblPerfil.TabIndex = 5;
            this.lblPerfil.Text = "Perfil";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Ativo",
            "Inativo"});
            this.comboBox1.Location = new System.Drawing.Point(90, 117);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(148, 24);
            this.comboBox1.TabIndex = 11;
            this.comboBox1.Text = "Ativo";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(11, 184);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(266, 22);
            this.dateTimePicker1.TabIndex = 10;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(349, 222);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(365, 81);
            this.richTextBox1.TabIndex = 9;
            this.richTextBox1.Text = "";
            // 
            // lblObs
            // 
            this.lblObs.AutoSize = true;
            this.lblObs.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObs.Location = new System.Drawing.Point(346, 184);
            this.lblObs.Name = "lblObs";
            this.lblObs.Size = new System.Drawing.Size(118, 19);
            this.lblObs.TabIndex = 6;
            this.lblObs.Text = "Observações:";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.Location = new System.Drawing.Point(86, 153);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(140, 19);
            this.lblData.TabIndex = 4;
            this.lblData.Text = "Data de Criação:";
            this.lblData.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(18, 120);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(60, 19);
            this.lblStatus.TabIndex = 2;
            this.lblStatus.Text = "Status";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rdAluno);
            this.panel1.Controls.Add(this.rdProfessor);
            this.panel1.Controls.Add(this.rdTecnico);
            this.panel1.Controls.Add(this.lblTipo);
            this.panel1.Location = new System.Drawing.Point(349, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(380, 64);
            this.panel1.TabIndex = 12;
            // 
            // rdAluno
            // 
            this.rdAluno.AutoSize = true;
            this.rdAluno.Location = new System.Drawing.Point(298, 18);
            this.rdAluno.Name = "rdAluno";
            this.rdAluno.Size = new System.Drawing.Size(62, 20);
            this.rdAluno.TabIndex = 6;
            this.rdAluno.TabStop = true;
            this.rdAluno.Text = "Aluno";
            this.rdAluno.UseVisualStyleBackColor = true;
            // 
            // rdProfessor
            // 
            this.rdProfessor.AutoSize = true;
            this.rdProfessor.Location = new System.Drawing.Point(186, 18);
            this.rdProfessor.Name = "rdProfessor";
            this.rdProfessor.Size = new System.Drawing.Size(86, 20);
            this.rdProfessor.TabIndex = 5;
            this.rdProfessor.TabStop = true;
            this.rdProfessor.Text = "Professor";
            this.rdProfessor.UseVisualStyleBackColor = true;
            // 
            // rdTecnico
            // 
            this.rdTecnico.AutoSize = true;
            this.rdTecnico.Location = new System.Drawing.Point(83, 18);
            this.rdTecnico.Name = "rdTecnico";
            this.rdTecnico.Size = new System.Drawing.Size(77, 20);
            this.rdTecnico.TabIndex = 4;
            this.rdTecnico.TabStop = true;
            this.rdTecnico.Text = "Técnico";
            this.rdTecnico.UseVisualStyleBackColor = true;
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo.Location = new System.Drawing.Point(14, 18);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(43, 19);
            this.lblTipo.TabIndex = 3;
            this.lblTipo.Text = "Tipo";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtBoxSenha);
            this.panel3.Controls.Add(this.textBox1);
            this.panel3.Controls.Add(this.lblLogin);
            this.panel3.Controls.Add(this.lblSenha);
            this.panel3.Location = new System.Drawing.Point(8, 6);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(272, 96);
            this.panel3.TabIndex = 14;
            // 
            // txtBoxSenha
            // 
            this.txtBoxSenha.Location = new System.Drawing.Point(82, 59);
            this.txtBoxSenha.Name = "txtBoxSenha";
            this.txtBoxSenha.PasswordChar = '*';
            this.txtBoxSenha.Size = new System.Drawing.Size(148, 22);
            this.txtBoxSenha.TabIndex = 8;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(82, 15);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(148, 22);
            this.textBox1.TabIndex = 8;
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.Location = new System.Drawing.Point(12, 17);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(53, 19);
            this.lblLogin.TabIndex = 0;
            this.lblLogin.Text = "Login";
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.Location = new System.Drawing.Point(12, 61);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(58, 19);
            this.lblSenha.TabIndex = 1;
            this.lblSenha.Text = "Senha";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.checkBox4);
            this.panel4.Controls.Add(this.checkBox3);
            this.panel4.Controls.Add(this.checkBox2);
            this.panel4.Controls.Add(this.checkBox1);
            this.panel4.Controls.Add(this.lblModulo);
            this.panel4.Location = new System.Drawing.Point(12, 212);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(272, 118);
            this.panel4.TabIndex = 19;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(152, 95);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(95, 20);
            this.checkBox4.TabIndex = 18;
            this.checkBox4.Text = "checkBox4";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(152, 52);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(95, 20);
            this.checkBox3.TabIndex = 17;
            this.checkBox3.Text = "checkBox3";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(12, 95);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(95, 20);
            this.checkBox2.TabIndex = 16;
            this.checkBox2.Text = "checkBox2";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(12, 52);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(95, 20);
            this.checkBox1.TabIndex = 15;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // lblModulo
            // 
            this.lblModulo.AutoSize = true;
            this.lblModulo.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModulo.Location = new System.Drawing.Point(94, 10);
            this.lblModulo.Name = "lblModulo";
            this.lblModulo.Size = new System.Drawing.Size(75, 19);
            this.lblModulo.TabIndex = 7;
            this.lblModulo.Text = "Módulos";
            this.lblModulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(746, 338);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Tabela";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colunaLogin,
            this.colunaSenha,
            this.colunaStatus,
            this.colunaTipo,
            this.colunaData,
            this.colunaPerfil,
            this.colunaModulos});
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.Location = new System.Drawing.Point(3, 3);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView.Size = new System.Drawing.Size(740, 332);
            this.dataGridView.TabIndex = 0;
            // 
            // colunaLogin
            // 
            this.colunaLogin.HeaderText = "Login";
            this.colunaLogin.MinimumWidth = 6;
            this.colunaLogin.Name = "colunaLogin";
            this.colunaLogin.ReadOnly = true;
            this.colunaLogin.Width = 125;
            // 
            // colunaSenha
            // 
            this.colunaSenha.HeaderText = "Senha";
            this.colunaSenha.MinimumWidth = 6;
            this.colunaSenha.Name = "colunaSenha";
            this.colunaSenha.ReadOnly = true;
            this.colunaSenha.Visible = false;
            this.colunaSenha.Width = 125;
            // 
            // colunaStatus
            // 
            this.colunaStatus.HeaderText = "Status";
            this.colunaStatus.MinimumWidth = 6;
            this.colunaStatus.Name = "colunaStatus";
            this.colunaStatus.ReadOnly = true;
            this.colunaStatus.Width = 125;
            // 
            // colunaTipo
            // 
            this.colunaTipo.HeaderText = "Tipo";
            this.colunaTipo.MinimumWidth = 6;
            this.colunaTipo.Name = "colunaTipo";
            this.colunaTipo.ReadOnly = true;
            this.colunaTipo.Width = 125;
            // 
            // colunaData
            // 
            this.colunaData.HeaderText = "Data de Criação";
            this.colunaData.MinimumWidth = 6;
            this.colunaData.Name = "colunaData";
            this.colunaData.ReadOnly = true;
            this.colunaData.Width = 125;
            // 
            // colunaPerfil
            // 
            this.colunaPerfil.HeaderText = "Perfil";
            this.colunaPerfil.MinimumWidth = 6;
            this.colunaPerfil.Name = "colunaPerfil";
            this.colunaPerfil.ReadOnly = true;
            this.colunaPerfil.Width = 125;
            // 
            // colunaModulos
            // 
            this.colunaModulos.HeaderText = "Módulos Incritos";
            this.colunaModulos.MinimumWidth = 6;
            this.colunaModulos.Name = "colunaModulos";
            this.colunaModulos.ReadOnly = true;
            this.colunaModulos.Width = 125;
            // 
            // JanelaCadastroTabela
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 367);
            this.Controls.Add(this.tabControl);
            this.Name = "JanelaCadastroTabela";
            this.Text = "Sistema de Gestão Acadêmica";
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn colunaLogin;
        private System.Windows.Forms.DataGridViewTextBoxColumn colunaSenha;
        private System.Windows.Forms.DataGridViewTextBoxColumn colunaStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colunaTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colunaData;
        private System.Windows.Forms.DataGridViewTextBoxColumn colunaPerfil;
        private System.Windows.Forms.DataGridViewComboBoxColumn colunaModulos;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox txtBoxSenha;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblModulo;
        private System.Windows.Forms.Label lblObs;
        private System.Windows.Forms.Label lblPerfil;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rdConvidado;
        private System.Windows.Forms.RadioButton rdAdministrador;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rdProfessor;
        private System.Windows.Forms.RadioButton rdTecnico;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton rdAluno;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}