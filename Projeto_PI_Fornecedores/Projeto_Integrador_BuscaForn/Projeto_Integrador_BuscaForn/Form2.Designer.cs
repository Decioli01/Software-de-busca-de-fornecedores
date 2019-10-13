namespace Projeto_Integrador_BuscaForn
{
    partial class FormCadastro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>///
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadastro));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCEP = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txtNomeFan = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtCNPJ = new System.Windows.Forms.TextBox();
            this.txtEndereço = new System.Windows.Forms.TextBox();
            this.txtTipForn = new System.Windows.Forms.TextBox();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.txtComp = new System.Windows.Forms.TextBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.txtCel = new System.Windows.Forms.TextBox();
            this.txtObs = new System.Windows.Forms.TextBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.comboboxEstado = new System.Windows.Forms.ComboBox();
            this.btnBuscaCep = new System.Windows.Forms.Button();
            this.btnCancCad = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(323, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(362, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "CADASTRO DE FORNECEDOR";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nome:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(12, 384);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 19);
            this.label4.TabIndex = 2;
            this.label4.Text = "Telefone:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(525, 384);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 19);
            this.label5.TabIndex = 3;
            this.label5.Text = "Celular:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(12, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 19);
            this.label6.TabIndex = 4;
            this.label6.Text = "Nome Fantasia:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(12, 170);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 19);
            this.label7.TabIndex = 5;
            this.label7.Text = "CPF/CNPJ:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(583, 94);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(182, 19);
            this.label8.TabIndex = 6;
            this.label8.Text = "Tipo de Fornecimento:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(12, 245);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 19);
            this.label9.TabIndex = 7;
            this.label9.Text = "Endereço:";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Location = new System.Drawing.Point(695, 245);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(122, 19);
            this.label10.TabIndex = 8;
            this.label10.Text = "Complemento:";
            // 
            // txtCEP
            // 
            this.txtCEP.Location = new System.Drawing.Point(67, 203);
            this.txtCEP.Name = "txtCEP";
            this.txtCEP.Size = new System.Drawing.Size(251, 26);
            this.txtCEP.TabIndex = 9;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Location = new System.Drawing.Point(12, 207);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 19);
            this.label11.TabIndex = 10;
            this.label11.Text = "CEP:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Location = new System.Drawing.Point(529, 245);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(33, 19);
            this.label12.TabIndex = 11;
            this.label12.Text = "Nº:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Location = new System.Drawing.Point(12, 281);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(62, 19);
            this.label13.TabIndex = 12;
            this.label13.Text = "Bairro:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Location = new System.Drawing.Point(12, 315);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(69, 19);
            this.label14.TabIndex = 13;
            this.label14.Text = "Cidade:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Location = new System.Drawing.Point(525, 281);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(69, 19);
            this.label15.TabIndex = 14;
            this.label15.Text = "Estado:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Location = new System.Drawing.Point(16, 349);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(62, 19);
            this.label16.TabIndex = 15;
            this.label16.Text = "E-mail:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Location = new System.Drawing.Point(28, 475);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(116, 19);
            this.label17.TabIndex = 16;
            this.label17.Text = "Observações:";
            // 
            // txtNomeFan
            // 
            this.txtNomeFan.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNomeFan.Location = new System.Drawing.Point(142, 91);
            this.txtNomeFan.Name = "txtNomeFan";
            this.txtNomeFan.Size = new System.Drawing.Size(435, 26);
            this.txtNomeFan.TabIndex = 17;
            // 
            // txtNome
            // 
            this.txtNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNome.Location = new System.Drawing.Point(78, 130);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(904, 26);
            this.txtNome.TabIndex = 18;
            // 
            // txtCNPJ
            // 
            this.txtCNPJ.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCNPJ.Location = new System.Drawing.Point(114, 167);
            this.txtCNPJ.Name = "txtCNPJ";
            this.txtCNPJ.Size = new System.Drawing.Size(430, 26);
            this.txtCNPJ.TabIndex = 19;
            // 
            // txtEndereço
            // 
            this.txtEndereço.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEndereço.Location = new System.Drawing.Point(107, 242);
            this.txtEndereço.Name = "txtEndereço";
            this.txtEndereço.Size = new System.Drawing.Size(409, 26);
            this.txtEndereço.TabIndex = 20;
            // 
            // txtTipForn
            // 
            this.txtTipForn.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTipForn.Location = new System.Drawing.Point(765, 91);
            this.txtTipForn.Name = "txtTipForn";
            this.txtTipForn.Size = new System.Drawing.Size(217, 26);
            this.txtTipForn.TabIndex = 21;
            // 
            // txtNum
            // 
            this.txtNum.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNum.Location = new System.Drawing.Point(568, 242);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(88, 26);
            this.txtNum.TabIndex = 22;
            // 
            // txtComp
            // 
            this.txtComp.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtComp.Location = new System.Drawing.Point(823, 242);
            this.txtComp.Name = "txtComp";
            this.txtComp.Size = new System.Drawing.Size(159, 26);
            this.txtComp.TabIndex = 23;
            // 
            // txtBairro
            // 
            this.txtBairro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBairro.Location = new System.Drawing.Point(76, 278);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(440, 26);
            this.txtBairro.TabIndex = 24;
            // 
            // txtCidade
            // 
            this.txtCidade.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCidade.Location = new System.Drawing.Point(78, 312);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(438, 26);
            this.txtCidade.TabIndex = 25;
            // 
            // txtEmail
            // 
            this.txtEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEmail.Location = new System.Drawing.Point(76, 346);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(440, 26);
            this.txtEmail.TabIndex = 26;
            // 
            // txtTel
            // 
            this.txtTel.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTel.Location = new System.Drawing.Point(89, 381);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(201, 26);
            this.txtTel.TabIndex = 27;
            // 
            // txtCel
            // 
            this.txtCel.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCel.Location = new System.Drawing.Point(600, 381);
            this.txtCel.Name = "txtCel";
            this.txtCel.Size = new System.Drawing.Size(217, 26);
            this.txtCel.TabIndex = 29;
            // 
            // txtObs
            // 
            this.txtObs.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtObs.Location = new System.Drawing.Point(26, 497);
            this.txtObs.Multiline = true;
            this.txtObs.Name = "txtObs";
            this.txtObs.Size = new System.Drawing.Size(801, 93);
            this.txtObs.TabIndex = 30;
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackgroundImage = global::Projeto_Integrador_BuscaForn.Properties.Resources.Formulario_Salvo48x48;
            this.btnConfirm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnConfirm.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.btnConfirm.FlatAppearance.BorderSize = 2;
            this.btnConfirm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirm.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnConfirm.Location = new System.Drawing.Point(689, 596);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(138, 53);
            this.btnConfirm.TabIndex = 31;
            this.btnConfirm.Text = "Confirmar Cadastro";
            this.btnConfirm.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnConfirm.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnConfirm.UseVisualStyleBackColor = true;
            // 
            // comboboxEstado
            // 
            this.comboboxEstado.FormattingEnabled = true;
            this.comboboxEstado.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AM",
            "AP",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MT",
            "MS",
            "MG",
            "PA",
            "PB",
            "PR",
            "PI",
            "RJ",
            "RN",
            "RS",
            "RO",
            "RR",
            "SC",
            "SP",
            "SE",
            "TO"});
            this.comboboxEstado.Location = new System.Drawing.Point(600, 278);
            this.comboboxEstado.Name = "comboboxEstado";
            this.comboboxEstado.Size = new System.Drawing.Size(121, 27);
            this.comboboxEstado.TabIndex = 33;
            // 
            // btnBuscaCep
            // 
            this.btnBuscaCep.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.btnBuscaCep.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnBuscaCep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscaCep.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBuscaCep.Location = new System.Drawing.Point(325, 203);
            this.btnBuscaCep.Name = "btnBuscaCep";
            this.btnBuscaCep.Size = new System.Drawing.Size(114, 27);
            this.btnBuscaCep.TabIndex = 34;
            this.btnBuscaCep.Text = "Buscar CEP";
            this.btnBuscaCep.UseVisualStyleBackColor = true;
            // 
            // btnCancCad
            // 
            this.btnCancCad.BackgroundImage = global::Projeto_Integrador_BuscaForn.Properties.Resources.Formulario_Canc48x48;
            this.btnCancCad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCancCad.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnCancCad.FlatAppearance.BorderSize = 2;
            this.btnCancCad.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCancCad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancCad.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCancCad.Location = new System.Drawing.Point(844, 596);
            this.btnCancCad.Name = "btnCancCad";
            this.btnCancCad.Size = new System.Drawing.Size(138, 53);
            this.btnCancCad.TabIndex = 35;
            this.btnCancCad.Text = "Cancelar Cadastr";
            this.btnCancCad.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancCad.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancCad.UseVisualStyleBackColor = true;
            this.btnCancCad.Click += new System.EventHandler(this.btnCancCad_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Location = new System.Drawing.Point(16, 432);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(136, 19);
            this.label18.TabIndex = 36;
            this.label18.Text = "Crie uma Senha:";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtSenha
            // 
            this.txtSenha.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSenha.Location = new System.Drawing.Point(158, 429);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(301, 26);
            this.txtSenha.TabIndex = 37;
            this.txtSenha.UseSystemPasswordChar = true;
            // 
            // FormCadastro
            // 
            this.BackgroundImage = global::Projeto_Integrador_BuscaForn.Properties.Resources.Fundo_pagina_inicial;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1013, 678);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.btnCancCad);
            this.Controls.Add(this.btnBuscaCep);
            this.Controls.Add(this.comboboxEstado);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.txtObs);
            this.Controls.Add(this.txtCel);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtCidade);
            this.Controls.Add(this.txtBairro);
            this.Controls.Add(this.txtComp);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.txtTipForn);
            this.Controls.Add(this.txtEndereço);
            this.Controls.Add(this.txtCNPJ);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtNomeFan);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtCEP);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormCadastro";
            this.Text = "Novo Cadastro";
            this.Load += new System.EventHandler(this.FormCadastro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtCEP;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtNomeFan;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtCNPJ;
        private System.Windows.Forms.TextBox txtEndereço;
        private System.Windows.Forms.TextBox txtTipForn;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.TextBox txtComp;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.TextBox txtCel;
        private System.Windows.Forms.TextBox txtObs;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.ComboBox comboboxEstado;
        private System.Windows.Forms.Button btnBuscaCep;
        private System.Windows.Forms.Button btnCancCad;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtSenha;
    }
}