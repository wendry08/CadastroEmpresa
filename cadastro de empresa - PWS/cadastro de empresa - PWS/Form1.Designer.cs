namespace cadastro_de_empresa___PWS
{
    partial class Form1
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
            this.tx_cnpj = new System.Windows.Forms.TextBox();
            this.CNPJ = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tx_razaosocial = new System.Windows.Forms.TextBox();
            this.tx_nomefantasia = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tx_situacaocadastral = new System.Windows.Forms.ComboBox();
            this.tx_nacional = new System.Windows.Forms.RadioButton();
            this.tx_presumido = new System.Windows.Forms.RadioButton();
            this.tx_nomereal = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tx_telefone = new System.Windows.Forms.MaskedTextBox();
            this.tx_atividade = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tx_social = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tx_completo = new System.Windows.Forms.ComboBox();
            this.tx_matriz = new System.Windows.Forms.RadioButton();
            this.tx_filial = new System.Windows.Forms.RadioButton();
            this.tx_grande = new System.Windows.Forms.RadioButton();
            this.tx_medio = new System.Windows.Forms.RadioButton();
            this.label13 = new System.Windows.Forms.Label();
            this.tx_juridica = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.tx_proprietario = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.tx_cpf = new System.Windows.Forms.MaskedTextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.tx_bairro = new System.Windows.Forms.TextBox();
            this.tx_rua = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tx_grouptri = new System.Windows.Forms.GroupBox();
            this.tx_grouptipo = new System.Windows.Forms.GroupBox();
            this.group3 = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.tx_grouptri.SuspendLayout();
            this.tx_grouptipo.SuspendLayout();
            this.group3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tx_cnpj
            // 
            this.tx_cnpj.Location = new System.Drawing.Point(72, 61);
            this.tx_cnpj.Name = "tx_cnpj";
            this.tx_cnpj.Size = new System.Drawing.Size(227, 20);
            this.tx_cnpj.TabIndex = 0;
            this.tx_cnpj.TextChanged += new System.EventHandler(this.tx_cnpj_TextChanged);
            // 
            // CNPJ
            // 
            this.CNPJ.AutoSize = true;
            this.CNPJ.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CNPJ.Location = new System.Drawing.Point(19, 61);
            this.CNPJ.Name = "CNPJ";
            this.CNPJ.Size = new System.Drawing.Size(46, 16);
            this.CNPJ.TabIndex = 1;
            this.CNPJ.Text = "CNPJ";
            this.CNPJ.Click += new System.EventHandler(this.CNPJ_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(284, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(270, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cadastro da Empresa";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "RAZÃO SOCIAL";
            // 
            // tx_razaosocial
            // 
            this.tx_razaosocial.Location = new System.Drawing.Point(128, 100);
            this.tx_razaosocial.Name = "tx_razaosocial";
            this.tx_razaosocial.Size = new System.Drawing.Size(171, 20);
            this.tx_razaosocial.TabIndex = 4;
            this.tx_razaosocial.TextChanged += new System.EventHandler(this.tx_razaosocial_TextChanged);
            // 
            // tx_nomefantasia
            // 
            this.tx_nomefantasia.Location = new System.Drawing.Point(133, 134);
            this.tx_nomefantasia.Name = "tx_nomefantasia";
            this.tx_nomefantasia.Size = new System.Drawing.Size(166, 20);
            this.tx_nomefantasia.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "NOME FANTASIA";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(350, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 10;
            // 
            // tx_situacaocadastral
            // 
            this.tx_situacaocadastral.FormattingEnabled = true;
            this.tx_situacaocadastral.Items.AddRange(new object[] {
            "ATIVA",
            "NULA",
            "SUSPENSA",
            "INAPTA",
            "BAIXADA"});
            this.tx_situacaocadastral.Location = new System.Drawing.Point(178, 339);
            this.tx_situacaocadastral.Name = "tx_situacaocadastral";
            this.tx_situacaocadastral.Size = new System.Drawing.Size(121, 21);
            this.tx_situacaocadastral.TabIndex = 11;
            this.tx_situacaocadastral.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // tx_nacional
            // 
            this.tx_nacional.AutoSize = true;
            this.tx_nacional.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_nacional.Location = new System.Drawing.Point(24, 19);
            this.tx_nacional.Name = "tx_nacional";
            this.tx_nacional.Size = new System.Drawing.Size(118, 17);
            this.tx_nacional.TabIndex = 12;
            this.tx_nacional.TabStop = true;
            this.tx_nacional.Text = "simples nacional";
            this.tx_nacional.UseVisualStyleBackColor = true;
            // 
            // tx_presumido
            // 
            this.tx_presumido.AutoSize = true;
            this.tx_presumido.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_presumido.Location = new System.Drawing.Point(24, 42);
            this.tx_presumido.Name = "tx_presumido";
            this.tx_presumido.Size = new System.Drawing.Size(114, 17);
            this.tx_presumido.TabIndex = 13;
            this.tx_presumido.TabStop = true;
            this.tx_presumido.Text = "lucro presumido";
            this.tx_presumido.UseVisualStyleBackColor = true;
            // 
            // tx_nomereal
            // 
            this.tx_nomereal.AutoSize = true;
            this.tx_nomereal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_nomereal.Location = new System.Drawing.Point(24, 65);
            this.tx_nomereal.Name = "tx_nomereal";
            this.tx_nomereal.Size = new System.Drawing.Size(78, 17);
            this.tx_nomereal.TabIndex = 14;
            this.tx_nomereal.TabStop = true;
            this.tx_nomereal.Text = "lucro real";
            this.tx_nomereal.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(19, 341);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(153, 15);
            this.label6.TabIndex = 15;
            this.label6.Text = "SITUAÇÃO CADASTRAL";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(19, 167);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 15);
            this.label7.TabIndex = 16;
            this.label7.Text = "TELEFONE";
            // 
            // tx_telefone
            // 
            this.tx_telefone.Location = new System.Drawing.Point(95, 167);
            this.tx_telefone.Mask = "(999) 000-0000";
            this.tx_telefone.Name = "tx_telefone";
            this.tx_telefone.Size = new System.Drawing.Size(204, 20);
            this.tx_telefone.TabIndex = 17;
            // 
            // tx_atividade
            // 
            this.tx_atividade.Location = new System.Drawing.Point(214, 208);
            this.tx_atividade.Mask = "00/00/0000";
            this.tx_atividade.Name = "tx_atividade";
            this.tx_atividade.Size = new System.Drawing.Size(85, 20);
            this.tx_atividade.TabIndex = 18;
            this.tx_atividade.ValidatingType = typeof(System.DateTime);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(19, 208);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(189, 15);
            this.label8.TabIndex = 19;
            this.label8.Text = "DATA DE INICIO DE ATIVIDADE";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(519, 66);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 15);
            this.label9.TabIndex = 20;
            this.label9.Text = "CAPITAL SOCIAL";
            // 
            // tx_social
            // 
            this.tx_social.Location = new System.Drawing.Point(636, 66);
            this.tx_social.Name = "tx_social";
            this.tx_social.Size = new System.Drawing.Size(100, 20);
            this.tx_social.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(519, 105);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(148, 15);
            this.label10.TabIndex = 22;
            this.label10.Text = "ENDEREÇO COMPLETO";
            // 
            // tx_completo
            // 
            this.tx_completo.FormattingEnabled = true;
            this.tx_completo.Items.AddRange(new object[] {
            "Acre (AC)",
            "Alagoas (AL)",
            "Amapá (AP)",
            "Amazonas (AM)",
            "Bahia (BA)",
            "Ceará (CE)",
            "Distrito Federal (DF)",
            "Espírito Santo (ES)",
            "Goiás (GO)",
            "Maranhão (MA)",
            "Mato Grosso (MT)",
            "Mato Grosso do Sul (MS)",
            "Minas Gerais (MG)",
            "Pará (PA)",
            "Paraíba (PB)",
            "Paraná (PR)",
            "Pernambuco (PE)",
            "Piauí (PI)",
            "Rio de Janeiro (RJ)",
            "Rio Grande do Norte (RN)",
            "Rio Grande do Sul (RS)",
            "Rondônia (RO)",
            "Roraima (RR)",
            "Santa Catarina (SC)",
            "São Paulo (SP)",
            "Sergipe (SE)",
            "Tocantins (TO)"});
            this.tx_completo.Location = new System.Drawing.Point(667, 103);
            this.tx_completo.Name = "tx_completo";
            this.tx_completo.Size = new System.Drawing.Size(121, 21);
            this.tx_completo.TabIndex = 23;
            // 
            // tx_matriz
            // 
            this.tx_matriz.AutoSize = true;
            this.tx_matriz.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_matriz.Location = new System.Drawing.Point(45, 11);
            this.tx_matriz.Name = "tx_matriz";
            this.tx_matriz.Size = new System.Drawing.Size(62, 17);
            this.tx_matriz.TabIndex = 25;
            this.tx_matriz.TabStop = true;
            this.tx_matriz.Text = "matriz ";
            this.tx_matriz.UseVisualStyleBackColor = true;
            // 
            // tx_filial
            // 
            this.tx_filial.AutoSize = true;
            this.tx_filial.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_filial.Location = new System.Drawing.Point(45, 30);
            this.tx_filial.Name = "tx_filial";
            this.tx_filial.Size = new System.Drawing.Size(48, 17);
            this.tx_filial.TabIndex = 26;
            this.tx_filial.TabStop = true;
            this.tx_filial.Text = "filial";
            this.tx_filial.UseVisualStyleBackColor = true;
            // 
            // tx_grande
            // 
            this.tx_grande.AutoSize = true;
            this.tx_grande.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_grande.Location = new System.Drawing.Point(28, 19);
            this.tx_grande.Name = "tx_grande";
            this.tx_grande.Size = new System.Drawing.Size(64, 17);
            this.tx_grande.TabIndex = 29;
            this.tx_grande.TabStop = true;
            this.tx_grande.Text = "grande";
            this.tx_grande.UseVisualStyleBackColor = true;
            // 
            // tx_medio
            // 
            this.tx_medio.AutoSize = true;
            this.tx_medio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_medio.Location = new System.Drawing.Point(34, 49);
            this.tx_medio.Name = "tx_medio";
            this.tx_medio.Size = new System.Drawing.Size(58, 17);
            this.tx_medio.TabIndex = 30;
            this.tx_medio.TabStop = true;
            this.tx_medio.Text = "medio";
            this.tx_medio.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(519, 160);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(134, 15);
            this.label13.TabIndex = 31;
            this.label13.Text = "NATUREZA JURIDICA";
            // 
            // tx_juridica
            // 
            this.tx_juridica.FormattingEnabled = true;
            this.tx_juridica.Items.AddRange(new object[] {
            "EI - Empresario Individual",
            "MEI - Microempreendedor Individual",
            "Sociedade Anonima"});
            this.tx_juridica.Location = new System.Drawing.Point(659, 154);
            this.tx_juridica.Name = "tx_juridica";
            this.tx_juridica.Size = new System.Drawing.Size(121, 21);
            this.tx_juridica.TabIndex = 32;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(19, 447);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(163, 15);
            this.label14.TabIndex = 33;
            this.label14.Text = "NOME DO PROPRIETARIO";
            // 
            // tx_proprietario
            // 
            this.tx_proprietario.Location = new System.Drawing.Point(188, 445);
            this.tx_proprietario.Name = "tx_proprietario";
            this.tx_proprietario.Size = new System.Drawing.Size(111, 20);
            this.tx_proprietario.TabIndex = 34;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(19, 245);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(31, 15);
            this.label15.TabIndex = 35;
            this.label15.Text = "CPF";
            // 
            // tx_cpf
            // 
            this.tx_cpf.Location = new System.Drawing.Point(56, 243);
            this.tx_cpf.Mask = "000.000.000-00";
            this.tx_cpf.Name = "tx_cpf";
            this.tx_cpf.Size = new System.Drawing.Size(243, 20);
            this.tx_cpf.TabIndex = 36;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(19, 395);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(57, 15);
            this.label16.TabIndex = 37;
            this.label16.Text = "BAIRRO";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label17.Location = new System.Drawing.Point(19, 289);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(33, 15);
            this.label17.TabIndex = 38;
            this.label17.Text = "RUA";
            // 
            // tx_bairro
            // 
            this.tx_bairro.Location = new System.Drawing.Point(82, 393);
            this.tx_bairro.Name = "tx_bairro";
            this.tx_bairro.Size = new System.Drawing.Size(217, 20);
            this.tx_bairro.TabIndex = 39;
            // 
            // tx_rua
            // 
            this.tx_rua.Location = new System.Drawing.Point(58, 287);
            this.tx_rua.Name = "tx_rua";
            this.tx_rua.Size = new System.Drawing.Size(241, 20);
            this.tx_rua.TabIndex = 40;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(369, 256);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 43);
            this.button1.TabIndex = 41;
            this.button1.Text = "CADASTRAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tx_grouptri
            // 
            this.tx_grouptri.Controls.Add(this.tx_presumido);
            this.tx_grouptri.Controls.Add(this.tx_nomereal);
            this.tx_grouptri.Controls.Add(this.tx_nacional);
            this.tx_grouptri.Location = new System.Drawing.Point(536, 204);
            this.tx_grouptri.Name = "tx_grouptri";
            this.tx_grouptri.Size = new System.Drawing.Size(200, 100);
            this.tx_grouptri.TabIndex = 42;
            this.tx_grouptri.TabStop = false;
            this.tx_grouptri.Text = "Grupo Tributario";
            this.tx_grouptri.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // tx_grouptipo
            // 
            this.tx_grouptipo.Controls.Add(this.tx_matriz);
            this.tx_grouptipo.Controls.Add(this.tx_filial);
            this.tx_grouptipo.Location = new System.Drawing.Point(536, 415);
            this.tx_grouptipo.Name = "tx_grouptipo";
            this.tx_grouptipo.Size = new System.Drawing.Size(166, 49);
            this.tx_grouptipo.TabIndex = 43;
            this.tx_grouptipo.TabStop = false;
            this.tx_grouptipo.Text = "grouptipo";
            // 
            // group3
            // 
            this.group3.Controls.Add(this.radioButton1);
            this.group3.Controls.Add(this.label3);
            this.group3.Controls.Add(this.tx_grande);
            this.group3.Controls.Add(this.tx_medio);
            this.group3.Location = new System.Drawing.Point(536, 323);
            this.group3.Name = "group3";
            this.group3.Size = new System.Drawing.Size(200, 71);
            this.group3.TabIndex = 44;
            this.group3.TabStop = false;
            this.group3.Text = "Grupo Empresa";
            this.group3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(104, 33);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(74, 17);
            this.radioButton1.TabIndex = 32;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "pequeno";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(98, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 31;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 516);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tx_rua);
            this.Controls.Add(this.tx_bairro);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.tx_cpf);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.tx_proprietario);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.tx_juridica);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.tx_completo);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tx_social);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tx_atividade);
            this.Controls.Add(this.tx_telefone);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tx_situacaocadastral);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tx_nomefantasia);
            this.Controls.Add(this.tx_razaosocial);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CNPJ);
            this.Controls.Add(this.tx_cnpj);
            this.Controls.Add(this.tx_grouptri);
            this.Controls.Add(this.tx_grouptipo);
            this.Controls.Add(this.group3);
            this.Name = "Form1";
            this.Text = "CADASTRO";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tx_grouptri.ResumeLayout(false);
            this.tx_grouptri.PerformLayout();
            this.tx_grouptipo.ResumeLayout(false);
            this.tx_grouptipo.PerformLayout();
            this.group3.ResumeLayout(false);
            this.group3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tx_cnpj;
        private System.Windows.Forms.Label CNPJ;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tx_razaosocial;
        private System.Windows.Forms.TextBox tx_nomefantasia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox tx_situacaocadastral;
        private System.Windows.Forms.RadioButton tx_nacional;
        private System.Windows.Forms.RadioButton tx_presumido;
        private System.Windows.Forms.RadioButton tx_nomereal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox tx_telefone;
        private System.Windows.Forms.MaskedTextBox tx_atividade;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tx_social;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox tx_completo;
        private System.Windows.Forms.RadioButton tx_matriz;
        private System.Windows.Forms.RadioButton tx_filial;
        private System.Windows.Forms.RadioButton tx_grande;
        private System.Windows.Forms.RadioButton tx_medio;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox tx_juridica;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tx_proprietario;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.MaskedTextBox tx_cpf;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox tx_bairro;
        private System.Windows.Forms.TextBox tx_rua;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox tx_grouptri;
        private System.Windows.Forms.GroupBox tx_grouptipo;
        private System.Windows.Forms.GroupBox group3;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label3;
    }
}

