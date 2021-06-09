using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HoraDoRemedio
{
    public partial class FormMenu : Form
    {
        private int idUser;
        private SoundPlayer alarmSound;

        public int IdUser { get => idUser; set => idUser = value; }

        public FormMenu()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.lbClock.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormMenu menu = new FormMenu();
            menu.IdUser = idUser;
            this.Hide();
            menu.ShowDialog();
            this.Close();
        }

        private void btAlarm_Click(object sender, EventArgs e)
        {
            FormAlarm alarm = new FormAlarm();
            alarm.IdUser = idUser;
            this.Hide();
            alarm.ShowDialog();
            this.Close();
        }

        private void btSchedule_Click(object sender, EventArgs e)
        {
            FormSchedule schedule = new FormSchedule();
            schedule.IdUser = idUser;
            this.Hide();
            schedule.ShowDialog();
            this.Close();
        }

        private void btLogout_Click(object sender, EventArgs e)
        {
            FormLogin login = new FormLogin();
            this.Hide();
            login.ShowDialog();
            this.Close();
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
