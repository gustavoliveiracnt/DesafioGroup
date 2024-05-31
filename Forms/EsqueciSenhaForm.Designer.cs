namespace Desafio_Group.Forms
{
    partial class EsqueciSenhaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EsqueciSenhaForm));
            this.Password = new System.Windows.Forms.Label();
            this.senha = new System.Windows.Forms.TextBox();
            this.User = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ImagemLogin = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ImagemLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.Password.Location = new System.Drawing.Point(43, 195);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(94, 26);
            this.Password.TabIndex = 9;
            this.Password.Text = "Senha:";
            // 
            // senha
            // 
            this.senha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.senha.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.senha.Location = new System.Drawing.Point(48, 227);
            this.senha.Name = "senha";
            this.senha.PasswordChar = '*';
            this.senha.Size = new System.Drawing.Size(174, 22);
            this.senha.TabIndex = 8;
            // 
            // User
            // 
            this.User.AutoSize = true;
            this.User.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.User.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.User.Location = new System.Drawing.Point(43, 130);
            this.User.Name = "User";
            this.User.Size = new System.Drawing.Size(110, 26);
            this.User.TabIndex = 7;
            this.User.Text = "Usuário:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.textBox1.Location = new System.Drawing.Point(48, 162);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(346, 22);
            this.textBox1.TabIndex = 6;
            // 
            // ImagemLogin
            // 
            this.ImagemLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ImagemLogin.Image = global::Desafio_Group.Properties.Resources.group;
            this.ImagemLogin.Location = new System.Drawing.Point(12, 28);
            this.ImagemLogin.Name = "ImagemLogin";
            this.ImagemLogin.Size = new System.Drawing.Size(410, 74);
            this.ImagemLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ImagemLogin.TabIndex = 10;
            this.ImagemLogin.TabStop = false;
            // 
            // EsqueciSenhaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(434, 311);
            this.Controls.Add(this.ImagemLogin);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.senha);
            this.Controls.Add(this.User);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EsqueciSenhaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Esqueci a Senha";
            ((System.ComponentModel.ISupportInitialize)(this.ImagemLogin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.TextBox senha;
        private System.Windows.Forms.Label User;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox ImagemLogin;
    }
}