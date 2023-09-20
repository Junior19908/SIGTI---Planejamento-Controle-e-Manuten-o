namespace SIGT___PCM.Cadastros
{
    partial class CadFuncionario
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadFuncionario));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Funcionário = new System.Windows.Forms.TabPage();
            this.btnVoltarMenu = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.rdDesativadoFuncionario = new System.Windows.Forms.RadioButton();
            this.rdAtivoFuncionario = new System.Windows.Forms.RadioButton();
            this.btnArquivo = new System.Windows.Forms.Button();
            this.txtCaminhoArquivoFuncionario = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtDisponibilidadeFuncionario = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rdAtividadeProducao = new System.Windows.Forms.RadioButton();
            this.rdAtividadeManutencao = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rdCategoriaHoristaFuncionario = new System.Windows.Forms.RadioButton();
            this.rdCategoriaMensalistaFuncionario = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdVincuExternoFuncionario = new System.Windows.Forms.RadioButton();
            this.rdVinculoInternoFuncionario = new System.Windows.Forms.RadioButton();
            this.dtDemissaoFuncionario = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtAdminissaoFuncionario = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txtQuantidadeFuncionario = new System.Windows.Forms.TextBox();
            this.txtDescricaoCodigoFuncionario = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCodigoFuncaoFuncionario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMatriculaFuncionario = new System.Windows.Forms.TextBox();
            this.txtNomeCompletoFuncionario = new System.Windows.Forms.TextBox();
            this.DadosComplementares = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JornadaSemanal = new System.Windows.Forms.TabPage();
            this.dataGridViewSemanaFuncionario = new System.Windows.Forms.DataGridView();
            this.Dom = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.SegFun = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.TerFun = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.QuaFun = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.QuiFun = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.SexFun = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.SabFun = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.metroStyleManagerCadastroFuncionario = new MetroFramework.Components.MetroStyleManager(this.components);
            this.tabControl1.SuspendLayout();
            this.Funcionário.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.DadosComplementares.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.JornadaSemanal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSemanaFuncionario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManagerCadastroFuncionario)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Funcionário);
            this.tabControl1.Controls.Add(this.DadosComplementares);
            this.tabControl1.Controls.Add(this.JornadaSemanal);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(20, 60);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(435, 370);
            this.tabControl1.TabIndex = 0;
            // 
            // Funcionário
            // 
            this.Funcionário.Controls.Add(this.btnVoltarMenu);
            this.Funcionário.Controls.Add(this.btnGravar);
            this.Funcionário.Controls.Add(this.groupBox1);
            this.Funcionário.Location = new System.Drawing.Point(4, 22);
            this.Funcionário.Name = "Funcionário";
            this.Funcionário.Padding = new System.Windows.Forms.Padding(3);
            this.Funcionário.Size = new System.Drawing.Size(427, 344);
            this.Funcionário.TabIndex = 0;
            this.Funcionário.Text = "Funcionário";
            this.Funcionário.UseVisualStyleBackColor = true;
            // 
            // btnVoltarMenu
            // 
            this.btnVoltarMenu.Location = new System.Drawing.Point(15, 313);
            this.btnVoltarMenu.Name = "btnVoltarMenu";
            this.btnVoltarMenu.Size = new System.Drawing.Size(75, 23);
            this.btnVoltarMenu.TabIndex = 6;
            this.btnVoltarMenu.Text = "&Voltar";
            this.btnVoltarMenu.UseVisualStyleBackColor = true;
            this.btnVoltarMenu.Click += new System.EventHandler(this.btnVoltarMenu_Click);
            // 
            // btnGravar
            // 
            this.btnGravar.Location = new System.Drawing.Point(333, 313);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(75, 23);
            this.btnGravar.TabIndex = 5;
            this.btnGravar.Text = "&Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.groupBox6);
            this.groupBox1.Controls.Add(this.btnArquivo);
            this.groupBox1.Controls.Add(this.txtCaminhoArquivoFuncionario);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.dtDemissaoFuncionario);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.dtAdminissaoFuncionario);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtQuantidadeFuncionario);
            this.groupBox1.Controls.Add(this.txtDescricaoCodigoFuncionario);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtCodigoFuncaoFuncionario);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtMatriculaFuncionario);
            this.groupBox1.Controls.Add(this.txtNomeCompletoFuncionario);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(401, 291);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(185, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Desc. Função:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "AJ SERRALHEIRO",
            "AJ SOLDADOR",
            "AJ. SERRALHEIRO",
            "AJ.CALDEIREIRO",
            "AJ.ELETRISTA",
            "AJ.SOLDADOR",
            "AJ.TORNEIRO",
            "CALDEIREIRO",
            "CASA DE FORÇA",
            "ELETRICISTA",
            "ENC TURBINA AÇUCAR",
            "ENC. MOENDA",
            "ENC. TURBINA VAPOR",
            "ENCARREGADO CALDEIRARIA",
            "ENCARREGADO INSTRUMENTAÇÃO",
            "ENCARREGADO LUBRIFICAÇÃO",
            "ENCARREGADO OFICINA",
            "INSTRUMENTISTA",
            "OP. PONTE ROLANTE",
            "OP.QUADRO",
            "OP.QUADRO (CASA FORÇA1)",
            "OP.TURBO GERADOR",
            "SERRALHEIRO",
            "SERRALHEIRO (MOTOR)",
            "SERVENTE",
            "SOLDADOR",
            "TORNEIRO"});
            this.comboBox1.Location = new System.Drawing.Point(268, 13);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 20;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.rdDesativadoFuncionario);
            this.groupBox6.Controls.Add(this.rdAtivoFuncionario);
            this.groupBox6.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold);
            this.groupBox6.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox6.Location = new System.Drawing.Point(202, 143);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(187, 46);
            this.groupBox6.TabIndex = 17;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Status Funcionário";
            // 
            // rdDesativadoFuncionario
            // 
            this.rdDesativadoFuncionario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rdDesativadoFuncionario.AutoSize = true;
            this.rdDesativadoFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.rdDesativadoFuncionario.ForeColor = System.Drawing.SystemColors.Desktop;
            this.rdDesativadoFuncionario.Location = new System.Drawing.Point(106, 20);
            this.rdDesativadoFuncionario.Name = "rdDesativadoFuncionario";
            this.rdDesativadoFuncionario.Size = new System.Drawing.Size(79, 17);
            this.rdDesativadoFuncionario.TabIndex = 5;
            this.rdDesativadoFuncionario.Text = "Desativado";
            this.rdDesativadoFuncionario.UseVisualStyleBackColor = true;
            // 
            // rdAtivoFuncionario
            // 
            this.rdAtivoFuncionario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rdAtivoFuncionario.AutoSize = true;
            this.rdAtivoFuncionario.Checked = true;
            this.rdAtivoFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.rdAtivoFuncionario.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rdAtivoFuncionario.Location = new System.Drawing.Point(19, 20);
            this.rdAtivoFuncionario.Name = "rdAtivoFuncionario";
            this.rdAtivoFuncionario.Size = new System.Drawing.Size(49, 17);
            this.rdAtivoFuncionario.TabIndex = 4;
            this.rdAtivoFuncionario.TabStop = true;
            this.rdAtivoFuncionario.Text = "Ativo";
            this.rdAtivoFuncionario.UseVisualStyleBackColor = true;
            // 
            // btnArquivo
            // 
            this.btnArquivo.Location = new System.Drawing.Point(312, 91);
            this.btnArquivo.Name = "btnArquivo";
            this.btnArquivo.Size = new System.Drawing.Size(75, 23);
            this.btnArquivo.TabIndex = 19;
            this.btnArquivo.Text = "&Arquivo";
            this.btnArquivo.UseVisualStyleBackColor = true;
            // 
            // txtCaminhoArquivoFuncionario
            // 
            this.txtCaminhoArquivoFuncionario.Location = new System.Drawing.Point(202, 117);
            this.txtCaminhoArquivoFuncionario.Name = "txtCaminhoArquivoFuncionario";
            this.txtCaminhoArquivoFuncionario.Size = new System.Drawing.Size(187, 20);
            this.txtCaminhoArquivoFuncionario.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(202, 101);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Anexar documentos:";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtDisponibilidadeFuncionario);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold);
            this.groupBox5.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox5.Location = new System.Drawing.Point(202, 239);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(187, 46);
            this.groupBox5.TabIndex = 16;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Disponibilidade";
            // 
            // txtDisponibilidadeFuncionario
            // 
            this.txtDisponibilidadeFuncionario.Location = new System.Drawing.Point(44, 17);
            this.txtDisponibilidadeFuncionario.Name = "txtDisponibilidadeFuncionario";
            this.txtDisponibilidadeFuncionario.Size = new System.Drawing.Size(94, 21);
            this.txtDisponibilidadeFuncionario.TabIndex = 17;
            this.txtDisponibilidadeFuncionario.Text = "100 %";
            this.txtDisponibilidadeFuncionario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rdAtividadeProducao);
            this.groupBox4.Controls.Add(this.rdAtividadeManutencao);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold);
            this.groupBox4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox4.Location = new System.Drawing.Point(9, 239);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(187, 46);
            this.groupBox4.TabIndex = 16;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Atividade Principal";
            // 
            // rdAtividadeProducao
            // 
            this.rdAtividadeProducao.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rdAtividadeProducao.AutoSize = true;
            this.rdAtividadeProducao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.rdAtividadeProducao.ForeColor = System.Drawing.SystemColors.Desktop;
            this.rdAtividadeProducao.Location = new System.Drawing.Point(111, 20);
            this.rdAtividadeProducao.Name = "rdAtividadeProducao";
            this.rdAtividadeProducao.Size = new System.Drawing.Size(71, 17);
            this.rdAtividadeProducao.TabIndex = 5;
            this.rdAtividadeProducao.TabStop = true;
            this.rdAtividadeProducao.Text = "Produção";
            this.rdAtividadeProducao.UseVisualStyleBackColor = true;
            // 
            // rdAtividadeManutencao
            // 
            this.rdAtividadeManutencao.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rdAtividadeManutencao.AutoSize = true;
            this.rdAtividadeManutencao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.rdAtividadeManutencao.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rdAtividadeManutencao.Location = new System.Drawing.Point(6, 20);
            this.rdAtividadeManutencao.Name = "rdAtividadeManutencao";
            this.rdAtividadeManutencao.Size = new System.Drawing.Size(85, 17);
            this.rdAtividadeManutencao.TabIndex = 4;
            this.rdAtividadeManutencao.TabStop = true;
            this.rdAtividadeManutencao.Text = "Manutenção";
            this.rdAtividadeManutencao.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rdCategoriaHoristaFuncionario);
            this.groupBox3.Controls.Add(this.rdCategoriaMensalistaFuncionario);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox3.Location = new System.Drawing.Point(202, 187);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(187, 46);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Categoria";
            // 
            // rdCategoriaHoristaFuncionario
            // 
            this.rdCategoriaHoristaFuncionario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rdCategoriaHoristaFuncionario.AutoSize = true;
            this.rdCategoriaHoristaFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.rdCategoriaHoristaFuncionario.ForeColor = System.Drawing.SystemColors.Desktop;
            this.rdCategoriaHoristaFuncionario.Location = new System.Drawing.Point(106, 18);
            this.rdCategoriaHoristaFuncionario.Name = "rdCategoriaHoristaFuncionario";
            this.rdCategoriaHoristaFuncionario.Size = new System.Drawing.Size(58, 17);
            this.rdCategoriaHoristaFuncionario.TabIndex = 3;
            this.rdCategoriaHoristaFuncionario.TabStop = true;
            this.rdCategoriaHoristaFuncionario.Text = "Horista";
            this.rdCategoriaHoristaFuncionario.UseVisualStyleBackColor = true;
            // 
            // rdCategoriaMensalistaFuncionario
            // 
            this.rdCategoriaMensalistaFuncionario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rdCategoriaMensalistaFuncionario.AutoSize = true;
            this.rdCategoriaMensalistaFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.rdCategoriaMensalistaFuncionario.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rdCategoriaMensalistaFuncionario.Location = new System.Drawing.Point(19, 18);
            this.rdCategoriaMensalistaFuncionario.Name = "rdCategoriaMensalistaFuncionario";
            this.rdCategoriaMensalistaFuncionario.Size = new System.Drawing.Size(75, 17);
            this.rdCategoriaMensalistaFuncionario.TabIndex = 2;
            this.rdCategoriaMensalistaFuncionario.TabStop = true;
            this.rdCategoriaMensalistaFuncionario.Text = "Mensalista";
            this.rdCategoriaMensalistaFuncionario.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdVincuExternoFuncionario);
            this.groupBox2.Controls.Add(this.rdVinculoInternoFuncionario);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox2.Location = new System.Drawing.Point(9, 187);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(187, 46);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Vínculo Empregatício";
            // 
            // rdVincuExternoFuncionario
            // 
            this.rdVincuExternoFuncionario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rdVincuExternoFuncionario.AutoSize = true;
            this.rdVincuExternoFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.rdVincuExternoFuncionario.ForeColor = System.Drawing.SystemColors.Desktop;
            this.rdVincuExternoFuncionario.Location = new System.Drawing.Point(111, 18);
            this.rdVincuExternoFuncionario.Name = "rdVincuExternoFuncionario";
            this.rdVincuExternoFuncionario.Size = new System.Drawing.Size(61, 17);
            this.rdVincuExternoFuncionario.TabIndex = 1;
            this.rdVincuExternoFuncionario.TabStop = true;
            this.rdVincuExternoFuncionario.Text = "Externo";
            this.rdVincuExternoFuncionario.UseVisualStyleBackColor = true;
            // 
            // rdVinculoInternoFuncionario
            // 
            this.rdVinculoInternoFuncionario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rdVinculoInternoFuncionario.AutoSize = true;
            this.rdVinculoInternoFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.rdVinculoInternoFuncionario.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rdVinculoInternoFuncionario.Location = new System.Drawing.Point(6, 18);
            this.rdVinculoInternoFuncionario.Name = "rdVinculoInternoFuncionario";
            this.rdVinculoInternoFuncionario.Size = new System.Drawing.Size(58, 17);
            this.rdVinculoInternoFuncionario.TabIndex = 0;
            this.rdVinculoInternoFuncionario.TabStop = true;
            this.rdVinculoInternoFuncionario.Text = "Interno";
            this.rdVinculoInternoFuncionario.UseVisualStyleBackColor = true;
            // 
            // dtDemissaoFuncionario
            // 
            this.dtDemissaoFuncionario.CustomFormat = "dd/MM/yyyy";
            this.dtDemissaoFuncionario.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtDemissaoFuncionario.Location = new System.Drawing.Point(96, 146);
            this.dtDemissaoFuncionario.Name = "dtDemissaoFuncionario";
            this.dtDemissaoFuncionario.Size = new System.Drawing.Size(100, 20);
            this.dtDemissaoFuncionario.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Demissão:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Admissão:";
            // 
            // dtAdminissaoFuncionario
            // 
            this.dtAdminissaoFuncionario.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtAdminissaoFuncionario.Location = new System.Drawing.Point(96, 117);
            this.dtAdminissaoFuncionario.Name = "dtAdminissaoFuncionario";
            this.dtAdminissaoFuncionario.Size = new System.Drawing.Size(100, 20);
            this.dtAdminissaoFuncionario.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Quantidade:";
            // 
            // txtQuantidadeFuncionario
            // 
            this.txtQuantidadeFuncionario.Location = new System.Drawing.Point(96, 91);
            this.txtQuantidadeFuncionario.Name = "txtQuantidadeFuncionario";
            this.txtQuantidadeFuncionario.Size = new System.Drawing.Size(100, 20);
            this.txtQuantidadeFuncionario.TabIndex = 7;
            // 
            // txtDescricaoCodigoFuncionario
            // 
            this.txtDescricaoCodigoFuncionario.Enabled = false;
            this.txtDescricaoCodigoFuncionario.Location = new System.Drawing.Point(202, 65);
            this.txtDescricaoCodigoFuncionario.Name = "txtDescricaoCodigoFuncionario";
            this.txtDescricaoCodigoFuncionario.Size = new System.Drawing.Size(187, 20);
            this.txtDescricaoCodigoFuncionario.TabIndex = 6;
            this.txtDescricaoCodigoFuncionario.Text = "Ajudante de Serralheiro";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Função:";
            // 
            // txtCodigoFuncaoFuncionario
            // 
            this.txtCodigoFuncaoFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoFuncaoFuncionario.Location = new System.Drawing.Point(96, 65);
            this.txtCodigoFuncaoFuncionario.Name = "txtCodigoFuncaoFuncionario";
            this.txtCodigoFuncaoFuncionario.Size = new System.Drawing.Size(100, 18);
            this.txtCodigoFuncaoFuncionario.TabIndex = 4;
            this.txtCodigoFuncaoFuncionario.Text = "SIGT-AJSER - 000001";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Matrícula:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nome:";
            // 
            // txtMatriculaFuncionario
            // 
            this.txtMatriculaFuncionario.Location = new System.Drawing.Point(96, 13);
            this.txtMatriculaFuncionario.Name = "txtMatriculaFuncionario";
            this.txtMatriculaFuncionario.Size = new System.Drawing.Size(85, 20);
            this.txtMatriculaFuncionario.TabIndex = 0;
            this.txtMatriculaFuncionario.Text = "50108896";
            // 
            // txtNomeCompletoFuncionario
            // 
            this.txtNomeCompletoFuncionario.Location = new System.Drawing.Point(96, 39);
            this.txtNomeCompletoFuncionario.Name = "txtNomeCompletoFuncionario";
            this.txtNomeCompletoFuncionario.Size = new System.Drawing.Size(293, 20);
            this.txtNomeCompletoFuncionario.TabIndex = 2;
            this.txtNomeCompletoFuncionario.Text = "Carlos José de Souza Brito Júnior";
            // 
            // DadosComplementares
            // 
            this.DadosComplementares.Controls.Add(this.dataGridView2);
            this.DadosComplementares.Location = new System.Drawing.Point(4, 22);
            this.DadosComplementares.Name = "DadosComplementares";
            this.DadosComplementares.Padding = new System.Windows.Forms.Padding(3);
            this.DadosComplementares.Size = new System.Drawing.Size(427, 344);
            this.DadosComplementares.TabIndex = 1;
            this.DadosComplementares.Text = "Dados Complementares";
            this.DadosComplementares.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 3);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(421, 338);
            this.dataGridView2.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            this.Column1.Width = 60;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Matricula";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Arquivo";
            this.Column3.Name = "Column3";
            this.Column3.Width = 200;
            // 
            // JornadaSemanal
            // 
            this.JornadaSemanal.Controls.Add(this.dataGridViewSemanaFuncionario);
            this.JornadaSemanal.Location = new System.Drawing.Point(4, 22);
            this.JornadaSemanal.Name = "JornadaSemanal";
            this.JornadaSemanal.Size = new System.Drawing.Size(427, 344);
            this.JornadaSemanal.TabIndex = 2;
            this.JornadaSemanal.Text = "Jornada Semanal Padrão";
            this.JornadaSemanal.UseVisualStyleBackColor = true;
            // 
            // dataGridViewSemanaFuncionario
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewSemanaFuncionario.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewSemanaFuncionario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSemanaFuncionario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Dom,
            this.SegFun,
            this.TerFun,
            this.QuaFun,
            this.QuiFun,
            this.SexFun,
            this.SabFun});
            this.dataGridViewSemanaFuncionario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewSemanaFuncionario.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewSemanaFuncionario.Name = "dataGridViewSemanaFuncionario";
            this.dataGridViewSemanaFuncionario.Size = new System.Drawing.Size(427, 344);
            this.dataGridViewSemanaFuncionario.TabIndex = 0;
            this.dataGridViewSemanaFuncionario.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSemanaFuncionario_CellValueChanged);
            // 
            // Dom
            // 
            this.Dom.HeaderText = "Dom";
            this.Dom.Name = "Dom";
            this.Dom.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Dom.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Dom.Width = 40;
            // 
            // SegFun
            // 
            this.SegFun.HeaderText = "Seg";
            this.SegFun.Name = "SegFun";
            this.SegFun.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.SegFun.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.SegFun.Width = 40;
            // 
            // TerFun
            // 
            this.TerFun.HeaderText = "Ter";
            this.TerFun.Name = "TerFun";
            this.TerFun.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.TerFun.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.TerFun.Width = 40;
            // 
            // QuaFun
            // 
            this.QuaFun.HeaderText = "Qua";
            this.QuaFun.Name = "QuaFun";
            this.QuaFun.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.QuaFun.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.QuaFun.Width = 40;
            // 
            // QuiFun
            // 
            this.QuiFun.HeaderText = "Qui";
            this.QuiFun.Name = "QuiFun";
            this.QuiFun.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.QuiFun.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.QuiFun.Width = 40;
            // 
            // SexFun
            // 
            this.SexFun.HeaderText = "Sex";
            this.SexFun.Name = "SexFun";
            this.SexFun.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.SexFun.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.SexFun.Width = 40;
            // 
            // SabFun
            // 
            this.SabFun.HeaderText = "Sab";
            this.SabFun.Name = "SabFun";
            this.SabFun.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.SabFun.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.SabFun.Width = 40;
            // 
            // metroStyleManagerCadastroFuncionario
            // 
            this.metroStyleManagerCadastroFuncionario.Owner = this;
            // 
            // CadFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 450);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CadFuncionario";
            this.Text = "Cadastro de Funcionarios";
            this.Load += new System.EventHandler(this.CadFuncionario_Load);
            this.tabControl1.ResumeLayout(false);
            this.Funcionário.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.DadosComplementares.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.JornadaSemanal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSemanaFuncionario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManagerCadastroFuncionario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Funcionário;
        private System.Windows.Forms.TabPage DadosComplementares;
        private System.Windows.Forms.TabPage JornadaSemanal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNomeCompletoFuncionario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMatriculaFuncionario;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtDemissaoFuncionario;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtAdminissaoFuncionario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtQuantidadeFuncionario;
        private System.Windows.Forms.TextBox txtDescricaoCodigoFuncionario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCodigoFuncaoFuncionario;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdVincuExternoFuncionario;
        private System.Windows.Forms.RadioButton rdVinculoInternoFuncionario;
        private System.Windows.Forms.TextBox txtDisponibilidadeFuncionario;
        private System.Windows.Forms.RadioButton rdAtividadeProducao;
        private System.Windows.Forms.RadioButton rdAtividadeManutencao;
        private System.Windows.Forms.RadioButton rdCategoriaHoristaFuncionario;
        private System.Windows.Forms.RadioButton rdCategoriaMensalistaFuncionario;
        private System.Windows.Forms.DataGridView dataGridViewSemanaFuncionario;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Button btnVoltarMenu;
        private System.Windows.Forms.Button btnGravar;
        private MetroFramework.Components.MetroStyleManager metroStyleManagerCadastroFuncionario;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Dom;
        private System.Windows.Forms.DataGridViewCheckBoxColumn SegFun;
        private System.Windows.Forms.DataGridViewCheckBoxColumn TerFun;
        private System.Windows.Forms.DataGridViewCheckBoxColumn QuaFun;
        private System.Windows.Forms.DataGridViewCheckBoxColumn QuiFun;
        private System.Windows.Forms.DataGridViewCheckBoxColumn SexFun;
        private System.Windows.Forms.DataGridViewCheckBoxColumn SabFun;
        private System.Windows.Forms.Button btnArquivo;
        private System.Windows.Forms.TextBox txtCaminhoArquivoFuncionario;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.RadioButton rdDesativadoFuncionario;
        private System.Windows.Forms.RadioButton rdAtivoFuncionario;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}