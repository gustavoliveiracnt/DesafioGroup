namespace Desafio_Group.Forms
{
    partial class Cadastro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cadastro));
            this.DocumentoLabel = new System.Windows.Forms.Label();
            this.NomeLabel = new System.Windows.Forms.Label();
            this.Nome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TipoCPF = new System.Windows.Forms.RadioButton();
            this.TipoCNPJ = new System.Windows.Forms.RadioButton();
            this.TelefoneLabel = new System.Windows.Forms.Label();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.EnderecoLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.ImagemLogin = new System.Windows.Forms.PictureBox();
            this.CadastrarButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.DocumentTxt = new System.Windows.Forms.MaskedTextBox();
            this.CEPMasked = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ImagemLogin)).BeginInit();
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
            // Nome
            // 
            this.Nome.BackColor = System.Drawing.Color.Lavender;
            this.Nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nome.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.Nome.Location = new System.Drawing.Point(26, 82);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(310, 22);
            this.Nome.TabIndex = 6;
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
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.Lavender;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.textBox2.Location = new System.Drawing.Point(162, 227);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(174, 22);
            this.textBox2.TabIndex = 15;
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
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.Lavender;
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.textBox4.Location = new System.Drawing.Point(162, 291);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(174, 22);
            this.textBox4.TabIndex = 19;
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
            // CadastrarButton
            // 
            this.CadastrarButton.BackColor = System.Drawing.Color.DarkSlateGray;
            this.CadastrarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CadastrarButton.ForeColor = System.Drawing.Color.Azure;
            this.CadastrarButton.Location = new System.Drawing.Point(26, 334);
            this.CadastrarButton.Name = "CadastrarButton";
            this.CadastrarButton.Size = new System.Drawing.Size(310, 33);
            this.CadastrarButton.TabIndex = 22;
            this.CadastrarButton.Text = "CADASTRAR";
            this.CadastrarButton.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkRed;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Azure;
            this.button1.Location = new System.Drawing.Point(26, 376);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 22);
            this.button1.TabIndex = 23;
            this.button1.Text = "DELETAR";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkCyan;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Azure;
            this.button2.Location = new System.Drawing.Point(136, 376);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(81, 22);
            this.button2.TabIndex = 24;
            this.button2.Text = "ALTERAR";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Goldenrod;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Azure;
            this.button3.Location = new System.Drawing.Point(223, 376);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(113, 22);
            this.button3.TabIndex = 25;
            this.button3.Text = "VISUZALIZAR";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // DocumentTxt
            // 
            this.DocumentTxt.BackColor = System.Drawing.Color.Lavender;
            this.DocumentTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.DocumentTxt.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.DocumentTxt.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Insert;
            this.DocumentTxt.Location = new System.Drawing.Point(162, 160);
            this.DocumentTxt.Mask = "000.000.000-00";
            this.DocumentTxt.Name = "DocumentTxt";
            this.DocumentTxt.Size = new System.Drawing.Size(174, 22);
            this.DocumentTxt.TabIndex = 27;
            this.DocumentTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            // maskedTextBox1
            // 
            this.maskedTextBox1.BackColor = System.Drawing.Color.Lavender;
            this.maskedTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.maskedTextBox1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.maskedTextBox1.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Insert;
            this.maskedTextBox1.Location = new System.Drawing.Point(27, 227);
            this.maskedTextBox1.Mask = "(99) 00000-0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(125, 22);
            this.maskedTextBox1.TabIndex = 29;
            this.maskedTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(680, 437);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.CEPMasked);
            this.Controls.Add(this.DocumentTxt);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CadastrarButton);
            this.Controls.Add(this.ImagemLogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.EnderecoLabel);
            this.Controls.Add(this.EmailLabel);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.TelefoneLabel);
            this.Controls.Add(this.TipoCNPJ);
            this.Controls.Add(this.TipoCPF);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DocumentoLabel);
            this.Controls.Add(this.NomeLabel);
            this.Controls.Add(this.Nome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Cadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro";
            this.Load += new System.EventHandler(this.Cadastro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ImagemLogin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DocumentoLabel;
        private System.Windows.Forms.Label NomeLabel;
        private System.Windows.Forms.TextBox Nome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton TipoCPF;
        private System.Windows.Forms.RadioButton TipoCNPJ;
        private System.Windows.Forms.Label TelefoneLabel;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label EnderecoLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.PictureBox ImagemLogin;
        private System.Windows.Forms.Button CadastrarButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private System.Windows.Forms.MaskedTextBox DocumentTxt;
        private System.Windows.Forms.MaskedTextBox CEPMasked;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
    }
}