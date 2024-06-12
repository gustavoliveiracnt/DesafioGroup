namespace Desafio_Group.Forms
{
    partial class RedefinirSenhaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RedefinirSenhaForm));
            this.ImagemLogin = new System.Windows.Forms.PictureBox();
            this.verificarButton = new System.Windows.Forms.Button();
            this.voltarButton = new System.Windows.Forms.Button();
            this.newPassword = new System.Windows.Forms.Label();
            this.novaSenha = new System.Windows.Forms.TextBox();
            this.mostrar_novaSenha = new System.Windows.Forms.CheckBox();
            this.confirmacaoSenha = new System.Windows.Forms.TextBox();
            this.confirmPassword = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ImagemLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // ImagemLogin
            // 
            this.ImagemLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ImagemLogin.Image = global::Desafio_Group.Properties.Resources.group;
            this.ImagemLogin.Location = new System.Drawing.Point(12, 43);
            this.ImagemLogin.Name = "ImagemLogin";
            this.ImagemLogin.Size = new System.Drawing.Size(510, 74);
            this.ImagemLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ImagemLogin.TabIndex = 12;
            this.ImagemLogin.TabStop = false;
            // 
            // verificarButton
            // 
            this.verificarButton.BackColor = System.Drawing.Color.DarkSlateGray;
            this.verificarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.verificarButton.ForeColor = System.Drawing.Color.Azure;
            this.verificarButton.Location = new System.Drawing.Point(219, 257);
            this.verificarButton.Name = "verificarButton";
            this.verificarButton.Size = new System.Drawing.Size(292, 33);
            this.verificarButton.TabIndex = 35;
            this.verificarButton.Text = "REDEFINIR";
            this.verificarButton.UseVisualStyleBackColor = false;
            this.verificarButton.Click += new System.EventHandler(this.verificarButton_Click);
            // 
            // voltarButton
            // 
            this.voltarButton.BackColor = System.Drawing.Color.Maroon;
            this.voltarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.voltarButton.ForeColor = System.Drawing.Color.Azure;
            this.voltarButton.Location = new System.Drawing.Point(17, 257);
            this.voltarButton.Name = "voltarButton";
            this.voltarButton.Size = new System.Drawing.Size(170, 33);
            this.voltarButton.TabIndex = 32;
            this.voltarButton.Text = "VOLTAR";
            this.voltarButton.UseVisualStyleBackColor = false;
            this.voltarButton.Click += new System.EventHandler(this.voltarButton_Click);
            // 
            // newPassword
            // 
            this.newPassword.AutoSize = true;
            this.newPassword.Font = new System.Drawing.Font("MS Reference Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newPassword.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.newPassword.Location = new System.Drawing.Point(12, 140);
            this.newPassword.Name = "newPassword";
            this.newPassword.Size = new System.Drawing.Size(175, 29);
            this.newPassword.TabIndex = 30;
            this.newPassword.Text = "Nova senha:";
            // 
            // novaSenha
            // 
            this.novaSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.novaSenha.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.novaSenha.Location = new System.Drawing.Point(17, 181);
            this.novaSenha.Name = "novaSenha";
            this.novaSenha.PasswordChar = '*';
            this.novaSenha.Size = new System.Drawing.Size(170, 22);
            this.novaSenha.TabIndex = 29;
            // 
            // mostrar_novaSenha
            // 
            this.mostrar_novaSenha.AutoSize = true;
            this.mostrar_novaSenha.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.mostrar_novaSenha.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.mostrar_novaSenha.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.mostrar_novaSenha.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.mostrar_novaSenha.Location = new System.Drawing.Point(17, 214);
            this.mostrar_novaSenha.Name = "mostrar_novaSenha";
            this.mostrar_novaSenha.Size = new System.Drawing.Size(157, 23);
            this.mostrar_novaSenha.TabIndex = 36;
            this.mostrar_novaSenha.Text = "Mostrar senhas";
            this.mostrar_novaSenha.UseVisualStyleBackColor = false;
            this.mostrar_novaSenha.CheckedChanged += new System.EventHandler(this.mostrar_novaSenha_CheckedChanged);
            // 
            // confirmacaoSenha
            // 
            this.confirmacaoSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmacaoSenha.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.confirmacaoSenha.Location = new System.Drawing.Point(219, 181);
            this.confirmacaoSenha.Name = "confirmacaoSenha";
            this.confirmacaoSenha.PasswordChar = '*';
            this.confirmacaoSenha.Size = new System.Drawing.Size(170, 22);
            this.confirmacaoSenha.TabIndex = 33;
            // 
            // confirmPassword
            // 
            this.confirmPassword.AutoSize = true;
            this.confirmPassword.Font = new System.Drawing.Font("MS Reference Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmPassword.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.confirmPassword.Location = new System.Drawing.Point(214, 140);
            this.confirmPassword.Name = "confirmPassword";
            this.confirmPassword.Size = new System.Drawing.Size(297, 29);
            this.confirmPassword.TabIndex = 34;
            this.confirmPassword.Text = "Confirme nova senha:";
            // 
            // RedefinirSenhaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(534, 320);
            this.Controls.Add(this.mostrar_novaSenha);
            this.Controls.Add(this.verificarButton);
            this.Controls.Add(this.confirmPassword);
            this.Controls.Add(this.confirmacaoSenha);
            this.Controls.Add(this.voltarButton);
            this.Controls.Add(this.newPassword);
            this.Controls.Add(this.novaSenha);
            this.Controls.Add(this.ImagemLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RedefinirSenhaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nova Senha";
            ((System.ComponentModel.ISupportInitialize)(this.ImagemLogin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ImagemLogin;
        private System.Windows.Forms.Button verificarButton;
        private System.Windows.Forms.Button voltarButton;
        private System.Windows.Forms.Label newPassword;
        private System.Windows.Forms.TextBox novaSenha;
        private System.Windows.Forms.CheckBox mostrar_novaSenha;
        private System.Windows.Forms.TextBox confirmacaoSenha;
        private System.Windows.Forms.Label confirmPassword;
    }
}