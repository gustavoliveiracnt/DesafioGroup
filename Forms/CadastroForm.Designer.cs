namespace Desafio_Group.Forms
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
            this.label1 = new System.Windows.Forms.Label();
            this.TipoCPF = new System.Windows.Forms.RadioButton();
            this.TipoCNPJ = new System.Windows.Forms.RadioButton();
            this.TelefoneLabel = new System.Windows.Forms.Label();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.emailTxt = new System.Windows.Forms.TextBox();
            this.EnderecoLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.enderecoTxt = new System.Windows.Forms.TextBox();
            this.ImagemLogin = new System.Windows.Forms.PictureBox();
            this.cadastrarButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.alterarButton = new System.Windows.Forms.Button();
            this.viewButton = new System.Windows.Forms.Button();
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.documentTxt = new System.Windows.Forms.MaskedTextBox();
            this.CEPMasked = new System.Windows.Forms.MaskedTextBox();
            this.telefoneTxt = new System.Windows.Forms.MaskedTextBox();
            this.tabelaCadastroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.buscartxt = new System.Windows.Forms.TextBox();
            this.buscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ImagemLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaCadastroBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // DocumentoLabel
            // 
            this.DocumentoLabel.AutoSize = true;
            this.DocumentoLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DocumentoLabel.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.DocumentoLabel.Location = new System.Drawing.Point(158, 122);
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
            this.NomeLabel.Location = new System.Drawing.Point(22, 59);
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
            this.nomeTxt.Location = new System.Drawing.Point(26, 82);
            this.nomeTxt.Name = "nomeTxt";
            this.nomeTxt.Size = new System.Drawing.Size(310, 22);
            this.nomeTxt.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(22, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Tipo:";
            // 
            // TipoCPF
            // 
            this.TipoCPF.AutoSize = true;
            this.TipoCPF.BackColor = System.Drawing.Color.Transparent;
            this.TipoCPF.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TipoCPF.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.TipoCPF.Location = new System.Drawing.Point(26, 145);
            this.TipoCPF.Name = "TipoCPF";
            this.TipoCPF.Size = new System.Drawing.Size(104, 19);
            this.TipoCPF.TabIndex = 11;
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
            this.TipoCNPJ.Location = new System.Drawing.Point(26, 161);
            this.TipoCNPJ.Name = "TipoCNPJ";
            this.TipoCNPJ.Size = new System.Drawing.Size(126, 19);
            this.TipoCNPJ.TabIndex = 12;
            this.TipoCNPJ.TabStop = true;
            this.TipoCNPJ.Text = "Jurídica (CNPJ)";
            this.TipoCNPJ.UseVisualStyleBackColor = false;
            // 
            // TelefoneLabel
            // 
            this.TelefoneLabel.AutoSize = true;
            this.TelefoneLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TelefoneLabel.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.TelefoneLabel.Location = new System.Drawing.Point(22, 204);
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
            this.EmailLabel.Location = new System.Drawing.Point(159, 204);
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
            this.emailTxt.Location = new System.Drawing.Point(162, 227);
            this.emailTxt.Name = "emailTxt";
            this.emailTxt.Size = new System.Drawing.Size(174, 22);
            this.emailTxt.TabIndex = 15;
            // 
            // EnderecoLabel
            // 
            this.EnderecoLabel.AutoSize = true;
            this.EnderecoLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnderecoLabel.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.EnderecoLabel.Location = new System.Drawing.Point(23, 268);
            this.EnderecoLabel.Name = "EnderecoLabel";
            this.EnderecoLabel.Size = new System.Drawing.Size(51, 20);
            this.EnderecoLabel.TabIndex = 18;
            this.EnderecoLabel.Text = "CEP:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label2.Location = new System.Drawing.Point(158, 268);
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
            this.enderecoTxt.Location = new System.Drawing.Point(162, 291);
            this.enderecoTxt.Name = "enderecoTxt";
            this.enderecoTxt.Size = new System.Drawing.Size(174, 22);
            this.enderecoTxt.TabIndex = 19;
            // 
            // ImagemLogin
            // 
            this.ImagemLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ImagemLogin.Image = global::Desafio_Group.Properties.Resources.group;
            this.ImagemLogin.Location = new System.Drawing.Point(12, 12);
            this.ImagemLogin.Name = "ImagemLogin";
            this.ImagemLogin.Size = new System.Drawing.Size(656, 37);
            this.ImagemLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ImagemLogin.TabIndex = 21;
            this.ImagemLogin.TabStop = false;
            // 
            // cadastrarButton
            // 
            this.cadastrarButton.BackColor = System.Drawing.Color.DarkSlateGray;
            this.cadastrarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cadastrarButton.ForeColor = System.Drawing.Color.Azure;
            this.cadastrarButton.Location = new System.Drawing.Point(26, 334);
            this.cadastrarButton.Name = "cadastrarButton";
            this.cadastrarButton.Size = new System.Drawing.Size(310, 33);
            this.cadastrarButton.TabIndex = 22;
            this.cadastrarButton.Text = "CADASTRAR";
            this.cadastrarButton.UseVisualStyleBackColor = false;
            this.cadastrarButton.Click += new System.EventHandler(this.cadastrarButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.DarkRed;
            this.deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.ForeColor = System.Drawing.Color.Azure;
            this.deleteButton.Location = new System.Drawing.Point(26, 376);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(104, 22);
            this.deleteButton.TabIndex = 23;
            this.deleteButton.Text = "DELETAR";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // alterarButton
            // 
            this.alterarButton.BackColor = System.Drawing.Color.DarkCyan;
            this.alterarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alterarButton.ForeColor = System.Drawing.Color.Azure;
            this.alterarButton.Location = new System.Drawing.Point(136, 376);
            this.alterarButton.Name = "alterarButton";
            this.alterarButton.Size = new System.Drawing.Size(81, 22);
            this.alterarButton.TabIndex = 24;
            this.alterarButton.Text = "ALTERAR";
            this.alterarButton.UseVisualStyleBackColor = false;
            this.alterarButton.Click += new System.EventHandler(this.alterarButton_Click);
            // 
            // viewButton
            // 
            this.viewButton.BackColor = System.Drawing.Color.Goldenrod;
            this.viewButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewButton.ForeColor = System.Drawing.Color.Azure;
            this.viewButton.Location = new System.Drawing.Point(223, 376);
            this.viewButton.Name = "viewButton";
            this.viewButton.Size = new System.Drawing.Size(113, 22);
            this.viewButton.TabIndex = 25;
            this.viewButton.Text = "VISUZALIZAR";
            this.viewButton.UseVisualStyleBackColor = false;
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
            this.documentTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.documentTxt.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.documentTxt.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Insert;
            this.documentTxt.Location = new System.Drawing.Point(162, 160);
            this.documentTxt.Mask = "000.000.000-00";
            this.documentTxt.Name = "documentTxt";
            this.documentTxt.Size = new System.Drawing.Size(174, 22);
            this.documentTxt.TabIndex = 27;
            this.documentTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CEPMasked
            // 
            this.CEPMasked.BackColor = System.Drawing.Color.Lavender;
            this.CEPMasked.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.CEPMasked.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.CEPMasked.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Insert;
            this.CEPMasked.Location = new System.Drawing.Point(26, 291);
            this.CEPMasked.Mask = "00000-000";
            this.CEPMasked.Name = "CEPMasked";
            this.CEPMasked.Size = new System.Drawing.Size(126, 22);
            this.CEPMasked.TabIndex = 28;
            this.CEPMasked.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // telefoneTxt
            // 
            this.telefoneTxt.BackColor = System.Drawing.Color.Lavender;
            this.telefoneTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.telefoneTxt.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.telefoneTxt.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Insert;
            this.telefoneTxt.Location = new System.Drawing.Point(27, 227);
            this.telefoneTxt.Mask = "(99) 00000-0000";
            this.telefoneTxt.Name = "telefoneTxt";
            this.telefoneTxt.Size = new System.Drawing.Size(125, 22);
            this.telefoneTxt.TabIndex = 29;
            this.telefoneTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label3.Location = new System.Drawing.Point(354, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 20);
            this.label3.TabIndex = 31;
            this.label3.Text = "Buscar:";
            // 
            // buscartxt
            // 
            this.buscartxt.BackColor = System.Drawing.Color.Lavender;
            this.buscartxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buscartxt.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.buscartxt.Location = new System.Drawing.Point(358, 82);
            this.buscartxt.Name = "buscartxt";
            this.buscartxt.Size = new System.Drawing.Size(234, 22);
            this.buscartxt.TabIndex = 30;
            // 
            // buscar
            // 
            this.buscar.BackColor = System.Drawing.Color.OliveDrab;
            this.buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buscar.ForeColor = System.Drawing.Color.Azure;
            this.buscar.Location = new System.Drawing.Point(598, 82);
            this.buscar.Name = "buscar";
            this.buscar.Size = new System.Drawing.Size(70, 22);
            this.buscar.TabIndex = 32;
            this.buscar.Text = "BUSCAR";
            this.buscar.UseVisualStyleBackColor = false;
            this.buscar.Click += new System.EventHandler(this.buscar_Click);
            // 
            // CadastroForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(680, 437);
            this.Controls.Add(this.buscar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buscartxt);
            this.Controls.Add(this.telefoneTxt);
            this.Controls.Add(this.CEPMasked);
            this.Controls.Add(this.documentTxt);
            this.Controls.Add(this.viewButton);
            this.Controls.Add(this.alterarButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.cadastrarButton);
            this.Controls.Add(this.ImagemLogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.enderecoTxt);
            this.Controls.Add(this.EnderecoLabel);
            this.Controls.Add(this.EmailLabel);
            this.Controls.Add(this.emailTxt);
            this.Controls.Add(this.TelefoneLabel);
            this.Controls.Add(this.TipoCNPJ);
            this.Controls.Add(this.TipoCPF);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DocumentoLabel);
            this.Controls.Add(this.NomeLabel);
            this.Controls.Add(this.nomeTxt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CadastroForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro";
            this.Load += new System.EventHandler(this.Cadastro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ImagemLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaCadastroBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DocumentoLabel;
        private System.Windows.Forms.Label NomeLabel;
        private System.Windows.Forms.TextBox nomeTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton TipoCPF;
        private System.Windows.Forms.RadioButton TipoCNPJ;
        private System.Windows.Forms.Label TelefoneLabel;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.TextBox emailTxt;
        private System.Windows.Forms.Label EnderecoLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox enderecoTxt;
        private System.Windows.Forms.PictureBox ImagemLogin;
        private System.Windows.Forms.Button cadastrarButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button alterarButton;
        private System.Windows.Forms.Button viewButton;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private System.Windows.Forms.MaskedTextBox documentTxt;
        private System.Windows.Forms.MaskedTextBox CEPMasked;
        private System.Windows.Forms.MaskedTextBox telefoneTxt;
        private System.Windows.Forms.BindingSource tabelaCadastroBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn documentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn enderecoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox buscartxt;
        private System.Windows.Forms.Button buscar;
    }
}