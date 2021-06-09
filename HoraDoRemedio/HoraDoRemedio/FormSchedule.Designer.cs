
namespace HoraDoRemedio
{
    partial class FormSchedule
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSchedule));
            this.pMenu = new System.Windows.Forms.Panel();
            this.btDisconnect = new System.Windows.Forms.Button();
            this.btMenu = new System.Windows.Forms.Button();
            this.btScheduleMenu = new System.Windows.Forms.Button();
            this.btAlarmMenu = new System.Windows.Forms.Button();
            this.pbImageHome = new System.Windows.Forms.PictureBox();
            this.lbSchedule = new System.Windows.Forms.Label();
            this.lbMinute = new System.Windows.Forms.Label();
            this.numMinute = new System.Windows.Forms.NumericUpDown();
            this.numHour = new System.Windows.Forms.NumericUpDown();
            this.lbHour = new System.Windows.Forms.Label();
            this.lbDescription = new System.Windows.Forms.Label();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.lbMonth = new System.Windows.Forms.Label();
            this.lbDay = new System.Windows.Forms.Label();
            this.lbYear = new System.Windows.Forms.Label();
            this.numYear = new System.Windows.Forms.NumericUpDown();
            this.numMonth = new System.Windows.Forms.NumericUpDown();
            this.numDay = new System.Windows.Forms.NumericUpDown();
            this.lbReadyAlarms = new System.Windows.Forms.Label();
            this.btRemove = new System.Windows.Forms.Button();
            this.clbSchedule = new System.Windows.Forms.CheckedListBox();
            this.btSave = new System.Windows.Forms.Button();
            this.pMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImageHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMonth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDay)).BeginInit();
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
            this.pMenu.Location = new System.Drawing.Point(0, 0);
            this.pMenu.Name = "pMenu";
            this.pMenu.Size = new System.Drawing.Size(150, 444);
            this.pMenu.TabIndex = 4;
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
            this.btDisconnect.TabIndex = 35;
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
            // lbSchedule
            // 
            this.lbSchedule.AutoSize = true;
            this.lbSchedule.BackColor = System.Drawing.Color.Transparent;
            this.lbSchedule.Font = new System.Drawing.Font("KoHo", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSchedule.Location = new System.Drawing.Point(156, 8);
            this.lbSchedule.Name = "lbSchedule";
            this.lbSchedule.Size = new System.Drawing.Size(199, 80);
            this.lbSchedule.TabIndex = 5;
            this.lbSchedule.Text = "Agenda";
            // 
            // lbMinute
            // 
            this.lbMinute.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbMinute.AutoSize = true;
            this.lbMinute.BackColor = System.Drawing.Color.Transparent;
            this.lbMinute.Font = new System.Drawing.Font("KoHo", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMinute.Location = new System.Drawing.Point(270, 262);
            this.lbMinute.Name = "lbMinute";
            this.lbMinute.Size = new System.Drawing.Size(88, 35);
            this.lbMinute.TabIndex = 28;
            this.lbMinute.Text = "Minuto:";
            this.lbMinute.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numMinute
            // 
            this.numMinute.Font = new System.Drawing.Font("KoHo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numMinute.Location = new System.Drawing.Point(276, 300);
            this.numMinute.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numMinute.Name = "numMinute";
            this.numMinute.Size = new System.Drawing.Size(82, 28);
            this.numMinute.TabIndex = 27;
            // 
            // numHour
            // 
            this.numHour.Font = new System.Drawing.Font("KoHo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numHour.Location = new System.Drawing.Point(184, 300);
            this.numHour.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.numHour.Name = "numHour";
            this.numHour.Size = new System.Drawing.Size(80, 28);
            this.numHour.TabIndex = 26;
            // 
            // lbHour
            // 
            this.lbHour.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbHour.AutoSize = true;
            this.lbHour.BackColor = System.Drawing.Color.Transparent;
            this.lbHour.Font = new System.Drawing.Font("KoHo", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHour.Location = new System.Drawing.Point(178, 262);
            this.lbHour.Name = "lbHour";
            this.lbHour.Size = new System.Drawing.Size(66, 35);
            this.lbHour.TabIndex = 25;
            this.lbHour.Text = "Hora:";
            this.lbHour.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbDescription
            // 
            this.lbDescription.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbDescription.AutoSize = true;
            this.lbDescription.BackColor = System.Drawing.Color.Transparent;
            this.lbDescription.Font = new System.Drawing.Font("KoHo", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDescription.Location = new System.Drawing.Point(164, 110);
            this.lbDescription.Name = "lbDescription";
            this.lbDescription.Size = new System.Drawing.Size(113, 35);
            this.lbDescription.TabIndex = 24;
            this.lbDescription.Text = "Descrição:";
            this.lbDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbDescription
            // 
            this.tbDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDescription.Location = new System.Drawing.Point(170, 148);
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(219, 26);
            this.tbDescription.TabIndex = 23;
            // 
            // lbMonth
            // 
            this.lbMonth.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbMonth.AutoSize = true;
            this.lbMonth.BackColor = System.Drawing.Color.Transparent;
            this.lbMonth.Font = new System.Drawing.Font("KoHo", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMonth.Location = new System.Drawing.Point(232, 181);
            this.lbMonth.Name = "lbMonth";
            this.lbMonth.Size = new System.Drawing.Size(59, 35);
            this.lbMonth.TabIndex = 32;
            this.lbMonth.Text = "Mês:";
            this.lbMonth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbDay
            // 
            this.lbDay.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbDay.AutoSize = true;
            this.lbDay.BackColor = System.Drawing.Color.Transparent;
            this.lbDay.Font = new System.Drawing.Font("KoHo", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDay.Location = new System.Drawing.Point(164, 181);
            this.lbDay.Name = "lbDay";
            this.lbDay.Size = new System.Drawing.Size(53, 35);
            this.lbDay.TabIndex = 29;
            this.lbDay.Text = "Dia:";
            this.lbDay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbYear
            // 
            this.lbYear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbYear.AutoSize = true;
            this.lbYear.BackColor = System.Drawing.Color.Transparent;
            this.lbYear.Font = new System.Drawing.Font("KoHo", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbYear.Location = new System.Drawing.Point(300, 181);
            this.lbYear.Name = "lbYear";
            this.lbYear.Size = new System.Drawing.Size(58, 35);
            this.lbYear.TabIndex = 34;
            this.lbYear.Text = "Ano:";
            this.lbYear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numYear
            // 
            this.numYear.Font = new System.Drawing.Font("KoHo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numYear.Location = new System.Drawing.Point(306, 219);
            this.numYear.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numYear.Minimum = new decimal(new int[] {
            2021,
            0,
            0,
            0});
            this.numYear.Name = "numYear";
            this.numYear.Size = new System.Drawing.Size(62, 28);
            this.numYear.TabIndex = 36;
            this.numYear.Value = new decimal(new int[] {
            2021,
            0,
            0,
            0});
            this.numYear.ValueChanged += new System.EventHandler(this.numYear_ValueChanged);
            // 
            // numMonth
            // 
            this.numMonth.Font = new System.Drawing.Font("KoHo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numMonth.Location = new System.Drawing.Point(238, 219);
            this.numMonth.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numMonth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numMonth.Name = "numMonth";
            this.numMonth.Size = new System.Drawing.Size(62, 28);
            this.numMonth.TabIndex = 37;
            this.numMonth.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numDay
            // 
            this.numDay.Font = new System.Drawing.Font("KoHo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numDay.Location = new System.Drawing.Point(170, 219);
            this.numDay.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.numDay.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numDay.Name = "numDay";
            this.numDay.Size = new System.Drawing.Size(62, 28);
            this.numDay.TabIndex = 38;
            this.numDay.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lbReadyAlarms
            // 
            this.lbReadyAlarms.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbReadyAlarms.AutoSize = true;
            this.lbReadyAlarms.BackColor = System.Drawing.Color.Transparent;
            this.lbReadyAlarms.Font = new System.Drawing.Font("KoHo", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbReadyAlarms.Location = new System.Drawing.Point(389, 110);
            this.lbReadyAlarms.Name = "lbReadyAlarms";
            this.lbReadyAlarms.Size = new System.Drawing.Size(181, 35);
            this.lbReadyAlarms.TabIndex = 42;
            this.lbReadyAlarms.Text = "Agendas prontas:";
            this.lbReadyAlarms.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btRemove
            // 
            this.btRemove.BackColor = System.Drawing.Color.White;
            this.btRemove.Font = new System.Drawing.Font("KoHo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRemove.Location = new System.Drawing.Point(480, 358);
            this.btRemove.Name = "btRemove";
            this.btRemove.Size = new System.Drawing.Size(191, 30);
            this.btRemove.TabIndex = 41;
            this.btRemove.Text = "Remover";
            this.btRemove.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btRemove.UseVisualStyleBackColor = false;
            this.btRemove.Click += new System.EventHandler(this.btRemove_Click);
            // 
            // clbSchedule
            // 
            this.clbSchedule.Font = new System.Drawing.Font("KoHo", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clbSchedule.FormattingEnabled = true;
            this.clbSchedule.Location = new System.Drawing.Point(395, 148);
            this.clbSchedule.Name = "clbSchedule";
            this.clbSchedule.Size = new System.Drawing.Size(276, 194);
            this.clbSchedule.TabIndex = 40;
            // 
            // btSave
            // 
            this.btSave.BackColor = System.Drawing.Color.White;
            this.btSave.Font = new System.Drawing.Font("KoHo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSave.Location = new System.Drawing.Point(184, 358);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(174, 30);
            this.btSave.TabIndex = 39;
            this.btSave.Text = "Salvar";
            this.btSave.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btSave.UseVisualStyleBackColor = false;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // FormSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HoraDoRemedio.Properties.Resources.BackGroundFeito;
            this.ClientSize = new System.Drawing.Size(704, 441);
            this.Controls.Add(this.lbReadyAlarms);
            this.Controls.Add(this.btRemove);
            this.Controls.Add(this.clbSchedule);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.numDay);
            this.Controls.Add(this.numMonth);
            this.Controls.Add(this.numYear);
            this.Controls.Add(this.lbYear);
            this.Controls.Add(this.lbMonth);
            this.Controls.Add(this.lbDay);
            this.Controls.Add(this.lbMinute);
            this.Controls.Add(this.numMinute);
            this.Controls.Add(this.numHour);
            this.Controls.Add(this.lbHour);
            this.Controls.Add(this.lbDescription);
            this.Controls.Add(this.tbDescription);
            this.Controls.Add(this.pMenu);
            this.Controls.Add(this.lbSchedule);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormSchedule";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hora do Remédio";
            this.Load += new System.EventHandler(this.FormSchedule_Load);
            this.pMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbImageHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMonth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pMenu;
        private System.Windows.Forms.Button btMenu;
        private System.Windows.Forms.Button btScheduleMenu;
        private System.Windows.Forms.Button btAlarmMenu;
        private System.Windows.Forms.PictureBox pbImageHome;
        private System.Windows.Forms.Label lbSchedule;
        private System.Windows.Forms.Label lbMinute;
        private System.Windows.Forms.NumericUpDown numMinute;
        private System.Windows.Forms.NumericUpDown numHour;
        private System.Windows.Forms.Label lbHour;
        private System.Windows.Forms.Label lbDescription;
        private System.Windows.Forms.TextBox tbDescription;
        private System.Windows.Forms.Label lbMonth;
        private System.Windows.Forms.Label lbDay;
        private System.Windows.Forms.Label lbYear;
        private System.Windows.Forms.NumericUpDown numYear;
        private System.Windows.Forms.NumericUpDown numMonth;
        private System.Windows.Forms.NumericUpDown numDay;
        private System.Windows.Forms.Label lbReadyAlarms;
        private System.Windows.Forms.Button btRemove;
        private System.Windows.Forms.CheckedListBox clbSchedule;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Button btDisconnect;
    }
}