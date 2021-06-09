using FluentScheduler;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HoraDoRemedio
{
    public class AlarmInformation
    {
        private int idAlarm;
        private int idUser;
        private int hourAlarm;
        private int minuteAlarm;
        private string medicineAlarm;
        private string weekAlarm;

        public int IdAlarm { get => idAlarm; set => idAlarm = value; }
        public int IdUser { get => idUser; set => idUser = value; }
        public int HourAlarm { get => hourAlarm; set => hourAlarm = value; }
        public int MinuteAlarm { get => minuteAlarm; set => minuteAlarm = value; }
        public string MedicineAlarm { get => medicineAlarm; set => medicineAlarm = value; }
        public string WeekAlarm { get => weekAlarm; set => weekAlarm = value; }

        public DataTable GetAll(int idUser)
        {
            var connection = new DB();
            string selectedAlarms = $"SELECT * FROM AlarmInformation WHERE IdUser = {idUser}";
            var result = connection.ExecutarSelect(selectedAlarms);

            return result;
        }
        public string SaveAlarm(string medicine, int hour, int minute, string week)
        {
            string result = "";

            if (medicine == "")
            {
                result = "Empty";
            }
            else
            {
                var connection = new DB();
                var values = new Dictionary<string, object>();
                values.Add("IdUser", idUser);
                values.Add("HourAlarm", hour);
                values.Add("MinuteAlarm", minute);
                values.Add("MedicineAlarm", medicine);
                values.Add("WeekAlarm", week);

                var resultTabel = connection.ExecutarInsert(values, "AlarmInformation");

                if (resultTabel == "")
                {
                    result = "Correct";
                }
            }
            return result;
        }

        public string RemoveAlarm(CheckedListBox.CheckedItemCollection clbAlarm)
        {
            var connection = new DB();
            int alarmCount = clbAlarm.Count;
            string resultRemove = "";

            for (int i = 0; i < alarmCount; i++)
            {
                var checkedItem = clbAlarm[i];
                var idAlarm = Convert.ToInt32(checkedItem.ToString().Split('-')[0].Replace("Alarme", ""));
                string deleteAlarm = $"IdAlarm = {idAlarm}";

                string result = connection.ExecutarExcluir("AlarmInformation", deleteAlarm);

                if (result == "")
                {
                    resultRemove = "Correct";
                }
                else
                {
                    resultRemove = "Incorrect";
                }
            }

            return resultRemove;
        }
    }
}

