
namespace HoraDoRemedio
{
    partial class FormMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            this.pMenu = new System.Windows.Forms.Panel();
            this.btLogout = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btSchedule = new System.Windows.Forms.Button();
            this.btAlarm = new System.Windows.Forms.Button();
            this.pbImageHome = new System.Windows.Forms.PictureBox();
            this.lbHome = new System.Windows.Forms.Label();
            this.lbClock = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btDisconnect = new System.Windows.Forms.Button();
            this.btMenu = new System.Windows.Forms.Button();
            this.btScheduleMenu = new System.Windows.Forms.Button();
            this.btAlarmMenu = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImageHome)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pMenu
            // 
            this.pMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(226)))), ((int)(((byte)(223)))));
            this.pMenu.Controls.Add(this.btLogout);
            this.pMenu.Controls.Add(this.button1);
            this.pMenu.Controls.Add(this.btSchedule);
            this.pMenu.Controls.Add(this.btAlarm);
            this.pMenu.Controls.Add(this.pbImageHome);
            this.pMenu.Location = new System.Drawing.Point(3, 0);
            this.pMenu.Name = "pMenu";
            this.pMenu.Size = new System.Drawing.Size(150, 444);
            this.pMenu.TabIndex = 0;
            // 
            // btLogout
            // 
            this.btLogout.FlatAppearance.BorderSize = 0;
            this.btLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btLogout.Font = new System.Drawing.Font("KoHo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLogout.Image = global::HoraDoRemedio.Properties.Resources.logoutLogo;
            this.btLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btLogout.Location = new System.Drawing.Point(0, 398);
            this.btLogout.Name = "btLogout";
            this.btLogout.Size = new System.Drawing.Size(150, 31);
            this.btLogout.TabIndex = 36;
            this.btLogout.Text = "Desconectar";
            this.btLogout.UseVisualStyleBackColor = true;
            this.btLogout.Click += new System.EventHandler(this.btLogout_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("KoHo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::HoraDoRemedio.Properties.Resources.Logomenu;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(0, 132);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 31);
            this.button1.TabIndex = 3;
            this.button1.Text = "Menu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btSchedule
            // 
            this.btSchedule.FlatAppearance.BorderSize = 0;
            this.btSchedule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSchedule.Font = new System.Drawing.Font("KoHo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSchedule.Image = global::HoraDoRemedio.Properties.Resources.calendarButton;
            this.btSchedule.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btSchedule.Location = new System.Drawing.Point(0, 206);
            this.btSchedule.Name = "btSchedule";
            this.btSchedule.Size = new System.Drawing.Size(150, 31);
            this.btSchedule.TabIndex = 2;
            this.btSchedule.Text = "Agendas";
            this.btSchedule.UseVisualStyleBackColor = true;
            this.btSchedule.Click += new System.EventHandler(this.btSchedule_Click);
            // 
            // btAlarm
            // 
            this.btAlarm.FlatAppearance.BorderSize = 0;
            this.btAlarm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAlarm.Font = new System.Drawing.Font("KoHo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAlarm.Image = global::HoraDoRemedio.Properties.Resources.LogoButtonMaior;
            this.btAlarm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btAlarm.Location = new System.Drawing.Point(0, 169);
            this.btAlarm.Name = "btAlarm";
            this.btAlarm.Size = new System.Drawing.Size(150, 31);
            this.btAlarm.TabIndex = 0;
            this.btAlarm.Text = "Alarmes";
            this.btAlarm.UseVisualStyleBackColor = true;
            this.btAlarm.Click += new System.EventHandler(this.btAlarm_Click);
            // 
            // pbImageHome
            // 
            this.pbImageHome.BackColor = System.Drawing.Color.Transparent;
            this.pbImageHome.Image = global::HoraDoRemedio.Properties.Resources.Hora_do_Remédio___Logo;
            this.pbImageHome.Location = new System.Drawing.Point(3, 3);
            this.pbImageHome.Name = "pbImageHome";
            this.pbImageHome.Size = new System.Drawing.Size(144, 123);
            this.pbImageHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbImageHome.TabIndex = 1;
            this.pbImageHome.TabStop = false;
            // 
            // lbHome
            // 
            this.lbHome.AutoSize = true;
            this.lbHome.BackColor = System.Drawing.Color.Transparent;
            this.lbHome.Font = new System.Drawing.Font("KoHo", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHome.Location = new System.Drawing.Point(159, 9);
            this.lbHome.Name = "lbHome";
            this.lbHome.Size = new System.Drawing.Size(157, 80);
            this.lbHome.TabIndex = 2;
            this.lbHome.Text = "Home";
            // 
            // lbClock
            // 
            this.lbClock.AutoSize = true;
            this.lbClock.BackColor = System.Drawing.Color.Transparent;
            this.lbClock.Font = new System.Drawing.Font("KoHo", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbClock.Location = new System.Drawing.Point(373, 19);
            this.lbClock.Name = "lbClock";
            this.lbClock.Size = new System.Drawing.Size(319, 107);
            this.lbClock.TabIndex = 3;
            this.lbClock.Text = "00:00:00";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(226)))), ((int)(((byte)(223)))));
            this.panel1.Controls.Add(this.btDisconnect);
            this.panel1.Controls.Add(this.btMenu);
            this.panel1.Controls.Add(this.btScheduleMenu);
            this.panel1.Controls.Add(this.btAlarmMenu);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(150, 444);
            this.panel1.TabIndex = 0;
            // 
            // btDisconnect
            // 
            this.btDisconnect.FlatAppearance.BorderSize = 0;
            this.btDisconnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDisconnect.Font = new System.Drawing.Font("KoHo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDisconnect.Image = global::HoraDoRemedio.Properties.Resources.logoutLogo;
            this.btDisconnect.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btDisconnect.Location = new System.Drawing.Point(0, 398);
            this.btDisconnect.Name = "btDisconnect";
            this.btDisconnect.Size = new System.Drawing.Size(150, 31);
            this.btDisconnect.TabIndex = 36;
            this.btDisconnect.Text = "Desconectar";
            this.btDisconnect.UseVisualStyleBackColor = true;
            this.btDisconnect.Click += new System.EventHandler(this.btLogout_Click);
            // 
            // btMenu
            // 
            this.btMenu.FlatAppearance.BorderSize = 0;
            this.btMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btMenu.Font = new System.Drawing.Font("KoHo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMenu.Image = global::HoraDoRemedio.Properties.Resources.Logomenu;
            this.btMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btMenu.Location = new System.Drawing.Point(0, 132);
            this.btMenu.Name = "btMenu";
            this.btMenu.Size = new System.Drawing.Size(150, 31);
            this.btMenu.TabIndex = 3;
            this.btMenu.Text = "Menu";
            this.btMenu.UseVisualStyleBackColor = true;
            this.btMenu.Click += new System.EventHandler(this.button1_Click);
            // 
            // btScheduleMenu
            // 
            this.btScheduleMenu.FlatAppearance.BorderSize = 0;
            this.btScheduleMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btScheduleMenu.Font = new System.Drawing.Font("KoHo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btScheduleMenu.Image = global::HoraDoRemedio.Properties.Resources.calendarButton;
            this.btScheduleMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btScheduleMenu.Location = new System.Drawing.Point(0, 206);
            this.btScheduleMenu.Name = "btScheduleMenu";
            this.btScheduleMenu.Size = new System.Drawing.Size(150, 31);
            this.btScheduleMenu.TabIndex = 2;
            this.btScheduleMenu.Text = "Agendas";
            this.btScheduleMenu.UseVisualStyleBackColor = true;
            this.btScheduleMenu.Click += new System.EventHandler(this.btSchedule_Click);
            // 
            // btAlarmMenu
            // 
            this.btAlarmMenu.FlatAppearance.BorderSize = 0;
            this.btAlarmMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAlarmMenu.Font = new System.Drawing.Font("KoHo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAlarmMenu.Image = global::HoraDoRemedio.Properties.Resources.LogoButtonMaior;
            this.btAlarmMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btAlarmMenu.Location = new System.Drawing.Point(0, 169);
            this.btAlarmMenu.Name = "btAlarmMenu";
            this.btAlarmMenu.Size = new System.Drawing.Size(150, 31);
            this.btAlarmMenu.TabIndex = 0;
            this.btAlarmMenu.Text = "Alarmes";
            this.btAlarmMenu.UseVisualStyleBackColor = true;
            this.btAlarmMenu.Click += new System.EventHandler(this.btAlarm_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::HoraDoRemedio.Properties.Resources.Hora_do_Remédio___Logo;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(144, 123);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::HoraDoRemedio.Properties.Resources.BackGroundFeito;
            this.ClientSize = new System.Drawing.Size(704, 441);
            this.Controls.Add(this.lbClock);
            this.Controls.Add(this.lbHome);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pMenu);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hora do Remédio";
            this.Load += new System.EventHandler(this.FormMenu_Load);
            this.pMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbImageHome)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pMenu;
        private System.Windows.Forms.PictureBox pbImageHome;
        private System.Windows.Forms.Label lbHome;
        private System.Windows.Forms.Button btAlarm;
        private System.Windows.Forms.Button btSchedule;
        private System.Windows.Forms.Label lbClock;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btLogout;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btDisconnect;
        private System.Windows.Forms.Button btMenu;
        private System.Windows.Forms.Button btScheduleMenu;
        private System.Windows.Forms.Button btAlarmMenu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
    }
}