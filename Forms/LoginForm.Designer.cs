﻿namespace Desafio_Group
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.label1 = new System.Windows.Forms.Label();
            this.usuarioTxt = new System.Windows.Forms.TextBox();
            this.User = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.Label();
            this.senhaTxt = new System.Windows.Forms.TextBox();
            this.ShowPass = new System.Windows.Forms.CheckBox();
            this.loginButton = new System.Windows.Forms.Button();
            this.EsqueciSenha = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.ImagemLogin = new System.Windows.Forms.PictureBox();
            this.Close = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ImagemLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(148, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(361, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bem-vindos ao Group Cad!";
            // 
            // usuarioTxt
            // 
            this.usuarioTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usuarioTxt.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.usuarioTxt.Location = new System.Drawing.Point(153, 234);
            this.usuarioTxt.Name = "usuarioTxt";
            this.usuarioTxt.Size = new System.Drawing.Size(346, 22);
            this.usuarioTxt.TabIndex = 2;
            // 
            // User
            // 
            this.User.AutoSize = true;
            this.User.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.User.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.User.Location = new System.Drawing.Point(148, 202);
            this.User.Name = "User";
            this.User.Size = new System.Drawing.Size(110, 26);
            this.User.TabIndex = 3;
            this.User.Text = "Usuário:";
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.Password.Location = new System.Drawing.Point(148, 267);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(94, 26);
            this.Password.TabIndex = 5;
            this.Password.Text = "Senha:";
            // 
            // senhaTxt
            // 
            this.senhaTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.senhaTxt.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.senhaTxt.Location = new System.Drawing.Point(153, 299);
            this.senhaTxt.Name = "senhaTxt";
            this.senhaTxt.PasswordChar = '*';
            this.senhaTxt.Size = new System.Drawing.Size(174, 22);
            this.senhaTxt.TabIndex = 4;
            // 
            // ShowPass
            // 
            this.ShowPass.AutoSize = true;
            this.ShowPass.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowPass.ForeColor = System.Drawing.Color.LightSlateGray;
            this.ShowPass.Location = new System.Drawing.Point(342, 295);
            this.ShowPass.Name = "ShowPass";
            this.ShowPass.Size = new System.Drawing.Size(148, 23);
            this.ShowPass.TabIndex = 6;
            this.ShowPass.Text = "Mostrar senha";
            this.ShowPass.UseVisualStyleBackColor = true;
            this.ShowPass.CheckedChanged += new System.EventHandler(this.ShowPass_CheckedChanged);
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.Color.DarkSlateGray;
            this.loginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButton.ForeColor = System.Drawing.Color.Azure;
            this.loginButton.Location = new System.Drawing.Point(153, 336);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(346, 33);
            this.loginButton.TabIndex = 7;
            this.loginButton.Text = "LOGIN";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // EsqueciSenha
            // 
            this.EsqueciSenha.AutoSize = true;
            this.EsqueciSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.EsqueciSenha.Location = new System.Drawing.Point(272, 375);
            this.EsqueciSenha.Name = "EsqueciSenha";
            this.EsqueciSenha.Size = new System.Drawing.Size(107, 16);
            this.EsqueciSenha.TabIndex = 8;
            this.EsqueciSenha.TabStop = true;
            this.EsqueciSenha.Text = "Esqueci a senha";
            this.EsqueciSenha.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.EsqueciSenha_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(169, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(312, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Insira dados abaixo para acessar o programa";
            // 
            // ImagemLogin
            // 
            this.ImagemLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ImagemLogin.Image = global::Desafio_Group.Properties.Resources.group;
            this.ImagemLogin.Location = new System.Drawing.Point(12, 43);
            this.ImagemLogin.Name = "ImagemLogin";
            this.ImagemLogin.Size = new System.Drawing.Size(610, 85);
            this.ImagemLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ImagemLogin.TabIndex = 0;
            this.ImagemLogin.TabStop = false;
            // 
            // Close
            // 
            this.Close.BackColor = System.Drawing.Color.Firebrick;
            this.Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Close.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Close.Location = new System.Drawing.Point(571, 12);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(51, 23);
            this.Close.TabIndex = 41;
            this.Close.Text = "SAIR";
            this.Close.UseVisualStyleBackColor = false;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(634, 420);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.EsqueciSenha);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.ShowPass);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.senhaTxt);
            this.Controls.Add(this.User);
            this.Controls.Add(this.usuarioTxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ImagemLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.ImagemLogin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ImagemLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox usuarioTxt;
        private System.Windows.Forms.Label User;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.TextBox senhaTxt;
        private System.Windows.Forms.CheckBox ShowPass;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.LinkLabel EsqueciSenha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Close;
    }
}

