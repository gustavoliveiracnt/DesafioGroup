﻿namespace Desafio_Group.Forms
{
    partial class CadastroForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroForm));
            this.DocumentoLabel = new System.Windows.Forms.Label();
            this.NomeLabel = new System.Windows.Forms.Label();
            this.nomeTxt = new System.Windows.Forms.TextBox();
            this.tpDocument = new System.Windows.Forms.Label();
            this.TipoCPF = new System.Windows.Forms.RadioButton();
            this.TipoCNPJ = new System.Windows.Forms.RadioButton();
            this.TelefoneLabel = new System.Windows.Forms.Label();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.emailTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.enderecoTxt = new System.Windows.Forms.TextBox();
            this.cadastrarButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.documentTxt = new System.Windows.Forms.MaskedTextBox();
            this.telefoneTxt = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buscar = new System.Windows.Forms.Button();
            this.buscartxt = new System.Windows.Forms.MaskedTextBox();
            this.CNPJBusca = new System.Windows.Forms.RadioButton();
            this.CPFBusca = new System.Windows.Forms.RadioButton();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.limparButton = new System.Windows.Forms.Button();
            this.nomeBusca = new System.Windows.Forms.RadioButton();
            this.Close = new System.Windows.Forms.Button();
            this.btnViewLocal = new System.Windows.Forms.Button();
            this.ImagemLogin = new System.Windows.Forms.PictureBox();
            this.tabelaCadastroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImagemLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaCadastroBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // DocumentoLabel
            // 
            this.DocumentoLabel.AutoSize = true;
            this.DocumentoLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DocumentoLabel.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.DocumentoLabel.Location = new System.Drawing.Point(158, 153);
            this.DocumentoLabel.Name = "DocumentoLabel";
            this.DocumentoLabel.Size = new System.Drawing.Size(118, 20);
            this.DocumentoLabel.TabIndex = 9;
            this.DocumentoLabel.Text = "Documento:";
            // 
            // NomeLabel
            // 
            this.NomeLabel.AutoSize = true;
            this.NomeLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NomeLabel.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.NomeLabel.Location = new System.Drawing.Point(22, 90);
            this.NomeLabel.Name = "NomeLabel";
            this.NomeLabel.Size = new System.Drawing.Size(75, 20);
            this.NomeLabel.TabIndex = 7;
            this.NomeLabel.Text = "Nome: ";
            // 
            // nomeTxt
            // 
            this.nomeTxt.BackColor = System.Drawing.Color.Lavender;
            this.nomeTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomeTxt.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.nomeTxt.Location = new System.Drawing.Point(26, 113);
            this.nomeTxt.Name = "nomeTxt";
            this.nomeTxt.Size = new System.Drawing.Size(297, 22);
            this.nomeTxt.TabIndex = 0;
            // 
            // tpDocument
            // 
            this.tpDocument.AutoSize = true;
            this.tpDocument.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpDocument.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.tpDocument.Location = new System.Drawing.Point(22, 153);
            this.tpDocument.Name = "tpDocument";
            this.tpDocument.Size = new System.Drawing.Size(56, 20);
            this.tpDocument.TabIndex = 10;
            this.tpDocument.Text = "Tipo:";
            // 
            // TipoCPF
            // 
            this.TipoCPF.AutoSize = true;
            this.TipoCPF.BackColor = System.Drawing.Color.Transparent;
            this.TipoCPF.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TipoCPF.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.TipoCPF.Location = new System.Drawing.Point(26, 176);
            this.TipoCPF.Name = "TipoCPF";
            this.TipoCPF.Size = new System.Drawing.Size(104, 19);
            this.TipoCPF.TabIndex = 1;
            this.TipoCPF.TabStop = true;
            this.TipoCPF.Text = "Física (CPF)";
            this.TipoCPF.UseVisualStyleBackColor = false;
            this.TipoCPF.CheckedChanged += new System.EventHandler(this.TipoCPF_CheckedChanged);
            // 
            // TipoCNPJ
            // 
            this.TipoCNPJ.AutoSize = true;
            this.TipoCNPJ.BackColor = System.Drawing.Color.Transparent;
            this.TipoCNPJ.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TipoCNPJ.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.TipoCNPJ.Location = new System.Drawing.Point(26, 192);
            this.TipoCNPJ.Name = "TipoCNPJ";
            this.TipoCNPJ.Size = new System.Drawing.Size(126, 19);
            this.TipoCNPJ.TabIndex = 2;
            this.TipoCNPJ.TabStop = true;
            this.TipoCNPJ.Text = "Jurídica (CNPJ)";
            this.TipoCNPJ.UseVisualStyleBackColor = false;
            // 
            // TelefoneLabel
            // 
            this.TelefoneLabel.AutoSize = true;
            this.TelefoneLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TelefoneLabel.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.TelefoneLabel.Location = new System.Drawing.Point(22, 235);
            this.TelefoneLabel.Name = "TelefoneLabel";
            this.TelefoneLabel.Size = new System.Drawing.Size(96, 20);
            this.TelefoneLabel.TabIndex = 14;
            this.TelefoneLabel.Text = "Telefone:";
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailLabel.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.EmailLabel.Location = new System.Drawing.Point(159, 235);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(75, 20);
            this.EmailLabel.TabIndex = 16;
            this.EmailLabel.Text = "E-mail:";
            // 
            // emailTxt
            // 
            this.emailTxt.BackColor = System.Drawing.Color.Lavender;
            this.emailTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailTxt.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.emailTxt.Location = new System.Drawing.Point(162, 258);
            this.emailTxt.Name = "emailTxt";
            this.emailTxt.Size = new System.Drawing.Size(161, 22);
            this.emailTxt.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label2.Location = new System.Drawing.Point(23, 300);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 20);
            this.label2.TabIndex = 20;
            this.label2.Text = "Endereço:";
            // 
            // enderecoTxt
            // 
            this.enderecoTxt.BackColor = System.Drawing.Color.Lavender;
            this.enderecoTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enderecoTxt.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.enderecoTxt.Location = new System.Drawing.Point(28, 323);
            this.enderecoTxt.Name = "enderecoTxt";
            this.enderecoTxt.Size = new System.Drawing.Size(257, 22);
            this.enderecoTxt.TabIndex = 8;
            // 
            // cadastrarButton
            // 
            this.cadastrarButton.BackColor = System.Drawing.Color.DarkSlateGray;
            this.cadastrarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cadastrarButton.ForeColor = System.Drawing.Color.Azure;
            this.cadastrarButton.Location = new System.Drawing.Point(28, 367);
            this.cadastrarButton.Name = "cadastrarButton";
            this.cadastrarButton.Size = new System.Drawing.Size(137, 33);
            this.cadastrarButton.TabIndex = 10;
            this.cadastrarButton.Text = "SALVAR";
            this.cadastrarButton.UseVisualStyleBackColor = false;
            this.cadastrarButton.Click += new System.EventHandler(this.salvarButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.DarkRed;
            this.deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.ForeColor = System.Drawing.Color.Azure;
            this.deleteButton.Location = new System.Drawing.Point(186, 367);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(137, 33);
            this.deleteButton.TabIndex = 11;
            this.deleteButton.Text = "DELETAR";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // documentTxt
            // 
            this.documentTxt.BackColor = System.Drawing.Color.Lavender;
            this.documentTxt.Culture = new System.Globalization.CultureInfo("");
            this.documentTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.documentTxt.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.documentTxt.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Insert;
            this.documentTxt.Location = new System.Drawing.Point(162, 191);
            this.documentTxt.Mask = "000.000.000-00";
            this.documentTxt.Name = "documentTxt";
            this.documentTxt.Size = new System.Drawing.Size(161, 22);
            this.documentTxt.TabIndex = 3;
            this.documentTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // telefoneTxt
            // 
            this.telefoneTxt.BackColor = System.Drawing.Color.Lavender;
            this.telefoneTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.telefoneTxt.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.telefoneTxt.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Insert;
            this.telefoneTxt.Location = new System.Drawing.Point(27, 258);
            this.telefoneTxt.Mask = "(99) 99999-9999";
            this.telefoneTxt.Name = "telefoneTxt";
            this.telefoneTxt.Size = new System.Drawing.Size(112, 22);
            this.telefoneTxt.TabIndex = 4;
            this.telefoneTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.telefoneTxt.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label3.Location = new System.Drawing.Point(354, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 20);
            this.label3.TabIndex = 31;
            this.label3.Text = "Buscar:";
            // 
            // buscar
            // 
            this.buscar.BackColor = System.Drawing.Color.OliveDrab;
            this.buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buscar.ForeColor = System.Drawing.Color.Azure;
            this.buscar.Location = new System.Drawing.Point(513, 127);
            this.buscar.Name = "buscar";
            this.buscar.Size = new System.Drawing.Size(72, 22);
            this.buscar.TabIndex = 16;
            this.buscar.Text = "BUSCAR";
            this.buscar.UseVisualStyleBackColor = false;
            this.buscar.Click += new System.EventHandler(this.buscar_Click);
            // 
            // buscartxt
            // 
            this.buscartxt.BackColor = System.Drawing.Color.Lavender;
            this.buscartxt.Culture = new System.Globalization.CultureInfo("");
            this.buscartxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.buscartxt.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.buscartxt.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Insert;
            this.buscartxt.Location = new System.Drawing.Point(513, 99);
            this.buscartxt.Mask = "000.000.000-00";
            this.buscartxt.Name = "buscartxt";
            this.buscartxt.Size = new System.Drawing.Size(147, 22);
            this.buscartxt.TabIndex = 15;
            this.buscartxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CNPJBusca
            // 
            this.CNPJBusca.AutoSize = true;
            this.CNPJBusca.BackColor = System.Drawing.Color.Transparent;
            this.CNPJBusca.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CNPJBusca.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.CNPJBusca.Location = new System.Drawing.Point(358, 127);
            this.CNPJBusca.Name = "CNPJBusca";
            this.CNPJBusca.Size = new System.Drawing.Size(126, 19);
            this.CNPJBusca.TabIndex = 13;
            this.CNPJBusca.TabStop = true;
            this.CNPJBusca.Text = "Jurídica (CNPJ)";
            this.CNPJBusca.UseVisualStyleBackColor = false;
            // 
            // CPFBusca
            // 
            this.CPFBusca.AutoSize = true;
            this.CPFBusca.BackColor = System.Drawing.Color.Transparent;
            this.CPFBusca.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CPFBusca.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.CPFBusca.Location = new System.Drawing.Point(358, 111);
            this.CPFBusca.Name = "CPFBusca";
            this.CPFBusca.Size = new System.Drawing.Size(104, 19);
            this.CPFBusca.TabIndex = 12;
            this.CPFBusca.TabStop = true;
            this.CPFBusca.Text = "Física (CPF)";
            this.CPFBusca.UseVisualStyleBackColor = false;
            this.CPFBusca.CheckedChanged += new System.EventHandler(this.CPFBusca_CheckedChanged);
            // 
            // dataGrid
            // 
            this.dataGrid.AllowUserToAddRows = false;
            this.dataGrid.AllowUserToDeleteRows = false;
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Location = new System.Drawing.Point(358, 176);
            this.dataGrid.MultiSelect = false;
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.ReadOnly = true;
            this.dataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGrid.Size = new System.Drawing.Size(302, 224);
            this.dataGrid.TabIndex = 36;
            this.dataGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_CellDoubleClick);
            // 
            // limparButton
            // 
            this.limparButton.BackColor = System.Drawing.Color.ForestGreen;
            this.limparButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.limparButton.ForeColor = System.Drawing.Color.Azure;
            this.limparButton.Location = new System.Drawing.Point(588, 127);
            this.limparButton.Name = "limparButton";
            this.limparButton.Size = new System.Drawing.Size(72, 22);
            this.limparButton.TabIndex = 17;
            this.limparButton.Text = "LIMPAR";
            this.limparButton.UseVisualStyleBackColor = false;
            this.limparButton.Click += new System.EventHandler(this.LimparButton_Click);
            // 
            // nomeBusca
            // 
            this.nomeBusca.AutoSize = true;
            this.nomeBusca.BackColor = System.Drawing.Color.Transparent;
            this.nomeBusca.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomeBusca.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.nomeBusca.Location = new System.Drawing.Point(358, 144);
            this.nomeBusca.Name = "nomeBusca";
            this.nomeBusca.Size = new System.Drawing.Size(62, 19);
            this.nomeBusca.TabIndex = 14;
            this.nomeBusca.TabStop = true;
            this.nomeBusca.Text = "Nome";
            this.nomeBusca.UseVisualStyleBackColor = false;
            // 
            // Close
            // 
            this.Close.BackColor = System.Drawing.Color.Firebrick;
            this.Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Close.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Close.Location = new System.Drawing.Point(617, 10);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(51, 23);
            this.Close.TabIndex = 18;
            this.Close.Text = "SAIR";
            this.Close.UseVisualStyleBackColor = false;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // btnViewLocal
            // 
            this.btnViewLocal.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnViewLocal.BackgroundImage")));
            this.btnViewLocal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnViewLocal.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnViewLocal.Location = new System.Drawing.Point(291, 320);
            this.btnViewLocal.Name = "btnViewLocal";
            this.btnViewLocal.Size = new System.Drawing.Size(32, 28);
            this.btnViewLocal.TabIndex = 9;
            this.btnViewLocal.UseVisualStyleBackColor = true;
            this.btnViewLocal.Click += new System.EventHandler(this.btnViewLocal_Click);
            // 
            // ImagemLogin
            // 
            this.ImagemLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ImagemLogin.Image = global::Desafio_Group.Properties.Resources.group;
            this.ImagemLogin.Location = new System.Drawing.Point(12, 40);
            this.ImagemLogin.Name = "ImagemLogin";
            this.ImagemLogin.Size = new System.Drawing.Size(656, 37);
            this.ImagemLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ImagemLogin.TabIndex = 21;
            this.ImagemLogin.TabStop = false;
            // 
            // CadastroForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(680, 426);
            this.Controls.Add(this.btnViewLocal);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.nomeBusca);
            this.Controls.Add(this.limparButton);
            this.Controls.Add(this.dataGrid);
            this.Controls.Add(this.buscartxt);
            this.Controls.Add(this.CNPJBusca);
            this.Controls.Add(this.CPFBusca);
            this.Controls.Add(this.buscar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.telefoneTxt);
            this.Controls.Add(this.documentTxt);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.cadastrarButton);
            this.Controls.Add(this.ImagemLogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.enderecoTxt);
            this.Controls.Add(this.EmailLabel);
            this.Controls.Add(this.emailTxt);
            this.Controls.Add(this.TelefoneLabel);
            this.Controls.Add(this.TipoCNPJ);
            this.Controls.Add(this.TipoCPF);
            this.Controls.Add(this.tpDocument);
            this.Controls.Add(this.DocumentoLabel);
            this.Controls.Add(this.NomeLabel);
            this.Controls.Add(this.nomeTxt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CadastroForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro";
            this.Load += new System.EventHandler(this.Cadastro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImagemLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaCadastroBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DocumentoLabel;
        private System.Windows.Forms.Label NomeLabel;
        private System.Windows.Forms.TextBox nomeTxt;
        private System.Windows.Forms.Label tpDocument;
        private System.Windows.Forms.RadioButton TipoCPF;
        private System.Windows.Forms.RadioButton TipoCNPJ;
        private System.Windows.Forms.Label TelefoneLabel;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.TextBox emailTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox enderecoTxt;
        private System.Windows.Forms.PictureBox ImagemLogin;
        private System.Windows.Forms.Button cadastrarButton;
        private System.Windows.Forms.Button deleteButton;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private System.Windows.Forms.MaskedTextBox documentTxt;
        private System.Windows.Forms.MaskedTextBox telefoneTxt;
        private System.Windows.Forms.BindingSource tabelaCadastroBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn documentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn enderecoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buscar;
        private System.Windows.Forms.MaskedTextBox buscartxt;
        private System.Windows.Forms.RadioButton CNPJBusca;
        private System.Windows.Forms.RadioButton CPFBusca;
        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.Button limparButton;
        private System.Windows.Forms.RadioButton nomeBusca;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.Button btnViewLocal;
    }
}