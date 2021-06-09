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
    public partial class FormSchedule : Form
    {
        private int idUser;

        public int IdUser { get => idUser; set => idUser = value; }

        public FormSchedule()
        {
            InitializeComponent();
        }

        private void FormSchedule_Load(object sender, EventArgs e)
        {
            RefreshSchedules();
        }

        private void RefreshSchedules()
        {
            clbSchedule.Items.Clear();
            ScheduleInformation schedule = new ScheduleInformation();
            DataTable result = schedule.GetAll(idUser);

            for (int i = 0; i < result.Rows.Count; i++)
            {
                clbSchedule.Items.Add($"Agenda {Convert.ToInt32(result.Rows[i]["IdSchedule"])} - {Convert.ToInt32(result.Rows[i]["DaySchedule"])}/{Convert.ToInt32(result.Rows[i]["MonthSchedule"])}/{Convert.ToInt32(result.Rows[i]["YearSchedule"])} - {Convert.ToInt32(result.Rows[i]["HourSchedule"])}:{Convert.ToInt32(result.Rows[i]["MinuteSchedule"])} - {result.Rows[i]["DescriptionSchedule"]}");
            }
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
            ScheduleInformation schedule = new ScheduleInformation();
            schedule.IdUser = idUser;
            string result = schedule.SaveSchedule(tbDescription.Text, Convert.ToInt32(numDay.Value), Convert.ToInt32(numMonth.Value), Convert.ToInt32(numYear.Value), Convert.ToInt32(numHour.Value), Convert.ToInt32(numMinute.Value));

            if (result == "Correct")
            {
                int contadorAgenda = clbSchedule.Items.Count + 1;
                clbSchedule.Items.Add($"Agenda {contadorAgenda} - {numDay.Value}/{numMonth.Value}/{numYear.Value} - {numHour.Value}:{numMinute.Value} - {tbDescription.Text}");
                RefreshSchedules();
                MessageBox.Show("Agenda adicionado.");

                JobManager.Initialize(new SchedulingTaks(Convert.ToInt32(numHour.Value), Convert.ToInt32(numMinute.Value), tbDescription.Text, Convert.ToInt32(numDay.Value), Convert.ToInt32(numMonth.Value), Convert.ToInt32(numYear.Value)));
            }
            else
            {
                MessageBox.Show("Erro ao adicionar agenda.");
            }
        }

        private void numYear_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btRemove_Click(object sender, EventArgs e)
        {
            ScheduleInformation schedule = new ScheduleInformation();
            var checkedBoxes = clbSchedule.CheckedItems;
            string result = schedule.RemoveSchedule(checkedBoxes);

            if (result == "Correct")
            {
                clbSchedule.Items.Remove(clbSchedule.CheckedItems);
                RefreshSchedules();
                MessageBox.Show("Agenda removida.");
            }
            else
            {
                MessageBox.Show("Erro ao tentar remover agenda.");
            }
        }
    }
}
