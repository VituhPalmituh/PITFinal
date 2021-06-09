using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HoraDoRemedio
{
    public class ScheduleInformation
    {
        private int idSchedule;
        private int idUser;
        private string daySchedule;
        private string monthSchedule;
        private string yearSchedule;
        private string hourSchedule;
        private string minuteSchedule;
        private string descriptionSchedule;

        public int IdSchedule { get => idSchedule; set => idSchedule = value; }
        public int IdUser { get => idUser; set => idUser = value; }
        public string DaySchedule { get => daySchedule; set => daySchedule = value; }
        public string MonthSchedule { get => monthSchedule; set => monthSchedule = value; }
        public string YearSchedule { get => yearSchedule; set => yearSchedule = value; }
        public string HourSchedule { get => hourSchedule; set => hourSchedule = value; }
        public string MinuteSchedule { get => minuteSchedule; set => minuteSchedule = value; }
        public string DescriptionSchedule { get => descriptionSchedule; set => descriptionSchedule = value; }

        public DataTable GetAll(int idUser)
        {
            var connection = new DB();
            string selectSchedules = $"SELECT * FROM ScheduleInformation WHERE IdUser = {idUser}";
            var result = connection.ExecutarSelect(selectSchedules);

            return result;
        }

        public string SaveSchedule(string description, int day, int month, int year, int hour, int minute)
        {
            string resultSchedule = "";

            if (description == "")
            {
                resultSchedule = "Incorrect";
            }
            else
            {
                var connection = new DB();
                var values = new Dictionary<string, object>();
                values.Add("IdUser", idUser);
                values.Add("DaySchedule", day);
                values.Add("MonthSchedule", month);
                values.Add("YearSchedule", year);
                values.Add("HourSchedule", hour);
                values.Add("MinuteSchedule", minute);
                values.Add("DescriptionSchedule", description);

                var result = connection.ExecutarInsert(values, "ScheduleInformation");

                if (result == "")
                {
                    resultSchedule = "Correct";
                }
                else
                {
                    resultSchedule = "Incorrect";
                }
            }

            return resultSchedule;
        }

        public string RemoveSchedule(CheckedListBox.CheckedItemCollection clbSchedule)
        {
            var connection = new DB();
            int scheduleCount = clbSchedule.Count;
            string result = "";

            for (int i = 0; i < scheduleCount; i++)
            {
                var checkedItem = clbSchedule[i];
                var idSchedule = Convert.ToInt32(checkedItem.ToString().Split('-')[0].Replace("Agenda", ""));
                string deleteSchedule = $"IdSchedule = {idSchedule}";

                string resultSchedule = connection.ExecutarExcluir("ScheduleInformation", deleteSchedule);
                if (resultSchedule == "")
                {
                    result = "Correct";
                }
                else
                {
                    result = "Incorrect";
                }
            }

            return result;
        }
    }
}
