
namespace HoraDoRemedio
{
    partial class FormAlarm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAlarm));
            this.pMenu = new System.Windows.Forms.Panel();
            this.btDisconnect = new System.Windows.Forms.Button();
            this.btMenu = new System.Windows.Forms.Button();
            this.btScheduleMenu = new System.Windows.Forms.Button();
            this.btAlarmMenu = new System.Windows.Forms.Button();
            this.pbImageHome = new System.Windows.Forms.PictureBox();
            this.lbAlarm = new System.Windows.Forms.Label();
            this.lbPills = new System.Windows.Forms.Label();
            this.tbMedicine = new System.Windows.Forms.TextBox();
            this.lbHour = new System.Windows.Forms.Label();
            this.numHour = new System.Windows.Forms.NumericUpDown();
            this.numMinute = new System.Windows.Forms.NumericUpDown();
            this.lbMinute = new System.Windows.Forms.Label();
            this.cbMon = new System.Windows.Forms.CheckBox();
            this.cbTue = new System.Windows.Forms.CheckBox();
            this.cbWed = new System.Windows.Forms.CheckBox();
            this.cbThu = new System.Windows.Forms.CheckBox();
            this.cbFri = new System.Windows.Forms.CheckBox();
            this.cbSat = new System.Windows.Forms.CheckBox();
            this.cbSun = new System.Windows.Forms.CheckBox();
            this.lbDays = new System.Windows.Forms.Label();
            this.btSaveAlarm = new System.Windows.Forms.Button();
            this.clbAlarm = new System.Windows.Forms.CheckedListBox();
            this.btRemove = new System.Windows.Forms.Button();
            this.lbReadyAlarms = new System.Windows.Forms.Label();
            this.pMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImageHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinute)).BeginInit();
            this.SuspendLayout();
            // 
            // pMenu
            // 
            this.pMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(226)))), ((int)(((byte)(223)))));
            this.pMenu.Controls.Add(this.btDisconnect);
            this.pMenu.Controls.Add(this.btMenu);
            this.pMenu.Controls.Add(this.btScheduleMenu);
            this.pMenu.Controls.Add(this.btAlarmMenu);
            this.pMenu.Controls.Add(this.pbImageHome);
            this.pMenu.Location = new System.Drawing.Point(1, 1);
            this.pMenu.Name = "pMenu";
            this.pMenu.Size = new System.Drawing.Size(150, 444);
            this.pMenu.TabIndex = 1;
            // 
            // btDisconnect
            // 
            this.btDisconnect.FlatAppearance.BorderSize = 0;
            this.btDisconnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDisconnect.Font = new System.Drawing.Font("KoHo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDisconnect.Image = global::HoraDoRemedio.Properties.Resources.logoutLogo;
            this.btDisconnect.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btDisconnect.Location = new System.Drawing.Point(0, 397);
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
            this.btMenu.TabIndex = 34;
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
            // lbAlarm
            // 
            this.lbAlarm.AutoSize = true;
            this.lbAlarm.BackColor = System.Drawing.Color.Transparent;
            this.lbAlarm.Font = new System.Drawing.Font("KoHo", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAlarm.Location = new System.Drawing.Point(157, 9);
            this.lbAlarm.Name = "lbAlarm";
            this.lbAlarm.Size = new System.Drawing.Size(187, 80);
            this.lbAlarm.TabIndex = 3;
            this.lbAlarm.Text = "Alarme";
            // 
            // lbPills
            // 
            this.lbPills.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbPills.AutoSize = true;
            this.lbPills.BackColor = System.Drawing.Color.Transparent;
            this.lbPills.Font = new System.Drawing.Font("KoHo", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPills.Location = new System.Drawing.Point(165, 104);
            this.lbPills.Name = "lbPills";
            this.lbPills.Size = new System.Drawing.Size(101, 35);
            this.lbPills.TabIndex = 16;
            this.lbPills.Text = "Remédio:";
            this.lbPills.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbMedicine
            // 
            this.tbMedicine.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMedicine.Location = new System.Drawing.Point(171, 142);
            this.tbMedicine.Name = "tbMedicine";
            this.tbMedicine.Size = new System.Drawing.Size(219, 26);
            this.tbMedicine.TabIndex = 15;
            this.tbMedicine.TextChanged += new System.EventHandler(this.tbUserSignUp_TextChanged);
            // 
            // lbHour
            // 
            this.lbHour.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbHour.AutoSize = true;
            this.lbHour.BackColor = System.Drawing.Color.Transparent;
            this.lbHour.Font = new System.Drawing.Font("KoHo", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHour.Location = new System.Drawing.Point(185, 176);
            this.lbHour.Name = "lbHour";
            this.lbHour.Size = new System.Drawing.Size(66, 35);
            this.lbHour.TabIndex = 19;
            this.lbHour.Text = "Hora:";
            this.lbHour.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numHour
            // 
            this.numHour.Font = new System.Drawing.Font("KoHo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numHour.Location = new System.Drawing.Point(191, 214);
            this.numHour.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.numHour.Name = "numHour";
            this.numHour.Size = new System.Drawing.Size(80, 28);
            this.numHour.TabIndex = 20;
            // 
            // numMinute
            // 
            this.numMinute.Font = new System.Drawing.Font("KoHo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numMinute.Location = new System.Drawing.Point(283, 214);
            this.numMinute.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numMinute.Name = "numMinute";
            this.numMinute.Size = new System.Drawing.Size(82, 28);
            this.numMinute.TabIndex = 21;
            // 
            // lbMinute
            // 
            this.lbMinute.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbMinute.AutoSize = true;
            this.lbMinute.BackColor = System.Drawing.Color.Transparent;
            this.lbMinute.Font = new System.Drawing.Font("KoHo", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMinute.Location = new System.Drawing.Point(277, 176);
            this.lbMinute.Name = "lbMinute";
            this.lbMinute.Size = new System.Drawing.Size(88, 35);
            this.lbMinute.TabIndex = 22;
            this.lbMinute.Text = "Minuto:";
            this.lbMinute.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbMon
            // 
            this.cbMon.AutoSize = true;
            this.cbMon.Font = new System.Drawing.Font("KoHo", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMon.Location = new System.Drawing.Point(174, 304);
            this.cbMon.Name = "cbMon";
            this.cbMon.Size = new System.Drawing.Size(51, 25);
            this.cbMon.TabIndex = 23;
            this.cbMon.Text = "Seg";
            this.cbMon.UseVisualStyleBackColor = true;
            // 
            // cbTue
            // 
            this.cbTue.AutoSize = true;
            this.cbTue.Font = new System.Drawing.Font("KoHo", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTue.Location = new System.Drawing.Point(231, 304);
            this.cbTue.Name = "cbTue";
            this.cbTue.Size = new System.Drawing.Size(46, 25);
            this.cbTue.TabIndex = 24;
            this.cbTue.Text = "Ter";
            this.cbTue.UseVisualStyleBackColor = true;
            // 
            // cbWed
            // 
            this.cbWed.AutoSize = true;
            this.cbWed.Font = new System.Drawing.Font("KoHo", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbWed.Location = new System.Drawing.Point(283, 304);
            this.cbWed.Name = "cbWed";
            this.cbWed.Size = new System.Drawing.Size(52, 25);
            this.cbWed.TabIndex = 25;
            this.cbWed.Text = "Qua";
            this.cbWed.UseVisualStyleBackColor = true;
            // 
            // cbThu
            // 
            this.cbThu.AutoSize = true;
            this.cbThu.Font = new System.Drawing.Font("KoHo", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbThu.Location = new System.Drawing.Point(341, 304);
            this.cbThu.Name = "cbThu";
            this.cbThu.Size = new System.Drawing.Size(49, 25);
            this.cbThu.TabIndex = 26;
            this.cbThu.Text = "Qui";
            this.cbThu.UseVisualStyleBackColor = true;
            // 
            // cbFri
            // 
            this.cbFri.AutoSize = true;
            this.cbFri.Font = new System.Drawing.Font("KoHo", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFri.Location = new System.Drawing.Point(204, 335);
            this.cbFri.Name = "cbFri";
            this.cbFri.Size = new System.Drawing.Size(49, 25);
            this.cbFri.TabIndex = 27;
            this.cbFri.Text = "Sex";
            this.cbFri.UseVisualStyleBackColor = true;
            // 
            // cbSat
            // 
            this.cbSat.AutoSize = true;
            this.cbSat.Font = new System.Drawing.Font("KoHo", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSat.Location = new System.Drawing.Point(259, 335);
            this.cbSat.Name = "cbSat";
            this.cbSat.Size = new System.Drawing.Size(52, 25);
            this.cbSat.TabIndex = 28;
            this.cbSat.Text = "Sab";
            this.cbSat.UseVisualStyleBackColor = true;
            // 
            // cbSun
            // 
            this.cbSun.AutoSize = true;
            this.cbSun.Font = new System.Drawing.Font("KoHo", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSun.Location = new System.Drawing.Point(317, 335);
            this.cbSun.Name = "cbSun";
            this.cbSun.Size = new System.Drawing.Size(56, 25);
            this.cbSun.TabIndex = 29;
            this.cbSun.Text = "Dom";
            this.cbSun.UseVisualStyleBackColor = true;
            // 
            // lbDays
            // 
            this.lbDays.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbDays.AutoSize = true;
            this.lbDays.BackColor = System.Drawing.Color.Transparent;
            this.lbDays.Font = new System.Drawing.Font("KoHo", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDays.Location = new System.Drawing.Point(164, 260);
            this.lbDays.Name = "lbDays";
            this.lbDays.Size = new System.Drawing.Size(63, 35);
            this.lbDays.TabIndex = 30;
            this.lbDays.Text = "Dias:";
            this.lbDays.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btSaveAlarm
            // 
            this.btSaveAlarm.BackColor = System.Drawing.Color.White;
            this.btSaveAlarm.Font = new System.Drawing.Font("KoHo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSaveAlarm.Location = new System.Drawing.Point(199, 390);
            this.btSaveAlarm.Name = "btSaveAlarm";
            this.btSaveAlarm.Size = new System.Drawing.Size(174, 30);
            this.btSaveAlarm.TabIndex = 31;
            this.btSaveAlarm.Text = "Salvar";
            this.btSaveAlarm.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btSaveAlarm.UseVisualStyleBackColor = false;
            this.btSaveAlarm.Click += new System.EventHandler(this.btSave_Click);
            // 
            // clbAlarm
            // 
            this.clbAlarm.Font = new System.Drawing.Font("KoHo", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clbAlarm.FormattingEnabled = true;
            this.clbAlarm.Location = new System.Drawing.Point(396, 142);
            this.clbAlarm.Name = "clbAlarm";
            this.clbAlarm.Size = new System.Drawing.Size(296, 213);
            this.clbAlarm.TabIndex = 32;
            this.clbAlarm.SelectedIndexChanged += new System.EventHandler(this.clbAlarm_SelectedIndexChanged);
            // 
            // btRemove
            // 
            this.btRemove.BackColor = System.Drawing.Color.White;
            this.btRemove.Font = new System.Drawing.Font("KoHo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRemove.Location = new System.Drawing.Point(501, 390);
            this.btRemove.Name = "btRemove";
            this.btRemove.Size = new System.Drawing.Size(191, 30);
            this.btRemove.TabIndex = 33;
            this.btRemove.Text = "Remover";
            this.btRemove.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btRemove.UseVisualStyleBackColor = false;
            this.btRemove.Click += new System.EventHandler(this.btRemove_Click);
            // 
            // lbReadyAlarms
            // 
            this.lbReadyAlarms.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbReadyAlarms.AutoSize = true;
            this.lbReadyAlarms.BackColor = System.Drawing.Color.Transparent;
            this.lbReadyAlarms.Font = new System.Drawing.Font("KoHo", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbReadyAlarms.Location = new System.Drawing.Point(390, 104);
            this.lbReadyAlarms.Name = "lbReadyAlarms";
            this.lbReadyAlarms.Size = new System.Drawing.Size(178, 35);
            this.lbReadyAlarms.TabIndex = 34;
            this.lbReadyAlarms.Text = "Alarmes Prontos:";
            this.lbReadyAlarms.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormAlarm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HoraDoRemedio.Properties.Resources.BackGroundFeito;
            this.ClientSize = new System.Drawing.Size(704, 441);
            this.Controls.Add(this.lbReadyAlarms);
            this.Controls.Add(this.btRemove);
            this.Controls.Add(this.clbAlarm);
            this.Controls.Add(this.btSaveAlarm);
            this.Controls.Add(this.lbDays);
            this.Controls.Add(this.cbSun);
            this.Controls.Add(this.cbSat);
            this.Controls.Add(this.cbFri);
            this.Controls.Add(this.cbThu);
            this.Controls.Add(this.cbWed);
            this.Controls.Add(this.cbTue);
            this.Controls.Add(this.cbMon);
            this.Controls.Add(this.lbMinute);
            this.Controls.Add(this.numMinute);
            this.Controls.Add(this.numHour);
            this.Controls.Add(this.lbHour);
            this.Controls.Add(this.lbPills);
            this.Controls.Add(this.tbMedicine);
            this.Controls.Add(this.lbAlarm);
            this.Controls.Add(this.pMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAlarm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hora do Remédio";
            this.Load += new System.EventHandler(this.FormAlarm_Load);
            this.pMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbImageHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinute)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pMenu;
        private System.Windows.Forms.Button btScheduleMenu;
        private System.Windows.Forms.Button btAlarmMenu;
        private System.Windows.Forms.PictureBox pbImageHome;
        private System.Windows.Forms.Label lbAlarm;
        private System.Windows.Forms.Label lbPills;
        private System.Windows.Forms.TextBox tbMedicine;
        private System.Windows.Forms.Label lbHour;
        private System.Windows.Forms.NumericUpDown numHour;
        private System.Windows.Forms.NumericUpDown numMinute;
        private System.Windows.Forms.Label lbMinute;
        private System.Windows.Forms.CheckBox cbMon;
        private System.Windows.Forms.CheckBox cbTue;
        private System.Windows.Forms.CheckBox cbWed;
        private System.Windows.Forms.CheckBox cbThu;
        private System.Windows.Forms.CheckBox cbFri;
        private System.Windows.Forms.CheckBox cbSat;
        private System.Windows.Forms.CheckBox cbSun;
        private System.Windows.Forms.Label lbDays;
        private System.Windows.Forms.Button btSaveAlarm;
        private System.Windows.Forms.CheckedListBox clbAlarm;
        private System.Windows.Forms.Button btRemove;
        private System.Windows.Forms.Button btMenu;
        private System.Windows.Forms.Label lbReadyAlarms;
        private System.Windows.Forms.Button btDisconnect;
    }
}