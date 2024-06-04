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
            this.confirmPassword = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.voltarButton = new System.Windows.Forms.Button();
            this.newPassword = new System.Windows.Forms.Label();
            this.recuperacaoEmail = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ImagemLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // ImagemLogin
            // 
            this.ImagemLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ImagemLogin.Image = global::Desafio_Group.Properties.Resources.group;
            this.ImagemLogin.Location = new System.Drawing.Point(12, 29);
            this.ImagemLogin.Name = "ImagemLogin";
            this.ImagemLogin.Size = new System.Drawing.Size(410, 74);
            this.ImagemLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ImagemLogin.TabIndex = 12;
            this.ImagemLogin.TabStop = false;
            // 
            // verificarButton
            // 
            this.verificarButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.verificarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.verificarButton.ForeColor = System.Drawing.Color.Azure;
            this.verificarButton.Location = new System.Drawing.Point(178, 279);
            this.verificarButton.Name = "verificarButton";
            this.verificarButton.Size = new System.Drawing.Size(217, 33);
            this.verificarButton.TabIndex = 35;
            this.verificarButton.Text = "REDEFINIR";
            this.verificarButton.UseVisualStyleBackColor = false;
            // 
            // confirmPassword
            // 
            this.confirmPassword.AutoSize = true;
            this.confirmPassword.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmPassword.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.confirmPassword.Location = new System.Drawing.Point(44, 201);
            this.confirmPassword.Name = "confirmPassword";
            this.confirmPassword.Size = new System.Drawing.Size(266, 26);
            this.confirmPassword.TabIndex = 34;
            this.confirmPassword.Text = "Confirme nova senha:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.textBox1.Location = new System.Drawing.Point(49, 233);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(346, 22);
            this.textBox1.TabIndex = 33;
            // 
            // voltarButton
            // 
            this.voltarButton.BackColor = System.Drawing.Color.Maroon;
            this.voltarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.voltarButton.ForeColor = System.Drawing.Color.Azure;
            this.voltarButton.Location = new System.Drawing.Point(49, 279);
            this.voltarButton.Name = "voltarButton";
            this.voltarButton.Size = new System.Drawing.Size(123, 33);
            this.voltarButton.TabIndex = 32;
            this.voltarButton.Text = "VOLTAR";
            this.voltarButton.UseVisualStyleBackColor = false;
            this.voltarButton.Click += new System.EventHandler(this.voltarButton_Click);
            // 
            // newPassword
            // 
            this.newPassword.AutoSize = true;
            this.newPassword.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newPassword.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.newPassword.Location = new System.Drawing.Point(44, 130);
            this.newPassword.Name = "newPassword";
            this.newPassword.Size = new System.Drawing.Size(157, 26);
            this.newPassword.TabIndex = 30;
            this.newPassword.Text = "Nova senha:";
            // 
            // recuperacaoEmail
            // 
            this.recuperacaoEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recuperacaoEmail.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.recuperacaoEmail.Location = new System.Drawing.Point(49, 162);
            this.recuperacaoEmail.Name = "recuperacaoEmail";
            this.recuperacaoEmail.Size = new System.Drawing.Size(346, 22);
            this.recuperacaoEmail.TabIndex = 29;
            // 
            // RedefinirSenhaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(434, 361);
            this.Controls.Add(this.verificarButton);
            this.Controls.Add(this.confirmPassword);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.voltarButton);
            this.Controls.Add(this.newPassword);
            this.Controls.Add(this.recuperacaoEmail);
            this.Controls.Add(this.ImagemLogin);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RedefinirSenhaForm";
            this.Text = "Nova Senha";
            ((System.ComponentModel.ISupportInitialize)(this.ImagemLogin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ImagemLogin;
        private System.Windows.Forms.Button verificarButton;
        private System.Windows.Forms.Label confirmPassword;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button voltarButton;
        private System.Windows.Forms.Label newPassword;
        private System.Windows.Forms.TextBox recuperacaoEmail;
    }
}