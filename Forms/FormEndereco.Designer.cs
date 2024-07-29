namespace Desafio_Group.Forms
{
    partial class FormEndereco
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
            this.Close = new System.Windows.Forms.Button();
            this.ImagemLogin = new System.Windows.Forms.PictureBox();
            this.LogradouroLabel = new System.Windows.Forms.Label();
            this.logradourotxt = new System.Windows.Forms.TextBox();
            this.ComplementoLabel = new System.Windows.Forms.Label();
            this.complementotxt = new System.Windows.Forms.TextBox();
            this.BairroLabel = new System.Windows.Forms.Label();
            this.bairrotxt = new System.Windows.Forms.TextBox();
            this.LocalidadeLabel = new System.Windows.Forms.Label();
            this.localidadetxt = new System.Windows.Forms.TextBox();
            this.UfLabel = new System.Windows.Forms.Label();
            this.uftxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numerotxt = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.buscarCEP = new System.Windows.Forms.Button();
            this.CEPMasked = new System.Windows.Forms.MaskedTextBox();
            this.EnderecoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ImagemLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // Close
            // 
            this.Close.BackColor = System.Drawing.Color.Firebrick;
            this.Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Close.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Close.Location = new System.Drawing.Point(324, 12);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(51, 23);
            this.Close.TabIndex = 19;
            this.Close.Text = "SAIR";
            this.Close.UseVisualStyleBackColor = false;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // ImagemLogin
            // 
            this.ImagemLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ImagemLogin.Image = global::Desafio_Group.Properties.Resources.group;
            this.ImagemLogin.Location = new System.Drawing.Point(12, 41);
            this.ImagemLogin.Name = "ImagemLogin";
            this.ImagemLogin.Size = new System.Drawing.Size(363, 37);
            this.ImagemLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ImagemLogin.TabIndex = 22;
            this.ImagemLogin.TabStop = false;
            // 
            // LogradouroLabel
            // 
            this.LogradouroLabel.AutoSize = true;
            this.LogradouroLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogradouroLabel.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.LogradouroLabel.Location = new System.Drawing.Point(35, 168);
            this.LogradouroLabel.Name = "LogradouroLabel";
            this.LogradouroLabel.Size = new System.Drawing.Size(118, 20);
            this.LogradouroLabel.TabIndex = 24;
            this.LogradouroLabel.Text = "Logradouro:";
            // 
            // logradourotxt
            // 
            this.logradourotxt.BackColor = System.Drawing.Color.Lavender;
            this.logradourotxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logradourotxt.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.logradourotxt.Location = new System.Drawing.Point(39, 191);
            this.logradourotxt.Name = "logradourotxt";
            this.logradourotxt.ReadOnly = true;
            this.logradourotxt.Size = new System.Drawing.Size(309, 22);
            this.logradourotxt.TabIndex = 0;
            // 
            // ComplementoLabel
            // 
            this.ComplementoLabel.AutoSize = true;
            this.ComplementoLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComplementoLabel.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.ComplementoLabel.Location = new System.Drawing.Point(35, 230);
            this.ComplementoLabel.Name = "ComplementoLabel";
            this.ComplementoLabel.Size = new System.Drawing.Size(141, 20);
            this.ComplementoLabel.TabIndex = 26;
            this.ComplementoLabel.Text = "Complemento:";
            // 
            // complementotxt
            // 
            this.complementotxt.BackColor = System.Drawing.Color.Lavender;
            this.complementotxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.complementotxt.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.complementotxt.Location = new System.Drawing.Point(39, 253);
            this.complementotxt.Name = "complementotxt";
            this.complementotxt.Size = new System.Drawing.Size(196, 22);
            this.complementotxt.TabIndex = 1;
            // 
            // BairroLabel
            // 
            this.BairroLabel.AutoSize = true;
            this.BairroLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BairroLabel.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.BairroLabel.Location = new System.Drawing.Point(39, 292);
            this.BairroLabel.Name = "BairroLabel";
            this.BairroLabel.Size = new System.Drawing.Size(71, 20);
            this.BairroLabel.TabIndex = 28;
            this.BairroLabel.Text = "Bairro:";
            // 
            // bairrotxt
            // 
            this.bairrotxt.BackColor = System.Drawing.Color.Lavender;
            this.bairrotxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bairrotxt.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.bairrotxt.Location = new System.Drawing.Point(43, 315);
            this.bairrotxt.Name = "bairrotxt";
            this.bairrotxt.Size = new System.Drawing.Size(185, 22);
            this.bairrotxt.TabIndex = 3;
            // 
            // LocalidadeLabel
            // 
            this.LocalidadeLabel.AutoSize = true;
            this.LocalidadeLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LocalidadeLabel.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.LocalidadeLabel.Location = new System.Drawing.Point(39, 359);
            this.LocalidadeLabel.Name = "LocalidadeLabel";
            this.LocalidadeLabel.Size = new System.Drawing.Size(114, 20);
            this.LocalidadeLabel.TabIndex = 30;
            this.LocalidadeLabel.Text = "Localidade:";
            // 
            // localidadetxt
            // 
            this.localidadetxt.BackColor = System.Drawing.Color.Lavender;
            this.localidadetxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.localidadetxt.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.localidadetxt.Location = new System.Drawing.Point(43, 382);
            this.localidadetxt.Name = "localidadetxt";
            this.localidadetxt.ReadOnly = true;
            this.localidadetxt.Size = new System.Drawing.Size(196, 22);
            this.localidadetxt.TabIndex = 4;
            // 
            // UfLabel
            // 
            this.UfLabel.AutoSize = true;
            this.UfLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UfLabel.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.UfLabel.Location = new System.Drawing.Point(266, 359);
            this.UfLabel.Name = "UfLabel";
            this.UfLabel.Size = new System.Drawing.Size(40, 20);
            this.UfLabel.TabIndex = 32;
            this.UfLabel.Text = "UF:";
            // 
            // uftxt
            // 
            this.uftxt.BackColor = System.Drawing.Color.Lavender;
            this.uftxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uftxt.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.uftxt.Location = new System.Drawing.Point(270, 382);
            this.uftxt.Name = "uftxt";
            this.uftxt.ReadOnly = true;
            this.uftxt.Size = new System.Drawing.Size(67, 22);
            this.uftxt.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(262, 230);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 34;
            this.label1.Text = "Número:";
            // 
            // numerotxt
            // 
            this.numerotxt.BackColor = System.Drawing.Color.Lavender;
            this.numerotxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numerotxt.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.numerotxt.Location = new System.Drawing.Point(266, 253);
            this.numerotxt.Name = "numerotxt";
            this.numerotxt.Size = new System.Drawing.Size(82, 22);
            this.numerotxt.TabIndex = 2;
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.ForeColor = System.Drawing.Color.Azure;
            this.btnSalvar.Location = new System.Drawing.Point(145, 423);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(95, 33);
            this.btnSalvar.TabIndex = 35;
            this.btnSalvar.Text = "SALVAR";
            this.btnSalvar.UseVisualStyleBackColor = false;
            // 
            // buscarCEP
            // 
            this.buscarCEP.BackColor = System.Drawing.Color.OliveDrab;
            this.buscarCEP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buscarCEP.ForeColor = System.Drawing.Color.Azure;
            this.buscarCEP.Location = new System.Drawing.Point(175, 128);
            this.buscarCEP.Name = "buscarCEP";
            this.buscarCEP.Size = new System.Drawing.Size(173, 22);
            this.buscarCEP.TabIndex = 37;
            this.buscarCEP.Text = "BUSCAR CEP";
            this.buscarCEP.UseVisualStyleBackColor = false;
            this.buscarCEP.Click += new System.EventHandler(this.buscarCEP_Click);
            // 
            // CEPMasked
            // 
            this.CEPMasked.BackColor = System.Drawing.Color.Lavender;
            this.CEPMasked.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.CEPMasked.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.CEPMasked.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Insert;
            this.CEPMasked.Location = new System.Drawing.Point(39, 126);
            this.CEPMasked.Mask = "00000-000";
            this.CEPMasked.Name = "CEPMasked";
            this.CEPMasked.Size = new System.Drawing.Size(126, 22);
            this.CEPMasked.TabIndex = 36;
            this.CEPMasked.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CEPMasked.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePrompt;
            // 
            // EnderecoLabel
            // 
            this.EnderecoLabel.AutoSize = true;
            this.EnderecoLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnderecoLabel.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.EnderecoLabel.Location = new System.Drawing.Point(36, 103);
            this.EnderecoLabel.Name = "EnderecoLabel";
            this.EnderecoLabel.Size = new System.Drawing.Size(51, 20);
            this.EnderecoLabel.TabIndex = 38;
            this.EnderecoLabel.Text = "CEP:";
            // 
            // FormEndereco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(387, 477);
            this.Controls.Add(this.buscarCEP);
            this.Controls.Add(this.CEPMasked);
            this.Controls.Add(this.EnderecoLabel);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numerotxt);
            this.Controls.Add(this.UfLabel);
            this.Controls.Add(this.uftxt);
            this.Controls.Add(this.LocalidadeLabel);
            this.Controls.Add(this.localidadetxt);
            this.Controls.Add(this.BairroLabel);
            this.Controls.Add(this.bairrotxt);
            this.Controls.Add(this.ComplementoLabel);
            this.Controls.Add(this.complementotxt);
            this.Controls.Add(this.LogradouroLabel);
            this.Controls.Add(this.logradourotxt);
            this.Controls.Add(this.ImagemLogin);
            this.Controls.Add(this.Close);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormEndereco";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Endereco";
            ((System.ComponentModel.ISupportInitialize)(this.ImagemLogin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.PictureBox ImagemLogin;
        private System.Windows.Forms.Label LogradouroLabel;
        private System.Windows.Forms.TextBox logradourotxt;
        private System.Windows.Forms.Label ComplementoLabel;
        private System.Windows.Forms.TextBox complementotxt;
        private System.Windows.Forms.Label BairroLabel;
        private System.Windows.Forms.TextBox bairrotxt;
        private System.Windows.Forms.Label LocalidadeLabel;
        private System.Windows.Forms.TextBox localidadetxt;
        private System.Windows.Forms.Label UfLabel;
        private System.Windows.Forms.TextBox uftxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox numerotxt;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button buscarCEP;
        private System.Windows.Forms.MaskedTextBox CEPMasked;
        private System.Windows.Forms.Label EnderecoLabel;
    }
}