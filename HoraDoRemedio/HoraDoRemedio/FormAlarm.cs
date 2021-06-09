using FluentScheduler;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HoraDoRemedio
{
    public partial class FormAlarm : Form
    {
        private int idUser;

        public int IdUser { get => idUser; set => idUser = value; }

        public FormAlarm()
        {
            InitializeComponent();
        }

        private void tbUserSignUp_TextChanged(object sender, EventArgs e)
        {

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

        private void btSave_Click(object sender, EventArgs e)
        {
            AlarmInformation alarm = new AlarmInformation();
            string selectedDays = SelectedDays();

            alarm.IdUser = idUser;
            string result = alarm.SaveAlarm(tbMedicine.Text, Convert.ToInt32(numHour.Value), Convert.ToInt32(numMinute.Value), selectedDays);

            if (result == "Correct")
            {
                RefreshAlarms();
                MessageBox.Show("Alarme adicionado.");

                JobManager.Initialize(new SchedulingTaks(Convert.ToInt32(numHour.Value), Convert.ToInt32(numMinute.Value), tbMedicine.Text, selectedDays));
            }
        }

        private void FormAlarm_Load(object sender, EventArgs e)
        {
            RefreshAlarms();
        }

        private void RefreshAlarms()
        {
            clbAlarm.Items.Clear();
            AlarmInformation alarm = new AlarmInformation();
            DataTable result = alarm.GetAll(idUser);

            for (int i = 0; i < result.Rows.Count; i++)
            {
                clbAlarm.Items.Add($"Alarme {Convert.ToInt32(result.Rows[i]["IdAlarm"])} - {result.Rows[i]["MedicineAlarm"]} - {Convert.ToInt32(result.Rows[i]["HourAlarm"])}:{Convert.ToInt32(result.Rows[i]["MinuteAlarm"])} - {result.Rows[i]["WeekAlarm"]}");
            }
        }

        private void btRemove_Click(object sender, EventArgs e)
        {
            AlarmInformation alarm = new AlarmInformation();
            var checkedBoxes = clbAlarm.CheckedItems;
            string result = alarm.RemoveAlarm(checkedBoxes);

            if (result == "Correct")
            {
                clbAlarm.Items.Remove(clbAlarm.CheckedItems);
                RefreshAlarms();
                MessageBox.Show("Alarme removido.");
            }
            else
            {
                MessageBox.Show("Erro ao remover o alarme.");
            }
        }

        public string SelectedDays()
        {
            List<string> days = new List<string>();
            string daysCheck = "";

            if (cbMon.Checked)
            {
                days.Add("Monday");
            }
            if (cbTue.Checked)
            {
                days.Add("Tuesday");
            }
            if (cbWed.Checked)
            {
                days.Add("Wednesday");
            }
            if (cbThu.Checked)
            {
                days.Add("Thursday");
            }
            if (cbFri.Checked)
            {
                days.Add("Friday");
            }
            if (cbSat.Checked)
            {
                days.Add("Saturday");
            }
            if (cbSun.Checked)
            {
                days.Add("Sunday");
            }

            foreach (var item in days)
            {
                daysCheck += item.ToString() + "/";
            }

            return daysCheck;
        }

        private void clbAlarm_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
