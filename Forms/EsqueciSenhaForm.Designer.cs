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
            this.User = new System.Windows.Forms.Label();
            this.recuperacaoEmail = new System.Windows.Forms.TextBox();
            this.enviarTokenButton = new System.Windows.Forms.Button();
            this.ImagemLogin = new System.Windows.Forms.PictureBox();
            this.voltarButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tokenTxt = new System.Windows.Forms.TextBox();
            this.verificarButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ImagemLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // User
            // 
            this.User.AutoSize = true;
            this.User.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.User.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.User.Location = new System.Drawing.Point(30, 99);
            this.User.Name = "User";
            this.User.Size = new System.Drawing.Size(105, 26);
            this.User.TabIndex = 7;
            this.User.Text = "E-mail: ";
            // 
            // recuperacaoEmail
            // 
            this.recuperacaoEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recuperacaoEmail.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.recuperacaoEmail.Location = new System.Drawing.Point(35, 131);
            this.recuperacaoEmail.Name = "recuperacaoEmail";
            this.recuperacaoEmail.Size = new System.Drawing.Size(346, 22);
            this.recuperacaoEmail.TabIndex = 6;
            // 
            // enviarTokenButton
            // 
            this.enviarTokenButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.enviarTokenButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enviarTokenButton.ForeColor = System.Drawing.Color.Azure;
            this.enviarTokenButton.Location = new System.Drawing.Point(35, 169);
            this.enviarTokenButton.Name = "enviarTokenButton";
            this.enviarTokenButton.Size = new System.Drawing.Size(346, 33);
            this.enviarTokenButton.TabIndex = 23;
            this.enviarTokenButton.Text = "ENVIAR TOKEN";
            this.enviarTokenButton.UseVisualStyleBackColor = false;
            this.enviarTokenButton.Click += new System.EventHandler(this.enviarTokenButton_Click);
            // 
            // ImagemLogin
            // 
            this.ImagemLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ImagemLogin.Image = global::Desafio_Group.Properties.Resources.group;
            this.ImagemLogin.Location = new System.Drawing.Point(12, 18);
            this.ImagemLogin.Name = "ImagemLogin";
            this.ImagemLogin.Size = new System.Drawing.Size(410, 64);
            this.ImagemLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ImagemLogin.TabIndex = 10;
            this.ImagemLogin.TabStop = false;
            // 
            // voltarButton
            // 
            this.voltarButton.BackColor = System.Drawing.Color.Maroon;
            this.voltarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.voltarButton.ForeColor = System.Drawing.Color.Azure;
            this.voltarButton.Location = new System.Drawing.Point(35, 295);
            this.voltarButton.Name = "voltarButton";
            this.voltarButton.Size = new System.Drawing.Size(123, 33);
            this.voltarButton.TabIndex = 24;
            this.voltarButton.Text = "VOLTAR";
            this.voltarButton.UseVisualStyleBackColor = false;
            this.voltarButton.Click += new System.EventHandler(this.voltarButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(30, 217);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 26);
            this.label1.TabIndex = 27;
            this.label1.Text = "Token:";
            // 
            // tokenTxt
            // 
            this.tokenTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tokenTxt.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.tokenTxt.Location = new System.Drawing.Point(35, 249);
            this.tokenTxt.Name = "tokenTxt";
            this.tokenTxt.Size = new System.Drawing.Size(346, 22);
            this.tokenTxt.TabIndex = 26;
            // 
            // verificarButton
            // 
            this.verificarButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.verificarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.verificarButton.ForeColor = System.Drawing.Color.Azure;
            this.verificarButton.Location = new System.Drawing.Point(164, 295);
            this.verificarButton.Name = "verificarButton";
            this.verificarButton.Size = new System.Drawing.Size(217, 33);
            this.verificarButton.TabIndex = 28;
            this.verificarButton.Text = "VERIFICAR";
            this.verificarButton.UseVisualStyleBackColor = false;
            this.verificarButton.Click += new System.EventHandler(this.verificarButton_Click);
            // 
            // EsqueciSenhaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(434, 361);
            this.Controls.Add(this.verificarButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tokenTxt);
            this.Controls.Add(this.voltarButton);
            this.Controls.Add(this.enviarTokenButton);
            this.Controls.Add(this.ImagemLogin);
            this.Controls.Add(this.User);
            this.Controls.Add(this.recuperacaoEmail);
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
        private System.Windows.Forms.Label User;
        private System.Windows.Forms.TextBox recuperacaoEmail;
        private System.Windows.Forms.PictureBox ImagemLogin;
        private System.Windows.Forms.Button enviarTokenButton;
        private System.Windows.Forms.Button voltarButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tokenTxt;
        private System.Windows.Forms.Button verificarButton;
    }
}