
namespace HoraDoRemedio
{
    partial class FormSignUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSignUp));
            this.btReturnLogin = new System.Windows.Forms.Button();
            this.btConfirmSignUp = new System.Windows.Forms.Button();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbUser = new System.Windows.Forms.TextBox();
            this.pictureLogo = new System.Windows.Forms.PictureBox();
            this.lbSignUp = new System.Windows.Forms.Label();
            this.lbPassword = new System.Windows.Forms.Label();
            this.lbUser = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // btReturnLogin
            // 
            this.btReturnLogin.BackColor = System.Drawing.Color.White;
            this.btReturnLogin.Font = new System.Drawing.Font("KoHo", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btReturnLogin.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btReturnLogin.Location = new System.Drawing.Point(293, 280);
            this.btReturnLogin.Name = "btReturnLogin";
            this.btReturnLogin.Size = new System.Drawing.Size(174, 29);
            this.btReturnLogin.TabIndex = 5;
            this.btReturnLogin.Text = "Voltar";
            this.btReturnLogin.UseVisualStyleBackColor = false;
            this.btReturnLogin.Click += new System.EventHandler(this.btReturnLogin_Click);
            // 
            // btConfirmSignUp
            // 
            this.btConfirmSignUp.BackColor = System.Drawing.Color.White;
            this.btConfirmSignUp.Font = new System.Drawing.Font("KoHo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btConfirmSignUp.Location = new System.Drawing.Point(293, 244);
            this.btConfirmSignUp.Name = "btConfirmSignUp";
            this.btConfirmSignUp.Size = new System.Drawing.Size(174, 30);
            this.btConfirmSignUp.TabIndex = 4;
            this.btConfirmSignUp.Text = "Cadastrar";
            this.btConfirmSignUp.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btConfirmSignUp.UseVisualStyleBackColor = false;
            this.btConfirmSignUp.Click += new System.EventHandler(this.btConfirmSignUp_Click);
            // 
            // tbPassword
            // 
            this.tbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPassword.Location = new System.Drawing.Point(293, 200);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(174, 26);
            this.tbPassword.TabIndex = 3;
            // 
            // tbUser
            // 
            this.tbUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUser.Location = new System.Drawing.Point(293, 136);
            this.tbUser.Name = "tbUser";
            this.tbUser.Size = new System.Drawing.Size(174, 26);
            this.tbUser.TabIndex = 1;
            this.tbUser.TextChanged += new System.EventHandler(this.tbUserSignUp_TextChanged);
            // 
            // pictureLogo
            // 
            this.pictureLogo.BackColor = System.Drawing.Color.Transparent;
            this.pictureLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureLogo.Image")));
            this.pictureLogo.Location = new System.Drawing.Point(12, 12);
            this.pictureLogo.Name = "pictureLogo";
            this.pictureLogo.Size = new System.Drawing.Size(150, 150);
            this.pictureLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureLogo.TabIndex = 9;
            this.pictureLogo.TabStop = false;
            this.pictureLogo.Click += new System.EventHandler(this.pictureLogo_Click);
            // 
            // lbSignUp
            // 
            this.lbSignUp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbSignUp.AutoSize = true;
            this.lbSignUp.BackColor = System.Drawing.Color.Transparent;
            this.lbSignUp.Font = new System.Drawing.Font("KoHo", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSignUp.Location = new System.Drawing.Point(256, 12);
            this.lbSignUp.Name = "lbSignUp";
            this.lbSignUp.Size = new System.Drawing.Size(226, 80);
            this.lbSignUp.TabIndex = 8;
            this.lbSignUp.Text = "Cadastro";
            this.lbSignUp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbPassword
            // 
            this.lbPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbPassword.AutoSize = true;
            this.lbPassword.BackColor = System.Drawing.Color.Transparent;
            this.lbPassword.Font = new System.Drawing.Font("KoHo", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPassword.Location = new System.Drawing.Point(208, 194);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(79, 35);
            this.lbPassword.TabIndex = 15;
            this.lbPassword.Text = "Senha:";
            this.lbPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbUser
            // 
            this.lbUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbUser.AutoSize = true;
            this.lbUser.BackColor = System.Drawing.Color.Transparent;
            this.lbUser.Font = new System.Drawing.Font("KoHo", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUser.Location = new System.Drawing.Point(193, 130);
            this.lbUser.Name = "lbUser";
            this.lbUser.Size = new System.Drawing.Size(94, 35);
            this.lbUser.TabIndex = 14;
            this.lbUser.Text = "Usuário:";
            this.lbUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbName
            // 
            this.lbName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbName.AutoSize = true;
            this.lbName.BackColor = System.Drawing.Color.Transparent;
            this.lbName.Font = new System.Drawing.Font("KoHo", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(213, 162);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(74, 35);
            this.lbName.TabIndex = 17;
            this.lbName.Text = "Nome:";
            this.lbName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbName
            // 
            this.tbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbName.Location = new System.Drawing.Point(293, 168);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(174, 26);
            this.tbName.TabIndex = 2;
            // 
            // FormSignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::HoraDoRemedio.Properties.Resources.BackGroundFeito;
            this.ClientSize = new System.Drawing.Size(704, 441);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.lbPassword);
            this.Controls.Add(this.lbUser);
            this.Controls.Add(this.btReturnLogin);
            this.Controls.Add(this.btConfirmSignUp);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbUser);
            this.Controls.Add(this.pictureLogo);
            this.Controls.Add(this.lbSignUp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormSignUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hora do Remédio";
            this.Load += new System.EventHandler(this.FormSignUp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btReturnLogin;
        private System.Windows.Forms.Button btConfirmSignUp;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbUser;
        private System.Windows.Forms.PictureBox pictureLogo;
        private System.Windows.Forms.Label lbSignUp;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.Label lbUser;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.TextBox tbName;
    }
}