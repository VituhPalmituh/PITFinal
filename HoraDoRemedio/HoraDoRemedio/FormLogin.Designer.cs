
namespace HoraDoRemedio
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.lbNameApp = new System.Windows.Forms.Label();
            this.pictureLogo = new System.Windows.Forms.PictureBox();
            this.lbUser = new System.Windows.Forms.Label();
            this.lbPassword = new System.Windows.Forms.Label();
            this.tbUser = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.btLogin = new System.Windows.Forms.Button();
            this.btSignup = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lbNameApp
            // 
            this.lbNameApp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbNameApp.AutoSize = true;
            this.lbNameApp.BackColor = System.Drawing.Color.Transparent;
            this.lbNameApp.Font = new System.Drawing.Font("KoHo", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNameApp.Location = new System.Drawing.Point(168, 9);
            this.lbNameApp.Name = "lbNameApp";
            this.lbNameApp.Size = new System.Drawing.Size(404, 80);
            this.lbNameApp.TabIndex = 0;
            this.lbNameApp.Text = "Hora do Remédio";
            this.lbNameApp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureLogo
            // 
            this.pictureLogo.BackColor = System.Drawing.Color.Transparent;
            this.pictureLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureLogo.Image")));
            this.pictureLogo.Location = new System.Drawing.Point(12, 12);
            this.pictureLogo.Name = "pictureLogo";
            this.pictureLogo.Size = new System.Drawing.Size(150, 150);
            this.pictureLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureLogo.TabIndex = 1;
            this.pictureLogo.TabStop = false;
            // 
            // lbUser
            // 
            this.lbUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbUser.AutoSize = true;
            this.lbUser.BackColor = System.Drawing.Color.Transparent;
            this.lbUser.Font = new System.Drawing.Font("KoHo", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUser.Location = new System.Drawing.Point(191, 174);
            this.lbUser.Name = "lbUser";
            this.lbUser.Size = new System.Drawing.Size(94, 35);
            this.lbUser.TabIndex = 2;
            this.lbUser.Text = "Usuário:";
            this.lbUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbPassword
            // 
            this.lbPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbPassword.AutoSize = true;
            this.lbPassword.BackColor = System.Drawing.Color.Transparent;
            this.lbPassword.Font = new System.Drawing.Font("KoHo", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPassword.Location = new System.Drawing.Point(206, 206);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(79, 35);
            this.lbPassword.TabIndex = 3;
            this.lbPassword.Text = "Senha:";
            this.lbPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbUser
            // 
            this.tbUser.Font = new System.Drawing.Font("KoHo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUser.Location = new System.Drawing.Point(291, 180);
            this.tbUser.Name = "tbUser";
            this.tbUser.Size = new System.Drawing.Size(174, 28);
            this.tbUser.TabIndex = 1;
            this.tbUser.TextChanged += new System.EventHandler(this.tbUser_TextChanged);
            // 
            // tbPassword
            // 
            this.tbPassword.Font = new System.Drawing.Font("KoHo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPassword.Location = new System.Drawing.Point(291, 212);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(174, 28);
            this.tbPassword.TabIndex = 2;
            // 
            // btLogin
            // 
            this.btLogin.BackColor = System.Drawing.Color.White;
            this.btLogin.Font = new System.Drawing.Font("KoHo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLogin.Location = new System.Drawing.Point(291, 244);
            this.btLogin.Name = "btLogin";
            this.btLogin.Size = new System.Drawing.Size(174, 30);
            this.btLogin.TabIndex = 3;
            this.btLogin.Text = "Conectar";
            this.btLogin.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btLogin.UseVisualStyleBackColor = false;
            this.btLogin.Click += new System.EventHandler(this.btLogin_Click);
            // 
            // btSignup
            // 
            this.btSignup.BackColor = System.Drawing.Color.White;
            this.btSignup.Font = new System.Drawing.Font("KoHo", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSignup.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btSignup.Location = new System.Drawing.Point(291, 280);
            this.btSignup.Name = "btSignup";
            this.btSignup.Size = new System.Drawing.Size(174, 29);
            this.btSignup.TabIndex = 4;
            this.btSignup.Text = "Não tem uma conta? Criar";
            this.btSignup.UseVisualStyleBackColor = false;
            this.btSignup.Click += new System.EventHandler(this.btSignup_Click);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::HoraDoRemedio.Properties.Resources.BackGroundFeito;
            this.ClientSize = new System.Drawing.Size(704, 441);
            this.Controls.Add(this.btSignup);
            this.Controls.Add(this.btLogin);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbUser);
            this.Controls.Add(this.lbPassword);
            this.Controls.Add(this.lbUser);
            this.Controls.Add(this.pictureLogo);
            this.Controls.Add(this.lbNameApp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hora do Remédio";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNameApp;
        private System.Windows.Forms.PictureBox pictureLogo;
        private System.Windows.Forms.Label lbUser;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.TextBox tbUser;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Button btLogin;
        private System.Windows.Forms.Button btSignup;
    }
}

