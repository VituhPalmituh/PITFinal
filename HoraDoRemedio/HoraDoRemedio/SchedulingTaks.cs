using FluentScheduler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoraDoRemedio
{
    public class SchedulingTaks : Registry
    {
        public SchedulingTaks(int hour, int minute, string medicine, string days)
        {
            Schedule(new SchedulingAlarms(medicine, days)).NonReentrant().ToRunOnceAt(hour, minute).AndEvery(1).Days();
        }

        public SchedulingTaks(int hour, int minute, string description, int day, int month, int year)
        {
            string dateSchedule = year.ToString() + "-" + month.ToString("D2") + "-" + day.ToString("D2");
            DateTime date = Convert.ToDateTime(dateSchedule);
            Schedule(new SchedulingAlarms(description, date)).NonReentrant().ToRunOnceAt(hour, minute).AndEvery(1).Days();
        }
    }
}
