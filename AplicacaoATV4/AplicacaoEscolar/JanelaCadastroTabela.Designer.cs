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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageNovoCadastro = new System.Windows.Forms.TabPage();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.lblPerfil = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.panelPerfil = new System.Windows.Forms.Panel();
            this.rdConvidado = new System.Windows.Forms.RadioButton();
            this.rdAdministrador = new System.Windows.Forms.RadioButton();
            this.cBoxStatus = new System.Windows.Forms.ComboBox();
            this.lblModulo = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.richTxtObs = new System.Windows.Forms.RichTextBox();
            this.lblObs = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.panelTipo = new System.Windows.Forms.Panel();
            this.rdAluno = new System.Windows.Forms.RadioButton();
            this.rdProfessor = new System.Windows.Forms.RadioButton();
            this.rdTecnico = new System.Windows.Forms.RadioButton();
            this.panelLogin = new System.Windows.Forms.Panel();
            this.txtBoxSenha = new System.Windows.Forms.TextBox();
            this.txtBoxLogin = new System.Windows.Forms.TextBox();
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.panelModulos = new System.Windows.Forms.Panel();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkFisica = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkQuimica = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkMatematica = new System.Windows.Forms.CheckBox();
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
            this.tabPageNovoCadastro.SuspendLayout();
            this.panelPerfil.SuspendLayout();
            this.panelTipo.SuspendLayout();
            this.panelLogin.SuspendLayout();
            this.panelModulos.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageNovoCadastro);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(754, 445);
            this.tabControl.TabIndex = 0;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // tabPageNovoCadastro
            // 
            this.tabPageNovoCadastro.Controls.Add(this.btnLimpar);
            this.tabPageNovoCadastro.Controls.Add(this.btnCadastrar);
            this.tabPageNovoCadastro.Controls.Add(this.lblPerfil);
            this.tabPageNovoCadastro.Controls.Add(this.lblTipo);
            this.tabPageNovoCadastro.Controls.Add(this.panelPerfil);
            this.tabPageNovoCadastro.Controls.Add(this.cBoxStatus);
            this.tabPageNovoCadastro.Controls.Add(this.lblModulo);
            this.tabPageNovoCadastro.Controls.Add(this.dateTimePicker);
            this.tabPageNovoCadastro.Controls.Add(this.richTxtObs);
            this.tabPageNovoCadastro.Controls.Add(this.lblObs);
            this.tabPageNovoCadastro.Controls.Add(this.lblData);
            this.tabPageNovoCadastro.Controls.Add(this.lblStatus);
            this.tabPageNovoCadastro.Controls.Add(this.panelTipo);
            this.tabPageNovoCadastro.Controls.Add(this.panelLogin);
            this.tabPageNovoCadastro.Controls.Add(this.panelModulos);
            this.tabPageNovoCadastro.Location = new System.Drawing.Point(4, 25);
            this.tabPageNovoCadastro.Name = "tabPageNovoCadastro";
            this.tabPageNovoCadastro.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageNovoCadastro.Size = new System.Drawing.Size(746, 416);
            this.tabPageNovoCadastro.TabIndex = 0;
            this.tabPageNovoCadastro.Text = "Novo Cadastro";
            this.tabPageNovoCadastro.UseVisualStyleBackColor = true;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLimpar.Location = new System.Drawing.Point(3, 333);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(740, 40);
            this.btnLimpar.TabIndex = 21;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnCadastrar.Location = new System.Drawing.Point(3, 373);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(740, 40);
            this.btnCadastrar.TabIndex = 20;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // lblPerfil
            // 
            this.lblPerfil.AutoSize = true;
            this.lblPerfil.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPerfil.Location = new System.Drawing.Point(315, 132);
            this.lblPerfil.Name = "lblPerfil";
            this.lblPerfil.Size = new System.Drawing.Size(49, 19);
            this.lblPerfil.TabIndex = 5;
            this.lblPerfil.Text = "Perfil";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo.Location = new System.Drawing.Point(318, 53);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(43, 19);
            this.lblTipo.TabIndex = 3;
            this.lblTipo.Text = "Tipo";
            // 
            // panelPerfil
            // 
            this.panelPerfil.Controls.Add(this.rdConvidado);
            this.panelPerfil.Controls.Add(this.rdAdministrador);
            this.panelPerfil.Location = new System.Drawing.Point(391, 108);
            this.panelPerfil.Name = "panelPerfil";
            this.panelPerfil.Size = new System.Drawing.Size(238, 64);
            this.panelPerfil.TabIndex = 13;
            // 
            // rdConvidado
            // 
            this.rdConvidado.AutoSize = true;
            this.rdConvidado.Location = new System.Drawing.Point(141, 19);
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
            this.rdAdministrador.Location = new System.Drawing.Point(11, 19);
            this.rdAdministrador.Name = "rdAdministrador";
            this.rdAdministrador.Size = new System.Drawing.Size(111, 20);
            this.rdAdministrador.TabIndex = 6;
            this.rdAdministrador.TabStop = true;
            this.rdAdministrador.Text = "Administrador";
            this.rdAdministrador.UseVisualStyleBackColor = true;
            // 
            // cBoxStatus
            // 
            this.cBoxStatus.FormattingEnabled = true;
            this.cBoxStatus.Items.AddRange(new object[] {
            "Ativo",
            "Inativo"});
            this.cBoxStatus.Location = new System.Drawing.Point(90, 117);
            this.cBoxStatus.Name = "cBoxStatus";
            this.cBoxStatus.Size = new System.Drawing.Size(148, 24);
            this.cBoxStatus.TabIndex = 11;
            this.cBoxStatus.Text = "Ativo";
            // 
            // lblModulo
            // 
            this.lblModulo.AutoSize = true;
            this.lblModulo.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModulo.Location = new System.Drawing.Point(302, 223);
            this.lblModulo.Name = "lblModulo";
            this.lblModulo.Size = new System.Drawing.Size(75, 19);
            this.lblModulo.TabIndex = 7;
            this.lblModulo.Text = "Módulos";
            this.lblModulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(11, 184);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(266, 22);
            this.dateTimePicker.TabIndex = 10;
            // 
            // richTxtObs
            // 
            this.richTxtObs.Location = new System.Drawing.Point(22, 243);
            this.richTxtObs.Name = "richTxtObs";
            this.richTxtObs.Size = new System.Drawing.Size(258, 80);
            this.richTxtObs.TabIndex = 9;
            this.richTxtObs.Text = "";
            // 
            // lblObs
            // 
            this.lblObs.AutoSize = true;
            this.lblObs.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObs.Location = new System.Drawing.Point(86, 221);
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
            // panelTipo
            // 
            this.panelTipo.Controls.Add(this.rdAluno);
            this.panelTipo.Controls.Add(this.rdProfessor);
            this.panelTipo.Controls.Add(this.rdTecnico);
            this.panelTipo.Location = new System.Drawing.Point(391, 38);
            this.panelTipo.Name = "panelTipo";
            this.panelTipo.Size = new System.Drawing.Size(282, 64);
            this.panelTipo.TabIndex = 12;
            // 
            // rdAluno
            // 
            this.rdAluno.AutoSize = true;
            this.rdAluno.Location = new System.Drawing.Point(196, 18);
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
            this.rdProfessor.Location = new System.Drawing.Point(92, 18);
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
            this.rdTecnico.Location = new System.Drawing.Point(9, 18);
            this.rdTecnico.Name = "rdTecnico";
            this.rdTecnico.Size = new System.Drawing.Size(77, 20);
            this.rdTecnico.TabIndex = 4;
            this.rdTecnico.TabStop = true;
            this.rdTecnico.Text = "Técnico";
            this.rdTecnico.UseVisualStyleBackColor = true;
            // 
            // panelLogin
            // 
            this.panelLogin.Controls.Add(this.txtBoxSenha);
            this.panelLogin.Controls.Add(this.txtBoxLogin);
            this.panelLogin.Controls.Add(this.lblLogin);
            this.panelLogin.Controls.Add(this.lblSenha);
            this.panelLogin.Location = new System.Drawing.Point(8, 6);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(272, 96);
            this.panelLogin.TabIndex = 14;
            // 
            // txtBoxSenha
            // 
            this.txtBoxSenha.Location = new System.Drawing.Point(82, 59);
            this.txtBoxSenha.Name = "txtBoxSenha";
            this.txtBoxSenha.PasswordChar = '*';
            this.txtBoxSenha.Size = new System.Drawing.Size(148, 22);
            this.txtBoxSenha.TabIndex = 8;
            // 
            // txtBoxLogin
            // 
            this.txtBoxLogin.Location = new System.Drawing.Point(82, 15);
            this.txtBoxLogin.Name = "txtBoxLogin";
            this.txtBoxLogin.Size = new System.Drawing.Size(148, 22);
            this.txtBoxLogin.TabIndex = 8;
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
            // panelModulos
            // 
            this.panelModulos.Controls.Add(this.checkBox6);
            this.panelModulos.Controls.Add(this.checkFisica);
            this.panelModulos.Controls.Add(this.checkBox5);
            this.panelModulos.Controls.Add(this.checkQuimica);
            this.panelModulos.Controls.Add(this.checkBox4);
            this.panelModulos.Controls.Add(this.checkMatematica);
            this.panelModulos.Location = new System.Drawing.Point(391, 188);
            this.panelModulos.Name = "panelModulos";
            this.panelModulos.Size = new System.Drawing.Size(338, 107);
            this.panelModulos.TabIndex = 19;
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point(119, 51);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(131, 20);
            this.checkBox6.TabIndex = 17;
            this.checkBox6.Text = "Banco de Dados";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkFisica
            // 
            this.checkFisica.AutoSize = true;
            this.checkFisica.Location = new System.Drawing.Point(119, 25);
            this.checkFisica.Name = "checkFisica";
            this.checkFisica.Size = new System.Drawing.Size(65, 20);
            this.checkFisica.TabIndex = 17;
            this.checkFisica.Text = "Física";
            this.checkFisica.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(14, 77);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(70, 20);
            this.checkBox5.TabIndex = 16;
            this.checkBox5.Text = "Redes";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkQuimica
            // 
            this.checkQuimica.AutoSize = true;
            this.checkQuimica.Location = new System.Drawing.Point(14, 51);
            this.checkQuimica.Name = "checkQuimica";
            this.checkQuimica.Size = new System.Drawing.Size(78, 20);
            this.checkQuimica.TabIndex = 16;
            this.checkQuimica.Text = "Química";
            this.checkQuimica.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(119, 77);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(201, 20);
            this.checkBox4.TabIndex = 15;
            this.checkBox4.Text = "Linguagem de Programação";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkMatematica
            // 
            this.checkMatematica.AutoSize = true;
            this.checkMatematica.Location = new System.Drawing.Point(14, 25);
            this.checkMatematica.Name = "checkMatematica";
            this.checkMatematica.Size = new System.Drawing.Size(99, 20);
            this.checkMatematica.TabIndex = 15;
            this.checkMatematica.Text = "Matemática";
            this.checkMatematica.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(746, 416);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Tabela";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
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
            this.dataGridView.Size = new System.Drawing.Size(740, 410);
            this.dataGridView.TabIndex = 0;
            // 
            // colunaLogin
            // 
            this.colunaLogin.HeaderText = "Login";
            this.colunaLogin.MinimumWidth = 6;
            this.colunaLogin.Name = "colunaLogin";
            this.colunaLogin.ReadOnly = true;
            // 
            // colunaSenha
            // 
            this.colunaSenha.HeaderText = "Senha";
            this.colunaSenha.MinimumWidth = 6;
            this.colunaSenha.Name = "colunaSenha";
            this.colunaSenha.ReadOnly = true;
            this.colunaSenha.Visible = false;
            // 
            // colunaStatus
            // 
            this.colunaStatus.HeaderText = "Status";
            this.colunaStatus.MinimumWidth = 6;
            this.colunaStatus.Name = "colunaStatus";
            this.colunaStatus.ReadOnly = true;
            // 
            // colunaTipo
            // 
            this.colunaTipo.HeaderText = "Tipo";
            this.colunaTipo.MinimumWidth = 6;
            this.colunaTipo.Name = "colunaTipo";
            this.colunaTipo.ReadOnly = true;
            // 
            // colunaData
            // 
            this.colunaData.HeaderText = "Data de Criação";
            this.colunaData.MinimumWidth = 6;
            this.colunaData.Name = "colunaData";
            this.colunaData.ReadOnly = true;
            // 
            // colunaPerfil
            // 
            this.colunaPerfil.HeaderText = "Perfil";
            this.colunaPerfil.MinimumWidth = 6;
            this.colunaPerfil.Name = "colunaPerfil";
            this.colunaPerfil.ReadOnly = true;
            // 
            // colunaModulos
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Black;
            this.colunaModulos.DefaultCellStyle = dataGridViewCellStyle1;
            this.colunaModulos.HeaderText = "Módulos Incritos";
            this.colunaModulos.MinimumWidth = 6;
            this.colunaModulos.Name = "colunaModulos";
            this.colunaModulos.ReadOnly = true;
            // 
            // JanelaCadastroTabela
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 445);
            this.Controls.Add(this.tabControl);
            this.Name = "JanelaCadastroTabela";
            this.Text = "Sistema de Gestão Acadêmica";
            this.tabControl.ResumeLayout(false);
            this.tabPageNovoCadastro.ResumeLayout(false);
            this.tabPageNovoCadastro.PerformLayout();
            this.panelPerfil.ResumeLayout(false);
            this.panelPerfil.PerformLayout();
            this.panelTipo.ResumeLayout(false);
            this.panelTipo.PerformLayout();
            this.panelLogin.ResumeLayout(false);
            this.panelLogin.PerformLayout();
            this.panelModulos.ResumeLayout(false);
            this.panelModulos.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageNovoCadastro;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.RichTextBox richTxtObs;
        private System.Windows.Forms.TextBox txtBoxSenha;
        private System.Windows.Forms.TextBox txtBoxLogin;
        private System.Windows.Forms.Label lblModulo;
        private System.Windows.Forms.Label lblObs;
        private System.Windows.Forms.Label lblPerfil;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.ComboBox cBoxStatus;
        private System.Windows.Forms.Panel panelPerfil;
        private System.Windows.Forms.RadioButton rdConvidado;
        private System.Windows.Forms.RadioButton rdAdministrador;
        private System.Windows.Forms.Panel panelTipo;
        private System.Windows.Forms.RadioButton rdProfessor;
        private System.Windows.Forms.RadioButton rdTecnico;
        private System.Windows.Forms.Panel panelLogin;
        private System.Windows.Forms.RadioButton rdAluno;
        private System.Windows.Forms.Panel panelModulos;
        private System.Windows.Forms.CheckBox checkFisica;
        private System.Windows.Forms.CheckBox checkQuimica;
        private System.Windows.Forms.CheckBox checkMatematica;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.DataGridViewTextBoxColumn colunaLogin;
        private System.Windows.Forms.DataGridViewTextBoxColumn colunaSenha;
        private System.Windows.Forms.DataGridViewTextBoxColumn colunaStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colunaTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colunaData;
        private System.Windows.Forms.DataGridViewTextBoxColumn colunaPerfil;
        private System.Windows.Forms.DataGridViewComboBoxColumn colunaModulos;
    }
}