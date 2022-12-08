using System;

namespace FormLoja
{
    partial class JanelaCadastro
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JanelaCadastro));
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtAreaVendedor = new System.Windows.Forms.TextBox();
            this.txtComissaoVendedor = new System.Windows.Forms.TextBox();
            this.txtNomeVendedor = new System.Windows.Forms.TextBox();
            this.btnCadastrarVendedor = new System.Windows.Forms.Button();
            this.lbAreaVendedor = new System.Windows.Forms.Label();
            this.lbComissaoVendedor = new System.Windows.Forms.Label();
            this.lbNomeVendedor = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataTimePicker = new System.Windows.Forms.DateTimePicker();
            this.txtAreaSocio = new System.Windows.Forms.TextBox();
            this.txtNomeSocio = new System.Windows.Forms.TextBox();
            this.btnCadastrarSocio = new System.Windows.Forms.Button();
            this.lbAreaSocio = new System.Windows.Forms.Label();
            this.lbDataNascimentoSocio = new System.Windows.Forms.Label();
            this.lbNomeSocio = new System.Windows.Forms.Label();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.arquivoMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.salvarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvarComoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imprimirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.fecharToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtoMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excluirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.novoToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.abrirToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.salvarToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.imprimirToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.recortarToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.copiarToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.colarToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ajudaToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabelCliente = new System.Windows.Forms.ToolStripLabel();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Location = new System.Drawing.Point(0, 56);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(374, 394);
            this.tabControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtAreaVendedor);
            this.tabPage1.Controls.Add(this.txtComissaoVendedor);
            this.tabPage1.Controls.Add(this.txtNomeVendedor);
            this.tabPage1.Controls.Add(this.btnCadastrarVendedor);
            this.tabPage1.Controls.Add(this.lbAreaVendedor);
            this.tabPage1.Controls.Add(this.lbComissaoVendedor);
            this.tabPage1.Controls.Add(this.lbNomeVendedor);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(366, 365);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Vendedor";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtAreaVendedor
            // 
            this.txtAreaVendedor.Font = new System.Drawing.Font("Lucida Console", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAreaVendedor.Location = new System.Drawing.Point(96, 250);
            this.txtAreaVendedor.Name = "txtAreaVendedor";
            this.txtAreaVendedor.Size = new System.Drawing.Size(182, 24);
            this.txtAreaVendedor.TabIndex = 4;
            this.txtAreaVendedor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtComissaoVendedor
            // 
            this.txtComissaoVendedor.Font = new System.Drawing.Font("Lucida Console", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComissaoVendedor.Location = new System.Drawing.Point(96, 166);
            this.txtComissaoVendedor.Name = "txtComissaoVendedor";
            this.txtComissaoVendedor.Size = new System.Drawing.Size(182, 24);
            this.txtComissaoVendedor.TabIndex = 4;
            this.txtComissaoVendedor.Text = "1000";
            this.txtComissaoVendedor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNomeVendedor
            // 
            this.txtNomeVendedor.Font = new System.Drawing.Font("Lucida Console", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeVendedor.Location = new System.Drawing.Point(96, 82);
            this.txtNomeVendedor.Name = "txtNomeVendedor";
            this.txtNomeVendedor.Size = new System.Drawing.Size(182, 24);
            this.txtNomeVendedor.TabIndex = 4;
            this.txtNomeVendedor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnCadastrarVendedor
            // 
            this.btnCadastrarVendedor.Font = new System.Drawing.Font("Lucida Console", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarVendedor.Location = new System.Drawing.Point(96, 292);
            this.btnCadastrarVendedor.Name = "btnCadastrarVendedor";
            this.btnCadastrarVendedor.Size = new System.Drawing.Size(182, 24);
            this.btnCadastrarVendedor.TabIndex = 3;
            this.btnCadastrarVendedor.Text = "Enviar Cadastro";
            this.btnCadastrarVendedor.UseVisualStyleBackColor = true;
            this.btnCadastrarVendedor.Click += new System.EventHandler(this.btnCadastrarVendedor_Click);
            // 
            // lbAreaVendedor
            // 
            this.lbAreaVendedor.AutoSize = true;
            this.lbAreaVendedor.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAreaVendedor.Location = new System.Drawing.Point(162, 208);
            this.lbAreaVendedor.Name = "lbAreaVendedor";
            this.lbAreaVendedor.Size = new System.Drawing.Size(51, 24);
            this.lbAreaVendedor.TabIndex = 2;
            this.lbAreaVendedor.Text = "Área";
            // 
            // lbComissaoVendedor
            // 
            this.lbComissaoVendedor.AutoSize = true;
            this.lbComissaoVendedor.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbComissaoVendedor.Location = new System.Drawing.Point(139, 124);
            this.lbComissaoVendedor.Name = "lbComissaoVendedor";
            this.lbComissaoVendedor.Size = new System.Drawing.Size(97, 24);
            this.lbComissaoVendedor.TabIndex = 1;
            this.lbComissaoVendedor.Text = "Comissão";
            // 
            // lbNomeVendedor
            // 
            this.lbNomeVendedor.AutoSize = true;
            this.lbNomeVendedor.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNomeVendedor.Location = new System.Drawing.Point(96, 40);
            this.lbNomeVendedor.Name = "lbNomeVendedor";
            this.lbNomeVendedor.Size = new System.Drawing.Size(182, 24);
            this.lbNomeVendedor.TabIndex = 0;
            this.lbNomeVendedor.Text = "Nome do Vendedor";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataTimePicker);
            this.tabPage2.Controls.Add(this.txtAreaSocio);
            this.tabPage2.Controls.Add(this.txtNomeSocio);
            this.tabPage2.Controls.Add(this.btnCadastrarSocio);
            this.tabPage2.Controls.Add(this.lbAreaSocio);
            this.tabPage2.Controls.Add(this.lbDataNascimentoSocio);
            this.tabPage2.Controls.Add(this.lbNomeSocio);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(366, 365);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Sócio";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataTimePicker
            // 
            this.dataTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dataTimePicker.Font = new System.Drawing.Font("Lucida Console", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dataTimePicker.Location = new System.Drawing.Point(92, 169);
            this.dataTimePicker.MaxDate = new System.DateTime(2022, 12, 7, 17, 22, 18, 271);
            this.dataTimePicker.Name = "dataTimePicker";
            this.dataTimePicker.Size = new System.Drawing.Size(190, 24);
            this.dataTimePicker.TabIndex = 12;
            this.dataTimePicker.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // txtAreaSocio
            // 
            this.txtAreaSocio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAreaSocio.Font = new System.Drawing.Font("Lucida Console", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAreaSocio.Location = new System.Drawing.Point(96, 255);
            this.txtAreaSocio.Name = "txtAreaSocio";
            this.txtAreaSocio.Size = new System.Drawing.Size(182, 24);
            this.txtAreaSocio.TabIndex = 9;
            this.txtAreaSocio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNomeSocio
            // 
            this.txtNomeSocio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNomeSocio.Font = new System.Drawing.Font("Lucida Console", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeSocio.Location = new System.Drawing.Point(115, 83);
            this.txtNomeSocio.Name = "txtNomeSocio";
            this.txtNomeSocio.Size = new System.Drawing.Size(144, 24);
            this.txtNomeSocio.TabIndex = 11;
            this.txtNomeSocio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnCadastrarSocio
            // 
            this.btnCadastrarSocio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCadastrarSocio.AutoSize = true;
            this.btnCadastrarSocio.Font = new System.Drawing.Font("Lucida Console", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarSocio.Location = new System.Drawing.Point(96, 298);
            this.btnCadastrarSocio.Name = "btnCadastrarSocio";
            this.btnCadastrarSocio.Size = new System.Drawing.Size(182, 27);
            this.btnCadastrarSocio.TabIndex = 8;
            this.btnCadastrarSocio.Text = "Enviar Cadastro";
            this.btnCadastrarSocio.UseVisualStyleBackColor = true;
            this.btnCadastrarSocio.Click += new System.EventHandler(this.btnCadastrarSocio_Click);
            // 
            // lbAreaSocio
            // 
            this.lbAreaSocio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbAreaSocio.AutoSize = true;
            this.lbAreaSocio.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAreaSocio.Location = new System.Drawing.Point(162, 212);
            this.lbAreaSocio.Name = "lbAreaSocio";
            this.lbAreaSocio.Size = new System.Drawing.Size(51, 24);
            this.lbAreaSocio.TabIndex = 7;
            this.lbAreaSocio.Text = "Área";
            // 
            // lbDataNascimentoSocio
            // 
            this.lbDataNascimentoSocio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbDataNascimentoSocio.AutoSize = true;
            this.lbDataNascimentoSocio.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDataNascimentoSocio.Location = new System.Drawing.Point(92, 126);
            this.lbDataNascimentoSocio.Name = "lbDataNascimentoSocio";
            this.lbDataNascimentoSocio.Size = new System.Drawing.Size(190, 24);
            this.lbDataNascimentoSocio.TabIndex = 6;
            this.lbDataNascimentoSocio.Text = "Data de Nascimento";
            // 
            // lbNomeSocio
            // 
            this.lbNomeSocio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbNomeSocio.AutoSize = true;
            this.lbNomeSocio.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNomeSocio.Location = new System.Drawing.Point(115, 40);
            this.lbNomeSocio.Name = "lbNomeSocio";
            this.lbNomeSocio.Size = new System.Drawing.Size(144, 24);
            this.lbNomeSocio.TabIndex = 5;
            this.lbNomeSocio.Text = "Nome do Sócio";
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoMenu,
            this.produtoMenu});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(374, 28);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "menuStrip";
            // 
            // arquivoMenu
            // 
            this.arquivoMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salvarToolStripMenuItem,
            this.salvarComoToolStripMenuItem,
            this.imprimirToolStripMenuItem,
            this.toolStripMenuItem2,
            this.fecharToolStripMenuItem});
            this.arquivoMenu.Name = "arquivoMenu";
            this.arquivoMenu.Size = new System.Drawing.Size(75, 24);
            this.arquivoMenu.Text = "Arquivo";
            // 
            // salvarToolStripMenuItem
            // 
            this.salvarToolStripMenuItem.Name = "salvarToolStripMenuItem";
            this.salvarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.salvarToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.salvarToolStripMenuItem.Text = "Salvar";
            // 
            // salvarComoToolStripMenuItem
            // 
            this.salvarComoToolStripMenuItem.Name = "salvarComoToolStripMenuItem";
            this.salvarComoToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.salvarComoToolStripMenuItem.Text = "Salvar Como";
            // 
            // imprimirToolStripMenuItem
            // 
            this.imprimirToolStripMenuItem.Name = "imprimirToolStripMenuItem";
            this.imprimirToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.imprimirToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.imprimirToolStripMenuItem.Text = "Imprimir";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(221, 6);
            // 
            // fecharToolStripMenuItem
            // 
            this.fecharToolStripMenuItem.Name = "fecharToolStripMenuItem";
            this.fecharToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F4)));
            this.fecharToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.fecharToolStripMenuItem.Text = "Fechar";
            // 
            // produtoMenu
            // 
            this.produtoMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarToolStripMenuItem,
            this.excluirToolStripMenuItem});
            this.produtoMenu.Name = "produtoMenu";
            this.produtoMenu.Size = new System.Drawing.Size(76, 24);
            this.produtoMenu.Text = "Produto";
            // 
            // cadastrarToolStripMenuItem
            // 
            this.cadastrarToolStripMenuItem.Name = "cadastrarToolStripMenuItem";
            this.cadastrarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.C)));
            this.cadastrarToolStripMenuItem.Size = new System.Drawing.Size(246, 26);
            this.cadastrarToolStripMenuItem.Text = "Cadastrar";
            this.cadastrarToolStripMenuItem.Click += new System.EventHandler(this.cadastrarToolStripMenuItem_Click);
            // 
            // excluirToolStripMenuItem
            // 
            this.excluirToolStripMenuItem.Name = "excluirToolStripMenuItem";
            this.excluirToolStripMenuItem.Size = new System.Drawing.Size(246, 26);
            this.excluirToolStripMenuItem.Text = "Excluir";
            // 
            // toolStrip
            // 
            this.toolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoToolStripButton,
            this.abrirToolStripButton,
            this.salvarToolStripButton,
            this.imprimirToolStripButton,
            this.toolStripSeparator,
            this.recortarToolStripButton,
            this.copiarToolStripButton,
            this.colarToolStripButton,
            this.toolStripSeparator1,
            this.ajudaToolStripButton,
            this.toolStripLabelCliente});
            this.toolStrip.Location = new System.Drawing.Point(0, 28);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(374, 27);
            this.toolStrip.TabIndex = 2;
            this.toolStrip.Text = "toolStrip";
            // 
            // novoToolStripButton
            // 
            this.novoToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.novoToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("novoToolStripButton.Image")));
            this.novoToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.novoToolStripButton.Name = "novoToolStripButton";
            this.novoToolStripButton.Size = new System.Drawing.Size(29, 24);
            this.novoToolStripButton.Text = "&Novo";
            // 
            // abrirToolStripButton
            // 
            this.abrirToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.abrirToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("abrirToolStripButton.Image")));
            this.abrirToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.abrirToolStripButton.Name = "abrirToolStripButton";
            this.abrirToolStripButton.Size = new System.Drawing.Size(29, 24);
            this.abrirToolStripButton.Text = "&Abrir";
            // 
            // salvarToolStripButton
            // 
            this.salvarToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.salvarToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("salvarToolStripButton.Image")));
            this.salvarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.salvarToolStripButton.Name = "salvarToolStripButton";
            this.salvarToolStripButton.Size = new System.Drawing.Size(29, 24);
            this.salvarToolStripButton.Text = "&Salvar";
            // 
            // imprimirToolStripButton
            // 
            this.imprimirToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.imprimirToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("imprimirToolStripButton.Image")));
            this.imprimirToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.imprimirToolStripButton.Name = "imprimirToolStripButton";
            this.imprimirToolStripButton.Size = new System.Drawing.Size(29, 24);
            this.imprimirToolStripButton.Text = "&Imprimir";
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // recortarToolStripButton
            // 
            this.recortarToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.recortarToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("recortarToolStripButton.Image")));
            this.recortarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.recortarToolStripButton.Name = "recortarToolStripButton";
            this.recortarToolStripButton.Size = new System.Drawing.Size(29, 24);
            this.recortarToolStripButton.Text = "Recor&tar";
            // 
            // copiarToolStripButton
            // 
            this.copiarToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.copiarToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("copiarToolStripButton.Image")));
            this.copiarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copiarToolStripButton.Name = "copiarToolStripButton";
            this.copiarToolStripButton.Size = new System.Drawing.Size(29, 24);
            this.copiarToolStripButton.Text = "&Copiar";
            // 
            // colarToolStripButton
            // 
            this.colarToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.colarToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("colarToolStripButton.Image")));
            this.colarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.colarToolStripButton.Name = "colarToolStripButton";
            this.colarToolStripButton.Size = new System.Drawing.Size(29, 24);
            this.colarToolStripButton.Text = "C&olar";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // ajudaToolStripButton
            // 
            this.ajudaToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ajudaToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("ajudaToolStripButton.Image")));
            this.ajudaToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ajudaToolStripButton.Name = "ajudaToolStripButton";
            this.ajudaToolStripButton.Size = new System.Drawing.Size(29, 24);
            this.ajudaToolStripButton.Text = "&Ajuda";
            // 
            // toolStripLabelCliente
            // 
            this.toolStripLabelCliente.Name = "toolStripLabelCliente";
            this.toolStripLabelCliente.Size = new System.Drawing.Size(55, 24);
            this.toolStripLabelCliente.Text = "Cliente";
            this.toolStripLabelCliente.Click += new System.EventHandler(this.toolStripLabelCliente_Click);
            // 
            // JanelaCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 450);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "JanelaCadastro";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Main Menu";
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem arquivoMenu;
        private System.Windows.Forms.ToolStripMenuItem produtoMenu;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton novoToolStripButton;
        private System.Windows.Forms.ToolStripButton abrirToolStripButton;
        private System.Windows.Forms.ToolStripButton salvarToolStripButton;
        private System.Windows.Forms.ToolStripButton imprimirToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripButton recortarToolStripButton;
        private System.Windows.Forms.ToolStripButton copiarToolStripButton;
        private System.Windows.Forms.ToolStripButton colarToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton ajudaToolStripButton;
        private System.Windows.Forms.Label lbAreaVendedor;
        private System.Windows.Forms.Label lbComissaoVendedor;
        private System.Windows.Forms.Label lbNomeVendedor;
        private System.Windows.Forms.TextBox txtAreaVendedor;
        private System.Windows.Forms.TextBox txtComissaoVendedor;
        private System.Windows.Forms.TextBox txtNomeVendedor;
        private System.Windows.Forms.Button btnCadastrarVendedor;
        private System.Windows.Forms.DateTimePicker dataTimePicker;
        private System.Windows.Forms.TextBox txtAreaSocio;
        private System.Windows.Forms.TextBox txtNomeSocio;
        private System.Windows.Forms.Button btnCadastrarSocio;
        private System.Windows.Forms.Label lbAreaSocio;
        private System.Windows.Forms.Label lbDataNascimentoSocio;
        private System.Windows.Forms.Label lbNomeSocio;
        private System.Windows.Forms.ToolStripMenuItem salvarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvarComoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imprimirToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem fecharToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem excluirToolStripMenuItem;
        private System.Windows.Forms.ToolStripLabel toolStripLabelCliente;
    }
}

